using Newtonsoft.Json;
using RestSharp;
using System;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        public class SubcriptionFunctions
        {
            private static string BaseUrl = @"https://api.sandbox.paypal.com/v1/";
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

            public static dynamic CreateProductPlans(AccessTokenModel accessTokenModel, string productId)
            {

                if (accessTokenModel is null) throw new ArgumentNullException();
                var client = new RestClient($"{BaseUrl}billing/plans");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Prefer", "return=representation");
                request.AddHeader("Authorization", $"{accessTokenModel.token_type} {accessTokenModel.access_token}");
                request.AddJsonBody(new ProductPlan(productId));

                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<dynamic>(response.Content);
            }

            public static SubscriptionResponse CreateSubscription(AccessTokenModel accessTokenModel)
            {

                if (accessTokenModel is null) throw new ArgumentNullException();
                var client = new RestClient($"{BaseUrl}billing/subscriptions");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"{accessTokenModel.token_type} {accessTokenModel.access_token}");
                request.AddHeader("PayPal-Request-Id", $"SUBSCRIPTION-{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}{DateTime.Now.Millisecond}");
                request.AddHeader("Prefer", "return=representation");
                request.AddJsonBody(new Subscription("P-09S060624C5333104LZCJQ2Y"));

                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<SubscriptionResponse>(response.Content);
            }
        }
    }


}
