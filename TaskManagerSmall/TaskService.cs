namespace TaskManagerSmall;

class TaskService
{
    private List<Taskk> tasks;

    public TaskService()
    {
        tasks = new List<Taskk>();
    }


    public void Add(Taskk task)
    {
        task.Id = tasks.Count() + 1;
        tasks.Add(task);
    }

    public void ComplateTask(int taskId)
    {
        tasks.Find(x=>x.Id == taskId).IsCompleted = true;

    }

    public List<Taskk> GetTasks(Priority priority)
    {
        var res = tasks.Where(item => item.Priority == priority).ToList();
        return res;
    }

    public void DisplayAllTasks()
    {
        tasks.ForEach(Console.WriteLine);
    }

    public List<Taskk> GetTaskList()
    {
        return tasks;
    }

}
