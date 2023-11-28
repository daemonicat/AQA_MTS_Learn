namespace Classes.Models;

public class Person
{
    public string name = "Undefined";
    public int age;

    public void Print()
    {
        Console.WriteLine($"Имя: {name} ;  Возраст: {age}");
    }
}