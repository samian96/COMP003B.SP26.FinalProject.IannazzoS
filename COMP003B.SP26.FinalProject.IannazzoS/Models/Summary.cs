using System.ComponentModel.DataAnnotations;
namespace COMP003B.SP26.FinalProject.IannazzoS.Models
{
    public class Summary
    {
        public int Id { get; set; }
        [Required]
        [Range(1,10)]
        public int Article { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
