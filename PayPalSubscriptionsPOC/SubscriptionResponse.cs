using System;
using System.Collections.Generic;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        #region "STEP 4 Create Subscription Models

        public class SubscriptionResponse : Subscription
        {
            public string id { get; set; }
            public DateTime create_time { get; set; }
            public List<Link> links { get; set; }
            public string status { get; set; }
            public DateTime status_update_time { get; set; }
        }

        #endregion
    }


}
