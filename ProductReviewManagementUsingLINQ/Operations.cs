﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementUsingLINQ
{
    public class Operations
    {
        public void GetTop3Records(List<ProductReview> reviewlist)
        {
            var result = reviewlist.OrderByDescending(x => x.Rating).Take(3).ToList();
            Display(result);
        }
        public void GetTopRecordsWithProductId(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).Take(3).ToList();
            Display(result);
        }
        public void GetTopRecordsCountWithProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductID + " " + data.Count);
            }
        }
        public void GetAllRecords(List<ProductReview> list)
        {
            var result = list.OrderBy(x => x.ProductId).Select(x => new { productId = x.ProductId, Review = x.Review });
            foreach (var data in result)
            {
                Console.WriteLine(data.productId + "|" + data.Review);
            }

        }
        public void SkipTop5Records(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Skip(5).ToList();
            Display(result);
        }
        public void Display(List<ProductReview> list)
        {
            //Display list
            foreach (var product in list)
            {
                Console.WriteLine("\n");
                Console.WriteLine(product.ProductId + " | " + product.UserId + " | " + product.Rating + " | " + product.Review + " | " + product.IsLike);
            }
        }
    }
}
