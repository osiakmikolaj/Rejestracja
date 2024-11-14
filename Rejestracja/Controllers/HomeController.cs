using Microsoft.AspNetCore.Mvc;
using Rejestracja.Models;
using System.Diagnostics;

namespace Rejestracja.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() { 
            return View();
        }

        [HttpPost]
        public IActionResult Register(User data)
        {
            if (ModelState.IsValid)
            {
                return View("Success", data);
            }
            else 
            { 
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
