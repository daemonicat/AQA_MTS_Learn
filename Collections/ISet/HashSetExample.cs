using Collections.Helper;

namespace Collections.ISet;

public static class HashSetExample
{
    public static void Run()
    {
        var uniqueNames = new HashSet<string>
        {
            "Alice",
            "Bob",
            "Alice" // Этот элемент не добавится, так как "Alice" уже существует
        };

        Console.WriteLine("Unique Names:");
        PrintHelper.PrintCollection(uniqueNames);
        
        var containsBob = uniqueNames.Contains("Bob");
        Console.WriteLine($"Contains 'Bob': {containsBob}");

        uniqueNames.Remove("Alice");

        Console.WriteLine("\nNames after removal:");
        PrintHelper.PrintCollection(uniqueNames);
    }
}