using Collections;
using Collections.IDictionary;
using Collections.IList;
using Collections.ISet;

// ArrayListExample.Run();

// ListExample.Run();

// LinkedListExample.Run();
//
// DictionaryExample.Run();
//
// SortedDictionaryExample.Run();
//
// SortedListExample.Run();
//
// HashSetExample.Run();
//
// StackExample.Run();
//
// QueueExample.Run();
//
// Example.Run();

var person1 = new Person()
{
    Name = "meow",
    Age = 20
};
var person2 = new Person()
{
    Name = "meow",
    Age = 20
};

Console.WriteLine(person1.GetHashCode());
Console.WriteLine(person2.GetHashCode());
Console.WriteLine(person1.Equals(person2));

IEnumerable<int> GenerateCounter(int count)
{
    for (var i = 0; i < count; i++)
    {
        yield return i;
    }
}

foreach (var number in GenerateCounter(5))
{
    Console.WriteLine(number);
}

foreach (var number in GenerateCounter(8))
{
    Console.WriteLine(number);
}