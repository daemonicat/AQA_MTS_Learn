namespace Classes.FourthTask;

public abstract class Doctor
{
    public static void Treatment(string? doctor)
    {
        switch (doctor)
        {
            case "Surgeon":
            {
                Console.WriteLine(
                    "The surgeon treatment was successful. Enjoy your life without some things in your belly.");
                break;
            }
            case "Therapist":
            {
                Console.WriteLine(
                    "The therapist treatment was successful. Just enjoy your life and don't forget about pills.");
                break;
            }
            case "Dentist":
            {
                Console.WriteLine("The dentist treatment was successful. Enjoy your life without some teeth.");
                break;
            }
            default:
            {
                Console.WriteLine("There is no such doctor");
                break;
            }
        }
    }
}