Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuRefProgPago
    Private gpCaption As String
    Private ARTICULOBL As New ARTICULOBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private LETRASBL As New LETRASBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private observa1 As String
    Public dtFpago As String
    Public dtMoneda As String

    Private Sub FormDocuRefProgPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpCaption = "Documento Referencia"
        Me.Text = gpCaption

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If gsCode11 = "1" Then
            lvbusqueda.Items.Clear()
            Dim dt As DataTable
            Dim item As ListViewItem
            Dim ELTBPROGPAGOBL As New ELTBPROGPAGOBL
            Dim fec As Date = Nothing
            If dtpfecha.Checked Then
                fec = dtpfecha.Value
                dt = ELTBPROGPAGOBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, txtCliente.Text, fec, dtMoneda)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NDOC")), "", row("NDOC")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))


                Next
            Else
                dt = ELTBPROGPAGOBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, txtCliente.Text, dtMoneda)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NDOC")), "", row("NDOC")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add("")
                Next
            End If
        Else

        End If

    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = False Then
                    lvbusqueda.Items(i).Checked = True

                End If

            Next
        Else
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    lvbusqueda.Items(i).Checked = False
                End If
            Next
        End If

    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim contador As Integer = 0
        Dim i As Integer = 0
        Dim dt As DataTable
        Dim val As String = ""
        Dim ELTBPROGPAGOBL As New ELTBPROGPAGOBL
        If Label2.Text <> 0 Then
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    If FormMantELTBPROGPAGO.dgvt_doc.Rows.Count > 0 Then
                        For j = 0 To FormMantELTBPROGPAGO.dgvt_doc.Rows.Count - 1
                            If lvbusqueda.Items(i).SubItems(3).Text = FormMantELTBPROGPAGO.dgvt_doc.Rows(j).Cells("NRO_DOC_REF").Value Then
                                val = "1"
                            End If
                        Next
                        If val <> "1" Then
                            dt = ELTBPROGPAGOBL.getListdgv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, txtCliente.Text)
                            For Each row As DataRow In dt.Rows
                                contador = contador + 1

                                FormMantELTBPROGPAGO.dgvt_doc.Rows.Add(
                                FormMantELTBPROGPAGO.txtt_doc.Text,                                  '0
                                "",                                                                  '1
                                FormMantELTBPROGPAGO.cmb_serdoc.Text,                                '2
                                FormMantELTBPROGPAGO.txtnumero.Text,                                 '3
                                IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),               '4
                                IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),           '5
                                IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),           '6
                                "",                                                                  '7
                                "",                                                                  '8
                                IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),               '9
                                "",                                                                  '10
                                IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),                 '11
                                IIf(IsDBNull(row("T_CMB")), 0, row("T_CMB")),                        '12
                                IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),                     '13
                                IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")),                        '14
                                IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),            '15
                                IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")),      '16
                                IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),    '17
                                IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),                   '18
                                "",'X_RET                                                            '19
                                IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),             '20
                                IIf(IsDBNull(row("T_OPE")), "", row("T_OPE")),                       '21 
                                IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),                   '22
                                IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),                   '23
                                "",                                                                  '24
                                IIf(IsDBNull(row("REG_NRO")), "", row("REG_NRO")),                   '25
                                IIf(IsDBNull(row("FEC_VEN")), "", row("FEC_VEN")),                   '26
                                IIf(IsDBNull(row("OBSERVA2")), "", row("OBSERVA2")),                 '27
                                IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")),      '28
                                IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),    '29
                                IIf(IsDBNull(row("CUENTITA")), 0, row("CUENTITA")),                  '30
                                "")                                                                  '31
                            Next
                        Else
                            val = ""
                        End If
                    Else
                        dt = ELTBPROGPAGOBL.getListdgv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, txtCliente.Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            'FormMantELTBPROGPAGO.dgvt_doc.Rows.Add(
                            '    IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),               '0
                            '    IIf(IsDBNull(row("T_DOC_REF")), "", ""),' STATUS                     '1
                            '    IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),           '2
                            '    IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),           '3
                            '    IIf(IsDBNull(row("NRO_DOC_REF")), "", ""),'CUENTA                    '4
                            '    IIf(IsDBNull(row("NRO_DOC_REF")), "", ""),'CUENTA_DEST               '5
                            '    IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),               '6
                            '    IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),                       '7
                            '    IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),                 '8
                            '    IIf(IsDBNull(row("T_CMB")), 0, row("T_CMB")),                        '9
                            '    IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),                     '10
                            '    IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")),                        '11
                            '    IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),            '12
                            '    IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")),      '13
                            '    IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),    '14
                            '    IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),                   '15
                            '    IIf(IsDBNull(row("OBSERVA")), "", ""),'X_RET                         '16
                            '    IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),             '17
                            '    IIf(IsDBNull(row("T_OPE")), "", row("T_OPE")),                       '18 
                            '    IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),                   '19
                            '    IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),                   '20
                            '    IIf(IsDBNull(row("RETEN")), "", row("RETEN")))                       '21
                            FormMantELTBPROGPAGO.dgvt_doc.Rows.Add(
                                FormMantELTBPROGPAGO.txtt_doc.Text,                                  '0
                                "AFECTO",                                                            '1
                                FormMantELTBPROGPAGO.cmb_serdoc.Text,                                '2
                                FormMantELTBPROGPAGO.txtnumero.Text,                                 '3
                                IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),               '4
                                IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),           '5
                                IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),           '6
                                "",                                                                  '7
                                "",                                                                  '8
                                IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),               '9
                                "",                                                                  '10
                                IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),                 '11
                                IIf(IsDBNull(row("T_CMB")), 0, row("T_CMB")),                        '12
                                IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),                     '13
                                IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")),                        '14
                                IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),            '15
                                IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")),      '16
                                IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),    '17
                                IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),                   '18
                                "",'X_RET                                                            '19
                                IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),             '20
                                IIf(IsDBNull(row("T_OPE")), "", row("T_OPE")),                       '21 
                                IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),                   '22
                                IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),                   '23
                                "",                                                                  '24
                                IIf(IsDBNull(row("REG_NRO")), "", row("REG_NRO")),                   '25
                                IIf(IsDBNull(row("FEC_VEN")), "", row("FEC_VEN")),                   '26
                                "", 'OBSERVA2                                                        '27
                                IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")),      '28
                                IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),    '29
                                IIf(IsDBNull(row("CUENTITA")), 0, row("CUENTITA")),                  '30               
                                "")                                                                  '31
                            If contador = 1 Then
                                If FormMantELTBPROGPAGO.txtmon.Text = "" Then
                                    FormMantELTBPROGPAGO.txtmon.Text = IIf(IsDBNull(row("MONEDA")), "", row("MONEDA"))
                                    FormMantELTBPROGPAGO.cmb_mon.SelectedValue = IIf(IsDBNull(row("MONEDA")), "", row("MONEDA"))
                                    FormMantELTBPROGPAGO.txtctct_cod.Text = IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR"))
                                    FormMantELTBPROGPAGO.cmb_ctct_cod.SelectedValue = IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR"))
                                End If
                            End If
                        Next
                    End If
                End If
            Next
        Else
            MsgBox("No ha marcado documentos para pasar")
        End If

    End Sub

    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDocuRefProgPago_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class