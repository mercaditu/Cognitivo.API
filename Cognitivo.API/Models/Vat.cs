using System;
using System.Collections.Generic;

namespace Cognitivo.API.Models
{
    public class Vat
    {
        public Vat()
        {
            details = new List<VatDetail>();
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int cloudId { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        public Company Company { get; set; }

        /// <summary>
        /// Name for easy recognition.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// List of Details 
        /// </summary>
        /// <value>The details.</value>
        public List<VatDetail> details { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
