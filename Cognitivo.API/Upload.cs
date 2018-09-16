using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Cognitivo.API
{
    /// <summary>
    /// Class that contains necesary functions to upload and sync your data with <i>cognitivo.in</i>
    /// </summary>
    public class Upload
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cognitivo.API.Upload"/> class.
        /// </summary>
        /// <param name="API_Key">API key.</param>
        /// <param name="SyncWith">Sync with.</param>
        public Upload(string API_Key, Enums.SyncWith SyncWith = Enums.SyncWith.Production)
        {
            Http.API = API_Key;
            Http.Url = (SyncWith == Enums.SyncWith.Production) ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/";
        }

        /// <summary>
        /// Transactional the specified CompanySlug and Data.
        /// </summary>
        /// <returns>The transactional.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Data">Data.</param>
        public Data.Transactional Transactional(string CompanySlug, Data.Transactional Data)
        {
            HttpWebResponse httpResponse = Http.SyncObject(CompanySlug + "/upload/transactional/", Data);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(Data.GetType());
                    Data = service.ReadObject(stream) as Data.Transactional;
                    stream.Close();
                }
            }

            return Data;
        }

        /// <summary>
        /// Sales the specified CompanySlug and ListOfSales.
        /// </summary>
        /// <returns>The sales.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="ListOfSales">List of sales.</param>
        public List<Models.Sales> Sales(string CompanySlug, List<Models.Sales> ListOfSales)
        {
            HttpWebResponse httpResponse = Http.SyncObject(CompanySlug + "/upload/sales/", ListOfSales);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(ListOfSales.GetType());
                    ListOfSales = service.ReadObject(stream) as List<Models.Sales>;
                    stream.Close();
                }
            }

            return ListOfSales;
        }

        /// <summary>
        /// Purchases the specified CompanySlug and ListOfPurchases.
        /// </summary>
        /// <returns>The purchases.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="ListOfPurchases">List of purchases.</param>
        public List<Models.Purchase> Purchases(string CompanySlug, List<Models.Purchase> ListOfPurchases)
        {
            HttpWebResponse httpResponse = Http.SyncObject(CompanySlug + "/upload/sales/", ListOfPurchases);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(ListOfPurchases.GetType());
                    ListOfPurchases = service.ReadObject(stream) as List<Models.Purchase>;
                    stream.Close();
                }
            }

            return ListOfPurchases;
        }
    }
}
