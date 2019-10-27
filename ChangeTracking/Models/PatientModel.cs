using ChangeTracking.Interfaces;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ChangeTracking.Models
{
    public class PatientModel : INotifyDirtyData, INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private Type _patientModelType;
        private string _medicalRecordNumber= "ASD2345";
        private string _lastName="";


        #region Constructor
        public PatientModel()
        {
            // Get the type information for this class and stash it away
            // because we will need it when we get property info.
            this._patientModelType = this.GetType();
        }
        #endregion

        #region Dirty Status Management
        // changes is our internal dictionary which holds the changed properties and their original values.
        private static ConcurrentDictionary<String, Object> _changes = new ConcurrentDictionary<String, Object>();

        /// <summary>
        /// Returns true if one or more monitored properties has changed.
        /// </summary>
        public bool HasChangedData => _changes.Count > 0;

        public event PropertyChangedEventHandler DirtyStatusChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void ClearChangedData()
        {
            _changes.Clear();
            // Raise the change events to notify subscribers the dirty status has changed
            RaiseDataChanged("");
        }


        /// <summary>
        /// Returns the original value of the property so it can be compared to the current value or used to restore the original value
        /// </summary>
        /// <param name="propertyName">The name of the class property 
        /// to fetch the original value for.</param>
        /// <returns>If an original value is present, that value will be returned. 
        /// If the original value is not present,  the method will return null.</returns>
        public object GetChangedData(string propertyName)
        {
            if (String.IsNullOrEmpty(propertyName) || !_changes.ContainsKey(propertyName)) return null;
            return _changes[propertyName];
        }

        // CheckDataChange should be called in property setters BEFORE the property value is set. It will
        // check to see if it already has a memory of the properties original value. If not, it will inspect
        // the property to get the original value and then save that back raising the DirtyStatusChanged event
        // in the process. If the new value is the same as the original value, the property will be removed from
        // the list of dirty properties.
        private void CheckDataChange(string propertyName, Object newPropertyValue)
        {
            // If we passed an empty property name, eject.
            if (string.IsNullOrWhiteSpace(propertyName))
                return;

            // Check to see if the property already exists in the dictionary...
            if (_changes.ContainsKey(propertyName))
            {
                // Already exists in the change collection
                if (_changes[propertyName].Equals(newPropertyValue))
                {
                    // The old value and the new value match
                    object oldValueObject = null;
                    _changes.TryRemove(propertyName, out oldValueObject);
                    RaiseDataChanged(propertyName);
                }
                else
                {
                    // New value is different than the original value...
                    // Don't do anything because we already know this value changed.
                }
            }
            else
            {
                // Key is not in the dictionary. Get the original value and save it
                if (!_changes.TryAdd(propertyName, TestAndCastClassProperty(propertyName)))
                    throw new ArgumentException("Unable to add specified property to the changed data dictionary.");
                else
                    RaiseDataChanged(propertyName);
            }
        }

        // Raises the events to notify interested parties that one or more monitored properties are now dirty
        private void RaiseDataChanged(string propertyName)
        {
            // Raise the DirtyStatusChanged event passing the name of the changed property
            if (DirtyStatusChanged != null)
                DirtyStatusChanged(this, new PropertyChangedEventArgs(propertyName));

            // Raise property changed on HasChangedData in case something is bound to that property
            RaisePropertyChanged("HasChangedData");
        }

        // Internal method which will get the value of the specified property
        private object TestAndCastClassProperty(string Property)
        {
            if (string.IsNullOrWhiteSpace(Property))
                return null;
            // _myType is the type info for this class and is fetched during construction.
            PropertyInfo propInfo = _patientModelType.GetProperty(Property);
            if (propInfo == null) { return null; }
            return propInfo.GetValue(this, null);
        }

        #endregion

        #region Properties & Property Notification

        public string MedicalRecordNumber
        {
            get
            {
                // Check to see if the value for the property is valid before returning it
                IsMedicalRecordNumberValid(_medicalRecordNumber);
                return _medicalRecordNumber;
            }
            set
            {
                if (_medicalRecordNumber != value)
                {
                    // Check if the new property value makes this property dirty.
                    // MUST be called before the internal value of the property is set!
                    CheckDataChange(nameof(MedicalRecordNumber), value);
                    _medicalRecordNumber = value;

                    // If there is support for CallerMemberName this should pass nothing:
                    // RaisePropertyChanged();
                    // rather than the explicit property name as demonstrated here:
                    RaisePropertyChanged(nameof(MedicalRecordNumber));
                }

            }
        }
        public string LastName
        {
            get
            {
                // Check to see if the value for the property is valid before returning it
                IsLastNameValid(_lastName);
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    // Check if the new property value makes this property dirty.
                    // MUST be called before the internal value of the property is set!
                    CheckDataChange(nameof(LastName), value);
                    _lastName = value;

                    // If there is support for CallerMemberName this should pass nothing:
                    // RaisePropertyChanged();
                    // rather than the explicit property name as demonstrated here:

                    RaisePropertyChanged(nameof(LastName));
                }
            }
        }

        protected void SetPropertyValue(object newValue, Action setValue, [CallerMemberName] string propertyName = null)
        {
            // This is a general way of checking and setting properties which can be called via a lambda.
            CheckDataChange(propertyName, newValue);
            setValue();
            RaisePropertyChanged(propertyName);
        }

        // Standard property change notification
        // NOTICE: The CallerMemberName attribute is not available in Portable Class Libraries unless you add it yourself!
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Data Validation


        #region Property Validators
        private bool IsMedicalRecordNumberValid(string value)
        {
            bool isValid = true;
            //The property validationa and setting the var
            if (string.IsNullOrEmpty(value))
            {
                AddError(nameof(MedicalRecordNumber), "MRN cannot be empty!", false);
                isValid = false;
            }
            else { RemoveError(nameof(MedicalRecordNumber), "MRN cannot be empty!"); }
            return isValid;
        }

        private bool IsLastNameValid(string value)
        {
            bool isValid = true;
            //The property validationa and setting the var
            if (string.IsNullOrEmpty(value))
            {
                AddError(nameof(LastName), "Lastname cannot be empty!", false);
                isValid = false;
            }
            else { RemoveError(nameof(LastName), "Lastname cannot be empty!"); }
            return isValid;
        }
        #endregion

        #region INotifyDataErrorInfo boilerplate

        private Dictionary<String, List<String>> errors = new Dictionary<string, List<string>>();

        public bool HasErrors => errors.Count > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (String.IsNullOrEmpty(propertyName) || !errors.ContainsKey(propertyName)) return null;
            return errors[propertyName];
        }

        private void RaiseErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        // Removes the specified error from the errors collection if it is
        // present. Raises the ErrorsChanged event if the collection changes.
        private void RemoveError(string propertyName, string error)
        {
            if (errors.ContainsKey(propertyName) &&
                errors[propertyName].Contains(error))
            {
                errors[propertyName].Remove(error);
                if (errors[propertyName].Count == 0) errors.Remove(propertyName);
                RaiseErrorsChanged(propertyName);
            }
        }

        // Adds the specified error to the errors collection if it is not
        // already present, inserting it in the first position if isWarning is
        // false. Raises the ErrorsChanged event if the collection changes.
        private void AddError(string propertyName, string error, bool isWarning)
        {
            if (!errors.ContainsKey(propertyName))
                errors[propertyName] = new List<string>();

            if (!errors[propertyName].Contains(error))
            {
                if (isWarning) errors[propertyName].Add(error);
                else errors[propertyName].Insert(0, error);
                RaiseErrorsChanged(propertyName);
            }
        }


        #endregion


        #endregion


    }
}
