﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

        public string ToString()
        {
            return "ProductId : " + ProductId + "\t UserId : " + UserId + "\t Rating : " + Rating + " \tReview : " + Review + "\t isLike : " + isLike ;
        }
    }
}
