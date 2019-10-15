<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemoICommandView
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
        Me.ButtonICommandLoadData = New System.Windows.Forms.Button()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonICommandLoadData
        '
        Me.ButtonICommandLoadData.Location = New System.Drawing.Point(144, 48)
        Me.ButtonICommandLoadData.Name = "ButtonICommandLoadData"
        Me.ButtonICommandLoadData.Size = New System.Drawing.Size(126, 23)
        Me.ButtonICommandLoadData.TabIndex = 0
        Me.ButtonICommandLoadData.Text = "ICommand Load Data"
        Me.ButtonICommandLoadData.UseVisualStyleBackColor = True
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Location = New System.Drawing.Point(12, 22)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(258, 20)
        Me.TextBoxInput.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Loded Data"
        '
        'DemoICommandView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 80)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Controls.Add(Me.ButtonICommandLoadData)
        Me.Name = "DemoICommandView"
        Me.Text = "Demo ICommand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonICommandLoadData As Button
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents Label3 As Label
End Class
