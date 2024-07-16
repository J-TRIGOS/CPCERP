Imports System.ComponentModel
Imports System.IO
Public Class FormLectorPDF
    Public gsPathReports = Application.StartupPath
    Private Sub FormLectorPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WebBrowser1.Navigate(gsRptPath)
            'Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gsRptPath = ""
    End Sub
    Private Sub FormLectorPDF_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class