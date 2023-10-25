using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course
        {
            Id = 1,

            Title = "Aspnet Core Kurs",

            Description = "Merhaba"


        };


        return View(kurs);
    }

    public IActionResult List()
    {
        var kurslar = new List<Course>(){
            new Course() { Id = 1, Title="AspNet Kurs", Description="Muhteşem Bir Kurs Eğitimi."},

            new Course() { Id = 2, Title="Flutter Kurs", Description="Eşsiz Bir Kurs Eğitimi."},

            new Course() { Id = 3, Title="Python Kurs", Description="Harikulade Bir Kurs Eğitimi."}
        };
        return View("CourseList", kurslar);
    }
}