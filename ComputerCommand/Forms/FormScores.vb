Imports System.Data.OleDb

Public Class FormScores
    ' Connection string.
    Public Access2010string As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = highscores.accdb"

    ' Set up connection.
    Dim dbConnect As New OleDbConnection(Access2010string)
    Dim dbAdapter As New OleDbDataAdapter
    Dim ScoresDS As New DataSet

    Private Sub ButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHome.Click
        ' Open the home menu.
        Me.Visible = False
        Dim homeForm As New FormMenu
        homeForm.ShowDialog()
    End Sub

    Private Sub FormScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' load database.
        LoadData()
    End Sub

    Public Sub LoadData()
        ' Empty old data.
        ScoresDS.Clear()
        ' Query.
        Dim SQLquery As String = "SELECT * FROM TableScores"
        ' Send sql to database identified by connect string.
        dbAdapter = New OleDbDataAdapter(SQLquery, Access2010string)

        ' command builder edited data to be saved to database.
        Dim dbCmdBuild As New OleDbCommandBuilder(dbAdapter)
        ' load records returned by query to be saved.
        dbAdapter.FillSchema(ScoresDS, SchemaType.Source, "TableScores")
        dbAdapter.Fill(ScoresDS, "TableScores")
        ' Display into grid.
        DataGridViewScore.DataSource = ScoresDS
        DataGridViewScore.DataMember = "TableScores"
    End Sub

End Class