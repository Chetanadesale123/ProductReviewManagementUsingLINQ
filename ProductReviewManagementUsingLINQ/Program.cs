using System;
namespace ProductReviewManagementUsingLINQ;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to product Review Management");
        List<ProductReview> reviewList = new List<ProductReview>();
        reviewList.Add(new ProductReview() { ProductId = 1, UserId = 111, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 2, UserId = 112, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 3, UserId = 113, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 4, UserId = 114, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 5, UserId = 115, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 6, UserId = 116, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 7, UserId = 10, Rating = 3, Review = "Nice", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 8, UserId = 118, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 9, UserId = 10, Rating = 1, Review = "worst", IsLike = false });
        reviewList.Add(new ProductReview() { ProductId = 10, UserId = 120, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 11, UserId = 121, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 12, UserId = 10, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 10, UserId = 123, Rating = 2, Review = "bad", IsLike = false });
        reviewList.Add(new ProductReview() { ProductId = 14, UserId = 124, Rating = 1, Review = "worst", IsLike = false });
        reviewList.Add(new ProductReview() { ProductId = 10, UserId = 125, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 16, UserId = 10, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 17, UserId = 127, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 18, UserId = 128, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 19, UserId = 129, Rating = 3, Review = "Nice", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 20, UserId = 10, Rating = 3, Review = "Nice", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 21, UserId = 131, Rating = 2, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 22, UserId = 132, Rating = 5, Review = "best", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 23, UserId = 10, Rating = 4, Review = "better", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 24, UserId = 134, Rating = 3, Review = "Nice", IsLike = true });
        reviewList.Add(new ProductReview() { ProductId = 25, UserId = 135, Rating = 2, Review = "bad", IsLike = false });
        bool end = true;
        while (end)
        {
            Console.WriteLine("\nSelect Option\n1.CreateProductReview\n 2.Retrive Top 3 Records \n 3.Retrive Top 3 Record With Product Id \n 4.Get Top Records Count With ProductId \n 5.Retrieve Only ProductId And Review \n 6. Skip Top 5 Records \n7.Create DataTable \n 8.Find average rating\n 9.Find Nice review Data \n 10.Rerieve Record Whose UserId Is 10  \n 11.End Of Program");
            Console.WriteLine("\nEnter Option For Exicute The Program");
            int option = Convert.ToInt16(Console.ReadLine());
            Operations operations = new Operations();
            switch (option)
            {
                case 1:
                    operations.Display(reviewList);
                    break;
                case 2:
                    operations.GetTop3Records(reviewList);
                    break;
                case 3:
                    operations.GetTopRecordsWithProductId(reviewList);
                    break;
                case 4:
                    operations.GetTopRecordsCountWithProductId(reviewList);
                    break;
                case 5:
                    operations.GetAllRecords(reviewList);
                    break;
                case 6:
                    operations.SkipTop5Records(reviewList);
                    break;
                case 7:
                    operations.Datatables();
                    break;
                case 8:
                    operations.AvgRating(reviewList);
                    break;
                case 9:
                    operations.NiceReview(reviewList);
                    break;
                case 10:
                    operations.RetriviewingOnlyParticularUserId(reviewList);
                    break;
                case 11:
                    end = false;
                    break;
                default:
                    Console.WriteLine("\n Invalid Option");
                    break;
            }
        }
    }
}
    

