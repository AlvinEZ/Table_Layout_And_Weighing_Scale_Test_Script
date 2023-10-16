Public Class MouseClass
    Inherits Button

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

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        DoDrag = False
        MyBase.OnMouseUp(mevent)
    End Sub

End Class
