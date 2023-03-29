using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagmentUsingLINQ
{
    public class ProductReviewModel
    {
        public int PeoductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }          
        public string IsLike { get; set; }
    }
}
