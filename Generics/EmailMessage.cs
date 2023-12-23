namespace Generics;

public class EmailMessage(string text) : Message(text)
{
    public EmailMessage() : this("Email Message by default.")
    {
    }
}