Public Class Bullet

    Public bulletRectangle As RectangleF
    Private missileDir As PointF
    Private speed As Integer = 10
    Private mouseLoc As PointF
    Private missileSize As New Size(10, 35)

    ' Shoot RAM!
    Dim imageRam As New Bitmap(My.Resources.ram)

    Public Enum MissileStates
        Fired
        Hit
        Explode
    End Enum

    Public state As MissileStates = MissileStates.Fired

    Public Sub New(ByVal startPoint As Point, ByVal direction As PointF, ByVal mouseLocation As PointF)
        bulletRectangle = New RectangleF(startPoint, missileSize)
        missileDir = direction
        mouseLoc = mouseLocation
    End Sub

    Public Sub MissileCalcs()
        Select Case state
            ' Missile states.
            Case MissileStates.Fired
                ' Move bullet.
                bulletRectangle.X += missileDir.X * speed
                bulletRectangle.Y -= missileDir.Y * speed

                If bulletRectangle.X > mouseLoc.X - 5 And bulletRectangle.X < mouseLoc.X + 5 Then
                    state = MissileStates.Hit
                End If
            Case MissileStates.Hit
                ' When hit inflate the object for a blast radius.
                bulletRectangle.Inflate(speed, speed)
                If bulletRectangle.Width > 30 Then
                    state = MissileStates.Explode
                End If
            Case MissileStates.Explode
                ' Remove.
                bulletRectangle.X = -100
                bulletRectangle.Y = -100
        End Select
    End Sub

    Public Sub DrawMissile(ByVal graphics As Graphics)
        ' Can use ellipse instead, but ram cooler!
        ' graphics.FillEllipse(Brushes.Red, bulletRectangle)
        graphics.DrawImage(imageRam, bulletRectangle)
    End Sub
End Class
