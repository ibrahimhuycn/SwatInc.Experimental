using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;
using SmsShared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MessentoSMSLibrary
{
    public class Sms : ISms
    {
        public bool Send(SendSmsArgs smsArgs)
        {
            Configuration conf = new Configuration();
            conf.Username = "ibrahim.hucyn@live.com";
            conf.Password = "Bismillah.123!";
            var apiInstance = new OmnimessageApi(conf);

            var sms = new SMS(
                sender: smsArgs.SenderPhoneNumber,
                text: smsArgs.Message
            );

            List<object> messages = new List<object>();
            messages.Add(sms);

            var omnimessage = new Omnimessage(
                to: smsArgs.ReceiverPhoneNumber,
                messages: messages
            );

            try
            {
                var result = apiInstance.SendOmnimessage(omnimessage);
                Debug.WriteLine(result.ToJson());
                return true;
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendOmnimessage: " + e.Message);
                return false;
            }
        }
    }
}
