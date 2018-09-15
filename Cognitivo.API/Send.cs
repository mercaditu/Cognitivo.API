using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

using System.Text;

namespace Cognitivo.API
{
    public class Send
    {

        /// <summary>
        /// Send to.
        /// </summary>
        public enum SendTo
        {
            /// <summary>
            /// The production.
            /// </summary>
            Production,
            /// <summary>
            /// The playground.
            /// </summary>
            Playground
        }
        private string API { get; set; }

        private string Url { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DebeHaber.API.Send"/> class.
        /// </summary>
        /// <param name="SendTo">Choose if you want to send your data to production, or playground.</param>
        /// <param name="API_Key">Place your API Key generated from the site here. Remember that production and playground keys are different.</param>
        public Send(SendTo SendTo, string API_Key)
        {
            API = API_Key;
            Url = SendTo == SendTo.Production ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/PQR";
        }

        private HttpWebResponse SendData(String Uri,object Json)
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
        /// Items.
        /// </summary>
        /// <returns>List of Items with information of successful sync.</returns>
        /// <param name="Items">List of Items.</param>
        public object Item(List<Models.Item> Items)
        {
            object json;
            var serializer = new DataContractJsonSerializer(Items.GetType());
            using (var stream = new MemoryStream())
            {
                serializer.WriteObject(stream, Items);
                using (StreamReader sr = new StreamReader(stream))
                {
                    json=sr.ReadToEnd();
                }
            }

            HttpWebResponse httpResponse = SendData("/sync/item", json);
            List<Models.ResponseItem> ResponseItems = new List<Models.ResponseItem>();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stram = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(ResponseItems.GetType());
                    ResponseItems = service.ReadObject(stram) as List<Models.ResponseItem>;
                    stram.Close();

                }

            }
            return ResponseItems;
        }

        /// <summary>
        /// Items.
        /// </summary>
        /// <returns>List of Items with information of successful sync.</returns>
        /// <param name="Items">List of Items.</param>
        public List<Models.ResponseCustomer> Customer(List<Models.Customer> Items)
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Models.Customer));
            ser.WriteObject(ms, Items);
            byte[] json = ms.ToArray();
            ms.Close();
            HttpWebResponse httpResponse = SendData("/sync/customer", json);
            List<Models.ResponseCustomer> ResponseCustomers = new List<Models.ResponseCustomer>();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stram = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(ResponseCustomers.GetType());
                    ResponseCustomers = service.ReadObject(stram) as List<Models.ResponseCustomer>;
                    ms.Close();

                }

            }
            return ResponseCustomers;
        }

        /// <summary>
        /// Invoices the specified Sales.
        /// </summary>
        /// <returns>List of Invoices with information of successful sync.</returns>
        /// <param name="Invoices">List of Invoices which can include Sales.</param>
        public List<Models.ResponseInvoice> Customer(List<Models.Invoice> Invoices)
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Models.Customer));
            ser.WriteObject(ms, Invoices);
            byte[] json = ms.ToArray();
            ms.Close();
            HttpWebResponse httpResponse = SendData("/sync/transaction", json);
            List<Models.ResponseInvoice> ResponseInvoices = new List<Models.ResponseInvoice>();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stram = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(ResponseInvoices.GetType());
                    ResponseInvoices = service.ReadObject(stram) as List<Models.ResponseInvoice>;
                    ms.Close();

                }

            }
            return ResponseInvoices;
        }
    }
}
