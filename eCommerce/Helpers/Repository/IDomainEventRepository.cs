using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Domain;

namespace eCommerce.Helpers.Repository
{
    public interface IDomainEventRepository
    {
        void Add<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent;
        IEnumerable<DomainEventRecord> FindAll();
    }
}
