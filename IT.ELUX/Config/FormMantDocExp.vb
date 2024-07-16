Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDocExp
    Private PROVISIONESBL As New PROVISIONESBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private ELTBDOCEXPBL As New ELTBDOCEXPBL
    Private CCOSTOBL As New CCOSTOBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private bTdoc As String
    Private bfec As String
    Private bSdoc As String
    Private bNdoc As String
    Private bP As String
    Private bFecP As String
    Public bMes As String
    Private cont_prov As Integer = 0
    Private contador As Integer = 0
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region

    Private Sub CleanVar()
        txtt_doc.Clear()
        txtser_doc_ref.Clear()
        txtnumero.Clear()
    End Sub

    Public Sub habilitar(ByVal est As Boolean)
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btndocu.Enabled = est
        'btnborrar.Enabled = est
    End Sub

    Private Function OkData() As Boolean

        If txtt_doc.Text = "" Then
            MsgBox("Ingrese descripcion el Tipo de Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtnumero.Text = "" Then
            MsgBox("Ingrese el numero del Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If Mid(txtmskfecprov.Text, 4, 2) <> bMes Then
            'MsgBox(Mid(txtmskfecprov.Text, 4, 2))
            MsgBox("El mes es diferente al mes marcado, por favor corrija la fecha de provision", MsgBoxStyle.Exclamation)
            txtmskfecprov.Focus()
            Return False
        End If
        If txtproveedor.Text = "" Then
            MsgBox("Ingrese el proveedor del Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If

        If txtnro_detrac.TextLength > 0 Then
            Dim fecprov As String = Replace(txtmskfecprov.Text, "/", "")
            Dim fecprov1 As String = Replace(fecprov, "_", "")
            Dim fecprov2 As String = Replace(fecprov1, " ", "")
            'contador = 0
            Try
                txtmskfecprov.Text = CDate(txtmskfecprov.Text)
            Catch ex As Exception
                'MsgBox(Replace(fecprov, "_", "").Length)
                'MsgBox(fecprov2.Length)
                'contador = contador + 1
                'If contador = 1 Then
                If fecprov2.Length < 10 And fecprov2.Length > 0 Then
                    MsgBox("Completa la fecha")
                    txtmskfecprov.Focus()
                    Return False
                End If
                'Else
                '    Exit Sub
                '    'txtmskfecprov.Focus()
                'End If
            End Try
            'MsgBox("Ingrese el Cliente de Referencia", MsgBoxStyle.Exclamation)
            '    txtt_doc.Focus()
        End If
        If txtnomproveedor.TextLength = 0 Then
            MsgBox("El proveedor no Existe", MsgBoxStyle.Exclamation)
            txtproveedor.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub SaveData()
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La factura no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim dtUsuario As DataTable
        ' Dim dt As DataTable
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim DAcumula6 As Double = 0
        Dim DAcumula7 As Double = 0
        Dim nro As String
        Dim peso As Double = 0
        Dim mesaño As String
        Dim m As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim PROVISIONESBE As New PROVISIONESBE
        Dim ELTBDOCEXPBE As New ELTBDOCEXPBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELTBDETDOCEXPBE As New ELTBDETDOCEXPBE
        For i = 0 To dgvt_doc.Rows.Count - 1
            If dgvt_doc.Rows(i).Cells("CUENTA").Value = "" Then
                MsgBox("Ingrese en el " & dgvt_doc.Rows(i).Cells("ART_COD").Value & " ya que no tiene cuenta")
                Exit Sub
            End If
            If dgvt_doc.Rows(i).Cells("STATUS").Value = "AFECTO" Then
                If dgvt_doc.Rows(i).Cells("UPRECIO_COMPRA").Value = 0 Then
                    MsgBox("Ingrese el valor de compra en el " & dgvt_doc.Rows(i).Cells("ART_COD").Value & " ya que no cuenta con valor")
                    Exit Sub
                End If
            ElseIf dgvt_doc.Rows(i).Cells("STATUS").Value = "INAFECTO" Then
                If dgvt_doc.Rows(i).Cells("UPRECIO_AFECTOS").Value = 0 Then
                    MsgBox("Ingrese el valor de compra en el " & dgvt_doc.Rows(i).Cells("ART_COD").Value & " ya que no cuenta con valor")
                    Exit Sub
                End If
            End If
            dgvt_doc.Rows(i).Cells("PESO").Value = PROVISIONESBL.SelRowPeso(dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value, dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value, Mid(dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value, 1, 7), dgvt_doc.Rows(i).Cells("ART_COD").Value)
            ELTBDOCEXPBE.T_CAMB = Val(dgvt_doc.Rows(i).Cells("T_CAMB").Value)
        Next
        ELTBDOCEXPBE.T_DOC_REF = RTrim(txtt_doc.Text)
        ELTBDOCEXPBE.TDOC = lbl_tdoc.Text
        ELTBDOCEXPBE.SDOC = lbl_sdoc.Text
        ELTBDOCEXPBE.NDOC = lbl_ndoc.Text
        'ELTBDOCEXPBE.FEC = lbl_fec.Text
        'ELTBDOCEXPBE.FECP = bFecP 'Mid(txtmskfecgene.Text, 7, 4) & Mid(txtmskfecgene.Text, 4, 2).ToString.PadLeft(2, "0") & Mid(txtmskfecgene.Text, 1, 2).ToString.PadLeft(2, "0") 'dtpfecha.Value.Year.ToString & dtpfecha.Value.Month.ToString.PadLeft(2, "0") & dtpfecha.Value.Day.ToString.PadLeft(2, "0")
        ELTBDOCEXPBE.P = lbl_prov.Text
        ELTBDOCEXPBE.SER_DOC_REF = RTrim(txtser_doc_ref.Text)
        ELTBDOCEXPBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        ELTBDOCEXPBE.T_OPE = txtope.Text
        ELTBDOCEXPBE.ADVALORE = npdadvalore.Value
        If cmbarticulo.SelectedIndex = 1 Then
            ELTBDOCEXPBE.ART_COD = "07010001"
        ElseIf cmbarticulo.SelectedIndex = 0 Then
            ELTBDOCEXPBE.ART_COD = "05990001"
        Else
            ELTBDOCEXPBE.ART_COD = ""
        End If
        'arregla el tipo de cambio
        Dim cmb As Double
        Dim dt As DataTable
        Dim mesfecha As String
        Dim mesdia As String
        If Mid(txtmskfecsbs.Text, 4, 2) = "1" Then
            mesfecha = "0" & Mid(txtmskfecsbs.Text, 4, 2)
        Else
            mesfecha = Mid(txtmskfecsbs.Text, 4, 2)
        End If
        If Mid(txtmskfecgene.Text, 1, 2) = "1" Then
            mesdia = "0" & Mid(txtmskfecsbs.Text, 1, 2)
        Else
            mesdia = Mid(txtmskfecsbs.Text, 1, 2)
        End If
        dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next

        For i = 0 To dgvt_doc.Rows.Count - 1
            dgvt_doc.Rows(i).Cells("T_CAMB").Value = cmb
        Next

        bTdoc = lbl_tdoc.Text
        bSdoc = lbl_sdoc.Text
        bNdoc = lbl_ndoc.Text
        bP = lbl_prov.Text
        ELTBDOCEXPBE.FEC_PROV = txtmskfecprov.Text 'dtpfechaprov.Value
        ELTBDOCEXPBE.SIGNO = "-"
        ELTBDOCEXPBE.FEC_VENSBS = txtmskfecsbs.Text
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_COMPRA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DCOMPRA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        Next
        ELTBDOCEXPBE.TPRECIO_COMPRA = DAcumula
        ELTBDOCEXPBE.TPRECIO_DCOMPRA = DAcumula1
        ELTBDOCEXPBE.T_DCTO = DAcumula2
        ELTBDOCEXPBE.T_DCTO_DOLAR = DAcumula3
        ELTBDOCEXPBE.T_IGV = DAcumula4
        ELTBDOCEXPBE.T_IGV_DOLAR = DAcumula5
        ELTBDOCEXPBE.PROVEEDOR = txtproveedor.Text
        ELTBDOCEXPBE.OBSERVA = txtobserva.Text
        'ELTBDOCEXPBE.CTCT_COD = "20100279348"
        ELTBDOCEXPBE.USUARIO = RTrim(gsUser)
        ELTBDOCEXPBE.F_PAGO_ENT = txtt_pago.Text
        ELTBDOCEXPBE.MONEDA = txtmoneda.Text
        ELMVLOGSBE.log_codusu = gsCodUsr
        ELTBDOCEXPBE.FEC_GENE = txtmskfecgene.Text
        If txtt_doc.Text = "07" Then
            ELTBDOCEXPBE.SIGNO = "-"
        Else
            ELTBDOCEXPBE.SIGNO = "+"
        End If

        ELTBDOCEXPBE.OBSERVA = txtobserva.Text
        If cmb_x_ret.SelectedIndex = 1 Then
            ELTBDOCEXPBE.X_RET = "N"
        ElseIf cmb_x_ret.SelectedIndex = 2 Then
            ELTBDOCEXPBE.X_RET = "R"
        End If
        If cmbest.SelectedIndex = 1 Then
            ELTBDOCEXPBE.EST = "1"
        ElseIf cmbest.SelectedIndex = 2 Then
            ELTBDOCEXPBE.EST = "2"
        ElseIf cmbest.SelectedIndex = 3 Then
            ELTBDOCEXPBE.EST = "3"
        End If
        ELTBDOCEXPBE.REG_NRO = txtreg_nro.Text
        ELTBDOCEXPBE.TIPO = "C"
        ELTBDOCEXPBE.TIPO2 = txttipo2.Text
        If chktipo1.Checked Then
            PROVISIONESBE.TIPO1 = "1"
        End If
        If cmbest1.SelectedIndex = 1 Then
            ELTBDOCEXPBE.EST1 = "D"
        ElseIf cmbest1.SelectedIndex = 2 Then
            ELTBDOCEXPBE.EST1 = "P"
        ElseIf cmbest1.SelectedIndex = 3 Then
            ELTBDOCEXPBE.EST1 = "R"
        End If
        ELTBDOCEXPBE.NRO_PERCEPCION = txtnro_percepcion.Text
        ELTBDOCEXPBE.DETRACCION = txtnro_detrac.Text
        'If dtpfec_det.Checked Then
        If txtnro_detrac.TextLength > 0 Then
            ELTBDOCEXPBE.FEC_DET = txtmskfecdet.Text
        End If
        'If dtpfec_letra.Checked Then
        If txtletra.TextLength > 0 Then
            ELTBDOCEXPBE.FEC_LETRA = txtmskfecletra.Text
        End If
        PROVISIONESBE.LETRA = txtletra.Text
        mesaño = Replace(Mid(txtmskfecprov.Text, 4, 7), "/", "")
        m = Mid(txtmskfecprov.Text, 4, 2)
        ELTBDOCEXPBE.MONTO_PAGADO = Val(IIf(IsDBNull(dgvt_doc.Rows(0).Cells("MONTO_PAGADO").Value), 0, dgvt_doc.Rows(0).Cells("MONTO_PAGADO").Value))
        ELTBDOCEXPBE.PROGRAMA = dgvt_doc.Rows(0).Cells("PROGRAMA").Value
        ELTBDOCEXPBE.PORCENTAJE = Val(IIf(IsDBNull(dgvt_doc.Rows(0).Cells("PORCENTAJE").Value), 0, dgvt_doc.Rows(0).Cells("PORCENTAJE").Value))
        ELTBDOCEXPBE.FARDO = dgvt_doc.Rows(0).Cells("FARDO").Value
        ELTBDOCEXPBE.CTA_CBCO = dgvt_doc.Rows(0).Cells("CTA_CBCO").Value
        ELTBDOCEXPBE.T_CMP = txtt_cmp.Text
        ELTBDOCEXPBE.S_CMP = txts_comp.Text
        ELTBDOCEXPBE.N_CMP = txtn_cmp.Text
        ELTBDOCEXPBE.ANO_CMP = Val(cmb_año_cmp.Text)
        ELTBDOCEXPBE.T_CONV = txt_conv.Text
        ELTBDOCEXPBE.PAIS = cmb_pais.SelectedValue
        ELTBDOCEXPBE.T_RENTA = txtt_renta.Text
        ELTBDOCEXPBE.EST_OPORT = txtest_oport.Text
        gsError = ELTBDOCEXPBL.SaveRow(ELTBDOCEXPBE, ELTBDETDOCEXPBE, flagAccion, ELMVLOGSBE, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'If dgvtletras.Rows.Count > 0 Then
            'gsError3 = PROVISIONESBL.SaveRLetra(PROVISIONESBE, DET_DOCUMENTOBE, flagAccion, ELMVLOGSBE, dgvtletras)
            'If gsError3 = "OK" Then
            'MsgBox("Letras Ingresadas", MsgBoxStyle.Information)
            gsError2 = ELTBDOCEXPBL.AsientoPR("Asiento", mesaño, m, RTrim(txtnumero.Text), txtser_doc_ref.Text, txtt_doc.Text, gsUser, txtproveedor.Text, dgvt_doc)
            If gsError2 = "OK" Then
                MsgBox("Asiento Creado", MsgBoxStyle.Information)
                flagAccion = "M"
                lbl_tdoc.Text = txtt_doc.Text
                lbl_sdoc.Text = txtser_doc_ref.Text
                lbl_ndoc.Text = txtnumero.Text
                lbl_prov.Text = txtproveedor.Text
                Try
                    sFecCom = Mid(txtmskfecsbs.Text, 7, 4) & Mid(txtmskfecsbs.Text, 4, 2).ToString.PadLeft(2, "0") 'dtpfechaprov.Value.Year & dtpfechaprov.Value.Month.ToString.PadLeft(2, "0")
                    dtUsuario = ELTBDOCEXPBL.SelectRow(Trim(txtt_doc.Text), Trim(txtser_doc_ref.Text), Trim(txtnumero.Text), sFecCom, Trim(txtproveedor.Text))
                    For Each Registro In dtUsuario.Rows
                        txtreg_nro.Text = IIf(IsDBNull(Registro("REG_NRO")), "", Registro("REG_NRO"))
                        txt_t_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), "", Format(Math.Round(Registro("T_DCTO_DOLAR"), 4), "N2"))
                        txt_t_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), "", Format(Math.Round(Registro("T_DCTO"), 4), "N2"))
                        txt_tprecio_compra.Text = IIf(IsDBNull(Registro("TPRECIO_COMPRA")), "", Format(Math.Round(Registro("TPRECIO_COMPRA"), 4), "N2"))
                        txt_tprecio_dcompra.Text = IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), "", Format(Math.Round(Registro("TPRECIO_DCOMPRA"), 4), "N2"))
                        txttafectod.Text = IIf(IsDBNull(Registro("TAFECTOD")), "", Format(Math.Round(Registro("TAFECTOD"), 4), "N2"))
                        txtafecto.Text = IIf(IsDBNull(Registro("TAFECTO")), "", Format(Math.Round(Registro("TAFECTO"), 4), "N2"))
                        txt_t_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Format(Math.Round(Registro("T_IGV"), 4), "N2"))
                        txt_t_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Format(Math.Round(Registro("T_IGV_DOLAR"), 4), "N2"))
                        txt_t_dies.Text = IIf(IsDBNull(Registro("T_DIES")), "", Format(Math.Round(Registro("T_DIES"), 4), "N2"))
                        txt_t_ies.Text = IIf(IsDBNull(Registro("T_IES")), "", Format(Math.Round(Registro("T_IES"), 4), "N2"))
                        txt_t_dcta.Text = IIf(IsDBNull(Registro("T_DCTA")), "", Format(Math.Round(Registro("T_DCTA"), 4), "N2"))
                        txt_t_cta.Text = IIf(IsDBNull(Registro("T_CTA")), "", Format(Math.Round(Registro("T_CTA"), 4), "N2"))
                        txt_t_dcta.Text = IIf(IsDBNull(Registro("T_DCTA")), "", Registro("T_DCTA"))
                        txt_t_cta.Text = IIf(IsDBNull(Registro("T_CTA")), "", Registro("T_CTA"))
                        'IIf(IsDBNull(Registro("T_DCTO_DOLAR")), "", Registro("T_DCTO_DOLAR")) + IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), "", Registro("TPRECIO_DCOMPRA")) +
                        'IIf(IsDBNull(Registro("TAFECTOD")), "", Registro("TAFECTOD")) + IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR")) +
                    Next
                    npdtcamb.Value = dgvt_doc.Rows(0).Cells("T_CAMB").Value
                Catch ex As Exception

                End Try
            Else
                FormMain.LblError.Text = gsError2
                MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
        txttcomprad.Text = Format(Math.Round(Val(txt_tprecio_dcompra.Text) + Val(txttafectod.Text) + Val(txt_t_igv_dolar.Text) + Val(txt_t_dies.Text) + Val(txt_t_dcta.Text) + Val(txt_t_dcto_dolar.Text), 2), "N2")
        txttcompras.Text = Format(Math.Round(Val(txt_tprecio_compra.Text) + Val(txtafecto.Text) + Val(txt_t_igv.Text) + Val(txt_t_ies.Text) + Val(txt_t_cta.Text) + Val(txt_t_dcto.Text), 2), "N2")
        txttcomprad.Text = Format(Math.Round(CDbl(txt_tprecio_dcompra.Text) + CDbl(txt_t_igv_dolar.Text) - CDbl(txt_t_dcto_dolar.Text) - CDbl(txt_t_dies.Text) - CDbl(txt_t_dcta.Text) + CDbl(txttafectod.Text), 2), "N2")
        txttcompras.Text = Format(Math.Round(CDbl(txt_tprecio_compra.Text) + CDbl(txt_t_igv.Text) - CDbl(txt_t_dcto.Text) - CDbl(txt_t_ies.Text) - CDbl(txt_t_cta.Text) + CDbl(txtafecto.Text), 2), "N2")

    End Sub

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    Cursor.Current = Cursors.WaitCursor
                    ReDim gsRptArgs(4)
                    gsRptArgs(0) = Mid(txtmskfecprov.Text, 7, 4) 'dtpfechaprov.Value.Year
                    gsRptArgs(1) = Mid(txtmskfecprov.Text, 4, 2).ToString.PadLeft(2, "0") 'dtpfechaprov.Value.Month.ToString.PadLeft(2, "0")
                    gsRptArgs(2) = txtope.Text
                    gsRptArgs(3) = txtreg_nro.Text
                    gsRptArgs(4) = txtreg_nro.Text
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPT_MOV_CT.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ELTBDOCEXPBL.SelectRow(sT_Ref, sS_Ref, sN_Ref, sFecCom, gsCode7)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            lbl_tdoc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            txtser_doc_ref.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            lbl_sdoc.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            lbl_ndoc.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            txtmskfecgene.Text = CDate(IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE")))
            'lbl_fec.Text = Mid(txtmskfecgene.Text, 7, 4) & Mid(txtmskfecgene.Text, 4, 2).ToString.PadLeft(2, "0")
            txtope.Text = IIf(IsDBNull(Registro("T_OPE")), "", Registro("T_OPE"))
            cmbtopenom.SelectedValue = txtope.Text
            txtproveedor.Text = IIf(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            lbl_prov.Text = IIf(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            txtnomproveedor.Text = PROVISIONESBL.SelectT_Prov(txtproveedor.Text)
            txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txttipo2.Text = IIf(IsDBNull(Registro("TIPO2")), "", Registro("TIPO2"))
            txtmskfecprov.Text = CDate(IIf(IsDBNull(Registro("FEC_PROV")), "", Registro("FEC_PROV")))
            bFecP = Mid(txtmskfecgene.Text, 7, 4) & Mid(txtmskfecgene.Text, 4, 2).ToString.PadLeft(2, "0") & Mid(txtmskfecgene.Text, 1, 2).ToString.PadLeft(2, "0")
            txtt_cmp.Text = IIf(IsDBNull(Registro("T_CMP")), "", Registro("T_CMP"))
            txts_comp.Text = IIf(IsDBNull(Registro("S_CMP")), "", Registro("S_CMP"))
            txtn_cmp.Text = IIf(IsDBNull(Registro("N_CMP")), "", Registro("N_CMP"))
            cmb_año_cmp.Text = IIf(IsDBNull(Registro("ANO_CMP")), "", Registro("ANO_CMP"))
            txt_conv.Text = IIf(IsDBNull(Registro("T_CONV")), "", Registro("T_CONV"))
            txtnom_conv.Text = ELTBDOCEXPBL.Select_Nomconv(txt_conv.Text)
            txtt_renta.Text = IIf(IsDBNull(Registro("T_RENTA")), "", Registro("T_RENTA"))
            txtest_oport.Text = IIf(IsDBNull(Registro("EST_OPORT")), "", Registro("EST_OPORT"))
            cmb_pais.SelectedValue = IIf(IsDBNull(Registro("PAIS")), "", Registro("PAIS"))
            npdadvalore.Value = Val(IIf(IsDBNull(Registro("ADVALOR")), "", Registro("ADVALOR")))
            'dtpfecha.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            'lbl_fec.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            If IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")) = "05990001" Then
                cmbarticulo.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")) = "07010003" Then
                cmbarticulo.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")) = "07010001" Then
                cmbarticulo.SelectedIndex = 1
            Else
                cmbarticulo.SelectedIndex = -1
            End If
            If IIf(IsDBNull(Registro("TIPO1")), "", Registro("TIPO1")) = "1" Then
                chktipo1.Checked = True
            Else
                chktipo1.Checked = False
            End If
            txtt_pago.Text = IIf(IsDBNull(Registro("F_PAGO_ENT")), "", Registro("F_PAGO_ENT"))
            cmbt_pago.SelectedValue = txtt_pago.Text
            txtnro_percepcion.Text = IIf(IsDBNull(Registro("nro_percepcion")), "", Registro("nro_percepcion"))
            txttipo2.Text = IIf(IsDBNull(Registro("tipo2")), "", Registro("tipo2"))
            txtnom_bs_ss.Text = PROVISIONESBL.SelectBS_SSrow(txttipo2.Text)
            txtmoneda.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            If IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "D" Then
                cmbest1.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "P" Then
                cmbest1.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "R" Then
                cmbest1.SelectedIndex = 3
            End If
            If IIf(IsDBNull(Registro("X_RET")), "", Registro("X_RET")) = "N" Then
                cmb_x_ret.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("X_RET")), "", Registro("X_RET")) = "R" Then
                cmb_x_ret.SelectedIndex = 2
            End If
            Me.txtnro_detrac.Text = IIf(IsDBNull(Registro("DETRACCION")), "", Registro("DETRACCION"))
            If txtnro_detrac.TextLength > 0 Then '> 0 
                txtmskfecdet.Text = CDate(IIf(IsDBNull(Registro("FEC_DET")), "", Registro("FEC_DET")))
                'dtpfec_det.Checked = True
            End If
            txtletra.Text = IIf(IsDBNull(Registro("LETRA")), "", Registro("LETRA"))
            If txtletra.TextLength > 0 Then
                txtmskfecletra.Text = CDate(IIf(IsDBNull(Registro("FEC_LETRA")), "", Registro("FEC_LETRA")))
                'dtpfec_letra.Checked = True
            End If
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "1" Then
                cmbest.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "2" Then
                cmbest.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "3" Then
                cmbest.SelectedIndex = 3
            End If
            txtmskfecsbs.Text = CDate(IIf(IsDBNull(Registro("FEC_VENSBS")), "", Registro("FEC_VENSBS")))
            txt_t_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), "", Format(Math.Round(Registro("T_DCTO_DOLAR"), 4), "N4"))
            txt_t_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), "", Format(Math.Round(Registro("T_DCTO"), 4), "N4"))
            txt_tprecio_compra.Text = IIf(IsDBNull(Registro("TPRECIO_COMPRA")), "", Format(Math.Round(Registro("TPRECIO_COMPRA"), 4), "N4"))
            txt_tprecio_dcompra.Text = IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), "", Format(Math.Round(Registro("TPRECIO_DCOMPRA"), 4), "N4"))
            txttafectod.Text = IIf(IsDBNull(Registro("TAFECTOD")), "", Format(Math.Round(Registro("TAFECTOD"), 4), "N4"))
            txtafecto.Text = IIf(IsDBNull(Registro("TAFECTO")), "", Format(Math.Round(Registro("TAFECTO"), 4), "N4"))
            txt_t_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Format(Math.Round(Registro("T_IGV"), 4), "N4"))
            txt_t_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Format(Math.Round(Registro("T_IGV_DOLAR"), 4), "N4"))
            txt_t_dies.Text = IIf(IsDBNull(Registro("T_DIES")), "", Format(Math.Round(Registro("T_DIES"), 4), "N4"))
            txt_t_ies.Text = IIf(IsDBNull(Registro("T_IES")), "", Format(Math.Round(Registro("T_IES"), 4), "N4"))
            txt_t_dcta.Text = IIf(IsDBNull(Registro("T_DCTA")), "", Format(Math.Round(Registro("T_DCTA"), 4), "N4"))
            txt_t_cta.Text = IIf(IsDBNull(Registro("T_CTA")), "", Format(Math.Round(Registro("T_CTA"), 4), "N4"))
            txttcomprad.Text = Format(Math.Round(CDbl(txt_tprecio_dcompra.Text) + CDbl(txt_t_igv_dolar.Text) - CDbl(txt_t_dcto_dolar.Text) - CDbl(txt_t_dies.Text) - CDbl(txt_t_dcta.Text) + CDbl(txttafectod.Text), 2), "N2")
            txttcompras.Text = Format(Math.Round(CDbl(txt_tprecio_compra.Text) + CDbl(txt_t_igv.Text) - CDbl(txt_t_dcto.Text) - CDbl(txt_t_ies.Text) - CDbl(txt_t_cta.Text) + CDbl(txtafecto.Text), 2), "N2")
            txtnom_moneda.Text = PROVISIONESBL.Select_MON_row(txtmoneda.Text)
            txtreg_nro.Text = IIf(IsDBNull(Registro("REG_NRO")), "", Registro("REG_NRO"))
        Next
    End Sub

    Private Sub FormMantDocExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ingreso de Documentos Proveedor/Cliente"
        Me.txtt_doc.Text = sTDoc
        bPrimero = True
        Me.txtser_doc_ref.Text = sSDoc
        Dim dt As DataTable = PROVISIONESBL.SelectT_DOC2()
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = PROVISIONESBL.SelectT_OPE(sAño)
        GetCmb("cod", "nom", dt, cmbtopenom)
        dt = GUIADESPACHOBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = ELTBDOCEXPBL.SelPais
        GetCmb("cod", "nom", dt, cmb_pais)
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CCO_COD", "C. Costo") '6
        dgvt_doc.Columns.Add("STATUS", "Status") '7
        dgvt_doc.Columns.Add("CUENTA", "Cuenta") '8
        dgvt_doc.Columns.Add("CUENTA_DEST", "Cuenta Destino") '9
        dgvt_doc.Columns.Add("SIGNO", "Signo") '10
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente") '11
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '12
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '13
        dgvt_doc.Columns.Add("UNIDAD", "Und.") '14
        dgvt_doc.Columns.Add("TPRECIO_COMPRA", "P. Compra") '15
        dgvt_doc.Columns.Add("TPRECIO_DCOMPRA", "P. Compra Dolares") '16
        dgvt_doc.Columns.Add("IGV", "IGV") '17
        dgvt_doc.Columns.Add("IGV_IMPOR", "IGV_IMPOR") '18
        dgvt_doc.Columns.Add("T_CAMB", "T_CAMB") '19
        dgvt_doc.Columns.Add("UPRECIO_COMPRA", "UPRECIO_COMPRA") '20
        dgvt_doc.Columns.Add("UPRECIO_DCOMPRA", "UPRECIO_DCOMPRA") '21
        dgvt_doc.Columns.Add("IGV_DIMPOR", "IGV_DIMPOR") '22
        dgvt_doc.Columns.Add("MONEDA", "MONEDA") '23
        dgvt_doc.Columns.Add("FEC_GENE", "FEC_GENE") '24
        dgvt_doc.Columns.Add("USUARIO", "USUARIO") '25
        dgvt_doc.Columns.Add("FEC_DIA", "FEC_DIA") '26
        dgvt_doc.Columns.Add("PROVEEDOR", "PROVEEDOR") '27
        dgvt_doc.Columns.Add("DSCTO_IMPOR", "DSCTO_IMPOR") '28
        dgvt_doc.Columns.Add("DSCTO_DIMPOR", "DSCTO_DIMPOR") '29
        dgvt_doc.Columns.Add("DSCTO", "DSCTO") '30
        dgvt_doc.Columns.Add("IES", "IES") '31
        dgvt_doc.Columns.Add("IES_IMPOR", "IES_IMPOR") '32
        dgvt_doc.Columns.Add("IES_DIMPOR", "IES_DIMPOR") '33
        dgvt_doc.Columns.Add("CTA", "CTA") '34
        dgvt_doc.Columns.Add("CTA_IMPOR", "CTA_IMPOR") '35
        dgvt_doc.Columns.Add("CTA_DIMPOR", "CTA_DIMPOR") '36
        dgvt_doc.Columns.Add("UPRECIO_AFECTOS", "UPRECIO_AFECTOS") '37
        dgvt_doc.Columns.Add("UPRECIO_AFECTOD", "UPRECIO_AFECTOD") '38
        dgvt_doc.Columns.Add("ART_NOM", "Art. Descri.") '39
        dgvt_doc.Columns.Add("SREQ", "Ser. Req.") '40
        dgvt_doc.Columns.Add("NREQ", "Nro. Req.") '41
        dgvt_doc.Columns.Add("X_D", "Rep.") '42
        dgvt_doc.Columns.Add("MONTO_PAGADO", "Monto Pagar S.") '43
        dgvt_doc.Columns.Add("PORCENTAJE", "Porc.") '44
        dgvt_doc.Columns.Add("CTA_CBCO", "CTA_CBCO") '45
        dgvt_doc.Columns.Add("FARDO", "Cod. Bien o Servicio") '46
        dgvt_doc.Columns.Add("PROGRAMA", "Cod. Ope") '47
        dgvt_doc.Columns.Add("PESO", "Peso") '48


        '--------- Letras de Compra
        dgvtletras.Columns.Add("CODIGO", "Cod.") '0
        dgvtletras.Columns.Add("T_DOC_REF", "Documento") '1
        dgvtletras.Columns.Add("SER_DOC_REF", "Serie") '2
        dgvtletras.Columns.Add("NRO_DOC_REF", "Numero") '3
        'dgvtletras.Columns.Add("EST", "ESTADO") '4
        dgvtletras.Columns.Add("FEC_LETRA", "Fec. Letra") '4
        dgvtletras.Columns.Add("NRO_DOC", "Nro. Docu") '5
        dgvtletras.Columns.Add("MONTO", "Monto S.") '6
        dgvtletras.Columns.Add("MONTOD", "Monto D.") '7
        dgvtletras.Columns.Add("PROVEEDOR", "Prov.") '8
        dgvtletras.Columns.Add("T_CMB", "T. Cambio") '9
        dgvtletras.Columns.Add("Moneda", "Moneda") '10

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                cmbest.SelectedIndex = 1
                txtope.Text = "003"
                cmbtopenom.SelectedValue = txtope.Text
                cmb_x_ret.SelectedIndex = 1
                txtt_renta.Text = "00"
                txtest_oport.Text = "0"
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(3).Visible = False
                dgvt_doc.Columns(11).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
                dgvt_doc.Columns(15).Visible = False
                dgvt_doc.Columns(16).Visible = False
                dgvt_doc.Columns(17).Visible = False
                dgvt_doc.Columns(18).Visible = False
                dgvt_doc.Columns(19).Visible = False
                dgvt_doc.Columns(20).Visible = False
                dgvt_doc.Columns(21).Visible = False
                dgvt_doc.Columns(22).Visible = False
                dgvt_doc.Columns(23).Visible = False
                dgvt_doc.Columns(24).Visible = False
                dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                dgvt_doc.Columns(29).Visible = False
                dgvt_doc.Columns(30).Visible = False
                dgvt_doc.Columns(31).Visible = False
                dgvt_doc.Columns(32).Visible = False
                dgvt_doc.Columns(33).Visible = False
                dgvt_doc.Columns(34).Visible = False
                dgvt_doc.Columns(35).Visible = False
                dgvt_doc.Columns(36).Visible = False
                dgvt_doc.Columns(37).Visible = False
                dgvt_doc.Columns(38).Visible = False
                'dgvt_doc.Columns(39).Visible = False
                dgvt_doc.Columns(41).Visible = False
                dgvt_doc.Columns(42).Visible = False
                dgvt_doc.Columns(43).Visible = False
                dgvt_doc.Columns(44).Visible = False
                dgvt_doc.Columns(45).Visible = False
                dgvt_doc.Columns(46).Visible = False
                dgvt_doc.Columns(47).Visible = False
                'dgvt_doc.Columns(48).Visible = False
            Case 1
                Dim t_cmb As Double
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                bCuarto = "1"
                Dim dtArticulo As DataTable
                'habilitar(True)
                dtArticulo = ELTBDOCEXPBL.getListdgv(sTDoc, sSDoc, sNDoc, sFecCom, gsCode7)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'6
                                      IIf(IsDBNull(row("STATUS")), "", row("STATUS")),'7
                                      IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),'8
                                      IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")),'9
                                      IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),'10
                                      IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),'11
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'12
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'13
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), '14
                                      IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")),'15
                                      IIf(IsDBNull(row("TPRECIO_DCOMPRA")), "", row("TPRECIO_DCOMPRA")),'16
                                      IIf(IsDBNull(row("IGV")), "", row("IGV")),'17
                                      IIf(IsDBNull(row("IGV_IMPOR")), "", row("IGV_IMPOR")),'18
                                      IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),'19
                                      IIf(IsDBNull(row("UPRECIO_COMPRA")), "", row("UPRECIO_COMPRA")),'20
                                      IIf(IsDBNull(row("UPRECIO_DCOMPRA")), "", row("UPRECIO_DCOMPRA")),'21
                                      IIf(IsDBNull(row("IGV_DIMPOR")), "", row("IGV_DIMPOR")),'22
                                      IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'23
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'24
                                      IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'25
                                      IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),'26
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'27
                                      IIf(IsDBNull(row("DSCTO_IMPOR")), "", row("DSCTO_IMPOR")),'28
                                      IIf(IsDBNull(row("DSCTO_DIMPOR")), "", row("DSCTO_DIMPOR")),'29
                                      IIf(IsDBNull(row("DSCTO")), "", row("DSCTO")),'30
                                      IIf(IsDBNull(row("IES")), "", row("IES")),'31
                                      IIf(IsDBNull(row("IES_IMPOR")), "", row("IES_IMPOR")),'32
                                      IIf(IsDBNull(row("IES_DIMPOR")), "", row("IES_DIMPOR")),'33
                                      IIf(IsDBNull(row("CTA")), "", row("CTA")),'34
                                      IIf(IsDBNull(row("CTA_IMPOR")), "", row("CTA_IMPOR")),'35
                                      IIf(IsDBNull(row("CTA_DIMPOR")), "", row("CTA_DIMPOR")),'36
                                      IIf(IsDBNull(row("UPRECIO_AFECTOS")), "", row("UPRECIO_AFECTOS")),'37
                                      IIf(IsDBNull(row("UPRECIO_AFECTOD")), "", row("UPRECIO_AFECTOD")),'38
                                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'39
                                      IIf(IsDBNull(row("SDOC")), "", row("SDOC")),'40
                                      IIf(IsDBNull(row("NDOC")), "", row("NDOC")),'41
                                      IIf(IsDBNull(row("X_D")), "", row("X_D")),'42
                                      IIf(IsDBNull(row("MONTO_PAGADO")), "", row("MONTO_PAGADO")),'43
                                      IIf(IsDBNull(row("PORCENTAJE")), "", row("PORCENTAJE")),'44
                                      IIf(IsDBNull(row("CTA_CBCO")), "", row("CTA_CBCO")),'45
                                      IIf(IsDBNull(row("FARDO")), "", row("FARDO")),'46
                                      IIf(IsDBNull(row("PROGRAMA")), "", row("PROGRAMA")),'47
                                      IIf(IsDBNull(row("PESO")), "", row("PESO"))) '48
                    t_cmb = IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB"))
                Next
                npdtcamb.Value = t_cmb
                dtArticulo = ELTBDOCEXPBL.getListdgv3(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvtletras.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")),'0
                                      IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'1
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'2
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'3
                                      IIf(IsDBNull(row("EST")), "", row("EST")),'4
                                      IIf(IsDBNull(row("FEC_LETRA")), "", row("FEC_LETRA")),'5
                                      IIf(IsDBNull(row("NRO_DOC")), "", row("NRO_DOC")),'6
                                      IIf(IsDBNull(row("MONTO")), "", row("MONTO"))) '37

                Next
                Dim i As Integer
                For i = 0 To 26
                    If i <> 5 And i <> 4 Then
                        dgvt_doc.Columns(i).ReadOnly = True
                    End If
                Next
                Label18.Text = dgvt_doc.Rows.Count
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                'Me.btnborrar.Enabled = False
                'Me.btndocu.Enabled = False
                'Me.btnagregar.Enabled = False
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(11).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
                dgvt_doc.Columns(15).Visible = False
                dgvt_doc.Columns(16).Visible = False
                dgvt_doc.Columns(17).Visible = False
                dgvt_doc.Columns(18).Visible = False
                dgvt_doc.Columns(19).Visible = False
                dgvt_doc.Columns(20).Visible = False
                dgvt_doc.Columns(21).Visible = False
                dgvt_doc.Columns(22).Visible = False
                dgvt_doc.Columns(23).Visible = False
                dgvt_doc.Columns(24).Visible = False
                dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                dgvt_doc.Columns(29).Visible = False
                dgvt_doc.Columns(30).Visible = False
                dgvt_doc.Columns(31).Visible = False
                dgvt_doc.Columns(32).Visible = False
                dgvt_doc.Columns(33).Visible = False
                dgvt_doc.Columns(34).Visible = False
                dgvt_doc.Columns(35).Visible = False
                dgvt_doc.Columns(36).Visible = False
                dgvt_doc.Columns(37).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(41).Visible = False
                dgvt_doc.Columns(42).Visible = False
                dgvt_doc.Columns(43).Visible = False
                dgvt_doc.Columns(44).Visible = False
                dgvt_doc.Columns(45).Visible = False
                dgvt_doc.Columns(46).Visible = False
                dgvt_doc.Columns(47).Visible = False
                'dgvt_doc.Columns(48).Visible = False
        End Select
        bPrimero = False
        btndocu.Select()
    End Sub

    Private Sub FormMantProvisiones_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetDocExp
            'gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.txtnomart.Text = ARTICULOBL.SelectArt2(frm.txtcodart.Text)
            frm.txtunidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
            frm.txtt_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
            frm.txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(frm.txtt_doc_ref1.Text)
            frm.txtser_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            frm.txtnro_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.txtcuenta.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUENTA").Value
            frm.txtnomcuenta.Text = PROVISIONESBL.SelectNomCta(frm.txtcuenta.Text, Mid(txtmskfecprov.Text, 7, 4))
            frm.txtcuenta_dest.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUENTA_DEST").Value
            frm.txtnomcuenta_dest.Text = PROVISIONESBL.SelectNomCta(frm.txtcuenta_dest.Text, Mid(txtmskfecprov.Text, 7, 4))
            'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
            sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
            'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
            frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value)
            'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
            'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.npduprecio_compra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_COMPRA").Value)
            frm.npduprecio_dcompra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DCOMPRA").Value)
            frm.npduprecio_afectos.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_AFECTOS").Value)
            frm.npduprecio_afectod.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_AFECTOD").Value)
            frm.txttprecio_compra.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_COMPRA").Value), "N6")
            frm.txttprecio_dcompra.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DCOMPRA").Value), "N6")
            frm.txtdscto.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO").Value), "N6")
            frm.txtigv.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value), "N2")
            frm.txtigvimpor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value), "N6")
            frm.txtigv_dimpor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value), "N6")
            frm.txtdscto_impor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_DIMPOR").Value), "N6")
            frm.txtdscto_dimpor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value), "N6")
            frm.txties.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IES").Value), "N6")
            frm.txties_impor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IES_IMPOR").Value), "N6")
            frm.txties_dimpor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IES_DIMPOR").Value), "N6")
            frm.txtcta.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA").Value), "N6")
            frm.txtcta_impor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_IMPOR").Value), "N6")
            frm.txtcta_dimpor.Text = Format(Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_DIMPOR").Value), "N6")
            frm.txtcco_cod.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CCO_COD").Value
            'frm.txtnguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU2").Value
            'frm.cmbsguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CONFIGURACION").Value
            frm.npduprecio_afectos.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_AFECTOS").Value
            frm.npduprecio_afectod.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_AFECTOD").Value
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("X_D").Value = "1" Then
                frm.cmb_xd.SelectedIndex = 1
            End If
            If txtt_doc.Text <> "07" Then
                frm.txtcco_nom.Text = CCOSTOBL.SelectNom(frm.txtcco_cod.Text)
            End If

            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SIGNO").Value = "+" Then
                frm.cmbsigno.SelectedIndex = 1
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SIGNO").Value = "-" Then
                frm.cmbsigno.SelectedIndex = 2
            Else
                frm.cmbsigno.SelectedIndex = -1
            End If

            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("STATUS").Value = "AFECTO" Then
                frm.cmbstatus.SelectedIndex = 1
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("STATUS").Value = "INAFECTO" Then
                frm.cmbstatus.SelectedIndex = 2
            Else
                frm.cmbstatus.SelectedIndex = -1
            End If
            If frm.npduprecio_compra.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                frm.txttcompras.Text = Format(Math.Round((frm.npduprecio_compra.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_compra.Text * frm.npdcantidad.Text, 6), "N6")
                frm.txttcomprad.Text = Format(Math.Round(((frm.npduprecio_compra.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_compra.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text, 6), "N6")
            End If
            'frm.lblano.Text = txtmskfecprov.Value.Year
            If flagAccion = "M" Then
                If frm.npdtcamb.Value = 0 Then
                    Dim mesfecha As String
                    Dim mesdia As String
                    If Mid(txtmskfecgene.Text, 4, 2) = "1" Then
                        mesfecha = "0" & Mid(txtmskfecsbs.Text, 4, 2)
                    Else
                        mesfecha = Mid(txtmskfecsbs.Text, 4, 2)
                    End If
                    If Mid(txtmskfecsbs.Text, 1, 2) = "1" Then
                        mesdia = "0" & Mid(txtmskfecsbs.Text, 1, 2)
                    Else
                        mesdia = Mid(txtmskfecsbs.Text, 1, 2)
                    End If
                    dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                    For Each Registro In dt.Rows
                        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                        npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                    Next
                End If
                'frm.btnagregar.Enabled = False
            ElseIf flagAccion = "N" Then
                Dim mesfecha As String
                Dim mesdia As String
                If Mid(txtmskfecsbs.Text, 4, 2) = "1" Then
                    mesfecha = "0" & Mid(txtmskfecsbs.Text, 4, 2)
                Else
                    mesfecha = Mid(txtmskfecsbs.Text, 4, 2)
                End If
                If Mid(txtmskfecsbs.Text, 1, 2) = "1" Then
                    mesdia = "0" & Mid(txtmskfecsbs.Text, 1, 2)
                Else
                    mesdia = Mid(txtmskfecsbs.Text, 1, 2)
                End If
                dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                    npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next
                'frm.txtigv.Text = 18
            End If
            gContador = 0

            '----agregado
            'Dim frm As FormMantProvisiones
            'With FormMantDetProvisiones
            frm.dgvt_docdet.Columns.Add("T_DOC_REF", "Documento") '0
            frm.dgvt_docdet.Columns.Add("SER_DOC_REF", "Serie") '1
            frm.dgvt_docdet.Columns.Add("NRO_DOC_REF", "Numero") '2
            frm.dgvt_docdet.Columns.Add("T_DOC_REF1", "Documento") '3
            frm.dgvt_docdet.Columns.Add("SER_DOC_REF1", "Serie") '4
            frm.dgvt_docdet.Columns.Add("NRO_DOC_REF1", "Numero") '5
            frm.dgvt_docdet.Columns.Add("CCO_COD", "C.Costo") '6
            frm.dgvt_docdet.Columns.Add("STATUS", "Status") '7
            frm.dgvt_docdet.Columns.Add("CUENTA", "Cuenta") '8
            frm.dgvt_docdet.Columns.Add("CUENTA_DEST", "Cuenta Destino") '9
            frm.dgvt_docdet.Columns.Add("SIGNO", "Signo") '10
            frm.dgvt_docdet.Columns.Add("CTCT_COD", "Cliente") '11
            frm.dgvt_docdet.Columns.Add("CANTIDAD", "Cantidad") '12
            frm.dgvt_docdet.Columns.Add("ART_COD", "Cod. Art.") '13
            frm.dgvt_docdet.Columns.Add("UNIDAD", "Und.") '14
            frm.dgvt_docdet.Columns.Add("TPRECIO_COMPRA", "P. Compra") '15
            frm.dgvt_docdet.Columns.Add("TPRECIO_DCOMPRA", "P. Compra Dolares") '16
            frm.dgvt_docdet.Columns.Add("IGV", "IGV") '17
            frm.dgvt_docdet.Columns.Add("IGV_IMPOR", "IGV_IMPOR") '18
            frm.dgvt_docdet.Columns.Add("T_CAMB", "T_CAMB") '19
            frm.dgvt_docdet.Columns.Add("UPRECIO_COMPRA", "UPRECIO_COMPRA") '20
            frm.dgvt_docdet.Columns.Add("UPRECIO_DCOMPRA", "UPRECIO_DCOMPRA") '21
            frm.dgvt_docdet.Columns.Add("IGV_DIMPOR", "IGV_DIMPOR") '22
            frm.dgvt_docdet.Columns.Add("MONEDA", "MONEDA") '23
            frm.dgvt_docdet.Columns.Add("FEC_GENE", "FEC_GENE") '24
            frm.dgvt_docdet.Columns.Add("USUARIO", "USUARIO") '25
            frm.dgvt_docdet.Columns.Add("FEC_DIA", "FEC_DIA") '26
            frm.dgvt_docdet.Columns.Add("PROVEEDOR", "PROVEEDOR") '27
            frm.dgvt_docdet.Columns.Add("DSCTO_IMPOR", "DSCTO_IMPOR") '28
            frm.dgvt_docdet.Columns.Add("DSCTO_DIMPOR", "DSCTO_DIMPOR") '29
            frm.dgvt_docdet.Columns.Add("DSCTO", "DSCTO") '30
            frm.dgvt_docdet.Columns.Add("IES", "IES") '31
            frm.dgvt_docdet.Columns.Add("IES_IMPOR", "IES_IMPOR") '32
            frm.dgvt_docdet.Columns.Add("IES_DIMPOR", "IES_DIMPOR") '33
            frm.dgvt_docdet.Columns.Add("CTA", "CTA") '34
            frm.dgvt_docdet.Columns.Add("CTA_IMPOR", "CTA_IMPOR") '35
            frm.dgvt_docdet.Columns.Add("CTA_DIMPOR", "CTA_DIMPOR") '36
            frm.dgvt_docdet.Columns.Add("UPRECIO_AFECTOS", "UPRECIO_AFECTOS") '37
            frm.dgvt_docdet.Columns.Add("UPRECIO_AFECTOD", "UPRECIO_AFECTOD") '38
            frm.dgvt_docdet.Columns.Add("ART_NOM", "ART_NOM") '39
            frm.dgvt_docdet.Columns.Add("X_D", "X_D") '40
            frm.dgvt_docdet.Columns.Add("NRO_DOCU2", "NRO_DOCU2") '41
            frm.dgvt_docdet.Columns.Add("CONFIGURACION", "SER_DOCU2") '42

            Dim dtArticulo As DataGridView
            dtArticulo = dgvt_doc
            Dim tc As Double
            For Each row As DataGridViewRow In dtArticulo.Rows
                If IIf(IsDBNull(row.Cells("T_CAMB").Value), "", row.Cells("T_CAMB").Value) = 0 Then
                    tc = frm.npdtcamb.Value
                Else
                    tc = IIf(IsDBNull(row.Cells("T_CAMB").Value), "", row.Cells("T_CAMB").Value)
                End If
                frm.dgvt_docdet.Rows.Add(IIf(IsDBNull(row.Cells("T_DOC_REF").Value), "", row.Cells("T_DOC_REF").Value),'0
                                          IIf(IsDBNull(row.Cells("SER_DOC_REF").Value), "", row.Cells("SER_DOC_REF").Value),'1
                                          IIf(IsDBNull(row.Cells("NRO_DOC_REF").Value), "", row.Cells("NRO_DOC_REF").Value),'2
                                          IIf(IsDBNull(row.Cells("T_DOC_REF1").Value), "", row.Cells("T_DOC_REF1").Value),'3
                                          IIf(IsDBNull(row.Cells("SER_DOC_REF1").Value), "", row.Cells("SER_DOC_REF1").Value),'4
                                          IIf(IsDBNull(row.Cells("NRO_DOC_REF1").Value), "", row.Cells("NRO_DOC_REF1").Value),'5
                                          IIf(IsDBNull(row.Cells("CCO_COD").Value), "", row.Cells("CCO_COD").Value),'5
                                          IIf(IsDBNull(row.Cells("STATUS").Value), "", row.Cells("STATUS").Value),'6
                                          IIf(IsDBNull(row.Cells("CUENTA").Value), "", row.Cells("CUENTA").Value),'7
                                          IIf(IsDBNull(row.Cells("CUENTA_DEST").Value), "", row.Cells("CUENTA_DEST").Value),'8
                                          IIf(IsDBNull(row.Cells("SIGNO").Value), "", row.Cells("SIGNO").Value),'9
                                          IIf(IsDBNull(row.Cells("CTCT_COD").Value), "", row.Cells("CTCT_COD").Value),'10
                                          IIf(IsDBNull(row.Cells("CANTIDAD").Value), "", row.Cells("CANTIDAD").Value),'11
                                          IIf(IsDBNull(row.Cells("ART_COD").Value), "", row.Cells("ART_COD").Value),'12
                                          IIf(IsDBNull(row.Cells("UNIDAD").Value), "", row.Cells("UNIDAD").Value), '13
                                          IIf(IsDBNull(row.Cells("TPRECIO_COMPRA").Value), "", row.Cells("TPRECIO_COMPRA").Value),'14
                                          IIf(IsDBNull(row.Cells("TPRECIO_DCOMPRA").Value), "", row.Cells("TPRECIO_DCOMPRA").Value),'15
                                          IIf(IsDBNull(row.Cells("IGV").Value), "", row.Cells("IGV").Value),'16
                                          IIf(IsDBNull(row.Cells("IGV_IMPOR").Value), "", row.Cells("IGV_IMPOR").Value),'17
                                          tc,'18
                                          IIf(IsDBNull(row.Cells("UPRECIO_COMPRA").Value), "", row.Cells("UPRECIO_COMPRA").Value),'19
                                          IIf(IsDBNull(row.Cells("UPRECIO_DCOMPRA").Value), "", row.Cells("UPRECIO_DCOMPRA").Value),'20
                                          IIf(IsDBNull(row.Cells("IGV_DIMPOR").Value), "", row.Cells("IGV_DIMPOR").Value),'21
                                          IIf(IsDBNull(row.Cells("MONEDA").Value), "", row.Cells("MONEDA").Value),'22
                                          IIf(IsDBNull(row.Cells("FEC_GENE").Value), "", row.Cells("FEC_GENE").Value),'23
                                          IIf(IsDBNull(row.Cells("USUARIO").Value), "", row.Cells("USUARIO").Value),'24
                                          IIf(IsDBNull(row.Cells("FEC_DIA").Value), "", row.Cells("FEC_DIA").Value),'25
                                          IIf(IsDBNull(row.Cells("PROVEEDOR").Value), "", row.Cells("PROVEEDOR").Value),'26
                                          IIf(IsDBNull(row.Cells("DSCTO_IMPOR").Value), "", row.Cells("DSCTO_IMPOR").Value),'27
                                          IIf(IsDBNull(row.Cells("DSCTO_DIMPOR").Value), "", row.Cells("DSCTO_DIMPOR").Value),'28
                                          IIf(IsDBNull(row.Cells("DSCTO").Value), "", row.Cells("DSCTO").Value),'29
                                          IIf(IsDBNull(row.Cells("IES").Value), "", row.Cells("IES").Value),'30
                                          IIf(IsDBNull(row.Cells("IES_IMPOR").Value), "", row.Cells("IES_IMPOR").Value),'31
                                          IIf(IsDBNull(row.Cells("IES_DIMPOR").Value), "", row.Cells("IES_DIMPOR").Value),'32
                                          IIf(IsDBNull(row.Cells("CTA").Value), "", row.Cells("CTA").Value),'33
                                          IIf(IsDBNull(row.Cells("CTA_IMPOR").Value), "", row.Cells("CTA_IMPOR").Value),'34
                                          IIf(IsDBNull(row.Cells("CTA_DIMPOR").Value), "", row.Cells("CTA_DIMPOR").Value),'35
                                          IIf(IsDBNull(row.Cells("UPRECIO_AFECTOS").Value), "", row.Cells("UPRECIO_AFECTOS").Value),'36
                                          IIf(IsDBNull(row.Cells("UPRECIO_AFECTOD").Value), "", row.Cells("UPRECIO_AFECTOD").Value),'37
                                          IIf(IsDBNull(row.Cells("ART_NOM").Value), "", row.Cells("ART_NOM").Value),'38
                                          IIf(IsDBNull(row.Cells("X_D").Value), "", row.Cells("X_D").Value)) '39
                'IIf(IsDBNull(row.Cells("NRO_DOCU2").Value), "", row.Cells("NRO_DOCU2").Value),'40
                'IIf(IsDBNull(row.Cells("CONFIGURACION").Value), "", row.Cells("CONFIGURACION").Value)) '41
            Next
            'End With
            '--f
            gsCode5 = dgvt_doc.CurrentRow.Index
            Label34.Text = gsCode5
            frm.Label32.Text = dgvt_doc.CurrentRow.Index + 1
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtmoneda.Text = "" Then
            MsgBox("Ingrese la moneda")
            Exit Sub
        End If
        gContador = 1
        Dim dt As DataTable
        If txtproveedor.Text = "" Then
            MsgBox("Por favor seleccione un Proveedor")
            Exit Sub
        End If
        If txtnumero.Text = "" Then
            MsgBox("Por favor Ingrese Numero de Documento")
            Exit Sub
        End If
        If txtser_doc_ref.Text = "" Then
            MsgBox("Por favor Ingrese la serie del Documento")
            Exit Sub
        End If
        If txtt_doc.Text = "" Then
            MsgBox("Por favor Ingrese el tipo del Documento")
            Exit Sub
        End If
        gCliente = txtproveedor.Text
        dt = PROVISIONESBL.getT_CAMBvensbs(sFecha)
        Dim frm As New FormMantDetDocExp
        Dim mesfecha As String
        Dim mesdia As String
        'If Mid(txtmskfecgene.Text, 4, 2) = "1" Then
        mesfecha = Mid(txtmskfecsbs.Text, 4, 2).PadLeft(2, "0")
        'Else
        'mesfecha = txtmskfecgene.Text
        'End If
        'If Mid(txtmskfecgene.Text, 1, 2) = "1" Then
        mesdia = Mid(txtmskfecsbs.Text, 1, 2).PadLeft(2, "0")
        'Else
        'mesdia = Mid(txtmskfecgene.Text, 1, 2)
        'End If
        dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        If txtt_doc.Text = "07" Then
            frm.cmbsigno.Text = "-"
        Else
            frm.cmbsigno.Text = "+"
        End If
        frm.txtigv.Text = 0
        frm.modif = "0"
        frm.ShowDialog()
        frm.modif = ""
        gCliente = Nothing
    End Sub

    Private Sub btnreten_Click(sender As Object, e As EventArgs) Handles btnreten.Click
        Dim frm As New FormELTBDetProv
        Dim dt As DataTable
        Dim tc As Double
        Dim tpreciocompra As Double = 0
        If flagAccion = "N" Then
            If dgvt_doc.Rows.Count > 0 Then
                If dgvt_doc.Rows(0).Cells("CTA_CBCO").Value = "" Then
                    frm.txtcta.Text = PROVISIONESBL.SelectCuenta(txtproveedor.Text)
                    frm.txtserv.Text = PROVISIONESBL.SelectServ(txtproveedor.Text)
                    frm.npdporc.Value = PROVISIONESBL.SelectPorc(txtproveedor.Text)
                    frm.txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(frm.txtserv.Text) 'SelectNomDetra
                    'frm.txtnomope.Text = PROVISIONESBL.SelectNomDetra(frm.txtope.Text)
                    Dim mesfecha As String
                    Dim mesdia As String
                    If Mid(txtmskfecgene.Text, 4, 2) = "1" Then
                        mesfecha = "0" & Mid(txtmskfecgene.Text, 4, 2)
                    Else
                        mesfecha = Mid(txtmskfecgene.Text, 4, 2)
                    End If
                    If Mid(txtmskfecgene.Text, 1, 2) = "1" Then
                        mesdia = "0" & Mid(txtmskfecgene.Text, 1, 2)
                    Else
                        mesdia = Mid(txtmskfecgene.Text, 1, 2)
                    End If
                    dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                    For Each Registro In dt.Rows
                        tc = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                    Next
                    If txtmoneda.Text = "00" Then
                        For Each row As DataGridViewRow In dgvt_doc.Rows
                            tpreciocompra = tpreciocompra + (IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18)
                            tpreciocompra = tpreciocompra + (IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18)
                        Next
                    Else
                        For Each row As DataGridViewRow In dgvt_doc.Rows
                            tpreciocompra = tpreciocompra + ((IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))) * tc)
                            tpreciocompra = tpreciocompra + ((IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18) * tc)
                        Next
                    End If
                    frm.txttotal.Text = Math.Round(tpreciocompra, 0)
                    frm.txtpago.Text = Math.Round(tpreciocompra * frm.npdporc.Value / 100, 0)
                    frm.ShowDialog()
                Else
                    frm.txtcta.Text = dgvt_doc.Rows(0).Cells("CTA_CBCO").Value
                    frm.txtserv.Text = dgvt_doc.Rows(0).Cells("FARDO").Value
                    If dgvt_doc.Rows(0).Cells("PORCENTAJE").Value = Nothing Then
                        frm.npdporc.Value = 0
                    Else
                        frm.npdporc.Value = dgvt_doc.Rows(0).Cells("PORCENTAJE").Value
                    End If
                    frm.txtpago.Text = dgvt_doc.Rows(0).Cells("MONTO_PAGADO").Value
                    frm.txtt_ope.Text = dgvt_doc.Rows(0).Cells("PROGRAMA").Value
                    'If txtmoneda.Text = "00" Then
                    frm.txttotal.Text = txttcompras.Text
                    'Else
                    '    frm.txttotal.Text = txttcomprad.Text
                    'End If
                    frm.txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(frm.txtserv.Text)
                    frm.txtnomope.Text = PROVISIONESBL.SelectNomDetra(frm.txtt_ope.Text)
                    frm.ShowDialog()
                End If
            Else
                MsgBox("No hay datos para poder Ingresar Totales de Detraccion")
            End If
        Else
            'Dim dt As DataTable = 
            If dgvt_doc.Rows(0).Cells("CTA_CBCO").Value = "" Then
                frm.txtcta.Text = PROVISIONESBL.SelectCuenta(txtproveedor.Text)
                frm.txtserv.Text = PROVISIONESBL.SelectServ(txtproveedor.Text)
                frm.npdporc.Value = PROVISIONESBL.SelectPorc(txtproveedor.Text)
                frm.txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(frm.txtserv.Text) 'SelectNomDetra
                'frm.txtnomope.Text = PROVISIONESBL.SelectNomDetra(frm.txtope.Text)
                Dim mesfecha As String
                Dim mesdia As String
                If Mid(txtmskfecgene.Text, 4, 2) = "1" Then
                    mesfecha = "0" & Mid(txtmskfecgene.Text, 4, 2)
                Else
                    mesfecha = Mid(txtmskfecgene.Text, 4, 2)
                End If
                If Mid(txtmskfecgene.Text, 1, 2) = "1" Then
                    mesdia = "0" & Mid(txtmskfecgene.Text, 1, 2)
                Else
                    mesdia = Mid(txtmskfecgene.Text, 1, 2)
                End If
                dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecgene.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                For Each Registro In dt.Rows
                    tc = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next
                If txtmoneda.Text = "00" Then
                    For Each row As DataGridViewRow In dgvt_doc.Rows
                        tpreciocompra = tpreciocompra + (IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18)
                        tpreciocompra = tpreciocompra + (IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18)
                    Next
                Else
                    For Each row As DataGridViewRow In dgvt_doc.Rows
                        tpreciocompra = tpreciocompra + ((IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))) * tc)
                        tpreciocompra = tpreciocompra + ((IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18) * tc)
                    Next
                End If
                frm.txttotal.Text = Math.Round(tpreciocompra, 0)
                frm.txtpago.Text = Math.Round(tpreciocompra * frm.npdporc.Value / 100, 0)
                frm.ShowDialog()
            Else
                frm.txtcta.Text = dgvt_doc.Rows(0).Cells("CTA_CBCO").Value
                frm.txtserv.Text = dgvt_doc.Rows(0).Cells("FARDO").Value
                frm.txtt_ope.Text = dgvt_doc.Rows(0).Cells("PROGRAMA").Value
                If dgvt_doc.Rows(0).Cells("PORCENTAJE").Value = Nothing Then
                    frm.npdporc.Value = 0
                Else
                    frm.npdporc.Value = dgvt_doc.Rows(0).Cells("PORCENTAJE").Value
                End If
                If txtmoneda.Text = "00" Then
                    For Each row As DataGridViewRow In dgvt_doc.Rows
                        tpreciocompra = tpreciocompra + (IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18)
                        tpreciocompra = tpreciocompra + (IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18)
                    Next
                Else
                    For Each row As DataGridViewRow In dgvt_doc.Rows
                        tpreciocompra = tpreciocompra + ((IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))) * tc)
                        tpreciocompra = tpreciocompra + ((IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)) * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)) * 1.18) * tc)
                    Next
                End If
                frm.txtpago.Text = dgvt_doc.Rows(0).Cells("MONTO_PAGADO").Value
                frm.txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(frm.txtserv.Text)
                frm.txtnomope.Text = PROVISIONESBL.SelectNomDetra(frm.txtt_ope.Text)
                frm.txttotal.Text = Math.Round(tpreciocompra, 0)
                frm.ShowDialog()
            End If

        End If
    End Sub

    Private Sub btnletras_Click(sender As Object, e As EventArgs) Handles btnletras.Click
        Dim frm As New FormLetrasCompras
        frm.dgvt_doc.Columns.Add("CODIGO", "Cod.") '0
        frm.dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '1
        frm.dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '2
        frm.dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '3
        'frm.dgvt_doc.Columns.Add("EST", "ESTADO") '4
        frm.dgvt_doc.Columns.Add("FEC_LETRA", "Fec. Letra") '5
        frm.dgvt_doc.Columns.Add("NRO_DOC", "Nro. Docu") '6
        frm.dgvt_doc.Columns.Add("MONTO", "Monto Soles") '7
        frm.dgvt_doc.Columns.Add("MONTOD", "Monto Dolares") '7
        frm.dgvt_doc.Columns.Add("PROVEEDOR", "Proveedor") '7
        frm.dgvt_doc.Columns.Add("T_CMB", "T. Cambio") '7
        frm.dgvt_doc.Columns.Add("Moneda", "Moneda") '7
        If dgvtletras.Rows.Count > 0 Then

            frm.txtt_doc.Text = txtt_doc.Text
            frm.txtser_doc.Text = txtser_doc_ref.Text
            frm.txtnro_doc.Text = txtnumero.Text
            frm.txtmoneda.Text = txtmoneda.Text
            frm.txtproveedor.Text = txtproveedor.Text
            Dim dtArticulo As DataGridView
            dtArticulo = dgvtletras

            For Each row As DataGridViewRow In dtArticulo.Rows
                frm.dgvt_doc.Rows.Add(IIf(IsDBNull(row.Cells("CODIGO").Value), "", row.Cells("CODIGO").Value),'0
                                      IIf(IsDBNull(row.Cells("T_DOC_REF").Value), "", row.Cells("T_DOC_REF").Value),'0
                                      IIf(IsDBNull(row.Cells("SER_DOC_REF").Value), "", row.Cells("SER_DOC_REF").Value),'1
                                      IIf(IsDBNull(row.Cells("NRO_DOC_REF").Value), "", row.Cells("NRO_DOC_REF").Value),'2
                                      IIf(IsDBNull(row.Cells("FEC_LETRA").Value), "", row.Cells("FEC_LETRA").Value),
                                      IIf(IsDBNull(row.Cells("NRO_DOC").Value), "", row.Cells("NRO_DOC").Value),'2
                                      IIf(IsDBNull(row.Cells("MONTO").Value), 0, row.Cells("MONTO").Value),'2
                                      IIf(IsDBNull(row.Cells("MONTOD").Value), 0, row.Cells("MONTOD").Value),'2
                                      IIf(IsDBNull(row.Cells("PROVEEDOR").Value), 0, row.Cells("PROVEEDOR").Value),'2
                                      IIf(IsDBNull(row.Cells("T_CMB").Value), 0, row.Cells("T_CMB").Value),'2
                                      IIf(IsDBNull(row.Cells("MONEDA").Value), 0, row.Cells("MONEDA").Value)) '3

            Next
            frm.ShowDialog()
        Else
            frm.txtt_doc.Text = txtt_doc.Text
            frm.txtser_doc.Text = txtser_doc_ref.Text
            frm.txtnro_doc.Text = txtnumero.Text
            frm.txtmoneda.Text = txtmoneda.Text
            frm.txtproveedor.Text = txtproveedor.Text

            If txtmoneda.Text = "00" Then
                frm.npdmontod.Enabled = False
                frm.npdmonto.Enabled = True
            Else
                frm.npdmontod.Enabled = True
                frm.npdmonto.Enabled = False
            End If
            frm.ShowDialog()
        End If
    End Sub

    Private Sub dgvt_doc_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt_doc.CellDoubleClick
        Dim dt As DataTable
        If txtmoneda.TextLength > 0 Then
            If dgvt_doc.Rows.Count > 0 Then
                Dim frm As New FormMantDetDocExp
                'gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
                frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
                frm.txtnomart.Text = ARTICULOBL.SelectArt2(frm.txtcodart.Text)
                frm.txtunidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
                frm.txtt_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
                frm.txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(frm.txtt_doc_ref1.Text)
                frm.txtser_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                frm.txtnro_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                frm.txtcuenta.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUENTA").Value
                frm.txtcuenta_dest.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
                frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                frm.npduprecio_compra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_COMPRA").Value)
                frm.npduprecio_dcompra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DCOMPRA").Value)
                frm.npduprecio_afectos.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_AFECTOS").Value)
                frm.npduprecio_afectod.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_AFECTOD").Value)
                frm.txttprecio_compra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_COMPRA").Value)
                frm.txttprecio_dcompra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DCOMPRA").Value)
                frm.txtdscto.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO").Value)
                frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                frm.txtigvimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value)
                frm.txtigv_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value)
                frm.txtdscto_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_DIMPOR").Value)
                frm.txtdscto_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
                frm.txties.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IES").Value)
                frm.txties_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IES_IMPOR").Value)
                frm.txties_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IES_DIMPOR").Value)
                frm.txtcta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA").Value)
                frm.txtcta_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_IMPOR").Value)
                frm.txtcta_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_DIMPOR").Value)
                frm.txtcco_cod.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CCO_COD").Value
                frm.txtcco_nom.Text = CCOSTOBL.SelectNom(frm.txtcco_cod.Text)
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("X_D").Value = "1" Then
                    frm.cmb_xd.SelectedIndex = 1
                End If
                If txtt_doc.Text <> "07" Then
                    frm.txtcco_nom.Text = CCOSTOBL.SelectNom(frm.txtcco_cod.Text)
                End If
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SIGNO").Value = "+" Then
                    frm.cmbsigno.SelectedIndex = 1
                ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SIGNO").Value = "-" Then
                    frm.cmbsigno.SelectedIndex = 2
                Else
                    frm.cmbsigno.SelectedIndex = -1
                End If

                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("STATUS").Value = "AFECTO" Then
                    frm.cmbstatus.SelectedIndex = 1
                ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("STATUS").Value = "INAFECTO" Then
                    frm.cmbstatus.SelectedIndex = 2
                Else
                    frm.cmbstatus.SelectedIndex = -1
                End If
                If frm.npduprecio_compra.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                    frm.txttcompras.Text = Math.Round((frm.npduprecio_compra.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_compra.Text * frm.npdcantidad.Text, 6)
                    frm.txttcomprad.Text = Math.Round(((frm.npduprecio_compra.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_compra.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text, 6)
                End If
                If flagAccion = "M" Then
                    If frm.npdtcamb.Value = 0 Then
                        Dim mesfecha As String
                        Dim mesdia As String
                        If Mid(txtmskfecsbs.Text, 4, 2) = "1" Then
                            mesfecha = "0" & Mid(txtmskfecsbs.Text, 4, 2)
                        Else
                            mesfecha = Mid(txtmskfecsbs.Text, 4, 2)
                        End If
                        If Mid(txtmskfecsbs.Text, 1, 2) = "1" Then
                            mesdia = "0" & Mid(txtmskfecsbs.Text, 1, 2)
                        Else
                            mesdia = Mid(txtmskfecsbs.Text, 1, 2)
                        End If
                        dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                        For Each Registro In dt.Rows
                            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                            npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                        Next
                    End If
                ElseIf flagAccion = "N" Then
                    Dim mesfecha As String
                    Dim mesdia As String
                    If Mid(txtmskfecsbs.Text, 4, 2) = "1" Then
                        mesfecha = "0" & Mid(txtmskfecsbs.Text, 4, 2)
                    Else
                        mesfecha = Mid(txtmskfecsbs.Text, 4, 2)
                    End If
                    If Mid(txtmskfecsbs.Text, 1, 2) = "1" Then
                        mesdia = "0" & Mid(txtmskfecsbs.Text, 1, 2)
                    Else
                        mesdia = Mid(txtmskfecsbs.Text, 1, 2)
                    End If
                    dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
                    For Each Registro In dt.Rows
                        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                    Next
                    frm.txtigv.Text = 18
                End If
                gContador = 0

                '----agregado
                'Dim frm As FormMantProvisiones
                'With FormMantDetProvisiones
                frm.dgvt_docdet.Columns.Add("T_DOC_REF", "Documento") '0
                frm.dgvt_docdet.Columns.Add("SER_DOC_REF", "Serie") '1
                frm.dgvt_docdet.Columns.Add("NRO_DOC_REF", "Numero") '2
                frm.dgvt_docdet.Columns.Add("T_DOC_REF1", "Documento") '3
                frm.dgvt_docdet.Columns.Add("SER_DOC_REF1", "Serie") '4
                frm.dgvt_docdet.Columns.Add("NRO_DOC_REF1", "Numero") '5
                frm.dgvt_docdet.Columns.Add("CCO_COD", "C.Costo") '5
                frm.dgvt_docdet.Columns.Add("STATUS", "Status") '6
                frm.dgvt_docdet.Columns.Add("CUENTA", "Cuenta") '7
                frm.dgvt_docdet.Columns.Add("CUENTA_DEST", "Cuenta Destino") '8
                frm.dgvt_docdet.Columns.Add("SIGNO", "Signo") '9
                frm.dgvt_docdet.Columns.Add("CTCT_COD", "Cliente") '10
                frm.dgvt_docdet.Columns.Add("CANTIDAD", "Cantidad") '11
                frm.dgvt_docdet.Columns.Add("ART_COD", "Cod. Art.") '12
                frm.dgvt_docdet.Columns.Add("UNIDAD", "Und.") '13
                frm.dgvt_docdet.Columns.Add("TPRECIO_COMPRA", "P. Compra") '14
                frm.dgvt_docdet.Columns.Add("TPRECIO_DCOMPRA", "P. Compra Dolares") '15
                frm.dgvt_docdet.Columns.Add("IGV", "IGV") '16
                frm.dgvt_docdet.Columns.Add("IGV_IMPOR", "IGV_IMPOR") '17
                frm.dgvt_docdet.Columns.Add("T_CAMB", "T_CAMB") '18
                frm.dgvt_docdet.Columns.Add("UPRECIO_COMPRA", "UPRECIO_COMPRA") '19
                frm.dgvt_docdet.Columns.Add("UPRECIO_DCOMPRA", "UPRECIO_DCOMPRA") '20
                frm.dgvt_docdet.Columns.Add("IGV_DIMPOR", "IGV_DIMPOR") '21
                frm.dgvt_docdet.Columns.Add("MONEDA", "MONEDA") '22
                frm.dgvt_docdet.Columns.Add("FEC_GENE", "FEC_GENE") '23
                frm.dgvt_docdet.Columns.Add("USUARIO", "USUARIO") '24
                frm.dgvt_docdet.Columns.Add("FEC_DIA", "FEC_DIA") '25
                frm.dgvt_docdet.Columns.Add("PROVEEDOR", "PROVEEDOR") '26
                frm.dgvt_docdet.Columns.Add("DSCTO_IMPOR", "DSCTO_IMPOR") '27
                frm.dgvt_docdet.Columns.Add("DSCTO_DIMPOR", "DSCTO_DIMPOR") '28
                frm.dgvt_docdet.Columns.Add("DSCTO", "DSCTO") '29
                frm.dgvt_docdet.Columns.Add("IES", "IES") '30
                frm.dgvt_docdet.Columns.Add("IES_IMPOR", "IES_IMPOR") '31
                frm.dgvt_docdet.Columns.Add("IES_DIMPOR", "IES_DIMPOR") '32
                frm.dgvt_docdet.Columns.Add("CTA", "CTA") '33
                frm.dgvt_docdet.Columns.Add("CTA_IMPOR", "CTA_IMPOR") '34
                frm.dgvt_docdet.Columns.Add("CTA_DIMPOR", "CTA_DIMPOR") '35
                frm.dgvt_docdet.Columns.Add("UPRECIO_AFECTOS", "UPRECIO_AFECTOS") '36
                frm.dgvt_docdet.Columns.Add("UPRECIO_AFECTOD", "UPRECIO_AFECTOD") '37
                frm.dgvt_docdet.Columns.Add("ART_NOM", "ART_NOM") '38
                frm.dgvt_docdet.Columns.Add("X_D", "X_D") '39
                frm.dgvt_docdet.Columns.Add("NRO_DOCU2", "NRO_DOCU2") '41
                frm.dgvt_docdet.Columns.Add("CONFIGURACION", "SER_DOCU2") '42
                Dim dtArticulo As DataGridView
                dtArticulo = dgvt_doc
                Dim tc As Double
                For Each row As DataGridViewRow In dtArticulo.Rows
                    If IIf(IsDBNull(row.Cells("T_CAMB").Value), "", row.Cells("T_CAMB").Value) = 0 Then
                        tc = frm.npdtcamb.Value
                    Else
                        tc = IIf(IsDBNull(row.Cells("T_CAMB").Value), "", row.Cells("T_CAMB").Value)
                    End If
                    frm.dgvt_docdet.Rows.Add(IIf(IsDBNull(row.Cells("T_DOC_REF").Value), "", row.Cells("T_DOC_REF").Value),'0
                                          IIf(IsDBNull(row.Cells("SER_DOC_REF").Value), "", row.Cells("SER_DOC_REF").Value),'1
                                          IIf(IsDBNull(row.Cells("NRO_DOC_REF").Value), "", row.Cells("NRO_DOC_REF").Value),'2
                                          IIf(IsDBNull(row.Cells("T_DOC_REF1").Value), "", row.Cells("T_DOC_REF1").Value),'3
                                          IIf(IsDBNull(row.Cells("SER_DOC_REF1").Value), "", row.Cells("SER_DOC_REF1").Value),'4
                                          IIf(IsDBNull(row.Cells("NRO_DOC_REF1").Value), "", row.Cells("NRO_DOC_REF1").Value),'5
                                          IIf(IsDBNull(row.Cells("CCO_COD").Value), "", row.Cells("CCO_COD").Value),'5
                                          IIf(IsDBNull(row.Cells("STATUS").Value), "", row.Cells("STATUS").Value),'6
                                          IIf(IsDBNull(row.Cells("CUENTA").Value), "", row.Cells("CUENTA").Value),'7
                                          IIf(IsDBNull(row.Cells("CUENTA_DEST").Value), "", row.Cells("CUENTA_DEST").Value),'8
                                          IIf(IsDBNull(row.Cells("SIGNO").Value), "", row.Cells("SIGNO").Value),'9
                                          IIf(IsDBNull(row.Cells("CTCT_COD").Value), "", row.Cells("CTCT_COD").Value),'10
                                          IIf(IsDBNull(row.Cells("CANTIDAD").Value), "", row.Cells("CANTIDAD").Value),'11
                                          IIf(IsDBNull(row.Cells("ART_COD").Value), "", row.Cells("ART_COD").Value),'12
                                          IIf(IsDBNull(row.Cells("UNIDAD").Value), "", row.Cells("UNIDAD").Value), '13
                                          IIf(IsDBNull(row.Cells("TPRECIO_COMPRA").Value), "", row.Cells("TPRECIO_COMPRA").Value),'14
                                          IIf(IsDBNull(row.Cells("TPRECIO_DCOMPRA").Value), "", row.Cells("TPRECIO_DCOMPRA").Value),'15
                                          IIf(IsDBNull(row.Cells("IGV").Value), "", row.Cells("IGV").Value),'16
                                          IIf(IsDBNull(row.Cells("IGV_IMPOR").Value), "", row.Cells("IGV_IMPOR").Value),'17
                                          tc,'18
                                          IIf(IsDBNull(row.Cells("UPRECIO_COMPRA").Value), "", row.Cells("UPRECIO_COMPRA").Value),'19
                                          IIf(IsDBNull(row.Cells("UPRECIO_DCOMPRA").Value), "", row.Cells("UPRECIO_DCOMPRA").Value),'20
                                          IIf(IsDBNull(row.Cells("IGV_DIMPOR").Value), "", row.Cells("IGV_DIMPOR").Value),'21
                                          IIf(IsDBNull(row.Cells("MONEDA").Value), "", row.Cells("MONEDA").Value),'22
                                          IIf(IsDBNull(row.Cells("FEC_GENE").Value), "", row.Cells("FEC_GENE").Value),'23
                                          IIf(IsDBNull(row.Cells("USUARIO").Value), "", row.Cells("USUARIO").Value),'24
                                          IIf(IsDBNull(row.Cells("FEC_DIA").Value), "", row.Cells("FEC_DIA").Value),'25
                                          IIf(IsDBNull(row.Cells("PROVEEDOR").Value), "", row.Cells("PROVEEDOR").Value),'26
                                          IIf(IsDBNull(row.Cells("DSCTO_IMPOR").Value), "", row.Cells("DSCTO_IMPOR").Value),'27
                                          IIf(IsDBNull(row.Cells("DSCTO_DIMPOR").Value), "", row.Cells("DSCTO_DIMPOR").Value),'28
                                          IIf(IsDBNull(row.Cells("DSCTO").Value), "", row.Cells("DSCTO").Value),'29
                                          IIf(IsDBNull(row.Cells("IES").Value), "", row.Cells("IES").Value),'30
                                          IIf(IsDBNull(row.Cells("IES_IMPOR").Value), "", row.Cells("IES_IMPOR").Value),'31
                                          IIf(IsDBNull(row.Cells("IES_DIMPOR").Value), "", row.Cells("IES_DIMPOR").Value),'32
                                          IIf(IsDBNull(row.Cells("CTA").Value), "", row.Cells("CTA").Value),'33
                                          IIf(IsDBNull(row.Cells("CTA_IMPOR").Value), "", row.Cells("CTA_IMPOR").Value),'34
                                          IIf(IsDBNull(row.Cells("CTA_DIMPOR").Value), "", row.Cells("CTA_DIMPOR").Value),'35
                                          IIf(IsDBNull(row.Cells("UPRECIO_AFECTOS").Value), "", row.Cells("UPRECIO_AFECTOS").Value),'36
                                          IIf(IsDBNull(row.Cells("UPRECIO_AFECTOD").Value), "", row.Cells("UPRECIO_AFECTOD").Value),'37
                                          IIf(IsDBNull(row.Cells("ART_NOM").Value), "", row.Cells("ART_NOM").Value),
                                          IIf(IsDBNull(row.Cells("X_D").Value), "", row.Cells("X_D").Value)) '38
                Next
                'End With
                '--f
                gsCode5 = dgvt_doc.CurrentRow.Index
                Label34.Text = gsCode5
                frm.Label32.Text = dgvt_doc.CurrentRow.Index + 1
                frm.ShowDialog()
            Else
                MsgBox("No hay items en la lista para modificar")
            End If
        Else
            MsgBox("Por favor Ingrese el tipo de Moneda")
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            'If MessageBox.Show("Esta seguro de Eliminar el Registro",
            '               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            '               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

            '    Exit Sub
            'End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuProvExp
        'If txtt_doc.Text = "07" Then
        '    gnOpcion3 = "1"
        '    'frm.rdboreq.Visible = False
        '    frm.rdbrdoc.Visible = False
        'Else
        gnOpcion3 = "0"
        ' End If

        frm.ShowDialog()
    End Sub

#Region "Txt y CMB"
    Private Sub txtt_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_doc.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "102"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtt_doc.Text = gLinea
                cmbt_doc.SelectedValue = gLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            txtope.Focus()
        End If
    End Sub

    Private Sub txtope_KeyDown(sender As Object, e As KeyEventArgs) Handles txtope.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "103"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtope.Text = gLinea
                cmbtopenom.SelectedValue = gLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            txtser_doc_ref.Focus()
        End If
    End Sub

    Private Sub txtmoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmoneda.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "104"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtmoneda.Text = gLinea
                txtnom_moneda.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            cmbest1.Focus()
        End If
    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "105"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtproveedor.Text = gLinea
                txtnomproveedor.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            txtobserva.Focus()
        End If
    End Sub

    Private Sub txtt_doc_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc.LostFocus
        If txtt_doc.TextLength > 0 Then
            cmbt_doc.SelectedValue = txtt_doc.Text
        Else
            txtt_doc.Text = ""
            cmbt_doc.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtope_LostFocus(sender As Object, e As EventArgs) Handles txtope.LostFocus
        If txtope.TextLength > 0 Then
            cmbtopenom.SelectedValue = txtope.Text
        Else
            txtope.Text = ""
            cmbtopenom.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtproveedor_LostFocus(sender As Object, e As EventArgs) Handles txtproveedor.LostFocus
        If txtproveedor.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtproveedor.Text)
            If prov.Length > 0 Then
                txtnomproveedor.Text = prov
            Else
                txtnomproveedor.Text = ""
            End If
        Else
            txtproveedor.Text = ""
            txtnomproveedor.Text = ""
        End If
    End Sub

    Private Sub txttipo2_LostFocus(sender As Object, e As EventArgs) Handles txttipo2.LostFocus
        If txttipo2.TextLength > 0 Then
            Dim prov1 As String = PROVISIONESBL.SelectBS_SSrow(txttipo2.Text)
            If prov1.Length > 0 Then
                txtnom_bs_ss.Text = prov1
            Else
                txtnom_bs_ss.Text = ""
            End If
        Else
            txttipo2.Text = ""
            txtnom_bs_ss.Text = ""
        End If
    End Sub

    Private Sub txttipo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipo2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "107"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txttipo2.Text = gLinea
                txtnom_bs_ss.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            txtt_cmp.Focus()
        End If
    End Sub

    Private Sub txtmoneda_LostFocus(sender As Object, e As EventArgs) Handles txtmoneda.LostFocus
        If txtmoneda.TextLength > 0 Then
            Dim prov1 As String = PROVISIONESBL.Select_MON_row(txtmoneda.Text)
            If prov1.Length > 0 Then
                txtnom_moneda.Text = prov1
            Else
                txtnom_moneda.Text = ""
            End If
        Else
            txtmoneda.Text = ""
            txtnom_moneda.Text = ""
        End If
    End Sub

    Private Sub txtnumero_LostFocus(sender As Object, e As EventArgs) Handles txtnumero.LostFocus
        If dgvt_doc.Rows.Count > 0 Then
            If dgvt_doc.Rows(0).Cells("T_DOC_REF").Value = "" Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    dgvt_doc.Rows(i).Cells("T_DOC_REF").Value = txtt_doc.Text
                    dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value = txtser_doc_ref.Text
                    dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = txtnumero.Text
                Next
            End If
        End If
    End Sub

    Private Sub txtser_doc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtser_doc_ref.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnumero.Focus()
        End If
    End Sub

    Private Sub txtnumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumero.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtmskfecprov.Focus()
        End If
    End Sub

    Private Sub cmbarticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbarticulo.KeyDown
        If e.KeyValue = Keys.Enter Then
            txttipo2.Focus()
        End If
    End Sub

    Private Sub txtobserva_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobserva.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmbarticulo.Focus()
        End If
    End Sub

    Private Sub cmbest1_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbest1.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmb_x_ret.Focus()
        End If
    End Sub

    Private Sub cmb_x_ret_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_x_ret.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnro_detrac.Focus()
        End If
    End Sub

    Private Sub txtnro_detrac_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnro_detrac.KeyDown
        If e.KeyValue = Keys.Enter Then
            If txtnro_detrac.TextLength > 0 Then
                'dtpfec_det.Checked = True
                txtmskfecdet.Focus()
            Else
                'dtpfec_det.Checked = False
                txtletra.Focus()
            End If

        End If
    End Sub

    Private Sub dtpfec_det_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfec_det.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtletra.Focus()
        End If
    End Sub

    Private Sub txtletra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtletra.KeyDown
        If e.KeyValue = Keys.Enter Then
            If txtletra.TextLength > 0 Then
                'dtpfec_det.Checked = True
                txtmskfecletra.Focus()
            Else
                'dtpfec_det.Checked = False
                'txtletra.Focus()
                dgvt_doc.Select()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtnro_percepcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnro_percepcion.KeyDown
        If e.KeyValue = Keys.Enter Then
            npdadvalore.Focus()
        End If
    End Sub

    Private Sub npdadvalore_Leave(sender As Object, e As EventArgs) Handles npdadvalore.Leave
        npdadvalore.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub npdadvalore_Enter(sender As Object, e As EventArgs) Handles npdadvalore.Enter
        npdadvalore.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtt_doc_Leave(sender As Object, e As EventArgs) Handles txtt_doc.Leave
        txtt_doc.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtt_doc_Enter(sender As Object, e As EventArgs) Handles txtt_doc.Enter
        txtt_doc.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtt_cmp_Leave(sender As Object, e As EventArgs) Handles txtt_cmp.Leave
        txtt_cmp.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtt_cmp_Enter(sender As Object, e As EventArgs) Handles txtt_cmp.Enter
        txtt_cmp.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub cmb_año_cmp_Leave(sender As Object, e As EventArgs) Handles cmb_año_cmp.Leave
        cmb_año_cmp.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmb_año_cmp_Enter(sender As Object, e As EventArgs) Handles cmb_año_cmp.Enter
        cmb_año_cmp.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmb_pais_Leave(sender As Object, e As EventArgs) Handles cmb_pais.Leave
        cmb_pais.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmb_pais_Enter(sender As Object, e As EventArgs) Handles cmb_pais.Enter
        cmb_pais.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub txts_comp_Leave(sender As Object, e As EventArgs) Handles txts_comp.Leave
        txts_comp.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txts_comp_Enter(sender As Object, e As EventArgs) Handles txts_comp.Enter
        txts_comp.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtn_cmp_Enter(sender As Object, e As EventArgs) Handles txtn_cmp.Enter
        txtn_cmp.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtn_cmp_Leave(sender As Object, e As EventArgs) Handles txtn_cmp.Leave
        txtn_cmp.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txt_conv_Enter(sender As Object, e As EventArgs) Handles txt_conv.Enter
        txt_conv.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txt_conv_Leave(sender As Object, e As EventArgs) Handles txt_conv.Leave
        txt_conv.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtt_renta_Enter(sender As Object, e As EventArgs) Handles txtt_renta.Enter
        txtt_renta.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtt_renta_Leave(sender As Object, e As EventArgs) Handles txtt_renta.Leave
        txtt_renta.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtest_oport_Enter(sender As Object, e As EventArgs) Handles txtest_oport.Enter
        txtest_oport.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtest_oport_Leave(sender As Object, e As EventArgs) Handles txtest_oport.Leave
        txtest_oport.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtnumero_Enter(sender As Object, e As EventArgs) Handles txtnumero.Enter
        txtnumero.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtnumero_Leave(sender As Object, e As EventArgs) Handles txtnumero.Leave
        txtnumero.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub cmbarticulo_Enter(sender As Object, e As EventArgs) Handles cmbarticulo.Enter
        cmbarticulo.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbarticulo_Leave(sender As Object, e As EventArgs) Handles cmbarticulo.Leave
        cmbarticulo.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmb_x_ret_Enter(sender As Object, e As EventArgs) Handles cmb_x_ret.Enter
        cmb_x_ret.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmb_x_ret_Leave(sender As Object, e As EventArgs) Handles cmb_x_ret.Leave
        cmb_x_ret.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmbt_doc_Enter(sender As Object, e As EventArgs) Handles cmbt_doc.Enter
        cmbt_doc.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbt_doc_Leave(sender As Object, e As EventArgs) Handles cmbt_doc.Leave
        cmbt_doc.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmbtopenom_Enter(sender As Object, e As EventArgs) Handles cmbtopenom.Enter
        cmbtopenom.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbtopenom_Leave(sender As Object, e As EventArgs) Handles cmbtopenom.Leave
        cmbtopenom.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmbest_Enter(sender As Object, e As EventArgs) Handles cmbest.Enter
        cmbest.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbest_Leave(sender As Object, e As EventArgs) Handles cmbest.Leave
        cmbest.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub cmbest1_Enter(sender As Object, e As EventArgs) Handles cmbest1.Enter
        cmbest1.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbest1_Leave(sender As Object, e As EventArgs) Handles cmbest1.Leave
        cmbest1.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub txtope_Leave(sender As Object, e As EventArgs) Handles txtope.Leave
        txtope.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtope_Enter(sender As Object, e As EventArgs) Handles txtope.Enter
        txtope.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtser_doc_ref_Leave(sender As Object, e As EventArgs) Handles txtser_doc_ref.Leave
        txtser_doc_ref.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtser_doc_ref_Enter(sender As Object, e As EventArgs) Handles txtser_doc_ref.Enter
        txtser_doc_ref.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtproveedor_Enter(sender As Object, e As EventArgs) Handles txtproveedor.Enter
        txtproveedor.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtproveedor_Leave(sender As Object, e As EventArgs) Handles txtproveedor.Leave
        txtproveedor.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtobserva_Enter(sender As Object, e As EventArgs) Handles txtobserva.Enter
        txtobserva.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtobserva_Leave(sender As Object, e As EventArgs) Handles txtobserva.Leave
        txtobserva.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtnro_percepcion_Enter(sender As Object, e As EventArgs) Handles txtnro_percepcion.Enter
        txtnro_percepcion.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtnro_percepcion_Leave(sender As Object, e As EventArgs) Handles txtnro_percepcion.Leave
        txtnro_percepcion.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txttipo2_Enter(sender As Object, e As EventArgs) Handles txttipo2.Enter
        txttipo2.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txttipo2_Leave(sender As Object, e As EventArgs) Handles txttipo2.Leave
        txttipo2.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtmoneda_Enter(sender As Object, e As EventArgs) Handles txtmoneda.Enter
        txtmoneda.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtmoneda_Leave(sender As Object, e As EventArgs) Handles txtmoneda.Leave
        txtmoneda.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtmasked_LostFocus(sender As Object, e As EventArgs) Handles txtmskfecprov.LostFocus
        Dim fecprov As String = Replace(txtmskfecprov.Text, "/", "")
        Dim fecprov1 As String = Replace(fecprov, "_", "")
        Dim fecprov2 As String = Replace(fecprov1, " ", "")
        'contador = 0
        Try
            txtmskfecprov.Text = CDate(txtmskfecprov.Text)
        Catch ex As Exception
            'MsgBox(Replace(fecprov, "_", "").Length)
            'MsgBox(fecprov2.Length)
            'contador = contador + 1
            'If contador = 1 Then
            If fecprov2.Length < 10 And fecprov2.Length > 0 Then
                MsgBox("Completa la fecha")
                txtmskfecprov.Focus()
                Exit Sub
            End If
            'Else
            '    Exit Sub
            '    'txtmskfecprov.Focus()
            'End If
        End Try
    End Sub

    Private Sub txtmskfecprov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmskfecprov.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtmskfecgene.Focus()
        End If
    End Sub

    Private Sub txtmskfecprov_Leave(sender As Object, e As EventArgs) Handles txtmskfecprov.Leave
        txtmskfecprov.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtmskfecprov_Enter(sender As Object, e As EventArgs) Handles txtmskfecprov.Enter
        txtmskfecprov.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtmskfecgene_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmskfecgene.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtproveedor.Focus()
        End If
    End Sub

    Private Sub txtmskfecgene_Leave(sender As Object, e As EventArgs) Handles txtmskfecgene.Leave
        txtmskfecgene.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtmskfecgene_Enter(sender As Object, e As EventArgs) Handles txtmskfecgene.Enter
        txtmskfecgene.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtmskfecdet_LostFocus(sender As Object, e As EventArgs) Handles txtmskfecdet.LostFocus
        Dim fecprov As String = Replace(txtmskfecdet.Text, "/", "")
        Dim fecprov1 As String = Replace(fecprov, "_", "")
        Dim fecprov2 As String = Replace(fecprov1, " ", "")
        'contador = 0
        Try
            txtmskfecdet.Text = CDate(txtmskfecdet.Text)
        Catch ex As Exception
            'MsgBox(Replace(fecprov, "_", "").Length)
            'MsgBox(fecprov2.Length)
            'contador = contador + 1
            'If contador = 1 Then
            If fecprov2.Length < 10 And fecprov2.Length > 0 Then
                MsgBox("Completa la fecha")
                txtmskfecdet.Focus()
                Exit Sub
            End If
            'Else
            '    Exit Sub
            '    'txtmskfecprov.Focus()
            'End If
        End Try
    End Sub

    Private Sub txtmskfecdet_Leave(sender As Object, e As EventArgs) Handles txtmskfecdet.Leave
        txtmskfecdet.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtmskfecdet_Enter(sender As Object, e As EventArgs) Handles txtmskfecdet.Enter
        txtmskfecdet.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtmskfecdet_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmskfecdet.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtletra.Focus()
        End If
    End Sub

    Private Sub txtmskfecletra_LostFocus(sender As Object, e As EventArgs) Handles txtmskfecletra.LostFocus
        Dim fecprov As String = Replace(txtmskfecletra.Text, "/", "")
        Dim fecprov1 As String = Replace(fecprov, "_", "")
        Dim fecprov2 As String = Replace(fecprov1, " ", "")
        'contador = 0
        Try
            txtmskfecletra.Text = CDate(txtmskfecletra.Text)
        Catch ex As Exception
            'MsgBox(Replace(fecprov, "_", "").Length)
            'MsgBox(fecprov2.Length)
            'contador = contador + 1
            'If contador = 1 Then
            If fecprov2.Length < 10 And fecprov2.Length > 0 Then
                MsgBox("Completa la fecha")
                txtmskfecletra.Focus()
                Exit Sub
            End If
            'Else
            '    Exit Sub
            '    'txtmskfecprov.Focus()
            'End If
        End Try
    End Sub

    Private Sub txtmskfecletra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmskfecletra.KeyDown
        'VER
        If e.KeyValue = Keys.Enter Then
            'dgvt_doc.Rows
            If dgvt_doc.Rows.Count > 0 Then
                'dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                'dgvt_doc.SelectedRows(e)
                'dgvt_doc.Rows(0).Cells("T_DOC_REF1").Selected = True
                dgvt_doc.Select()
                e.Handled = True
            Else
                btnagregar.Select()
            End If

        End If
    End Sub

    Private Sub txtmskfecgene_LostFocus(sender As Object, e As EventArgs) Handles txtmskfecgene.LostFocus
        Try
            Dim cmb As Double
            Dim dt As DataTable
            Dim mesfecha As String
            Dim mesdia As String
            If Mid(txtmskfecsbs.Text, 4, 2) = "1" Then
                mesfecha = "0" & Mid(txtmskfecsbs.Text, 4, 2)
            Else
                mesfecha = Mid(txtmskfecsbs.Text, 4, 2)
            End If
            If Mid(txtmskfecsbs.Text, 1, 2) = "1" Then
                mesdia = "0" & Mid(txtmskfecsbs.Text, 1, 2)
            Else
                mesdia = Mid(txtmskfecsbs.Text, 1, 2)
            End If
            dt = PROVISIONESBL.getT_CAMBvensbs(Mid(txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
            For Each Registro In dt.Rows
                cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            Next

            For i = 0 To dgvt_doc.Rows.Count - 1
                dgvt_doc.Rows(i).Cells("T_CAMB").Value = cmb
            Next
        Catch ex As Exception
            MsgBox("Error en la fecha de emision")
        End Try

    End Sub

    Private Sub cmbt_doc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_doc.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If Me.cmbt_doc.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Me.txtt_doc.Text = Me.cmbt_doc.SelectedValue

    End Sub

    Private Sub cmbest1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbest1.SelectedIndexChanged
        If cmbest1.SelectedIndex = 1 Then
            btnreten.Enabled = True
        Else
            btnreten.Enabled = False
        End If
    End Sub

    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        txtt_pago.Text = cmbt_pago.SelectedValue
    End Sub

    Private Sub txtt_pago_LostFocus(sender As Object, e As EventArgs) Handles txtt_pago.LostFocus

        If txtt_pago.Text = "" Then
            cmbt_pago.SelectedIndex = -1
        Else
            cmbt_pago.SelectedValue = txtt_pago.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "251"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            cmb_pais.SelectedValue = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "252"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txt_conv.Text = gLinea
            txtnom_conv.Text = gSubLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txt_conv_LostFocus(sender As Object, e As EventArgs) Handles txt_conv.LostFocus
        If txt_conv.TextLength > 0 Then
            Dim prov As String = ELTBDOCEXPBL.Select_Nomconv(txt_conv.Text)
            If prov.Length > 0 Then
                txtnom_conv.Text = prov
            Else
                txtnom_conv.Text = ""
            End If
        Else
            txt_conv.Text = ""
            txtnom_conv.Text = ""
        End If
    End Sub

    Private Sub txtt_cmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_cmp.KeyDown
        If e.KeyValue = Keys.Enter Then
            txts_comp.Focus()
        End If
    End Sub

    Private Sub txts_comp_KeyDown(sender As Object, e As KeyEventArgs) Handles txts_comp.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmb_año_cmp.Focus()
        End If
    End Sub

    Private Sub cmb_año_cmp_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_año_cmp.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtn_cmp.Focus()
        End If
    End Sub

    Private Sub txtn_cmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtn_cmp.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmb_pais.Focus()
        End If
    End Sub

    Private Sub cmb_pais_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_pais.KeyDown
        If e.KeyValue = Keys.Enter Then
            txt_conv.Focus()
        End If
    End Sub

    Private Sub txt_conv_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_conv.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtt_renta.Focus()
        End If
    End Sub

    Private Sub txtt_renta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_renta.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtest_oport.Focus()
        End If
    End Sub

    Private Sub txtest_oport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtest_oport.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtmoneda.Focus()
        End If
    End Sub

#End Region
End Class