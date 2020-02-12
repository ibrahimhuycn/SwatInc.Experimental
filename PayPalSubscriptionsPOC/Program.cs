using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PayPalSubscriptionsPOC
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Authenticating with PayPal...");
                AccessTokenModel token = PayPalAuth.GetAccessToken(new PaypalClientModel());
                Console.WriteLine("Authentication Successful...");

                Console.WriteLine("Creating Product...");
                var createdProduct = SubcriptionFunctions.CreateProduct(token);
                Console.WriteLine("Product Successfully created...");

                Console.WriteLine("Creating Plan...");
                Console.WriteLine("Plan Successfully created...");

                Console.WriteLine("Creating subscription...");
                Console.WriteLine("subscriptions Successfully created...");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //
            Console.ReadLine();

        }

        public class SubcriptionFunctions
        {
            private static  string BaseUrl = @"https://api.sandbox.paypal.com/v1/";
            public static ProductCreatedResponseModel CreateProduct(AccessTokenModel accessTokenModel)
            {
                if (accessTokenModel is null) throw new ArgumentNullException();
                var client = new RestClient($"{BaseUrl}catalogs/products");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"{accessTokenModel.token_type} {accessTokenModel.access_token}");
                request.AddJsonBody(new ProductModel());

                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<ProductCreatedResponseModel>(response.Content);

            }
        }

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

        public class AccessTokenModel
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
            public List<string> ScopeList { get; private set; }
            public string access_token { get; set; }
            public string token_type { get; set; }
            public string app_id { get; set; }
            public long expires_in { get; set; }
            public string nonce { get; set; }
        }

        public class PaypalClientModel
        {
            public string clientId = "AVeLPjw99V_seFhy9ByHAhgZcr2UA0TZRrWiU0yZXBhgZbqIDQjiz3reFqTmH9ozFa61HE8cvlMwvCtG";
            public string clientSecret = "EDaCNfV0c8R19xKYqjAqEuAOeZopeBP7OqKuZ1NbbSUOF9C-IeNAHZqbVPWNv-jIU4KOStjsF41kvZbp";
            public string sandboxUrl = @"https://api.sandbox.paypal.com/v1/oauth2/token";

        }

        public class ProductModel
        {
            public ProductModel()
            {
                this.id = $"MHPU-{DateTime.Today.Day}{DateTime.Today.Month}{DateTime.Today.Year}";
                this.name = "MHPU Membership Subscription";
                this.description = "This is a yearly subscription for MHPU membership";
                this.type = "SERVICE";
                this.category = "MEMBERSHIP_CLUBS_AND_ORGANIZATIONS";
                this.image_url = @"https://icons-for-free.com/iconfiles/png/512/chemistry+lab+laboratory+experiment-1320568120013842296.png";
                this.home_url = "https://example.com/home";

            }
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string type { get; private set; }
            public string category { get; private set; }
            public string image_url { get; private set; }
            public string home_url { get; private set; }
        }

        public class LinkModel
        {
            public string href { get; set; }
            public string rel { get; set; }
            public string method { get; set; }
        }

        public class ProductCreatedResponseModel
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public string category { get; set; }
            public string image_url { get; set; }
            public string home_url { get; set; }
            public DateTime create_time { get; set; }
            public DateTime update_time { get; set; }
            public List<LinkModel> links { get; set; }
        }
    }
}
