using System.ComponentModel;

public class Program
{
    [Obsolete("Don't use OldMethod, use NewMethod instead", false)]

    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }
    public static void Main()
    {
        OldMethod();
    }

    
}