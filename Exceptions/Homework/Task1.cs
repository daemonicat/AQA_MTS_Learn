namespace Exceptions.Homework;

internal abstract class Task1
{
    public static void Logpass()
    {
        Console.WriteLine("Login:");
        var login = Console.ReadLine();

        Console.WriteLine("Password:");
        var password = Console.ReadLine();

        Console.WriteLine("Password one more time:");
        var confirmPassword = Console.ReadLine();

        try
        {
            if (CredsValidation.IsCredsValid(login, password, confirmPassword))
                Console.WriteLine("Succsess");
        }
        catch (WrongLoginException exLogin)
        {
            Console.WriteLine($"There is a problem with a login: {exLogin.Message}");
        }
        catch (WrongPasswordException exPassword)
        {
            Console.WriteLine($"There is a problem with a password: {exPassword.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unidentified flying error: {ex.Message}");
        }
    }
}