using System;

namespace DesignPatterns.Observer.Stock.Event
{
    public class Investor
    {
        private string _name;
        public Investor(string name)
        {
            _name = name;
        }
        public void SendData(object obj)
        {
            if (obj is Stock)
            {
                Stock stock = (Stock)obj;
                Console.WriteLine(string.Format("Notify:{0},Symbol:{1},Price:{2:C}", _name, stock._symbol, stock._price));
            }

        }
    }
}
