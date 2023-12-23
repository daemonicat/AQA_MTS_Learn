namespace Generics;

public class ChildWherePerson<T>(T id, string name) : GenericPerson<T>(id, name)
    where T : class;