using System.ComponentModel.DataAnnotations;
namespace COMP003B.SP26.FinalProject.IannazzoS.Models
{
    public class Medication
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(10,120)]
        public int Count { get; set; }

        [Required]
        [StringLength(100)]

        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PrescriptionDate { get; set; }

        [StringLength(300)]
        public string? DoctorNote { get; set; }

        // collection navigation
        public virtual ICollection<Appointment>? Appointments { get; set; }
    }
}
