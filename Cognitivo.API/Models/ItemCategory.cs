using System;
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
        public int cloudId { get; set; }

        public string name { get; set; }
    }
}
