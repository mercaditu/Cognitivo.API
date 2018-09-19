using System;
namespace Cognitivo.API.Models
{
    public class SalesDetail
    {
        public SalesDetail()
        {
            quantity = 1;
        }

        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int cloudId { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>The order.</value>
        public Sales salesCloudId { get; set; }

        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        /// <value>The vat.</value>
        public int vatCloudId { get; set; }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public int itemCloudId { get; set; }

        /// <summary>
        /// Gets or sets the item description.
        /// </summary>
        /// <value>The item description.</value>
        public string itemDescription { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public decimal cost { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        public decimal quantity { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public decimal price { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
