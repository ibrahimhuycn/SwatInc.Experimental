using ChangeTracking.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeTracking
{
    public partial class ChangeTrackingView : Form
    {
        private ChangeTrackingViewModel _viewModel;

        public ChangeTrackingView(ChangeTrackingViewModel viewModel)
        {
            InitializeComponent();
            InitializeDataBinding(viewModel);

        }

        private void InitializeDataBinding(ChangeTrackingViewModel viewModel)
        {
            this._viewModel = viewModel;

            //Initialize sample model
          //  _viewModel.DirtyPatientModel = new Models.PatientModel() { MedicalRecordNumber = "MJN3424", LastName = "Hussain" };

            //Binding Medical Record Number
            textBoxMrn.DataBindings.Add(new Binding("Text", _viewModel.DirtyPatientModel, nameof(_viewModel.DirtyPatientModel.MedicalRecordNumber)));

            //Binding Save button Enabled State
            buttonSave.DataBindings.Add(new Binding("Enabled", _viewModel.DirtyPatientModel, nameof(_viewModel.DirtyPatientModel.HasChangedData)));
        }
    }
}
