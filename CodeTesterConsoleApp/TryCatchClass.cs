namespace CodeTesterConsoleApp;

public class TryCatchClass
{
    #region ImplementationOfTryCatch
    public dynamic GettingError(dynamic a)
    {
        try
        {
            int ag = a;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            throw;
        }
        finally
        {
            //string ar = a;
            Console.WriteLine("This is how we use try catch");
        }

        return "this is how it works";
    }


    #endregion
}