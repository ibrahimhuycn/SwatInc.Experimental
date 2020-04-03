using SmsShared;

namespace SmsUI
{
    public class OnlineSmsViewmodel
    {
        private ISms _smsService;

        public OnlineSmsViewmodel(ISms MessagingService)
        {
            this._smsService = MessagingService;
            this.From = "+16572209754";
        }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }

        public bool SendMessage()
        {
           return _smsService.Send(new SendSmsArgs()
            {
                ReceiverPhoneNumber = this.To,
                SenderPhoneNumber = this.From,
                Message = this.Message
            });
        }
    }
}
