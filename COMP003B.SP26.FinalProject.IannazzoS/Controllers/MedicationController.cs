using Microsoft.AspNetCore.Mvc;
using COMP003B.SP26.FinalProject.IannazzoS.Models;
namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
{
    public class MedicationController : Controller
    {
        public IActionResult Index()
        {
            var medications = new List<Medication> {
                new Medication { Id = 1, Name = "Aspirin", Count = 10, Description = "400mg Aspirin for mild pain relief.", PrescriptionDate = DateTime.Now, DoctorNote = "Take as needed for pain 3 times a day." }

            };
            return View(medications);
        }
    }
}
