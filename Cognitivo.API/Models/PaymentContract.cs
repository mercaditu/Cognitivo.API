using System;
using System.Collections.Generic;

namespace Cognitivo.API.Models
{
    public class PaymentContract
    {
        public PaymentContract()
        {
            details = new List<PaymentContractDetail>();
        }

        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int? localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int cloudId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>The details.</value>
        public List<PaymentContractDetail> details { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }

        public Enums.Action action { get; set; }
    }
}
