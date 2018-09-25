﻿using Cognitivo.API.Models;
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
            Http.Url = (SyncWith == Enums.SyncWith.Production) ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/";
        }

        /// <summary>
        /// Base the specified CompanySlug and Data.
        /// </summary>
        /// <returns>The base..</returns>
        /// <param name="CompanySlug">Company slug.</param>
        /// <param name="Data">Data.</param>
        public List<Sales> Transaction(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/transaction", Data);
            List<Sales> MyList = JsonConvert.DeserializeObject<List<Sales>>(result);
            return MyList;


        }
        public List<ItemMovement> ItemMovements(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/itemmovements", Data);
            List<ItemMovement> MyList = JsonConvert.DeserializeObject<List<ItemMovement>>(result);
            return MyList;
        }
        public List<AccountMovement> AccountMovements(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/accountmovements", Data);
            List<AccountMovement> MyList = JsonConvert.DeserializeObject<List<AccountMovement>>(result);
            return MyList;

        }


        public List<Models.Item> Item(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/item", Data);
            List<Models.Item> MyList = JsonConvert.DeserializeObject<List<Models.Item>>(result);
            return MyList;

        }
        //public List<object> Account(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/account", Data);
        //    return Data;
        //}
        //public List<object> Company(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/company", Data);
        //    return Data;
        //}

        public List<Models.Customer> Customer(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/customer", Data);
            List<Models.Customer> MyList = JsonConvert.DeserializeObject<List<Models.Customer>>(result);
            return MyList;


        }
        //public List<object> ItemCategories(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/contact", Data);
        //    return Data;
        //}
        //public List<object> Locations(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/Locations", Data);
        //    return Data;
        //}
        public List<Models.PaymentContract> PaymentContracts(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/contract", Data);
            List<Models.PaymentContract> MyList = JsonConvert.DeserializeObject<List<Models.PaymentContract>>(result);
            return MyList;

        }
        //public List<object> PaymentContractDetails(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/PaymentContractDetails", Data);
        //    return Data;
        //}
        //public List<object> PaymentTypes(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/PaymentTypes", Data);
        //    return Data;
        //}
        //public List<object> PointOfSales(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/PointOfSales", Data);
        //    return Data;
        //}
        //public List<object> Ranges(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/Ranges", Data);
        //    return Data;
        //}
        //public List<object> Suppliers(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/Suppliers", Data);
        //    return Data;
        //}
        //public List<object> Users(string CompanySlug, List<object> Data)
        //{
        //    Data = Http.SyncList(CompanySlug + "/sync/Users", Data);
        //    return Data;
        //}
        public List<Vat> Vats(string CompanySlug, List<object> Data)
        {
            string result = Http.SyncList(CompanySlug + "/sync/saletax", Data);
            List<Vat> MyList = JsonConvert.DeserializeObject<List<Vat>>(result);
            return MyList;

        }



    }
}
