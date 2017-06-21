<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormScores))
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.DataGridViewScore = New System.Windows.Forms.DataGridView()
        Me.TableScoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HighscoresDataSet = New ComputerCommand.highscoresDataSet()
        Me.TableScoresTableAdapter = New ComputerCommand.highscoresDataSetTableAdapters.TableScoresTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableScoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelTitle.Location = New System.Drawing.Point(-6, -2)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(502, 50)
        Me.LabelTitle.TabIndex = 2
        Me.LabelTitle.Text = "Computer Command"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ComputerCommand.My.Resources.Resources.virus
        Me.PictureBox1.Location = New System.Drawing.Point(361, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 294)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.Honeydew
        Me.ButtonHome.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonHome.Location = New System.Drawing.Point(12, 51)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(49, 25)
        Me.ButtonHome.TabIndex = 7
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'DataGridViewScore
        '
        Me.DataGridViewScore.AllowUserToAddRows = False
        Me.DataGridViewScore.AllowUserToDeleteRows = False
        Me.DataGridViewScore.AutoGenerateColumns = False
        Me.DataGridViewScore.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewScore.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.ScoreDataGridViewTextBoxColumn})
        Me.DataGridViewScore.DataSource = Me.TableScoresBindingSource
        Me.DataGridViewScore.GridColor = System.Drawing.Color.Black
        Me.DataGridViewScore.Location = New System.Drawing.Point(91, 72)
        Me.DataGridViewScore.Name = "DataGridViewScore"
        Me.DataGridViewScore.ReadOnly = True
        Me.DataGridViewScore.Size = New System.Drawing.Size(243, 277)
        Me.DataGridViewScore.TabIndex = 8
        '
        'TableScoresBindingSource
        '
        Me.TableScoresBindingSource.DataMember = "TableScores"
        Me.TableScoresBindingSource.DataSource = Me.HighscoresDataSet
        '
        'HighscoresDataSet
        '
        Me.HighscoresDataSet.DataSetName = "highscoresDataSet"
        Me.HighscoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableScoresTableAdapter
        '
        Me.TableScoresTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MaxInputLength = 3
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 50
        '
        'ScoreDataGridViewTextBoxColumn
        '
        Me.ScoreDataGridViewTextBoxColumn.DataPropertyName = "Score"
        Me.ScoreDataGridViewTextBoxColumn.HeaderText = "Score"
        Me.ScoreDataGridViewTextBoxColumn.Name = "ScoreDataGridViewTextBoxColumn"
        Me.ScoreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(502, 393)
        Me.Controls.Add(Me.DataGridViewScore)
        Me.Controls.Add(Me.ButtonHome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormScores"
        Me.Text = "Computer Command - Level Select"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableScoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonHome As System.Windows.Forms.Button
    Friend WithEvents DataGridViewScore As System.Windows.Forms.DataGridView
    Friend WithEvents HighscoresDataSet As ComputerCommand.highscoresDataSet
    Friend WithEvents TableScoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableScoresTableAdapter As ComputerCommand.highscoresDataSetTableAdapters.TableScoresTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
