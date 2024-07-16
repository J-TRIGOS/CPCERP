
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormDocuRefConta
    Dim gpCaption As String
    Private CUENTABANCOBL As New CUENTABANCOBL
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Cursor.Current = Cursors.WaitCursor
        lvbusqueda1.Items.Clear()
        Dim dt As DataTable
        Dim item As ListViewItem
        Dim var1, var2, var3 As String

        If chkgen.Checked = False Then
            var1 = "0"
        Else
            var1 = "1"
        End If

        If txtt_doc.Text = "" Then txtt_doc.Text = " "
        If txtser_doc.Text = "" Then txtser_doc.Text = " "
        If txtnro_doc.Text = "" Then txtnro_doc.Text = " "
        If txtregistro.Text = "" Then txtregistro.Text = " "
        If txt_tipomon.Text = "" Then txt_tipomon.Text = " "
        If txt_proveedor.Text = "" Then txt_proveedor.Text = " "

        dt = ELPAGO_DOCUMENTOBL.list1(txtt_doc.Text, txtser_doc.Text, txtnro_doc.Text, txtregistro.Text,
                                     txt_tipomon.Text, txt_proveedor.Text, var1, dtpgen_desde.Value, dtpgen_hasta.Value)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")))
                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                item.SubItems.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")))
                item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                item.SubItems.Add(IIf(IsDBNull(row("REG_NRO")), "", row("REG_NRO")))
                item.SubItems.Add(IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")))
                item.SubItems.Add(IIf(IsDBNull(row("TPRECIO_DCOMPRA")), "", row("TPRECIO_DCOMPRA")))
                item.SubItems.Add(IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                item.SubItems.Add(IIf(IsDBNull(row("MON_COD")), "", row("MON_COD")))
                item.SubItems.Add(IIf(IsDBNull(row("NOMBRE")), "", row("NOMBRE")))
            Next
        Else
            item = lvbusqueda1.Items.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("No hay Data para la busqueda realizada")
        End If


    End Sub

    Private Sub btnPasar_Click(sender As Object, e As EventArgs) Handles btnPasar.Click
        If lvbusqueda1.Items.Count <= 0 Then
            MsgBox("No hay datos para pasar ", MsgBoxStyle.Information)
        Else

            Dim a As Integer = FormOrdenProgramas.dgvt_doc.Rows.Count
            Dim fechadia, t_cambio As String

            'Dim fechafin As Date = FormOrdenProgramas.dtpfec_inicio.Value
            'Dim fechafindos As Date = FormOrdenProgramas.dtpfec_inicio.Value

            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = True Then
                    a = a + 1
                    fechadia = lvbusqueda1.Items(i).SubItems(3).Text
                    t_cambio = ELPAGO_DOCUMENTOBL.SelectTipoC(fechadia)

                    FormELPAGO_DOCUMENTO.dgvt_doc.Rows.Add(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                    lvbusqueda1.Items(i).SubItems(2).Text, "NO", "", "", lvbusqueda1.Items(i).SubItems(4).Text, lvbusqueda1.Items(i).SubItems(5).Text,
                    "", fechadia, t_cambio, lvbusqueda1.Items(i).SubItems(10).Text, lvbusqueda1.Items(i).SubItems(11).Text,
                    lvbusqueda1.Items(i).SubItems(7).Text, lvbusqueda1.Items(i).SubItems(8).Text)
                End If
            Next

        End If
    End Sub

    Private Sub chkgen_CheckedChanged(sender As Object, e As EventArgs) Handles chkgen.CheckedChanged
        If chkgen.Checked = True Then
            dtpgen_desde.Enabled = True
            dtpgen_hasta.Enabled = True
        Else
            dtpgen_desde.Enabled = False
            dtpgen_hasta.Enabled = False
        End If
    End Sub

    Private Sub txt_proveedor_LostFocus(sender As Object, e As EventArgs) Handles txt_proveedor.LostFocus
        If (txt_proveedor.Text = "") Then
            lbl_proveedor.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectProveedorCOD(txt_proveedor.Text)
            If dt.Rows.Count > 0 Then
                txt_proveedor.Text = dt.Rows(0).Item(0).ToString
                lbl_proveedor.Text = dt.Rows(0).Item(1).ToString
            Else
                txt_proveedor.Text = ""
                lbl_proveedor.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "98"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_proveedor.Text = gLinea
                lbl_proveedor.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub txt_tipomon_LostFocus(sender As Object, e As EventArgs) Handles txt_tipomon.LostFocus
        If (txt_tipomon.Text = "") Then
            lbl_tipomon.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectMonCOD(txt_tipomon.Text)
            If dt.Rows.Count > 0 Then
                txt_tipomon.Text = dt.Rows(0).Item(0).ToString
                lbl_tipomon.Text = dt.Rows(0).Item(1).ToString
            Else
                txt_tipomon.Text = ""
                lbl_tipomon.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_tipomon_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipomon.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "97"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_tipomon.Text = gLinea
                lbl_tipomon.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtt_doc_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc.LostFocus
        If (txtt_doc.Text = "") Then
            lblt_doc.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectTipodocCOD(txtt_doc.Text)
            If dt.Rows.Count > 0 Then
                txtt_doc.Text = dt.Rows(0).Item(0).ToString
                lblt_doc.Text = dt.Rows(0).Item(1).ToString
            Else
                txtt_doc.Text = ""
                lblt_doc.Text = ""
            End If
        End If
    End Sub

    Private Sub txtt_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_doc.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "96"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtt_doc.Text = gLinea
                lblt_doc.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
End Class