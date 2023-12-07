namespace Homework.FirstTask;

public class BaseFigure
{
    protected double A;
    protected double B;
    protected double C;

    protected BaseFigure(double a)
    {
        A = a;
    }

    protected BaseFigure(double a, double b)
    {
        A = a;
        B = b;
    }

    protected BaseFigure(double a, double b, double c) : this(a, b)
    {
        C = c;
    }

    public virtual double GetArea()
    {
        return A * B * C;
    }
}