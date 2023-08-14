namespace N23_T2;

internal class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
                new Book("Qora Qol" , 9, "Jack London"),
                new Book("Uning ochiq asri", 7, "Jorj Oruel"),
                new Book("Toqmoq vaqt", 6, "William Faulkner"),
                new Book("Uylar va qorqinchoqlar kitobi" , 8, "Mark Twain"),
                new Book("Hindcha vaqli", 5, "Jorj Oruel"),
                new Book("Zamonga qarshi yoʻl", 10, "Jack London"),
                new Book("Tovush va g'azab", 1, "William Faulkner"),
                new Book("Alisa Wonderlandda", 10, "Lewis Carroll"),
                new Book("Harri Potter va Felsefe Ta'si", 4, "Lewis Carroll"),
                new Book("Qora kitob" , 6, "Mark Twain")
        };
        
        // Sortlash rating bo'yicham
        var rating = books.OrderByDescending(book => book.Rating).ToList();
        foreach (var book in rating)
            Console.WriteLine($"Rating: {book.Rating}, Author: {book.Author}, Book Name: {book.Name} ");
        Console.WriteLine();


        Console.Write("Kimning kitobini qidirmoqchisiz: ");
        var avtor = Console.ReadLine();

        var engYaxshiKitobi = books.Where(x=>x.Author.ToLower() == avtor.ToLower()).OrderByDescending(book => book.Rating).ToList().First();
        Console.WriteLine($"{engYaxshiKitobi.Author}ning eng yaxshi kitobi: {engYaxshiKitobi.Name}, Rating: {engYaxshiKitobi.Rating}");

        var engYomonKitobi = books.Where(x => x.Author.ToLower() == avtor.ToLower()).OrderByDescending(book => book.Rating).ToList().Last();
        Console.WriteLine($"{engYomonKitobi.Author}ning eng yomon kitobi: {engYomonKitobi.Name}, Rating: {engYomonKitobi.Rating}");


    }
}