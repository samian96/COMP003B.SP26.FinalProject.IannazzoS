using COMP003B.SP26.FinalProject.IannazzoS.Models.API;
using COMP003B.SP26.FinalProject.IannazzoS.Data;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientLog : Controller
    {// should get all patient information from data
        [HttpGet]
        public ActionResult<List<ApiPatient>> GetPatients()
        {
            return Ok(PatientInfo.Patients);
        }
        // gets information by Id number
        [HttpGet("{id}")] 
        public ActionResult<ApiPatient> GetPatients(int id)
        {
            var patient = PatientInfo.Patients.FirstOrDefault(p => p.Id == id);

            if (patient is null)
                return NotFound();

            return Ok(patient);
        }
        // should handle updating patient information
        [HttpPut("{id}")]
        public IActionResult UpdatePatient(int id, ApiPatient updatedPatient)
        {
            var existingPatient = PatientInfo.Patients.FirstOrDefault(p => p.Id == id);
            // returns a bad request if not found
            if (existingPatient is null)
                return BadRequest();
            // updates existing properties of patients
            existingPatient.Name = updatedPatient.Name;
            existingPatient.Age = updatedPatient.Age;
            existingPatient.Medicine = updatedPatient.Medicine;
            existingPatient.AppointmentDate = updatedPatient.AppointmentDate;

            return NoContent();

        }
    }
}
