namespace Homework.FirstTask;

public class DefaultTriangle(double a, double b, double c) : BaseFigure
{
    public double A = a;
    public double B = b;
    public double C = c;

    private double P => (A + B + C) / 2;

    public override double GetArea()
    {
        return double.Sqrt(P * (P - A) * (P - B) * (P - C));
    }
}