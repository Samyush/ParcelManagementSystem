namespace CodeTesterConsoleApp;

public class PropertyVsField
{
    public int Field;

    public int Property { get; set; }

    public void Printer()
    {
        Console.WriteLine(Field + " This a Field and " + Property + " This is a Property");
        
        //Console.WriteLine("ThisIsTest".ToCharArray().Reverse());
    }

}