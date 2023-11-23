namespace StringApp
{
    public static class ThirdTask
    {
        public static void SplitString()
        {
            string inputString = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            string firstPart;
            string secondPart;

            for (int i = 0; i < inputString.Split("abc").Length; i++)
            {
                if (i == 0)
                {
                    firstPart = inputString.Split("abc")[0];
                    Console.WriteLine(firstPart);
                }
                else
                {
                    secondPart = inputString.Split("abc")[1];
                    Console.WriteLine(secondPart);
                }
            }
        }
    }
}