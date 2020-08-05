using DataProvider;
using DataProvider.Repositories.Abstractions;
using Domain.Abstractions;
using Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Services
{
    public class BaseCRUDService<T, TKey> : IBaseCRUDService<T, TKey> where T : class, IEntity<TKey>
    {
        private readonly UnitOfWork uow;
        private readonly IRepository<T, TKey> repository;

        public BaseCRUDService(UnitOfWork uow, IRepository<T, TKey> repository)
        {
            this.uow = uow;
            this.repository = repository;
        }

        public async Task Delete(TKey id)
        {
            var entity = await repository.GetAsync(id);
            repository.Delete(entity);
            await uow.SaveAsync();
        }

        public async Task<T> Get(TKey id)
        {
            var entity = await repository.GetAsync(id);
            return entity;
        }

        public async Task Insert(T entity)
        {
            repository.Insert(entity);
            await uow.SaveAsync();
        }

        public async Task<IList<T>> List()
        {
            var entities = await repository.List();
            return entities;
        }

        public async Task<IList<T>> List(Expression<Func<T, bool>> expression)
        {
            var entities = await repository.List(expression);
            return entities;
        }

        public async Task Update(T entity)
        {
            repository.Update(entity);
            await uow.SaveAsync();
        }
    }
}
