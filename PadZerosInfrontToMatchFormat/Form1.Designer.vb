<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxNoDigits = New System.Windows.Forms.TextBox()
        Me.TextBoxPadChar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.ButtonPadNumber = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNoDigits
        '
        Me.TextBoxNoDigits.Location = New System.Drawing.Point(147, 57)
        Me.TextBoxNoDigits.Name = "TextBoxNoDigits"
        Me.TextBoxNoDigits.Size = New System.Drawing.Size(178, 20)
        Me.TextBoxNoDigits.TabIndex = 0
        '
        'TextBoxPadChar
        '
        Me.TextBoxPadChar.Location = New System.Drawing.Point(147, 31)
        Me.TextBoxPadChar.Name = "TextBoxPadChar"
        Me.TextBoxPadChar.Size = New System.Drawing.Size(178, 20)
        Me.TextBoxPadChar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pad Character"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Number of Digits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "The Number to Pad To"
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(147, 86)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(178, 20)
        Me.TextBoxNumber.TabIndex = 6
        '
        'ButtonPadNumber
        '
        Me.ButtonPadNumber.Location = New System.Drawing.Point(250, 112)
        Me.ButtonPadNumber.Name = "ButtonPadNumber"
        Me.ButtonPadNumber.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPadNumber.TabIndex = 7
        Me.ButtonPadNumber.Text = "Pad Number"
        Me.ButtonPadNumber.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 144)
        Me.Controls.Add(Me.ButtonPadNumber)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPadChar)
        Me.Controls.Add(Me.TextBoxNoDigits)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNoDigits As TextBox
    Friend WithEvents TextBoxPadChar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents ButtonPadNumber As Button
End Class
