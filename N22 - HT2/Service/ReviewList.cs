using N22___HT2.Interface;

namespace N22___HT2.Service;

public class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
{
    private List<TReview> reviews = new List<TReview>();

    public void Add(TReview review)
    {
        reviews.Add(review);
    }

    public void Update(int id, int star, string message)
    {
        TReview review = reviews.Find(r => r.Id == id);
        if (review != null)
        {
            review.Star = star;
            review.Message = message;
        }
    }

    public void Remove(int id)
    {
        reviews.RemoveAll(r => r.Id == id);
    }

    public void Remove(TReview review)
    {
        reviews.Remove(review);
    }

    public TReview GetReview(int id)
    {
        return reviews.FirstOrDefault(r => r.Id == id);
    }

    public TReview GetReview(string message)
    {
        return reviews.FirstOrDefault(r => r.Message == message);
    }

    public string GetOverallReview()
    {
        if (reviews.Count == 0)
        {
            return "Sharx yozish";
        }

        bool allFiveStars = reviews.All(r => r.Star == 5);
        if (allFiveStars)
        {
            return "5 yulduzli";
        }

        TReview lowestRated = reviews.OrderBy(r => r.Star).First();
        return lowestRated.Message;
    }
}


