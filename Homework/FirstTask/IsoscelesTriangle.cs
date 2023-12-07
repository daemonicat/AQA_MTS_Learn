namespace Homework.FirstTask;

public class IsoscelesTriangle : DefaultTriangle
{
    public IsoscelesTriangle(int a, int b, int c) : base(a, b, c)
    {
    }

    public double GetIsoscelesTriangleArea()
    {
        if (Math.Abs(A - B) < 0.0001)
        {
            return 0.5 * C * double.Sqrt(A * A - C * C / 4);
        }

        if (Math.Abs(A - C) < 0.0001)
        {
            return 0.5 * B * double.Sqrt(A * A - B * B / 4);
        }

        if (Math.Abs(B - C) < 0.0001)
        {
            return 0.5 * A * double.Sqrt(B * B - A * A / 4);
        }

        return base.GetArea();
    }
}