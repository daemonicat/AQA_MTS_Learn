using Collections.Helper;

namespace Collections.IList;

public static class LinkedListExample
{
    public static void Run()
    {
        var linkedList = new LinkedList<string>();

        linkedList.AddLast("apple");
        linkedList.AddLast("banana");
        linkedList.AddLast("cherry");

        linkedList.AddFirst("orange");

        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(linkedList);

        Console.WriteLine($"Первый элемент: {linkedList.First?.Value}");
        Console.WriteLine($"Последний элемент: {linkedList.Last?.Value}");

        var containsBanana = linkedList.Contains("banana");
        Console.WriteLine($"Список содержит 'banana': {containsBanana}");

        var node = linkedList.Find("banana");
        Console.WriteLine($"Найденный элемент: {node?.Value}");

        linkedList.Remove("banana");

        Console.WriteLine("Элементы после удаления:");
        PrintHelper.PrintCollection(linkedList);

        linkedList.Clear();

        Console.WriteLine("Элементы после очистки:");
        PrintHelper.PrintCollection(linkedList);
    }
}