namespace CodeTesterConsoleApp;

public class RefAndOut
{
    public int Update(out int c, ref int b)
    {
        c = 100;
        // values to b can be assigned in this format too
        //b = 100;
        return c + b;
    }
}