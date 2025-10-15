using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;
using AspNetCoreGeneratedDocument;

namespace basics.Controllers;

public class HomeController : Controller {
    public IActionResult Index()
    {
        return View(Repository.Courses);
    }
    public IActionResult Contact()
    {
        return View();
    }

}
