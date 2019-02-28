Imports System.ComponentModel

Public Class PersonViewModel
    Implements INotifyPropertyChanged

    Private Property _model As Person
    Overridable Property NationalIdCardNumber As String
        Get
            Return _model.NationalIdCardNumber
        End Get
        Set
            If _model.NationalIdCardNumber Is Value Then
                Return
            End If
            _model.NationalIdCardNumber = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(NationalIdCardNumber)))
        End Set
    End Property

    Overridable Property FirstName As String
        Get
            Return _model.FirstName
        End Get
        Set
            If _model.FirstName Is Value Then
                Return
            End If
            _model.FirstName = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(FirstName)))
        End Set
    End Property

    Overridable Property Lastname As String
        Get
            Return _model.Lastname
        End Get
        Set
            If _model.Lastname Is Value Then
                Return
            End If
            _model.Lastname = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Lastname)))
        End Set
    End Property

    Overridable Property Address As Address
        Get
            Return _model.Address
        End Get
        Set
            If _model.Address Is Value Then
                Return
            End If
            _model.Address = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Address)))
        End Set
    End Property

    Overridable Property ContactDetails As Contact
        Get
            Return _model.ContactDetails
        End Get
        Set
            If _model.ContactDetails Is Value Then
                Return
            End If
            _model.ContactDetails = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(ContactDetails)))
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
