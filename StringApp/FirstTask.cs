using System.Text.RegularExpressions;

namespace StringApp
{
    public static partial class FirstTask
    {
        public static void TestToTesting()
        {
            Console.WriteLine("Enter your string:");
            var inputString = Console.ReadLine();

            if (inputString == null) return;
            inputString = inputString.Replace("test", "testing");
            inputString = MyRegex().Replace(inputString, "");

            Console.WriteLine($"Edited string: \n{inputString}");
        }

        [GeneratedRegex("[0-9]", RegexOptions.IgnoreCase, "en-RU")]
        private static partial Regex MyRegex();
    }
}