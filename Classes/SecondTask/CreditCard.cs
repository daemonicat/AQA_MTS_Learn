namespace Classes.SecondTask;

public class CreditCard(string accountNumber, float currentAmount)
{
    public void AddMoney(float amount)
    {
        currentAmount += amount;
        Console.WriteLine($"Added: {amount}. Current amount: {currentAmount}");
    }

    public void WithdrawMoney(float amount)
    {
        if (currentAmount < amount)
            Console.WriteLine($"Can not withdraw this amount. Current amount available: {currentAmount}");
        else
        {
            currentAmount -= amount;
            Console.WriteLine($"Withdrew: {amount}. Current amount available: {currentAmount}");
        }
    }

    public void GetInfoAccount()
    {
        Console.WriteLine($"Account Number: {accountNumber} Current amount: {currentAmount}");
    }
}