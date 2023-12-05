namespace Interfaces.Example;

public class Tablet1 : IDisplayable, IChargeable
{
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet Display: {information}");
    }

    public void DrawBorders()
    {
        Console.WriteLine("Tablet: DrawBorders");
    }

    public void Charge()
    {
        Console.WriteLine("Tablet: Charging");
    }
}