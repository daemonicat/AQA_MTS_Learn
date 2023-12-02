using Classes.FirstTask;
using Classes.FourthTask;
using Classes.SecondTask;

namespace Classes;

public static class Helpers
{
    public static int GetInputNumber()
    {
        var wrongInput = true;
        var inputNumber = 0;

        do
        {
            var inputNumberStr = Console.ReadLine();
            try
            {
                inputNumber = int.Parse(inputNumberStr);
                wrongInput = false;
            }
            catch
            {
                Console.WriteLine(
                    "It was not a number. Maybe your cat sat on a keyboard? Try to enter a number please.");
            }
        } while (wrongInput);

        return inputNumber;
    }

    public static void FirstTask()
    {
        var phone1 = new Phone();
        var phone2 = new Phone("79128457791", "NewModel");
        var phone3 = new Phone("79032059981", "RandomModel", 117);

        FirstTaskRoutineHelper(phone1);
        FirstTaskRoutineHelper(phone2);
        FirstTaskRoutineHelper(phone3);
    }

    public static void SecondTask()
    {
        var creditCard1 = new CreditCard("243790862789", 27918.96f);
        var creditCard2 = new CreditCard("243807891627", 12071.02f);
        var creditCard3 = new CreditCard("243836019628", 1078.47f);

        creditCard1.AddMoney(500);
        creditCard2.AddMoney(10281.71f);
        creditCard3.WithdrawMoney(847.31f);

        creditCard1.GetInfoAccount();
        creditCard2.GetInfoAccount();
        creditCard3.GetInfoAccount();
    }

    public static void FourthTask()
    {
        var treatmentPlan = new TreatmentPlan(5);
        var patient = new Patient(treatmentPlan.TreatmentPlanNumber);
        patient.ChooseDoctor(patient.TreatmentPlan);
        Doctor.Treatment(patient.Doctor);
    }

    private static void FirstTaskRoutineHelper(Phone phone)
    {
        phone.Print();

        Phone.ReceiveCall("John");
        phone.GetNumber();

        phone.SendMessage(new[] { "79990001192", "70009172819" });
        phone.SendMessage(new[] { "79990001192", "70009172819", "78123456618", "37599108263", "70198276192" });
    }
}