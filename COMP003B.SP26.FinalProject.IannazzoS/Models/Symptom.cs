using System.ComponentModel.DataAnnotations;
namespace COMP003B.SP26.FinalProject.IannazzoS.Models
{
    public class Symptom
    {
        public int SymptomId { get; set; }

        [Required]

        public string Name { get; set; }

        // navigation 

        public virtual ICollection<Appointment>? Appointments { get; set; }
    }
}
