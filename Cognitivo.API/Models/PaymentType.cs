using System;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    public class PaymentType
    {
        /// <summary>
        /// Core accepts different types of behaviours.
        /// </summary>
        public enum Behaviours
        {
            /// <summary>
            /// Normal: Such as Cash, Check, Credit Card.
            /// </summary>
            Normal,
            /// <summary>
            /// Same as Normal, except the money enters the account delayed. This requires an aditional process of varification before acrediting value into account.
            /// </summary>
            Delayed,
            /// <summary>
            /// Credit Behaviours are meant for Credit and Debit Notes. Where you use credits to pay off debt.
            /// </summary>
            Credit,
            /// <summary>
            /// Vat WithHolding depending on certain countries that require Customers or Suppliers to Withhold vat generated from the transaction.
            /// </summary>
            VatWithholding
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
        /// Gets or sets the behaviour.
        /// </summary>
        /// <value>The behaviour.</value>
        public Behaviours Behaviour { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Action action { get; set; }

    }
}
