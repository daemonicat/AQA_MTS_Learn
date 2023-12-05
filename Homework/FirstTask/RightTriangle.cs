namespace Homework.FirstTask;

public class RightTriangle : DefaultTriangle
{
    public RightTriangle(int a, int b, int c) : base(a, b, c)
    {
    }

    public override double GetTriangleArea()
    {
        if (a > b && a > c)
        {
            return 0.5 * b * c;
        }
        
        if (b > a && b > c)
        {
            return 0.5 * a * c;
        }
        
        if (c > a && c > b)
        {
            return 0.5 * a * b;
        }

        return base.GetTriangleArea();
    }
}