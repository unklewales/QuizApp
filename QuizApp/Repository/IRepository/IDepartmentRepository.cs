using QuizApp.Models;

namespace QuizApp.Repository.IRepository
{
    public interface IDepartmentRepository: IRepository<Department>
    {
       
        void Update(Department obj);
    }
}
