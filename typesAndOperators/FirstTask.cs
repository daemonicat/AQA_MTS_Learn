// See https://aka.ms/new-console-template for more information

public static class FirstTask
{
    public static void Main()
    {
        float firstNumber;
        float secondNumber;

        Console.WriteLine("Enter first number");
        var firstNumberStr = Console.ReadLine();
        try
        {
            firstNumber = float.Parse(firstNumberStr);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Enter both numbers and operation sign please");
            return;
        }

        Console.WriteLine("Enter valid operation: (+, -, *, /)");
        var operationSign = Console.ReadLine();

        Console.WriteLine("Enter second number");
        var secondNumberStr = Console.ReadLine();
        try
        {
            secondNumber = Single.Parse(secondNumberStr);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Enter both numbers and operation sign please");
            return;
        }

        if (string.IsNullOrEmpty(operationSign))
        {
            Console.WriteLine("Enter both numbers and operation sign please");
            return;
        }

        float result = 0;
        switch (operationSign)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "/":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Can not divide by 0");
                }
                else
                {
                    result = firstNumber / secondNumber;
                }

                break;
            default:
                Console.WriteLine("Use only this symbols as operation sign: +, -, *, /");
                break;
        }

        Console.WriteLine(result);
    }
}