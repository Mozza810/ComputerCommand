
Imports System.Data.OleDb

Public Class FormEnterScore

    Dim newScore As Integer

    ' Form used when game ends for user to type in details to put into database.
    Private Sub FormEnterScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBoxScore.Text.Length < 1 Or TextBoxName.Text.Length <> 3) Then
            MessageBox.Show("Error with entry...")
        Else
            Dim usrName As String = TextBoxName.Text
            Dim newScoreDb As Integer = TextBoxScore.Text

            Dim SQLinsert As String = "INSERT INTO TableScores( Name, Score)" & _
                " Values ( '" & usrName.ToString & "', '" & newScoreDb.ToString & "') "

            Dim dbConnection As New OleDbConnection(FormScores.Access2010string)
            ' open connection.
            dbConnection.Open()
            Dim dbCommand As New OleDbCommand(SQLinsert, dbConnection)
            dbCommand.ExecuteNonQuery()
            SQLinsert = Nothing

            FormScores.LoadData()

            dbConnection.Close()

            ' Open score form and close enter score.
            FormScores.Visible = True
            Me.Close()
        End If
    End Sub

End Class