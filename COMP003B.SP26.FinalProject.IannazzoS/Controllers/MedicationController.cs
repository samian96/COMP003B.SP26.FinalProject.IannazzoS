using Microsoft.AspNetCore.Mvc;
using COMP003B.SP26.FinalProject.IannazzoS.Models;
namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
{
    [Route("event")]
    public class MedicationController : Controller
    {
        [HttpGet("medication/{medication}")]
        public IActionResult OrderForm(string medication)
        {
            return View();
        }

        [HttpPost("medication/{medication}")]
        public IActionResult OrderForm([FromForm] Medication medication)
        {
            if (!ModelState.IsValid)
            {
                return View(medication);
            }
            return RedirectToAction("Success", medication);
        }
    }
}
