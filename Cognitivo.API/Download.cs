using System;
using System.Collections.Generic;

namespace Cognitivo.API
{
    public class Download
    {
        public Download(string API_Key, Enums.SyncWith SyncWith = Enums.SyncWith.Production)
        {
            Http.API = API_Key;
            Http.Url = (SyncWith == Enums.SyncWith.Production) ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/";
        }

        public Data.Base Base(string CompanySlug)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }

            Data.Base Data = new Data.Base();
            Data = Http.Get(CompanySlug + "/download/base/") as Data.Base;

            return Data;
        }

        public List<Models.Sales> Sales (string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            return Http.Get(CompanySlug + "/download/sales/") as List<Models.Sales>;
        }

        public List<Models.Purchase> Purchases(string CompanySlug, Enums.TimeSpan Timespan)
        {
            if (CompanySlug == "") { throw new Exception("Company Slug is blank. Please assign before performing sync."); }
            return Http.Get(CompanySlug + "/download/purchases/") as List<Models.Purchase>;
        }
    }
}
