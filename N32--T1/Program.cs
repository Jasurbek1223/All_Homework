namespace N32__T1;

public class Program
{
    static void Main(string[] args)
    {
        List<ShortenedLink> links = new List<ShortenedLink>();

        ShortenedLink link1 = new ShortenedLink
        {
            Id = 1,
            OriginalUrl = "https://www.example.com/page1",
            ShortenedUrl = "https://short.link/abc"
        };
        links.Add(link1);

        ShortenedLink link2 = new ShortenedLink
        {
            Id = 2,
            OriginalUrl = "https://www.example.com/page2",
            ShortenedUrl = "https://short.link/def"
        };
        links.Add(link2);

        // Check if the shortened URLs are unique
        bool areShortenedUrlsUnique = AreShortenedUrlsUnique(links);
        Console.WriteLine($"Are shortened URLs unique? {areShortenedUrlsUnique}");
    }

    static bool AreShortenedUrlsUnique(List<ShortenedLink> links)
    {
        HashSet<string> shortenedUrls = new HashSet<string>();

        foreach (var link in links)
        {
            if (!shortenedUrls.Add(link.ShortenedUrl))
            {
                return false;
            }
        }

        return true;
    }






}