using QuizApp.Models;

namespace QuizApp.Repository.IRepository
{
    public interface IQuestionRepository: IRepository<Question>
    {
        void Update(Question obj);
        List<Question> GetQuestionsForDepartment(int departmentId);
    }
}
