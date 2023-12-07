namespace Homework.FirstTask;

public class Square : BaseFigure
{
    public Square(int a) : base(a)
    {
    }

    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }
}