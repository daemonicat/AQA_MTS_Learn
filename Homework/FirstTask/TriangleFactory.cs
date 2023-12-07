namespace Homework.FirstTask;

public static class TriangleFactory
{
    // isosceles, equilateral, right, scalene triangles
    public static DefaultTriangle CreateTriangle(int a, int b, int c)
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
            if (a * a == b * b + c * c)
            {
                return new RightTriangle(a, b, c);
            }
        }

        if (b > a && b > c)
        {
            if (b * b == a * a + c * c)
            {
                return new RightTriangle(a, b, c);
            }
        }

        if (c > a && c > b)
        {
            if (c * c == b * b + a * a)
            {
                return new RightTriangle(a, b, c);
            }
        }

        if (a != b && b != c)
        {
            return new ScaleneTriangle(a, b, c);
        }

        return new DefaultTriangle(a, b, c);
    }
}