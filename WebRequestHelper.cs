using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace UnifiProtect_ClipSaver
{
    public static class WebRequestHelper
    {
        public static string UserAgent { get; set; }

        static WebRequestHelper()
        {
            UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";
        }

        static CookieContainer _cookies;
        static public CookieContainer Cookies
        {
            get
            {
                if (_cookies == null)
                {
                    _cookies = new CookieContainer();
                }
                return _cookies;
            }
        }

        public static void ClearCookies()
        {
            _cookies = null;
        }

        public static HttpClient GetClient()
        {
            var handler = new HttpClientHandler()
            {
                CookieContainer = Cookies,
                UseCookies = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            //TODO: Decide for yourself and environment if ignoring cert issues is ok.
            handler.ServerCertificateCustomValidationCallback = (request, cert, chain, errors) =>
            {
                return true;
            };

            var client = new HttpClient(handler);

            client.DefaultRequestHeaders.UserAgent.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", WebRequestHelper.UserAgent);
            client.DefaultRequestHeaders.ExpectContinue = false;
            client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.5");

            return client;
        }
    }
}
