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

    public IActionResult Index(int pageNum = 1)
    {
        int pageSize = 10;
        
        var books = _repo.Books
            .OrderBy(x => x.Title)
            .Skip((pageNum - 1) * pageSize)
            .Take(pageSize);

        ViewBag.PageCount = (int)Math.Ceiling((double)books.Count() / pageSize);
        ViewBag.PageNum = pageNum;
        ViewBag.PageSize = pageSize;
        
        return View(books);
    }
}