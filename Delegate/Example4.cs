namespace Delegate;

public abstract class Example4
{
    private delegate void NoParameters();

    public static void Run()
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!");
        };
        
        noPrm();
    }
}