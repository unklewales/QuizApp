namespace QuizApp.Repository.IRepository
{
    public interface IUnitOfWork
    {
        
            IDepartmentRepository Department { get; }
            IQuizRepository Quiz { get; }
            IQuestionRepository Question { get; }

         
        void Save();


       
    }
}
