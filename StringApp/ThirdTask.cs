namespace StringApp
{
    public static class ThirdTask
    {
        public static void SplitString()
        {
            const string inputString = "teamwithsomeofexcersicesabcwanttomakeitbetter.";

            for (int i = 0; i < inputString.Split("abc").Length; i++)
            {
                if (i == 0)
                {
                    string firstPart = inputString.Split("abc")[0];
                    Console.WriteLine(firstPart);
                }
                else
                {
                    string secondPart = inputString.Split("abc")[1];
                    Console.WriteLine(secondPart);
                }
            }
        }
    }
}