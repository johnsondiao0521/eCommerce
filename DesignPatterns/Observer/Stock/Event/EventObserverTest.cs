using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Stock.Event
{
    public class EventObserverTest
    {
        public static void Do()
        {
            Stock stockMicrosoft = new Event.Stock("Microsoft", 120);

            Investor investor = new Investor("Johnson");
            stockMicrosoft.eventHandler += new NotifyEventHandler(investor.SendData);
            stockMicrosoft.OnNotify();
        }
    }
}
