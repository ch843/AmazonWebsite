using System.Diagnostics;
using AmazonWebsite.Context;
using AmazonWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonWebsite.Controllers;

public class HomeController : Controller
{
    private IBookRepository _repo;

    public HomeController(IBookRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index()
    {
        IEnumerable<Book> books = _repo.Books;
        return View(books);
    }
}