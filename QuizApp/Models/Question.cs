using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int CorrectAnswerId { get; set; }
        [ForeignKey("CorrectAnswerId")]
        public Answer CorrectAnswer { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        //public int AnswerId { get; set; }
        //  public Answer? Answer { get; set; }

    }
}
