namespace TwilioMessaging
{
    public interface ISms
    {
        bool Send(SendSmsArgs smsArgs);
    }
}