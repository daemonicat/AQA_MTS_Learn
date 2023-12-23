namespace Generics;

public class MessengerNew<T> where T : new()
{
    private T _message = new();

    public void SendMessage()
    {
        Console.WriteLine($"Sending message: {_message!.ToString()}");
    }
}