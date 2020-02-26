using System;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        #region STEP 3 Product Plan Models
        #endregion

        #region "STEP 4 Create Subscription Models
        public class Subscription
        {
            public Subscription()
            {

            }
            public Subscription(string planId)
            {
                this.plan_id = planId;
                this.start_time = DateTime.UtcNow;
                this.subscriber = new Subscriber()
                {
                    email_address = "sb-r7ose910540@personal.example.com",
                    name = new Name() { given_name = "John", surname = "Doe" }
                };

                this.application_context = new ApplicationContext()
                {
                    brand_name = "MHPU Membership Subscription",
                    locale = "en-US",
                    shipping_preference = "",
                    user_action = "SUBSCRIBE_NOW",
                    payment_method = new PaymentMethod()
                    {
                        payer_selected = "PAYPAL",
                        payee_preferred = "IMMEDIATE_PAYMENT_REQUIRED"
                    },
                    return_url = "http://shoppingbird.azurewebsites.net/success",
                    cancel_url = "http://shoppingbird.azurewebsites.net/failure"

                };
            }

            public string plan_id { get; set; }
            public DateTime start_time { get; set; }
            public Subscriber subscriber { get; set; }
            public ApplicationContext application_context { get; set; }
        }

        #endregion
    }


}
