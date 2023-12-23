namespace Delegate;

public abstract class Example5
{
    private delegate void NoParameters();

    private delegate int Operation(int x, int y);

    public static void Run()
    {
        NoParameters noPrm = delegate { Console.WriteLine("Have fun!"); };

        Test(noPrm);

        Operation operation = SelectOperation(OperationType.Add);
        Console.WriteLine(operation(10, 4)); // 14

        operation = SelectOperation(OperationType.Subtract);
        Console.WriteLine(operation(10, 4)); // 6

        operation = SelectOperation(OperationType.Multiply);
        Console.WriteLine(operation(10, 4)); // 40
    }

    private static void Test(NoParameters noParam)
    {
        noParam();
    }

    private static int Add(int x, int y) => x + y;
    private static int Subtract(int x, int y) => x - y;
    private static int Multiply(int x, int y) => x * y;

    private static Operation SelectOperation(OperationType opType)
    {
        return opType switch
        {
            OperationType.Add => Add,
            OperationType.Subtract => Subtract,
            _ => Multiply
        };
    }
}