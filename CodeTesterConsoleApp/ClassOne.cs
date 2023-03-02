using CodeTesterConsoleApp;

namespace CodeTesterConsoleApp;

public class ClassOne : ClassTwo
{
    
}

public abstract class ClassTwo
{
    PartialClass test = new();

    public void Tester()
    {
        PartialClass.tester();
        Console.WriteLine("test");
    }
}