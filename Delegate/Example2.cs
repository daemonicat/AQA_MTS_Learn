// See https://aka.ms/new-console-template for more information

namespace Delegate;

internal abstract class Example2
{
    private delegate string WithParameters(string name1, string name2);
    
    public static void Run()
    {
        WithParameters withParameters1 = new (ShowMessage);
        WithParameters withParameters2 = ShowMessage;

        var result1 = withParameters1("Boris", "Ivan");
        var result2 = withParameters2("Olga", "Natasha");
        
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }

    private static string ShowMessage(string value1, string value2)
    {
        Console.WriteLine($"{value1}, {value2} Have fun!!!");

        return "successful";
    }
}