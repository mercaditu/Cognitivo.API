using System;
namespace Cognitivo.API.Models
{
    public class Customer
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
        /// Gets or sets the taxid.
        /// </summary>
        /// <value>The taxid.</value>
        public string taxid { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string address { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        /// <value>The telephone.</value>
        public string telephone { get; set; }

        /// <summary>
        /// Gets or sets the lead time.
        /// </summary>
        /// <value>The lead time.</value>
        public int? leadTime { get; set; }

        /// <summary>
        /// Gets or sets the credit limit.
        /// </summary>
        /// <value>The credit limit.</value>
        public int? creditLimit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Cognitivo.API.Models.Customer"/> is default.
        /// </summary>
        /// <value><c>true</c> if is default; otherwise, <c>false</c>.</value>
        public bool isDefault { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
