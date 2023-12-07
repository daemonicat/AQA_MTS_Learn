namespace Homework.FirstTask;

public class EquilateralTriangle : DefaultTriangle
{
    public EquilateralTriangle(double a, double b, double c) : base(a, b, c)
    {
    }

    public override double GetArea()
    {
        return Math.Pow(A, 2) * double.Sqrt(3) / 4;
    }
}