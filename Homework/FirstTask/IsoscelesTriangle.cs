namespace Homework.FirstTask;

public class IsoscelesTriangle : DefaultTriangle
{
    public IsoscelesTriangle(int a, int b, int c) : base(a, b, c)
    {
    }

    public double GetIsoscelesTriangleArea()
    {
        if (a == b)
        {
            return 0.5 * c * double.Sqrt(a * a - c * c / 4);
        }

        if (a == c)
        {
            return 0.5 * b * double.Sqrt(a * a - b * b / 4);
        }

        if (b == c)
        {
            return 0.5 * a * double.Sqrt(b * b - a * a / 4);
        }

        return base.GetTriangleArea();
    }
}