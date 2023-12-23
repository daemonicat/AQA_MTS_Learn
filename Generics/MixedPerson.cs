namespace Generics;

public class MixedPerson<T, TK>(T id, string name, TK code) : GenericPerson<T>(id, name)
    where TK : struct
{
    public TK Code { get; set; } = code;
}