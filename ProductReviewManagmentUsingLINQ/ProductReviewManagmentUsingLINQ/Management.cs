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
    }
}
