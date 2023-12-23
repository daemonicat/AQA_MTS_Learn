namespace Generics;

public class Company<TP>(TP ceo)
{
    public TP Ceo { get; set; } = ceo; // президент компании
}