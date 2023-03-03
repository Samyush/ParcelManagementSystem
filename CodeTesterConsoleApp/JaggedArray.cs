using System.Collections;

namespace CodeTesterConsoleApp;

public class JaggedArray
{
    //array list => is not recommended to use
    private ArrayList arrayData = new() {1, "", 2.92};

    //array
    private readonly string[] hello = {"one"};

    //list
    private readonly List<string> yo = new() {"hello", "two"};

    //jagged array
    //private JaggedArray _jaggedArray = new JaggedArray();
    //private int[][] jArray = new int[][] {new int[] {1,2,3}, new int[] {1,3,4}};

    public void Tester()
    {
        foreach (var data in yo) Console.WriteLine(data);

        foreach (var datas in yo) Console.WriteLine(datas);

        Console.WriteLine(hello);
        Console.WriteLine(yo);
    }
}