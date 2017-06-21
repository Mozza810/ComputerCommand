Public Class Virus

    Private targetComputer As Integer

    Private speed As Integer = 3

    ' Random number.
    Dim myRand As New Random

    ' Computers and viruses.
    Private myComputers As Computer
    Public virusR As RectangleF
    Dim imageVirus As New Bitmap(My.Resources.virus)

    ' Start and end point of viruses, and their direction.
    Dim startPoint, endPoint As Point
    Dim enemyDir As PointF
    Dim virusSize As New Size(29, 24)

    ' Loc of computers, virus init points at x.
    Dim locationsX() As Integer = {8, 85, 160, 349, 422, 492}

    Public Sub New(ByVal computer As Computer)

        ' Enemy angle at which they will move.
        Dim enemyAngle As Double
        Dim startLocInt As Integer

        Randomize()

        ' Start at top, random x along width of screen.
        startPoint.Y = 0

        ' Choose true rand start loc 
        startLocInt = myRand.Next(2, 428)
        startPoint.X = startLocInt

        ' Get passed in value, and give Computer member a value.
        myComputers = computer

        ' Choose a computer to aim for.
        targetComputer = Int(Rnd() * myComputers.computers.Count)

        If myComputers.computers.Count > 0 Then
            ' Aim for middle of the target computer (+34)
            endPoint.Y = myComputers.computerTopLevel + 20
            endPoint.X = (computer.computers(targetComputer).X) + 34

            ' Work out the angle.
            enemyAngle = Math.Atan((endPoint.Y - startPoint.Y) / (endPoint.X - startPoint.X))

            ' Work out enemy movement.
            If enemyAngle > 0 Then
                enemyDir.X = Math.Cos(enemyAngle)
                enemyDir.Y = Math.Sin(enemyAngle)
            Else
                enemyDir.X = Math.Cos(enemyAngle) * -1
                enemyDir.Y = Math.Sin(enemyAngle) * -1
            End If

            ' virus size and start point as new rect.
            virusR = New RectangleF(startPoint, virusSize)
        End If
    End Sub

    Public Sub UpdateVirus(ByVal bullets As Queue(Of Bullet), ByVal newSpeed As Integer)
        ' Update virus mov.
        If newSpeed < 1 Then
            virusR.X += enemyDir.X * speed
            virusR.Y += enemyDir.Y * speed
        Else
            virusR.X += enemyDir.X * newSpeed
            virusR.Y += enemyDir.Y * newSpeed
        End If

        For Each b As Bullet In bullets
            ' If any bullets and virus intersect.
            If virusR.IntersectsWith(b.bulletRectangle) Then
                ' Remove.
                virusR.X = -100
                virusR.Y = -100
            End If
        Next

        If virusR.X < 0 Or virusR.Y > myComputers.computerTopLevel + 20 Then
            virusR.X = -100
            virusR.Y = -100
        End If
    End Sub

    Public Property SpeedWork() As Integer
        Get
            Return speed
        End Get
        Set(ByVal value As Integer)
            speed = value
        End Set
    End Property

    Public Sub DrawVirus(ByVal graphics As Graphics)
        ' Draw the enemy/virus!!
        graphics.DrawImage(imageVirus, virusR)
    End Sub

End Class
