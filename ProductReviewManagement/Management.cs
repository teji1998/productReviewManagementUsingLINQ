using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// Gets the top three records based on rating.
        /// </summary>
        /// <param name="reviewList">The review list.</param>
        public void GetTopThreeRecordsBasedOnRating(List<ProductReview> reviewList)
        {
            var highestRatingRecord = (from productData in reviewList
                                       orderby productData.Rating descending
                                       select productData).Take(3);
            Console.WriteLine("The top three records are : ");
            foreach(var data in highestRatingRecord)
            {
                Console.WriteLine(data.ToString());
            }

        }
    }
}
