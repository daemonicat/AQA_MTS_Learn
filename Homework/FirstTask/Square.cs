namespace Homework.FirstTask;

public class Square : Rectangle
{
    public Square(int a, int b) : base(a, b)
    {
    }
    
    public override int GetRectangleArea()
    {
        return a * a;
    }
}