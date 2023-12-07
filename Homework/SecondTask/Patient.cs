namespace Homework.SecondTask;

public class Patient(int treatmentPlan)
{
    public readonly int TreatmentPlan = treatmentPlan;
    public string? Doctor;

    public void ChooseDoctor(int treatmentPlan)
    {
        Doctor = treatmentPlan switch
        {
            1 => "Surgeon",
            2 => "Dentist",
            _ => "Therapist"
        };
    }
}