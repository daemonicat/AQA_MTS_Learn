namespace Homework.SecondTask;

public class DoctorFactory
{
    public static Doctor CreateDoctor(string? doctor)
    {
        return doctor switch
        {
            "Surgeon" => new Surgeon(),
            "Therapist" => new Therapist(),
            "Dentist" => new Dentist(),
            _ => new Doctor()
        };
    }
}