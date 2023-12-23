namespace Generics;

public abstract class StaticPerson<T>(T id, string name)
{
    public static T? Code;

    private T Id { get; } = id;
    private string Name { get; } = name;

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}