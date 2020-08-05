using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction
{
    public interface IBaseCRUDService<T, Tkey>
    {
        Task<T> Get(Tkey id);
        Task<IList<T>> List();
        Task<IList<T>> List(Expression<Func<T, bool>> expression);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(Tkey id);
    }
}
