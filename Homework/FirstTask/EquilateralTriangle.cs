namespace Homework.FirstTask;

public class EquilateralTriangle : DefaultTriangle
{
    public EquilateralTriangle(int a, int b, int c) : base(a, b, c)
    {
    }

    public override double GetArea()
    {
        return Math.Pow(A, 2) * double.Sqrt(3) / 4;
    }
}