namespace Delegate;

public static class Example8
{
    private delegate T Operation<out T, in TK>(TK variable);

    public static void Run()
    {
        Operation<decimal, int> squareOperation = Square;
        var result1 = squareOperation(5);
        Console.WriteLine(result1); 

        Operation<int, int> doubleOperation = Double;
        var result2 = doubleOperation(5);
        Console.WriteLine(result2); 
    }

    private static decimal Square(int n) => n * n;
    private static int Double(int n) => n + n;
}