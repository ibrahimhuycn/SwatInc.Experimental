using System;
using System.Diagnostics;
using Telesign;

namespace TelesignMessaging
{
    public class Sms
    {
        private bool IsSmsSendingSuccessful;
        private const string customerId = "17CB5BFB-78E1-407A-A05D-3BB9EFBD2A7B";
        private const string apiKey = "7QXLmGbYUB/iyG0Id+WXiZnIrG/RJ1GtAIgn1Maz6Rfq7jpoAOeI9PVe0PWUwytW+rq3Ky6BVeNCLSvc72GBng==";
        public bool Send(SendSmsArgs smsArgs)
        {
            IsSmsSendingSuccessful = false;
            
            string phoneNumber = smsArgs.ReceiverPhoneNumber; //format: 9607657111
            string message = smsArgs.Message;
            string messageType = "ARN";

            try
            {
                MessagingClient messagingClient = new MessagingClient(customerId, apiKey);
                RestClient.TelesignResponse telesignResponse = messagingClient.Message(phoneNumber, message, messageType);
                IsSmsSendingSuccessful = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                IsSmsSendingSuccessful = false;
            }

            return IsSmsSendingSuccessful;
        }
    }
}