using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public interface IGenericRepository<TEntity>
    {
        void Create(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
