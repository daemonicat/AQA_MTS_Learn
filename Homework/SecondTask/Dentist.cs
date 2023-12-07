namespace Homework.SecondTask;

public class Dentist : Doctor
{
    public override void Treatment(string? doctor)
    {
        Console.WriteLine("The dentist treatment was successful. Enjoy your life without some teeth.");
    }
}