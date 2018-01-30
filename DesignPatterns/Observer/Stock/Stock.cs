using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Stock
{
    public abstract class Stock
    {
        private List<IObserver> observers = new List<IObserver>();
        public string _symbol;
        public decimal _price;
        public Stock(string symbol, decimal price)
        {
            _symbol = symbol;
            _price = price;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.SendData(this);
            }
        }
    }
}
