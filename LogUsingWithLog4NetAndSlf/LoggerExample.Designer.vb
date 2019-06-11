<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoggerExample
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
        Me.ButtonThrowEx = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonThrowEx
        '
        Me.ButtonThrowEx.Location = New System.Drawing.Point(117, 33)
        Me.ButtonThrowEx.Name = "ButtonThrowEx"
        Me.ButtonThrowEx.Size = New System.Drawing.Size(104, 23)
        Me.ButtonThrowEx.TabIndex = 0
        Me.ButtonThrowEx.Text = "Throw Ex"
        Me.ButtonThrowEx.UseVisualStyleBackColor = True
        '
        'LoggerExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 83)
        Me.Controls.Add(Me.ButtonThrowEx)
        Me.Name = "LoggerExample"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonThrowEx As Button
End Class
