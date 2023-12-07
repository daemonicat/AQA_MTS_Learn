namespace Homework.SecondTask;

public static class SecondTask
{
    public static void Hospital()
    {
        var treatmentPlan = new TreatmentPlan(2);
        var patient = new Patient(treatmentPlan.TreatmentPlanNumber);
        patient.ChooseDoctor(patient.TreatmentPlan);
        DoctorFactory.CreateDoctor(patient.Doctor).Treatment(patient.Doctor);
    }
}