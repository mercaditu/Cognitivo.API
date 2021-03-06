﻿using System;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    public class VatDetail
    {
        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int? cloudId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the coefficient.
        /// </summary>
        /// <value>The coefficient.</value>
        public decimal coefficient { get; set; }

        /// <summary>
        /// Gets or sets the percentage.
        /// </summary>
        /// <value>The percentage.</value>
        public decimal percentage { get; set; }

        [DataMember]
        public DateTime updatedAt { get; set; }
        [DataMember]
        public DateTime createdAt { get; set; }
        [DataMember]
        public DateTime? deletedAt { get; set; }
    }
}
