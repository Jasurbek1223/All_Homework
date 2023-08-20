namespace N27_HT2;

internal class Program
{
    static void Main(string[] args)
    {
        List<VideoPost> videoPost = new List<VideoPost>
        {
            new VideoPost {Id = 1, Title = "Funny Cats", Description = "Nimadur", Likes = 1200, Dislikes = 200, Topics = Topics.Fun},
            new VideoPost {Id = 2, Title = "Programming", Description = "Python", Likes = 1500, Dislikes = 100, Topics = Topics.IT},
            new VideoPost {Id = 3, Title = "Biznes", Description = "Boshqaruv", Likes = 1100, Dislikes = 50, Topics = Topics.Business},
            new VideoPost {Id = 1, Title = "Mobile Legends", Description = "Action", Likes = 2000, Dislikes = 300, Topics = Topics.Gaming},
        };

        // Eng ko'p like
        var mostLikedVideo = videoPost.OrderByDescending(videoPost => videoPost.Likes).FirstOrDefault();
        Console.WriteLine($"Most Liked Video: {mostLikedVideo.Title} (Likes: {mostLikedVideo.Likes})");


        // Eng kam dislike
        var leastDislikedVideo = videoPost.OrderBy(videoPost => videoPost.Dislikes).FirstOrDefault();
        Console.WriteLine($"Least Disliked Video: {leastDislikedVideo.Title} (Dislikes: {leastDislikedVideo.Dislikes})");

        // Likelar o'rtachasi
        double averageLikes = videoPost.Average(v => v.Likes);
        Console.WriteLine($"Average Likes: {averageLikes}");

        // Dislikelar yig'indisi
        var sumDislike = videoPost.Sum(v => v.Likes);
        Console.WriteLine($"Total dislikes: {sumDislike}");

        // Faqat title va description bo'yicha chiqarib beradi
        var video = videoPost.Select(v => new {v.Title, v.Description}).ToList();
        Console.WriteLine($"Videolar haqida malumot:");
        foreach(var item in video)
        {
            Console.WriteLine("Title: " + item.Title + ", Description: " + item.Description);
        }

        // Enumdagi topiklar boyicham unique qilib beradi
        var uniqueTopic = videoPost.Select(v => v.Topics).Distinct();
        Console.WriteLine("Unique topics: ");
        foreach(var item in uniqueTopic)
        {
            Console.WriteLine(item);
        }



    }
}