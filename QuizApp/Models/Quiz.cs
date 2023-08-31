using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        
        public string Title { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        [ValidateNever]
        public List<Question> Questions { get; set; }

    }
}
