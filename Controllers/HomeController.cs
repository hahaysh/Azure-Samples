using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using broodwar03.Models;

namespace broodwar03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        broodwar.lib.GoDoWa goDowa = new broodwar.lib.GoDoWa();
        string strTemp = string.Empty;
        strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });
        Thread.Sleep(3000);
        ViewData["Message"] = strTemp;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
