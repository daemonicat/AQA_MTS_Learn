namespace Homework.SecondTask;

public class Surgeon : Doctor
{
    public override void Treatment(string? doctor)
    {
        Console.WriteLine("The surgeon treatment was successful. Enjoy your life without some things in your belly.");
    }
}