using System;
namespace Cognitivo.API.Models
{
    public class AccountMovement
    {
        public AccountMovement()
        {
            date = DateTime.Now;
            debit = 0;
            credit = 0;
            currencyRate = 1;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int cloudId { get; set; }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        /// <value>The account.</value>
        public int accountCloudId { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime date { get; set; }

        /// <summary>
        /// Gets or sets the debit.
        /// </summary>
        /// <value>The debit.</value>
        public decimal debit { get; set; }

        /// <summary>
        /// Gets or sets the credit.
        /// </summary>
        /// <value>The credit.</value>
        public decimal credit { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currencyCode { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>The rate.</value>
        public decimal currencyRate { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        public string comment { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>The reference.</value>
        public string reference { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>The last updated on.</value>
        public DateTime updatedAt { get; set; }
    }
}
