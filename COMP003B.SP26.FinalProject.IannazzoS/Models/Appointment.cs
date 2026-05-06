using System.ComponentModel.DataAnnotations;
namespace COMP003B.SP26.FinalProject.IannazzoS.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int SymptomId { get; set; }


        // nullable nav properties
        public virtual Patient? Patient { get; set; }
        public virtual Symptom? Symptom { get; set; }
    }
}
