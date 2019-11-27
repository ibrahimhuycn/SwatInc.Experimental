using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindNestedClassesAndCollections
{
    public class Request
    {
        public Request()
        {
            this.Samples = new List<Sample>();
        }
        public string RequestNo { get; set; }
        public string PatientName { get; set; }

        public List<Sample> Samples;

    }

    public class Sample
    {
        public string SampleNo { get; set; }

    }
}
