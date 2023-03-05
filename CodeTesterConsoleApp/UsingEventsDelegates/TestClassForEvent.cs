namespace CodeTesterConsoleApp.UsingEventsDelegates;

public class TestClassForEvent
{
    public void TestMethod()
    {
        Console.WriteLine("TEST about to begin");
        Thread.Sleep(3000);
        try
        {
            EventTriggerClass eventTriggerClass = new();
            eventTriggerClass.OnEventTriggered(message: "this is a test message");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}