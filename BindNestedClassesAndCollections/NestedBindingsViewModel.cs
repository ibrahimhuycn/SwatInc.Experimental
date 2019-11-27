using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindNestedClassesAndCollections
{
    public class NestedBindingsViewModel
    {
        public NestedBindingsViewModel()
        {
            this.Requests = new ObservableCollection<Request>();
            this.SelectedSample = new ObservableCollection<Sample>();
        }
        public ObservableCollection<Request> Requests;
        public ObservableCollection<Sample> SelectedSample;
    }
}
