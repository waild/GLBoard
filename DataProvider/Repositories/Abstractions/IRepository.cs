using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Abstractions;
using System.Threading.Tasks;

namespace DataProvider.Repositories.Abstractions
{
    public interface IRepository<T, TKey> where T : class, IEntity<TKey>
    {
        ValueTask<T> GetAsync(TKey id);
        Task<List<T>> List();
        Task<List<T>> List(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
