namespace N32___T2;

public class ChatMessage
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public int ChatId { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Subject: {Subject}, Message: {Message}, ChatId: {ChatId}";
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() + Subject.GetHashCode() + Message.GetHashCode() + ChatId.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;

        ChatMessage other = (ChatMessage)obj;
        return Id == other.Id && Subject == other.Subject && Message == other.Message && ChatId == other.ChatId;

    }


}
