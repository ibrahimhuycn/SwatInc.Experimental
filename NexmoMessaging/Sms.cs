using Nexmo.Api;
using SmsShared;
using System;
using System.Diagnostics;

namespace NexmoMessaging
{
    public class Sms : ISms
    {
        private bool IsSenndingMessageSuccessful;



        public bool Send(SendSmsArgs smsArgs)
        {
            IsSenndingMessageSuccessful = false;



            try
            {
                string API_KEY = "7c5e5ac9";
                string API_SECRET = "BjFLZ8yP8fgDk36F";

                var client = new Client(creds: new Nexmo.Api.Request.Credentials
                            (nexmoApiKey: API_KEY, nexmoApiSecret: API_SECRET));

                var results = client.SMS.Send(new SMS.SMSRequest
                {
                    from = smsArgs.SenderPhoneNumber,
                    to = smsArgs.ReceiverPhoneNumber,
                    text = smsArgs.Message
                });

                IsSenndingMessageSuccessful = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                IsSenndingMessageSuccessful = false;
            }

            return IsSenndingMessageSuccessful;
        }
    }
}
