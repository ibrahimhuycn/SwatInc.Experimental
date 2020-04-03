namespace SmsShared
{
    public interface ISms
    {
        bool Send(SendSmsArgs smsArgs);
    }
}