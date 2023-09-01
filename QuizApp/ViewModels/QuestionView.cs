using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Models;

namespace QuizApp.ViewModels
{
    public class QuestionView
    {
        public Question? Question { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? DepartmentList { get; set; }
    }
}
