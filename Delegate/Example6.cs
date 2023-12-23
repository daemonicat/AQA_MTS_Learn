namespace Delegate;

public abstract class Example6
{
    public static void Run()
    {
        var currencyExchangeMonitor = new CurrencyExchangeMonitor
        {
            PriceChangeHandler = ShowPrice
        };

        var dataCorrection = new DataCorrection();
        currencyExchangeMonitor.PriceChangeHandler += DataCorrection.UpdateData;
        
        currencyExchangeMonitor.Start();
    }
    
    // Сигнатура должна соответствовать делегату public delegate void PriceChange(int currentPrice);
    private static void ShowPrice(int price)
    {
        Console.WriteLine($"Текущая цена: {price}");
    }
}