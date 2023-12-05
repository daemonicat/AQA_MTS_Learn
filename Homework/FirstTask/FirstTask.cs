namespace Homework.FirstTask;

public static class FirstTask
{
    public static void TriangleApp()
    {
        var triangle1 = TriangleFactory.CreateTriangle(3, 4, 5);
        var triangle2 = TriangleFactory.CreateTriangle(3, 3, 3);
        var triangle3 = TriangleFactory.CreateTriangle(4, 4, 5);
        Console.WriteLine(triangle1.GetType());
        Console.WriteLine(triangle2.GetType());
        Console.WriteLine(triangle3.GetType());


        var triangles = new DefaultTriangle[5];
        
        
    }
}