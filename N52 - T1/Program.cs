
using N52___T1.Extensions;
using N52___T1.Models;

var postsA = new List<Post>
{
    new (1, "O'tgan kunlar", "Roman", "O'tkir Hoshimov"),
    new (2, "Harry potter", "Fantastika", "Agata Kristi"),
    new (3, "Title3", "Description3", "Author3")
};

var postsB = new List<Post>
{ 
    new (1, "Title5", "Description5", "Author5"),
    new (2, "Title3", "Description3", "Author3"),
    new (1, "Title4", "Description4", "Author4"),
   
};

var posts = postsA.ZipIntersectBy(postsB, post => post.Id);

foreach (var (postA, postB) in posts)
{
    Console.WriteLine($"{postA.Title} {postA.Description}  -  {postB.Title} {postB.Description}");
}
