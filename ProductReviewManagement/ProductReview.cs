using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    
    public class ProductReview
    {
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        public double Rating { get; set; }

        /// <summary>
        /// Gets or sets the review.
        /// </summary>
        /// <value>
        /// The review.
        /// </value>
        public string Review { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is like.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is like; otherwise, <c>false</c>.
        /// </value>
        public bool isLike { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString()
        {
            return "ProductId : " + ProductId + "\t UserId : " + UserId + "\t Rating : " + Rating + "\t Review : " + Review + "\t isLike : " + isLike ;
        }
    }
}
