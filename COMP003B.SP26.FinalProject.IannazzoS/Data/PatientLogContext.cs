using Microsoft.EntityFrameworkCore;
using COMP003B.SP26.FinalProject.IannazzoS.Models;
namespace COMP003B.SP26.FinalProject.IannazzoS.Data
{
    public class PatientLogContext : DbContext
    {
        public PatientLogContext(DbContextOptions<PatientLogContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }

}
