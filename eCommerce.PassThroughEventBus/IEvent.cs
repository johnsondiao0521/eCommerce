using System;

namespace eCommerce.PassThroughEventBus
{
    /// <summary>
    /// 事件消息的基本结构
    /// </summary>
    public interface IEvent
    {
        Guid Id { get; }
        DateTime Timestamp { get; }
    }
}
