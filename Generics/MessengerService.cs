namespace Generics;

public class MessengerService<T, TP> 
    
    where T : Message
    where TP: SimplePerson
{
    public void SendMessage(TP sender, TP receiver, T message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}