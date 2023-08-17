namespace TaskManagerSmall;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("404");
        var taskService = new TaskService();

        Taskk task1 = new Taskk("vazifa1", Priority.Low, DateTime.Now.AddDays(2));
        Taskk task2 = new Taskk("vazifa2", Priority.Hight, DateTime.Now.AddDays(1));
        Taskk task3 = new Taskk("vazifa3", Priority.Hight, DateTime.Now.AddHours(2));
        Taskk task4 = new Taskk("vazifa4", Priority.Medium, DateTime.Now.AddDays(4));
        Taskk task5 = new Taskk("vazifa5", Priority.Low, DateTime.Now.AddHours(8));

        taskService.Add(task1);
        taskService.Add(task2);
        taskService.Add(task3);
        taskService.Add(task4);
        taskService.Add(task5);
        
        taskService.DisplayAllTasks();
        Console.WriteLine("200");


    }
}