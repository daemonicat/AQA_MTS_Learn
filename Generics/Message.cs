namespace Generics;

public class Message(string text)
{
    public string Text { get; } = text;

    public override string ToString()
    {
        return $"{nameof(Text)}: {Text}";
    }
}