Public Class DemoICommandView

    Private _cmd As DemoDataLoadCommand
    Private _viewModel As ViewModelBase

    Public Sub New()
        InitializeComponent()
        InitializeBindingComponents()
        ListenForEvents()
    End Sub

    Private Sub InitializeBindingComponents()
        _viewModel = New ViewModelBase
        _cmd = New DemoDataLoadCommand(_viewModel)
    End Sub

    Private Sub ButtonICommandLoadData_Click(sender As Object, e As EventArgs) Handles ButtonICommandLoadData.Click
        _cmd.Execute(TextBoxInput.Text)
    End Sub
    Private Sub CatchExecutedEvent(ByVal message As String)
        MsgBox(message)
    End Sub
    Private Sub ListenForEvents()
        AddHandler _viewModel.Executed, AddressOf CatchExecutedEvent
    End Sub
End Class
