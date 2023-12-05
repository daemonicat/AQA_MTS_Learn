namespace Interfaces.Example;

public class Tablet : IDisplayable
{
    public int SerialNumber;
    
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet Display: {information}");
    }

    public void DrawBorders()
    {
        Console.WriteLine("Tablet: DrawBorders");
    }
}