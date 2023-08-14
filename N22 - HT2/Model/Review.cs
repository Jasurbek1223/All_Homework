using N22___HT2.Interface;

namespace N22___HT2.Model;

public class Review : IReview
{
    public int Id { get; set; }
    public int Star { get; set; }
    public string Message { get; set; }
}
