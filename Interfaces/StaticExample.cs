namespace Interfaces;

public class StaticExample
{
    public static int StaticVar = 0;
    public int InstanceVar = 0;

    public StaticExample()
    {
        StaticVar++;
        InstanceVar += 1;
    }
}