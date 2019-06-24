<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPatientUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxSearchResults = New System.Windows.Forms.TextBox()
        Me.LabelSearchResults = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ProgressBarAnimation = New System.Windows.Forms.ProgressBar()
        Me.PanelAnimation = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSearchResults = New System.Windows.Forms.Panel()
        Me.PanelAnimation.SuspendLayout()
        Me.PanelSearchResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxSearchResults
        '
        Me.TextBoxSearchResults.Location = New System.Drawing.Point(3, 21)
        Me.TextBoxSearchResults.Multiline = True
        Me.TextBoxSearchResults.Name = "TextBoxSearchResults"
        Me.TextBoxSearchResults.Size = New System.Drawing.Size(375, 143)
        Me.TextBoxSearchResults.TabIndex = 0
        '
        'LabelSearchResults
        '
        Me.LabelSearchResults.AutoSize = True
        Me.LabelSearchResults.Location = New System.Drawing.Point(3, 5)
        Me.LabelSearchResults.Name = "LabelSearchResults"
        Me.LabelSearchResults.Size = New System.Drawing.Size(79, 13)
        Me.LabelSearchResults.TabIndex = 1
        Me.LabelSearchResults.Text = "Search Results"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(303, 171)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 2
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ProgressBarAnimation
        '
        Me.ProgressBarAnimation.Location = New System.Drawing.Point(3, 4)
        Me.ProgressBarAnimation.MarqueeAnimationSpeed = 10
        Me.ProgressBarAnimation.Name = "ProgressBarAnimation"
        Me.ProgressBarAnimation.Size = New System.Drawing.Size(194, 10)
        Me.ProgressBarAnimation.Step = 5
        Me.ProgressBarAnimation.TabIndex = 3
        '
        'PanelAnimation
        '
        Me.PanelAnimation.Controls.Add(Me.Label2)
        Me.PanelAnimation.Controls.Add(Me.Label1)
        Me.PanelAnimation.Controls.Add(Me.ProgressBarAnimation)
        Me.PanelAnimation.Location = New System.Drawing.Point(89, 64)
        Me.PanelAnimation.Name = "PanelAnimation"
        Me.PanelAnimation.Size = New System.Drawing.Size(200, 58)
        Me.PanelAnimation.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please wait..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Searching for Data"
        '
        'PanelSearchResults
        '
        Me.PanelSearchResults.Controls.Add(Me.TextBoxSearchResults)
        Me.PanelSearchResults.Controls.Add(Me.LabelSearchResults)
        Me.PanelSearchResults.Location = New System.Drawing.Point(1, 2)
        Me.PanelSearchResults.Name = "PanelSearchResults"
        Me.PanelSearchResults.Size = New System.Drawing.Size(380, 168)
        Me.PanelSearchResults.TabIndex = 5
        '
        'SearchPatientUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 193)
        Me.Controls.Add(Me.PanelSearchResults)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.PanelAnimation)
        Me.MaximizeBox = False
        Me.Name = "SearchPatientUI"
        Me.Text = "Patient Search"
        Me.PanelAnimation.ResumeLayout(False)
        Me.PanelAnimation.PerformLayout()
        Me.PanelSearchResults.ResumeLayout(False)
        Me.PanelSearchResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxSearchResults As TextBox
    Friend WithEvents LabelSearchResults As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ProgressBarAnimation As ProgressBar
    Friend WithEvents PanelAnimation As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelSearchResults As Panel
End Class
