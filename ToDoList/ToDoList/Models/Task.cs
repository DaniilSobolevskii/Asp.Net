namespace ToDoList.Models;

public class Task
{
    public static List<Task> Tasks = new List<Task>();
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    
}