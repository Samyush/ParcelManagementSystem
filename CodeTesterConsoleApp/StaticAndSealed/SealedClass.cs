namespace CodeTesterConsoleApp.StaticAndSealed;

//static or sealed class can't be inherited 

public sealed class SealedClass
{
    public void Test()
    {
        Console.WriteLine("must be working");
    }
}

/*public class Inheritor : SealedClass
{
    //we cannot inherit sealed class
}*/