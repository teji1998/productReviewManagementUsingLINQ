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
            Console.WriteLine("\nThe top three records are : ");
            foreach(var data in highestRatingRecord)
            {
                Console.WriteLine(data.ToString());
            }
        }

        /// <summary>
        /// Getting the records having rating greater than three.
        /// </summary>
        /// <param name="reviewList">The review list.</param>
        public void GettingRecordsHavingRatingGreaterThanThree(List<ProductReview> reviewList)
        {
            var obtainedRecords = (from productData in reviewList
                                   where (productData.ProductId == 1 || productData.ProductId == 4 || productData.ProductId == 9) && productData.Rating > 3
                                   select productData);
            Console.WriteLine("\nThe records having rating greater than 3 are : ");
            foreach(var data in obtainedRecords)
            {
                Console.WriteLine(data.ToString());
            }

        }
    }
}
