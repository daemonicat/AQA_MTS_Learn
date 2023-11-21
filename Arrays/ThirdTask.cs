public static class ThirdTask
{
    public static void MinMaxAverage()
    {
        int inputNumber;

        Console.Write("Enter your number: ");
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

        int[] array = new int[inputNumber];

        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            array[i] = new Random().Next(100);
        }

        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            Console.Write($"{array[i]} ");
            if (i == array.GetUpperBound(0)) Console.WriteLine();
        }

        Array.Sort(array);

        Console.WriteLine($"Lowest number is {array[0]}");
        Console.WriteLine($"Highest number is {array[array.GetUpperBound(0)]}");

        int sum = 0;
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            sum += array[i];
        }

        Console.WriteLine($"Average value is {sum / (array.GetUpperBound(0) + 1)}");
    }
}