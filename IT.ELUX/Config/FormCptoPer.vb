Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormCptoPer
    Private PERBL As New PERBL
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormCptoPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Concepto"
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If gArt = "0" Then
            FormMantPersonal.dgvcpto.Rows(FormMantPersonal.dgvcpto.CurrentRow.Index).Cells("MONTO").Value = npdmonto.Value
            FormMantPersonal.dgvcpto.Rows(FormMantPersonal.dgvcpto.CurrentRow.Index).Cells("CODIGO").Value = txtcpto_cod.Text
        Else
            Dim cn As Integer = 0
            If FormMantPersonal.dgvcpto.Rows.Count > 0 Then
                For i = 0 To FormMantPersonal.dgvcpto.Rows.Count - 1
                    If FormMantPersonal.dgvcpto.Rows(i).Cells("CODIGO").Value = txtcpto_cod.Text Then
                        cn = cn + 1
                    End If
                Next
                If cn = 0 Then
                    FormMantPersonal.dgvcpto.Rows.Add(txtdni.Text, txtnom.Text, txtcpto_cod.Text, txtnomcpto.Text, npdmonto.Value)
                Else
                    MsgBox("El concepto ya se encuentra ingresado")
                End If
            Else
                FormMantPersonal.dgvcpto.Rows.Add(txtdni.Text, txtnom.Text, txtcpto_cod.Text, txtnomcpto.Text, npdmonto.Value)
            End If

        End If
        Dispose()
    End Sub

    Private Sub FormCptoPer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtcpto_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcpto_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "79"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcpto_cod.Text = gLinea
                txtnomcpto.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcpto_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcpto_cod.LostFocus
        If txtcpto_cod.Text <> "" Then
            txtnomcpto.Text = PERBL.SelPERCpto(txtcpto_cod.Text)
        Else
            txtnomcpto.Text = ""
        End If
    End Sub
End Class