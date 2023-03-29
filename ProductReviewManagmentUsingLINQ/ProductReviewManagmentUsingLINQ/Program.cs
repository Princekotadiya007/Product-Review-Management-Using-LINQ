using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagmentUsingLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ProductReviewModel> list = new List<ProductReviewModel>()
            {
                new ProductReviewModel() { ProductId = 1, UserId = 10, Rating = 1, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 2, UserId = 11, Rating = 5, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 3, UserId = 12, Rating = 6, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 4, UserId = 13, Rating = 8, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 5, UserId = 14, Rating = 2, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 6, UserId = 15, Rating = 6, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 7, UserId = 16, Rating = 6, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 8, UserId = 17, Rating = 5, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 9, UserId = 18, Rating = 8, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 10, UserId = 19, Rating = 1, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 11, UserId = 20, Rating = 9, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 12, UserId = 21, Rating = 10, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 13, UserId = 22, Rating = 4, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 14, UserId = 23, Rating = 6, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 15, UserId = 24, Rating = 3, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 16, UserId = 25, Rating = 8, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 17, UserId = 26, Rating = 5, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 18, UserId = 27, Rating = 6, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 19, UserId = 28, Rating = 1, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 20, UserId = 29, Rating = 5, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 21, UserId = 30, Rating = 4, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 22, UserId = 31, Rating = 9, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 23, UserId = 32, Rating = 3, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 24, UserId = 33, Rating = 4, Review = "good", IsLike = true },
                new ProductReviewModel() { ProductId = 25, UserId = 34, Rating = 3, Review = "good", IsLike = true },
            };

            Management management = new Management();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter an option");
                Console.WriteLine("1.Add Product Review \n2.Display Product Review \n3.Rritevive Top3Record");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.AddProductReview(list);
                        break;
                    case 2:
                        management.DisplayProductReview(list);
                        break;
                    case 3:
                        management.RriteviveTop3Record(list);
                        break;
                }
            }

        }
    }
}
