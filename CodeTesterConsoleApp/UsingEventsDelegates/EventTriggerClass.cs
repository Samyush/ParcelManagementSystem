namespace CodeTesterConsoleApp.UsingEventsDelegates;

public class EventTriggerClass
{
    //Define Delegate
    // Define an event based on that delegate
    // Raise the event
    
    public delegate void EventTrigger(string message ,object source, EventArgs args);
    
    public event EventTrigger? EventTriggered;
    
    public void TriggerEvent()
    {
        Console.WriteLine("Triggering Event...");
        Thread.Sleep(3000);
        
        OnEventTriggered(message: "General Event Triggered test success");
    }

    //the below method is called when the event is raised and it is called by the publisher [generic method created]
    public void OnEventTriggered(string message = "nth passed")
    {
        if (EventTriggered != null)
            EventTriggered(message ,this, EventArgs.Empty);
        else
        {
            Console.WriteLine("No subscribers to EventTriggered");
        }
    }
}