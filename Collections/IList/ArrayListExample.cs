using System.Collections;
using System.Text;
using Collections.Helper;

namespace Collections.IList;

public static class ArrayListExample
{
    public static void Run()
    {
        var stringList = new ArrayList
        {
            "Первый",
            "Второй",
            "Третий"
        };
        Console.WriteLine(stringList.Capacity);

        Console.WriteLine("Элементы в ArrayList:");
        foreach (var item in stringList)
        {
            Console.WriteLine(item);
        }

        stringList.Add(4);
        Console.WriteLine(stringList.Capacity);
        stringList.Add(true);
        Console.WriteLine(stringList.Capacity);
        stringList.Add(new StringBuilder("Object"));
        Console.WriteLine(stringList.Capacity);
        stringList.Add(4);
        Console.WriteLine(stringList.Capacity);
        stringList.Add(true);
        Console.WriteLine(stringList.Capacity);
        stringList.Add(new StringBuilder("Object"));
        Console.WriteLine(stringList.Capacity);

        Console.WriteLine("\nЭлементы в ArrayList после добавления числа и булевого значения:");
        PrintHelper.PrintCollection(stringList);
    }
}