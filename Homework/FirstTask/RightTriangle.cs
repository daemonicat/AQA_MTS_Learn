namespace Homework.FirstTask;

public class RightTriangle : DefaultTriangle
{
    public RightTriangle(double a, double b, double c) : base(a, b, c)
    {
    }

    public override double GetArea()
    {
        if (A > B && A > C)
        {
            return 0.5 * B * C;
        }

        if (B > A && B > C)
        {
            return 0.5 * A * C;
        }

        if (C > A && C > B)
        {
            return 0.5 * A * B;
        }

        return base.GetArea();
    }
}