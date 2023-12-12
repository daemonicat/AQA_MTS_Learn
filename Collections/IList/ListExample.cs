using Collections.Helper;

namespace Collections.IList;

public static class ListExample
{
    public static void Run()
    {
        var stringList = new List<string>
        {
            "Первый",
            "Второй",
            "Третий"
        };

        stringList.Insert(1, "Новый Второй");

        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(stringList);

        var elementAtIndex = stringList[2];
        Console.WriteLine($"Элемент по индексу 2: {elementAtIndex}");

        var containsElement = stringList.Contains("Третий");
        Console.WriteLine($"Список содержит 'Третий': {containsElement}");

        stringList.Sort();
        Console.WriteLine("Отсортированная коллекция:");
        PrintHelper.PrintCollection(stringList);
        
        var item = stringList.BinarySearch("Новый Второй");
        Console.WriteLine($"Бинарный поиск 'Новый Второй': {item}");

        var index = stringList.IndexOf("Новый Второй");
        Console.WriteLine($"Поиск индекса 'Новый Второй': {index}");
        
        stringList.Remove("Второй");

        stringList.RemoveAt(0);
        
        Console.WriteLine("Элементы после удаления:");
        PrintHelper.PrintCollection(stringList);

        stringList.Reverse();
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        stringList.Clear();
        Console.WriteLine($"Количество элементов после очистки: {stringList.Count}");
        PrintHelper.PrintCollection(stringList);
    }
}