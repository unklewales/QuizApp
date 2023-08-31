using QuizApp.Data;
using QuizApp.Models;
using QuizApp.Repository.IRepository;
using static QuizApp.Repository.DepartmentRepository;

namespace QuizApp.Repository
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
       
            private AppDbContext _dbContext;
            public QuestionRepository(AppDbContext DbContext) : base(DbContext)
            {
                _dbContext = DbContext;
            }



            public void Update(Question obj)
            {
                _dbContext.Questions.Update(obj);
            }
        //or
    }
}
