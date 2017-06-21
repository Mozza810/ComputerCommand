<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnterScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEnterScore))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelYourScore = New System.Windows.Forms.Label()
        Me.TextBoxScore = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter 3 Char name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(13, 28)
        Me.TextBoxName.MaxLength = 3
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxName.TabIndex = 1
        '
        'LabelYourScore
        '
        Me.LabelYourScore.AutoSize = True
        Me.LabelYourScore.Location = New System.Drawing.Point(10, 60)
        Me.LabelYourScore.Name = "LabelYourScore"
        Me.LabelYourScore.Size = New System.Drawing.Size(83, 13)
        Me.LabelYourScore.TabIndex = 2
        Me.LabelYourScore.Text = "Your score was:"
        '
        'TextBoxScore
        '
        Me.TextBoxScore.Enabled = False
        Me.TextBoxScore.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxScore.Location = New System.Drawing.Point(13, 76)
        Me.TextBoxScore.Name = "TextBoxScore"
        Me.TextBoxScore.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxScore.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(119, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 70)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormEnterScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(212, 110)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxScore)
        Me.Controls.Add(Me.LabelYourScore)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormEnterScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Score!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents LabelYourScore As System.Windows.Forms.Label
    Friend WithEvents TextBoxScore As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
