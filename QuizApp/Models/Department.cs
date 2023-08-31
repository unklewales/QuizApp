using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuizApp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [DisplayName("Name  of Department")]
        public string? DepartmentalName { get; set; } 
           
        
    }
}
