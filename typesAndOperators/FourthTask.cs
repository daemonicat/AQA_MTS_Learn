public static class FourthTask
{
    public static void Main()
    {
        int inputNumber;

        Console.WriteLine("Enter your number");
        var inputNumberStr = Console.ReadLine();
        try
        {
            inputNumber = int.Parse(inputNumberStr);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        //First solution
        Console.WriteLine(inputNumber % 2 == 0 ? "This number is even!" : "This number is odd!");
        //Second solution
        Console.WriteLine((inputNumber & 1) == 0 ? "This number is even!" : "This number is odd!");
    }
}