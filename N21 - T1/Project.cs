namespace N21___T1;

public class Project
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Task> Tasks { get; set; }


    public void AddTask(Task task)
    {
        Tasks.Add(task);
    }


}
