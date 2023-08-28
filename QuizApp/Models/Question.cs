using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public int AnswerId { get; set; }
        [ForeignKey(nameof(Answer))]    
        public Answer Answer { get; set; }
        public int CorrectAnswerId { get; set; }
    }
}
