Public Class PersonView
    Private ReadOnly Property _viewModel As Object

    Public Sub New()

        InitializeComponent()
        Me._viewModel = New PersonViewModel
        Me.ViewModelBindingSource.DataSource = _viewModel
        Me.InitializeBindings()
    End Sub


    Private Sub InitializeBindings()
        TextBoxFirstName.DataBindings.Add("Text", ViewModelBindingSource, NameOf(_viewModel.FirstName))
        TextBoxLastName.DataBindings.Add("Text", ViewModelBindingSource, NameOf(_viewModel.Lastname))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If _viewModel.FirstName = "" Then
            _viewModel.FirstName = "Ibrahim"
            _viewModel.Lastname = "Hussain"
            Button1.Text = "Clear"
        Else
            _viewModel.FirstName = ""
            _viewModel.Lastname = ""
            Button1.Text = "Find"
        End If

    End Sub
End Class
