using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace BindNestedClassesAndCollections
{
    public partial class NestedBinding : Form
    {
        private NestedBindingsViewModel _viewModel;
        private ObservableCollection<Sample> tempSamples = new ObservableCollection<Sample>();
        public NestedBinding(NestedBindingsViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            InitiateDataBindings();

            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Clear the existing selected samples beacuse new request is selected now
            _viewModel.SelectedSample.Clear();

            //Add the new requests Samples.
            Request a = (Request)(gridView1.GetRow(e.FocusedRowHandle));
            if (a != null)
            {
                foreach (var item in a.Samples)
                {
                    _viewModel.SelectedSample.Add(item);
                }
            }

        }

        private void InitiateDataBindings()
        {
            gridControl1.DataSource = _viewModel.Requests;
            gridControl2.DataSource = _viewModel.SelectedSample;
        }

        private void AddRequest(ObservableCollection<Sample> samples)
        {
            var AR = new Request() { RequestNo = textBoxRequestNo.Text, PatientName = textBoxPatientName.Text };

            foreach (var item in samples)
            {
                AR.Samples.Add(item);
            }
            _viewModel.Requests.Add(AR);
            ClearSamplesTemp();
        }

        private void ClearSamplesTemp()
        {
            tempSamples.Clear();
        }

        private void AddTempSamples()
        {
            var sample1 = new Sample { SampleNo = textBoxSampleNo.Text };
            tempSamples.Add(sample1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddRequest(tempSamples);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tempSamples.Add(new Sample() { SampleNo = textBoxSampleNo.Text });
        }
    }
}
