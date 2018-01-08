using System;

namespace eCommerce.PassThroughEventBus
{
    /// <summary>
    /// 事件订阅者
    /// </summary>
    public interface IEventSubscriber : IDisposable
    {
        void Subscribe();
    }
}
