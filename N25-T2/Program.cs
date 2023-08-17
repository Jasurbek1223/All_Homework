namespace N25_T2;

public class Program
{//Inception
    static void Main(string[] args)
    {
        var movies = new List<Movie>
        {
            new Movie { Name = "Sherlock", Author = "Artur Conan Doel", Rating = 10 },
            new Movie { Name = "Sherlock", Author = "Christopher Nolan", Rating = 9.3 },
            new Movie { Name = "The Shawshank Redemption", Author = "Frank Darabont", Rating = 9.2 },
            new Movie { Name = "The Godfather", Author = "Francis Ford Coppola", Rating = 9.2 },
            new Movie { Name = "Pulp Fiction", Author = "Quentin Tarantino", Rating = 8.9 },
            new Movie { Name = "The Dark Knight", Author = "Christopher Nolan", Rating = 9.0 },
            new Movie { Name = "Fight Club", Author = "David Fincher", Rating = 8.8 },
            new Movie { Name = "Forrest Gump", Author = "Robert Zemeckis", Rating = 8.8 },
            new Movie { Name = "The Matrix", Author = "The Wachowskis", Rating = 8.7 },
            new Movie { Name = "The Lord of the Rings: The Return of the King", Author = "Peter Jackson", Rating = 8.9 },
            // Add more movies here...
        };

        var movieServise = new MovieService(movies);

        Console.WriteLine("Top 10 movies rating: ");

        List<Movie> topMovieesByRating = movieServise.GetByRating().Take(10).ToList();
        foreach(Movie movie in topMovieesByRating)
        {
            Console.WriteLine($"{movie.Name} by {movie.Author} - Rating: {movie.Rating}");
        }



    }
}