namespace Homework.FirstTask;

public class IsoscelesTriangle : DefaultTriangle
{
    public IsoscelesTriangle(double a, double b, double c) : base(a, b, c)
    {
    }

    public override double GetArea()
    {
        if (A.Equals(B))
        {
            return 0.5 * C * double.Sqrt(Math.Pow(A, 2) - Math.Pow(C, 2) / 4);
        }

        if (A.Equals(C))
        {
            return 0.5 * B * double.Sqrt(Math.Pow(A, 2) - Math.Pow(B, 2) / 4);
        }

        if (B.Equals(C))
        {
            return 0.5 * A * double.Sqrt(Math.Pow(B, 2) - Math.Pow(A, 2) / 4);
        }

        return base.GetArea();
    }
}