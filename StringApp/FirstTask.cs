using System.Text.RegularExpressions;

namespace StringApp
{
    public static partial class FirstTask
    {
        public static void TestToTesting()
        {
            string? inputString = File.ReadAllText(@"../../../FirstTaskIOFiles/FirstTaskInput.txt");

            inputString = inputString.Replace("test", "testing");
            inputString = Regex.Replace(inputString, "[0-9]", "");

            if (!File.Exists(@"../../../FirstTaskIOFiles/FirstTaskOutput.txt"))
                File.WriteAllText(@"../../../FirstTaskIOFiles/FirstTaskOutput.txt", inputString);
        }
    }
}