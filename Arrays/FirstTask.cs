namespace Arrays
{
    public static class FirstTask
    {
        public static void InArrayOrNot()
        {
            var wrongInput = true;
            var notInArray = true;
            int[] array = { 1, 6, 4, 2, 9, 5 };

            Console.WriteLine("There is an initial array:");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            
            Console.Write("Enter your number: ");
            var inputNumber = Helpers.GetInputNumber();

            foreach (var item in array)
            {
                if (item != inputNumber) continue;
                notInArray = false;
                break;
            }

            Console.WriteLine(notInArray ? "Your number is not in array" : "Your number is in array, hoooooray!");
        }
    }
}