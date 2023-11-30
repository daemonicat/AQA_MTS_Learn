namespace Classes.Models;

public class Student
{
    public string studentName;
    public int group;
    public int diplomMark;

    public Student()
    {
    }

    public Student(string studentName)
    {
        this.studentName = studentName;
        group = 1;
        diplomMark = new Random().Next(1, 11);
    }
    
    public void Print()
    {
        Console.WriteLine($" name = {studentName}, group = {group}, mark = {diplomMark}");
    }
}