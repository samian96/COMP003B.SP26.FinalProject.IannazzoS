using COMP003B.SP26.FinalProject.IannazzoS.Models.API;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
namespace COMP003B.SP26.FinalProject.IannazzoS.Data
{
    public static class PatientInfo
    {
        public static List<ApiPatient> Patients { get; } = new()
        {
            new ApiPatient {Id = 1, Name ="Sam", Age = 30, Medicine = "Aspirin", AppointmentDate = DateTime.UtcNow }
        };
    }
}
