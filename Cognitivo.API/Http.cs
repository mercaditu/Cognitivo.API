using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

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

        /// <summary>
        /// This method will first upload your data, and download whats in the server.
        /// </summary>
        /// <returns>The sync.</returns>
        /// <param name="Uri">URI.</param>
        /// <param name="MyData">My data.</param>
        public static HttpWebResponse Sync(String Uri, object MyData)
        {
            object json;
            var serializer = new DataContractJsonSerializer(MyData.GetType());

            using (var stream = new MemoryStream())
            {
                serializer.WriteObject(stream, MyData);
                using (StreamReader sr = new StreamReader(stream)) { json = sr.ReadToEnd(); }
            }

            return Post(Uri, json);
        }
    }
}
