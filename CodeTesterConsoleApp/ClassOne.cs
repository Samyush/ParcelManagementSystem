namespace CodeTesterConsoleApp;

public class ClassOne : ClassTwo
{
    //we cannot create instance of abstract class
    //ClassTwo classTwo = new();
}

public abstract class ClassTwo
{
    /// <summary>
    ///     this is xml comment
    /// </summary>
    private PartialClass test = new();

    public void Tester()
    {
        PartialClass.tester();
        Console.WriteLine("test");
        using (var file = File.CreateText(@"D:\path.txt"))
        {
            //using of "using statement"

            /*var serializer = new JsonSerializer();
            //serialize object directly into file stream
            serializer.Serialize(file, _data);*/
        }
    }
}