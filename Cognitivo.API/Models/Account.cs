using System;

namespace Cognitivo.API.Models
{
    public class Account
    {
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
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the default currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currencyCode { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
