using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11Rosenlund.Models;
using Mission11Rosenlund.Models.ViewModels;

namespace Mission11Rosenlund.Controllers;

public class HomeController : Controller
{
    private IBookRepository _repo;
    public HomeController(IBookRepository data)
    {
        _repo = data;
    }

    public IActionResult Index(int pageNum)
    {
        int pageSize = 10;
        
        var listData = new ProjectsList
        {
            Books = _repo.Books
            .OrderBy(b => b.BookId)
            .Skip((pageNum-1)*pageSize)
            .Take(pageSize),
            
            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = pageSize,
                TotalItems = _repo.Books.Count()
            }
        };
        
        return View(listData);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}