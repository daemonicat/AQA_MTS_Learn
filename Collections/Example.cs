namespace Collections;

public static class Example
{
    public static void Run()
    {
        var studentGrades = new Dictionary<string, List<int>>
        {
            { "Meow", new List<int> { 7, 9, 10 } },
            { "Meow2", new List<int> { 3, 6, 1 } },
            { "Meow3", new List<int> { 1, 4, 8 } }
        };

        foreach (var item in studentGrades)
        {
            Console.WriteLine($"Average grade for {item.Key} is {item.Value.Average()}");
        }
    }
}