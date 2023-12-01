public interface IMessageSender
{
    void SendMessage(string message);
}

// Low-level module
public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
  
        Console.WriteLine("Email sent: " + message);
    }
}

// Low-level module
public class SMSSender : IMessageSender
{
    public void SendMessage(string message)
    {
    
        Console.WriteLine("SMS sent: " + message);
    }
}

// High-level module
public class NotificationService
{
    private readonly IMessageSender _messageSender;

    public NotificationService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void SendNotification(string message)
    {
        _messageSender.SendMessage(message);
    }
}