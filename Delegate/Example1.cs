
namespace Delegate;

internal abstract class Example1
{
    private delegate void NoParameters();
    
    public static void Run()
    {
        var noParameters1 = new NoParameters(ShowMessage);
        NoParameters noParameters2 = new (ShowMessage);
        NoParameters noParameters3 = ShowMessage;

        noParameters1();
        noParameters2();
        noParameters3();
    }

    private static void ShowMessage()
    {
        Console.WriteLine("Have fun!!!");
    }
}