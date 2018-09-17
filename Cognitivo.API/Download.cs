﻿using System;
using System.Web;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace Cognitivo.API
{
    public class Download
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cognitivo.API.Download"/> class.
        /// </summary>
        /// <param name="API_Key">API key.</param>
        /// <param name="SyncWith">Select if you want to sync with production server, or just the playground to test..</param>
        public Download(string API_Key, Enums.SyncWith SyncWith = Enums.SyncWith.Production)
        {
            Http.API = API_Key;
            Http.Url = (SyncWith == Enums.SyncWith.Production) ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/";
        }

        /// <summary>
        /// Base the specified CompanySlug.
        /// </summary>
        /// <returns>All Base Tables (Company, Item Lists, Price Lists, Customers, Suppliers, Contracts, Vats, and more.)</returns>
        /// <param name="CompanySlug">Company slug.</param>
        public Data.Base Base(string CompanySlug)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            //return Http.Post(CompanySlug + "/download/base/") as Data.Base;
           return new Data.Base();
        }

        /// <summary>
        /// Sales the specified CompanySlug and Timespan.
        /// </summary>
        /// <returns>The sales.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Timespan">Timespan.</param>
        public List<Models.Sales> Sales (string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Sales> sales = new List<Models.Sales>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/sales/");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stram = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(sales.GetType());
                    sales = service.ReadObject(stram) as List<Models.Sales>;
                    stram.Close();
                }
            }
            return sales;
            //return new List<Models.Sales>();
        }

        /// <summary>
        /// Purchases the specified CompanySlug and Timespan.
        /// </summary>
        /// <returns>The purchases.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Timespan">Timespan.</param>
        public List<Models.Purchase> Purchases(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            //return Http.Get(CompanySlug + "/download/purchases/") as List<Models.Purchase>;
            return new List<Models.Purchase>();
        }
    }
}
