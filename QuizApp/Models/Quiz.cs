using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<Question> Questions { get; set; }
        public int QuestionId { get; set; }
        [ForeignKey(nameof(Questions))] 
        public Question? Question { get; set; }


    }
}
