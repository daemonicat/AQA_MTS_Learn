namespace Generics;

public class VaryGenericPerson<T>(int id, string name, T code) : GenericPerson<int>(id, name)
{
    public T Code = code;
}