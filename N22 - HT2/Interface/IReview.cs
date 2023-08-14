namespace N22___HT2.Interface;

public interface IReview
{
    int Id { get; }
    int Star { get; set; }
    string Message { get; set; }
}
