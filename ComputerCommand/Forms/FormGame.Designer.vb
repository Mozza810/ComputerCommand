<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGame))
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelLevel = New System.Windows.Forms.Label()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.ButtonMute = New System.Windows.Forms.Button()
        Me.PanelGameView = New System.Windows.Forms.Panel()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(261, 9)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(65, 13)
        Me.LabelScore.TabIndex = 0
        Me.LabelScore.Text = "Score: 0000"
        '
        'LabelLevel
        '
        Me.LabelLevel.AutoSize = True
        Me.LabelLevel.Location = New System.Drawing.Point(214, 9)
        Me.LabelLevel.Name = "LabelLevel"
        Me.LabelLevel.Size = New System.Drawing.Size(45, 13)
        Me.LabelLevel.TabIndex = 1
        Me.LabelLevel.Text = "Level: 0"
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonHome.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonHome.Location = New System.Drawing.Point(360, 4)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(72, 23)
        Me.ButtonHome.TabIndex = 5
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'ButtonMute
        '
        Me.ButtonMute.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonMute.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMute.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonMute.Location = New System.Drawing.Point(516, 4)
        Me.ButtonMute.Name = "ButtonMute"
        Me.ButtonMute.Size = New System.Drawing.Size(72, 23)
        Me.ButtonMute.TabIndex = 6
        Me.ButtonMute.Text = "Unmute"
        Me.ButtonMute.UseVisualStyleBackColor = False
        '
        'PanelGameView
        '
        Me.PanelGameView.BackColor = System.Drawing.Color.White
        Me.PanelGameView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGameView.Location = New System.Drawing.Point(12, 33)
        Me.PanelGameView.Name = "PanelGameView"
        Me.PanelGameView.Size = New System.Drawing.Size(570, 428)
        Me.PanelGameView.TabIndex = 7
        '
        'ButtonPause
        '
        Me.ButtonPause.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonPause.Enabled = False
        Me.ButtonPause.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonPause.Location = New System.Drawing.Point(438, 4)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(72, 23)
        Me.ButtonPause.TabIndex = 9
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = False
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelTitle.Location = New System.Drawing.Point(1, 6)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(201, 20)
        Me.LabelTitle.TabIndex = 10
        Me.LabelTitle.Text = "Computer Command"
        '
        'Timer1
        '
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 471)
        Me.Controls.Add(Me.LabelLevel)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.PanelGameView)
        Me.Controls.Add(Me.ButtonMute)
        Me.Controls.Add(Me.ButtonHome)
        Me.Controls.Add(Me.LabelScore)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormGame"
        Me.Text = "Computer Command"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelScore As System.Windows.Forms.Label
    Friend WithEvents LabelLevel As System.Windows.Forms.Label
    Friend WithEvents ButtonHome As System.Windows.Forms.Button
    Friend WithEvents ButtonMute As System.Windows.Forms.Button
    Friend WithEvents PanelGameView As System.Windows.Forms.Panel
    Friend WithEvents ButtonPause As System.Windows.Forms.Button
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
