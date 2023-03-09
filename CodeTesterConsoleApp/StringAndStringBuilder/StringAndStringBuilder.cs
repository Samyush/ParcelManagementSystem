using System.Text;

namespace CodeTesterConsoleApp.StringAndStringBuilder;

public static class StringAndStringBuilder
{

    public static void WorkingWithStrings()
    {
        // string is immutable and StringBuilder is mutable
        // string is faster than StringBuilder
        // here in the below str we are creating
        // a new string every time we add a new string
        // i.e we are creating a new string in the memory every time || a total of 5
        // so it is not efficient
        string str = "Hello";
        str += " World";
        str += " This";
        str += " is";
        str += " Me";
        str += " Testing";

        Console.WriteLine(str);
    }
    
    public static void WorkingWithStringBuilder()
    {
        // here in the below builder we are creating
        //StringBuilder bt = "Hello"; -> this is not allowed
        var builder = new StringBuilder("Hello");
        builder.Append('-', 10);
        builder.AppendLine();
        builder.Append("Header");
        builder.AppendLine();
        builder.Append('-', 10);
        builder.Replace('-', '+');
        //builder.Remove(0, 10);
        builder.Insert(0, new string('-', 10));
        Console.WriteLine(builder);
        Console.WriteLine("First Char: " + builder[0]);
    }

}