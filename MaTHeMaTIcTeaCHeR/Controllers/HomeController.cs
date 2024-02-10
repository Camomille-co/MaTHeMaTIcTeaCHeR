using MaTHeMaTIcTeaCHeR.Data;
using MaTHeMaTIcTeaCHeR.Data.Identity;
using MaTHeMaTIcTeaCHeR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaTHeMaTIcTeaCHeR.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _application;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext application)
        {
            _application = application;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FOS()
        {
            return View("FOS");
        }

        public IActionResult Homework()
        {
            return View("Homework");
        }

        public IActionResult Lectures()
        {
            return View("Lectures");
        }

        public IActionResult RPD()
        {
            return View("RPD");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page";

            return View( _application.Users.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
