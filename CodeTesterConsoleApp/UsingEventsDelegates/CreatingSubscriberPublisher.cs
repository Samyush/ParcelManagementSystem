namespace CodeTesterConsoleApp.UsingEventsDelegates;

public class CreatingSubscriberPublisher
{

    public CreatingSubscriberPublisher()
    {
        var video = new Video() { Title = "Video 1" };
        var videoEncoder = new VideoEncoder(); // Publisher
        var mailService = new MailService(); // Subscriber
        var messageService = new MessageService(); // Subscriber
        var test = new TestClassForEvent(); // publisher

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);
        
        //my own test for custom generic event
        var eventTriggerClass = new EventTriggerClass();
        //eventTriggerClass.EventTriggered += mailService.OnVideoEncoded;
        eventTriggerClass.EventTriggered += mailService.OnEventTriggered;
        //eventTriggerClass.EventTriggered += messageService.OnVideoEncoded;
        eventTriggerClass.TriggerEvent();
        
        //my own test for custom generic event
        eventTriggerClass.EventTriggered += mailService.OnEventTriggered;
        test.TestMethod();
    }

}

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("MailService: Sending an email...");
    }
    
    public void OnEventTriggered(string message ,object source, EventArgs e)
    {
        Console.WriteLine($"MailService: Sending an email... {message}");
    }
}

public class MessageService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("MessageService: Sending a text message...");
    }
}