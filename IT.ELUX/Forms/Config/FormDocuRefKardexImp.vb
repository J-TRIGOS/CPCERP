Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuRefKardexImp
    Private ELTBKARDEXIMPBL As New ELTBKARDEXIMPBL
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If rdboreq.Checked Then
            If dtpfecha.Checked Then
                lvbusqueda.Items.Clear()
                Dim dt As DataTable
                Dim item As ListViewItem
                Dim var1, var2, var3 As String

                Dim fec As Date = Nothing
                fec = dtpfecha.Value

                dt = ELTBKARDEXIMPBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                        'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                        item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                        item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                        item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                        item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                        item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        item.SubItems.Add(IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")))
                    Next
                Else
                    item = lvbusqueda.Items.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("No hay Data para la busqueda realizada")

                End If
            Else
                'If chknodom.Checked Then
                '    'If dtpfecha.Checked Then
                '    lvbusqueda.Items.Clear()
                '    Dim dt As DataTable
                '    Dim item As ListViewItem
                '    Dim var1, var2, var3 As String

                '    Dim fec As Date = Nothing
                '    fec = dtpfecha.Value

                '    dt = ELTBKARDEXIMPBL.listnodom(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                '    If dt.Rows.Count > 0 Then
                '        For Each row As DataRow In dt.Rows
                '            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                '            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                '            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                '            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                '            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                '            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                '            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                '        Next
                '    Else
                '        item = lvbusqueda.Items.Add("")
                '        item.SubItems.Add("")
                '        item.SubItems.Add("")
                '        item.SubItems.Add("")
                '        item.SubItems.Add("No hay Data para la busqueda realizada")

                '    End If
                '    'End If
                'Else
                'If dtpfecha.Checked Then
                lvbusqueda.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = ELTBKARDEXIMPBL.list(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    Else
                        item = lvbusqueda.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                'End If
                'End If

            End If
        ElseIf rdbfactComp.Checked Then
            If dtpfecha.Checked Then
                lvbusqueda.Items.Clear()
                Dim dt As DataTable
                Dim item As ListViewItem
                Dim var1, var2, var3 As String

                Dim fec As Date = Nothing
                fec = dtpfecha.Value

                dt = ELTBKARDEXIMPBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                        'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                        item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                        item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                        item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                        item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                        item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    Next
                Else
                    item = lvbusqueda.Items.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("No hay Data para la busqueda realizada")

                End If
            Else
                lvbusqueda.Items.Clear()
                Dim dt As DataTable
                Dim item As ListViewItem
                Dim var1, var2, var3 As String
                Dim fec As Date = Nothing
                fec = dtpfecha.Value
                dt = ELTBKARDEXIMPBL.list3(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                        'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                        item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                        item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                        item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                        item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                        item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    Next
                Else
                    item = lvbusqueda.Items.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("No hay Data para la busqueda realizada")

                End If
            End If
        End If
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim contador As Integer = 0

        If Label2.Text <> 0 Then
            'Dim tpreciouni As Double
            'Dim tpreciounid As Double
            'Dim igvprecio As Double
            'Dim igvpreciod As Double
            If rdboreq.Checked Then
                For i = 0 To lvbusqueda.Items.Count - 1
                    If lvbusqueda.Items(i).Checked = True Then
                        If chknodom.Checked Then
                            dt = ELTBKARDEXIMPBL.getListdgv2(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text, "")
                        Else
                            dt = ELTBKARDEXIMPBL.getListdgv2(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text, "1")
                        End If
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            'Dim s As String
                            FormELTBKardexImp.dgvt_doc.Rows.Add(FormELTBKardexImp.txtt_doc.Text, FormELTBKardexImp.cmb_serdoc.Text, FormELTBKardexImp.txtnumero.Text,
                                                     IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), "", IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                                     IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                                     IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")), IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")), IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),
                                                     "H", IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE")))
                            If contador = 1 Then
                                If FormELTBKardexImp.txtproveedor.Text = "" Then
                                    FormELTBKardexImp.txtproveedor.Text = lvbusqueda.Items(i).SubItems(3).Text
                                    FormELTBKardexImp.txtnomproveedor.Text = ELTBKARDEXIMPBL.SelectT_Prov(FormELTBKardexImp.txtproveedor.Text)
                                    FormELTBKardexImp.txtmon.Text = IIf(IsDBNull(row("MONEDA")), "", row("MONEDA"))
                                    FormELTBKardexImp.cmbmon.SelectedValue = IIf(IsDBNull(row("MONEDA")), "", row("MONEDA"))
                                End If
                            End If
                            If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) = "50" Then
                                FormELTBKardexImp.txtnumdua.Text = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF"))
                                FormELTBKardexImp.dtpfecdua.Value = IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE"))
                            End If
                        Next
                    End If
                Next
            ElseIf rdbfactComp.Checked Then
                For i = 0 To lvbusqueda.Items.Count - 1
                    If lvbusqueda.Items(i).Checked = True Then
                        'chequear
                        dt = ELTBKARDEXIMPBL.getListdgv4(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            Dim s As String
                            If cmbaf.SelectedIndex = 0 Then
                                s = "AFECTO"
                            Else
                                s = "INAFECTO"
                            End If
                            FormMantProvisiones.dgvt_doc.Rows.Add(FormELTBKardexImp.txtt_doc.Text, FormELTBKardexImp.cmb_serdoc.Text, FormELTBKardexImp.txtnumero.Text,
                                                     IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), "", IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                                     IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                                     IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")), IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")), IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),
                                                     "H", IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE")))
                            If i = 1 Then
                                FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                                FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                            End If
                        Next
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
                'Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                'FormMantProvisiones.txtnomproveedor.Text = prov1
                ''verificar
                'FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                '                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                'FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                '                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                'FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                'prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                'FormMantProvisiones.txtnom_moneda.Text = prov1
                'If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                '    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                '    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                '    FormMantProvisiones.txtser_doc_ref.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                '    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                '    FormMantProvisiones.btnagregar.Enabled = True
                '    FormMantProvisiones.btnborrar.Enabled = True
                '    FormMantProvisiones.btndocu.Enabled = True
                '    FormMantProvisiones.btnmodificar.Enabled = True
                'End If
            End If
        Else
            MsgBox("No ha marcado documentos para pasar")
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()

    End Sub

    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim contador As Integer = 0

        If Label2.Text <> 0 Then
            'Dim tpreciouni As Double
            'Dim tpreciounid As Double
            'Dim igvprecio As Double
            'Dim igvpreciod As Double
            If rdboreq.Checked Then
                'For i = 0 To lvbusqueda.Items.Count - 1
                'If lvbusqueda.Items(i).Checked = True Then
                If chknodom.Checked Then
                    dt = ELTBKARDEXIMPBL.getListdgv2(lvbusqueda.Items(e.Index).SubItems(0).Text, lvbusqueda.Items(e.Index).SubItems(1).Text, lvbusqueda.Items(e.Index).SubItems(2).Text, "")
                Else
                    dt = ELTBKARDEXIMPBL.getListdgv2(lvbusqueda.Items(e.Index).SubItems(0).Text, lvbusqueda.Items(e.Index).SubItems(1).Text, lvbusqueda.Items(e.Index).SubItems(2).Text, "1")
                End If

                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    'Dim s As String
                    If chknodom.Checked Then
                        FormELTBKardexImp.dgvt_doc.Rows.Add(FormELTBKardexImp.txtt_doc.Text, FormELTBKardexImp.cmb_serdoc.Text, FormELTBKardexImp.txtnumero.Text,
                                 IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                 IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), "", IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                 IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                 IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")), IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")),
                                 IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")), IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),
                                 "H", IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE")), IIf(IsDBNull(row("ADVALORE")), 0, row("ADVALORE")))
                    Else
                        FormELTBKardexImp.dgvt_doc.Rows.Add(FormELTBKardexImp.txtt_doc.Text, FormELTBKardexImp.cmb_serdoc.Text, FormELTBKardexImp.txtnumero.Text,
                                 IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                 IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), "", IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                 IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                 IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")), IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")),
                                 IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")), IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),
                                 "H", IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE")))
                    End If

                    If contador = 1 Then
                        If FormELTBKardexImp.txtproveedor.Text = "" Then
                            FormELTBKardexImp.txtproveedor.Text = lvbusqueda.Items(0).SubItems(3).Text
                            FormELTBKardexImp.txtnomproveedor.Text = ELTBKARDEXIMPBL.SelectT_Prov(FormELTBKardexImp.txtproveedor.Text)
                            FormELTBKardexImp.txtmon.Text = IIf(IsDBNull(row("MONEDA")), "", row("MONEDA"))
                            FormELTBKardexImp.cmbmon.SelectedValue = IIf(IsDBNull(row("MONEDA")), "", row("MONEDA"))

                        End If
                    End If
                    If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) = "50" Then
                        FormELTBKardexImp.txtnumdua.Text = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF"))
                        FormELTBKardexImp.dtpfecdua.Value = IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE"))
                        FormELTBKardexImp.dtpfecha.Value = IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE"))
                    End If
                Next
                FormELTBKardexImp.txtnro_oreq.Text = txt_num.Text
                'End If
                'Next
            ElseIf rdbfactComp.Checked Then
                For i = 0 To lvbusqueda.Items.Count - 1
                    If lvbusqueda.Items(i).Checked = True Then
                        'chequear
                        dt = ELTBKARDEXIMPBL.getListdgv4(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            Dim s As String
                            If cmbaf.SelectedIndex = 0 Then
                                s = "AFECTO"
                            Else
                                s = "INAFECTO"
                            End If
                            FormMantProvisiones.dgvt_doc.Rows.Add(FormELTBKardexImp.txtt_doc.Text, FormELTBKardexImp.cmb_serdoc.Text, FormELTBKardexImp.txtnumero.Text,
                                                     IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), "", IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                                     IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                                     IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")), IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("T_IGV")), 0, row("T_IGV")), IIf(IsDBNull(row("T_IGV_DOLAR")), 0, row("T_IGV_DOLAR")),
                                                     "H", IIf(IsDBNull(row("FEC_GENE")), 0, row("FEC_GENE")))
                            If i = 1 Then
                                FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                                FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                            End If
                        Next
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
                'Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                'FormMantProvisiones.txtnomproveedor.Text = prov1
                ''verificar
                'FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                '                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                'FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                '                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                'FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                'prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                'FormMantProvisiones.txtnom_moneda.Text = prov1
                'If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                '    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                '    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                '    FormMantProvisiones.txtser_doc_ref.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                '    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                '    FormMantProvisiones.btnagregar.Enabled = True
                '    FormMantProvisiones.btnborrar.Enabled = True
                '    FormMantProvisiones.btndocu.Enabled = True
                '    FormMantProvisiones.btnmodificar.Enabled = True
                'End If
            End If
        Else
            MsgBox("No ha marcado documentos para pasar")
        End If
    End Sub

    Private Sub txt_num_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num.KeyDown
        If e.KeyValue = Keys.Enter Then
            If rdboreq.Checked Then
                If dtpfecha.Checked Then
                    lvbusqueda.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = ELTBKARDEXIMPBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")))
                        Next
                    Else
                        item = lvbusqueda.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                Else
                    'If dtpfecha.Checked Then
                    lvbusqueda.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = ELTBKARDEXIMPBL.list(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    Else
                        item = lvbusqueda.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                    'End If
                End If
            ElseIf rdbfactComp.Checked Then
                If dtpfecha.Checked Then
                    lvbusqueda.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = ELTBKARDEXIMPBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    Else
                        item = lvbusqueda.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                Else
                    lvbusqueda.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = ELTBKARDEXIMPBL.list3(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    Else
                        item = lvbusqueda.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                End If
            End If
        End If
    End Sub

End Class