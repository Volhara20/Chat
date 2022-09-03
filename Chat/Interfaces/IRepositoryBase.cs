using System.Linq.Expressions;

namespace Chat.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<ICollection<T>> GetAll();
        Task<ICollection<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
