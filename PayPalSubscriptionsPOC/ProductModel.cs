using System;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        #region STEP 1 Get Access Token MOdels

        #endregion

        #region STEP 2 Create Product Models
        public class ProductModel
        {
            public ProductModel()
            {
                this.id = $"MHPU-{DateTime.Today.Day}{DateTime.Today.Month}{DateTime.Today.Year}A3";
                this.name = "MHPU Membership Subscription";
                this.description = "This product is our platinum membership subcription at MHPU";
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

        #endregion
    }


}
