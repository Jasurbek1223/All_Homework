namespace N32___T2;

public class Program
{
    static void Main(string[] args)
    {
        ChatMessage message1 = new ChatMessage
        {
            Id = 1,
            Subject = "Greetings",
            Message = "Assalom",
            ChatId = 123
        };

        ChatMessage message2 = new ChatMessage
        {
            Id = 2,
            Subject = "Meeting",
            Message = "I have a meeting at 2 PM",
            ChatId = 207
        };

        Console.WriteLine(message1);
        Console.WriteLine(message2);

        Console.WriteLine("Are the message equal? " + (message1.Equals(message2) ? "Yes" : "No"));

    }
}