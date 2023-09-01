namespace QuizApp.Repository.IRepository
{
    public interface IUnitOfWork
    {
        
            IDepartmentRepository Department { get; }
            
            IQuestionRepository Question { get; }

         
        void Save();


       
    }
}
