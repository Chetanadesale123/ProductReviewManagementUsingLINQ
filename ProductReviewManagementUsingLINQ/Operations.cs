using System;
using System.Collections.Generic;
using System.Data;
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
        public void Datatables()
        {
            //created datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Review");
            dt.Columns.Add("Islike");
            //created row
            dt.Rows.Add("1", "111", "5", "best", "true");
            dt.Rows.Add(2, 112, 5, "best", true);
            dt.Rows.Add(3, 113, 4, "better", true);
            dt.Rows.Add(4, 114, 3, "Good", true);
            dt.Rows.Add(5, 115, 5, "best", true);
            dt.Rows.Add(6, 116, 4, "better", true);
            dt.Rows.Add(7, 117, 3, "Good", true);
            dt.Rows.Add(8, 118, 4, "better", true);
            dt.Rows.Add(9, 119, 1, "worst", false);
            dt.Rows.Add(10, 120, 5, "best", true);
            dt.Rows.Add(11, 121, 4, "better", true);
            dt.Rows.Add(12, 122, 4, "better", true);
            dt.Rows.Add(13, 123, 2, "bad", false);
            dt.Rows.Add(14, 124, 1, "worst", false);
            dt.Rows.Add(15, 125, 5, "best", true);
            dt.Rows.Add(16, 126, 5, "best", true);
            dt.Rows.Add(17, 127, 4, "better", true);
            dt.Rows.Add(18, 128, 4, "better", true);
            dt.Rows.Add(19, 129, 3, "Good", true);
            dt.Rows.Add(20, 130, 3, "Good", true);
            dt.Rows.Add(21, 131, 2, "better", true);
            dt.Rows.Add(22, 132, 5, "best", true);
            dt.Rows.Add(23, 133, 4, "better", true);
            dt.Rows.Add(24, 134, 3, "Good", true);
            dt.Rows.Add(25, 135, 2, "bad", false);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
            IEnumerable<DataRow> rows = dt.AsEnumerable().Where(r => r.Field<string>("Islike") == "True");
            Console.WriteLine("\n ^^^^^^^^^^^^^^^^^Data from datatable who's islike value is true^^^^^^^^^^^^^^^^^^");
            foreach (DataRow row in rows)
            {
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
        }
    }
}
