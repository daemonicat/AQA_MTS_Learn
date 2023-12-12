using Collections.Helper;

namespace Collections.IList;

public static class QueueExample
{
    public static void Run()
    {
        var myQueue = new Queue<string>();

        myQueue.Enqueue("Apple");
        myQueue.Enqueue("Banana");
        myQueue.Enqueue("Cherry");

        Console.WriteLine("Queue elements:");
        PrintHelper.PrintCollection(myQueue);

        var dequeuedElement = myQueue.Dequeue();
        Console.WriteLine($"Dequeued element: {dequeuedElement}");

        Console.WriteLine("Queue elements after dequeue:");
        PrintHelper.PrintCollection(myQueue);

        var peekedElement = myQueue.Peek();
        Console.WriteLine($"Peeked element: {peekedElement}");

        Console.WriteLine("Queue elements after peek:");
        PrintHelper.PrintCollection(myQueue);
    }
}