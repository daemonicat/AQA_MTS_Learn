using Collections.Helper;

namespace Collections.IDictionary;

public static class DictionaryExample
{
    public static void Run()
    {
        var myDictionary = new Dictionary<string, int>
        {
            { "apple", 10 },
            { "banana", 5 },
            { "cherry", 7 }
        };

        var containsKey = myDictionary.ContainsKey("banana");
        Console.WriteLine($"ContainsKey(\"banana\"): {containsKey}");

        if (myDictionary.TryGetValue("apple", out var value))
        {
            Console.WriteLine($"Value for key 'apple': {value}");
        }

        PrintHelper.PrintCollection(myDictionary);

        myDictionary.Remove("cherry");

        Console.WriteLine("Elements after removal:");
        PrintHelper.PrintCollection(myDictionary);

        myDictionary.Clear();

        Console.WriteLine("Elements after clearing:");
        PrintHelper.PrintCollection(myDictionary);
    }
}