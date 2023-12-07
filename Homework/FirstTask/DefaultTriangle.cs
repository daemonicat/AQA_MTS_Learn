namespace Homework.FirstTask;

public class DefaultTriangle : BaseFigure
{
    private double P => (A + B + C) / 2;

    public DefaultTriangle(double a, double b, double c) : base(a, b, c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double GetArea()
    {
        return double.Sqrt(P * (P - A) * (P - B) * (P - C));
    }
}