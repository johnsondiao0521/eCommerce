using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain
{
    public class DomainEventHandle<T> : IHandles<T>
        where T : DomainEvent
    {
        IDomainEventRepository domainEventRepository;
        public DomainEventHandle(IDomainEventRepository domainEventRepository)
        {
            this.domainEventRepository = domainEventRepository;
        }
        public void Handle(T domainEvent)
        {
            domainEvent.Flatten();
            domainEvent.CorrelationID = Guid.NewGuid().ToString();
            domainEventRepository.Add(domainEvent);
        }
    }
}
