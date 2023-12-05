namespace Homework.FirstTask;

public class Rectangle
{
    public int a;
    public int b;

    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public virtual int GetRectangleArea()
    {
        return a * b;
    }
}