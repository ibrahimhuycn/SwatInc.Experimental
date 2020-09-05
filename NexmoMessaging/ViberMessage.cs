using Newtonsoft.Json;
using SmsShared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace NexmoMessaging
{
    public class ViberMessage : ISms
    {
        public bool Send(SendSmsArgs smsArgs)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://messages-sandbox.nexmo.com/v0.1/messages"))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/json");

                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("7c5e5ac9:BjFLZ8yP8fgDk36F"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");


                    var _root = new root()
                    {
                        from = new from() { type = "viber_service_msg",id = "16273" },
                        to = new to() { type = "viber_service_msg", number="9607657111"},
                        message = new message() { content = new content() 
                        {
                            type = "text",
                            text = smsArgs.Message
                        } }
                    };

                    var _content = JsonConvert.SerializeObject(_root);
                    request.Content = new StringContent(_content);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    try
                    {
                        var response = httpClient.SendAsync(request).GetAwaiter().GetResult();
                        if (response.IsSuccessStatusCode)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception(response.ReasonPhrase);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

        }


    }
    public class from
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    public class to
    {
        public string type { get; set; }
        public string number { get; set; }
    }

    public class content
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class message
    {
        public content content { get; set; }
    }

    public class root
    {
        public from from { get; set; }
        public to to { get; set; }
        public message message { get; set; }
    }


}
