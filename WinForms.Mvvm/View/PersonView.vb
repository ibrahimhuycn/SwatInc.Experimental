Public Class PersonView
    Public Shared Property _viewModel As PersonViewModel

    Public Sub New()

        InitializeComponent()
        PersonView._viewModel = New PersonViewModel
        Me.ViewModelBindingSource.DataSource = PersonView._viewModel
        Me.InitializeBindings()
    End Sub


    Private Sub InitializeBindings()
        TextBoxFirstName.DataBindings.Add("Text", ViewModelBindingSource, NameOf(_viewModel.FirstName))
        TextBoxLastName.DataBindings.Add("Text", ViewModelBindingSource, NameOf(_viewModel.Lastname))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Person.GetPerson("1")
    End Sub
End Class
