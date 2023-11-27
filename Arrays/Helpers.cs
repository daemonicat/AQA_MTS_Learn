namespace Arrays
{
    public static class Helpers
    {
        public static int GetInputNumber()
        {
            var wrongInput = true;
            var inputNumber = 0;

            do
            {
                var inputNumberStr = Console.ReadLine();
                try
                {
                    inputNumber = int.Parse(inputNumberStr);
                    wrongInput = false;
                }
                catch
                {
                    Console.WriteLine("It was not a number. Maybe your cat sat on a keyboard? Try to enter a number please.");
                }
            } while (wrongInput);

            return inputNumber;
        }
    }
}