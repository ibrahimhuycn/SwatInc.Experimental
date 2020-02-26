using System.Collections.Generic;
using System.Linq;

namespace PayPalSubscriptionsPOC
{
    partial class Program
    {
        #region STEP 1 Get Access Token MOdels

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

        #endregion
    }


}
