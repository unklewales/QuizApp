using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public string OptionA { get; set; }
        
        public bool IsCorrect { get; set; }

        [ForeignKey("QuizId")]
        public int QuizId { get; set; }
        
        public Quiz? Quiz { get; set; }

    }
}
