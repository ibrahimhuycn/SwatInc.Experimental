using System;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Authenticating with PayPal...");
                AccessTokenModel token = PayPalAuth.GetAccessToken(new PaypalClientModel());
                Console.WriteLine("Authentication Successful...");

                //Console.WriteLine("Creating Product...");
                //var createdProduct = SubcriptionFunctions.CreateProduct(token);
                //Console.WriteLine("Product Successfully created...");

                //Console.WriteLine("Creating Plan...");
                //var createdPlans = SubcriptionFunctions.CreateProductPlans(token, createdProduct.id);
                //Console.WriteLine("Plan Successfully created...");

                Console.WriteLine("Creating subscription...");
                var createdSub = SubcriptionFunctions.CreateSubscription(token);
                Console.WriteLine("subscriptions Successfully created...");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //
            Console.ReadLine();

        }

#region "STEP 4 Create Subscription Models

        #endregion
    }


}
