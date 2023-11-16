public static class ThirdTask
{
    public static void Main()
    {
        var emptyInput = false;

        Console.WriteLine("Enter \"weather\" word");
        var weatherWord = Console.ReadLine();
        
        if (string.IsNullOrEmpty(weatherWord))
        {
            emptyInput = true;
            Console.WriteLine("Enter \"weather\" word please!");
        }

        if (emptyInput) return;
        weatherWord = weatherWord?.ToLower();
        switch (weatherWord)
        {
            case "погода":
                Console.WriteLine("Weather");
                break;
            case "дождь":
                Console.WriteLine("Rain");
                break;
            case "снег":
                Console.WriteLine("Snow");
                break;
            case "ветер":
                Console.WriteLine("Wind");
                break;
            case "жарко":
                Console.WriteLine("Hot");
                break;
            case "тепло":
                Console.WriteLine("Warm");
                break;
            case "ясно":
                Console.WriteLine("Clear");
                break;
            case "солнечно":
                Console.WriteLine("Sunny");
                break;
            case "засуха":
                Console.WriteLine("Drought");
                break;
            case "радуга":
                Console.WriteLine("Rainbow");
                break;
            default:
                Console.WriteLine("There is no such word");
                break;
        }
    }
}