using Exceptions;
using Exceptions.Homework;

/*
int[] array = new int[3];
int value = array[5];
*/

/*
Object obj = null;
obj.GetHashCode();
*/

CheckedExceptions checkedExceptions = new CheckedExceptions();
// checkedExceptions.ReadFile("file.txt");

UncheckedExceptions uncheckedExceptions = new UncheckedExceptions();
// uncheckedExceptions.DivideNumbers(1, 0);

ExceptionUsage exceptionUsage = new ExceptionUsage();
// exceptionUsage.Template();
// exceptionUsage.ShortForm1();
// exceptionUsage.ShortForm2();
// exceptionUsage.ShortForm3();
//
// exceptionUsage.ManyCatch();
//
// exceptionUsage.FilterCatch(1, 0);
// exceptionUsage.FilterCatch(0, 1);

/*string? data = Console.ReadLine();

if (int.TryParse(data, out var x))
{
    Console.WriteLine($"x = {x}");
}
else
{
    Console.WriteLine("Некорректный ввод...");
}*/

ThrowExceptions throwExceptions = new ThrowExceptions();
// throwExceptions.CheckUsername();
// throwExceptions.CheckUsername1();

CustomExceptionUsage customExceptionUsage = new CustomExceptionUsage();
// customExceptionUsage.Run();
// customExceptionUsage.ProcessInput(" ");
// customExceptionUsage.UseCustomArgumentException();
Task1.Logpass();