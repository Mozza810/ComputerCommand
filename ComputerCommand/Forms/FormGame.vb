Public Class FormGame

    ' Set audio to true as plays from start, also pause status.
    Public audioStatus, pauseStatus As Boolean
    Public media As New Media.SoundPlayer(My.Resources.rush)
    ' Set level, targetCompt speed and score.
    Dim level, targetComputer, speed As Integer
    Public score As Integer
    ' Button for the game start.
    Dim buttonStartGame, buttonRestartGame As New Button
    ' Label for the game over.
    Dim labelGameOver As New Label
    ' Create new stopwatch to count time.
    Dim stopwatch As New Stopwatch

    ' graphics and picturebox
    Dim graphics As Graphics
    Dim pict As PictureBox

    Dim info As FormEnterScore

    Dim myGun As Gun

    Dim bulletQueue As New Queue(Of Bullet)
    Dim virusQueue As New Queue(Of Virus)

    Dim myOriginPoint As Point

    Dim bullet As Bullet

    Dim myComputers As Computer
    Dim myVirus As Virus

    Dim bitmap As Bitmap
    Dim bitmapGraphicsDraw As Graphics

    Private Sub FormGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Music is not muted and game is not paused, set status to false at init.
        pauseStatus = False
        audioStatus = False

        level = 1

        Timer1.Interval = 1000 / 60

        ' Create graphics.
        graphics = PanelGameView.CreateGraphics

        ' Gun values.
        myOriginPoint = New Point(PanelGameView.Width / 2, PanelGameView.Height)
        myGun = New Gun(myOriginPoint)
        bitmap = New Bitmap(PanelGameView.Width, PanelGameView.Height)

        ' Init comp.
        myComputers = New Computer()
        myVirus = New Virus(myComputers)

        ' Queue of enemies, pass in computers.
        For i As Integer = 0 To 6
            virusQueue.Enqueue(New Virus(myComputers))
        Next
    End Sub


    Private Sub ButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHome.Click
        ' Open the home menu.
        Me.Visible = False
        Dim homeForm As New FormMenu
        homeForm.ShowDialog()
    End Sub

    Private Sub mute()
        ' Stop music and game sound.
        media.Stop()
    End Sub

    Private Sub unmute()
        ' Play music.
        media.PlayLooping()
    End Sub

    Private Sub ButtonMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMute.Click
        ' If music is playing then make mutable, if not then make unmutable.
        If (audioStatus = True) Then
            mute()
            audioStatus = False
            ButtonMute.Text = "Unmute"
        Else
            unmute()
            audioStatus = True
            ButtonMute.Text = "Mute"
        End If
    End Sub

    Private Sub FormGame_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Mute the music and show menu when this game is closed.
        mute()
        FormMenu.Visible = True
    End Sub

    Private Sub PanelGameView_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelGameView.MouseClick
        If pauseStatus = True Then
            MessageBox.Show("game is paused!!!")
        Else
            ' Check level!
            If level = 1 Or level = 2 Or level = 3 Then
                ' SHoot!
                bulletQueue.Enqueue(New Bullet(myGun.gunEnd, myGun.outputVector, e.Location))
                If (audioStatus = True) Then
                    ' Add missile sound if music is not wanted?
                    ' My.Computer.Audio.Play(My.Resources.missile, AudioPlayMode.Background)
                End If
            End If
        End If
    End Sub

    Private Sub PanelGameView_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelGameView.MouseMove
        myGun.GunCalc(e.X, e.Y)
    End Sub

    Private Sub PanelGameView_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelGameView.Paint
        ' Make a dynamic button that can trigger the start of the game.
        With buttonStartGame
            .Size = New Size(150, 40)
            .Text = "Start Game!"
            .Location = New Point(205, 173)
            .BackColor = Color.White
            .ForeColor = Color.DarkGreen
            .Font = New Drawing.Font("OCR A extended", "10")
        End With
        AddHandler buttonStartGame.Click, AddressOf StartGame
        ' Add the button and bring to the front.
        Me.Controls.Add(buttonStartGame)
        buttonStartGame.BringToFront()
    End Sub

    Private Sub StartGame()

        ' Get rid of buttons.
        buttonStartGame.Visible = False
        buttonStartGame.Enabled = False

        ' Enable the pause button as the timer will start on game choice.
        ButtonPause.Enabled = True

        ' Level is 1.
        LabelLevel.Text = "Level: 1"

        ' Start timer and stopwatch.
        Timer1.Start()
        stopwatch.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' Clear, replace color white back every time, ensures mouse movement draw lines don't stay.
        graphics.Clear(Color.White)

        ' Draw gun/base.
        myGun.DrawGun(graphics, PanelGameView.Font)

        ' Draw the computers, pass in pict and graphics.
        myComputers.DrawComputers(pict, graphics)

        ' Check bullet count is over 1.
        If bulletQueue.Count > 0 Then
            For Each b As Bullet In bulletQueue
                b.MissileCalcs()
                b.DrawMissile(graphics)
            Next
            ' Deqeue if it is less than one.
            If bulletQueue.Peek.bulletRectangle.Y < 0 Then bulletQueue.Dequeue()
        End If

        myComputers.UpdateComputers(virusQueue)

        If virusQueue.Count > 0 Then
            For Each vi As Virus In virusQueue
                vi.UpdateVirus(bulletQueue, speed)
                vi.DrawVirus(graphics)
            Next
            If virusQueue.Peek.virusR.X < 0 Then virusQueue.Dequeue()
        Else
            For i As Integer = 1 To 10
                virusQueue.Enqueue(New Virus(myComputers))
            Next
        End If

        If myComputers.computers.Count = 0 Then
            GameOver()
        End If

        ' Check if a change of speed is needed!
        TimeCheck()

        ' Store user score then add to label and conv to string.
        score = stopwatch.ElapsedMilliseconds
        LabelScore.Text = "Score: " + score.ToString

        ' Back buffer, fixes glitch on screen and stops graphics bug when close.
        graphics = graphics.FromImage(bitmap)
        bitmapGraphicsDraw = PanelGameView.CreateGraphics
        bitmapGraphicsDraw.DrawImage(bitmap, 0, 0)
    End Sub

    Private Sub TimeCheck()

        ' Levels are introduced here.
        If stopwatch.ElapsedMilliseconds > 10000 And level = 1 Then
            ' Move to level two.
            speed = (myVirus.SpeedWork * 2)
            level = 2
            LabelLevel.Text = "Level: " + level.ToString
        ElseIf stopwatch.ElapsedMilliseconds = 25000 And level = 2 Then
            ' Move to level three.
            speed = (myVirus.SpeedWork * 4)
            level = 3
            LabelLevel.Text = "Level: " + level.ToString
        ElseIf stopwatch.ElapsedMilliseconds = 50000 And level = 3 Then
            ' Set level 4, move to gameover, then they win.
            level = 4
            GameOver()
            LabelLevel.Text = "Game Won!"
        End If
    End Sub


    Private Sub ButtonPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPause.Click
        If pauseStatus = True Then
            Timer1.Start()
            pauseStatus = False
            ButtonPause.Text = "Pause"
        Else
            Timer1.Stop()
            pauseStatus = True
            ButtonPause.Text = "Play"
        End If
    End Sub

    Private Sub GameOver()
        ' Stop game timers as it has ended.
        Timer1.Stop()
        stopwatch.Stop()

        If level = 4 Then
            info = New FormEnterScore
            ' They have won and also can enter score.
            MessageBox.Show("GAME WON!")
            ' Open enter high score form.
            info.TextBoxScore.Text = score.ToString
            info.Visible = True
            ' Close old.
            Me.Visible = False
        Else
            info = New FormEnterScore
            ' Open enter high score form.
            info.Visible = True
            info.TextBoxScore.Text = score.ToString
            ' CLose old.
            Me.Visible = False
        End If
    End Sub

End Class