using QuizApp.Data;
using QuizApp.Models;
using QuizApp.Repository.IRepository;
using static QuizApp.Repository.DepartmentRepository;

namespace QuizApp.Repository
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
       
            private AppDbContext _dbContext;
            public DepartmentRepository(AppDbContext DbContext) : base(DbContext)
            {
                _dbContext = DbContext;
            }



            public void Update(Department obj)
            {
                _dbContext.Departments.Update(obj);
            }
        //or
    }
}
