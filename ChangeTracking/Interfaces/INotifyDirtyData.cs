using System;
using System.ComponentModel;

namespace ChangeTracking.Interfaces
{
    /// <summary>
    /// Interface for a data class which implements a smarter dirty flag
    /// </summary>
    public interface INotifyDirtyData
    {
        event PropertyChangedEventHandler DirtyStatusChanged;
        Object GetChangedData(string propertyName);
        void ClearChangedData();
        bool HasChangedData { get; }
    }
}
