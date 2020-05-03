using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FluentValidationTest
{
    public partial class Form1 : Form
    {
        private readonly Form1ViewModel _viewModel;

        public Form1(Form1ViewModel viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;
            InitializeBinding();
            textEditNid.Validating += TextEditNid_Validating;
           // CreateJson();
        }

        private void CreateJson()
        {
            var jsonValidationData = new List<ValidationData>()
            {
                new ValidationData(){Tag="CIN",Regex=@"nCoV-\d{1,5}(?:R\d{1,2})?\/\d{2}"},
                new ValidationData(){Tag="NationalId",Regex=@"A\d{6}"}
            };

            Clipboard.SetText(JsonConvert.SerializeObject(jsonValidationData));
        }

        private void InitializeBinding()
        {
            textEditNid.DataBindings.Add
            (new Binding("EditValue", _viewModel, nameof(_viewModel.NationalIDCardNumber),
            true, DataSourceUpdateMode.OnPropertyChanged));

            textEditNid.DataBindings.Add
            (new Binding("ErrorText", _viewModel, nameof(_viewModel.NidErrorText),
            true, DataSourceUpdateMode.OnPropertyChanged));

        }

        private void TextEditNid_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !(_viewModel.ValidateNid());
        }
    }
}
