using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        public class PayPalAuth
        {
            public static AccessTokenModel GetAccessToken(PaypalClientModel AuthData)
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
                return JsonConvert.DeserializeObject<AccessTokenModel>(response.Content);
            }
        }
    }


}
