Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuProvCon
    Private PROVISIONESBL As New PROVISIONESBL
    Private ARTICULOBL As New ARTICULOBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If gnOpcion3 = "0" Then
            If rdbrdoc.Checked Then
                If dtpfecha.Checked Then
                    lvbusqueda2.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda2.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")))
                        Next
                    Else
                        item = lvbusqueda1.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                Else
                    'If dtpfecha.Checked Then
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda2.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")))
                        Next
                    Else
                        item = lvbusqueda1.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                    'End If
                End If
            ElseIf rdboreq.Checked Then
                If dtpfecha.Checked Then
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list4(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    Else
                        item = lvbusqueda1.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                Else
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list3(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    Else
                        item = lvbusqueda1.Items.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("No hay Data para la busqueda realizada")

                    End If
                End If
            ElseIf rdbfactrecp.Checked Then '----
                If dtpfecha.Checked Then
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list5(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    End If
                Else
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list5(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    End If
                End If
                'End If
            ElseIf rdbfactComp.Checked Then
                If dtpfecha.Checked Then
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list10(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    End If
                Else
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list9(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    End If
                End If
            End If
        Else
            If rdbfactrecp.Checked Then
                If dtpfecha.Checked Then
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list8(txtt_doc.Text, txtser_doc.Text, txt_num.Text, dtpfecha.Value)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    End If
                Else
                    lvbusqueda1.Items.Clear()
                    Dim dt As DataTable
                    Dim item As ListViewItem
                    Dim var1, var2, var3 As String

                    Dim fec As Date = Nothing
                    fec = dtpfecha.Value

                    dt = PROVISIONESBL.list7(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                            'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                            item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                            item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                        Next
                    End If
                End If
            End If
        End If



    End Sub

    Private Sub FormDocuProvCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Busqueda de Ordenes"
        Me.cmbaf.SelectedIndex = 0
        Me.txt_num.Select()

    End Sub

    Private Sub txtt_doc_TextChanged(sender As Object, e As EventArgs) Handles txtt_doc.TextChanged
        If txtt_doc.TextLength > 0 Then
            chktipo.Checked = True
        Else
            chktipo.Checked = False
        End If
    End Sub

    Private Sub txtser_doc_TextChanged(sender As Object, e As EventArgs) Handles txtser_doc.TextChanged
        If txtser_doc.TextLength > 0 Then
            chkser.Checked = True
        Else
            chkser.Checked = False
        End If
    End Sub

    Private Sub txt_num_TextChanged(sender As Object, e As EventArgs) Handles txt_num.TextChanged
        If txt_num.TextLength > 0 Then
            chknum.Checked = True
        Else
            chknum.Checked = False
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDocuProvCon_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        dt = PROVISIONESBL.getListdgv2(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text, lvbusqueda1.Items(i).SubItems(2).Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            Dim s As String
                            If cmbaf.SelectedIndex = 0 Then
                                s = "AFECTO"
                            Else
                                s = "INAFECTO"
                            End If
                            'If s = "AFECTO" Then
                            FormMantProvisiones.dgvt_doc.Rows.Add(FormMantProvisiones.txtt_doc.Text, FormMantProvisiones.txtser_doc_ref.Text, FormMantProvisiones.txtnumero.Text,
                                                     IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), "",
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), 0, row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")))
                            'Else

                            'End If
                            If i = 1 Then
                                FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                                FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                            End If
                        Next
                    End If
                Next
            ElseIf rdbrdoc.Checked Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        'Verificar
                        dt = PROVISIONESBL.getListdgv4(lvbusqueda2.Items(i).SubItems(0).Text, lvbusqueda2.Items(i).SubItems(1).Text, lvbusqueda2.Items(i).SubItems(2).Text, lvbusqueda2.Items(i).SubItems(6).Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            Dim s As String
                            If cmbaf.SelectedIndex = 0 Then
                                s = "AFECTO"
                            Else
                                s = "INAFECTO"
                            End If
                            FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                     IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "",
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")))
                        Next
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
                Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                FormMantProvisiones.txtnomproveedor.Text = prov1
                FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                FormMantProvisiones.txtnom_moneda.Text = prov1
                If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.txtser_doc_ref.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                    FormMantProvisiones.btnagregar.Enabled = True
                    FormMantProvisiones.btnborrar.Enabled = True
                    FormMantProvisiones.btndocu.Enabled = True
                    FormMantProvisiones.btnmodificar.Enabled = True
                End If
            ElseIf rdbfactrecp.Checked Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        dt = PROVISIONESBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text, lvbusqueda1.Items(i).SubItems(2).Text, txt_num.Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            Dim s As String
                            If cmbaf.SelectedIndex = 0 Then
                                s = "AFECTO"
                            Else
                                s = "INAFECTO"
                            End If
                            FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                     IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "",
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")))
                        Next
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
                Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                FormMantProvisiones.txtnomproveedor.Text = prov1
                'verificar
                FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                FormMantProvisiones.txtnom_moneda.Text = prov1
                If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.txtser_doc_ref.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                    FormMantProvisiones.btnagregar.Enabled = True
                    FormMantProvisiones.btnborrar.Enabled = True
                    FormMantProvisiones.btndocu.Enabled = True
                    FormMantProvisiones.btnmodificar.Enabled = True
                End If
                'End If
            ElseIf rdbfactComp.Checked Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        dt = PROVISIONESBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text, lvbusqueda1.Items(i).SubItems(2).Text, txt_num.Text)
                        For Each row As DataRow In dt.Rows
                            contador = contador + 1
                            Dim s As String
                            If cmbaf.SelectedIndex = 0 Then
                                s = "AFECTO"
                            Else
                                s = "INAFECTO"
                            End If
                            FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                     IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                     IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "",
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                                     IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")))
                            If i = 1 Then
                                FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                                FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                            End If
                        Next
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
            Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
            FormMantProvisiones.txtnomproveedor.Text = prov1
            'verificar
            FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
            FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                     FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
            FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
            prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
            FormMantProvisiones.txtnom_moneda.Text = prov1
            If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                FormMantProvisiones.txtser_doc_ref.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                FormMantProvisiones.btnagregar.Enabled = True
                FormMantProvisiones.btnborrar.Enabled = True
                FormMantProvisiones.btndocu.Enabled = True
                FormMantProvisiones.btnmodificar.Enabled = True
            End If
        End If
        Else
            MsgBox("No ha marcado documentos para pasar")
        End If
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If lvbusqueda1.Visible = True Then
            If chkmarcar.Checked Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = False Then
                        lvbusqueda1.Items(i).Checked = True
                    End If

                Next
            Else
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        lvbusqueda1.Items(i).Checked = False
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub lvbusqueda1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda1.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
        Dim contador As Integer = 0
        Dim tpreciouni As Double
        Dim tpreciounid As Double
        Dim igvprecio As Double
        Dim igvpreciod As Double
        Dim nro_prov As String
        Dim dt As DataTable
        If FormMantProvisiones.dgvt_doc.Rows.Count > 0 Then
            If lvbusqueda1.Items(e.Index).Checked = True Then
                Exit Sub
            Else
                For i = 0 To FormMantProvisiones.dgvt_doc.Rows.Count - 1
                    If FormMantProvisiones.dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = lvbusqueda1.Items(e.Index).SubItems(2).Text Then
                        'lvbusqueda1.Items(e.Index).Checked = False
                        MsgBox("Este Documento ya se encuentra listado")
                        Exit Sub
                    End If
                Next
            End If
        End If
        If gnOpcion3 = "0" Then
            'VERIFICAR ESTO
            'Dim contador As Integer = 0
            If rdboreq.Checked Then
                Dim cmb As Double
                Dim mesfecha As String
                Dim mesdia As String
                dt = PROVISIONESBL.getListdgv2(lvbusqueda1.Items(e.Index).SubItems(0).Text, lvbusqueda1.Items(e.Index).SubItems(1).Text, lvbusqueda1.Items(e.Index).SubItems(2).Text)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    Dim s As String
                    If cmbaf.SelectedIndex = 0 Then
                        s = "AFECTO"
                    Else
                        s = "INAFECTO"
                    End If

                    Dim fecprov As String = Replace(FormMantProvisiones.txtmskfecprov.Text, "/", "")
                    Dim fecprov1 As String = Replace(fecprov, "_", "")
                    Dim fecprov2 As String = Replace(fecprov1, " ", "")
                    'contador = 0
                    Try
                        FormMantProvisiones.txtmskfecprov.Text = CDate(FormMantProvisiones.txtmskfecprov.Text)
                    Catch ex As Exception
                        'MsgBox(Replace(fecprov, "_", "").Length)
                        'MsgBox(fecprov2.Length)
                        'contador = contador + 1
                        'If contador = 1 Then
                        If fecprov2.Length < 10 And fecprov2.Length > 0 Then
                            MsgBox("Completa la fecha")
                            FormMantProvisiones.txtmskfecprov.Focus()
                        End If
                        'Else
                        '    Exit Sub
                        '    'txtmskfecprov.Focus()
                        'End If
                    End Try
                    If Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2) = "1" Then
                        mesfecha = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                    Else
                        mesfecha = Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                    End If
                    If Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2) = "1" Then
                        mesdia = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                    Else
                        mesdia = Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                    End If
                    dt = REQUERIMIENTOBL.getT_CAMB(Mid(FormMantProvisiones.txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                    For Each Registro In dt.Rows
                        cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                    Next

                    For i = 0 To FormMantProvisiones.dgvt_doc.Rows.Count - 1
                        FormMantProvisiones.dgvt_doc.Rows(i).Cells("T_CAMB").Value = cmb
                    Next
                    If FormMantProvisiones.txtmoneda.Text = "00" Then
                        If IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) > 0 Then
                            tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                            tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), 2)
                            igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                            igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")) * 0.18, 2)
                        Else
                            tpreciouni = 0
                            tpreciounid = 0
                            igvpreciod = 0
                            igvprecio = 0
                        End If
                    Else
                        If IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) > 0 Then
                            tpreciounid = 0
                            tpreciouni = 0
                            igvpreciod = 0
                            igvprecio = 0
                        End If
                        tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                        tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), 2)
                        igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                        igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")) * 0.18, 2)
                    End If
                    If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "50" Or IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "21" Then
                        nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                    End If
                    Dim igv As Double
                    If IIf(IsDBNull(row("IGV")), 0, row("IGV")) = 0 Then
                        igv = 18
                    Else
                        igv = IIf(IsDBNull(row("IGV")), 0, row("IGV"))
                    End If
                    FormMantProvisiones.dgvt_doc.Rows.Add(FormMantProvisiones.txtt_doc.Text, FormMantProvisiones.txtser_doc_ref.Text, FormMantProvisiones.txtnumero.Text,
                                                         IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                          IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),
                                                         s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                         IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), ARTICULOBL.SelectUniMed(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))),
                                                         tpreciouni, tpreciounid, 'IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                         igv, igvprecio, 'IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                         IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                         IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")),
                                                         igvpreciod, 'IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")),
                                                         IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                         FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), 0, row("PROVEEDOR")), 0, 0, 0,
                                                         0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")),
                                                         IIf(IsDBNull(row("NOM_ART")), 0, row("NOM_ART")))
                    Dim prov1 As String
                    If contador = 1 Then
                        FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                        FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                        FormMantProvisiones.txtproveedor.Text = lvbusqueda1.Items(e.Index).SubItems(3).Text
                        prov1 = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                        FormMantProvisiones.txtnomproveedor.Text = prov1
                        FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                        prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                        FormMantProvisiones.txtnom_moneda.Text = prov1
                        FormMantProvisiones.txtobserva.Text = IIf(IsDBNull(row("OBSERVACION")), "", row("OBSERVACION"))
                    End If
                Next
            ElseIf rdbfactrecp.Checked Then
                'verificar 01-08-2019
                Dim cmb As Double
                Dim mesfecha As String
                Dim mesdia As String
                dt = PROVISIONESBL.getListdgv1(lvbusqueda1.Items(e.Index).SubItems(0).Text, lvbusqueda1.Items(e.Index).SubItems(1).Text, lvbusqueda1.Items(e.Index).SubItems(2).Text, txt_num.Text)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    Dim s As String
                    If cmbaf.SelectedIndex = 0 Then
                        s = "AFECTO"
                    Else
                        s = "INAFECTO"
                    End If
                    If FormMantProvisiones.txtmoneda.Text = "00" Then

                        If Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2) = "1" Then
                                mesfecha = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                            Else
                                mesfecha = Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                            End If
                            If Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2) = "1" Then
                                mesdia = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                            Else
                                mesdia = Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                            End If
                            dt = REQUERIMIENTOBL.getT_CAMB(Mid(FormMantProvisiones.txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                            For Each Registro In dt.Rows
                                cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                            Next

                            tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                            tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / cmb, 2)
                            igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                            igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / cmb * 0.18, 2)
                        Else
                            tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                        tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * cmb, 2)
                        igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                        igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * cmb * 0.18, 2)
                    End If
                    If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "50" Or IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "21" Then
                        nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                    End If
                    FormMantProvisiones.txtobserva.Text = IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA"))


                    FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), nro_prov,
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                     IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1") & "-" & contador),
                                                     IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), ARTICULOBL.SelectUniMed(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))),
                                                     tpreciouni, tpreciounid,'IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), igvprecio,'IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     cmb,
                                                     IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), igvpreciod,'IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), 
                                                     IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")),
                                                     IIf(IsDBNull(row("NOM_ART")), 0, row("NOM_ART")))
                    If contador = 1 Then
                        FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                        FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                        MsgBox(Mid(FormMantProvisiones.txtmskfecgene.Text, 3, 2))
                        If Mid(FormMantProvisiones.txtmskfecgene.Text, 3, 2) <> "/" Then
                            FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value, 1, 3),
                            FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                            FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value, 1, 3),
                            FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                        End If
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
                Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                FormMantProvisiones.txtnomproveedor.Text = prov1

                'verificar
                If gnOpcion = "0" Then
                    FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value, 1, 3),
                    FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                    FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value, 1, 3),
                    FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                End If

                'MUESTRA TIPO DE CAMBIO
                'Dim cmb As Double
                'Dim mesfecha As String
                'Dim mesdia As String
                If Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2) = "1" Then
                    mesfecha = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                Else
                    mesfecha = Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                End If
                If Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2) = "1" Then
                    mesdia = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                Else
                    mesdia = Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                End If
                dt = REQUERIMIENTOBL.getT_CAMB(Mid(FormMantProvisiones.txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                For Each Registro In dt.Rows
                    cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next

                For i = 0 To FormMantProvisiones.dgvt_doc.Rows.Count - 1
                    FormMantProvisiones.dgvt_doc.Rows(i).Cells("T_CAMB").Value = cmb
                Next

                'CARGA LOS DEMAS CAMPOS
                FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                FormMantProvisiones.txtnom_moneda.Text = prov1
                If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    If FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value <> "CLL" Then
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    End If
                    FormMantProvisiones.txtser_doc_ref.Text = nro_prov
                    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                    FormMantProvisiones.btnagregar.Enabled = True
                    FormMantProvisiones.btnborrar.Enabled = True
                    FormMantProvisiones.btndocu.Enabled = True
                    FormMantProvisiones.btnmodificar.Enabled = True
                End If
                'End If
            ElseIf rdbfactComp.Checked Then
                Dim cmb As Double
                Dim mesfecha As String
                Dim mesdia As String
                dt = PROVISIONESBL.getListdgv6(lvbusqueda1.Items(e.Index).SubItems(0).Text, lvbusqueda1.Items(e.Index).SubItems(1).Text, lvbusqueda1.Items(e.Index).SubItems(2).Text, lvbusqueda1.Items(e.Index).SubItems(3).Text)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    Dim s As String
                    If cmbaf.SelectedIndex = 0 Then
                        s = "AFECTO"
                    Else
                        s = "INAFECTO"
                    End If
                    If FormMantProvisiones.txtmoneda.Text = "00" Then
                        'FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value, 1, 3),
                        'FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value)
                        'FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value, 1, 3),
                        'FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value)
                        If Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2) <> "" Then
                            If Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2).Length = "1" Then
                                mesfecha = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2).PadLeft(1, "0")
                            Else
                                mesfecha = Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                            End If
                            If Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2).Length = "1" Then
                                mesdia = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                            Else
                                mesdia = Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                            End If
                            dt = REQUERIMIENTOBL.getT_CAMB(Mid(FormMantProvisiones.txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                            For Each Registro In dt.Rows
                                cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                            Next
                        End If
                        tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                        tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / cmb, 2)
                        igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                        igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / cmb * 0.18, 2)
                    Else
                        tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                        tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * cmb, 2)
                        igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                        igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * cmb * 0.18, 2)
                    End If
                    If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "50" Or IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "21" Then
                        nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                    End If
                    FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), nro_prov,
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                     IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF") & "-" & contador),
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), ARTICULOBL.SelectUniMed(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))),
                                                     tpreciouni, tpreciounid,'IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), igvprecio,'IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     cmb,
                                                     IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), igvpreciod,'IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), 
                                                     IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")),
                                                     IIf(IsDBNull(row("NOM_ART")), 0, row("NOM_ART")))
                    If contador = 1 Then
                        FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                        FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                    End If
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("CTCT_COD").Value
                Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                FormMantProvisiones.txtnomproveedor.Text = prov1

                'verificar
                FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value, 1, 3),
                FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value)
                FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value, Mid(FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value, 1, 3),
                FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value)

                'MUESTRA TIPO DE CAMBIO
                'Dim cmb As Double
                'Dim mesfecha As String
                'Dim mesdia As String
                If Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2) = "1" Then
                    mesfecha = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                Else
                    mesfecha = Mid(FormMantProvisiones.txtmskfecgene.Text, 4, 2)
                End If
                If Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2) = "1" Then
                    mesdia = "0" & Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                Else
                    mesdia = Mid(FormMantProvisiones.txtmskfecgene.Text, 1, 2)
                End If
                dt = REQUERIMIENTOBL.getT_CAMB(Mid(FormMantProvisiones.txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                For Each Registro In dt.Rows
                    cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next

                For i = 0 To FormMantProvisiones.dgvt_doc.Rows.Count - 1
                    FormMantProvisiones.dgvt_doc.Rows(i).Cells("T_CAMB").Value = cmb
                Next

                'CARGA LOS DEMAS CAMPOS
                FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                FormMantProvisiones.txtnom_moneda.Text = prov1
                If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    If FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value <> "CLL" Then
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    End If
                    FormMantProvisiones.txtser_doc_ref.Text = nro_prov
                    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                    FormMantProvisiones.btnagregar.Enabled = True
                    FormMantProvisiones.btnborrar.Enabled = True
                    FormMantProvisiones.btndocu.Enabled = True
                    FormMantProvisiones.btnmodificar.Enabled = True
                End If
            End If

        Else
            'verificar
            dt = PROVISIONESBL.getListdgv5(lvbusqueda1.Items(e.Index).SubItems(0).Text, lvbusqueda1.Items(e.Index).SubItems(1).Text, lvbusqueda1.Items(e.Index).SubItems(2).Text, lvbusqueda1.Items(e.Index).SubItems(3).Text)
            For Each row As DataRow In dt.Rows
                contador = contador + 1
                Dim s As String
                If cmbaf.SelectedIndex = 0 Then
                    s = "AFECTO"
                Else
                    s = "INAFECTO"
                End If
                If FormMantProvisiones.txtmoneda.Text = "00" Then
                    'preciounid = IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) *
                    tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                    tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), 2)
                    igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                    igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")) * 0.18, 2)
                Else
                    tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                    tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), 2)
                    igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                    igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")) * 0.18, 2)
                End If
                If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "50" Or IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "21" Then
                    nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                    nro_prov = nro_prov.PadLeft(4, "0")
                Else
                    nro_prov = IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF"))
                End If

                FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), nro_prov,
                                                     IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                     IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1") & "-" & contador),
                                                     IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "",
                                                     s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                     IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), ARTICULOBL.SelectUniMed(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))),
                                                     tpreciouni, tpreciounid,'IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                     IIf(IsDBNull(row("IGV")), 0, row("IGV")), igvprecio,'IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                     IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), igvpreciod,'IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), 
                                                     IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                     FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                     0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")),
                                                      IIf(IsDBNull(row("NOM_ART")), 0, row("NOM_ART")))
                If contador = 1 Then
                    FormMantProvisiones.txtt_pago.Text = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                    FormMantProvisiones.cmbt_pago.SelectedValue = IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT"))
                End If
            Next
            FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
            Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
            FormMantProvisiones.txtnomproveedor.Text = prov1

            'verificar
            FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
            FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
            FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
            FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)

            FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
            prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
            FormMantProvisiones.txtnom_moneda.Text = prov1
            If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                If FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value <> "CLL" Then
                    nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    nro_prov = nro_prov.PadLeft(4, "0")
                Else
                    nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                End If
                FormMantProvisiones.txtser_doc_ref.Text = nro_prov
                FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                FormMantProvisiones.btnagregar.Enabled = True
                FormMantProvisiones.btnborrar.Enabled = True
                FormMantProvisiones.btndocu.Enabled = True
                FormMantProvisiones.btnmodificar.Enabled = True
            End If
        End If
    End Sub

    Private Sub rdbrdoc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbrdoc.CheckedChanged
        If rdbrdoc.Checked = True Then
            lvbusqueda1.Items.Clear()
            lvbusqueda2.Items.Clear()
            Me.lvbusqueda1.Visible = False
            Me.lvbusqueda2.Visible = True
        End If
    End Sub

    Private Sub rdboreq_CheckedChanged(sender As Object, e As EventArgs) Handles rdboreq.CheckedChanged
        If rdboreq.Checked = True Then
            lvbusqueda1.Items.Clear()
            lvbusqueda2.Items.Clear()
            Me.lvbusqueda1.Visible = True
            Me.lvbusqueda2.Visible = False
        End If
    End Sub

    Private Sub rdbfactrecp_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfactrecp.CheckedChanged
        If rdbfactrecp.Checked = True Then
            lvbusqueda1.Items.Clear()
            lvbusqueda2.Items.Clear()
            Me.lvbusqueda1.Visible = True
            Me.lvbusqueda2.Visible = False
        End If
    End Sub

    Private Sub lvbusqueda2_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda2.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
        Dim tpreciouni As Double
        Dim tpreciounid As Double
        Dim igvprecio As Double
        Dim igvpreciod As Double
        Dim contador As Integer = 0
        Dim dt As DataTable
        Dim nro_prov As String
        If Label2.Text <> 0 Then

            If rdbrdoc.Checked Then
                'Verificar
                dt = PROVISIONESBL.getListdgv4(lvbusqueda2.Items(e.Index).SubItems(0).Text, lvbusqueda2.Items(e.Index).SubItems(1).Text, lvbusqueda2.Items(e.Index).SubItems(2).Text, lvbusqueda2.Items(e.Index).SubItems(6).Text)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    Dim s As String
                    If cmbaf.SelectedIndex = 0 Then
                        s = "AFECTO"
                    Else
                        s = "INAFECTO"
                    End If
                    If FormMantProvisiones.txtmoneda.Text = "00" Then
                        'preciounid = IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) *
                        tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                        tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), 2)
                        igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                        igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) / IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")) * 0.18, 2)
                    Else
                        tpreciounid = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), 2)
                        tpreciouni = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), 2)
                        igvpreciod = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * 0.18, 2)
                        igvprecio = Math.Round(IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")) * IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")) * IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")) * 0.18, 2)
                    End If
                    If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "50" Or IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) <> "21" Then
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    End If
                    FormMantProvisiones.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), nro_prov,
                                                             IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                             IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                             IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "",
                                                             s, IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                                             IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")), "+", "20100279348", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), ARTICULOBL.SelectUniMed(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))),
                                                             tpreciouni, tpreciounid,'IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")),
                                                             IIf(IsDBNull(row("IGV")), 0, row("IGV")), igvprecio,'IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                             IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                             IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), igvpreciod,'IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), 
                                                             IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                             FormMantProvisiones.txtmskfecgene.Text, gsUser, RTrim(Date.Now), IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")), 0, 0, 0,
                                                             0, 0, 0, 0, 0, 0, IIf(IsDBNull(row("UPRECIO_AFECTOS")), 0, row("UPRECIO_AFECTOS")), IIf(IsDBNull(row("UPRECIO_AFECTOD")), 0, row("UPRECIO_AFECTOD")))
                Next
                FormMantProvisiones.txtproveedor.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("PROVEEDOR").Value
                Dim prov1 As String = PROVISIONESBL.SelectT_Prov(FormMantProvisiones.txtproveedor.Text)
                FormMantProvisiones.txtnomproveedor.Text = prov1
                FormMantProvisiones.txtmskfecgene.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                         FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                FormMantProvisiones.txtmskfecprov.Text = PROVISIONESBL.Select_Fecha(FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF1").Value, FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value,
                                                         FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value)
                FormMantProvisiones.txtmoneda.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("MONEDA").Value
                prov1 = PROVISIONESBL.Select_MON_row(FormMantProvisiones.txtmoneda.Text)
                FormMantProvisiones.txtnom_moneda.Text = prov1
                If FormMantProvisiones.txtt_doc.TextLength = 0 And FormMantProvisiones.txtser_doc_ref.TextLength = 0 And FormMantProvisiones.txtnumero.TextLength = 0 Then
                    FormMantProvisiones.txtt_doc.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    FormMantProvisiones.cmbt_doc.SelectedValue = FormMantProvisiones.dgvt_doc.Rows(0).Cells("T_DOC_REF").Value
                    If FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value <> "CLL" Then
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                        nro_prov = nro_prov.PadLeft(4, "0")
                    Else
                        nro_prov = FormMantProvisiones.dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value
                    End If
                    FormMantProvisiones.txtser_doc_ref.Text = nro_prov
                    FormMantProvisiones.txtnumero.Text = FormMantProvisiones.dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value
                    FormMantProvisiones.btnagregar.Enabled = True
                    FormMantProvisiones.btnborrar.Enabled = True
                    FormMantProvisiones.btndocu.Enabled = True
                    FormMantProvisiones.btnmodificar.Enabled = True
                End If
            End If

        End If
    End Sub

    Private Sub txt_num_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num.KeyDown
        If e.KeyValue = Keys.Enter Then
            If gnOpcion3 = "0" Then
                If rdbrdoc.Checked Then
                    If dtpfecha.Checked Then
                        lvbusqueda2.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda2.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")))
                            Next
                        Else
                            item = lvbusqueda1.Items.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("No hay Data para la busqueda realizada")

                        End If
                    Else
                        'If dtpfecha.Checked Then
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda2.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")))
                            Next
                        Else
                            item = lvbusqueda1.Items.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("No hay Data para la busqueda realizada")

                        End If
                        'End If
                    End If
                ElseIf rdboreq.Checked Then
                    If dtpfecha.Checked Then
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list4(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                                item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            Next
                        Else
                            item = lvbusqueda1.Items.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("No hay Data para la busqueda realizada")

                        End If
                    Else
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list3(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                                item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            Next
                        Else
                            item = lvbusqueda1.Items.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                            item.SubItems.Add("No hay Data para la busqueda realizada")

                        End If
                    End If
                ElseIf rdbfactrecp.Checked Then
                    If dtpfecha.Checked Then
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list5(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            Next
                        End If
                    Else
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list5(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_rEF1")))
                                item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            Next
                        End If
                    End If
                End If
            Else
                If rdbfactrecp.Checked Then
                    If dtpfecha.Checked Then
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list8(txtt_doc.Text, txtser_doc.Text, txt_num.Text, dtpfecha.Value)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                                item.SubItems.Add(IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            Next
                        End If
                    Else
                        lvbusqueda1.Items.Clear()
                        Dim dt As DataTable
                        Dim item As ListViewItem
                        Dim var1, var2, var3 As String

                        Dim fec As Date = Nothing
                        fec = dtpfecha.Value

                        dt = PROVISIONESBL.list7(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                        If dt.Rows.Count > 0 Then
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                                'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                                item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                            Next
                        End If
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub rdbfactComp_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfactComp.CheckedChanged
        If rdbfactComp.Checked = True Then
            lvbusqueda1.Items.Clear()
            lvbusqueda2.Items.Clear()
            Me.lvbusqueda1.Visible = True
            Me.lvbusqueda2.Visible = False
        End If
    End Sub

End Class
