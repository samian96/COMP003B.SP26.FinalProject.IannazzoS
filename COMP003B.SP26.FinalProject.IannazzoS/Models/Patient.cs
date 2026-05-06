using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.IannazzoS.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(3,100)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string Referral { get; set; } = string.Empty;

        // collection navigation
        public virtual ICollection<Appointment>? Appointments { get; set; }
    }
}
