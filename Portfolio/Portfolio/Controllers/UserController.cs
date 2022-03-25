using Microsoft.AspNetCore.Mvc;
using PorfolioDataAccess;

namespace Portfolio.Controllers;

public class UserController : Controller
{
    private readonly Context _context;

    public UserController(Context context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult User()
    {
        return View();
    }
}