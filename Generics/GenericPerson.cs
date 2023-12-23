namespace Generics;

public class GenericPerson<T>(T id, string name)
{
    public T Id { get; } = id;
    private string Name { get; } = name;

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}