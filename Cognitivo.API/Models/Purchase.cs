using System;
using System.Collections.Generic;

namespace Cognitivo.API.Models
{
    public class Purchase
    {
  
        public Purchase()
        {
            Date = DateTime.Now;
            Details = new List<PurchaseDetail>();
            IsArchived = false;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int CloudID { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Status Status { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>The contact.</value>
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Gets or sets the payment contract.
        /// </summary>
        /// <value>The payment contract.</value>
        public PaymentContract PaymentContract { get; set; }

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>The invoice number.</value>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the invoice code.
        /// </summary>
        /// <value>The invoice code.</value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the code expiry.
        /// </summary>
        /// <value>The code expiry.</value>
        public DateTime CodeExpiry { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        /// <value>The currency rate.</value>
        public decimal CurrencyRate { get; set; }

        /// <summary>
        /// Gets the interval.
        /// </summary>
        /// <value>The interval.</value>
        public TimeSpan Interval { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>The details.</value>
        public List<PurchaseDetail> Details { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.Order"/> is archived.
        /// </summary>
        /// <value><c>true</c> if is archived; otherwise, <c>false</c>.</value>
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime LastUpdatedOn { get; set; }
    }
}
