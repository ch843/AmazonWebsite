using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AmazonWebsite.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}