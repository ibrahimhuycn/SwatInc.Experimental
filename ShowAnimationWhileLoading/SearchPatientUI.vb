Imports System.Threading

Public Class SearchPatientUI
    Private Async Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        'Configure progress bar
        ProgressBarAnimation.Style = ProgressBarStyle.Marquee

        'show loading panel, hide SearchResults panel. note: loading panel is behind
        PanelAnimation.Show()
        PanelSearchResults.Hide()

        'Start the long running process
        ButtonSearch.Enabled = False
        Dim DemoData = Await Task.Run(Function() LoadDataAsync())

        ButtonSearch.Enabled = True
        TextBoxSearchResults.Text = String.Format("Patient Name: {0}{1}Patient Age: {2}  Sex: {3}{1}National Id: ", DemoData.PatientName, vbCrLf, DemoData.Age, DemoData.Sex, DemoData.IDCardNumber)
        ProgressBarAnimation.Style = ProgressBarStyle.Blocks
        ' PanelAnimation.Hide()
        PanelSearchResults.Show()

    End Sub

    Private Async Function LoadDataAsync() As Task(Of PatientDataDemo)
        Thread.Sleep(5000)
        Dim DemoData As PatientDataDemo
        DemoData = New PatientDataDemo With {.PatientName = "FATHIMA BINTH MOHAMED", .Age = 23, .IDCardNumber = "A585365522", .Sex = "Female"}
        Return DemoData

    End Function

End Class