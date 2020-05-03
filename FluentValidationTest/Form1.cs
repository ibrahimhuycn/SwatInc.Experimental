using FluentValidation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

    public class Form1ViewModel : INotifyPropertyChanged
    {
        private string nationalIDCardNumber;
        private string nidErrorText;
        public Form1ViewModel()
        {
            NidErrorText = null;
        }
        public string NationalIDCardNumber
        {
            get => nationalIDCardNumber; set
            {
                if (nationalIDCardNumber == value) return;
                nationalIDCardNumber = value;
                PropertyChanged?.Invoke
                    (this, new PropertyChangedEventArgs(nameof(NationalIDCardNumber)));
            }
        }
        public string NidErrorText
        {
            get => nidErrorText; set
            {
                nidErrorText = value;
                PropertyChanged?.Invoke
                    (this, new PropertyChangedEventArgs(nameof(NidErrorText)));
            }
        }


        public bool ValidateNid()
        {
            var validator = new Form1ViewModelValidator();
            var results = validator.Validate(this);

            string errorMessages = null;
            if (!results.IsValid)
            {
                foreach (var message in results.Errors)
                {
                    errorMessages += message + "\n";
                }

                NidErrorText = errorMessages;
            }
            else
            {
                NidErrorText = null;
            }

            return results.IsValid;
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

    public class Form1ViewModelValidator : AbstractValidator<Form1ViewModel>
    {
        public Form1ViewModelValidator()
        {
            RuleFor(n => n.NationalIDCardNumber)
                .Must(BeAValidNid).WithMessage("Invalid card number!");
        }

        protected bool BeAValidNid(string nid)
        {
            var a = ValidationHelper.Cin.IsMatch(nid);
            return a;
        }
    }

    public static class ValidationHelper
    {
        static List<ValidationData> validationData =
            JsonConvert.DeserializeObject<List<ValidationData>>(DiskIO.ReadValidationData());

        public static Regex Cin = new Regex(validationData.Find(v=> v.Tag == "CIN").Regex, RegexOptions.Compiled);

    }

    public class DiskIO
    {
        public static string ReadValidationData()
        {
            return File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\ValidationData.json");
        }
    }
}
