namespace Delegate;

public class CurrencyExchangeMonitor
{
    public delegate void PriceChange(int currentPrice);

    public PriceChange PriceChangeHandler { get; set; }

    public void Start()
    {
        while (true)
        {
            var currentPrice = new Random().Next(100);

            PriceChangeHandler(currentPrice);
            
            Thread.Sleep(2000);
        }
    }
}