namespace Homework.FirstTask;

public static class FirstTask
{
    public static void TriangleApp()
    {
        var figures = new BaseFigure[6];
        figures[0] = TriangleFactory.CreateTriangle(3, 4, 5);
        figures[1] = TriangleFactory.CreateTriangle(3, 3, 3);
        figures[2] = TriangleFactory.CreateTriangle(4, 4, 5);
        figures[3] = TriangleFactory.CreateTriangle(3, 4, 6);
        figures[4] = new Rectangle(7, 12);
        figures[5] = new Square(5);

        foreach (var figure in figures)
        {
            Console.WriteLine(figure.GetArea());
        }
    }
}