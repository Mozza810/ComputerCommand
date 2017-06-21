Public Class Gun
    Private _originPointF As PointF
    Private mouseX, mouseY As Integer
    Private gunRadius As Integer = 50
    Private gunX, gunY As Integer
    Public gunEnd As Point
    Private gunAngle As Double
    Public outputVector As PointF

    Public Sub New(ByVal originPointF As PointF)
        _originPointF = originPointF
    End Sub

    Public Sub GunCalc(ByVal mouseX As Integer, ByVal mouseY As Integer)
        mouseX = mouseX - _originPointF.X
        mouseY = _originPointF.Y - mouseY

        gunAngle = (Math.Atan(mouseY / mouseX))

        If gunAngle > 0 Then
            gunX = (Math.Cos(gunAngle) * gunRadius) + _originPointF.X
            gunY = _originPointF.Y - (Math.Sin(gunAngle) * gunRadius)

            outputVector.X = (Math.Cos(gunAngle) * 1)
            outputVector.Y = (Math.Sin(gunAngle) * 1)
        Else
            gunX = ((Math.Cos(gunAngle) * gunRadius) * -1) + _originPointF.X
            gunY = _originPointF.Y - ((Math.Sin(gunAngle) * gunRadius) * -1)

            outputVector.X = (Math.Cos(gunAngle) * -1)
            outputVector.Y = (Math.Sin(gunAngle) * -1)
        End If

        gunEnd = New Point(gunX, gunY)
    End Sub

    Public Sub DrawGun(ByVal g As Graphics, ByVal font As Font)
        g.DrawLine(Pens.Black, _originPointF, gunEnd)
        g.DrawEllipse(Pens.DarkRed, _originPointF.X - gunRadius, _originPointF.Y - gunRadius, gunRadius * 2, gunRadius * 2)
    End Sub

End Class
