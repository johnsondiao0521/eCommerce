using System;

namespace eCommerce.Helpers.Domain
{
    /// <summary>
    /// 聚合根
    /// </summary>
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
