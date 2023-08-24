using System.Text.Json;

namespace AsyncTaskManagement;

public class TaskService
{
    private string _filePath = @"D:\\.NET_new\\fayll";

    public async Task AddTaskAsync(List<TaskItem> tasks, TaskItem newTask)
    {
        tasks.Add(newTask);
    }

    public async Task CompletedTask(List<TaskItem> tasks, int taskId)
    {
        TaskItem taskToUpdate= tasks.FirstOrDefault(task => task.Id == taskId);
        if (taskToUpdate != null)
        {
            taskToUpdate.IsCompleted = true;
        }
    }

    private async Task SaveAsync(TaskItem task)
    {
        var fileName = $"{nameof(task)}.docx";
        using (StreamWriter streamWriter = new StreamWriter(fileName))
        {
            streamWriter.WriteAsync($"{task.Id} {nameof(task)}");
        }
        
    }

    public async Task<List<TaskItem>> LoadTasksAsync()
    {
        if (File.Exists(_filePath))
        {
            using (StreamReader file = File.OpenText(_filePath))
            {
                var tasksJson = await file.ReadToEndAsync();
                return JsonSerializer.Deserialize<List<TaskItem>>(tasksJson);
            }
        }
        else
        {
            return new List<TaskItem>();
        }
    }




}
