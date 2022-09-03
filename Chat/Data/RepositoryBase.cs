using Chat.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Chat.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationContext Context { get; set; }
        public RepositoryBase(ApplicationContext context)
        {
            Context = context;
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<ICollection<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await Context.Set<T>().Where(expression).ToListAsync();
        }

        public Task Create(T entity)
        {
            Context.Set<T>().Add(entity);
            return Task.CompletedTask;
        }

        public Task Update(T entity)
        {
            Context.Set<T>().Update(entity);
            return Task.CompletedTask;
        }

        public Task Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }
    }
}
