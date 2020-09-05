using System;
using System.ComponentModel;

namespace SwitchDataGridDatasource
{
        public class SwapViewModel : INotifyPropertyChanged
        {
            private ActiveDatasource _activeSource;

            public SwapViewModel()
            {
                Results = new BindingList<ResultsModel>();
                AuditTrail = new BindingList<AuditTrail>();
                GenerateDemoData();
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void GenerateDemoData()
            {
                //results
                var result1 = new ResultsModel() { Test = "Hb", Result = "12.4" };
                var result2 = new ResultsModel() { Test = "HCT", Result = "35.7" };
                Results.Add(result1);
                Results.Add(result2);

                //audit trail
                var trail1 = new AuditTrail() { EventTime = DateTimeOffset.Now, Details = "Hb registered" };
                var trail2 = new AuditTrail() { EventTime = DateTimeOffset.Now, Details = "Hb result: 12.4" };
                var trail3 = new AuditTrail() { EventTime = DateTimeOffset.Now, Details = "HCT registered" };
                var trail4 = new AuditTrail() { EventTime = DateTimeOffset.Now, Details = "HCT result: 35.7" };

                AuditTrail.Add(trail1);
                AuditTrail.Add(trail2);
                AuditTrail.Add(trail3);
                AuditTrail.Add(trail4);
            }

            public BindingList<ResultsModel> Results { get; set; }
            public BindingList<AuditTrail> AuditTrail { get; set; }
            public ActiveDatasource ActiveSource
            {
                get => _activeSource; set
                {
                    if (_activeSource == value) return;
                    _activeSource = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActiveSource)));
                }
            }

            public enum ActiveDatasource
            {
                Result,
                Audit
            }
        }
    }
