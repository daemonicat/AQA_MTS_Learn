using Collections.Helper;

namespace Collections.IDictionary;

public static class SortedDictionaryExample
{
    public static void Run()
    {
        var mySortedDictionary = new SortedDictionary<string, int>
        {
            { "Apple", 10 },
            { "Cherry", 7 },
            { "Banana", 5 }
        };

        Console.WriteLine("SortedDictionary elements:");
        PrintHelper.PrintCollection(mySortedDictionary);

        var containsKey = mySortedDictionary.ContainsKey("Banana");
        Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");

        if (mySortedDictionary.TryGetValue("Apple", out var value))
        {
            Console.WriteLine($"Value for key 'Apple': {value}");
        }

        mySortedDictionary.Remove("Cherry");

        Console.WriteLine("SortedDictionary elements after removal:");
        PrintHelper.PrintCollection(mySortedDictionary);
    }
}