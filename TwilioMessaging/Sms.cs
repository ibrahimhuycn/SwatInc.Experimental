using SmsShared;
using System.Diagnostics;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010.Account;
namespace TwilioMessaging
{
    public class Sms : ISms
    {
        //+1 657 220 9754
        private const string AccountId = "ACcb06091ba40a576ea09bcc1dceaff557";
        private const string AuthToken = "38e76c2d21b0d862b3cfbaff05c15d37";

        public bool Send(SendSmsArgs smsArgs)
        {
            bool IsSendSuccess = false;
            TwilioClient.Init(AccountId, AuthToken);

            try
            {
                var message = MessageResource.Create(
                    body: smsArgs.Message,
                    from: new Twilio.Types.PhoneNumber(smsArgs.SenderPhoneNumber),
                    to: new Twilio.Types.PhoneNumber(smsArgs.ReceiverPhoneNumber)
                );

                Debug.WriteLine(message.Sid);
                IsSendSuccess = true;
            }
            catch (ApiException e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine($"Twilio Error {e.Code} - {e.MoreInfo}");
                IsSendSuccess = false;
            }

            return IsSendSuccess;
        }

    }
}

