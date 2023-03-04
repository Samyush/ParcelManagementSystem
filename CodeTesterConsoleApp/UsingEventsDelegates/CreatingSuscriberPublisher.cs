using CodeTesterConsoleApp.UsingEventsDelegates;
using CodeTesterConsoleApp;

public class CreatingSuscriberPublisher
{

    public CreatingSuscriberPublisher()
    {
        var video = new Video() { Title = "Video 1" };
        var videoEncoder = new VideoEncoder(); // Publisher
        var mailService = new MailService(); // Suscriber
        var messageService = new MessageService(); // Suscriber

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);
    }

}

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("MailService: Sending an email...");
    }
}

public class MessageService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("MessageService: Sending a text message...");
    }
}