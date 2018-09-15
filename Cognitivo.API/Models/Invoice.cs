using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cognitivo.API.Models
{

    [DataContract]
    public class Invoice
    {
        public Invoice()
        {
            details = new List<Detail>();
        }

        public enum Status { Pending = 1, Invoiced = 2, RequestAnnulment = 3, Annuled = 4 }
        [DataMember]
        public long? relationship_cloud_id;
        [DataMember]
        public int local_id;
        [DataMember]
        public int branch_id;
        [DataMember]
        public string branch_name;
        [DataMember]
        public long cloud_id;
        [DataMember]
        public Customer customer;
        [DataMember]
        public string number;
        [DataMember]
        public DateTime trans_date;
        [DataMember]
        public DateTime? packing_date;
        [DataMember]
        public int credit_days;
        [DataMember]
        public string currency;
        [DataMember]
        public decimal rate;
        [DataMember]
        public string comment;
        [DataMember]
        public Status status;
        [DataMember]
        public List<Detail> details;
    }
    [DataContract]
    public class Detail
    {
        [DataMember]
        public long? local_id;
        [DataMember]
        public long detail_cloud_id;
        [DataMember]
        public long? item_cloud_id;
        [DataMember]
        public long product_id;
        [DataMember]
        public int vat_id;
        [DataMember]
        public decimal quantity;
        [DataMember]
        public decimal price;
        [DataMember]
        public string name;
        [DataMember]
        public string code;
        [DataMember]
        public decimal discount;
        [DataMember]
        public bool is_shipped;
        [DataMember]
        public Item item { get; set; }



    }


    [DataContract]
    public class ResponseInvoice
    {
        public ResponseInvoice()
        {
            details = new List<ResoponseInvoiceDetail>();
        }
        [DataMember]
        public int cloud_id;
        [DataMember]
        public int relationship_id;
        [DataMember]
        public int local_id;
        [DataMember]
        public List<ResoponseInvoiceDetail> details;

    }
    [DataContract]
    public class ResoponseInvoiceDetail
    {
        [DataMember]
        public int cloud_id;
        [DataMember]
        public decimal item_id;
        [DataMember]
        public decimal quantity;
        [DataMember]
        public decimal unit_price;
    }
}
