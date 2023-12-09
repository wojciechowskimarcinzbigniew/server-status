using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using TestApp.Services;

namespace TestApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IClockService _ClockService;

    public HomeController(ILogger<HomeController> logger, IClockService clockService)
    {
        _logger = logger;
        _ClockService = clockService;
    }

    public IActionResult Index()
    {
        DateTime date = _ClockService.GetDate();
        return View(date);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
