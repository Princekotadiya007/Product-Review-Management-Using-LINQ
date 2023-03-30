using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagmentUsingLINQ
{
    internal class Management
    {
        List<ProductReviewModel> productList = new List<ProductReviewModel> ();

        public void AddProductReview(List<ProductReviewModel> productReviewList)
        {
            this.productList = productReviewList;
            Console.WriteLine("Review add successfuly");
        }
        public void DisplayProductReview(List<ProductReviewModel> productReviewdisplay)
        {
            foreach(ProductReviewModel product in productReviewdisplay)
            {
                Console.WriteLine(product.ProductId+" "+ product.UserId+" "+ product.Rating+" "+ product.Review+" "+ product.IsLike+ " ");
            }
        }
        public void RriteviveTop3Record(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.OrderByDescending(p => p.Rating).Take(3);
            DisplayProductReview(result.ToList());
        }
        public void RetriveRecordBasedOnProductIdAndRating(List<ProductReviewModel> productReviewList)
        {
            var result = productList.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 3 || p.ProductId == 9));
            DisplayProductReview(result.ToList());
        }
        public void CountOfReview(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, Count = p.Count() });
            foreach (var product in result)
            {
                Console.WriteLine("ProductID" + " " + product.ProductId + " " + "Count" + " " + product.Count);
            }
        }
    }
}
