using System.Collections.Generic;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        #region STEP 3 Product Plan Models

        public class ProductPlan
        {
            public ProductPlan(string productId)
            {
                this.product_id = productId;
                this.name = "BASIC MEMBERSHIP PLAN";
                this.description = "This is the basic membership plan for MHPU.";

                this.billing_cycles = new List<BillingCycle>()
                {
                    new BillingCycle() {
                        frequency = new Frequency() {  interval_unit= "MONTH", interval_count = 1 },
                        tenure_type = "TRIAL",
                        sequence = 1,
                        total_cycles =1
                    },
                    new BillingCycle() {
                        frequency = new Frequency() {  interval_unit= "MONTH", interval_count = 1 },
                        tenure_type = "REGULAR",
                        sequence = 2,
                        total_cycles = 12,
                        pricing_scheme = new PricingScheme()
                        {
                             fixed_price = new FixedPrice()
                             {
                                 value = "10",
                                 currency_code = "USD"
                             }
                        }
                    }
                    
                };
                this.payment_preferences = new PaymentPreferences()
                {
                    auto_bill_outstanding = true,
                    setup_fee = new SetupFee()
                    {
                        value = "10",
                        currency_code = "USD"
                    },
                    setup_fee_failure_action = "CONTINUE",
                    payment_failure_threshold = 3
                };
                this.taxes = new Taxes()
                {
                    percentage = "10",
                    inclusive = false
                };
            }
            public string product_id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public List<BillingCycle> billing_cycles { get; set; }
            public PaymentPreferences payment_preferences { get; set; }
            public Taxes taxes { get; set; }
        }

        #endregion
    }


}
