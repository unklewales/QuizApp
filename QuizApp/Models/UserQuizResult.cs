using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class UserQuizResult
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser? ApplicationUser { get; set; }    

        public int QuizId { get; set; }
        [ForeignKey("QuizId")]  
        public Quiz? Quiz { get; set; }
        public int Score { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
