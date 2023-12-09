namespace Exceptions;

public class CustomExceptionUsage
{
    public void Run()
    {
        try
        {
            throw new CustomException("Произошла ошибка!");

            Console.WriteLine("Этот код не будет достигнут.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Поймано собственное исключение: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Поймано исключение: {ex.Message}");
        }
    }

    public void ProcessInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new InvalidInputException(nameof(input), "Поле не должно быть пустым или содержать только пробелы.");
        }
    }

    public void UseCustomArgumentException()
    {
        try
        {
            Employee person = new Employee { Name = "Tom", Age = 17 };
        }
        catch (CustomArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Некорректное значение: {ex.Value}");
        }
    }
}