namespace Classes.Models;

public class PersonThis
{
    public string name;
    public int age;

    public PersonThis()
    {
        name = "Неизвестно";
        age = 18;
    }

    public PersonThis(string name)
    {
        this.name = name;
        age = 18;
    }

    public PersonThis(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}