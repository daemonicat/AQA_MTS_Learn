namespace Delegate;

public abstract class Example3
{
    private delegate void NoParameters();

    public static void Run()
    {
        NoParameters noPrm = ShowMessage1;

        noPrm += ShowMessage2;
        
        noPrm.Invoke();
    }

    private static void ShowMessage1() => Console.WriteLine("Have fun!");

    private static void ShowMessage2() => Console.WriteLine("See you!");
}