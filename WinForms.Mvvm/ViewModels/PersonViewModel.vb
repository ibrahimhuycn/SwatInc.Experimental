Imports System.ComponentModel

Public Class PersonViewModel
    Implements INotifyPropertyChanged
    Public Overridable Property NationalIdCardNumber As String
    Public Overridable Property FirstName As String
    Public Overridable Property Lastname As String
    Public Overridable Property Address As Address
    Public Overridable Property ContactDetails As Contact
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
