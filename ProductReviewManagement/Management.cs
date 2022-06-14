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
        /// Retrive all data from list whose rating greater than 3 from records 1,4,9

        public void RetriveRecords(List<ProductReview> productreviewlist)
        {
            var ProductData = (from productReviews in productreviewlist
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews);

            foreach (var list in ProductData)
            {
                Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
            }
        }
        public void CountReviewofEachProductID(List<ProductReview> productreviewlist)
        {
            foreach (var line in productreviewlist.GroupBy(info => info.ProductID)
                           .Select(group => new
                           {
                               products = group.Key,
                               Count = group.Count()

                           }).OrderBy(x => x.products))

            {
                Console.WriteLine("Product Id:{0} => Count :{1}", line.products, line.Count);
            }

        }
    }
}