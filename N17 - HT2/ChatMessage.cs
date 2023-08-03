namespace N17___HT2;

internal class ChatMessage
{
    public int Id { get;  }
    public DateTime SentTime { get; }
    public DateTime EditedTime { get; private set; }
    public string Content { get; set; }

    public ChatMessage(int id, DateTime sentTime, string content) 
    {
        Id = id;
        SentTime = sentTime;
        Content = content;
    }

    public ChatMessage(ChatMessage chatMessage)
    {
        Id = chatMessage.Id;
        SentTime = chatMessage.SentTime;
        Content = chatMessage.Content;
        EditedTime = DateTime.Now;
    }




}
