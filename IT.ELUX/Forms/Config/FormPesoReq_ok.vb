Imports System.ComponentModel

Public Class FormPesoReq_ok
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("PESO").Value = npdpeso.Value
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub FormPesoReq_ok_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormPesoReq_ok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class