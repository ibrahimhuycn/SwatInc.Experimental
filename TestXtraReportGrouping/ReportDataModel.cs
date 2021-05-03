using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXtraReportGrouping
{
    public class ReportDataModel
    {
        public string SectionName { get; set; }
        public string PrimaryGroupName { get; set; }
        public string SecondaryGroupName { get; set; }

        public string DetailName { get; set; }

        public string DetailValue { get; set; }
    }
}
