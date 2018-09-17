using System;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{   
    [DataContract]
    public class Item
    {
        public Item()
        {
        }
        [DataMember]
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int CloudID { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        public Company Company { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        /// <value>The sku.</value>
        public string Sku { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the bar code.
        /// </summary>
        /// <value>The bar code.</value>
        public string BarCode { get; set; }


        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        // public Enums.ItemTypes Type { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public ItemCategory Category { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        /// <value>The vat.</value>
        public int Vat_CloudID { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string Currency { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public decimal Price { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public decimal Cost { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.Item"/> weigh with scale.
        /// </summary>
        /// <value><c>true</c> if weigh with scale; otherwise, <c>false</c>.</value>
        public bool WeighWithScale { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public decimal Weight { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the volume.
        /// </summary>
        /// <value>The volume.</value>
        public decimal Volume { get; set; }
        [DataMember]
        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime LastUpdatedOn { get; set; }
    }
}
