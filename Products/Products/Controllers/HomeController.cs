using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Products.Models;

namespace Products.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index( string name, string description,string gender)
    {
        var model = new Product { Name = name, Dexcription = description, Gender = gender};
        return View(model);
    }

    [HttpPost("postProduct")]
    public IActionResult AnotherIndex( string name, string description,string gender)
    {
        var model = new Product { Name = name, Dexcription = description, Gender = gender};
        return View("Index",model);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}