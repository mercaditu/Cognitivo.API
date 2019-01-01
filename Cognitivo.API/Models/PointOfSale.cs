using System;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{
    public class PointOfSale
    {
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
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public int? locationCloudId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the price list.
        /// </summary>
        /// <value>The price list.</value>
        public int defaultPriceList { get; set; }

        /// <summary>
        /// Gets or sets the default payment condition.
        /// </summary>
        /// <value>The default payment condition.</value>
        public int defaultPaymentCondition { get; set; }

        /// <summary>
        /// Gets or sets the default type of the payment.
        /// </summary>
        /// <value>The default type of the payment.</value>
        public int defaultPaymentType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.PointOfSale"/> prefill payment.
        /// Prefill amount paid with the exact due amount
        /// </summary>
        /// <value><c>true</c> if prefill payment; otherwise, <c>false</c>.</value>
        public bool PrefillPayment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.PointOfSale"/> is restaurant.
        /// </summary>
        /// <value><c>true</c> if is restaurant; otherwise, <c>false</c>.</value>
        public bool IsRestaurant { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.PointOfSale"/> is tax inclusive.
        /// </summary>
        /// <value><c>true</c> if is tax inclusive; otherwise, <c>false</c>.</value>
        public bool IsTaxInclusive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.PointOfSale"/> uses touch screen.
        /// </summary>
        /// <value><c>true</c> if uses touch screen; otherwise, <c>false</c>.</value>
        public bool useTouchScreen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.PointOfSale"/> has loyalty program.
        /// </summary>
        /// <value><c>true</c> if has loyalty program; otherwise, <c>false</c>.</value>
        public bool useLoyaltyProgram { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.PointOfSale"/> has cash control.
        /// </summary>
        /// <value><c>true</c> if has cash control; otherwise, <c>false</c>.</value>
        public bool useCashControl { get; set; }


        [DataMember]
        public DateTime updatedAt { get; set; }
        [DataMember]
        public DateTime createdAt { get; set; }
        [DataMember]
        public DateTime? deletedAt { get; set; }


        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Action action { get; set; }
    }
}
