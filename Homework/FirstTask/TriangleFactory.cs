namespace Homework.FirstTask;

public static class TriangleFactory
{
    // isosceles, equilateral, right, scalene triangles
    public static DefaultTriangle CreateTriangle(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return new EquilateralTriangle(a, b, c);
        }

        if (a == b || a == c || b == c)
        {
            return new IsoscelesTriangle(a, b, c);
        }

        if (a > b && a > c)
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                return new RightTriangle(a, b, c);
            }
        }

        if (b > a && b > c)
        {
            if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                return new RightTriangle(a, b, c);
            }
        }

        if (c > a && c > b)
        {
            if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
            {
                return new RightTriangle(a, b, c);
            }
        }

        return new DefaultTriangle(a, b, c);
    }
}