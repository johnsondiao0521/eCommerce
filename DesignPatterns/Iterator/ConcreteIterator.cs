using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    /// <summary>
    /// 具体迭代器
    /// </summary>
    public class ConcreteIterator : IIterator
    {
        public ConcreteIterator(ConcreteList list)
        {

        }
        public object CurrentItem()
        {
            throw new NotImplementedException();
        }

        public void First()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }
    }
}
