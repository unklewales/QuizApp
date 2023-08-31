using QuizApp.Data;
using QuizApp.Models;
using QuizApp.Repository.IRepository;
using static QuizApp.Repository.DepartmentRepository;

namespace QuizApp.Repository
{
    public class QuizRepository : Repository<Quiz>, IQuizRepository
    {
       
            private AppDbContext _dbContext;
            public QuizRepository(AppDbContext DbContext) : base(DbContext)
            {
                _dbContext = DbContext;
            }



            public void Update(Quiz obj)
            {
                _dbContext.Quizes.Update(obj);
            }

        
    }
}
