namespace Interfaces.Example;

public class Smartphone : IDisplayable
{
    public int UUID;
    
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Smartphone Display: {information}");
    }
}