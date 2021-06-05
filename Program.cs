using System;
using System.Threading.Tasks;

namespace UnifiProtect_ClipSaver
{
    class Program
    {
        static readonly string uniFiProtectDeviceAddress = "";
        static readonly string uniFiUsername = "";
        static readonly string uniFiPassword = "";
        static readonly string[] cameraIds = new string[]
        {
            //CameraIds to save clips from
        };

        static async Task Main(string[] args)
        {
            var dates = new DateTime[]
            {
                //24 hour time based helper to simplify multiple times.
                GetDate(2021, 6, 7, 08, 09), //May fail depending on your recorders capacity
            };

            var service = new UniFiCameraRecordingExtractionService(uniFiProtectDeviceAddress);
            await service.Login(uniFiUsername, uniFiPassword);
            foreach (var date in dates)
            {
                Console.WriteLine($"Getting clips for {date}...");
                await service.GetClips(cameraIds, date, TimeSpan.FromMinutes(10));
            }

            await service.Logout();
        }

        private static DateTime GetDate(int year, int month, int day, int hour, int minute)
        {
            return new DateTime(year, month, day, hour, minute, 00, DateTimeKind.Local);
        }
    }
}
