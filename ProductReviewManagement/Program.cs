// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management");
            Management management = new Management();

            //UC1- Add 25 Default Value List for product review

            List<ProductReview> productReviewList = new List<ProductReview>();

            productReviewList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 2, UserID = 1, Rating = 7, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 3, UserID = 2, Rating = 4, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 4, UserID = 2, Rating = 3, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 5, UserID = 2, Rating = 6, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 6, UserID = 2, Rating = 2, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 7, UserID = 2, Rating = 1, Review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 8, UserID = 2, Rating = 8, Review = "Very Nice", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 9, UserID = 3, Rating = 9, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 10, UserID = 3, Rating = 8, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 11, UserID = 3, Rating = 8, Review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 12, UserID = 3, Rating = 5, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 13, UserID = 3, Rating = 7, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 14, UserID = 10, Rating = 3, Review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 15, UserID = 10, Rating = 6, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 16, UserID = 10, Rating = 2, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 17, UserID = 10, Rating = 1, Review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 18, UserID = 10, Rating = 10, Review = "Very Nice", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 19, UserID = 10, Rating = 8, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 20, UserID = 12, Rating = 8, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 21, UserID = 12, Rating = 8, Review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 22, UserID = 12, Rating = 5, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 23, UserID = 12, Rating = 7, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 24, UserID = 12, Rating = 3, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 25, UserID = 12, Rating = 6, Review = "Good", isLike = false });

            Console.WriteLine("Select \n1)Create ProductReview Class with 25 Default values\n2)Retrive Top 3 Records of Top 3 Rating Values\n3)Details from Records with product Id(1,4,9) with rating>3 ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    foreach (var list in productReviewList)
                    {
                        Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
                    }
                    break;
                case 2:

                    management.TopRecords(productReviewList);
                    break;
                case 3:
                    management.RetriveRecords(productReviewList);
                    break;
                default:
                    Console.WriteLine("Please choose the correct option!");
                    break;
            }
        }
    }
}
