using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cognitivo.API.APIModel
{
    [DataContract]
    public class Item
    {
        [DataMember]
        public long? local_id;
        [DataMember]
        public string name;
        [DataMember]
        public string code;
        [DataMember]
        public string comment;
        [DataMember]
        public decimal unit_price;
        [DataMember]
        public long? cloud_id;
        [DataMember]
        public string currency_code;
        [DataMember]
        public string updated_at;


    }
    [DataContract]
    public class ResponseItem
    {
        [DataMember]
        public int cloud_id;
        [DataMember]
        public string name;
        [DataMember]
        public string code;
        [DataMember]
        public string description;
        [DataMember]
        public decimal? price;
        [DataMember]
        public int? vat_cloud_id;
        [DataMember]
        public int local_id;

    }
}
