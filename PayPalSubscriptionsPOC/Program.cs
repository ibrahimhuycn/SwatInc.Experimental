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
            string clientId = "AVeLPjw99V_seFhy9ByHAhgZcr2UA0TZRrWiU0yZXBhgZbqIDQjiz3reFqTmH9ozFa61HE8cvlMwvCtG";
            string clientSecret = "EDaCNfV0c8R19xKYqjAqEuAOeZopeBP7OqKuZ1NbbSUOF9C-IeNAHZqbVPWNv-jIU4KOStjsF41kvZbp";

            var client = new RestClient("https://api.sandbox.paypal.com/v1/oauth2/token");

            client.Authenticator = new HttpBasicAuthenticator(clientId, clientSecret);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "client_credentials");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            Console.ReadLine();



        }

        public class AccessToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public long expires_in { get; set; }
        }
    }
}
