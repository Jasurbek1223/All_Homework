using N22___HT2.Interface;
using N22___HT2.Model;
using N22___HT2.Service;

namespace N22___HT2;
class Program
{
    static void Main(string[] args)
    {
        IReviewList<IReview> reviewList = new ReviewList<IReview>();

        Review review1 = new Review { Id = 1, Star = 4, Message = "Good product" };
        Review review2 = new Review { Id = 3, Star = 5, Message = "OK" };
        CrashReport report1 = new CrashReport { Id = 2, Star = 2, Message = "Not working", ScreenshotPath = "screenshot.jpg" };
        CrashReport report2 = new CrashReport { Id = 4, Star = 4, Message = "Bad", ScreenshotPath = "fayl.txt" };

        reviewList.Add(review1);
        reviewList.Add(review2);
        reviewList.Add(report1);
        reviewList.Add(report2);

        Console.WriteLine("Review by ID:");
        IReview reviewById = reviewList.GetReview(1);
        if (reviewById != null)
        {
            Console.WriteLine($"ID: {reviewById.Id}, Message: {reviewById.Message}");
        }

        Console.WriteLine("\nReview by Message:");
        IReview reviewByMessage = reviewList.GetReview("Not working");
        if (reviewByMessage != null)
        {
            Console.WriteLine($"ID: {reviewByMessage.Id}, Message: {reviewByMessage.Message}");
        }

        reviewList.Update(1, 5, "Excellent product");

        Console.WriteLine("\nUpdated Review by ID:");
        IReview updatedReviewById = reviewList.GetReview(1);
        if (updatedReviewById != null)
        {
            Console.WriteLine($"ID: {updatedReviewById.Id}, Message: {updatedReviewById.Message}");
        }

        Console.WriteLine("\nOverall Review:");
        string overallReview = reviewList.GetOverallReview();
        Console.WriteLine(overallReview);
    }
}

