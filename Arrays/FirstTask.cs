public static class FirstTask
{
    public static void Main()
    {
        var emptyInput = false;
        var notInArray = true;
        int[] array = { 1, 6, 4, 2, 9, 5 };
        var inputNumber = 0;

        Console.Write("Enter your number: ");
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
        foreach (var item in array)
        {
            if (item == inputNumber) notInArray = false;
        }

        Console.WriteLine(notInArray ? "Your number is not in array" : "Your number is in array, hoooooray!");
    }
}