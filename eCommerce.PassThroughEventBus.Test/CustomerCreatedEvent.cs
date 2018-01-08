using System;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce.PassThroughEventBus.Test
{
    public class CustomerCreatedEvent : IEvent
    {
        public CustomerCreatedEvent(string customerName)
        {
            Id = Guid.NewGuid();
            Timestamp = DateTime.UtcNow;
            CustomerName = customerName;
        }
        public Guid Id { get; }

        public DateTime Timestamp { get; }

        public string CustomerName { get; }
    }

    public class CustomerCreatedEventHandler : IEventHandler<CustomerCreatedEvent>
    {
        public bool CanHandle(IEvent @event)
        {
            return @event.GetType().Equals(typeof(CustomerCreatedEvent));
        }

        public Task<bool> HandleAsync(IEvent @event)
        {
            return CanHandle(@event) ? HandleAsync((CustomerCreatedEvent)@event) : Task.FromResult(false);
        }

        public Task<bool> HandleAsync(CustomerCreatedEvent @event)
        {
            return Task.FromResult(true);
        }
    }
}
