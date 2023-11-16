public static class SecondTask
{
    public static void Main()
    {
        var emptyInput = false;
        float inputNumber = 0;

        Console.WriteLine("Enter your number");
        var inputNumberStr = Console.ReadLine();
        try
        {
            inputNumber = float.Parse(inputNumberStr);
        }
        catch (FormatException e)
        {
            emptyInput = true;
            Console.WriteLine(e.Message);
        }

        if (emptyInput) return;
        switch (inputNumber)
        {
            case >= -40 and <= -10:
                Console.WriteLine("Your number in range [-40,-10]");
                break;
            case >= -9 and <= 0:
                Console.WriteLine("Your number in range [-9,0]");
                break;
            case >= 1 and <= 10:
                Console.WriteLine("Your number in range [1,10]");
                break;
            case >= 11 and <= 40:
                Console.WriteLine("Your number in range [11,40]");
                break;
            default:
                Console.WriteLine("Your number is out of all ranges");
                break;
        }
    }
}