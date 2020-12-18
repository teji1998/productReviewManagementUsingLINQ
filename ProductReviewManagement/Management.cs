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

        /// <summary>
        /// Counts the of review by product id.
        /// </summary>
        /// <param name="reviewlist">The reviewlist.</param>
        public void CountOfReviewByProductId(List<ProductReview> reviewlist)
        {
            var reviewRecords = reviewlist.GroupBy(data => data.ProductId)
                                    .Select(data => new { ProductId = data.Key, Count = data.Count() });
            Console.WriteLine("\nCount of review by product id : ");
            foreach(var data in reviewRecords)
            {
                Console.WriteLine("ProductId : " + data.ProductId +   "\tCount : " + data.Count );
            }
        }

        /// <summary>
        /// Obtains the product identifier and review.
        /// </summary>
        /// <param name="reviewList">The review list.</param>
        public void ObtainProductIdAndReview(List<ProductReview> reviewList)
        {
            var obtainedRecords = reviewList.Select(data => new { ProductId = data.ProductId, Review = data.Review });
            Console.WriteLine("\nProduct id and review : ");
            foreach(var data in obtainedRecords)
            {
                Console.WriteLine("ProductId : " + data.ProductId + "\tReview " +data.Review );
            }
        }

        public void skipTopFiveRecords(List<ProductReview> reviewList)
        {
            var records = (from productData in reviewList
                           select productData).Skip(5);
            Console.WriteLine("\nDisplaying the records after skipping top five records : ");
            foreach(var data in records)
            {
                Console.WriteLine(data.ToString());
            }
        }
    }
}
