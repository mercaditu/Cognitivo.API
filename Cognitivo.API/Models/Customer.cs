using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cognitivo.API.Models
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public long? local_id;
        [DataMember]
        public string name;
        [DataMember]
        public string customer_taxid;
        [DataMember]
        public string customer_alias;
        [DataMember]
        public string customer_address;
        [DataMember]
        public string customer_telephone;
        [DataMember]
        public string customer_email;
        [DataMember]
        public long? cloud_id;
        [DataMember]
        public string updated_at;


    }
    [DataContract]
    public class ResponseCustomer
    {
        [DataMember]
        public int cloud_id;
        [DataMember]
        public string name;
        [DataMember]
        public string code;
        [DataMember]
        public string address;
        [DataMember]
        public string telephone;
        [DataMember]
        public string email;
        [DataMember]
        public int local_id;
   
    }
}
