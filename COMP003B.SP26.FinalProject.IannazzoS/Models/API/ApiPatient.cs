using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.IannazzoS.Models.API
{
    public class ApiPatient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public EmailAddressAttribute Email { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Refferal { get; set; }

    }
}
