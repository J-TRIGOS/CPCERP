Imports System.ComponentModel

Public Class FormDetGuiaDespDuplicar
    Private Sub FormDetGuiaDespDuplicar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Duplicar"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnduplicar.Click
        For i = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
            FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("SERIE_SOLI").Value = txtserie.Text
            FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("NRO_DOCU1").Value = txtnumero.Text
            FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("FEC_ENT").Value = dtpfecha.Value
        Next
        Dispose()
    End Sub

    Private Sub FormDetGuiaDespDuplicar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class