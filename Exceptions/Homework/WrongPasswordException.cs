namespace Exceptions.Homework;

internal class WrongPasswordException : Exception
{
    public WrongPasswordException()
    {
    }

    public WrongPasswordException(string message) : base(message)
    {
    }
}