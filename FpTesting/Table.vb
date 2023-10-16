Public Class Table
    Private DoDrag As Boolean = False
    Private PosX, PosY As Integer

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        DoDrag = True
        PosX = mevent.X
        PosY = mevent.Y
        MyBase.OnMouseDown(mevent)
    End Sub

    Protected Overrides Sub OnMouseMove(mevent As MouseEventArgs)
        If DoDrag = True Then
            Location = New Point(Location.X + mevent.X - PosX, Location.Y + mevent.Y - PosY)
        End If
        MyBase.OnMouseMove(mevent)
    End Sub

    Private Sub Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        DoDrag = False
        MyBase.OnMouseUp(mevent)
    End Sub

    'PictureBox
    Private Sub picturebox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        DoDrag = True
        PosX = e.X
        PosY = e.Y
    End Sub

    Private Sub picturebox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If DoDrag = True Then
            Location = New Point(Location.X + e.X - PosX, Location.Y + e.Y - PosY)
        End If
    End Sub

    Private Sub picturebox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        DoDrag = False
    End Sub

    'TableNumber
    Private Sub TableNumber_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTableNumber.MouseDown
        DoDrag = True
        PosX = e.X
        PosY = e.Y
    End Sub

    Private Sub TableNumber_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTableNumber.MouseMove
        If DoDrag = True Then
            Location = New Point(Location.X + e.X - PosX, Location.Y + e.Y - PosY)
        End If
    End Sub

    Private Sub TableNumber_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTableNumber.MouseUp
        DoDrag = False
    End Sub
End Class
