<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.PictureBoxBackground = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelTitle.Location = New System.Drawing.Point(1, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(502, 50)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Computer Command"
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonPlay.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlay.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonPlay.Location = New System.Drawing.Point(148, 93)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(213, 60)
        Me.ButtonPlay.TabIndex = 2
        Me.ButtonPlay.Text = "Play Computer Command"
        Me.ButtonPlay.UseVisualStyleBackColor = False
        '
        'ButtonScores
        '
        Me.ButtonScores.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonScores.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScores.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonScores.Location = New System.Drawing.Point(148, 173)
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.Size = New System.Drawing.Size(213, 60)
        Me.ButtonScores.TabIndex = 3
        Me.ButtonScores.Text = "High Scores"
        Me.ButtonScores.UseVisualStyleBackColor = False
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonHelp.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHelp.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonHelp.Location = New System.Drawing.Point(148, 253)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(213, 60)
        Me.ButtonHelp.TabIndex = 4
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = False
        '
        'PictureBoxBackground
        '
        Me.PictureBoxBackground.Image = Global.ComputerCommand.My.Resources.Resources.computermenu
        Me.PictureBoxBackground.Location = New System.Drawing.Point(-89, 39)
        Me.PictureBoxBackground.Name = "PictureBoxBackground"
        Me.PictureBoxBackground.Size = New System.Drawing.Size(732, 536)
        Me.PictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxBackground.TabIndex = 0
        Me.PictureBoxBackground.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 405)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxBackground)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Command V.1"
        CType(Me.PictureBoxBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxBackground As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ButtonScores As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button

End Class
