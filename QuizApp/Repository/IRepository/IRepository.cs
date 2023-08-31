using System.Linq.Expressions;

namespace QuizApp.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T GetAObj(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void AddAObj(T obj);
        void RemoveAObj(T obj);
      
    }
}
