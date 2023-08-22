using N28_HT1.Interfaces;

namespace N28_HT1.Models;

public class Event : IEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return $"{Name} {Date}";
    }
}
