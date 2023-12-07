namespace Homework.FirstTask;

public class Rectangle(double a, double b) : BaseFigure
{
    public double A = a;
    public double B = b;


    public override double GetArea()
    {
        return A * B;
    }
}