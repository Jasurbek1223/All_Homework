namespace TaskManagerSmall;

class Taskk
{
    public int Id { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }

    public Taskk(string description, Priority priority, DateTime deadline)
    {
        Description = description;
        Priority = priority;
        Deadline = deadline;
        IsCompleted = false;
        CreatedDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Id}\n" +
            $"{Description}\n" +
            $"{Priority}\n" +
            $"{CreatedDate}\n" +
            $"{Deadline}\n" +
            $"{IsCompleted}\n";
    }

}
