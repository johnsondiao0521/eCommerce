using System;
using System.Collections.Generic;

namespace eCommerce.Domain
{
    public interface IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity FindById(Guid id);
        TEntity FindOne(Func<TEntity, bool> whereLambda);
        IEnumerable<TEntity> Find(Func<TEntity, bool> whereLambda);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
