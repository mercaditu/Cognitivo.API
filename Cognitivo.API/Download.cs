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
            if (SyncWith == Enums.SyncWith.Production)
            {
                Http.Url = "https://www.cognitivo.com/api/";
            }
            else if (SyncWith == Enums.SyncWith.Playground)
            {
                Http.Url = "http://phplaravel-181496-694025.cloudwaysapps.com/api/";
            }
            else
            {
                Http.Url = "http://localhost:8000/api/";
            }

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
        public List<Models.Item> Item(string CompanySlug,Enums.TimeSpan Timespan)
        {
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.ItemData items = new Models.ItemData();
                 HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/item/1");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                items = JsonConvert.DeserializeObject<Models.ItemData>(result);
            }
            return items.data;
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
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.AccountData accounts = new Models.AccountData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/account/1");
           
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                accounts = JsonConvert.DeserializeObject<Models.AccountData>(result);

            }
            return accounts.data;
            //return new List<Models.Sales>();
        }

        public List<Models.Company> Company(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.CompanyData companys = new Models.CompanyData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/company");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    companys = JsonConvert.DeserializeObject<Models.CompanyData>(result); 
                }

            }
            return companys.data;
            //return new List<Models.Sales>();
        }

        public List<Models.Customer> Customer(string CompanySlug, Enums.TimeSpan Timespan)
        {
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.CustomerData customers = new Models.CustomerData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/customer");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();

                }
                customers = JsonConvert.DeserializeObject<Models.CustomerData>(result);
            }
            return customers.data;
            //return new List<Models.Sales>();
        }
        public List<Models.ItemCategory> ItemCategory(string CompanySlug, Enums.TimeSpan Timespan)
        {
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.ItemCategoryData ItemCategorys = new Models.ItemCategoryData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/itemcategory/1");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    
                }
                ItemCategorys = JsonConvert.DeserializeObject<Models.ItemCategoryData>(result);
            }
            return ItemCategorys.data;
            //return new List<Models.Sales>();
        }

        public List<Models.Location> Location(string CompanySlug, Enums.TimeSpan Timespan)
        {
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.LocationData Locations = new Models.LocationData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/location/1");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    
                }
                Locations = JsonConvert.DeserializeObject<Models.LocationData>(result);
            }
            return Locations.data;
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
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.RangeData ranges = new Models.RangeData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/range");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                   result = streamReader.ReadToEnd();
                    
                }
                ranges = JsonConvert.DeserializeObject<Models.RangeData>(result);
            }
            return ranges.data;
            //return new List<Models.Sales>();
        }
        public List<Models.Inventory> Inventory(string CompanySlug, Enums.TimeSpan Timespan)
        {
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.InventoryData inventorys = new Models.InventoryData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/inventory");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();

                }
                inventorys = JsonConvert.DeserializeObject<Models.InventoryData>(result);
            }
            return inventorys.data;
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
            string result = "";
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            Models.VatData vats = new Models.VatData();
            HttpWebResponse httpResponse = Http.Get(CompanySlug + "/download/saletax/1");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    
                }
                vats = JsonConvert.DeserializeObject<Models.VatData>(result);
            }
            return vats.data;
            //return new List<Models.Sales>();
        }






        /// <summary>
        /// Sales the specified CompanySlug and Timespan.
        /// </summary>
        /// <returns>The sales.</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Timespan">Timespan.</param>
        public List<Models.Sales> Sales(string CompanySlug, Enums.TimeSpan Timespan)
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
