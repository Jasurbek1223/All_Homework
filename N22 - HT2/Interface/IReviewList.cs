namespace N22___HT2.Interface;

public interface IReviewList<TReview> where TReview : IReview
{
    void Add(TReview review);
    void Update(int id, int star, string message);
    void Remove(int id);
    void Remove(TReview review);
    TReview GetReview(int id);
    TReview GetReview(string message);
    string GetOverallReview();
}
                           