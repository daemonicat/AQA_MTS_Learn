namespace Homework.FirstTask;

public class Square : Rectangle
{
    public Square(double a) : base(a, a)
    {
    }

    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }
}