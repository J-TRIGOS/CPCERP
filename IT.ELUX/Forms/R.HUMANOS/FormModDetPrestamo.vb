Imports IT.ELUX.BL
Public Class FormModDetPrestamo

    Dim PRESTAMOBL As New PRESTAMOBL
    Private Sub FormModDetPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCuota.Enabled = False
        If gsUser = "JTRIGOS" Then
            cmbEstado.Visible = True
        Else
            cmbEstado.Visible = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        FormPrestamoPer.dgvt_doc.Rows(gsCode5).Cells("MONTO").Value = txtMonto.Text
        FormPrestamoPer.dgvt_doc.Rows(gsCode5).Cells("FECVENC").Value = dtpFecha.Value.ToString("dd/MM/yyyy")
        FormPrestamoPer.dgvt_doc.Rows(gsCode5).Cells("PRDO").Value = txtPeriodoPago.Text
        Dim PRDOPAGO As New DataTable
        PRDOPAGO = PRESTAMOBL.BuscarNumPrdo(txtPeriodoPago.Text)
        If PRDOPAGO.Rows.Count > 0 Then
            FormPrestamoPer.dgvt_doc.Rows(gsCode5).Cells("PRDOPAGO").Value = PRDOPAGO.Rows(0).Item(0)
        End If

        FormPrestamoPer.dgvt_doc.Rows(gsCode5).Cells("ESTADO").Value = cmbEstado.Text
        FormPrestamoPer.dgvt_doc.Rows(gsCode5).Cells("TPAGO").Value = cmbTpago.Text
        gLinea2 = Nothing
        Dispose()
    End Sub

    Private Sub btnBuscarPrdo_Click(sender As Object, e As EventArgs) Handles btnBuscarPrdo.Click
        Try
            gLinea = txtPeriodoPago.Text
            gSubLinea = dtpFecha.Value.ToString("MMyyyy")

            sBusAlm = "PRDOPRESTAMO"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gLinea2 <> Nothing Then
                txtPeriodoPago.Text = gLinea
                dtpFecha.Value = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            FormPrestamoPer.dgvt_doc.Rows.Add(1)
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("CUOTA").Value = txtCuota.Text
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("TIPO").Value = FormPrestamoPer.txtt_doc.Text
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("SERIE").Value = FormPrestamoPer.cmb_serdoc.Text
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("NUMERO").Value = FormPrestamoPer.txtnumero.Text & "-" & txtCuota.Text
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("FECVENC").Value = dtpFecha.Value.ToString("dd/MM/yyyy")
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("PRDO").Value = txtPeriodoPago.Text
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("MONTO").Value = txtMonto.Text
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("PRDOPAGO").Value = gLinea2
            FormPrestamoPer.dgvt_doc.Rows(txtCuota.Text - 1).Cells("ESTADO").Value = "PENDIENTE"
            Dispose()
        Catch ex As Exception

        End Try

    End Sub
End Class