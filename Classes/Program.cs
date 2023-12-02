namespace Classes;

public static class Program
{
    public static void Main(string[] args)
    {
        /*/*int[] array = { -4, 8, 10, 2, 12, 0, 5, 6 };

        PrintArray(array);
        Console.WriteLine();

        Array.Reverse(array);
        PrintArray(array);

        Console.WriteLine();

        int sum1 = CalculateSum(1, 2, 3, 4, 5);
        int sum2 = CalculateSum(); // Пустой вызов

        Console.WriteLine("Sum 1: " + sum1);
        Console.WriteLine("Sum 2: " + sum2);

        OutAdd(90, 90, out int ans);

        Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);

        int mainValue = 5;
        Console.WriteLine($"mainValue is {mainValue}");
        ModifyValue(ref mainValue);
        Console.WriteLine($"mainValue now is {mainValue}");

        Console.WriteLine($"Age: {GetPersonAge()}");

        var person1 = GetPersonInfo();
        Console.WriteLine($"Name: {person1.Item1}, Age: {person1.Item2}");

        int factorial4 = Factorial(4);
        int factorial5 = Factorial(5);
        int factorial6 = Factorial(6);

        Console.WriteLine($"Факториал числа 4 = {factorial4}");
        Console.WriteLine($"Факториал числа 5 = {factorial5}");
        Console.WriteLine($"Факториал числа 6 = {factorial6}");#1#

        // -=================== Классы ===================-
        // -=================== Структура класса
        EmptyClass emptyClass = new EmptyClass();

        Person personObj1 = new Person();
        Person personObj2 = new Person();

        personObj1.Print();
        personObj1.name = "Meow";
        personObj1.age = 3;
        personObj1.Print();

        // -=================== Создание конструкторов
        PersonWithConstructor personWithConstructor = new PersonWithConstructor();
        personWithConstructor.Print();

        ConstructorCustom constructorCustom1 = new ConstructorCustom(3);

        ConstructorCustom constructorCustom2 = new ConstructorCustom("Meow");

        constructorCustom1 = new ConstructorCustom("purrr");

        // -=================== Первичные конструкторы
        PersonPrimaryConstructors personPrimaryConstructors4 = new PersonPrimaryConstructors(name: "Meow", age: 3);

        PersonPrimaryConstructors personPrimaryConstructors2 = new PersonPrimaryConstructors(name: "Meow");

        // PersonPrimaryConstructors personPrimaryConstructors1 = new PersonPrimaryConstructors();
        // PersonPrimaryConstructors personPrimaryConstructors3 = new PersonPrimaryConstructors(age: 45);

        personPrimaryConstructors2.Print();
        personPrimaryConstructors4.Print();

        NamespaceA.ClassA classA = new NamespaceA.ClassA();
        classA.Print();
        NamespaceB.ClassA classB = new NamespaceB.ClassA();
        classB.Print();*/

        /*Student[] students = new Student[14];

        for (int i = 0; i < 14; i++)
        {
            students[i] = new Student();
            students[i].studentName = "Meow" + i;
            students[i].group = new Random().Next(2);
            students[i].diplomMark = new Random().Next(1, 11);
        }


        foreach (var student in students)
        {
            if (student.diplomMark == 9 || student.diplomMark == 10)
            {
                student.Print();
            }
        }

        Console.WriteLine();
        Student[] students1 = new Student[14];
        for (int i = 0; i < 14; i++) students1[i] = new Student("Meow" + i);
        foreach (var student in students1)
        {
            student.Print();
        }

        Cat cat = new Cat();
        cat.name = "Meow";
        cat.age = 3;
        cat.maxFoodCount = 5;

        Console.WriteLine(cat.Feeding(3));
        Console.WriteLine(cat.Feeding(5));*/


        /*// -=================== Метод без возвращаемого значения ===================-
        private static void PrintArray(int[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write($"{item} \t");
            }
        }

        // -=================== Метод с переменным числом аргументов ===================-
        private static int CalculateSum(params int[] numbers)
        {
            var sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        // -=================== Передача параметров ===================-
        // -=================== По значению
        private static void SimpleAdd(int x, int y)
        {
            int ans = x + y;

            x = 250;
            y = 888;
        }

        // -=================== По ссылке
        // -=================== Out
        // Значения выходных параметров должны быть установлены внутри вызываемого метода.
        private static void OutAdd(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Практическое применение в тестировании - возврат данных
        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        // -=================== Ref
        private static void ModifyValue(ref int value)
        {
            value = 5 * 2;
        }

        // -=================== Возврат значений ===================-
        // -=================== Возврат значения
        private static int GetPersonAge()
        {
            return 25;
        }

        // -=================== Возврат нескольких значений
        private static (string, int) GetPersonInfo()
        {
            return ("John", 25);
        }

        // -=================== Сжатый метод
        private static int ShortAdd(int х, int у) => х + у;

        // -=================== Рекурсивная функция
        private static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }*/

        Console.WriteLine("Enter task number (1, 2 or 4)");
        var inputNumber = Helpers.GetInputNumber();

        switch (inputNumber)
        {
            case 1:
                Helpers.FirstTask();
                break;
            case 2:
                Helpers.SecondTask();
                break;
            case 4:
                Helpers.FourthTask();
                break;
            default:
                Console.WriteLine("Wrong number");
                break;
        }
    }
}