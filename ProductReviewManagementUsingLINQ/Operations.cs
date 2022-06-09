using System;
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
