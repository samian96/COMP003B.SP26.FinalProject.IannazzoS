using COMP003B.SP26.FinalProject.IannazzoS.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Tracing;
using System.Reflection;
namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
{
    [Route("context")]
    public class ContextController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var summary = new List<Summary>
            {
                new Summary {Id = 1, Article = 1, Title = "Appointments", Description = "Check to see if you have an appointment scheduled, or schedule a new appointment for yourself"}
            };
            return View(summary);
        }
        public IActionResult Summary(int id)
        {
            var details = new Summary { Id = id, Title = $"Summary {id}",};
            return RedirectToAction("Index", "Appointments");
        }
    }
}
