Imports System.Windows.Input

Public Class DemoDataLoadCommand
    Implements ICommand

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Private Property _viewModel As ViewModelBase
    Public Sub New(viewModel As ViewModelBase)
        Me._viewModel = viewModel
    End Sub

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        Dim message As String = parameter
        Me._viewModel.DemoMethod(message)
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
