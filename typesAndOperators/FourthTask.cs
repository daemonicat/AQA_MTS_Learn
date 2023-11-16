public static class FourthTask
{
    public static void Main()
    {
        var emptyInput = false;
        var inputNumber = 0;

        Console.WriteLine("Enter your number");
        var inputNumberStr = Console.ReadLine();
        try
        {
            inputNumber = int.Parse(inputNumberStr);
        }
        catch (FormatException e)
        {
            emptyInput = true;
            Console.WriteLine(e.Message);
        }

        if (emptyInput) return;
        //First solution
        Console.WriteLine(inputNumber % 2 == 0 ? "This number is even!" : "This number is odd!");
        //Second solution
        Console.WriteLine((inputNumber & 1) == 0 ? "This number is even!" : "This number is odd!");
    }
}