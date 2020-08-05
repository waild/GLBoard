using DataProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Abstractions;
using System.Threading.Tasks;

namespace DataProvider.Repositories
{
    public abstract class BaseRepository<T, TKey> : IRepository<T, TKey> where T : class, IEntity<TKey>
    {
        private readonly AppContext dataContext;

        public BaseRepository(AppContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Delete(T entity)
        {
            dataContext.Set<T>().Remove(entity);
        }

        public ValueTask<T> GetAsync(TKey id)
        {
            return dataContext.Set<T>().FindAsync(id);
        }

        public void Insert(T entity)
        {
            dataContext.Set<T>().Add(entity);
        }

        public Task<List<T>> List()
        {
            return dataContext.Set<T>().ToListAsync();
        }

        public Task<List<T>> List(Expression<Func<T, bool>> expression)
        {
            return dataContext.Set<T>().Where(expression).ToListAsync();
        }

        public void Update(T entity)
        {
            dataContext.Entry<T>(entity).State = EntityState.Modified;
        }
    }
    
}
