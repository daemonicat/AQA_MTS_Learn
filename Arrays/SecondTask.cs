public static class SecondTask
{
    public static void Main()
    {
        var emptyInput = false;
        var inputNumber = 0;
        int[] array = { 1, 6, 4, 2, 9, 5, 5, 1, 3, 7, 9, 6, 8, 8, 8, 1, 8 };
        
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
        array = array.Where(num => num != inputNumber).ToArray();
    }
}