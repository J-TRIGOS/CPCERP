Imports System.ComponentModel
Imports System.IO
Public Class FormLectorIMG
    Private Sub FormLectorIMG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pbximagen.Image = Image.FromFile(gsRptPath)
            ' Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gsRptPath = ""
    End Sub

    Private Sub FormLectorIMG_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class