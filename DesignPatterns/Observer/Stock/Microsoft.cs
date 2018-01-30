
using System.Collections.Generic;

namespace DesignPatterns.Observer.Stock
{
    public class Microsoft : Stock
    {
        private List<IObserver> observers = new List<IObserver>();
        public Microsoft(string symbol, decimal price)
            : base(symbol, price)
        {
            _symbol = symbol;
            _price = price;
        }
    }
}
