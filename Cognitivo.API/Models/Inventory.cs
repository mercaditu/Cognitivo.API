using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cognitivo.API.Models
{
    public class Inventory
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
        public int cloudId { get; set; }

        /// <summary>
        /// Gets or sets the location value.
        /// </summary>
        /// <value>The location value.</value>
        public int locationId { get; set; }

        /// <summary>
        /// Gets or sets the Item value.
        /// </summary>
        /// <value>The item value.</value>
        public int itemId { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public decimal cost { get; set; }

        /// <summary>
        /// Gets or sets the System Quantity.
        /// </summary>
        /// <value>The template.</value>
        public string quantitySystem { get; set; }

        /// <summary>
        /// Gets or sets the Actula Quantity.
        /// </summary>
        /// <value>The mask.</value>
        public string quantityActual { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The code.</value>
        public string comment { get; set; }

        


        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Action action { get; set; }
    }
}
