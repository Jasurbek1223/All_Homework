namespace AsyncTaskManagement;


public class Program
{
    static async void Main(string[] args)
    {
        TaskService taskService = new TaskService();
        List<TaskItem> tasks = await taskService.LoadTasksAsync();

        TaskItem newTask = new TaskItem
        {
            Id = 1,
            Description = "Test",
            IsCompleted = false
        };

        await taskService.AddTaskAsync(tasks, newTask);
        Console.WriteLine("Task Added");

        await taskService.CompletedTask(tasks, 1);
        Console.WriteLine("Task Completed");



    }
}