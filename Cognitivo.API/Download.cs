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

        public Data.Base Base()
        {
            Data.Base Data = new Data.Base();

            //TODO, loop through the data

            return Data;
        }

        public Data.Transactional Transactional (Enums.TimeSpan Timespan)
        {
            Data.Transactional Data = new Data.Transactional();

            //TODO, 

            return Data;
        }
    }
}
