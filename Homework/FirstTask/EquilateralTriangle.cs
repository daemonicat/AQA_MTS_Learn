namespace Homework.FirstTask;

public class EquilateralTriangle : DefaultTriangle
{
    public EquilateralTriangle(int a, int b, int c) : base(a, b, c)
    {
    }

    public override double GetTriangleArea()
    {
        return a * a * double.Sqrt(3) / 4;
    }
}