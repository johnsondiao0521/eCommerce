
namespace DesignPatterns.Iterator
{
    /// <summary>
    /// 抽象迭代器
    /// </summary>
    public interface IIterator
    {
        bool MoveNext();

        object CurrentItem();

        void First();

        void Next();
    }
}
