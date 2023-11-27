namespace Arrays
{
    public static class FourthTask
    {
        public static void AverageInArrays()
        {
            int[] array = { 1, 6, 4, 2, 9 };
            int[] array1 = { 5, 14, 10, 3, 7 };

            Console.WriteLine("There is an initial arrays:");

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i <= array1.GetUpperBound(0); i++)
            {
                Console.Write($"{array1[i]} ");
            }

            Console.WriteLine();

            int sum = 0;
            int sum1 = 0;

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                sum += array[i];
                sum1 += array1[i];
            }

            if (sum / array.Length > sum1 / array1.Length)
            {
                Console.WriteLine("Average of first array is higher");
            }
            else if (sum / array.Length < sum1 / array1.Length)
            {
                Console.WriteLine("Average of second array is higher");
            }
            else
            {
                Console.WriteLine("Averages of both arrays are equal");
            }
        }
    }
}