Public Class Form1
    Private Sub ButtonPadNumber_Click(sender As Object, e As EventArgs) Handles ButtonPadNumber.Click
        'Int i = 1;
        '    String s = i.ToString().PadLeft(40, '0');

        Dim num As Integer = Me.TextBoxNumber.Text
        Dim TotalDigits As Integer = Me.TextBoxNoDigits.Text
        Dim PadChar As String = Me.TextBoxPadChar.Text

        MsgBox(num.ToString().PadLeft(TotalDigits, PadChar))
    End Sub
End Class
