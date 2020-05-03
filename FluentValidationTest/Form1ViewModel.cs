using System.ComponentModel;

namespace FluentValidationTest
{
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
}
