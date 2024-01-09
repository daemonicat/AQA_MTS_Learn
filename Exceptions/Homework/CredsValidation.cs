using System.Text.RegularExpressions;

namespace Exceptions.Homework;

public abstract class CredsValidation
{
    public static bool IsCredsValid(string? login, string? password, string? confirmPassword)
    {
        var isValid = true;

        if (string.IsNullOrWhiteSpace(login))
        {
            isValid = false;
            throw new WrongLoginException("Empty login");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            isValid = false;
            throw new WrongPasswordException("Empty password");
        }

        if (login.Length >= 20)
        {
            isValid = false;
            throw new WrongLoginException("Login length should be less than 20.");
        }

        if (password.Length >= 20)
        {
            isValid = false;
            throw new WrongPasswordException("Password length should be less than 20.");
        }

        if (login.Contains(' '))
        {
            isValid = false;
            throw new WrongLoginException("Don't use white spaces");
        }

        if (password.Contains(' '))
        {
            isValid = false;
            throw new WrongPasswordException("Don't use white spaces");
        }

        if (!ContainsNumber(password))
        {
            isValid = false;
            throw new WrongPasswordException("Password does not contain at least one number");
        }

        if (password == confirmPassword) return isValid;
        isValid = false;
        throw new WrongPasswordException("Password mismatch");
    }

    private static bool ContainsNumber(string input)
    {
        return Regex.IsMatch(input, @"\d");
    }
}