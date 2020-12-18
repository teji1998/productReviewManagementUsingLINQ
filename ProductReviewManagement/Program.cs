using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management using LINQ !!!");

            Management management = new Management();
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1,  Rating = 4.2, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 2, UserId = 1,  Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 2,  Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 3,  Rating = 4.9, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 5, UserId = 3,  Rating = 4.2, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 4,  Rating = 1, Review = "bad",  isLike = true },
                new ProductReview() { ProductId = 7, UserId = 6,  Rating = 4.1, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 5,  Rating = 4.25, Review = "nice", isLike = false },
                new ProductReview() { ProductId = 9, UserId = 8,  Rating = 5, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 16,UserId = 18, Rating = 3.6,Review = "nice", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 18, Rating = 1.5,Review = "bad", isLike = true },
                new ProductReview() { ProductId = 10,UserId = 10, Rating = 3.75, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 12,UserId = 12, Rating = 3.64, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 13,UserId = 12, Rating = 4.97, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 14,UserId = 4,  Rating = 3.8, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 15,UserId = 14, Rating = 4.8, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 16,UserId = 18, Rating = 1.8, Review = "bad", isLike = true },
                new ProductReview() { ProductId = 17,UserId = 8,  Rating = 4.7, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 18,UserId = 19, Rating = 3.9, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 19,UserId = 20, Rating = 3.9, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 20,UserId = 25, Rating = 4.6, Review = "nice", isLike = false },
                new ProductReview() { ProductId = 21,UserId = 20, Rating = 4.5, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 22,UserId = 25, Rating = 1,Review = "bad",  isLike =  false },
                new ProductReview() { ProductId = 23,UserId = 20, Rating = 4.56, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 24,UserId = 25, Rating = 4.98, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 25,UserId = 16, Rating = 4.42, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 13,UserId = 18, Rating = 3.95,Review = "nice", isLike = true },
            };

            //to get values added in list
            foreach (var data in productReviewList) {
                Console.WriteLine(data.ToString());
            }
            
            //to get top three records based on highest rating
            management.GetTopThreeRecordsBasedOnRating(productReviewList);

        }
    }
}
