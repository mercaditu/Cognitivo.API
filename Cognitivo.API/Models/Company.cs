﻿using System;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    public class Company
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int? localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public string slugCognitivo { get; set; }

        /// <summary>
        /// Gets or sets the avatar URL.
        /// </summary>
        /// <value>The avatar URL.</value>
        public string logoUrl { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the alias.
        /// </summary>
        /// <value>The alias.</value>
        public string alias { get; set; }

        /// <summary>
        /// Gets or sets the taxid.
        /// </summary>
        /// <value>The taxid.</value>
        public string taxId { get; set; }

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
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the default currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currencyCode { get; set; }

      


        [DataMember]
        public DateTime updatedAt { get; set; }
        [DataMember]
        public DateTime createdAt { get; set; }
        [DataMember]
        public DateTime? deletedAt { get; set; }
    }
}
