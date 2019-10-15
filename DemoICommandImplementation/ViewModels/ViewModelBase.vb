Public Class ViewModelBase
    Public Sub New()

    End Sub
    Public Event Executed(message As String)

    Public Sub DemoMethod(message As String)
        Debug.WriteLine(message)
        RaiseEvent Executed(message)
    End Sub
End Class
