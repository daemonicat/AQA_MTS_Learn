namespace AbstractClasses.Game;

public abstract class Character
{
    public int level;
    public string name;

    public Character(int level)
    {
        this.level = level;
    }
    
    // abstract метод создаётся без тела метода
    public abstract void Move();
    public abstract void Attack();
    public abstract void UseAbility();

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}, level: {level}");
    }

    public abstract string Clan { get; set; }
}