using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers;

public class BlogController : Controller
{
    [HttpGet]
    public IActionResult AddBlog()
    {
        return View();
    }
    
}