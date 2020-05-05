using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FluentValidationTest
{
    public static class ValidationHelper
    {
        private static List<ValidationData> validationData =
            JsonConvert.DeserializeObject<List<ValidationData>>(DiskIO.ReadValidationData());

        public static Regex Cin = new Regex(validationData.Find(v=> v.Tag == "CIN").Regex, RegexOptions.Compiled);

    }
}
