namespace Homework.FirstTask;

public class ScaleneTriangle : DefaultTriangle
{
    private double P => (A + B + C) / 2;
    
    public ScaleneTriangle(double a, double b, double c) : base(a, b, c)
    {
    }
    
    public override double GetArea()
    {
        return double.Sqrt(P * (P - A) * (P - B) * (P - C));
    }
}