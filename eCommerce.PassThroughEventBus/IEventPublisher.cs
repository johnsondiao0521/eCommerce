using System;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce.PassThroughEventBus
{
    /// <summary>
    /// 事件发布者
    /// </summary>
    public interface IEventPublisher : IDisposable
    {
        Task PublishAsync<TEvent>(TEvent @event)
            where TEvent : IEvent;
    }
}
