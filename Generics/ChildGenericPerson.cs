namespace Generics;

public class ChildGenericPerson<T>(T id, string name) : GenericPerson<T>(id, name);