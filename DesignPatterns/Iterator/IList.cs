
namespace DesignPatterns.Iterator
{
    /// <summary>
    /// 抽象聚集
    /// </summary>
    public interface IList
    {
        IIterator GetIterator();
    }
}
