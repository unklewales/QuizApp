using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizApp.Models;

namespace QuizApp.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Answer> Answers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserQuizResult> UserQuizResults { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)         // A Question can have many Answers
                .WithOne(a => a.Question)        // An Answer belongs to one Question
                .HasForeignKey(a => a.QuestionId); // Foreign key relationship

            modelBuilder.Entity<Question>()
                .HasOne(q => q.CorrectAnswer)    // A Question has one CorrectAnswer
                .WithOne()                       // A CorrectAnswer is not pointing back to Question
                .HasForeignKey<Question>(q => q.CorrectAnswerId);

        }
    }
}
