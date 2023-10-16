Public Class Form1

    Dim button As Integer = 1
    Dim textbox As Integer = 1
    Dim DoDrag As Boolean
    Dim X, Y As Integer

    'https://help.aronium.com/hc/en-us/articles/360000183771-Floor-plans
    'https://resto-support.lightspeedhq.com/hc/en-us/articles/226405368-Editing-floor-plans-in-Restaurant-POS
    'https://www.youtube.com/watch?v=Wpw5xx1YTB8

    'FloorID (Combo Box let user to select which floor)
    'TableNumber (txtName)
    'Long table or short table select?
    'Save table location(X,Y)
    'Save btn

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function addtextbox() As System.Windows.Forms.TextBox
        Dim txt As TextBox = New TextBox()
        Panel1.Controls.Add(txt)
        txt.Top = textbox * 30
        txt.Left = 100
        txt.Text = "TextBox" & Me.textbox.ToString()
        textbox = textbox + 1
        Return txt
    End Function

    Private Function addtable() As Table
        'Dim txt As LongTable = New LongTable()
        'Panel1.Controls.Add(txt)

        Dim txt As Table = New Table()
        Panel1.Controls.Add(txt)
        'AddHandler txt.Click, AddressOf HelloIsMe

        'txt.Top = textbox * 30
        'txt.Left = 100
        'txt.Text = "TextBox" & Me.textbox.ToString()
        'textbox = textbox + 1
        Return txt
    End Function

    Private Function addlongtable() As LongTable
        Dim txt As LongTable = New LongTable()
        Panel1.Controls.Add(txt)
        'AddHandler txt.Click, AddressOf HelloIsMe

        'txt.Top = textbox * 30
        'txt.Left = 100
        'txt.Text = "TextBox" & Me.textbox.ToString()
        'textbox = textbox + 1
        Return txt
    End Function

    Private Function addbutton() As System.Windows.Forms.Button
        Dim btn As Button = New MouseClass()
        Panel1.Controls.Add(btn)
        btn.Top = button * 30
        'btn.Left = 300
        btn.Text = "T" & button
        btn.Name = "T" & button

        If txtWidth.Text = "" Or txtHeight.Text = "" Then
            btn.Size = New Size(140, 75)
        Else
            btn.Size = New Size(txtWidth.Text, txtHeight.Text)
        End If
        button = button + 1

        'txtName.Text = btn.Name
        'txtHeight.Text = btn.Height
        'txtWidth.Text = btn.Width
        AddHandler btn.Click, AddressOf HelloIsMe
        Return btn
    End Function

    Private Function deletebutton(ByVal sender As Object, ByVal e As EventArgs)

        Dim btn As MouseClass = DirectCast(sender, MouseClass)
        Panel1.Controls.Remove(btn)

    End Function

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click

        If txtName.Text = "" Then
            MsgBox("Please select a table to delete")
            Exit Sub
        End If

        Dim btn As MouseClass = CType(Panel1.Controls(txtName.Text.ToString), MouseClass)
        Panel1.Controls.Remove(btn)

        txtName.Text = ""
        txtHeight.Text = ""
        txtWidth.Text = ""

    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown,Me.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.ContextMenu = ContextMenu1
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'addtextbox()

        If cboType.Text = "LongTable" Then
            addlongtable()
        Else
            addtable()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addbutton()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deletebutton(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each btn In Panel1.Controls.OfType(Of Button)()
            MsgBox(btn.Name & "," & btn.Location.X & "," & btn.Location.Y)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFloor.SelectedIndexChanged
        If cboFloor.Text = "" Then

        ElseIf cboFloor.Text = "DineIn" Then
            Panel1.BackColor = Color.Black
        Else
            Panel1.BackColor = Color.White
        End If
    End Sub

    Private Sub HelloIsMe(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As MouseClass = DirectCast(sender, MouseClass)
        txtName.Text = btn.Name
        btn.Text = "Testing"
        txtHeight.Text = btn.Height
        txtWidth.Text = btn.Width
        'Dim btn As Table = DirectCast(sender, Table)
        'txtName.Text = btn.Name
        'btn.lblTableNumber.Text = "Testing"
        'txtHeight.Text = btn.Height
        'txtWidth.Text = btn.Width
    End Sub

    'Private Sub GetLocation()
    '    Dim Ctl As Control
    '    For Each Ctl In Form1
    '        MsgBox("Name : " & Ctl.Name & vbCrLf & "Left : " & Ctl.Left & vbCrLf & "Top : " & Ctl.Top"")
    '    Next
    'End Sub

End Class
