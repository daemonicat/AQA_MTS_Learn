// See https://aka.ms/new-console-template for more information

class firstTask
{
    public static void Main(){
        var empty = false;
        float firstNumber = 0;
        float secondNumber = 0;

        Console.WriteLine("Enter first number");
        var firstNumberStr = Console.ReadLine();
        try
        {
            firstNumber = Single.Parse(firstNumberStr);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
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
            Console.WriteLine(e.Message);
        }
        
        if (string.IsNullOrEmpty(operationSign))
        {
            empty = true;
            Console.WriteLine("Enter both numbers and operation sign please");
        }

        if (!empty)
        {
            float result;
            switch (operationSign)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Can not divide by 0");
                    } else
                    {
                        result = firstNumber / secondNumber;
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