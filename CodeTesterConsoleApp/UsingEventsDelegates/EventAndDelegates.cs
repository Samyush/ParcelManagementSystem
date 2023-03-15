namespace CodeTesterConsoleApp.UsingEventsDelegates;

class EventsAndDelegate
{
    public delegate void MyDelegate(string message);
    public event MyDelegate? MyEvent;

    public void RaiseEvent(string message, EventArgs e)
    {
        if (MyEvent != null)
        {
            MyEvent(message);
        }
    }
}