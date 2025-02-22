using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
        {
            // Sample CV data (replace with your own)
            var cv = new CV
            {
                Name = "Your Name",
                Email = "your.email@example.com",
                Phone = "123-456-7890",
                Skills = new List<string> { "C#", "ASP.NET Core", "SQL", "JavaScript" },
                EducationHistory = new List<Education>
                {
                    new Education { Degree = "B.S. in Computer Science", Institution = "Your University", Year = "2018-2022" }
                },
                WorkExperience = new List<Experience>
                {
                    new Experience 
                    { 
                        JobTitle = "Software Developer", 
                        Company = "Tech Corp", 
                        Duration = "2022-Present", 
                        Description = "Developed web applications using ASP.NET Core."
                    }
                }
            };

            return View(cv);
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
