using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    [DataContract]
    public class Sales
    {
  
        public Sales()
        {
            Date = DateTime.Now;
            details = new List<SalesDetail>();
            isArchived = false;
        }

        [DataMember]
        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int localId { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int cloudId { get; set; }



        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Status status { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Action action { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public int locationCloudId { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>The contact.</value>
        public int customerCloudId { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the payment contract.
        /// </summary>
        /// <value>The payment contract.</value>
        public int paymentContractCloudId { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>The invoice number.</value>
        public string invoiceNumber { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the invoice code.
        /// </summary>
        /// <value>The invoice code.</value>
        public string code { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the code expiry.
        /// </summary>
        /// <value>The code expiry.</value>
        public DateTime codeExpiry { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currency { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        /// <value>The currency rate.</value>
        public decimal currencyRate { get; set; }
        [DataMember]
        /// <summary>
        /// Gets the interval.
        /// </summary>
        /// <value>The interval.</value>
        public TimeSpan interval { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>The details.</value>
        public List<SalesDetail> details { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.Order"/> is archived.
        /// </summary>
        /// <value><c>true</c> if is archived; otherwise, <c>false</c>.</value>
        public bool isArchived { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }


        
    }
}
