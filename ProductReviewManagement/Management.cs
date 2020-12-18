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

        public Management()
        {
            //Creating columns in the datatable
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("isLike", typeof(bool));

            //adding data into datatable
            dataTable.Rows.Add(1, 1, 3.7d, "Good", true);
            dataTable.Rows.Add(2, 2, 3.9d, "Good", true);
            dataTable.Rows.Add(3, 3, 3.6d, "Good", true);
            dataTable.Rows.Add(4, 4, 4.44d, "Good", true);
            dataTable.Rows.Add(5, 5, 3.98d, "Nice", false);
            dataTable.Rows.Add(6, 6, 1.6d, "Bad", false);
            dataTable.Rows.Add(7, 7, 4d, "Good", true);
            dataTable.Rows.Add(8, 5, 4.3d, "Good", true);
            dataTable.Rows.Add(9, 4, 4.8d, "Good", true);
            dataTable.Rows.Add(16, 5, 3.47d, "Good", true);
            dataTable.Rows.Add(3, 1, 3.89d, "Nice", false);
            dataTable.Rows.Add(10, 8, 5d, "Best", true);
            dataTable.Rows.Add(12, 18, 4.28d, "Nice", true);
            dataTable.Rows.Add(13, 17, 2.2d, "Bad", false);
            dataTable.Rows.Add(14, 9, 3.6d, "Nice", false);
            dataTable.Rows.Add(15, 21, 3.77d, "Good", true);
            dataTable.Rows.Add(16, 10, 4.49d, "Nice", true);
            dataTable.Rows.Add(17, 15, 1.89d, "Bad", true);
            dataTable.Rows.Add(18, 17, 4.44d, "Nice", true);
            dataTable.Rows.Add(19, 12, 4.99d, "Best", true);
            dataTable.Rows.Add(20, 10, 1.2d, "Bad", true);
            dataTable.Rows.Add(21, 15, 4.67d, "Nice", true);
            dataTable.Rows.Add(22, 13, 3.5d, "Nice", true);
            dataTable.Rows.Add(23, 22, 4.5d, "Best", true);
            dataTable.Rows.Add(24, 19, 2.3d, "Bad", true);
            dataTable.Rows.Add(25, 19, 4.5d, "Nice", true); 
            dataTable.Rows.Add(13, 25, 5d, "Good", true);
            dataTable.Rows.Add(11, 10, 3.56d, "Nice", true);
        }

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

        /// <summary>
        /// Skips the top five records and displays the remaining records
        /// </summary>
        /// <param name="reviewList">The review list.</param>
        public void SkipTopFiveRecords(List<ProductReview> reviewList)
        {
            var records = (from productData in reviewList
                           select productData).Skip(5);
            Console.WriteLine("\nDisplaying the records after skipping top five records : ");
            foreach(var data in records)
            {
                Console.WriteLine(data.ToString());
            }
        }

        /// <summary>
        /// Selects the product identifier and review from record.
        /// </summary>
        /// <param name="reviewList">The review list.</param>
        public void SelectProductIdAndReviewFromRecords(List<ProductReview> reviewList)
        {
            var select = from productData in reviewList
                         select (productData.ProductId, productData.Review);
            Console.WriteLine("\nProduct id and review : ");
            foreach (var data in select)
            {
                Console.WriteLine("ProductId : " + data.ProductId + "\tReview : " + data.Review);
            }
        }
    }
}
