namespace N25_T2;

class MovieService
{
    private List<Movie> movies;

    public MovieService(List<Movie> movies)
    {
        this.movies = movies;
    }

    public List<Movie> Search(string searchKeyword)
    {
        return movies
            .Where(movie => movie.Name.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase) || movie.Author.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public bool Add(string name, string author, double rating)
    {
        if (movies.Any(movie => movie.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && movie.Author.Equals(author, StringComparison.OrdinalIgnoreCase)))
        {
            return false; // Movie with same name and author already exists
        }

        movies.Add(new Movie { Name = name, Author = author, Rating = rating });
        return true; // Movie added successfully
    }

    public List<Movie> GetByRating()
    {
        return movies.OrderByDescending(movie => movie.Rating).ToList();
    }
}
