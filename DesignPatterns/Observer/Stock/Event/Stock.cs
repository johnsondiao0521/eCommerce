
namespace DesignPatterns.Observer.Stock.Event
{
    public delegate void NotifyEventHandler(object sender);
    public class Stock
    {
        public NotifyEventHandler eventHandler;
        public string _symbol;
        public decimal _price;
        public Stock(string symbol, decimal price)
        {
            _symbol = symbol;
            _price = price;
        }

        public void OnNotify()
        {
            eventHandler?.Invoke(this);
        }
    }
}
