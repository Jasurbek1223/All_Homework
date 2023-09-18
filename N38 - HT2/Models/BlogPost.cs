namespace N38___HT2.Models;

public class BlogPost
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"PostId : {PostId}, Title : {Title}, Content : {Content}";
    }
}
