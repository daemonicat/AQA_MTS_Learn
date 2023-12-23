namespace Generics;

public class Person<T, TK>(T id, TK code, string name)
{
    public T Id { get; } = id;
    public TK Code { get; set; } = code;
    public string Name { get; } = name;
}