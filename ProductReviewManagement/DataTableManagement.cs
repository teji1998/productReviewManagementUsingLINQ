﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class DataTableManagement
    {
        DataTable dataTable = new DataTable();
        public DataTableManagement()
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
            dataTable.Rows.Add(10, 10, 5d, "Best", true);
            dataTable.Rows.Add(23, 10, 5d, "Bad", true);
            dataTable.Rows.Add(14, 10, 5d, "Nice", false);
            dataTable.Rows.Add(21, 10, 5d, "Good", true);
        }

        /// <summary>
        /// Obtains the records based on is like value.
        /// </summary>
        public void ObtainRecordsBasedOnIsLikeValue()
        {
            var records = from reviews in dataTable.AsEnumerable()
                          where reviews.Field<bool>("isLike").Equals(true)
                          select reviews;
            Console.WriteLine("\nDisplays values where isLike value is true");
            foreach (var data in records)
            {
                Console.WriteLine($"ProductId : {data.ItemArray[0]} UserId : {data.ItemArray[1]} Rating : {data.ItemArray[2]} Review : {data.ItemArray[3]} isLike : {data.ItemArray[4]}");
            }

        }

        /// <summary>
        /// Obtains the average rating by product identifier.
        /// </summary>
        public void ObtainAverageRatingByProductID()
        {
            var Data = dataTable.AsEnumerable()
                .GroupBy(x => x.Field<int>("ProductId"))
                        .Select(x => new { ProductId = x.Key, Average = x.Average(p => p.Field<double>("Rating")) });
            Console.WriteLine("\nDisplays average based on rating: ");
            foreach (var data in Data)
            {
                Console.WriteLine("Product Id: " + data.ProductId + " " + "Average: " + data.Average);
            }
        }

        /// <summary>
        /// Obtains the review message as nice.
        /// </summary>
        public void ObtainRecordsBasedOnReviewMessage()
        {
            var records = from review in dataTable.AsEnumerable()
                          where review.Field<string>("Review").Equals("Nice")
                          select review;
            Console.WriteLine("\nDisplays records having review message as nice : ");
            foreach (var data in records)
            {
                Console.WriteLine($"ProductID- {data.ItemArray[0]} UserID- {data.ItemArray[1]} Rating- {data.ItemArray[2]} Review- {data.ItemArray[3]} isLike- {data.ItemArray[4]}");
            }
        }

        /// <summary>
        /// Obtains the records for user identifier based on rating.
        /// </summary>
        public void ObtainRecordsForUserIdBasedOnRating()
        {
            var records = from review in dataTable.AsEnumerable()
                          where review.Field<int>("UserId").Equals(10)
                          orderby review.Field<double>("Rating")
                          select review;
            Console.WriteLine("\nDisplays records having user id as 10 : ");

            foreach (var data in records)
            {
                Console.WriteLine($"ProductId- {data.ItemArray[0]} UserID- {data.ItemArray[1]} Rating- {data.ItemArray[2]} Review- {data.ItemArray[3]} isLike- {data.ItemArray[4]}");
            }
        }
    }
}
