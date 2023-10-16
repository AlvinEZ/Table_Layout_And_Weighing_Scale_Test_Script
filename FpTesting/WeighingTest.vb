Imports System.IO.Ports

Public Class WeighingTest
    Private Sub WeighingTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TextBox1.Text = sport.ReadChar
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PV_ComPort As String = "COM2"
        Dim sport As SerialPort = New SerialPort(PV_ComPort, 9600, Parity.None, 8, StopBits.One)
        Try
            sport.Open()
            'TextBox1.Text = Trim(sport.ReadLine())           
            sport.ReadTimeout = 10000
            'sport.Close()
            TextBox1.Text = Trim(sport.ReadTo(vbCrLf))

        Catch ex As TimeoutException
            MsgBox("Error: Serial Port read timed out.", MsgBoxStyle.Exclamation)
        Finally
            If sport IsNot Nothing Then sport.Close()
        End Try
    End Sub


End Class