using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class ApplicationUser
    {
        public string Name { get; set; }
        [Key]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
        public string? ImageUrl { get; set; }    
    }
}
