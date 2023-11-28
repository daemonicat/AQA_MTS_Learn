namespace Classes.Models;

public class PersonWithConstructor
{
    public string name;
    public int age;

    public PersonWithConstructor()
    {
        name = "Undefined";
        age = 3;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {name} ;  Возраст: {age}");
    }
}