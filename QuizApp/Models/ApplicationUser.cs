using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
        //public IEnumerable<SelectListItem>? DepartmentList { get; set; }
        
        public String ImageUrl { get; set; }    
    }
}
