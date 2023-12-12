using Collections.Helper;

namespace Collections.IDictionary;

public static class SortedListExample
{
    public static void Run()
    {
        var mySortedList = new SortedList<string, int>
        {
            { "Apple", 10 },
            { "Cherry", 7 },
            { "Banana", 5 }
        };

        Console.WriteLine("SortedList elements:");
        PrintHelper.PrintCollection(mySortedList);
        
        var containsKey = mySortedList.ContainsKey("Banana");
        Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");

        if (mySortedList.TryGetValue("Apple", out var value))
        {
            Console.WriteLine($"Value for key 'Apple': {value}");
        }

        mySortedList.Remove("Cherry");

        Console.WriteLine("SortedList elements after removal:");
        PrintHelper.PrintCollection(mySortedList);
    }
}