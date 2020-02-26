using System;
using System.Collections.Generic;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        #region STEP 2 Create Product Models

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

        #endregion
    }


}
