namespace Generics;

public readonly struct MessageStruct(string text)
{
    public string Text { get; } = text;

    public override string ToString()
    {
        return $"{nameof(Text)}: {Text}";
    }
}