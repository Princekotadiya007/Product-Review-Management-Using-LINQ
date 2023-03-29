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
            List<ProductReviewModel> list = new List<ProductReviewModel>();

            new ProductReviewModel()(ProductId=1, UserId = 10, Rating = 4, ProductReviewModel = "good", IsLike = true);
        }
    }
}
