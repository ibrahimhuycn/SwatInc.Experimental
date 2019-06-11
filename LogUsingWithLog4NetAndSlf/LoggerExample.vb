
Imports slf4net

<Assembly: log4net.Config.XmlConfigurator(Watch:=True)>
Public Class LoggerExample

    Private Shared ReadOnly _logger As ILogger = LoggerFactory.GetLogger(GetType(LoggerExample))

    Public Sub Foo()
        _logger.Trace("Foo started at {0}.", Date.Now)

        ' Do some work

        _logger.Trace("Foo() completed at {0}.", Date.Now)
    End Sub

    Private Sub ButtonThrowEx_Click(sender As Object, e As EventArgs) Handles ButtonThrowEx.Click
        Try
            Throw New NotImplementedException
        Catch ex As Exception
            _logger.Error(ex.Message)
        End Try
    End Sub
End Class
