using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers;

public class StudentController : Controller
{

    private static readonly List<Student> _students = new()
    {
        new Student {Id=1, Name="Rohit Patil", Age=22, Course="Computer Engineering"},
        new Student {Id=2, Name="Adarsh Khumbhar", Age=22, Course="Computer Science"},
        new Student {Id=3, Name="Shantanu Patil", Age=25, Course="Computer Engineering"},
        new Student {Id=4, Name="Sahil Patil", Age=22, Course="Artificial Intelligence"},
    };
    public IActionResult Index()
    {
        ViewBag.WelcomeMessage="Welcome to Student Portal!";
        ViewBag.Today=DateTime.Now.ToString("dddd, dd MM yyyy");
        ViewData["StudentCount"]=_students.Count;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        var student = _students.FirstOrDefault(s=>s.Id==id);
        if (student == null)
        {
            return View("StudentNotFound");
        }

        return View(student);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string name,int age,string course)
    {
        var newId=_students.Max(s=>s.Id)+1;
        _students.Add(new Student{Id=newId, Name=name, Age=age, Course=course});
        ViewBag.SuccessMessage=$"Student {name} added!";
        return View("Success");
    }

    [Route("students/all")]
    public IActionResult AllStudents()
    {
        return View(_students);    
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


