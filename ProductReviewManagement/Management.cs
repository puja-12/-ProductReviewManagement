using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var result = (from productReview in listProductReview orderby productReview.Rating descending select productReview).Take(3);

            foreach (var list in result)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "  " + "UserID: " + list.UserID + "  " + "Rating: " + list.Rating + "  " + "Review: " + list.Review + "  " + "isLike: " + list.isLike);
            }
        }
    }
}