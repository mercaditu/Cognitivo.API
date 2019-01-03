using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    public class Document
    {
        

        public Document()
        {
            details = new List<Range>();
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

        /// <summary>
        /// Name for easy recognition.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }
        /// <summary>
        ///Document Module ex:sale,Purchase
        /// </summary>
        public int module { get; set; }
        /// <summary>
        /// type of Document
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// Template of Document
        /// </summary>
        public string designUrl { get; set; }

        /// <summary>
        /// Document of Code Template
        /// </summary>
        public string codeTemplate { get; set; }

        /// <summary>
        /// Document of Mask
        /// </summary>
        public string mask { get; set; }



        /// <summary>
        /// List of Details 
        /// </summary>
        /// <value>The details.</value>
        public List<Range> details { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
       // public DateTime updatedAt { get; set; }

        
        public Enums.Action action { get; set; }


        [DataMember]
        public DateTime updatedAt { get; set; }
        [DataMember]
        public DateTime createdAt { get; set; }
        [DataMember]
        public DateTime? deletedAt { get; set; }
    }
}
