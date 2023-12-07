namespace Homework.FirstTask;

public class Rectangle : BaseFigure
{
    public Rectangle(double a, double b) : base(a, b)
    {
    }

    public override double GetArea()
    {
        return A * B;
    }
}