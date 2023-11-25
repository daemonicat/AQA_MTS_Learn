namespace Classes
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { -4, 8, 10, 2, 12, 0, 5, 6 };

            PrintArray(array);
            Console.WriteLine();

            Array.Reverse(array);
            PrintArray(array);
            
            Console.WriteLine();

            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // Пустой вызов

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
        }

        private static void PrintArray(int[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write($"{item} \t");
            }
        }

        private static int CalculateSum(params int[] numbers)
        {
            var sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}