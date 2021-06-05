using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace UnifiProtect_ClipSaver
{
    public class UniFiCameraRecordingExtractionService
    {
        public static class URLs
        {
            public static string Login(string host) => $"https://{host}/api/auth/login";
            public static string Bootstrap(string host) => $"https://{host}/proxy/protect/api/bootstrap";
            public static string Download(string host, string camera, long start, long end, string fileName) => $"https://{host}/proxy/protect/api/video/export?camera={camera}&channel=0&start={start}&end={end}&filename={fileName}";
            public static string Logout(string host) => $"https://{host}/api/auth/logout";
        }

        private string uniFiProtectDeviceAddress;
        private HttpClient client;
        private IEnumerable<Camera> cameras;

        public UniFiCameraRecordingExtractionService(string uniFiProtectDeviceAddress)
        {
            this.uniFiProtectDeviceAddress = uniFiProtectDeviceAddress;
        }

        public async Task Login(string username, string password)
        {
            client = WebRequestHelper.GetClient();
            cameras = await Login(client, uniFiProtectDeviceAddress, username, password);
        }

        public async Task GetClips(string[] cameraIds, DateTime start, TimeSpan length)
        {
            var pairedCameraResults = cameras.Where(c => cameraIds.Contains(c.id)).Select(c => new MiniCameraDetails() { CameraId = c.id, CameraName = c.name });

            await GetClipsInternal(client, uniFiProtectDeviceAddress, pairedCameraResults, start, length);
        }

        internal async Task GetClipsInternal(HttpClient client, string uniFiProtectDevice, IEnumerable<MiniCameraDetails> cameras, DateTime start, TimeSpan length)
        {
            var startUt = UnixTime.GetUnixTimeMillis(start.ToUniversalTime());
            var endUt = UnixTime.GetUnixTimeMillis(start.ToUniversalTime().Add(length));
            foreach (var camera in cameras)
            {
                string fileName = $"{start.ToString("s").Replace(":", ".")} - {camera.CameraName}.mp4";
                var dlVideo = await client.GetAsync(URLs.Download(uniFiProtectDevice, camera.CameraId, startUt, endUt, fileName));
                dlVideo.EnsureSuccessStatusCode(); //Failure here usually indicates that the clip is outside of the bounds of what is available

                using (var stream = dlVideo.Content.ReadAsStream())
                {
                    using (var br = new BinaryReader(stream))
                    {
                        var bytes = br.ReadBytes((int)stream.Length);
                        File.WriteAllBytes(fileName, bytes); //TODO: Find better place
                    }
                }
            }
        }

        public async Task Logout()
        {
            await client.PostAsync(URLs.Logout(uniFiProtectDeviceAddress), null);
        }

        static public async Task<IEnumerable<Camera>> Login(HttpClient client, string host, string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    throw new ArgumentNullException("username");
                }
                else if (string.IsNullOrEmpty(password))
                {
                    throw new ArgumentNullException("password");
                }

                Console.WriteLine("Login: Setting credentials...");
                var content = new FormUrlEncodedContent(new[]
                       {
                       new KeyValuePair<string, string>("username", username),
                       new KeyValuePair<string, string>("password", password),
                   });

                GC.Collect();

                Console.WriteLine("Login: Awaiting posting...");
                var result = await client.PostAsync(URLs.Login(host), content);
                result.EnsureSuccessStatusCode();

                Console.WriteLine("Login: Reading response...");
                await result.Content.ReadAsStringAsync();
                result.EnsureSuccessStatusCode();

                Console.WriteLine("Login: Deserializing...");
                var getResult = await client.GetAsync(URLs.Bootstrap(host));
                var bootStrapResult = await getResult.Content.ReadAsStringAsync();

                BootstrapResponse bootstrap = JsonConvert.DeserializeObject<BootstrapResponse>(bootStrapResult);
                return bootstrap.cameras;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
