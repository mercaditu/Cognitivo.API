using System;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    public class ItemCategory
    {
        public ItemCategory()
        {
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
        public int? cloudId { get; set; }

        public string name { get; set; }

        public bool group { get; set; }

        [DataMember]
        public DateTime updatedAt { get; set; }
        [DataMember]
        public DateTime createdAt { get; set; }
        [DataMember]
        public DateTime? deletedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
      //  public DateTime updatedAt { get; set; }

        public Enums.Action action { get; set; }
    }
}
