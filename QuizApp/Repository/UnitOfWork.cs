using QuizApp.Data;
using QuizApp.Repository.IRepository;

namespace QuizApp.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        
            private AppDbContext _dbContext;
            public IDepartmentRepository Department { get; private set; }
            public IQuizRepository Quiz { get; private set; }
            public IQuestionRepository Question { get; private set; }
            
            public UnitOfWork(AppDbContext DbContext)
            {
                    _dbContext = DbContext;
                    Department = new DepartmentRepository(_dbContext);
                    Quiz = new QuizRepository(_dbContext); 
                    Question = new QuestionRepository(_dbContext);
            }
            public void Save()
            {
                _dbContext.SaveChanges();
            }
        
    }
}
