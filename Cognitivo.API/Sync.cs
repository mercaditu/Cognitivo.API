using System;
namespace Cognitivo.API
{
    public class Sync
    {
        public Sync(string API_Key, Enums.SyncWith SyncWith = Enums.SyncWith.Production)
        {
            Http.API = API_Key;
            Http.Url = (SyncWith == Enums.SyncWith.Production) ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/";
        }

        public Data.Base Base(Data.Base Base)
        {
            //TODO, loop through the data
            return Base;
        }
    }
}
