using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.IannazzoS.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // collection navigation
        public virtual ICollection<Appointment>? Appointments { get; set; }
    }
}
