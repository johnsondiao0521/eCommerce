using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Stock
{
    public class Investor : IObserver
    {
        private string _name;
        public Investor(string name)
        {
            _name = name;
        }
        public void SendData(Stock ms)
        {
            Console.WriteLine(string.Format("Notify:{0},Symbol:{1},Price:{2:C}", _name, ms._symbol, ms._price));
        }
    }
}
