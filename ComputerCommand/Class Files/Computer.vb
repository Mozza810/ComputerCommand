Imports System.Drawing.Drawing2D

Public Class Computer

    Private floor As Rectangle
    Public computers As New List(Of RectangleF)
    Private block As Integer
    Private computerWidth As Integer = 68
    Private computerHeight As Integer = 42
    Private computerGap As Double
    Public computerTopLevel As Integer
    Private screenWidth As Integer = 570
    Private screenHeight As Integer = 428
    Private virusQueue As New Queue(Of Virus)

    Dim image As New Bitmap(My.Resources.Computer)

    Dim locationsX() As Integer = {8, 85, 160, 349, 422, 492}

    Public Sub New()
        block = screenWidth / 10
        computerGap = (computerWidth / 6)
        computerTopLevel = screenHeight - 20 - computerHeight

        ' Add the computers at locationx at c in index array.
        For c As Integer = 0 To 5
            computers.Add(New RectangleF(locationsX(c), computerTopLevel, computerWidth, computerHeight))
        Next

        ' Create a floor rect.
        floor = New Rectangle(0, computerTopLevel + computerHeight, screenWidth, 20)
    End Sub

    Public Sub DrawComputers(ByVal pict As PictureBox, ByVal graphics As Graphics)
        ' For every rectF in comp then draw image.
        For Each c As RectangleF In computers
            graphics.DrawImage(image, c)
        Next
        ' draw the floor.
        graphics.FillRectangle(Brushes.BurlyWood, floor)
    End Sub

    Public Sub UpdateComputers(ByVal virusQ As Queue(Of Virus))
        ' Pass to member var for usage elsewhere.
        virusQueue = virusQ

        ' For every virus in queue, remove computer.
        For Each vi As Virus In virusQueue
            computers.ToList.ForEach(AddressOf DeleteComputer)
        Next
    End Sub

    Private Sub DeleteComputer(ByVal r As RectangleF)
        For Each vq As Virus In virusQueue
            If vq.virusR.IntersectsWith(r) Then
                ' Remove computer at point of intersection with the virus.
                computers.Remove(r)
            End If
        Next
    End Sub
End Class
