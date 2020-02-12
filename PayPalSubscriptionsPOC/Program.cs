using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalSubscriptionsPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = PayPalAuth.GetAccessToken(new PaypalClient());
            Console.ReadLine();

        }

        public class PayPalAuth
        {
            public static AccessToken GetAccessToken(PaypalClient AuthData)
            {
                var client = new RestClient(AuthData.sandboxUrl)
                {
                    Authenticator = new HttpBasicAuthenticator(AuthData.clientId, AuthData.clientSecret),
                    Timeout = -1
                };


                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("grant_type", "client_credentials");

                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<AccessToken>(response.Content);
            }
        }

        public class AccessToken
        {
            private string _scope { get; set; }
            public string scope 
            {
                get
                {
                    return _scope;
                }
                set 
                {
                    this._scope = value;
                    ScopeList = _scope.Split(' ').ToList();
                }
            }
            public List<string>  ScopeList { get; private set; }
            public string access_token { get; set; }
            public string token_type { get; set; }
            public string app_id { get; set; }
            public long expires_in { get; set; }
            public string nonce { get; set; }
        }

        public class PaypalClient
        {
            public string clientId = "AVeLPjw99V_seFhy9ByHAhgZcr2UA0TZRrWiU0yZXBhgZbqIDQjiz3reFqTmH9ozFa61HE8cvlMwvCtG";
            public string clientSecret = "EDaCNfV0c8R19xKYqjAqEuAOeZopeBP7OqKuZ1NbbSUOF9C-IeNAHZqbVPWNv-jIU4KOStjsF41kvZbp";
            public string sandboxUrl = @"https://api.sandbox.paypal.com/v1/oauth2/token";

        }
    }
}
