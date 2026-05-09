

using COMP003B.SP26.FinalProject.IannazzoS.Models;
using Microsoft.AspNetCore.Mvc;
namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
// note: Not sure why the api keeps grabbing the info from this, I know its grabbing from the summary Id I am pretty sure
{
    
    [Route("context")]
    public class ContextController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            var summary = new List<Summary>
            {
                new Summary {Id = 1, Article = 1, Title = "Appointments", Description = "Check to see if you have an appointment scheduled, or schedule a new appointment for yourself"},

                new Summary {Id = 2, Article = 2, Title = "Patients", Description = "Check to see if you already have a patient account or need to create a new patient account."},

                new Summary {Id = 3, Article = 3, Title = "Symptoms", Description = "Check to see what type of symptoms you are experiencing"},

                new Summary {Id = 4, Article = 4, Title = "Contact Us", Description = "Contact us if you are looking for a virtual appoiintment over an in person one."}
            };
            return View(summary);
        }
        [HttpGet("summary/{id}")]
        public IActionResult Summary(int id)
        {
            var details = new Summary { Id = id, Title = $"Summary {id}", Description = "This area should be filled with information on the article",  };
            return View(details);
        }
    }
}
