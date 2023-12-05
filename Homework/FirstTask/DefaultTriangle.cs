using System.Data.SqlTypes;

namespace Homework.FirstTask;

public class DefaultTriangle
{
    public int a;
    public int b;
    public int c;
    private double p
    {
        get => (a + b + c) / 2;
    }

    public DefaultTriangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public virtual double GetTriangleArea()
    {
        return double.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

// isosceles, equilateral, right, scalene triangles
    public string GetTriangleType()
    {
        if (a == b && b == c)
        {
            return "equilateral";
        }

        if (a == b || a == c || b == c)
        {
            return "isosceles";
        }

        if (a != b && b != c)
        {
            return "scalene";
        }

        if (a > b && a > c)
        {
            if (a * a == b * b + c * c)
            {
                return "right";
            }
        }

        if (b > a && b > c)
        {
            if (b * b == a * a + c * c)
            {
                return "right";
            }
        }

        if (c > a && c > b)
        {
            if (c * c == b * b + a * a)
            {
                return "right";
            }
        }

        return "wrong input";
    }
}