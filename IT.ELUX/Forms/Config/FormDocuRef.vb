Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuRef
    Private gpCaption As String
    Private ARTICULOBL As New ARTICULOBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private LETRASBL As New LETRASBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private observa1 As String
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormDocuRef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpCaption = "Documento Referencia"
        Me.Text = gpCaption
        If gsCode = 0 Then
            lvbusqueda.Visible = True
            lvbusqueda1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            CheckBox1.Visible = True
            chkpendiente.Visible = True
            Dim dt As DataTable = ARTICULOBL.getListcmb13()
            GetCmb("cod", "nom", dt, cmbc_costo)
            cmbc_costo.Visible = True
            If sMov = "0" Then
                lvbusqueda.Visible = False
                lvbusqueda1.Visible = True
            End If
        ElseIf gsCode = 1 Then
            lvbusqueda.Visible = False
            lvbusqueda1.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            cmbc_costo.Visible = True
            chkpendiente.Visible = False
        ElseIf gsCode = 2 Then
            lvbusqueda.Visible = True
            lvbusqueda1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            chkpendiente.Visible = True
            Dim dt As DataTable = ARTICULOBL.getListcmb13()
            GetCmb("cod", "nom", dt, cmbc_costo)
            cmbc_costo.Visible = True

        ElseIf gsCode = 3 Then
            lvbusqueda.Visible = True
            lvbusqueda1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            chkpendiente.Visible = True
            Dim dt As DataTable = ARTICULOBL.getListcmb13()
            GetCmb("cod", "nom", dt, cmbc_costo)
            cmbc_costo.Visible = True

        ElseIf gsCode = 4 Then
            lvbusqueda.Visible = True
            lvbusqueda1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            CheckBox1.Visible = True
            chkpendiente.Visible = True
            Dim dt As DataTable = ARTICULOBL.getListcmb13()
            GetCmb("cod", "nom", dt, cmbc_costo)
            cmbc_costo.Visible = True
            If sMov = "0" Then
                lvbusqueda.Visible = False
                lvbusqueda1.Visible = True
            End If
            If FormMantGuiaAlmacen.txtt_movinv.Text = "E26" Then
                Dim item As ListViewItem
                Dim fec As Date = Nothing
                fec = FormMantGuiaAlmacen.dtpfecha.Value
                dt = GUIAALMACENBL.list8("", "", "", fec, FormMantGuiaAlmacen.txtc_costo.Text)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add("")
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                Next
            ElseIf FormMantGuiaAlmacen.txtt_movinv.Text = "E12" Then
                Dim item As ListViewItem
                Dim fec As Date = Nothing
                fec = FormMantGuiaAlmacen.dtpfecha.Value
                dt = GUIAALMACENBL.list9("", "", "", fec, FormMantGuiaAlmacen.txtc_costo.Text)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add("")
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                Next
                ' *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** '
            ElseIf FormMantGuiaAlmacen.txtt_movinv.Text = "E17" Then
                Dim item As ListViewItem
                Dim fec As Date = FormMantGuiaAlmacen.dtpfecha.Value
                fec = FormMantGuiaAlmacen.dtpfecha.Value
                dt = GUIAALMACENBL.list10("", "", "", fec, FormMantGuiaAlmacen.txtc_costo.Text)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add("")
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                Next
                ' *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** '
            End If
        ElseIf gsCode = 5 Then
            lvbusqueda.Visible = False
            lvbusqueda1.Visible = False
            lvreq.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            CheckBox1.Visible = True
            chkpendiente.Visible = True
            Label1.Visible = False
            dtpfecha.Visible = False
            chkart.Visible = True
            txtart.Visible = True
            Button1.Visible = True
        End If
        'lvbusqueda.CheckBoxes = True
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDocuRef_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        lvbusqueda.Items.Clear()
        'lvbusqueda1.Items.Clear()
        If txtt_doc.Text = "SOLM" And sMov = "0" Then
            lvbusqueda.Visible = False
            lvbusqueda1.Visible = True
        Else
            If gsCode = 0 Then
                lvbusqueda.Visible = True
                lvbusqueda1.Visible = False
            ElseIf gsCode = 1 Then
                lvbusqueda.Visible = False
                lvbusqueda1.Visible = True
            End If
        End If
        Dim GUIAALMACENBL As New GUIAALMACENBL

        Dim dt As DataTable
        Dim sPasar As String
        Dim contador As Integer = 0
        Dim contador1 As Integer = 0
        Dim item As ListViewItem
        Dim REQUERIMIENTOBL As New REQUERIMIENTOBL
        Dim SOLMATERIALESBL As New SOLMATERIALESBL
        Dim fec As Date = Nothing
        If gsCode = 0 Or gsCode = 2 Then
            If dtpfecha.Checked Then
                fec = dtpfecha.Value
                If chkpendiente.Checked = False Then
                    If txtt_doc.Text = "SOLM" Then
                        If sMov = "0" Then
                            dt = SOLMATERIALESBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec, FormMantGuiaAlmacen.txtc_costo.Text)
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                                item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                                item.SubItems.Add(IIf(IsDBNull(row("art_cod")), "", row("art_cod")))
                                item.SubItems.Add(IIf(IsDBNull(row("nom_art")), "", row("nom_art")))
                                item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                                item.SubItems.Add(IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))
                                item.SubItems.Add(IIf(IsDBNull(row("NUMOP")), "", row("NUMOP")))
                            Next
                        Else
                            MsgBox("El tipo de movimiento no es una salida, favor de cambiar el tipo de movimiento")
                        End If
                    Else
                        dt = GUIAALMACENBL.list(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                            item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                            item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                            item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                            item.SubItems.Add(IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod")))
                            item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                        Next
                    End If

                Else

                    dt = GUIAALMACENBL.list5(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                    For Each row As DataRow In dt.Rows
                        item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                        item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                        item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                        item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                        item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                        item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                        item.SubItems.Add("")
                        item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                    Next

                End If
            Else
                If chkpendiente.Checked = False Then
                    If txtt_doc.Text = "SOLM" Then
                        If sMov = "0" Then
                            dt = SOLMATERIALESBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text, FormMantGuiaAlmacen.txtc_costo.Text)
                            For Each row As DataRow In dt.Rows
                                item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                                item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                                item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                                item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                                item.SubItems.Add(IIf(IsDBNull(row("art_cod")), "", row("art_cod")))
                                item.SubItems.Add(IIf(IsDBNull(row("nom_art")), "", row("nom_art")))
                                item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                                item.SubItems.Add(IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))
                                item.SubItems.Add(IIf(IsDBNull(row("NUMOP")), "", row("NUMOP")))
                            Next
                        Else
                            MsgBox("El tipo de movimiento no es una salida, favor de cambiar el tipo de movimiento")
                        End If
                    Else
                        dt = GUIAALMACENBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                        For Each row As DataRow In dt.Rows
                            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                            item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                            item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                            item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                            item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                            item.SubItems.Add(IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod")))
                            item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                        Next
                    End If
                Else

                    dt = GUIAALMACENBL.list4(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                    For Each row As DataRow In dt.Rows
                        item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                        item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                        item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                        item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                        item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                        item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                        item.SubItems.Add("")
                        item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                    Next


                End If
            End If
        ElseIf gsCode = "1" Then
            If dtpfecha.Checked Then
                fec = dtpfecha.Value
                dt = GUIAALMACENBL.list3(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    contador1 = contador - 1
                    item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("art_cod")), "", row("art_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("nom_art")), "", row("nom_art")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                    item.SubItems.Add(IIf(IsDBNull(row("T_doc_ref1")), "", row("T_doc_ref1")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref1")), "", row("ser_doc_ref1")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref1")), "", row("nro_doc_ref1")))
                    item.SubItems.Add(IIf(IsDBNull(row("cantidad")), "", row("cantidad")))
                    item.SubItems.Add(IIf(IsDBNull(row("act_cod")), "", row("act_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("unidad")), "", row("unidad")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("lote")), "", row("lote")))
                    item.SubItems.Add(IIf(IsDBNull(row("observa")), "", row("observa")))
                    sPasar = REQUERIMIENTOBL.sReqAprob(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                       IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                                       IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                        IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "155729857-2-2022")
                    If sPasar = "1" Then
                        lvbusqueda1.Items.Item(contador1).ForeColor = Color.Gold
                    ElseIf sPasar = "3" Then
                        lvbusqueda1.Items.Item(contador1).ForeColor = Color.Red
                    Else
                        lvbusqueda1.Items.Item(contador1).ForeColor = Color.Green
                    End If

                Next
            Else
                dt = GUIAALMACENBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    contador1 = contador - 1
                    item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("art_cod")), "", row("art_cod"))) '4
                    item.SubItems.Add(IIf(IsDBNull(row("nom_art")), "", row("nom_art"))) '5
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene"))) '6
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod"))) '7
                    item.SubItems.Add(IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod"))) '8
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est"))) '9
                    item.SubItems.Add(IIf(IsDBNull(row("T_doc_ref1")), "", row("T_doc_ref1"))) '10
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref1")), "", row("ser_doc_ref1"))) '11
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref1")), "", row("nro_doc_ref1"))) '12
                    item.SubItems.Add(IIf(IsDBNull(row("cantidad")), "", row("cantidad"))) '13
                    item.SubItems.Add(IIf(IsDBNull(row("act_cod")), "", row("act_cod"))) '14
                    item.SubItems.Add(IIf(IsDBNull(row("unidad")), "", row("unidad"))) '15
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod"))) '16
                    item.SubItems.Add(IIf(IsDBNull(row("lote")), "", row("lote"))) '17
                    item.SubItems.Add(IIf(IsDBNull(row("observa")), "", row("observa"))) '18
                    item.SubItems.Add(IIf(IsDBNull(row("art_venta")), "", row("art_venta"))) '19
                    sPasar = REQUERIMIENTOBL.sReqAprob(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                       IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                       IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                        IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "155729857-2-2022")
                    If sPasar = "1" Then
                        lvbusqueda1.Items.Item(contador1).ForeColor = Color.Gold
                    ElseIf sPasar = "3" Then
                        lvbusqueda1.Items.Item(contador1).ForeColor = Color.Red
                    Else
                        lvbusqueda1.Items.Item(contador1).ForeColor = Color.Green
                    End If
                Next
            End If

        ElseIf gsCode = "3" Then

            If dtpfecha.Checked Then
                fec = dtpfecha.Value
                dt = GUIAALMACENBL.list7(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add("")
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                Next
            Else
                dt = GUIAALMACENBL.list6(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                    item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                    item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod")))
                    item.SubItems.Add(IIf(IsDBNull(row("est")), "", row("est")))
                Next
            End If
        ElseIf gsCode = "5" Then
            dt = GUIAALMACENBL.listreq(txtt_doc.Text, txtser_doc.Text, txt_num.Text, txtart.Text)
            For Each row As DataRow In dt.Rows
                item = lvreq.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("art_cod")), "", row("art_cod")))
                item.SubItems.Add(IIf(IsDBNull(row("nomart")), "", row("nomart")))
                item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                item.SubItems.Add(IIf(IsDBNull(row("cco_cod")), "", row("cco_cod")))
                item.SubItems.Add(IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod")))
            Next
        End If
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim i As Int32 = 0
        Dim cont1 As Integer = 0
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim GUIAALMACENBL As New GUIAALMACENBL
        Dim SOLMATERIALESBL As New SOLMATERIALESBL
        Dim contador As Integer = 0
        Dim sValor As String = ""
        Dim Variable As String = ""
        If gsCode = "0" Then
            If Label2.Text <> 0 Then
                If lvbusqueda.Visible = True Then
                    Dim s As Integer = 0
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            If chkpendiente.Checked = False Then

                                If Mid(lvbusqueda.Items(i).SubItems(0).Text, 1, 1) = "P" Then
                                    dt = GUIAALMACENBL.getListdgv1(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, Trim(sest1))
                                    For Each row As DataRow In dt.Rows

                                        '--1
                                        For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                            If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                                s = s + 1
                                            End If
                                        Next
                                        '--
                                        If s = 0 Then
                                            contador = contador + 1
                                            FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                         FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                         IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                         IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text,
                                                                         IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                                         IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                                         IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                         FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                         RTrim(Date.Now), "155729857-2-2022", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                         FormMantGuiaAlmacen.cmbestado.Text)
                                            If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) = "OREQ" Or contador = 1 Then
                                                'FormMantGuiaAlmacen.txtobserva1.Text = FormMantGuiaAlmacen.txtobserva1.Text & IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) & "-" & IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")) & "-" & IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) & ","
                                            End If
                                        End If
                                    Next
                                Else
                                    If txtt_doc.Text = "SOLM" Then
                                        dt = SOLMATERIALESBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text)
                                        For Each row As DataRow In dt.Rows
                                            '--1
                                            For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                                If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                                    s = s + 1
                                                End If
                                            Next
                                            '--

                                            If FormMantGuiaAlmacen.dgvt_doc.Rows.Count > 0 Then
                                                For j = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                                    If FormMantGuiaAlmacen.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) Then
                                                        Variable = "1"
                                                    End If
                                                Next
                                            End If
                                            If s = 0 Then
                                                If Variable <> "1" Then
                                                    FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                                     FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                                    IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                                     IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                                     "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                                     RTrim(Date.Now), "155729857-2-2022", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                                     FormMantGuiaAlmacen.cmbestado.Text)
                                                End If
                                            End If
                                            Variable = ""
                                            cont1 = cont1 + 1
                                            If cont1 = 1 Then
                                                FormMantGuiaAlmacen.txtc_costo.Text = IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD"))
                                                FormMantGuiaAlmacen.cmbc_costo.SelectedValue = IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD"))
                                                FormMantGuiaAlmacen.cmbdni.SelectedValue = IIf(IsDBNull(row("USUARIO_OK")), "", row("USUARIO_OK"))
                                                FormMantGuiaAlmacen.txtdni.Text = IIf(IsDBNull(row("USUARIO_OK")), "", row("USUARIO_OK"))
                                            End If
                                        Next
                                    Else
                                        dt = GUIAALMACENBL.getListdgv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                        FormMantGuiaAlmacen.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                        FormMantGuiaAlmacen.txtproveedor.Text = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                        FormMantGuiaAlmacen.cmbproveedor.SelectedValue = FormMantGuiaAlmacen.txtproveedor.Text
                                        For Each row As DataRow In dt.Rows
                                            '--1
                                            For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                                If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                                    s = s + 1
                                                End If
                                            Next
                                            '--
                                            If s = 0 Then
                                                contador = contador + 1
                                                FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                         FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                        IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                         IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                         "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                         RTrim(Date.Now), "155729857-2-2022", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                         FormMantGuiaAlmacen.cmbestado.Text)
                                                If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) = "OREQ" Or contador = 1 Then
                                                    'FormMantGuiaAlmacen.txtobserva1.Text = FormMantGuiaAlmacen.txtobserva1.Text & IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) & "-" & IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")) & "-" & IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) & ","
                                                End If
                                            End If

                                        Next
                                        If FormMantGuiaAlmacen.cmbt_movinv.SelectedValue = "E19" Then
                                            FormMantGuiaAlmacen.chk_m.Visible = True
                                            FormMantGuiaAlmacen.chk_m.Checked = True
                                        End If

                                    End If

                                End If
                            Else
                                If cmbc_costo.SelectedIndex <> -1 Then
                                    dt = GUIAALMACENBL.getListdgv3(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, cmbc_costo.SelectedValue)
                                Else
                                    dt = GUIAALMACENBL.getListdgv4(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                End If

                                For Each row As DataRow In dt.Rows

                                    '--1
                                    For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    '--
                                    If s = 0 Then
                                        contador = contador + 1
                                        FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                 FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                    IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                  IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, "", "", "", "", "+", IIf(IsDBNull(row("OBSERVA1")), "", row("OBSERVA1")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                 "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                 RTrim(Date.Now), "155729857-2-2022", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                 FormMantGuiaAlmacen.cmbestado.Text)
                                        If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) = "OREQ" Or contador = 1 Then
                                            ' FormMantGuiaAlmacen.txtobserva1.Text = FormMantGuiaAlmacen.txtobserva1.Text & IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) & "-" & IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")) & "-" & IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) & ","
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Next
                ElseIf lvbusqueda1.Visible = True Then
                    Dim s As Integer = 0
                    If txtt_doc.Text = "SOLM" Then
                        For i = 0 To lvbusqueda1.Items.Count - 1
                            If lvbusqueda1.Items(i).Checked = True Then
                                dt = SOLMATERIALESBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text)
                                For Each row As DataRow In dt.Rows
                                    For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    If FormMantGuiaAlmacen.dgvt_doc.Rows.Count > 0 Then
                                        For j = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                            If FormMantGuiaAlmacen.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) Then
                                                Variable = "1"
                                            End If
                                        Next
                                    End If
                                    If s = 0 Then
                                        If FormMantGuiaAlmacen.txtc_costo.TextLength = 0 Then

                                            If Variable <> "1" Then
                                                FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                         FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                        IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                         IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                         "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                         RTrim(Date.Now), "155729857-2-2022", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                         FormMantGuiaAlmacen.cmbestado.Text, "", IIf(IsDBNull(row("ART_ACT")), "", row("ART_ACT")))
                                            Else
                                                FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                         FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                         IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                         IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                         "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                         RTrim(Date.Now), "155729857-2-2022", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                         FormMantGuiaAlmacen.cmbestado.Text, "", IIf(IsDBNull(row("ART_ACT")), "", row("ART_ACT")))
                                            End If
                                        Else
                                            If IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")) = FormMantGuiaAlmacen.txtc_costo.Text Then
                                                If Variable <> "1" Then
                                                    FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                             FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                            IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                             IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                             "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                             RTrim(Date.Now), "155729857-2-2022", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                             FormMantGuiaAlmacen.cmbestado.Text, "", IIf(IsDBNull(row("ART_ACT")), "", row("ART_ACT")))
                                                Else
                                                    FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                             FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                             IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                             IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                             "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                             RTrim(Date.Now), "155729857-2-2022", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                             FormMantGuiaAlmacen.cmbestado.Text, "", IIf(IsDBNull(row("ART_ACT")), "", row("ART_ACT")))
                                                End If
                                            End If
                                        End If
                                    End If
                                    Variable = ""
                                    'articulo = IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1"))
                                    'End If
                                    cont1 = cont1 + 1
                                    If cont1 = 1 Then
                                        FormMantGuiaAlmacen.txtc_costo.Text = IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD"))
                                        FormMantGuiaAlmacen.cmbc_costo.SelectedValue = IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD"))
                                        FormMantGuiaAlmacen.txtdni.Text = IIf(IsDBNull(row("USUARIO_OK")), "", row("USUARIO_OK"))
                                        FormMantGuiaAlmacen.cmbdni.SelectedValue = IIf(IsDBNull(row("USUARIO_OK")), "", row("USUARIO_OK"))
                                    End If
                                Next
                            End If
                        Next
                    End If
                End If
            Else
                MsgBox("No ha marcado documentos para pasar")
            End If

        ElseIf gsCode = "1" Then
            Dim Val As Integer = 0
            If Label2.Text <> 0 Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then

                        'dt = GUIAALMACENBL.getListdgv(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text)
                        'For Each row As DataRow In dt.Rows
                        'sPasar = REQUERIMIENTOBL.sReqAprob(FormMantRequerimiento.txtt_doc.Text, FormMantRequerimiento.cmb_serdoc.Text, FormMantRequerimiento.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                        '                            IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), "155729857-2-2022")

                        If FormMantRequerimiento.dgvt_doc.Rows.Count > 0 Then
                            For j = 0 To FormMantRequerimiento.dgvt_doc.Rows.Count - 1
                                If FormMantRequerimiento.dgvt_doc.Rows(j).Cells("T_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(10).Text And FormMantRequerimiento.dgvt_doc.Rows(j).Cells("SER_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(11).Text And FormMantRequerimiento.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(12).Text And FormMantRequerimiento.dgvt_doc.Rows(j).Cells("ART_COD").Value = lvbusqueda1.Items(i).SubItems(4).Text Then '
                                    Val = 1
                                    'MsgBox("repetido")
                                End If
                            Next
                        End If

                        If Val = 0 Then
                            If lvbusqueda1.Items.Item(i).ForeColor = Color.Red Or lvbusqueda1.Items.Item(i).ForeColor = Color.Gold Then
                                MsgBox("El Requerimiento no ha sido aprobado o ah sido desaprobado")
                            Else
                                dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                                Dim cmb As Double = 0
                                'Dim frm As New FormMantDetFacturacion
                                For Each Registro In dt.Rows
                                    cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                                Next
                                FormMantRequerimiento.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda1.Items(i).SubItems(10).Text, lvbusqueda1.Items(i).SubItems(11).Text, Mid(lvbusqueda1.Items(i).SubItems(12).Text, 1, 7))
                                FormMantRequerimiento.txtdni.Text = GUIAALMACENBL.SelectDni(lvbusqueda1.Items(i).SubItems(10).Text, lvbusqueda1.Items(i).SubItems(11).Text, Mid(lvbusqueda1.Items(i).SubItems(12).Text, 1, 7))
                                FormMantRequerimiento.cmbdni.SelectedValue = FormMantRequerimiento.txtdni.Text
                                FormMantRequerimiento.dgvt_doc.Rows.Add(FormMantRequerimiento.txtt_doc.Text, FormMantRequerimiento.cmb_serdoc.Text,
                                                            FormMantRequerimiento.txtnumero.Text, lvbusqueda1.Items(i).SubItems(10).Text, lvbusqueda1.Items(i).SubItems(11).Text,
                                                            lvbusqueda1.Items(i).SubItems(12).Text, FormMantRequerimiento.txtproveedor.Text, lvbusqueda1.Items(i).SubItems(13).Text, lvbusqueda1.Items(i).SubItems(4).Text,
                                                            lvbusqueda1.Items(i).SubItems(5).Text, Nothing, lvbusqueda1.Items(i).SubItems(14).Text, "", "", "", "+", lvbusqueda1.Items(i).SubItems(18).Text, FormMantRequerimiento.txtt_movinv.Text, "", "", "", "", "", "",
                                                            "", "", "", FormMantRequerimiento.dtpfecha.Text, gsUser, lvbusqueda1.Items(i).SubItems(15).Text, FormMantRequerimiento.txtt_pago.Text, FormMantRequerimiento.txtfor_ent.Text,
                                                            RTrim(Date.Now), "20100279348", lvbusqueda1.Items(i).SubItems(16).Text, "", lvbusqueda1.Items(i).SubItems(17).Text, FormMantRequerimiento.txtdni.Text, "", "", "", "", "", "",
                                                            FormMantRequerimiento.cmbestado.Text, lvbusqueda1.Items(i).SubItems(19).Text)
                            End If
                            'Next
                        End If
                        Val = 0
                    End If
                    FormMantRequerimiento.txtc_costo.Text = lvbusqueda1.Items(i).SubItems(16).Text
                    FormMantRequerimiento.cmbc_costo.SelectedValue = FormMantRequerimiento.txtc_costo.Text
                Next

            Else
                MsgBox("No ah marcado ningun documento para pasar")
            End If

        ElseIf gsCode = "2" Then
            Dim s As Integer = 0
            'Dim articulo As String = ""
            If Label2.Text <> 0 Then
                If lvbusqueda.Visible = True Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            If chkpendiente.Checked = False Then
                                If Mid(lvbusqueda.Items(i).SubItems(0).Text, 1, 1) = "P" Then
                                    dt = GUIAALMACENBL.getListdgv1(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, Trim(sest1))
                                    For Each row As DataRow In dt.Rows

                                        '--1
                                        For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                            If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                                s = s + 1
                                            End If
                                        Next
                                        '--
                                        If s = 0 Then
                                            FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                     FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                     IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                     IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text,
                                                                     IIf(IsDBNull(row("TPRECIO_COMPRA")), 0, row("TPRECIO_COMPRA")), IIf(IsDBNull(row("TPRECIO_DCOMPRA")), 0, row("TPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                                     IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_COMPRA")), 0, row("UPRECIO_COMPRA")),
                                                                     IIf(IsDBNull(row("UPRECIO_DCOMPRA")), 0, row("UPRECIO_DCOMPRA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                     FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                     RTrim(Date.Now), "20100279348", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                     FormMantGuiaAlmacen.cmbestado.Text)
                                        End If
                                    Next
                                Else
                                    If txtt_doc.Text = "SOLM" Then
                                        dt = SOLMATERIALESBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text)
                                        For Each row As DataRow In dt.Rows
                                            '--1
                                            For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                                If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                                    s = s + 1
                                                End If
                                            Next
                                            '--

                                            If FormMantGuiaAlmacen.dgvt_doc.Rows.Count > 0 Then
                                                For j = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                                    If FormMantGuiaAlmacen.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) Then
                                                        Variable = "1"
                                                    End If

                                                Next
                                            End If
                                            If s = 0 Then
                                                If Variable <> "1" Then
                                                    FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                                     FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                                    IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                                     IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                                     "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                                     RTrim(Date.Now), "20100279348", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                                     FormMantGuiaAlmacen.cmbestado.Text)

                                                End If
                                            End If
                                            Variable = ""
                                        Next
                                    Else
                                        'dt = GUIADESPACHOBL.getListdgv_Gd(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                        FormMantGuiaDespacho.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                        'FormMantGuiaDespacho.txtctct_cod.Text = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                        FormMantGuiaDespacho.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))

                                        Dim smedida As String
                                        For Each row As DataRow In dt.Rows

                                            '--1
                                            For l = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
                                                If FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                                    s = s + 1
                                                End If
                                            Next
                                            '--
                                            If s = 0 Then
                                                FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                     FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                    IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")), IIf(IsDBNull(row("CANTIDAD")), "0", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                     IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), ARTICULOBL.getMedida(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", "", FormMantGuiaDespacho.dtpfecha.Text, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),
                                                                     IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")), "+", FormMantGuiaDespacho.txtt_movinv.Text, IIf(IsDBNull(row("TPRECIO_VENTA")), "0", row("TPRECIO_VENTA")), IIf(IsDBNull(row("TPRECIO_DVENTA")), "0", row("TPRECIO_DVENTA")), IIf(IsDBNull(row("IGV")), "0", row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), "0", row("IGV_IMPOR")), IIf(IsDBNull(row("T_CAMB")), "0", row("T_CAMB")), IIf(IsDBNull(row("UPRECIO_VENTA")), "0", row("UPRECIO_VENTA")),
                                                                     IIf(IsDBNull(row("UPRECIO_DVENTA")), "0", row("UPRECIO_DVENTA")), IIf(IsDBNull(row("IGV_DIMPOR")), "0", row("IGV_DIMPOR")), FormMantGuiaDespacho.txtmon.Text, FormMantGuiaDespacho.dtpfecha.Text, IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")), FormMantGuiaDespacho.txtt_pago.Text, FormMantGuiaDespacho.txtfor_ent.Text,
                                                                     RTrim(Date.Now), "20100279348", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")), IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")), "", "0", "0", FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))

                                            End If
                                        Next
                                    End If

                                End If
                            Else
                                If cmbc_costo.SelectedIndex <> -1 Then
                                    dt = GUIAALMACENBL.getListdgv3(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, cmbc_costo.SelectedValue)
                                Else
                                    dt = GUIAALMACENBL.getListdgv4(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                End If

                                For Each row As DataRow In dt.Rows
                                    '--1
                                    For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    '--
                                    If s = 0 Then
                                        FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                             FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                              IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, "", "", "", "", "+", IIf(IsDBNull(row("OBSERVA1")), "", row("OBSERVA1")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                             "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                             RTrim(Date.Now), "20100279348", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                             FormMantGuiaAlmacen.cmbestado.Text)
                                    End If
                                Next
                            End If
                        End If
                    Next
                ElseIf lvbusqueda1.Visible = True Then
                    If txtt_doc.Text = "SOLM" Then
                        For i = 0 To lvbusqueda1.Items.Count - 1
                            If lvbusqueda1.Items(i).Checked = True Then
                                dt = SOLMATERIALESBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text)
                                For Each row As DataRow In dt.Rows
                                    '--1
                                    For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    '--

                                    If FormMantGuiaAlmacen.dgvt_doc.Rows.Count > 0 Then
                                        For j = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                            If FormMantGuiaAlmacen.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) Then
                                                Variable = "1"
                                            End If

                                        Next
                                    End If
                                    If s = 0 Then
                                        If Variable <> "1" Then
                                            FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                                                 FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                                IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                                 IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", "", "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                                                 "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                                                 RTrim(Date.Now), "20100279348", FormMantGuiaAlmacen.txtc_costo.Text, "", "", FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                                                 FormMantGuiaAlmacen.cmbestado.Text)

                                        End If
                                    End If
                                    Variable = ""
                                Next
                            End If
                        Next
                    End If
                End If
            Else
                MsgBox("No ha marcado documentos para pasar")
            End If
        ElseIf gsCode = "3" Then
            Dim s As Integer = 0
            If sOp = "0" Then
                If Label2.Text <> 0 Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            Dim nro As String
                            FormMantGuiaDespacho.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantGuiaDespacho.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Try
                                FormMantGuiaDespacho.cmbmon.SelectedValue = GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Catch ex As Exception

                            End Try

                            If lvbusqueda.Items(i).SubItems(0).Text <> "OREQ" Then
                                FormMantGuiaDespacho.cmbt_movinv.SelectedValue = GUIAALMACENBL.SelectT_MOVINV(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Else
                                FormMantGuiaDespacho.cmbt_movinv.SelectedValue = "S32"
                            End If
                            FormMantGuiaDespacho.cmbt_pago.SelectedValue = GUIAALMACENBL.SelectF_PAGO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantGuiaDespacho.txtoc.Text = GUIAALMACENBL.SelectNUMPEDIDO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            nro = FACTURACIONBL.SelectNro4("09", "001")
                            Dim cmb As Double = 0
                            dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                            'Dim frm As New FormMantDetFacturacion
                            For Each Registro In dt.Rows
                                cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                            Next
                            If nro.Length = 3 Then
                                nro = "0000" & nro
                            ElseIf nro.Length = 4 Then
                                nro = "000" & nro
                            ElseIf nro.Length = 5 Then
                                nro = "00" & nro
                            ElseIf nro.Length = 6 Then
                                nro = "0" & nro
                            ElseIf nro.Length = 7 Then
                                nro = nro
                            End If

                            Dim uprecio_dventa As Double
                            Dim uprecio_venta As Double
                            Dim compras As Double
                            Dim comprad As Double
                            Dim precio_venta As Double
                            Dim precio_dventa As Double
                            Dim igvimpor As Double
                            Dim igv_dimpor As Double
                            Dim igv As Double
                            'txtnumero.Enabled = True
                            If FormMantGuiaDespacho.cmbmon.SelectedValue = "00" Then
                                dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)

                                For Each row As DataRow In dt.Rows
                                    '--1
                                    For l = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    '--
                                    If s = 0 Then
                                        If row("T_DOC_REF") = "OREQ" Then
                                            FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                                       FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                       IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaDespacho.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                       IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", '"F001",
                                                                                       IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")), "+", FormMantGuiaDespacho.txtt_movinv.Text,
                                                                                       0, 0, IIf(IsDBNull(row("IGV")), 0, row("IGV")), 0, cmb, 0,
                                                                                       0, 0, IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                                       FormMantGuiaDespacho.dtpfecha.Text, gsUser, IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                                       RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", "", 'nro,
                                                                                       "", "", "", "",
                                                                                       FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", "", "", Mid(RTrim(Date.Now), 1, 10), IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))
                                        Else

                                            If IIf(IsDBNull(row("IGV")), 0, row("IGV")) > 0 Then
                                                uprecio_dventa = Math.Round(row("UPRECIO_VENTA") / cmb, 6)
                                                compras = Math.Round((row("UPRECIO_VENTA") * row("CANTIDAD")) * (row("IGV") / 100) + row("UPRECIO_VENTA") * row("CANTIDAD"), 2)
                                                comprad = Math.Round(((row("UPRECIO_VENTA") * row("CANTIDAD")) * (row("IGV") / 100) + row("UPRECIO_VENTA") * row("CANTIDAD")) / cmb, 2)
                                                precio_venta = Math.Round(row("UPRECIO_VENTA") * row("CANTIDAD"), 2)
                                                precio_dventa = Math.Round(row("UPRECIO_VENTA") * row("CANTIDAD") / cmb, 2)
                                                igvimpor = Math.Round(compras - precio_venta, 2)
                                                igv_dimpor = Math.Round(comprad - precio_dventa, 2)
                                                FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                                       FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                                       IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaDespacho.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                       IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "F001",
                                                                                       IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")), "+", FormMantGuiaDespacho.txtt_movinv.Text, precio_venta, precio_dventa, IIf(IsDBNull(row("IGV")), 0, row("IGV")), igvimpor,
                                                                                       cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                                                       uprecio_dventa, igv_dimpor, IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                                       FormMantGuiaDespacho.dtpfecha.Text, gsUser, IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                                       RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", nro,
                                                                                       "", "", "", "",
                                                                                       FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", "", "", Mid(RTrim(Date.Now), 1, 10), IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))

                                            Else
                                                uprecio_dventa = Math.Round(row("UPRECIO_VENTA") / cmb, 6)
                                                compras = Math.Round((row("UPRECIO_VENTA") * row("CANTIDAD")), 2)
                                                comprad = Math.Round((row("UPRECIO_VENTA") * row("CANTIDAD")) / cmb, 2)
                                                precio_venta = Math.Round(row("UPRECIO_VENTA") * row("CANTIDAD"), 2)
                                                precio_dventa = Math.Round(row("UPRECIO_VENTA") * row("CANTIDAD") / cmb, 2)
                                                igvimpor = Math.Round(compras - precio_venta, 2)
                                                igv_dimpor = Math.Round(comprad - precio_dventa, 2)
                                                FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                                       FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                                       IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaDespacho.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                       IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "F001",
                                                                                       IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                                       "+", FormMantGuiaDespacho.txtt_movinv.Text, precio_venta, precio_dventa, IIf(IsDBNull(row("IGV")), 0, row("IGV")), igvimpor,
                                                                                       cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                                                       uprecio_dventa, igv_dimpor, IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                                       FormMantGuiaDespacho.dtpfecha.Text, gsUser, IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                                       RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", nro,
                                                                                       "", "", "", "",
                                                                                       FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", "", "", Mid(RTrim(Date.Now), 1, 10), IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))
                                            End If
                                        End If
                                    End If

                                Next
                            ElseIf FormMantGuiaDespacho.cmbmon.SelectedValue = "01" Then
                                dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                For Each row As DataRow In dt.Rows

                                    '--1
                                    For l = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    '--
                                    If s = 0 Then
                                        If row("T_DOC_REF") = "OREQ" Then
                                            FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                                       FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                                       IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaDespacho.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                                       IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", '"F001",
                                                                                       IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")), "+", FormMantGuiaDespacho.txtt_movinv.Text,
                                                                                       0, 0, IIf(IsDBNull(row("IGV")), 0, row("IGV")), 0, cmb, 0,
                                                                                       0, 0, IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                                       FormMantGuiaDespacho.dtpfecha.Text, gsUser, IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                                       RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", "", 'nro,
                                                                                       "", "", "", "",
                                                                                       FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", "", "", Mid(RTrim(Date.Now), 1, 10), IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))
                                        Else
                                            If FormMantGuiaDespacho.cmbt_movinv.SelectedValue = "S06" Then
                                                igv = 0
                                            Else
                                                igv = IIf(IsDBNull(row("IGV")), 0, row("IGV"))
                                            End If
                                            If igv > 0 Then

                                                uprecio_venta = Math.Round(row("UPRECIO_DVENTA") * cmb, 6)
                                                comprad = Math.Round((row("UPRECIO_DVENTA") * row("CANTIDAD")) * (row("IGV") / 100) + row("UPRECIO_DVENTA") * row("CANTIDAD"), 2)
                                                compras = Math.Round(((row("UPRECIO_DVENTA") * row("CANTIDAD")) * (row("IGV") / 100) + row("UPRECIO_DVENTA") * row("CANTIDAD")) * cmb, 2)
                                                precio_venta = Math.Round(row("UPRECIO_DVENTA") * row("CANTIDAD") * cmb, 2)
                                                precio_dventa = Math.Round(row("UPRECIO_DVENTA") * row("CANTIDAD"), 2)
                                                igvimpor = Math.Round(compras - precio_venta, 2)
                                                igv_dimpor = Math.Round(comprad - precio_dventa, 2)
                                                FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                        FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                        IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaDespacho.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                        IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "F001",
                                                                        IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                        "+", FormMantGuiaDespacho.txtt_movinv.Text, precio_venta, precio_dventa, igv, igvimpor,
                                                                        cmb, uprecio_venta,
                                                                        IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), igv_dimpor, IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                        FormMantGuiaDespacho.dtpfecha.Text, gsUser, IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                        RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", nro,
                                                                        "", "", "", "",
                                                                        FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", "", "", Mid(RTrim(Date.Now), 1, 10), IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))
                                            Else
                                                uprecio_venta = Math.Round(row("UPRECIO_DVENTA") * cmb, 6)
                                                comprad = Math.Round(row("UPRECIO_DVENTA") * row("CANTIDAD"), 2)
                                                compras = Math.Round((row("UPRECIO_DVENTA") * row("CANTIDAD")) * cmb, 2)
                                                precio_venta = Math.Round(row("UPRECIO_DVENTA") * row("CANTIDAD") * cmb, 2)
                                                precio_dventa = Math.Round(row("UPRECIO_DVENTA") * row("CANTIDAD"), 2)
                                                igvimpor = Math.Round(compras - precio_venta, 2)
                                                igv_dimpor = Math.Round(comprad - precio_dventa, 2)
                                                FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, FormMantGuiaDespacho.cmb_serdoc.Text,
                                                                        FormMantGuiaDespacho.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                        IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantGuiaDespacho.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                        IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "F001",
                                                                        IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                        "+", FormMantGuiaDespacho.txtt_movinv.Text, precio_venta, precio_dventa, igv, igvimpor,
                                                                        cmb, uprecio_venta,
                                                                        IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), igv_dimpor, IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                        FormMantGuiaDespacho.dtpfecha.Text, gsUser, IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                        RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", nro,
                                                                        "", "", "", "",
                                                                        FormMantGuiaDespacho.cmbestado.Text, "", "", "", "", "", "", "", "", "", "", "", "", Mid(RTrim(Date.Now), 1, 10), IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))
                                            End If
                                        End If
                                    End If

                                Next
                            End If
                        End If
                    Next
                Else
                    MsgBox("No ha marcado documentos para pasar")
                End If
            ElseIf sOp = "1" Then
                If Label2.Text <> 0 Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            FormMantFacturacion.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantFacturacion.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantFacturacion.cmbmon.SelectedValue = GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantFacturacion.cmbt_movinv.SelectedValue = GUIAALMACENBL.SelectT_MOVINV(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantFacturacion.cmbt_pago.SelectedValue = GUIAALMACENBL.SelectF_PAGO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantFacturacion.txtoc.Text = GUIAALMACENBL.SelectNUMPEDIDO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Dim cmb As Double = 0
                            dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                            Dim observa As String
                            'Dim frm As New FormMantDetFacturacion
                            For Each Registro In dt.Rows
                                cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                            Next
                            dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                            For Each row As DataRow In dt.Rows
                                If lvbusqueda.Items(i).SubItems(0).Text = "09" Then
                                    observa = ""
                                Else
                                    observa = IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA"))
                                End If

                                FormMantFacturacion.dgvt_doc.Rows.Add(FormMantFacturacion.txtt_doc.Text,
                                                                      FormMantFacturacion.cmb_serdoc.Text,
                                                             FormMantFacturacion.txtnumero.Text,
                                                             lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text,
                                                             lvbusqueda.Items(i).SubItems(3).Text, FormMantFacturacion.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                             "+", observa, FormMantFacturacion.txtt_movinv.Text, IIf(IsDBNull(row("TPRECIO_VENTA")), 0, row("TPRECIO_VENTA")), IIf(IsDBNull(row("TPRECIO_DVENTA")), 0, row("TPRECIO_DVENTA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                             cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                             IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                             FormMantFacturacion.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                             RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), "", "", "", "",
                                                             FormMantFacturacion.cmbestado.Text)
                            Next

                        End If
                    Next

                Else
                    MsgBox("No ha marcado documentos para pasar")
                End If
            ElseIf sOp = "2" Then
                Dim contarnum As Integer = 0
                If Label2.Text <> 0 Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            FormMantNotaCredito.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaCredito.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaCredito.cmbmon.SelectedValue = GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaCredito.cmbt_movinv.SelectedValue = GUIAALMACENBL.SelectT_MOVINV(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaCredito.cmbt_pago.SelectedValue = GUIAALMACENBL.SelectF_PAGO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaCredito.txtoc.Text = GUIAALMACENBL.SelectNUMPEDIDO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Dim cmb As Double = 0
                            'dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                            ''Dim frm As New FormMantDetFacturacion
                            'For Each Registro In dt.Rows
                            '    cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                            'Next
                            dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                            For Each row As DataRow In dt.Rows

                                '--1
                                For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                    If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                        s = s + 1
                                    End If
                                Next
                                '--
                                If s = 0 Then
                                    contarnum = contarnum + 1
                                    If contarnum = 1 Then
                                        dt1 = REQUERIMIENTOBL.getT_CAMB(row("FECFACT"))
                                        'Dim frm As New FormMantDetFacturacion
                                        For Each Registro In dt1.Rows
                                            cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                                        Next
                                    End If
                                    FormMantNotaCredito.dgvt_doc.Rows.Add(FormMantNotaCredito.txtt_doc.Text, FormMantNotaCredito.cmb_serdoc.Text,
                                                                 FormMantNotaCredito.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                 IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantNotaCredito.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                 IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                 "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantNotaCredito.txtt_movinv.Text, IIf(IsDBNull(row("TPRECIO_VENTA")), 0, row("TPRECIO_VENTA")), IIf(IsDBNull(row("TPRECIO_DVENTA")), 0, row("TPRECIO_DVENTA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                                 cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                                 IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                 FormMantNotaCredito.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                 RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")), "", "", "", "",
                                                                 FormMantNotaCredito.cmbestado.Text, row("FECFACT"))
                                End If
                            Next
                        End If
                    Next

                Else
                    MsgBox("No ha marcado documentos para pasar")
                End If
            ElseIf sOp = "3" Then
                If Label2.Text <> 0 Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            FormMantNotaDebito.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaDebito.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaDebito.cmbmon.SelectedValue = GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaDebito.cmbt_movinv.SelectedValue = GUIAALMACENBL.SelectT_MOVINV(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaDebito.cmbt_pago.SelectedValue = GUIAALMACENBL.SelectF_PAGO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantNotaDebito.txtoc.Text = GUIAALMACENBL.SelectNUMPEDIDO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Dim cmb As Double = 0
                            dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                            'Dim frm As New FormMantDetFacturacion
                            For Each Registro In dt.Rows
                                cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                            Next
                            dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                            For Each row As DataRow In dt.Rows
                                FormMantNotaDebito.dgvt_doc.Rows.Add(FormMantNotaDebito.txtt_doc.Text, FormMantNotaDebito.cmb_serdoc.Text,
                                                                 FormMantNotaDebito.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                 IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantNotaDebito.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                 IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                 "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantNotaDebito.txtt_movinv.Text, IIf(IsDBNull(row("TPRECIO_VENTA")), 0, row("TPRECIO_VENTA")), IIf(IsDBNull(row("TPRECIO_DVENTA")), 0, row("TPRECIO_DVENTA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                                 cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                                 IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                 FormMantNotaDebito.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                 RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")), "", "", "", "",
                                                                 FormMantNotaDebito.cmbestado.Text)
                            Next
                        End If
                    Next
                Else
                    MsgBox("No ha marcado documentos para pasar")
                End If
            ElseIf sOp = "4" Then
                If Label2.Text <> 0 Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked = True Then
                            FormMantBoleta.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantBoleta.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantBoleta.cmbmon.SelectedValue = GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantBoleta.cmbt_movinv.SelectedValue = GUIAALMACENBL.SelectT_MOVINV(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantBoleta.cmbt_pago.SelectedValue = GUIAALMACENBL.SelectF_PAGO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            FormMantBoleta.txtoc.Text = GUIAALMACENBL.SelectNUMPEDIDO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                            Dim cmb As Double = 0
                            dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                            'Dim frm As New FormMantDetFacturacion
                            For Each Registro In dt.Rows
                                cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                            Next
                            dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                            For Each row As DataRow In dt.Rows
                                '--1
                                For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                    If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                        s = s + 1
                                    End If
                                Next
                                '--
                                If s = 0 Then
                                    FormMantBoleta.dgvt_doc.Rows.Add(FormMantBoleta.txtt_doc.Text, FormMantBoleta.cmb_serdoc.Text,
                                                                 FormMantBoleta.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                                 IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), FormMantBoleta.txtctct_cod.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                 IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), "", IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")), "", "", IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                                                 "+", IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")), FormMantBoleta.txtt_movinv.Text, IIf(IsDBNull(row("TPRECIO_VENTA")), 0, row("TPRECIO_VENTA")), IIf(IsDBNull(row("TPRECIO_DVENTA")), 0, row("TPRECIO_DVENTA")), IIf(IsDBNull(row("IGV")), 0, row("IGV")), IIf(IsDBNull(row("IGV_IMPOR")), 0, row("IGV_IMPOR")),
                                                                 cmb, IIf(IsDBNull(row("UPRECIO_VENTA")), 0, row("UPRECIO_VENTA")),
                                                                 IIf(IsDBNull(row("UPRECIO_DVENTA")), 0, row("UPRECIO_DVENTA")), IIf(IsDBNull(row("IGV_DIMPOR")), 0, row("IGV_DIMPOR")), IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                                                 FormMantBoleta.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")), IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                                                 RTrim(Date.Now), "20100279348", "", IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("LOTE")), "", row("LOTE")), "", IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")), "", "", "", "",
                                                                 FormMantBoleta.cmbestado.Text)
                                End If
                            Next
                        End If
                    Next
                Else
                    MsgBox("No ha marcado documentos para pasar")
                End If
            ElseIf sOp = "5" Then
                Dim cmb As Double = 0
                Dim valor As Double
                Dim contar As Int32 = 0
                dt = REQUERIMIENTOBL.getT_CAMB(gsCode7)
                'Dim frm As New FormMantDetFacturacion
                For Each Registro In dt.Rows
                    cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                Next
                If Label2.Text <> 0 Then
                    If MessageBox.Show("¿Desea tomar el monto Total de la factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) <> DialogResult.No Then
                        For i = 0 To lvbusqueda.Items.Count - 1
                            If lvbusqueda.Items(i).Checked = True Then
                                FormMantLetras.txtobservacion.Text = GUIAALMACENBL.SelectObs(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                FormMantLetras.cmbctct_cod.SelectedValue = GUIAALMACENBL.SelectProv(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                'tipo de cambio del detalle t_movinv 14
                                FormMantLetras.btmiv = GUIAALMACENBL.SelectMOVINV(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                'Ojo verificar error cuando hay mas de un documento
                                If FormMantLetras.dtgv_montos.Rows.Count = 0 Then
                                    FormMantLetras.cmbmon.SelectedValue = GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                    FormMantLetras.cmbt_pago.SelectedValue = GUIAALMACENBL.SelectF_PAGO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                    FormMantLetras.txtoc.Text = GUIAALMACENBL.SelectNUMPEDIDO(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                    If FormMantLetras.cmbmon.SelectedValue = "00" Then
                                        FormMantLetras.txtmontopagado.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                        FormMantLetras.txtmontopagadod.Text = ""
                                    Else
                                        FormMantLetras.txtmontopagadod.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                        FormMantLetras.txtmontopagado.Text = ""
                                    End If
                                Else
                                    If GUIAALMACENBL.SelectMONEDA(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) <> FormMantLetras.cmbmon.SelectedValue Then
                                        ' MsgBox("La moneda es distinta a la del documento anterior desea continuar?")
                                        If MessageBox.Show("¿La moneda es distinta a la del documento anterior desea continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) <> DialogResult.No Then

                                        End If
                                        If FormMantLetras.cmbmon.SelectedValue = "01" Then
                                            FormMantLetras.txtmontopagado.Text = "" 'GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) + FormMantLetras.txtmontopagado.Text
                                            FormMantLetras.txtmontopagadod.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) + FormMantLetras.txtmontopagadod.Text
                                        Else
                                            FormMantLetras.txtmontopagado.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) + FormMantLetras.txtmontopagado.Text
                                            FormMantLetras.txtmontopagadod.Text = ""
                                        End If
                                    Else
                                        If FormMantLetras.cmbmon.SelectedValue = "01" Then
                                            FormMantLetras.txtmontopagado.Text = "" 'GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) + FormMantLetras.txtmontopagado.Text
                                            FormMantLetras.txtmontopagadod.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) + FormMantLetras.txtmontopagadod.Text
                                        Else
                                            FormMantLetras.txtmontopagado.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7)) + FormMantLetras.txtmontopagado.Text
                                            FormMantLetras.txtmontopagadod.Text = ""
                                        End If
                                    End If
                                End If
                                valor = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                'If FormMantLetras.cmbmon.SelectedValue = "00" Then
                                '    FormMantLetras.txtmontopagado.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                '    FormMantLetras.txtmontopagadod.Text = "0.00"
                                'Else
                                '    FormMantLetras.txtmontopagadod.Text = GUIAALMACENBL.SelectTotal(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, Mid(lvbusqueda.Items(i).SubItems(3).Text, 1, 7))
                                '    FormMantLetras.txtmontopagado.Text = "0.00"
                                'End If

                                'Dim cmb As Double = 0
                                'dt = REQUERIMIENTOBL.getT_CAMB(gsCode7)
                                ''Dim frm As New FormMantDetFacturacion
                                'For Each Registro In dt.Rows
                                '    cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
                                'Next
                                dt = GUIAALMACENBL.getListdgv6(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                For Each row As DataRow In dt.Rows

                                    '--1
                                    For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                                        If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                            s = s + 1
                                        End If
                                    Next
                                    '--
                                    If s = 0 Then
                                        contar = contar + 1
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
                                        If contar = 1 Then
                                            FormMantLetras.btcmb = IIf(IsDBNull(row("T_CAMB")), 0, row("T_CAMB"))
                                            If FormMantLetras.btmiv = "14" Then
                                                If FormMantLetras.cmbmon.SelectedValue = "00" Then
                                                    FormMantLetras.dtgv_montos.Rows.Add(FormMantLetras.txtt_doc.Text, FormMantLetras.cmb_serdoc.SelectedItem,
                                                   FormMantLetras.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                                   IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")), IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                   FormMantLetras.cmbctct_cod.SelectedValue, FormMantLetras.cmbctct_cod.Text, FormMantLetras.cmbmon.SelectedValue,
                                                   FormMantLetras.cmbmon.Text, FormMantLetras.txtmontopagado.Text, 0,
                                                   FormMantLetras.btcmb, FormMantLetras.txtmontopagado.Text, Math.Round(FormMantLetras.txtmontopagado.Text * FormMantLetras.btcmb, 2))
                                                Else
                                                    FormMantLetras.dtgv_montos.Rows.Add(FormMantLetras.txtt_doc.Text, FormMantLetras.cmb_serdoc.SelectedItem,
                                                   FormMantLetras.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                                   IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")), IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                   FormMantLetras.cmbctct_cod.SelectedValue, FormMantLetras.cmbctct_cod.Text, FormMantLetras.cmbmon.SelectedValue,
                                                   FormMantLetras.cmbmon.Text, Math.Round(FormMantLetras.txtmontopagadod.Text / FormMantLetras.btcmb, 2), FormMantLetras.txtmontopagadod.Text,
                                                   FormMantLetras.btcmb, Math.Round(FormMantLetras.txtmontopagadod.Text / FormMantLetras.btcmb, 2), FormMantLetras.txtmontopagadod.Text)
                                                End If
                                            Else
                                                If FormMantLetras.cmbmon.SelectedValue = "00" Then
                                                    FormMantLetras.dtgv_montos.Rows.Add(FormMantLetras.txtt_doc.Text, FormMantLetras.cmb_serdoc.SelectedItem,
                                                   FormMantLetras.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                                   IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")), IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                   FormMantLetras.cmbctct_cod.SelectedValue, FormMantLetras.cmbctct_cod.Text, FormMantLetras.cmbmon.SelectedValue,
                                                   FormMantLetras.cmbmon.Text, valor, 0,
                                                   cmb, valor, Math.Round(valor * cmb, 2))
                                                Else
                                                    FormMantLetras.dtgv_montos.Rows.Add(FormMantLetras.txtt_doc.Text, FormMantLetras.cmb_serdoc.SelectedItem,
                                                   FormMantLetras.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                                   IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")), IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                                   FormMantLetras.cmbctct_cod.SelectedValue, FormMantLetras.cmbctct_cod.Text, FormMantLetras.cmbmon.SelectedValue,
                                                   FormMantLetras.cmbmon.Text, Math.Round(valor / cmb, 2), valor,
                                                   cmb, Math.Round(valor / cmb, 2), valor)
                                                End If
                                            End If
                                        End If
                                    End If

                                Next

                            End If
                        Next
                    Else
                        Dim frm As New FormMantLetras_Monto
                        frm.btnaceptar.Text = "Aceptar"
                        Dim dtdatos As DataTable
                        For i = 0 To lvbusqueda.Items.Count - 1
                            If lvbusqueda.Items(i).Checked = True Then
                                Dim fechaletra As String = FormMantLetras.dtpfecha.Value.ToShortDateString
                                dtdatos = GUIAALMACENBL.getListdatos(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                                frm.lbl01.Text = lvbusqueda.Items(i).SubItems(0).Text
                                frm.lbl02.Text = lvbusqueda.Items(i).SubItems(2).Text
                                frm.lbl03.Text = lvbusqueda.Items(i).SubItems(3).Text
                                frm.lblproveedor.Text = dtdatos.Rows(0).Item(0).ToString
                                frm.lbl_cliente.Text = dtdatos.Rows(0).Item(1).ToString
                                frm.txtmon.Text = dtdatos.Rows(0).Item(2).ToString
                                frm.lblmon.Text = dtdatos.Rows(0).Item(3).ToString
                                frm.lblmontos.Text = dtdatos.Rows(0).Item(4).ToString
                                frm.lblmontod.Text = dtdatos.Rows(0).Item(5).ToString
                            End If
                        Next
                        FormMantLetras.txtctct_cod.Text = frm.lblproveedor.Text
                        FormMantLetras.cmbctct_cod.SelectedValue = frm.lblproveedor.Text
                        If FormMantLetras.btmiv = "14" Then
                            frm.lblt_cambio.Text = FormMantLetras.btcmb
                        Else
                            frm.lblt_cambio.Text = cmb
                        End If

                        frm.ShowDialog()
                        'MsgBox("No ha marcado documentos para pasar")
                    End If
                End If
            End If
        ElseIf gsCode = "4" Then
            Dim s As Integer = 0
            For j = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(j).Checked Then
                    'If cmbc_costo.SelectedIndex <> -1 Then
                    '    dt = GUIAALMACENBL.getListdgv3(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, cmbc_costo.SelectedValue)
                    'Else
                    dt = GUIAALMACENBL.getListdgv4(lvbusqueda.Items(j).SubItems(0).Text, lvbusqueda.Items(j).SubItems(2).Text, lvbusqueda.Items(j).SubItems(3).Text)
                    'End If
                    For Each row As DataRow In dt.Rows
                        '--1
                        For l = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                            If FormMantGuiaAlmacen.dgvt_doc.Rows(l).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                s = s + 1
                            End If
                        Next
                        '   --
                        For i = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                            If FormMantGuiaAlmacen.dgvt_doc.Rows(i).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                s = s + 1
                            End If
                        Next
                        If s = 0 Then
                            contador = contador + 1
                            FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, FormMantGuiaAlmacen.cmb_serdoc.Text,
                                                                         FormMantGuiaAlmacen.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                            IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), FormMantGuiaAlmacen.txtproveedor.Text, IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")), IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                          IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), Nothing, "", "", "", "", "+", IIf(IsDBNull(row("OBSERVA1")), "", row("OBSERVA1")), FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                                         "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                                         RTrim(Date.Now), "20100279348", IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", IIf(IsDBNull(row("LOTE")), "", row("LOTE")), FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                                         FormMantGuiaAlmacen.cmbestado.Text)
                        End If
                        'If IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) = "OREQ" Or contador = 1 Then
                        '    ' FormMantGuiaAlmacen.txtobserva1.Text = FormMantGuiaAlmacen.txtobserva1.Text & IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")) & "-" & IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")) & "-" & IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")) & ","
                        'End If
                    Next

                End If
            Next
        ElseIf gsCode = "5" Then
            'lvreq.Items.Clear()
            For j = 0 To lvreq.Items.Count - 1
                If lvreq.Items(j).Checked Then
                    dt = GUIAALMACENBL.getListdgv5(lvreq.Items(j).SubItems(2).Text, lvreq.Items(j).SubItems(3).Text, lvreq.Items(j).SubItems(4).Text)
                    For Each row As DataRow In dt.Rows
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, FormMantELTBSOLMATERIALES.cmb_serdoc.Text, FormMantELTBSOLMATERIALES.txtnumero.Text,
                                                                    IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                                    IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), 'FormMantELTBSOLMATERIALES.txtnumero.Text,
                                                                    IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                                                    IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), IIf(IsDBNull(row("NOMART")), "", row("NOMART")), "", gsUser,
                                                                    ARTICULOBL.SelectUniMed(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD"))), "P", IIf(IsDBNull(row("ART_VENTA")), "", row("ART_VENTA")), "",
                                                                    If(IsDBNull(row("CCO_COD")), "", row("CCO_COD")), "", "0", "", "", 0)
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
    End Sub

    Private Sub lvbusqueda1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda1.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If lvbusqueda.Visible = True Then
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
        ElseIf lvbusqueda1.Visible = True Then
            If chkmarcar.Checked Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items.Item(i).ForeColor = Color.Red Or lvbusqueda1.Items.Item(i).ForeColor = Color.Yellow Then
                        lvbusqueda1.Items(i).Checked = False
                    Else
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim dt As DataTable = ARTICULOBL.getListcmblin1()
            GetCmb("cod", "nom", dt, cmbc_costo)
        Else
            Dim dt As DataTable = ARTICULOBL.getListcmb13()
            GetCmb("cod", "nom", dt, cmbc_costo)
        End If
    End Sub

    Private Sub txtart_TextChanged(sender As Object, e As EventArgs) Handles txtart.TextChanged
        If txtart.TextLength > 0 Then
            chkart.Checked = True
        Else
            chkart.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "5"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
End Class