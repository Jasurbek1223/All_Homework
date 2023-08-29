namespace N32___T6;

public class BlogService
{
    private List<Blog> blogs;

    public BlogService(List<Blog> blogs)
    {
        this.blogs = blogs;
    }

    private void ValidateOnCreate(Blog model)
    {
        if(string.IsNullOrWhiteSpace(model.Title) || string.IsNullOrWhiteSpace(model.Body))
        {
            throw new ValidationException("Title and Body cannot by empty");
        }
    }

    private void ValidateOnUpdate(Blog model)
    {
        if (string.IsNullOrWhiteSpace(model.Title) || string.IsNullOrWhiteSpace(model.Body))
        {
            throw new ValidationException("Title and Body cannot by empty");
        }
    }

    public void Create(Blog model)
    {
        ValidateOnCreate(model);

        blogs.Add(model);
    }

    public Blog Get(int id)
    {
        if(id < 0 || id > blogs.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(id), " invalid blog ID.");
        }

        return blogs[id];
    }

    public void Update(Blog model)
    {
        ValidateOnUpdate(model);

        int index = blogs.FindIndex(blog => blog.Id == model.Id);

        if(index == -1)
        {
            throw new InvalidOperationException("Blog not found");
        }

        // Update logic
        blogs[index] = model;
    }

    public void Delete(int id)
    {
        if(id < 0 && id > blogs.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(id), "Invalid Blog Id.");
        }

        blogs.RemoveAt(id);
    }
    










}

public class ValidationException : Exception
{
    public ValidationException(string message) : base(message) { }
}