namespace N52___T1.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }

    public Post(int id, string title, string description, string author)
    {
        Id = id;
        Title = title;
        Description = description;
        Author = author;
    }
}
