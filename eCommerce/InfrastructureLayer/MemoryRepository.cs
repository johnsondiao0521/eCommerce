using System;
using System.Collections.Generic;
using System.Linq;
using eCommerce.Helpers.Domain;
using eCommerce.Helpers.Repository;
using eCommerce.Helpers.Specification;

namespace eCommerce.InfrastructureLayer
{
    public class MemoryRepository<TEntity> : IRepository<TEntity>
        where TEntity : IAggregateRoot
    {

        protected static List<TEntity> entities = new List<TEntity>();
        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<TEntity> Find(ISpecification<TEntity> spec)
        {
            return entities.Where(spec.IsSatisfiedBy);
        }

        public TEntity FindById(Guid id)
        {
            return entities.Where(c => c.Id == id).FirstOrDefault();
        }

        public TEntity FindOne(ISpecification<TEntity> spec)
        {
            return entities.Where(spec.IsSatisfiedBy).FirstOrDefault();
        }

        public void Remove(TEntity entity)
        {
            entities.Remove(entity);
        }
    }
}
