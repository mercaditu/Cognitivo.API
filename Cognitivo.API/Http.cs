using Newtonsoft.Json;
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

        /// <summary>
        /// Get the specified Uri.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="Uri">URI.</param>
        public static HttpWebResponse Get(String Uri)
        {
            var webAddr = Url + Uri;

            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Authorization", "Bearer " + API);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            return httpResponse;
        }

        private static HttpWebResponse Post(String Uri, object Json)
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
        internal static HttpWebResponse SyncObject(String Uri, object MyData)
        {
            var json = JsonConvert.SerializeObject(MyData);
            return Post(Uri, json);


        }

        /// <summary>
        /// Syncs the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="Uri">URI.</param>
        /// <param name="MyList">My list.</param>
        internal static HttpWebResponse SyncList(String Uri, List<object> MyList)
        {
            var json = JsonConvert.SerializeObject(MyList);
            HttpWebResponse httpResponse = Post(Uri, json);
            return httpResponse;
        }
    }
}
