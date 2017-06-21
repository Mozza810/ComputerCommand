Public Class FormMenu

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonHelp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonHelp.MouseEnter
        ButtonHelp.Location = New Point(ButtonHelp.Location.X + 40, ButtonHelp.Location.Y)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub ButtonPlay_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonPlay.MouseEnter
        ButtonPlay.Location = New Point(ButtonPlay.Location.X + 40, ButtonPlay.Location.Y)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub ButtonScores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonScores.MouseEnter
        ButtonScores.Location = New Point(ButtonScores.Location.X + 40, ButtonScores.Location.Y)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub ButtonHelp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonHelp.MouseLeave
        ButtonHelp.Location = New Point(ButtonHelp.Location.X - 40, ButtonHelp.Location.Y)
    End Sub

    Private Sub ButtonPlay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonPlay.MouseLeave
        ButtonPlay.Location = New Point(ButtonPlay.Location.X - 40, ButtonPlay.Location.Y)
    End Sub

    Private Sub ButtonScores_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonScores.MouseLeave
        ButtonScores.Location = New Point(ButtonScores.Location.X - 40, ButtonScores.Location.Y)
    End Sub

    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click

        ' Close the main menu so the game form can be opened.
        Me.Visible = False
        Dim gameForm As New FormGame
        gameForm.ShowDialog()

    End Sub

    Private Sub ButtonScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonScores.Click
        ' Close the main menu so the game form can be opened.
        Me.Visible = False
        Dim levelForm As New FormScores
        levelForm.ShowDialog()

    End Sub

    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click

        ' Close the main menu so the game form can be opened.
        Me.Visible = False
        Dim helpForm As New FormHelp
        helpForm.ShowDialog()

    End Sub
End Class
