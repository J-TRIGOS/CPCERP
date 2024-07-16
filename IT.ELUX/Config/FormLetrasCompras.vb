Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormLetrasCompras
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private Sub FormLetrasCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Letras Compras"
        Me.txtt_doc.Text = FormMantProvisiones.txtt_doc.Text
        Me.txtser_doc.Text = FormMantProvisiones.txtser_doc_ref.Text
        Me.txtnro_doc.Text = FormMantProvisiones.txtnumero.Text
        Me.txtmoneda.Text = FormMantProvisiones.txtmoneda.Text
        Me.txtproveedor.Text = FormMantProvisiones.txtproveedor.Text
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'Dim frn As New formmant
        If dgvt_doc.Rows.Count > 0 Then
            FormMantProvisiones.dgvtletras.Rows.Clear()
            For i = 0 To dgvt_doc.Rows.Count - 1
                FormMantProvisiones.dgvtletras.Rows.Add(dgvt_doc.Rows(i).Cells("Codigo").Value,
                                                        dgvt_doc.Rows(i).Cells("T_DOC_REF").Value,
                                                        dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value,
                                                        dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value,
                                                        dgvt_doc.Rows(i).Cells("FEC_LETRA").Value,
                                                        dgvt_doc.Rows(i).Cells("NRO_DOC").Value,
                                                        dgvt_doc.Rows(i).Cells("MONTO").Value,
                                                        dgvt_doc.Rows(i).Cells("MONTOD").Value,
                                                        dgvt_doc.Rows(i).Cells("PROVEEDOR").Value,
                                                        dgvt_doc.Rows(i).Cells("T_CMB").Value,
                                                        dgvt_doc.Rows(i).Cells("MONEDA").Value)
            Next
        End If

        Dispose()
    End Sub

    Private Sub FormLetrasCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub dgvt_doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt_doc.CellContentClick
        txtnum_doc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC").Value
        npdmonto.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTO").Value
        dtpfecha.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_LETRA").Value
        npdmontod.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTOD").Value
        txtt_cmb.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CMB").Value
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnro_doc.TextLength > 0 And npdmonto.Value > 0 Then
            dgvt_doc.Rows.Add(dgvt_doc.Rows.Count + 1, FormMantProvisiones.txtt_doc.Text, FormMantProvisiones.txtser_doc_ref.Text,
            FormMantProvisiones.txtnumero.Text, dtpfecha.Value, txtnum_doc.Text, Math.Round(npdmonto.Value, 2), Math.Round(npdmontod.Value, 2),
            txtproveedor.Text, txtt_cmb.Text, txtmoneda.Text)
            btnnuevo.Text = "Nuevo"
            txtnum_doc.Text = ""
            npdmonto.Value = 0
            npdmontod.Value = 0

        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        If btnnuevo.Text = "Cancelar" Then
            btnnuevo.Text = "Nuevo"
            txtnum_doc.Enabled = False
            npdmonto.Enabled = False
            dtpfecha.Enabled = False
            npdmontod.Enabled = False
            'dtpfecha.Enabled = False
        ElseIf btnnuevo.Text = "Nuevo" Then
            btnnuevo.Text = "Cancelar"
            Dim dt As DataTable
            Dim mesfecha As String
            Dim mesdia As String
            If dtpfecha.Value.Month.ToString.Length = "1" Then
                mesfecha = "0" & dtpfecha.Value.Month.ToString
            Else
                mesfecha = dtpfecha.Value.Month.ToString
            End If
            If dtpfecha.Value.Day.ToString.Length = "1" Then
                mesdia = "0" & dtpfecha.Value.Day.ToString
            Else
                mesdia = dtpfecha.Value.Day.ToString
            End If
            dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
            For Each Registro In dt.Rows
                txtt_cmb.Text = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            Next
            txtnum_doc.Enabled = True
            'npdmonto.Enabled = True
            dtpfecha.Enabled = True
            'npdmontod.Enabled = True
            If txtmoneda.Text = "00" Then
                npdmonto.Enabled = True
                npdmontod.Enabled = False
            Else
                npdmonto.Enabled = False
                npdmontod.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If dgvt_doc.RowCount > 0 Then
            btnnuevo.Text = "Nuevo"
            txtnum_doc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC").Value
            npdmonto.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTO").Value
            dtpfecha.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_LETRA").Value
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub dtpfecha_LostFocus(sender As Object, e As EventArgs) Handles dtpfecha.LostFocus
        Dim dt As DataTable
        Dim mesfecha As String
        Dim mesdia As String
        If dtpfecha.Value.Month.ToString.Length = "1" Then
            mesfecha = "0" & dtpfecha.Value.Month.ToString
        Else
            mesfecha = dtpfecha.Value.Month.ToString
        End If
        If dtpfecha.Value.Day.ToString.Length = "1" Then
            mesdia = "0" & dtpfecha.Value.Day.ToString
        Else
            mesdia = dtpfecha.Value.Day.ToString
        End If
        dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            txtt_cmb.Text = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
    End Sub

    Private Sub npdmonto_LostFocus(sender As Object, e As EventArgs) Handles npdmonto.LostFocus
        If npdmonto.Value > 0 Then
            npdmontod.Value = npdmonto.Value * txtt_cmb.Text
        Else
            npdmonto.Text = "0.00"
            npdmontod.Value = "0.00"
        End If
    End Sub

    Private Sub npdmontod_ValueChanged(sender As Object, e As EventArgs) Handles npdmontod.ValueChanged
        If npdmontod.Value > 0 Then
            npdmonto.Value = npdmontod.Value / txtt_cmb.Text
        Else
            npdmonto.Text = "0.00"
            npdmontod.Value = "0.00"
        End If
    End Sub
End Class