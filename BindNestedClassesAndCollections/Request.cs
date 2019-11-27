using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindNestedClassesAndCollections
{
    public class Request
    {
        public Request()
        {
            this.Samples = new ObservableCollection<Sample>();
        }
        public string RequestNo { get; set; }
        public string PatientName { get; set; }

        public ObservableCollection<Sample> Samples;

    }

    public class Sample
    {
        public string SampleNo { get; set; }

    }
}
