Public Class FormHelp

    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click
        ' Open the home menu.
        Me.Visible = False
        Dim homeForm As New FormMenu
        homeForm.ShowDialog()
    End Sub

    Private Sub FormHelp_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        FormMenu.Visible = True
    End Sub
End Class