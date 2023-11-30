namespace Classes.Models;

public class Cat
{
    public string name;
    public int age;
    public int maxFoodCount;

    public bool Feeding(int FoodCount)
    {
        return FoodCount >= maxFoodCount;
    }
}