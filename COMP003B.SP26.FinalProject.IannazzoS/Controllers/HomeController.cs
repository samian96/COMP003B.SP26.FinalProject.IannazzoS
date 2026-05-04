using COMP003B.SP26.FinalProject.IannazzoS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
}
