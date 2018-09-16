using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Cognitivo.API
{
    public class Upload
    {
        public Upload(string API_Key, Enums.SyncWith SyncWith = Enums.SyncWith.Production)
        {
            Http.API = API_Key;
            Http.Url = (SyncWith == Enums.SyncWith.Production) ? "https://www.cognitivo.com/api/" : "https://test.cognitivo.in/api/";
        }

        public Data.Transactional Transactional(Data.Transactional Data)
        {
            Data.Transactional data = new API.Data.Transactional();
            HttpWebResponse httpResponse = Http.Sync("", Data);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    DataContractJsonSerializer service = new DataContractJsonSerializer(data.GetType());
                    data = service.ReadObject(stream) as Data.Transactional;
                    stream.Close();
                }
            }

            return Data;
        }
    }
}
