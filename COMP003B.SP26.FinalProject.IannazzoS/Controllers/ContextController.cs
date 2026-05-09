

using COMP003B.SP26.FinalProject.IannazzoS.Models;
using Microsoft.AspNetCore.Mvc;
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
                new Summary {Id = 1, Article = 1, Title = "Appointments", Description = "Check to see if you have an appointment scheduled, or schedule a new appointment for yourself"},

                new Summary {Id = 2, Article = 2, Title = "Patients", Description = "Check to see if you already have a patient account or need to create a new patient account."}
            };
            return View(summary);
        }
        public IActionResult Summary(int id)
        {
            var details = new Summary { Id = id, Title = $"Summary {id}", Description = "This area should be filled with information on the article",  };
            return View(details);
        }
    }
}
