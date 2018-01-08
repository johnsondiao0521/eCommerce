
using System.Threading.Tasks;

namespace eCommerce.PassThroughEventBus
{
    /// <summary>
    /// 事件处理器
    /// </summary>
    public interface IEventHandler
    {
        /// <summary>
        /// 定义了事件的处理过程
        /// </summary>
        /// <param name="event"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> HandleAsync(IEvent @event);

        /// <summary>
        /// 用以确定传入的事件对象是否可被当前处理器所处理
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        bool CanHandle(IEvent @event);
    }

    public interface IEventHandler<in T> : IEventHandler
        where T : IEvent
    {
        Task<bool> HandleAsync(T @event);
    }
}
