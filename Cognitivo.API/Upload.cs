using Cognitivo.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            if (SyncWith == Enums.SyncWith.Production)
            {
                Http.Url = "http://www.bazaar.social/api/";
            }
            else if (SyncWith == Enums.SyncWith.Playground)
            {
                Http.Url = "https://www.test.cognitivo.in/api/";
            }
            else
            {
                Http.Url = "http://localhost:8000/api/";
            }

        }

        /// <summary>
        /// Base the specified CompanySlug and Data.
        /// </summary>
        /// <returns>The base..</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Data">Data.</param>
        public List<Sales> Transaction(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response =Http.SyncList(CompanySlug + "/upload/transaction", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            SalesData MyList = JsonConvert.DeserializeObject<SalesData>(result);
            return MyList.data;


        }
        //public List<ItemMovement> ItemMovements(string CompanySlug, List<object> Data)
        //{
        //    string result = Http.SyncList(CompanySlug + "/upload/itemmovements", Data);
        //    List<ItemMovement> MyList = JsonConvert.DeserializeObject<List<ItemMovement>>(result);
        //    return MyList;
        //}
        //public List<AccountMovement> AccountMovements(string CompanySlug, List<object> Data)
        //{
        //    string result = Http.SyncList(CompanySlug + "/upload/accountmovements", Data);
        //    List<AccountMovement> MyList = JsonConvert.DeserializeObject<List<AccountMovement>>(result);
        //    return MyList;

        //}


        public List<Item> Item(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/item", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.ItemData MyList = new ItemData();
            MyList = JsonConvert.DeserializeObject<Models.ItemData>(result);

            return MyList.data;



        }
        public void ItemImage(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/itemImage", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }


         



        }
        public List<PointOfSale> Terminal(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/terminal", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.PointOfSaleData MyList = new PointOfSaleData();
            MyList = JsonConvert.DeserializeObject<Models.PointOfSaleData>(result);

            return MyList.data;



        }
        public List<PaymentType> PaymentType(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/paymentType", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.PaymentTypeData MyList = new PaymentTypeData();
            MyList = JsonConvert.DeserializeObject<Models.PaymentTypeData>(result);

            return MyList.data;



        }

        public List<Customer> Customer(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/customer", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.CustomerData MyList = new CustomerData();
            MyList = JsonConvert.DeserializeObject<Models.CustomerData>(result);

            return MyList.data;
        }

        public List<Account> Account(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/account", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.AccountData MyList = new AccountData();
            MyList = JsonConvert.DeserializeObject<Models.AccountData>(result);

            return MyList.data;
        }


        //public List<object> ItemCategories(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/upload/contact", Data);
        //    return Data;
        //}
        public List<Location> Locations(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/location", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.LocationData MyList = new LocationData();
            MyList = JsonConvert.DeserializeObject<Models.LocationData>(result);

            return MyList.data;
        }

        public List<ItemPromotion> Promotions(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/promotion", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.ItemPromotionData MyList = new ItemPromotionData();
            MyList = JsonConvert.DeserializeObject<Models.ItemPromotionData>(result);

            return MyList.data;
        }

        public List<Models.PaymentContract> PaymentContracts(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/contract", Data);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.PaymentContractData MyList = new PaymentContractData();
            MyList = JsonConvert.DeserializeObject<Models.PaymentContractData>(result);

            return MyList.data;


        }
       
        public List<Document> Ranges(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/document", Data); ;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.DocumentData MyList = new DocumentData();
            MyList = JsonConvert.DeserializeObject<Models.DocumentData>(result);

            return MyList.data;
          
        }
        public List<Range> Inventory(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/Ranges", Data); ;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.RangeData MyList = new RangeData();
            MyList = JsonConvert.DeserializeObject<Models.RangeData>(result);

            return MyList.data;

        }
        //public List<object> Suppliers(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/upload/Suppliers", Data);
        //    return Data;
        //}
        //public List<object> Users(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/upload/Users", Data);
        //    return Data;
        //}
        public List<Vat> Vats(string CompanySlug, List<object> Data)
        {
            string result = "";
            HttpWebResponse response = Http.SyncList(CompanySlug + "/upload/saletax", Data); ;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpListenerException ex = new HttpListenerException();
                throw ex;
            }
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Models.VatData MyList = new VatData();
             MyList = JsonConvert.DeserializeObject<Models.VatData>(result);

            return MyList.data;

          

        }



    }
}
