using Collections.Helper;

namespace Collections.IList;

public static class StackExample
{
    public static void Run()
    {
        var myStack = new Stack<string>();

        myStack.Push("Apple");
        myStack.Push("Banana");
        myStack.Push("Cherry");

        Console.WriteLine("Stack elements:");
        PrintHelper.PrintCollection(myStack);

        var topElement = myStack.Peek();
        Console.WriteLine($"Top element (Peek): {topElement}");

        var removedElement = myStack.Pop();
        Console.WriteLine($"Removed element (Pop): {removedElement}");

        Console.WriteLine("Stack elements after Pop:");
        PrintHelper.PrintCollection(myStack);
    }
}