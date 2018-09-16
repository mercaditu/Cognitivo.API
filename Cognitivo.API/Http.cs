using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace Cognitivo.API
{
    public static class Http
    {
        public static string API { get; set; }
        public static string Url { get; set; }

        public static HttpWebResponse Post(String Uri, object Json)
        {
            var webAddr = Url + Uri;

            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Authorization", "Bearer " + API);

            using (var requestStream = httpWebRequest.GetRequestStream())
            {
                using (var streamWriter = new StreamWriter(requestStream))
                {
                    streamWriter.Write(Json);
                    streamWriter.Flush();
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            return httpResponse;
        }

        public static object Get(String Uri)
        {
            object Json = new object();
            return Json; 
        }
    }
}
