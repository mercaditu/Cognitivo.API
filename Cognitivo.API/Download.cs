using System;
using System.Web;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

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
        public List<Models.Item> Item(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Item> items = new List<Models.Item>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/item");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    items = JsonConvert.DeserializeObject(result) as List<Models.Item>;
                }
            }
            return items;
            //return new List<Models.Sales>();
        }

        /// <summary>
        /// Sales the specified CompanySlug and Timespan.
        /// </summary>
        /// <returns>The sales.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Timespan">Timespan.</param>
        public List<Models.Account> Account(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Account> accounts = new List<Models.Account>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/account");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    accounts = JsonConvert.DeserializeObject(result) as List<Models.Account>;
                }
            }
            return accounts;
            //return new List<Models.Sales>();
        }

        public List<Models.Company> Company(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Company> companys = new List<Models.Company>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/account");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    companys = JsonConvert.DeserializeObject(result) as List<Models.Company>;
                }
            }
            return companys;
            //return new List<Models.Sales>();
        }

        public List<Models.Customer> Customer(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Customer> customers = new List<Models.Customer>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/account");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    customers = JsonConvert.DeserializeObject(result) as List<Models.Customer>;
                }
            }
            return customers;
            //return new List<Models.Sales>();
        }
        public List<Models.ItemCategory> ItemCategory(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.ItemCategory> ItemCategorys = new List<Models.ItemCategory>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/itemcategory");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    ItemCategorys = JsonConvert.DeserializeObject(result) as List<Models.ItemCategory>;
                }
            }
            return ItemCategorys;
            //return new List<Models.Sales>();
        }
        public List<Models.ItemPriceList> ItemPriceList(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.ItemPriceList> ItemPriceList = new List<Models.ItemPriceList>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/itempricelist");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    ItemPriceList = JsonConvert.DeserializeObject(result) as List<Models.ItemPriceList>;
                }
            }
            return ItemPriceList;
            //return new List<Models.Sales>();
        }
        public List<Models.Location> Location(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Location> Locations = new List<Models.Location>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/location");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Locations = JsonConvert.DeserializeObject(result) as List<Models.Location>;
                }
            }
            return Locations;
            //return new List<Models.Sales>();
        }
        public List<Models.PaymentContract> PaymentContract(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.PaymentContract> PaymentContracts = new List<Models.PaymentContract>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/paymentcontract");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    PaymentContracts = JsonConvert.DeserializeObject(result) as List<Models.PaymentContract>;
                }
            }
            return PaymentContracts;
            //return new List<Models.Sales>();
        }
        public List<Models.PaymentContractDetail> PaymentContractDetail(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.PaymentContractDetail> PaymentContractDetails = new List<Models.PaymentContractDetail>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/paymentcontractdetail");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    PaymentContractDetails = JsonConvert.DeserializeObject(result) as List<Models.PaymentContractDetail>;
                }
            }
            return PaymentContractDetails;
            //return new List<Models.Sales>();
        }
        public List<Models.PaymentType> PaymentType(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.PaymentType> paymenttypes = new List<Models.PaymentType>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/paymentype");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    paymenttypes = JsonConvert.DeserializeObject(result) as List<Models.PaymentType>;
                }
            }
            return paymenttypes;
            //return new List<Models.Sales>();
        }
        public List<Models.PointOfSale> PointOfSale(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.PointOfSale> pointofsales = new List<Models.PointOfSale>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/pointofsale");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    pointofsales = JsonConvert.DeserializeObject(result) as List<Models.PointOfSale>;
                }
            }
            return pointofsales;
            //return new List<Models.Sales>();
        }
        public List<Models.Range> Range(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Range> ranges = new List<Models.Range>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/range");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    ranges = JsonConvert.DeserializeObject(result) as List<Models.Range>;
                }
            }
            return ranges;
            //return new List<Models.Sales>();
        }
        public List<Models.Supplier> Supplier(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Supplier> suppliers = new List<Models.Supplier>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/supplier");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    suppliers = JsonConvert.DeserializeObject(result) as List<Models.Supplier>;
                }
            }
            return suppliers;
            //return new List<Models.Sales>();
        }
        public List<Models.User> Users(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.User> users = new List<Models.User>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/user");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    users = JsonConvert.DeserializeObject(result) as List<Models.User>;
                }
            }
            return users;
            //return new List<Models.Sales>();
        }
        public List<Models.Vat> Vat(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            List<Models.Vat> vats = new List<Models.Vat>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/vat");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    vats = JsonConvert.DeserializeObject(result) as List<Models.Vat>;
                }
            }
            return vats;
            //return new List<Models.Sales>();
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
                    sales = JsonConvert.DeserializeObject(result) as List<Models.Sales>;
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
            List<Models.Purchase> Purchases = new List<Models.Purchase>();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/purchase/");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Purchases = JsonConvert.DeserializeObject(result) as List<Models.Purchase>;
                }
            }
            return Purchases;
        }

       
    }
}
