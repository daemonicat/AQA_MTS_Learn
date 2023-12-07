namespace Homework.SecondTask;

public class Therapist : Doctor
{
    public override void Treatment(string? doctor)
    {
        Console.WriteLine("The therapist treatment was successful. Just enjoy your life and don't forget about pills.");
    }
}