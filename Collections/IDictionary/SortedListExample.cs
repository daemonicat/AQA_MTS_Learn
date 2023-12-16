using Collections.Helper;

namespace Collections.IDictionary;

public static class SortedListExample
{
    public static void Run()
    {
        var mySortedList = new SortedList<string, int>(16)
        {
            { "Apple", 10 },
            { "Cherry", 7 },
            { "Banana", 5 }
        };

        Console.WriteLine("SortedList elements:");
        PrintHelper.PrintCollection(mySortedList);
        
        var containsKey = mySortedList.ContainsKey("Banana");
        Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");
        
        var containsValue = mySortedList.ContainsValue(7);
        Console.WriteLine($"ContainsValue(7): {containsValue}");

        if (mySortedList.TryGetValue("Apple", out var value))
        {
            Console.WriteLine($"Value for key 'Apple': {value}");
        }

        mySortedList.Remove("Cherry");

        Console.WriteLine("SortedList elements after removal:");
        PrintHelper.PrintCollection(mySortedList);
    }
}