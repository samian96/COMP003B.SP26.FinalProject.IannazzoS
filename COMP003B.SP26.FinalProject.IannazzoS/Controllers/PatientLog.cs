using COMP003B.SP26.FinalProject.IannazzoS.Models.API;
using COMP003B.SP26.FinalProject.IannazzoS.Data;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP26.FinalProject.IannazzoS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientLog : Controller
    {
        [HttpGet]
        public ActionResult<List<ApiPatient>> GetPatients()
        {
            return Ok(PatientInfo.Patients);
        }
    }
}
