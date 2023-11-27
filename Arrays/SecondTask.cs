namespace Arrays
{
    public static class SecondTask
    {
        public static void DeleteEntry()
        {
            int[] array = { 1, 6, 4, 2, 9, 5, 5, 1, 3, 7, 9, 6, 8, 8, 8, 1, 8 };

            Console.WriteLine("There is an initial array:");

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.Write("Enter your number: ");
            var inputNumber = Helpers.GetInputNumber();

            var finalArray = array.Where(num => num != inputNumber).ToArray();

            Console.WriteLine("There is a final array:");

            foreach (var item in finalArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}