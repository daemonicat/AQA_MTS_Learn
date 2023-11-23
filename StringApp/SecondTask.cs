namespace StringApp
{
    public static class SecondTask
    {
        public static void SecondApp()
        {
            string[] inputArray = { "Welcome", "to", "the", "TMS", "lessons" };
            
            string result = string.Join("\" \"", inputArray);
            result = result.Insert(0, "\"");
            result = result.Insert(result.Length, "\"");
            
            Console.WriteLine(result);
        }
    }
}