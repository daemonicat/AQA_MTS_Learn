// See https://aka.ms/new-console-template for more information

public static class FirstTask
{
    public static void Main(){
        var EmptyInput = false;
        float FirstNumber = 0;
        float SecondNumber = 0;

        Console.WriteLine("Enter first number");
        var FirstNumberStr = Console.ReadLine();
        try
        {
            FirstNumber = Single.Parse(FirstNumberStr);
        }
        catch (FormatException e)
        {
            EmptyInput = true;
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Enter valid operation: (+, -, *, /)");
        var OperationSign = Console.ReadLine();

        Console.WriteLine("Enter second number");
        var SecondNumberStr = Console.ReadLine();
        try
        {
            SecondNumber = Single.Parse(SecondNumberStr);
        }
        catch (FormatException e)
        {
            EmptyInput = true;
            Console.WriteLine(e.Message);
        }
        
        if (string.IsNullOrEmpty(OperationSign))
        {
            EmptyInput = true;
            Console.WriteLine("Enter both numbers and operation sign please");
        }

        if (!EmptyInput)
        {
            float result;
            switch (OperationSign)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = FirstNumber - SecondNumber;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = FirstNumber * SecondNumber;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (SecondNumber == 0)
                    {
                        Console.WriteLine("Can not divide by 0");
                    } else
                    {
                        result = FirstNumber / SecondNumber;
                        Console.WriteLine(result);
                    }
                    break;
                default:
                    Console.WriteLine("Use only this symbols as operation sign: +, -, *, /");
                    break;
            }
        } 
    }
}