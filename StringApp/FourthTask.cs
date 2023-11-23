namespace StringApp
{
    public static class FourthTask
    {
        public static void SubstringInsert()
        {
            string inputString = "Плохой день.";

            inputString = inputString.Substring(inputString.IndexOf("Плохой") + "Плохой".Length);
            Console.WriteLine(inputString);

            inputString = inputString.Insert(0, "Хороший");
            inputString = inputString.Insert(inputString.Length - 1, "!!!!!!!!!");
            inputString = inputString.Remove(inputString.Length - 2, 1);
            inputString = inputString.Insert(inputString.Length - 1, "?");

            Console.WriteLine(inputString);
        }
    }
}