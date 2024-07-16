Imports System.ComponentModel

Public Class FormDetRecepComp
    Private Sub btnduplicar_Click(sender As Object, e As EventArgs) Handles btnduplicar.Click
        For i = 0 To FormMantFCRecepComp.dgvt_doc.Rows.Count - 1
            If FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("T_DOCU").Value = "" Then
                'FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("T_DOC").Value = txtserie.Text
                If cmbt_doc.SelectedIndex = 0 Then
                    FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("T_DOCU").Value = "01"
                ElseIf cmbt_doc.SelectedIndex = 0 Then
                    FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("T_DOCU").Value = "03"
                ElseIf cmbt_doc.SelectedIndex = 2 Then
                    FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("T_DOCU").Value = "07"
                ElseIf cmbt_doc.SelectedIndex = 3 Then
                    FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("T_DOCU").Value = "08"
                End If
            End If
            If FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("SER_DOCU").Value = "" Then
                FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("SER_DOCU").Value = txtserie.Text
            End If
            If FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("NRO_DOCU").Value = "" Then
                FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("NRO_DOCU").Value = txtnumero.Text
            End If
            If FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("SER_DOCU1").Value = "" Then
                FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("SER_DOCU1").Value = txtserie1.Text
            End If
            If FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("NRO_DOCU1").Value = "" Then
                FormMantFCRecepComp.dgvt_doc.Rows(i).Cells("NRO_DOCU1").Value = txtnumero1.Text
            End If
        Next
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDetRecepComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Duplicar Datos"
    End Sub

    Private Sub FormDetRecepComp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class