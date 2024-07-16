Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBDetProv
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'Dim frm As New FormMantProvisiones
        For i = 0 To FormMantProvisiones.dgvt_doc.Rows.Count - 1
            FormMantProvisiones.dgvt_doc.Rows(i).Cells("CTA_CBCO").Value = txtcta.Text
            FormMantProvisiones.dgvt_doc.Rows(i).Cells("FARDO").Value = txtserv.Text
            FormMantProvisiones.dgvt_doc.Rows(i).Cells("PORCENTAJE").Value = npdporc.Value
            FormMantProvisiones.dgvt_doc.Rows(i).Cells("MONTO_PAGADO").Value = txtpago.Text
            FormMantProvisiones.dgvt_doc.Rows(i).Cells("PROGRAMA").Value = txtt_ope.Text
        Next
        Dispose()
    End Sub

    Private Sub txtt_ope_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_ope.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "231"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtt_ope.Text = gLinea
                txtnomope.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtserv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserv.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "232"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtserv.Text = gLinea
                txtnomserv.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub npdporc_LostFocus(sender As Object, e As EventArgs) Handles npdporc.LostFocus
        txtpago.Text = Math.Round(txttotal.Text * npdporc.Value / 100)
    End Sub

    Private Sub FormELTBDetProv_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtserv_LostFocus(sender As Object, e As EventArgs) Handles txtserv.LostFocus
        If txtserv.Text = "" Then
            txtnomserv.Text = ""
        Else
            txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(txtserv.Text)
        End If

    End Sub

    Private Sub txtt_ope_LostFocus(sender As Object, e As EventArgs) Handles txtt_ope.LostFocus
        If txtt_ope.Text = "" Then
            txtnomope.Text = ""
        Else
            txtnomope.Text = PROVISIONESBL.SelectNomDetra(txtt_ope.Text)
        End If

    End Sub
End Class