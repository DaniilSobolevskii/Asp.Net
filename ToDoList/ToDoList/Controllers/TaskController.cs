using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;


namespace ToDoList.Controllers;
using ToDoList.Models;

public class HomeController : Controller
{
    /*[HttpPost()]
    public IActionResult GetTask([FromQuery] int id, [FromBody] string name, string description)
    {
        var task = new Task{Id = id,Name = name, Description = description};
        ToDoList.Models.Task.Tasks.Add(task);
        return RedirectToAction("Index");
    }
    private readonly ILogger<HomeController> _logger;
*/
    [HttpPost]
   
    public IActionResult Insert(Task task)
    {
        Task.Tasks.Add(task);
        return RedirectToAction("Index");
    }
  
   
    public IActionResult Index()
    {
        return View();
    }
    
   
}