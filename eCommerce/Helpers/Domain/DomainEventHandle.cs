using eCommerce.Helpers.Logging;
using eCommerce.Helpers.Repository;

namespace eCommerce.Helpers.Domain
{
    public class DomainEventHandle<TDomainEvent> : Handles<TDomainEvent>
        where TDomainEvent : DomainEvent
    {
        IRequestCorrelationIdentifier requestCorrelationIdentifier;
        IDomainEventRepository domainEventRepository;
        public DomainEventHandle(IRequestCorrelationIdentifier requestCorrelationIdentifier, IDomainEventRepository domainEventRepository)
        {
            this.requestCorrelationIdentifier = requestCorrelationIdentifier;
            this.domainEventRepository = domainEventRepository;
        }

        public void Handle(TDomainEvent @event)
        {
            @event.Flatten();
            @event.CorrelationID = this.requestCorrelationIdentifier.CorrelationID;
            this.domainEventRepository.Add(@event);
        }
    }
}
