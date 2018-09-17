using System;
namespace Cognitivo.API.Models
{
    public class Range
    {
        public int Id { get; set; }
        public int CloudId { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        public int companyCloudId { get; set; }

        /// <summary>
        /// Gets or sets the starting value.
        /// </summary>
        /// <value>The starting value.</value>
        public int startingValue { get; set; }

        /// <summary>
        /// Gets or sets the current value.
        /// </summary>
        /// <value>The current value.</value>
        public int currentValue { get; set; }

        /// <summary>
        /// Gets or sets the ending value.
        /// </summary>
        /// <value>The ending value.</value>
        public int endingValue { get; set; }

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        /// <value>The template.</value>
        public string template { get; set; }

        /// <summary>
        /// Gets or sets the mask.
        /// </summary>
        /// <value>The mask.</value>
        public string mask { get; set; }

        /// <summary>
        /// Gets or sets the code. Certain countries or companies may require each range to be signed by an identifier code.
        /// </summary>
        /// <value>The code.</value>
        public string code { get; set; }

        /// <summary>
        /// Gets or sets the expiry date. Null value equals to no expiration date.
        /// </summary>
        /// <value>The expiry date.</value>
        public DateTime? expiryDate { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
