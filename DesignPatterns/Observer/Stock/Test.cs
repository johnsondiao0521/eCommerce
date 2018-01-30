
namespace DesignPatterns.Observer.Stock
{
    public class StockObserverTest
    {
        public static void Do()
        {
            Stock stockmisoft = new Microsoft("Microsoft", 120);
            stockmisoft.AddObserver(new Investor("dzd"));
            stockmisoft.AddObserver(new Investor("csx"));
            stockmisoft.Notify();

            Stock stockgoogle = new Microsoft("Google", 200);
            stockgoogle.AddObserver(new Investor("dzd"));
            stockgoogle.AddObserver(new Investor("csx"));
            stockgoogle.Notify();
        }
    }
}
