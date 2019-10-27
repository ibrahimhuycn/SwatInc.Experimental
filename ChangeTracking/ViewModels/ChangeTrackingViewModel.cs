using ChangeTracking.Models;
using System.ComponentModel;

namespace ChangeTracking.ViewModels
{
    public class ChangeTrackingViewModel : INotifyPropertyChanged
    {
        private PatientModel _patientModel;

        #region Constructor
        public ChangeTrackingViewModel(PatientModel patientModel)
        {
            this._patientModel = patientModel;
        }
        #endregion

        public PatientModel DirtyPatientModel
        {
            get => _patientModel;
            set => _patientModel = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName = "")
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
