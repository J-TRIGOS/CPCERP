Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormMantLetras_Monto

    Private ELTBLETRAS_MONTOBL As New ELTBLETRAS_MONTOBL
    Dim GUIAALMACENBL As New GUIAALMACENBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Dim dg As DataGridView
    Dim dt As DataTable

    Private Sub FormMantLetras_Monto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtmon.Text = "00" Then
            txtmontos.Enabled = True
            txtmontod.Enabled = False
        Else
            txtmontos.Enabled = False
            txtmontod.Enabled = True
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If OkData() = False Then
            Exit Sub
        Else
            Dim aa, bb As String
            If txtmontos.Text = "" Then
                aa = 0
            Else
                aa = txtmontos.Text
            End If

            If txtmontod.Text = "" Then
                bb = 0
            Else
                bb = txtmontod.Text
            End If

            Dim cmb As String
            dt = REQUERIMIENTOBL.getT_CAMB(gsCode7)
            'Dim frm As New FormMantDetFacturacion
            For Each Registro In dt.Rows
                cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
            Next

            If btnaceptar.Text = "Aceptar" Then
                FormMantLetras.dtgv_montos.Rows.Add(FormMantLetras.txtt_doc.Text, FormMantLetras.cmb_serdoc.SelectedItem,
                                                FormMantLetras.txtnumero.Text, lbl01.Text, lbl02.Text, lbl03.Text,
                                                lblproveedor.Text, lbl_cliente.Text, txtmon.Text, lblmon.Text, aa, bb,
                                                lblt_cambio.Text, lblmontos.Text, lblmontod.Text)
                FormMantLetras.txtmon.Text = txtmon.Text
                FormMantLetras.cmbmon.SelectedValue = txtmon.Text
                dt = GUIAALMACENBL.getListdgv6(lbl01.Text, lbl02.Text, lbl03.Text)
                For Each row As DataRow In dt.Rows
                    FormMantLetras.dgvt_doc.Rows.Add(FormMantLetras.txtt_doc.Text, FormMantLetras.cmb_serdoc.Text,
                                                                     FormMantLetras.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantLetras.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                     IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),
                                                                     IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                     "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), "", IIf(IsDBNull(row("TPRECIO_VENTA")), 0, row("TPRECIO_VENTA")), IIf(IsDBNull(row("TPRECIO_DVENTA")), 0, row("TPRECIO_DVENTA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                                     cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                                     IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                     FormMantLetras.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                     RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")), "", "", "", "",
                                                                     FormMantLetras.cmbestado.Text)
                Next
            Else
                FormMantLetras.dtgv_montos.Rows(FormMantLetras.dtgv_montos.CurrentRow.Index).Cells(10).Value = aa
                FormMantLetras.dtgv_montos.Rows(FormMantLetras.dtgv_montos.CurrentRow.Index).Cells(11).Value = bb
            End If

            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Function OkData() As Boolean

        If txtmon.Text = "00" Then
            If txtmontos.Text = "" Then
                MsgBox("Ingrese el monto en soles", MsgBoxStyle.Exclamation)
                txtmontos.Focus()
                Return False
            End If
            If CInt(txtmontos.Text) > CInt(lblmontos.Text) Then
                MsgBox("Este monto no debe ser mayor a la factura", MsgBoxStyle.Exclamation)
                txtmontos.Focus()
                Return False
            End If
        Else
            If txtmontod.Text = "" Then
                MsgBox("Ingrese el monto en Dolares", MsgBoxStyle.Exclamation)
                txtmontod.Focus()
                Return False
            End If
            If CInt(txtmontod.Text) > CInt(lblmontod.Text) Then
                MsgBox("Este monto no debe ser mayor a la factura", MsgBoxStyle.Exclamation)
                txtmontod.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub txtmontod_LostFocus(sender As Object, e As EventArgs) Handles txtmontod.LostFocus
        If txtmon.Text = "01" Then
            txtmontos.Value = Math.Round(txtmontod.Value * lblt_cambio.Text, 2)
        Else
            txtmontod.Value = Math.Round(txtmontos.Value / lblt_cambio.Text, 2)
        End If
    End Sub

    Private Sub txtmontos_LostFocus(sender As Object, e As EventArgs) Handles txtmontos.LostFocus
        'If txtmon.Text = "01" Then
        '    txtmontos.Value = Math.Round(txtmontod.Value * lblt_cambio.Text, 2)
        'Else
        '    txtmontod.Value = Math.Round(txtmontos.Value / lblt_cambio.Text, 2)
        'End If
    End Sub

    Private Sub FormMantLetras_Monto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class