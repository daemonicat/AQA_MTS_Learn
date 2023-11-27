namespace Arrays
{
    public static class ThirdTask
    {
        public static void MinMaxAverage()
        {
            Console.Write("Enter your number: ");
            int inputNumber = Helpers.GetInputNumber();

            int[] array = new int[inputNumber];

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

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
}