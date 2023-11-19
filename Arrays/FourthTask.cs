public static class FourthTask
{
    public static void Main()
    {
        int[] array = { 1, 6, 4, 2, 9 };
        int[] array1 = { 5, 14, 10, 3, 7 };

        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            Console.Write($"{array[i]} ");
            if (i == array.GetUpperBound(0)) Console.WriteLine();
        }

        for (int i = 0; i <= array1.GetUpperBound(0); i++)
        {
            Console.Write($"{array1[i]} ");
            if (i == array1.GetUpperBound(0)) Console.WriteLine();
        }

        int sum = 0;
        int sum1 = 0;
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            sum += array[i];
            sum1 += array1[i];
        }

        if (sum / 5 > sum1 / 5)
        {
            Console.WriteLine("Average of first array is higher");
        }
        else if (sum / 5 < sum1 / 5)
        {
            Console.WriteLine("Average of second array is higher");
        }
        else
        {
            Console.WriteLine("Averages of both arrays are equal");
        }
    }
}