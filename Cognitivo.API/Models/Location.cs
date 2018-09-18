using System;
namespace Cognitivo.API.Models
{
    public class Location
    {
        public Location() { }

        public int localId { get; set; }

        public int cloudId { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        public Company Company { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string address { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        /// <value>The telephone.</value>
        public string telephone { get; set; }

        /// <summary>
        /// Gets or sets the Telephone.
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        public string country { get; set; }


        /// <summary>
        /// Gets or sets the Zip.
        /// </summary>
        public string zip { get; set; }



        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        /// <value>The vat.</value>
        public int? vatCloudId { get; set; }
        /// <summary>
        /// Gets or sets code of currency
        /// </summary>
        public string currencyCode { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
