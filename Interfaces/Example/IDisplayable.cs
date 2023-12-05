namespace Interfaces.Example;

public interface IDisplayable
{
    void DisplayInformation(string information);

    // void DrawBorders();
    
    void DrawBorders()
    {
        Console.WriteLine("DrawBorders");
    }
}