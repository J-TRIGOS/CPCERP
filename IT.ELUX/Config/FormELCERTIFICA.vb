Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELCERTIFICA
    Private ELCERTIFICABL As New ELCERTIFICABL
    Private ELCERTIFICABE As New ELCERTIFICABE
    Private ELMVLOGSBE As New ELMVLOGSBE
    Private gpCaption As String
    Dim a As String
    Dim ctct As String
    Dim tipo As String
    Dim DAcumula6 As String = ""
    Dim twoEst As String
    Private gdtMainData As DataTable


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormELCERTIFICA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbNroguia.SelectedItem = "001"
        Select Case gnOpcion
            Case 0
                txtcertificado.Text = ELCERTIFICABL.SelectMaxTransp().PadLeft(4, "0")
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
                DeshabilitarTabs(False)

                '------ Protocolo -------
                twoEst = "N"
                GroupBox19.Visible = False
                cmbEst.SelectedIndex = 0
                '------  -------
            Case 1
                flagAccion = "M"
                Deshabilitar(False)
                GetData(sTDoc, sSDoc, sNDoc)
        End Select


        '--------Protocolo ---------
        dgvControl.Columns.Add("ESPESOR", "ESPESOR")
        dgvControl.Columns.Add("TEMPLE", "TEMPLE")
        dgvControl.Columns.Add("DIAMETRO", "DIAMETRO")
        dgvControl.Columns.Add("TRATAMIENTO TERMICO", "TRA. TERMICO")
        dgvControl.Columns.Add("RECUBRIMIENTO INTERIOR", "REC. INTERIOR")
        dgvControl.Columns.Add("MODELO", "MODELO")
        dgvControl.Columns.Add("CANTIDAD TAPAS BULTO", "CANT. TAP. BULTO")
        dgvControl.Columns.Add("DIAMETRO EXTERIOR", "DIA. EXTERIOR")
        dgvControl.Columns.Add("DIAMETRO INTERIOR", "DIA. INTERIOR")
        dgvControl.Columns.Add("DIAMETRO ENTRE UÑAS", "DIA. UÑAS")
        dgvControl.Columns.Add("ALTURA DE EXTERIOR", "ALT. EXTERIOR")
        dgvControl.Columns.Add("NIVEL DE VACIO", "NVL. VACIO")
        dgvControl.Columns.Add("SEGURIDAD DE CIERRE", "SEG. CIERRE")
        dgvControl.Columns.Add("DIA EXT RES", "DIA EXT RES")
        dgvControl.Columns.Add("DIA INT RES", "DIA INT RES")
        dgvControl.Columns.Add("DIA UÑAS RES", "DIA UÑAS RES")
        dgvControl.Columns.Add("ALT EXT RES", "ALT EXT RES")
        dgvControl.Columns.Add("SAF", "SAF")
        dgvControl.Columns.Add("DIA_EXT_MEN", "DIA_EXT_MEN")
        dgvControl.Columns.Add("DIA_EXT_MAY", "DIA_EXT_MAY")
        dgvControl.Columns.Add("DIA_INT_MEN", "DIA_INT_MEN")
        dgvControl.Columns.Add("DIA_INT_MAY", "DIA_INT_MAY")
        dgvControl.Columns.Add("DIA_UNIA_MEN", "DIA_UNIA_MEN")
        dgvControl.Columns.Add("DIA_UNIA_MAY", "DIA_UNIA_MAY")
        dgvControl.Columns.Add("ALT_EXT_MEN", "ALT_EXT_MEN")
        dgvControl.Columns.Add("ALT_EXT_MAY", "ALT_EXT_MAY")
        '---------------------------------------
        dgvControl.Columns("SAF").Visible = False
        dgvControl.Columns("DIA_EXT_MEN").Visible = False
        dgvControl.Columns("DIA_EXT_MAY").Visible = False
        dgvControl.Columns("DIA_INT_MEN").Visible = False
        dgvControl.Columns("DIA_INT_MAY").Visible = False
        dgvControl.Columns("DIA_UNIA_MEN").Visible = False
        dgvControl.Columns("DIA_UNIA_MAY").Visible = False
        dgvControl.Columns("ALT_EXT_MEN").Visible = False
        dgvControl.Columns("ALT_EXT_MAY").Visible = False
        '--------------------------------------
        dgvLote.Columns.Add("TIPO", "TIPO")
        dgvLote.Columns.Add("SERIE", "SERIE")
        dgvLote.Columns.Add("NUMERO", "NRO. DOCU")
        dgvLote.Columns.Add("PRODUCTO", "PRODUCTO")
        dgvLote.Columns.Add("CANTIDAD", "CANTIDAD")
        dgvLote.Columns.Add("FECHA PRODUCCION", "FEC. PRODUCCION")
        dgvLote.Columns.Add("TURNO", "TURNO")
        dgvLote.Columns.Add("LOTE", "LOTE")
        dgvLote.Columns.Add("CANTIDAD1", "CANTIDAD1")
        dgvLote.Columns("CANTIDAD1").Visible = False
        '-----------------------------------------
        '   dgvMod.Columns.Add("T_DOC_REF", "TIPO")
        '   dgvMod.Columns.Add("SER_DOC_REF", "SERIE")
        '   dgvMod.Columns.Add("NRO_DOC_REF", "NUMERO")
        '   dgvMod.Columns.Add("COD_ART", "ARTICULO")
        '   dgvMod.Columns.Add("CTCT_COD", "RUC")
        '   dgvMod.Columns.Add("CLIENTE", "CLIENTE")
        '   dgvMod.Columns.Add("FEC_DIA", "FEC EMICION")
        '   dgvMod.Columns.Add("NOM_ART", "NOM")
        '   dgvMod.Columns.Add("EST", "EST")
        '   dgvMod.Columns("EST").Visible = False
        ''----------------------------
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        'cmbarticulo.Items().Clear()

        Dim dtUsuario, dteasypeel, dttapaplastic, dttelesco As DataTable
        Dim Registro, Regeasy, Regplastic, Regtelesco As DataRow

        dtUsuario = ELCERTIFICABL.SelectRow(sTDoc, sSDoc, sNDoc)
        txtnguia.Text = sNDoc
        cmbNroguia.SelectedItem = sSDoc
        lblclientenom1.Text = gArt
        gArt = ""
        If dtUsuario.Rows.Count > 0 Then
            For Each Registro In dtUsuario.Rows
                cmbarticulo.Items.Add(IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")))
                cmbarticulo.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                lblnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
                txtcertificado.Text = IIf(IsDBNull(Registro("TIPO_ACTA")), "", Registro("TIPO_ACTA"))
                txtlote.Text = IIf(IsDBNull(Registro("LOTE")), "", Registro("LOTE"))
                txt_fecprod.Text = IIf(IsDBNull(Registro("FEC_PROV")), "", Registro("FEC_PROV"))
                txtn_bolsas.Text = IIf(IsDBNull(Registro("N_BOLSAS")), "", Registro("N_BOLSAS"))
                txtcantidad.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
                cmbTpaquete.SelectedIndex = IIf(IsDBNull(Registro("T_PAQUETE")), "", Registro("T_PAQUETE"))
                txtaltcuerpo.Text = IIf(IsDBNull(Registro("ALT_CUERPO")), "", Registro("ALT_CUERPO"))
                txtalturaenv.Text = IIf(IsDBNull(Registro("ALT_ENVASE")), "", Registro("ALT_ENVASE"))
                txtdiainterno.Text = IIf(IsDBNull(Registro("DIA_INTERNO")), "", Registro("DIA_INTERNO"))
                txtdexterno.Text = IIf(IsDBNull(Registro("DIA_EXTERNO")), "", Registro("DIA_EXTERNO"))
                txtanchenv.Text = IIf(IsDBNull(Registro("ANC_ENVASE")), "", Registro("ANC_ENVASE"))
                txtlargenv.Text = IIf(IsDBNull(Registro("LARG_ENVASE")), "", Registro("LARG_ENVASE"))
                txtalttapa.Text = IIf(IsDBNull(Registro("ALT_TAPA")), "", Registro("ALT_TAPA"))
                txtpesoenv.Text = IIf(IsDBNull(Registro("PES_ENVASE")), "", Registro("PES_ENVASE"))
                txtalt_asa.Text = IIf(IsDBNull(Registro("ALT_ASA")), "", Registro("ALT_ASA"))
                If IIf(IsDBNull(Registro("TIP_ENVASE")), "", Registro("TIP_ENVASE")) = "0" Then
                    cmbtip_envase.SelectedIndex = 1
                ElseIf IIf(IsDBNull(Registro("TIP_ENVASE")), "", Registro("TIP_ENVASE")) = "1" Then
                    cmbtip_envase.SelectedIndex = 0
                End If
                txtobs1.Text = IIf(IsDBNull(Registro("OBS1")), "", Registro("OBS1"))
                txtobs2.Text = IIf(IsDBNull(Registro("OBS2")), "", Registro("OBS2"))
                txtobs3.Text = IIf(IsDBNull(Registro("OBS3")), "", Registro("OBS3"))
                txtobs4.Text = IIf(IsDBNull(Registro("OBS4")), "", Registro("OBS4"))
                txtobs5.Text = IIf(IsDBNull(Registro("OBS5")), "", Registro("OBS5"))
                txto1.Text = IIf(IsDBNull(Registro("O1")), "", Registro("O1"))
                txto2.Text = IIf(IsDBNull(Registro("O2")), "", Registro("O2"))
                txto3.Text = IIf(IsDBNull(Registro("O3")), "", Registro("O3"))
                txto4.Text = IIf(IsDBNull(Registro("O4")), "", Registro("O4"))
                txto5.Text = IIf(IsDBNull(Registro("O5")), "", Registro("O5"))
                txto6.Text = IIf(IsDBNull(Registro("O6")), "", Registro("O6"))
                txto7.Text = IIf(IsDBNull(Registro("O7")), "", Registro("O7"))
                txto8.Text = IIf(IsDBNull(Registro("O8")), "", Registro("O8"))
                txto9.Text = IIf(IsDBNull(Registro("O9")), "", Registro("O9"))
                txtm1.Text = IIf(IsDBNull(Registro("M1")), "", Registro("M1"))
                txtm2.Text = IIf(IsDBNull(Registro("M2")), "", Registro("M2"))
                txtm3.Text = IIf(IsDBNull(Registro("M3")), "", Registro("M3"))
                txtm4.Text = IIf(IsDBNull(Registro("M4")), "", Registro("M4"))
                txtm5.Text = IIf(IsDBNull(Registro("M5")), "", Registro("M5"))
                txtm6.Text = IIf(IsDBNull(Registro("M6")), "", Registro("M6"))
                txtm7.Text = IIf(IsDBNull(Registro("M7")), "", Registro("M7"))
                txtm8.Text = IIf(IsDBNull(Registro("M8")), "", Registro("M8"))
                txtm9.Text = IIf(IsDBNull(Registro("M9")), "", Registro("M9"))
                txtp1.Text = IIf(IsDBNull(Registro("P1")), "", Registro("P1"))
                txtp2.Text = IIf(IsDBNull(Registro("P2")), "", Registro("P2"))
                txtp3.Text = IIf(IsDBNull(Registro("P3")), "", Registro("P3"))
                txtp4.Text = IIf(IsDBNull(Registro("P4")), "", Registro("P4"))
                txtp5.Text = IIf(IsDBNull(Registro("P5")), "", Registro("P5"))
                txtp6.Text = IIf(IsDBNull(Registro("P6")), "", Registro("P6"))
                txtp7.Text = IIf(IsDBNull(Registro("P7")), "", Registro("P7"))
                txtp8.Text = IIf(IsDBNull(Registro("P8")), "", Registro("P8"))
                txtp9.Text = IIf(IsDBNull(Registro("P9")), "", Registro("P9"))
                txtes1.Text = IIf(IsDBNull(Registro("ES1")), "", Registro("ES1"))
                txtes2.Text = IIf(IsDBNull(Registro("ES2")), "", Registro("ES2"))
                txtes3.Text = IIf(IsDBNull(Registro("ES3")), "", Registro("ES3"))
                txtes4.Text = IIf(IsDBNull(Registro("ES4")), "", Registro("ES4"))
                txtes5.Text = IIf(IsDBNull(Registro("ES5")), "", Registro("ES5"))
                txtes6.Text = IIf(IsDBNull(Registro("ES6")), "", Registro("ES6"))
                txtes7.Text = IIf(IsDBNull(Registro("ES7")), "", Registro("ES7"))

                cmbTpaquete.SelectedIndex = Convert.ToInt32(Registro("T_PAQUETE")) - 1
                'LLENAR AL COMBO                
            Next
        End If
        'DTEASY
        dteasypeel = ELCERTIFICABL.SelectRowEasy(sNDoc)
        If dteasypeel.Rows.Count > 0 Then
            For Each Regeasy In dteasypeel.Rows
                txtproducto.Text = IIf(IsDBNull(Regeasy("PRODUCTO")), "", Regeasy("PRODUCTO"))
                txtenvase.Text = IIf(IsDBNull(Regeasy("TIPO_ENVASE")), "", Regeasy("TIPO_ENVASE"))
                txtx1.Text = IIf(IsDBNull(Regeasy("X1")), "", Regeasy("X1"))
                txtx3.Text = IIf(IsDBNull(Regeasy("X3")), "", Regeasy("X3"))
                txtx2.Text = IIf(IsDBNull(Regeasy("X2")), "", Regeasy("X2"))
                txtdiamext.Text = IIf(IsDBNull(Regeasy("DIAM_EXTERNO")), "", Regeasy("DIAM_EXTERNO"))
                txtdiamint.Text = IIf(IsDBNull(Regeasy("DIAM_INTERNO")), "", Regeasy("DIAM_INTERNO"))
                txtdiamcierr.Text = IIf(IsDBNull(Regeasy("DIAM_CIERRE")), "", Regeasy("DIAM_CIERRE"))
                txtprofund.Text = IIf(IsDBNull(Regeasy("PROFUNDIDAD")), "", Regeasy("PROFUNDIDAD"))
                txtalturcor.Text = IIf(IsDBNull(Regeasy("ALT_CORTE")), "", Regeasy("ALT_CORTE"))

                txtembajpr.Text = IIf(IsDBNull(Regeasy("EMBAL_PRIM")), "", Regeasy("EMBAL_PRIM"))
                txtembajsecu.Text = IIf(IsDBNull(Regeasy("EMBAL_SECUN")), "", Regeasy("EMBAL_SECUN"))
                txtseparad.Text = IIf(IsDBNull(Regeasy("SEPARADORES")), "", Regeasy("SEPARADORES"))
                txtnropa.Text = IIf(IsDBNull(Regeasy("NRO_EASY_PAQUETE")), "", Regeasy("NRO_EASY_PAQUETE"))

                txtdescreasy.Text = IIf(IsDBNull(Regeasy("DESCR_EASY")), "", Regeasy("DESCR_EASY"))
                txtacabado.Text = IIf(IsDBNull(Regeasy("ACAB_FIN_EASY")), "", Regeasy("ACAB_FIN_EASY"))
                txtcompuesto.Text = IIf(IsDBNull(Regeasy("COMPUE_SELLAD")), "", Regeasy("COMPUE_SELLAD"))
            Next
        End If

        'DTPLASTICA
        dttapaplastic = ELCERTIFICABL.SelectRowPlast(sNDoc)
        If dttapaplastic.Rows.Count > 0 Then
            For Each Regplastic In dttapaplastic.Rows
                txtproduc3.Text = IIf(IsDBNull(Regplastic("PRODUCTO")), "", Regplastic("PRODUCTO"))
                txttipoenvase3.Text = IIf(IsDBNull(Regplastic("TIPO_ENVASE")), "", Regplastic("TIPO_ENVASE"))
                txtx4.Text = IIf(IsDBNull(Regplastic("X4")), "", Regplastic("X4"))
                txtx6.Text = IIf(IsDBNull(Regplastic("X6")), "", Regplastic("X6"))
                txtx2.Text = IIf(IsDBNull(Regplastic("X5")), "", Regplastic("X5"))
                txtaltmenor.Text = IIf(IsDBNull(Regplastic("ALTURA_MEN")), "", Regplastic("ALTURA_MEN"))
                txtalturatot.Text = IIf(IsDBNull(Regplastic("ALTURA_TOT")), "", Regplastic("ALTURA_TOT"))
                txtdiaminter.Text = IIf(IsDBNull(Regplastic("DIAM_INT")), "", Regplastic("DIAM_INT"))
                txtdiammayor.Text = IIf(IsDBNull(Regplastic("DIAM_MAY")), "", Regplastic("DIAM_MAY"))
                txtpesotapa.Text = IIf(IsDBNull(Regplastic("PESO_TAP")), "", Regplastic("PESO_TAP"))

                txtembajalepri.Text = IIf(IsDBNull(Regplastic("EMBALAJE_PRI")), "", Regplastic("EMBALAJE_PRI"))
                txtembajalesec.Text = IIf(IsDBNull(Regplastic("EMBALAJE_SEC")), "", Regplastic("EMBALAJE_SEC"))
                txtseparado.Text = IIf(IsDBNull(Regplastic("SEPARADORES")), "", Regplastic("SEPARADORES"))
                txtntapa.Text = IIf(IsDBNull(Regplastic("N_TAPA_PAQUETE")), "", Regplastic("N_TAPA_PAQUETE"))

                txtmaterialtapa.Text = IIf(IsDBNull(Regplastic("MATERI_TAPA")), "", Regplastic("MATERI_TAPA"))
                txtacabfintap.Text = IIf(IsDBNull(Regplastic("ACABADO_FIN")), "", Regplastic("ACABADO_FIN"))
            Next
        End If

        'dt telescopica

        dttelesco = ELCERTIFICABL.SelectRowTeles(sNDoc)
        If dttelesco.Rows.Count > 0 Then
            For Each Regtelesc In dttelesco.Rows
                txtproducto4.Text = IIf(IsDBNull(Regtelesc("PRODUCTO")), "", Regtelesc("PRODUCTO"))
                txttipoenvase4.Text = IIf(IsDBNull(Regtelesc("TIPO_ENVASE")), "", Regtelesc("TIPO_ENVASE"))

                txtx7.Text = IIf(IsDBNull(Regtelesc("X7")), "", Regtelesc("X7"))
                txtx8.Text = IIf(IsDBNull(Regtelesc("X8")), "", Regtelesc("X8"))
                txtx9.Text = IIf(IsDBNull(Regtelesc("X9")), "", Regtelesc("X9"))

                txtdiammayexter.Text = IIf(IsDBNull(Regtelesc("D_MAYOR_EXT")), "", Regtelesc("D_MAYOR_EXT"))
                txtdiammenrexter.Text = IIf(IsDBNull(Regtelesc("D_MENOR_EXT")), "", Regtelesc("D_MENOR_EXT"))
                txtabertot.Text = IIf(IsDBNull(Regtelesc("ABERT_TOT")), "", Regtelesc("ABERT_TOT"))
                txtdiammenortap.Text = IIf(IsDBNull(Regtelesc("D_MENOR_TAPON")), "", Regtelesc("D_MENOR_TAPON"))
                txtdiamextros.Text = IIf(IsDBNull(Regtelesc("D_EXT_ROSCA")), "", Regtelesc("D_EXT_ROSCA"))
                txtpesodtapa.Text = IIf(IsDBNull(Regtelesc("PESO_TAPA")), "", Regtelesc("PESO_TAPA"))

                txtalturatotdiame.Text = IIf(IsDBNull(Regtelesc("ALT_TOT_MAY")), "", Regtelesc("ALT_TOT_MAY"))
                txtdiametrajuste.Text = IIf(IsDBNull(Regtelesc("D_AJUSTE_TAPON")), "", Regtelesc("D_AJUSTE_TAPON"))
                txtranuraajuste.Text = IIf(IsDBNull(Regtelesc("RANURA_AJUSTE")), "", Regtelesc("RANURA_AJUSTE"))
                txtdiaminterbase.Text = IIf(IsDBNull(Regtelesc("D_INT_BASE")), "", Regtelesc("D_INT_BASE"))
                diamextajustbase.Text = IIf(IsDBNull(Regtelesc("D_EXT_AJUSTE_BASE")), "", Regtelesc("D_EXT_AJUSTE_BASE"))
                txtdiamajuste.Text = IIf(IsDBNull(Regtelesc("DIAM_AJUSTE")), "", Regtelesc("DIAM_AJUSTE"))
                txtpesobase.Text = IIf(IsDBNull(Regtelesc("PESO_BASE")), "", Regtelesc("PESO_BASE"))

                txtv1.Text = IIf(IsDBNull(Regtelesc("V1")), "", Regtelesc("V1"))
                txtv2.Text = IIf(IsDBNull(Regtelesc("V2")), "", Regtelesc("V2"))
                txtv3.Text = IIf(IsDBNull(Regtelesc("V3")), "", Regtelesc("V3"))
                txtv4.Text = IIf(IsDBNull(Regtelesc("V4")), "", Regtelesc("V4"))
                txtv5.Text = IIf(IsDBNull(Regtelesc("V5")), "", Regtelesc("V5"))
                txtv6.Text = IIf(IsDBNull(Regtelesc("V6")), "", Regtelesc("V6"))
                txtv7.Text = IIf(IsDBNull(Regtelesc("V7")), "", Regtelesc("V7"))
                txtv8.Text = IIf(IsDBNull(Regtelesc("V8")), "", Regtelesc("V8"))
                txtv9.Text = IIf(IsDBNull(Regtelesc("V9")), "", Regtelesc("V9"))
                txtv10.Text = IIf(IsDBNull(Regtelesc("V10")), "", Regtelesc("V10"))
                txtv11.Text = IIf(IsDBNull(Regtelesc("V11")), "", Regtelesc("V11"))
                txtv12.Text = IIf(IsDBNull(Regtelesc("V12")), "", Regtelesc("V12"))
                txtv13.Text = IIf(IsDBNull(Regtelesc("V13")), "", Regtelesc("V13"))
                txtv14.Text = IIf(IsDBNull(Regtelesc("V14")), "", Regtelesc("V14"))
                txtv15.Text = IIf(IsDBNull(Regtelesc("V15")), "", Regtelesc("V15"))
                txtv16.Text = IIf(IsDBNull(Regtelesc("V16")), "", Regtelesc("V16"))
                txtv17.Text = IIf(IsDBNull(Regtelesc("V17")), "", Regtelesc("V17"))
                txtv18.Text = IIf(IsDBNull(Regtelesc("V18")), "", Regtelesc("V18"))
                txtv19.Text = IIf(IsDBNull(Regtelesc("V19")), "", Regtelesc("V19"))
                txtv20.Text = IIf(IsDBNull(Regtelesc("V20")), "", Regtelesc("V20"))
                txtv21.Text = IIf(IsDBNull(Regtelesc("V21")), "", Regtelesc("V21"))
                txtv22.Text = IIf(IsDBNull(Regtelesc("V22")), "", Regtelesc("V22"))
                txtv23.Text = IIf(IsDBNull(Regtelesc("V23")), "", Regtelesc("V23"))
                txtv24.Text = IIf(IsDBNull(Regtelesc("V24")), "", Regtelesc("V24"))
                txtv25.Text = IIf(IsDBNull(Regtelesc("V25")), "", Regtelesc("V25"))
                txtv26.Text = IIf(IsDBNull(Regtelesc("V26")), "", Regtelesc("V26"))

                txtr1.Text = IIf(IsDBNull(Regtelesc("R1")), "", Regtelesc("R1"))
                txtr2.Text = IIf(IsDBNull(Regtelesc("R2")), "", Regtelesc("R2"))
                txtr3.Text = IIf(IsDBNull(Regtelesc("R3")), "", Regtelesc("R3"))
                txtr4.Text = IIf(IsDBNull(Regtelesc("R4")), "", Regtelesc("R4"))
                txtr5.Text = IIf(IsDBNull(Regtelesc("R5")), "", Regtelesc("R5"))
                txtr6.Text = IIf(IsDBNull(Regtelesc("R6")), "", Regtelesc("R6"))
                txtr7.Text = IIf(IsDBNull(Regtelesc("R7")), "", Regtelesc("R7"))
                txtr8.Text = IIf(IsDBNull(Regtelesc("R8")), "", Regtelesc("R8"))
                txtr9.Text = IIf(IsDBNull(Regtelesc("R9")), "", Regtelesc("R9"))
                txtr10.Text = IIf(IsDBNull(Regtelesc("R10")), "", Regtelesc("R10"))
                txtr11.Text = IIf(IsDBNull(Regtelesc("R11")), "", Regtelesc("R11"))
                txtr12.Text = IIf(IsDBNull(Regtelesc("R12")), "", Regtelesc("R12"))
                txtr13.Text = IIf(IsDBNull(Regtelesc("R13")), "", Regtelesc("R13"))
                cmbcolor.Text = IIf(IsDBNull(Regtelesc("COLOR")), "", Regtelesc("COLOR"))
            Next
        End If

    End Sub

    Private Sub Deshabilitar(ByVal dd As Boolean)
        txtnguia.Enabled = dd
        cmbNroguia.Enabled = dd
        cmbarticulo.Enabled = dd
    End Sub

    Private Sub DeshabilitarTabs(ByVal dd As Boolean)
        TabPage2.Enabled = dd
        TabPage3.Enabled = dd
        TabPage4.Enabled = dd
    End Sub

    Private Sub txtnguia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnguia.KeyDown

        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        If e.KeyValue = Keys.F9 Then

            sBusAlm = "87"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                cmbarticulo.Items().Clear()
                dgvt_doc.Rows.Clear()
                dgvt_doc.DataSource = Nothing

                txtnguia.Text = gLinea
                dtUsuario = ELCERTIFICABL.SelectGuias(gLinea, cmbNroguia.SelectedItem)
                For Each Registro In dtUsuario.Rows

                    dgvt_doc.Rows.Add(IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")),
                                      IIf(IsDBNull(Registro("NOM")), "", Registro("NOM")),
                                      IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD")),
                                      IIf(IsDBNull(Registro("N_BOLSAS")), "", Registro("N_BOLSAS")),
                                      IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")))
                    'LLENAR AL COMBO
                    cmbarticulo.Items.Add(IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")))
                    lblclientenom1.Text = IIf(IsDBNull(Registro("CLIENTE")), "", Registro("CLIENTE"))
                Next
                cmbarticulo.SelectedIndex = 0
                DeshabilitarTabs(True)
                gLinea = ""
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtproducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproducto.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "88"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtproducto.Text = gLinea
                gLinea = ""
                txtproducto_LostFocus(sender, e)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtproduc3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproduc3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "89"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtproduc3.Text = gLinea
                gLinea = ""
                txtproduc3_LostFocus(sender, e)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtproducto4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproducto4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "90"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtproducto4.Text = gLinea
                gLinea = ""
                txtproducto4_LostFocus(sender, e)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cmbarticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulo.SelectedIndexChanged
        Dim Cliente As String
        Dim indice As Integer = cmbarticulo.SelectedIndex
        lblnom.Text = dgvt_doc.Rows(indice).Cells(1).Value
        txtcantidad.Text = dgvt_doc.Rows(indice).Cells(2).Value
        txtn_bolsas.Text = dgvt_doc.Rows(indice).Cells(3).Value

        txtdatoslote.Text = ELCERTIFICABL.SelectGetLote(txtnguia.Text)

        Dim Articulo As String = "%" + cmbarticulo.SelectedItem.Substring(0, 6) + "%"
        If lblclientenom1.Text <> "" Then
            If lblclientenom1.Text.Length > 12 Then
                Cliente = "%" + lblclientenom1.Text.Substring(0, 12) + "%"
            Else
                Cliente = "%" + lblclientenom1.Text + "%"
            End If
        Else
            Cliente = ""
        End If

        Dim Series As String() = ELCERTIFICABL.SelectGetData(Articulo, Cliente).Split("|")
        If Series.Length > 3 Then

            'txtcertificado.Text = Series(0).Trim()
            txtlote.Text = Series(1).Trim()
            txt_fecprod.Text = Series(2)
            'txtn_bolsas.Text = Series(3)
            'txtcantidad.Text = Series(4)
            cmbTpaquete.SelectedIndex = CInt(Series(5)) - 1
            txtaltcuerpo.Text = Series(6).Trim()
            txtalturaenv.Text = Series(7).Trim()
            txtdiainterno.Text = Series(8).Trim()
            txtdexterno.Text = Series(9).Trim()
            txtanchenv.Text = Series(10).Trim()
            txtlargenv.Text = Series(11).Trim()
            txtalttapa.Text = Series(12).Trim()
            txtpesoenv.Text = Series(13).Trim()
            txtalt_asa.Text = Series(14).Trim()
            txtobs1.Text = Series(15).Trim()
            txtobs2.Text = Series(16).Trim()
            txtobs3.Text = Series(17).Trim()
            txtobs4.Text = Series(18).Trim()
            txtobs5.Text = Series(19).Trim()
            'txto1.Text = Series(20).Trim()
            'txto2.Text = Series(21).Trim()
            'txto3.Text = Series(22).Trim()
            'txto4.Text = Series(23).Trim()
            'txto5.Text = Series(24).Trim()
            'txto6.Text = Series(25).Trim()
            'txto7.Text = Series(26).Trim()
            'txto8.Text = Series(27).Trim()
            'txto9.Text = Series(28).Trim()
            'txtm1.Text = Series(29).Trim()
            'txtm2.Text = Series(30).Trim()
            'txtm3.Text = Series(31).Trim()
            'txtm4.Text = Series(32).Trim()
            'txtm5.Text = Series(33).Trim()
            'txtm6.Text = Series(34).Trim()
            'txtm7.Text = Series(35).Trim()
            'txtm8.Text = Series(36).Trim()
            'txtm9.Text = Series(37).Trim()
            'txtp1.Text = Series(38).Trim()
            'txtp2.Text = Series(39).Trim()
            'txtp3.Text = Series(40).Trim()
            'txtp4.Text = Series(41).Trim()
            'txtp5.Text = Series(42).Trim()
            'txtp6.Text = Series(43).Trim()
            'txtp7.Text = Series(44).Trim()
            'txtp8.Text = Series(45).Trim()
            'txtp9.Text = Series(46).Trim()
            txtes1.Text = Series(47).Trim()
            txtes2.Text = Series(48).Trim()
            txtes3.Text = Series(49).Trim()
            txtes4.Text = Series(50).Trim()
            txtes5.Text = Series(51).Trim()
            txtes6.Text = Series(52).Trim()
            txtes7.Text = Series(53).Trim()
        End If

    End Sub

    Private Sub Limpiar()

        lblclientenom1.Text = ""
        cmbarticulo.Items().Clear()
        lblnom.Text = ""
        txt_fecprod.Text = ""
        cmbTpaquete.SelectedIndex = -1
        txtcantidad.Text = ""
        txtn_bolsas.Text = ""
        txtaltcuerpo.Text = ""
        txtalturaenv.Text = ""
        txtdiainterno.Text = ""
        txtdexterno.Text = ""
        txtanchenv.Text = ""
        txtlargenv.Text = ""
        txtalttapa.Text = ""
        txtpesoenv.Text = ""

    End Sub

    Private Function OkData() As Boolean
        If lblnom.Text = "" Then
            MsgBox("Seleccione Un Codigo de Articulo", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtcantidad.Text = "" Then
            MsgBox("Ingrese la Cantidad", MsgBoxStyle.Exclamation)
            txtcantidad.Focus()
            Return False
        End If
        If txtn_bolsas.Text = "" Then
            MsgBox("Ingrese el Numero", MsgBoxStyle.Exclamation)
            txtn_bolsas.Focus()
            Return False
        End If
        If txtlote.Text = "" Then
            MsgBox("Ingrese el lote", MsgBoxStyle.Exclamation)
            txtn_bolsas.Focus()
            Return False
        End If
        If txt_fecprod.Text = "" Then
            MsgBox("Ingrese el Numero", MsgBoxStyle.Exclamation)
            txt_fecprod.Focus()
            Return False
        End If
        If cmbTpaquete.SelectedIndex = -1 Then
            MsgBox("Seleccione un tipo de Envase", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnguia.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Sub savedata()

        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELCERTIFICABE As New ELCERTIFICABE
                ELCERTIFICABE.t_doc_ref = "ASQ"
                ELCERTIFICABE.nro_ser_doc = txtnguia.Text
                ELCERTIFICABE.ser_doc_ref = cmbNroguia.SelectedItem
                ELCERTIFICABE.tipo_acta = txtcertificado.Text
                ELCERTIFICABE.art_cod = cmbarticulo.Text
                ELCERTIFICABE.lote = txtlote.Text
                ELCERTIFICABE.fec_prov = txt_fecprod.Text
                ELCERTIFICABE.n_bolsas = txtn_bolsas.Text
                ELCERTIFICABE.cantidad = txtcantidad.Text
                ELCERTIFICABE.alt_cuerpo = txtaltcuerpo.Text
                ELCERTIFICABE.alt_envase = txtalturaenv.Text
                ELCERTIFICABE.dia_interno = txtdiainterno.Text
                ELCERTIFICABE.dia_externo = txtdexterno.Text
                ELCERTIFICABE.anc_envase = txtanchenv.Text
                ELCERTIFICABE.larg_envase = txtlargenv.Text
                ELCERTIFICABE.alt_tapa = txtalttapa.Text
                ELCERTIFICABE.pes_envase = txtpesoenv.Text
                ELCERTIFICABE.alt_asa = txtalt_asa.Text
                ELCERTIFICABE.obs1 = txtobs1.Text
                ELCERTIFICABE.obs2 = txtobs2.Text
                ELCERTIFICABE.obs3 = txtobs3.Text
                ELCERTIFICABE.obs4 = txtobs4.Text
                ELCERTIFICABE.obs5 = txtobs5.Text
                If cmbtip_envase.Text = "NO" Then
                    ELCERTIFICABE.tip_envase = "0"
                ElseIf cmbtip_envase.Text = "SI" Then
                    ELCERTIFICABE.tip_envase = "1"
                End If


                    ELCERTIFICABE.o1 = txto1.Text
                    ELCERTIFICABE.o2 = txto2.Text
                    ELCERTIFICABE.o3 = txto3.Text
                    ELCERTIFICABE.o4 = txto4.Text
                    ELCERTIFICABE.o5 = txto5.Text
                    ELCERTIFICABE.o6 = txto6.Text
                    ELCERTIFICABE.o7 = txto7.Text
                    ELCERTIFICABE.o8 = txto8.Text
                    ELCERTIFICABE.o9 = txto9.Text
                    ELCERTIFICABE.m1 = txtm1.Text
                    ELCERTIFICABE.m2 = txtm2.Text
                    ELCERTIFICABE.m3 = txtm3.Text
                    ELCERTIFICABE.m4 = txtm4.Text
                    ELCERTIFICABE.m5 = txtm5.Text
                    ELCERTIFICABE.m6 = txtm6.Text
                    ELCERTIFICABE.m7 = txtm7.Text
                    ELCERTIFICABE.m8 = txtm8.Text
                    ELCERTIFICABE.m9 = txtm9.Text
                    ELCERTIFICABE.p1 = txtp1.Text
                    ELCERTIFICABE.p2 = txtp2.Text
                    ELCERTIFICABE.p3 = txtp3.Text
                    ELCERTIFICABE.p4 = txtp4.Text
                    ELCERTIFICABE.p5 = txtp5.Text
                    ELCERTIFICABE.p6 = txtp6.Text
                    ELCERTIFICABE.p7 = txtp7.Text
                    ELCERTIFICABE.p8 = txtp8.Text
                    ELCERTIFICABE.p9 = txtp9.Text

                    ELCERTIFICABE.es1 = txtes1.Text
                    ELCERTIFICABE.es2 = txtes2.Text
                    ELCERTIFICABE.es3 = txtes3.Text
                    ELCERTIFICABE.es4 = txtes4.Text
                    ELCERTIFICABE.es5 = txtes5.Text
                    ELCERTIFICABE.es6 = txtes6.Text
                    ELCERTIFICABE.es7 = txtes7.Text

                    ELCERTIFICABE.usuario = gsCodUsr
                    gsError = ELCERTIFICABL.SaveRow(ELCERTIFICABE, flagAccion, cmbTpaquete.SelectedIndex + 1)

                    If gsError = "OK" Then

                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = "ASQ"
                        gsRptArgs(1) = RTrim(cmbNroguia.SelectedItem)
                        gsRptArgs(2) = RTrim(txtcertificado.Text)
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_DOCUMENTO_CALIDAD.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()

                        If flagAccion = "M" Then
                            Me.Close()
                        End If
                        If flagAccion = "N" Then
                            flagAccion = "M"
                        End If
                    Else
                        FormMain.LblError.Text = gsError

                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If
    End Sub

    Private Sub FormELCERTIFICA_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub btnagregar_Click_1(sender As Object, e As EventArgs) Handles btnagregar.Click
        savedata()
    End Sub

    Private Sub txto1_LostFocus(sender As Object, e As EventArgs) Handles txto1.LostFocus, txtm1.LostFocus
        If (txto1.Text = "") And txtm1.Text <> "" Then
            txtp1.Text = txtm1.Text
        ElseIf (txtm1.Text = "") And txto1.Text <> "" Then
            txtp1.Text = txto1.Text
        ElseIf (txtm1.Text = "") And txto1.Text = "" Then
            txtp1.Text = ""
        Else
            txtp1.Text = FormatNumber((CDbl(txtm1.Text) + CDbl(txto1.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto2_LostFocus(sender As Object, e As EventArgs) Handles txto2.LostFocus, txtm2.LostFocus
        If (txto2.Text = "") And txtm2.Text <> "" Then
            txtp2.Text = txtm2.Text
        ElseIf (txtm2.Text = "") And txto2.Text <> "" Then
            txtp2.Text = txto2.Text
        ElseIf (txtm2.Text = "") And txto2.Text = "" Then
            txtp2.Text = ""
        Else
            txtp2.Text = FormatNumber((CDbl(txtm2.Text) + CDbl(txto2.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto3_LostFocus(sender As Object, e As EventArgs) Handles txto3.LostFocus, txtm3.LostFocus
        If (txto3.Text = "") And txtm3.Text <> "" Then
            txtp3.Text = txtm3.Text
        ElseIf (txtm3.Text = "") And txto3.Text <> "" Then
            txtp3.Text = txto3.Text
        ElseIf (txtm3.Text = "") And txto3.Text = "" Then
            txtp3.Text = ""
        Else
            txtp3.Text = FormatNumber((CDbl(txtm3.Text) + CDbl(txto3.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto4_LostFocus(sender As Object, e As EventArgs) Handles txto4.LostFocus, txtm4.LostFocus
        If (txto4.Text = "") And txtm4.Text <> "" Then
            txtp4.Text = txtm4.Text
        ElseIf (txtm4.Text = "") And txto4.Text <> "" Then
            txtp4.Text = txto4.Text
        ElseIf (txtm4.Text = "") And txto4.Text = "" Then
            txtp4.Text = ""
        Else
            txtp4.Text = FormatNumber((CDbl(txtm4.Text) + CDbl(txto4.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto5_LostFocus(sender As Object, e As EventArgs) Handles txto5.LostFocus, txtm5.LostFocus
        If (txto5.Text = "") And txtm5.Text <> "" Then
            txtp5.Text = txtm5.Text
        ElseIf (txtm5.Text = "") And txto5.Text <> "" Then
            txtp5.Text = txto5.Text
        ElseIf (txtm5.Text = "") And txto5.Text = "" Then
            txtp5.Text = ""
        Else
            txtp5.Text = FormatNumber((CDbl(txtm5.Text) + CDbl(txto5.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto6_LostFocus(sender As Object, e As EventArgs) Handles txto6.LostFocus, txtm6.LostFocus
        If (txto6.Text = "") And txtm6.Text <> "" Then
            txtp6.Text = txtm6.Text
        ElseIf (txtm6.Text = "") And txto6.Text <> "" Then
            txtp6.Text = txto6.Text
        ElseIf (txtm6.Text = "") And txto6.Text = "" Then
            txtp6.Text = ""
        Else
            txtp6.Text = FormatNumber((CDbl(txtm6.Text) + CDbl(txto6.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto7_LostFocus(sender As Object, e As EventArgs) Handles txto7.LostFocus, txtm7.LostFocus
        If (txto7.Text = "") And txtm7.Text <> "" Then
            txtp7.Text = txtm7.Text
        ElseIf (txtm7.Text = "") And txto7.Text <> "" Then
            txtp7.Text = txto7.Text
        ElseIf (txtm7.Text = "") And txto7.Text = "" Then
            txtp7.Text = ""
        Else
            txtp7.Text = FormatNumber((CDbl(txtm7.Text) + CDbl(txto7.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto8_LostFocus(sender As Object, e As EventArgs) Handles txto8.LostFocus, txtm8.LostFocus
        If (txto8.Text = "") And txtm8.Text <> "" Then
            txtp8.Text = txtm8.Text
        ElseIf (txtm8.Text = "") And txto8.Text <> "" Then
            txtp8.Text = txto8.Text
        ElseIf (txtm8.Text = "") And txto8.Text = "" Then
            txtp8.Text = ""
        Else
            txtp8.Text = FormatNumber((CDbl(txtm8.Text) + CDbl(txto8.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto9_LostFocus(sender As Object, e As EventArgs) Handles txto9.LostFocus, txtm9.LostFocus
        If (txto9.Text = "") And txtm9.Text <> "" Then
            txtp9.Text = txtm9.Text
        ElseIf (txtm9.Text = "") And txto9.Text <> "" Then
            txtp9.Text = txto9.Text
        ElseIf (txtm9.Text = "") And txto9.Text = "" Then
            txtp9.Text = ""
        Else
            txtp9.Text = FormatNumber((CDbl(txtm9.Text) + CDbl(txto9.Text)) / 2, 2)
        End If
    End Sub

    Private Sub Generar_Easy_Peel_Click(sender As Object, e As EventArgs) Handles Generar_Easy_Peel.Click
        If OkData2() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELCERTIFICABE As New ELCERTIFICABE
                ELCERTIFICABE.t_doc_ref = ELCERTIFICABL.SelectRowCount
                ELCERTIFICABE.nro_ser_doc = txtnguia.Text
                ELCERTIFICABE.ser_doc_ref = cmbNroguia.SelectedItem
                ELCERTIFICABE.art_cod = cmbarticulo.Text

                ELCERTIFICABE.o1 = txtdiamext.Text
                ELCERTIFICABE.o2 = txtdiamint.Text
                ELCERTIFICABE.o3 = txtdiamcierr.Text
                ELCERTIFICABE.o4 = txtprofund.Text
                ELCERTIFICABE.o5 = txtalturcor.Text
                ELCERTIFICABE.o6 = txtembajpr.Text
                ELCERTIFICABE.o7 = txtembajsecu.Text
                ELCERTIFICABE.o8 = txtseparad.Text
                ELCERTIFICABE.o9 = txtnropa.Text
                ELCERTIFICABE.m1 = txtdescreasy.Text
                ELCERTIFICABE.m2 = txtacabado.Text
                ELCERTIFICABE.m3 = txtcompuesto.Text
                ELCERTIFICABE.m4 = txtproducto.Text
                ELCERTIFICABE.m5 = txtenvase.Text

                ELCERTIFICABE.es12 = txtx1.Text
                ELCERTIFICABE.es13 = txtx2.Text
                ELCERTIFICABE.es14 = txtx3.Text

                ELCERTIFICABE.usuario = gsCodUsr

                gsError = ELCERTIFICABL.SaveRow2(ELCERTIFICABE, flagAccion, cmbTpaquete.SelectedIndex + 1)

                If gsError = "OK" Then
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = ELCERTIFICABE.t_doc_ref
                    gsRptArgs(1) = RTrim(cmbNroguia.SelectedItem)
                    gsRptArgs(2) = RTrim(txtnguia.Text)
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_DOCUMENTO_CALIDAD_EASY_PEEL.rpt " & ELCERTIFICABE.ser_doc_ref & " " & ELCERTIFICABE.nro_ser_doc
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Function OkData2() As Boolean
        If txtproducto.Text = "" Then
            MsgBox("Ingrese el Producto", MsgBoxStyle.Exclamation)
            txtproducto.Focus()
            Return False
        End If
        If txtenvase.Text = "" Then
            MsgBox("Ingrese el Tipo envase", MsgBoxStyle.Exclamation)
            txtenvase.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnTapaPlastica_Click(sender As Object, e As EventArgs) Handles btnTapaPlastica.Click
        If OkData3() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELCERTIFICABE As New ELCERTIFICABE
                ELCERTIFICABE.t_doc_ref = ELCERTIFICABL.SelectRowCountP
                ELCERTIFICABE.nro_ser_doc = txtnguia.Text
                ELCERTIFICABE.ser_doc_ref = cmbNroguia.SelectedItem
                ELCERTIFICABE.art_cod = cmbarticulo.Text

                ELCERTIFICABE.o1 = txtproduc3.Text
                ELCERTIFICABE.o2 = txttipoenvase3.Text
                ELCERTIFICABE.o3 = txtaltmenor.Text
                ELCERTIFICABE.o4 = txtalturatot.Text
                ELCERTIFICABE.o5 = txtdiaminter.Text
                ELCERTIFICABE.o6 = txtdiammayor.Text
                ELCERTIFICABE.o7 = txtpesotapa.Text
                ELCERTIFICABE.o8 = txtembajalepri.Text
                ELCERTIFICABE.o9 = txtembajalesec.Text
                ELCERTIFICABE.m1 = txtseparado.Text
                ELCERTIFICABE.m2 = txtntapa.Text
                ELCERTIFICABE.m3 = txtmaterialtapa.Text
                ELCERTIFICABE.m4 = txtacabfintap.Text

                ELCERTIFICABE.es12 = txtx4.Text
                ELCERTIFICABE.es13 = txtx5.Text
                ELCERTIFICABE.es14 = txtx6.Text

                ELCERTIFICABE.usuario = gsCodUsr

                gsError = ELCERTIFICABL.SaveRow3(ELCERTIFICABE, flagAccion, cmbTpaquete.SelectedIndex + 1)
                If gsError = "OK" Then

                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = ELCERTIFICABE.t_doc_ref
                    gsRptArgs(1) = RTrim(cmbNroguia.SelectedItem)
                    gsRptArgs(2) = RTrim(txtnguia.Text)
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_DOCUMENTO_CALIDAD_TAPA_PLASTICA.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    'Dispose()
                    'Exit Sub
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Function OkData3() As Boolean
        If txtproduc3.Text = "" Then
            MsgBox("Ingrese el Producto", MsgBoxStyle.Exclamation)
            txtproduc3.Focus()
            Return False
        End If
        If txttipoenvase3.Text = "" Then
            MsgBox("Ingrese el Tipo envase", MsgBoxStyle.Exclamation)
            txttipoenvase3.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnTapaTelescopica_Click_1(sender As Object, e As EventArgs) Handles btnTapaTelescopica.Click
        If OkData4() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELCERTIFICABE As New ELCERTIFICABE
                ELCERTIFICABE.t_doc_ref = ELCERTIFICABL.SelectRowCountT
                ELCERTIFICABE.nro_ser_doc = txtnguia.Text
                ELCERTIFICABE.ser_doc_ref = cmbNroguia.SelectedItem
                ELCERTIFICABE.art_cod = cmbarticulo.Text

                ELCERTIFICABE.alt_cuerpo = txtproducto4.Text
                ELCERTIFICABE.alt_envase = txttipoenvase4.Text
                ELCERTIFICABE.dia_interno = txtdiammayexter.Text
                ELCERTIFICABE.dia_externo = txtdiammenrexter.Text
                ELCERTIFICABE.anc_envase = txtabertot.Text
                ELCERTIFICABE.larg_envase = txtdiammenortap.Text
                ELCERTIFICABE.alt_tapa = txtdiamextros.Text
                ELCERTIFICABE.pes_envase = txtpesodtapa.Text
                ELCERTIFICABE.tipo_acta = txtalturatotdiame.Text

                ELCERTIFICABE.alt_asa = txtdiametrajuste.Text
                ELCERTIFICABE.obs1 = txtranuraajuste.Text
                ELCERTIFICABE.obs2 = txtdiaminterbase.Text
                ELCERTIFICABE.obs3 = diamextajustbase.Text
                ELCERTIFICABE.obs4 = txtpesobase.Text
                ELCERTIFICABE.obs5 = txtv1.Text
                ELCERTIFICABE.Color = cmbcolor.Text

                ELCERTIFICABE.o1 = txtv2.Text
                ELCERTIFICABE.o2 = txtv3.Text
                ELCERTIFICABE.o3 = txtv4.Text
                ELCERTIFICABE.o4 = txtv5.Text
                ELCERTIFICABE.o5 = txtv6.Text
                ELCERTIFICABE.o6 = txtv7.Text
                ELCERTIFICABE.o7 = txtv8.Text
                ELCERTIFICABE.o8 = txtv9.Text
                ELCERTIFICABE.o9 = txtv10.Text
                ELCERTIFICABE.m1 = txtv11.Text
                ELCERTIFICABE.m2 = txtv12.Text
                ELCERTIFICABE.m3 = txtv13.Text
                ELCERTIFICABE.m4 = txtv14.Text
                ELCERTIFICABE.m5 = txtv15.Text
                ELCERTIFICABE.m6 = txtv16.Text
                ELCERTIFICABE.m7 = txtv17.Text
                ELCERTIFICABE.m8 = txtv18.Text
                ELCERTIFICABE.m9 = txtv19.Text
                ELCERTIFICABE.p1 = txtv20.Text
                ELCERTIFICABE.p2 = txtv21.Text
                ELCERTIFICABE.p3 = txtv22.Text
                ELCERTIFICABE.p4 = txtv23.Text
                ELCERTIFICABE.p5 = txtv24.Text
                ELCERTIFICABE.p6 = txtr1.Text
                ELCERTIFICABE.p7 = txtr2.Text
                ELCERTIFICABE.p8 = txtr3.Text
                ELCERTIFICABE.p9 = txtr4.Text
                ELCERTIFICABE.es1 = txtr5.Text
                ELCERTIFICABE.es2 = txtr6.Text
                ELCERTIFICABE.es3 = txtr7.Text
                ELCERTIFICABE.es4 = txtr8.Text
                ELCERTIFICABE.es5 = txtr9.Text
                ELCERTIFICABE.es6 = txtr10.Text
                ELCERTIFICABE.es7 = txtr11.Text
                ELCERTIFICABE.fec_prov = txtr12.Text

                ELCERTIFICABE.es8 = txtdiamajuste.Text
                ELCERTIFICABE.es9 = txtv25.Text
                ELCERTIFICABE.es10 = txtv26.Text
                ELCERTIFICABE.es11 = txtr13.Text

                ELCERTIFICABE.es12 = txtx7.Text
                ELCERTIFICABE.es13 = txtx8.Text
                ELCERTIFICABE.es14 = txtx9.Text

                ELCERTIFICABE.usuario = gsCodUsr

                gsError = ELCERTIFICABL.SaveRow4(ELCERTIFICABE, flagAccion, cmbTpaquete.SelectedIndex + 1)
                If gsError = "OK" Then

                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = ELCERTIFICABE.t_doc_ref
                    gsRptArgs(1) = RTrim(cmbNroguia.SelectedItem)
                    gsRptArgs(2) = RTrim(txtnguia.Text)
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_DOCUMENTO_CALIDAD_TAPA_TELESCOPICAS.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    'Dispose()
                    'Exit Sub
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Function OkData4() As Boolean
        If txtproducto4.Text = "" Then
            MsgBox("Ingrese el Producto", MsgBoxStyle.Exclamation)
            txtproducto4.Focus()
            Return False
        End If
        If txttipoenvase4.Text = "" Then
            MsgBox("Ingrese el Tipo envase", MsgBoxStyle.Exclamation)
            txttipoenvase4.Focus()
            Return False
        End If
        If cmbcolor.Text = "" Then
            MsgBox("Seleccione el color", MsgBoxStyle.Exclamation)
            txttipoenvase4.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub txtproducto_LostFocus(sender As Object, e As EventArgs) Handles txtproducto.LostFocus
        Dim producto As String
        If txtproducto.Text <> "" Then
            If txtproducto.Text.Length > 24 Then
                producto = "%" + txtproducto.Text.Substring(0, 23).Trim + "%"
            Else
                producto = "%" + txtproducto.Text.Trim + "%"
            End If
            Dim Series As String() = ELCERTIFICABL.SelectGetDataEasy(producto).Split("|")
            If Series.Length > 3 Then

                txtenvase.Text = Series(0).Trim()
                txtdiamext.Text = Series(1).Trim()
                txtdiamint.Text = Series(2).Trim()
                txtdiamcierr.Text = Series(3).Trim()
                txtprofund.Text = Series(4).Trim()
                txtalturcor.Text = Series(5).Trim()
                txtdescreasy.Text = Series(6).Trim()
                txtacabado.Text = Series(7).Trim()
                txtcompuesto.Text = Series(8).Trim()
                txtembajpr.Text = Series(9).Trim()
                txtembajsecu.Text = Series(10).Trim()
                txtseparad.Text = Series(11).Trim()
                txtnropa.Text = Series(12).Trim()

            Else
                MsgBox("No hay Considencias para este Producto ", MsgBoxStyle.Exclamation)
            End If
        Else
            producto = ""
        End If

    End Sub

    Private Sub txtproduc3_LostFocus(sender As Object, e As EventArgs) Handles txtproduc3.LostFocus
        Dim producto As String
        If txtproduc3.Text <> "" Then
            If txtproduc3.Text.Length > 23 Then
                producto = "%" + txtproduc3.Text.Substring(0, 22).Trim + "%"
            Else
                producto = "%" + txtproduc3.Text.Trim + "%"
            End If
            Dim Series As String() = ELCERTIFICABL.SelectGetDataTapaPlas(producto).Split("|")
            If Series.Length > 3 Then

                txttipoenvase3.Text = Series(0).Trim()
                txtaltmenor.Text = Series(1).Trim()
                txtalturatot.Text = Series(2).Trim()
                txtdiaminter.Text = Series(3).Trim()
                txtdiammayor.Text = Series(4).Trim()
                txtpesotapa.Text = Series(5).Trim()
                txtembajalepri.Text = Series(6).Trim()
                txtembajalesec.Text = Series(7).Trim()
                txtseparado.Text = Series(8).Trim()
                txtntapa.Text = Series(9).Trim()
                txtmaterialtapa.Text = Series(10).Trim()
                txtacabfintap.Text = Series(11).Trim()

            Else
                MsgBox("No hay Considencias para este Producto ", MsgBoxStyle.Exclamation)
            End If
        Else
            producto = ""
        End If
    End Sub

    Private Sub txtproducto4_LostFocus(sender As Object, e As EventArgs) Handles txtproducto4.LostFocus
        Dim producto As String
        If txtproducto4.Text <> "" Then
            If txtproducto4.Text.Length > 23 Then
                producto = "%" + txtproducto4.Text.Substring(0, 22).Trim + "%"
            Else
                producto = "%" + txtproducto4.Text.Trim + "%"
            End If
            Dim Series As String() = ELCERTIFICABL.SelectGetDataTapaTel(producto).Split("|")
            If Series.Length > 3 Then

                txttipoenvase4.Text = Series(0).Trim()
                txtdiammayexter.Text = Series(1).Trim()
                txtdiammenrexter.Text = Series(2).Trim()
                txtabertot.Text = Series(3).Trim()
                txtdiammenortap.Text = Series(4).Trim()
                txtdiamextros.Text = Series(5).Trim()
                txtpesodtapa.Text = Series(6).Trim()
                txtalturatotdiame.Text = Series(7).Trim()
                txtdiametrajuste.Text = Series(8).Trim()
                txtranuraajuste.Text = Series(9).Trim()
                txtdiaminterbase.Text = Series(10).Trim()
                diamextajustbase.Text = Series(11).Trim()
                txtpesobase.Text = Series(12).Trim()
                txtv1.Text = Series(13).Trim()
                txtv2.Text = Series(14).Trim()
                txtv3.Text = Series(15).Trim()
                txtv4.Text = Series(16).Trim()
                txtv5.Text = Series(17).Trim()
                txtv6.Text = Series(18).Trim()
                txtv7.Text = Series(19).Trim()
                txtv8.Text = Series(20).Trim()
                txtv9.Text = Series(21).Trim()
                txtv10.Text = Series(22).Trim()
                txtv11.Text = Series(23).Trim()
                txtv12.Text = Series(24).Trim()
                txtv13.Text = Series(25).Trim()
                txtv14.Text = Series(26).Trim()
                txtv15.Text = Series(27).Trim()
                txtv16.Text = Series(28).Trim()
                txtv17.Text = Series(29).Trim()
                txtv18.Text = Series(30).Trim()
                txtv19.Text = Series(31).Trim()
                txtv20.Text = Series(32).Trim()
                txtv21.Text = Series(33).Trim()
                txtv22.Text = Series(34).Trim()
                txtv23.Text = Series(35).Trim()
                txtv24.Text = Series(36).Trim()
                txtr1.Text = Series(37).Trim()
                txtr2.Text = Series(38).Trim()
                txtr3.Text = Series(39).Trim()
                txtr4.Text = Series(40).Trim()
                txtr5.Text = Series(41).Trim()
                txtr6.Text = Series(42).Trim()
                txtr7.Text = Series(43).Trim()
                txtr8.Text = Series(44).Trim()
                txtr9.Text = Series(45).Trim()
                txtr10.Text = Series(46).Trim()
                txtr11.Text = Series(47).Trim()
                txtr12.Text = Series(48).Trim()

                txtdiamajuste.Text = Series(49).Trim()
                txtv25.Text = Series(50).Trim()
                txtv26.Text = Series(51).Trim()
                txtr13.Text = Series(52).Trim()

            Else
                MsgBox("No hay Considencias para este Producto ", MsgBoxStyle.Exclamation)
            End If
        Else
            producto = ""
        End If


    End Sub

    Private Sub FormELCERTIFICA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub


    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
#Disable Warning BC42105 ' La función 'GetCmb' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function
    '-------------------------------------------------------Protocolo--------------------------------------------------------------


    Private Sub txtNro_two_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtNro_two.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "237"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                cmbarticulo.Items().Clear()
                dgvt_doc.Rows.Clear()
                dgvt_doc.DataSource = Nothing

                txtNro_two.Text = gLinea
                btnBusTwo_Click(sender, e)
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            btnBusTwo_Click(sender, e)
        End If
    End Sub

    Private Sub btnBusTwo_Click(sender As Object, e As EventArgs) Handles btnBusTwo.Click

        txtctct_two.Text = Nothing
        Dim dt As DataTable
        Dim ELCERTIFICABL As New ELCERTIFICABL
        dt = ELCERTIFICABL.SelectAl2(txtNro_two.Text, txtSer_two.Text)

        For Each row As DataRow In dt.Rows
            txtctct_two.Text = IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE"))
            ctct = IIf(IsDBNull(row("ctct_cod")), "", row("ctct_cod"))
            tipo = IIf(IsDBNull(row("t_doc_Ref")), "", row("t_doc_ref"))
        Next
        dgvControl.Rows.Clear()

        dgvLote.Rows.Clear()
        If txtNro_two.Text <> "" And txtSer_two.Text <> "" And txtctct_two.Text <> Nothing Then
            GetCmb("NOM_ART", "COD_ART", dt, ComboBox2)
            Button3.Enabled = False
            Button4.Enabled = False
        ElseIf txtctct_two.Text = Nothing Then
            ComboBox2.DataSource = Nothing
            ComboBox2.Items.Clear()
            Button3.Enabled = False
            Button4.Enabled = False
            TextBox2.Text = ""
            txtNro_EnvTwo.Text = ""
            txtMedida.Text = ""
            txtFecEmi.Text = ""
        Else
            Button3.Enabled = False
            Button4.Enabled = False
        End If
        twoEst = "N"
        cmbEst.SelectedIndex = 0
        Button1.Enabled = True
        txt_nro_doc_ref.Text = txtNro_two.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim ok As String
        TextBox2.Text = ""
        txtNro_EnvTwo.Text = ""
        txtMedida.Text = ""
        txtFecEmi.Text = ""
        If ComboBox2.ValueMember <> "" And ComboBox2.Text <> Nothing Then

            Dim ELCERTIFICABL As New ELCERTIFICABL
            ok = ELCERTIFICABL.SelectOk(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)

            If ok = Nothing Or ok = "A" Or twoEst = "M" Or btnMod.Text = "Volver" Then

                Dim dt As DataTable
                'Dim ELCERTIFICABL As New ELCERTIFICABL
                dt = ELCERTIFICABL.SelectArt(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)
                For Each ro As DataRow In dt.Rows
                    TextBox2.Text = IIf(IsDBNull(ro("NOM")), "", ro("NOM"))
                    txtNro_EnvTwo.Text = IIf(IsDBNull(ro("CANTIDAD")), "", ro("CANTIDAD"))
                    txtMedida.Text = IIf(IsDBNull(ro("MEDIDA")), "", ro("MEDIDA"))
                    txtFecEmi.Text = IIf(IsDBNull(ro("FECHA")), "", ro("FECHA"))
                    Button3.Enabled = True
                    Button4.Enabled = True
                Next
            ElseIf ok = "H" Then
                MsgBox("Articulo Existente", MsgBoxStyle.Information)
                'MessageBox.Show("Articulo Existente")
            End If

        End If
    End Sub

    Private Sub txtMedida_TextChanged(sender As Object, e As EventArgs) Handles txtMedida.TextChanged
        Dim Act As String
        If btnMod.Text = "Volver" Then
            Act = "M"
        Else
            Act = "N"
        End If
        If txtMedida.Text <> Nothing Then
            Dim dt As DataTable
            Dim ELCERTIFICABL As New ELCERTIFICABL
            dt = ELCERTIFICABL.SelectCon("09", txtSer_two.Text, txtNro_two.Text, txtMedida.Text, Act, ComboBox2.Text)
            For Each row As DataRow In dt.Rows
                dgvControl.Rows.Add(
                                 IIf(IsDBNull(row("ESPESOR")), "", row("ESPESOR")),
                                 IIf(IsDBNull(row("TEMPLE")), "", row("TEMPLE")),
                                 IIf(IsDBNull((txtMedida.Text)), "", (txtMedida.Text)),
                                 IIf(IsDBNull(row("TRATAMIENTO_TERMICO")), "", row("TRATAMIENTO_TERMICO")),
                                 IIf(IsDBNull(row("REC_INTERIOR")), "", row("REC_INTERIOR")),
                                 IIf(IsDBNull(row("MODELO")), "", row("MODELO")),
                                 IIf(IsDBNull(row("CANT_BULTOS")), "", row("CANT_BULTOS")),
                                 IIf(IsDBNull(row("DIAM_EXTERIOR")), "", row("DIAM_EXTERIOR")),
                                 IIf(IsDBNull(row("DIAM_INTERIOR")), "", row("DIAM_INTERIOR")),
                                 IIf(IsDBNull(row("DIAM_UNIA")), "", row("DIAM_UNIA")),
                                 IIf(IsDBNull(row("ALT_EXTERIOR")), "", row("ALT_EXTERIOR")),
                                 IIf(IsDBNull(row("NIVEL_VACIO")), "", row("NIVEL_VACIO")),
                                 IIf(IsDBNull(row("SEGURIDAD_CIERRE")), "", row("SEGURIDAD_CIERRE")),
                                 IIf(IsDBNull(row("DIAM_EXT_RES")), "", row("DIAM_EXT_RES")),
                                 IIf(IsDBNull(row("DIAM_INT_RES")), "", row("DIAM_INT_RES")),
                                 IIf(IsDBNull(row("DIAM_UNIA_RES")), "", row("DIAM_UNIA_RES")),
                                 IIf(IsDBNull(row("ALT_EXT_RES")), "", row("ALT_EXT_RES")),
                                 IIf(IsDBNull(row("SAF")), "", row("SAF")),
                                 IIf(IsDBNull(row("DIA_EXT_MEN")), "", row("DIA_EXT_MEN")),
                                 IIf(IsDBNull(row("DIA_EXT_MAY")), "", row("DIA_EXT_MAY")),
                                 IIf(IsDBNull(row("DIA_INT_MEN")), "", row("DIA_INT_MEN")),
                                 IIf(IsDBNull(row("DIA_INT_MAY")), "", row("DIA_INT_MAY")),
                                 IIf(IsDBNull(row("DIA_UNIA_MEN")), "", row("DIA_UNIA_MEN")),
                                 IIf(IsDBNull(row("DIA_UNIA_MAY")), "", row("DIA_UNIA_MAY")),
                                 IIf(IsDBNull(row("ALT_EXT_MEN")), "", row("ALT_EXT_MEN")),
                                 IIf(IsDBNull(row("ALT_EXT_MAY")), "", row("ALT_EXT_MAY")))
            Next
        Else
            dgvControl.Rows.Clear()
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New FormMantELCERTIFICA
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New FormMantDetElcertifica
        frm.TextBox3.Text = ComboBox2.Text
        frm.twoE = twoEst
        frm.TextBox2.Text = txtNro_two.Text
        frm.ShowDialog()
        If dgvLote.RowCount = Nothing Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        If dgvLote.RowCount <> Nothing Then
            If MessageBox.Show("Esta seguro de Eliminar el lote",
                               gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            dgvLote.Rows.RemoveAt(dgvLote.CurrentRow.Index)
            dgvt_doc.Refresh()
            'Label106.Text = dgvLote.CurrentRow.Index
        Else
            MsgBox("No hay datos")
        End If
        If dgvLote.RowCount = Nothing Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
    End Sub

    Private Sub btnMod_Click_1(sender As Object, e As EventArgs) Handles btnMod.Click

        If btnMod.Text = "Modificar" Then
            GroupBox17.Visible = False
            GroupBox18.Visible = False
            GroupBox19.Visible = True

            btnMod.Text = "Volver"
            cmbBus2.SelectedIndex = 0
            Dim dt As DataTable
            Dim ELCERTIFICABL As New ELCERTIFICABL
            dt = ELCERTIFICABL.SelectAl3("3", "3", "3")

            gdtMainData = dt
            dgvMod.DataSource = dt
            dgvMod.Refresh()
            ' For Each row As DataRow In dt.Rows
            '     dgvMod.Rows.Add(
            '                      IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
            '                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
            '                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
            '                      IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")),
            '                      IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
            '                      IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE")),
            '                      IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),
            '                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
            '                      IIf(IsDBNull(row("EST")), "", row("EST")))
            ' Next

            Button1.Enabled = False
            cmbBus2.Items.Clear()
            For Each col As DataGridViewColumn In dgvMod.Columns
                cmbBus2.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            If dgvMod.Rows.Count > 0 Then
                cmbBus2.SelectedIndex = 1
            End If
        Else
            GroupBox17.Visible = True
            GroupBox18.Visible = True
            GroupBox19.Visible = False
            '    dgvMod.Rows.Clear()
            btnMod.Text = "Modificar"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If dgvControl.RowCount = Nothing Then
            MessageBox.Show("INGRESAR CONTROL DE CALIDAD")
            Exit Sub
        End If

        If dgvControl.Rows(0).Cells("DIA EXT RES").Value = Nothing And dgvControl.Rows(0).Cells("DIA INT RES").Value = Nothing And dgvControl.Rows(0).Cells("DIA UÑAS RES").Value = Nothing And dgvControl.Rows(0).Cells("ALT EXT RES").Value = Nothing Then
            MessageBox.Show("CONTROL DE CALIDAD INCOMPOLETO")
            Exit Sub
        End If

        If dgvLote.RowCount = Nothing Then
            MessageBox.Show("INGRESAR LOTE")
            Exit Sub
        End If

        If txt_nro_doc_ref.Text <> txtNro_two.Text Then
            MessageBox.Show("Numero de documento distinto")
            'Exit Sub
        End If
        DAcumula6 = "LT "
        If contar() = False Then
            MessageBox.Show("Cantidad distinta (LOTE)")
            'Exit Sub
        End If

        Dim ELCERTIFICABE As New ELCERTIFICABE
        Dim inc As String


        If dgvControl.Rows(0).Cells("SAF").Value = Nothing Then
            Dim ELCERTIFICABL As New ELCERTIFICABL
            inc = ELCERTIFICABL.SelectInc()
            ELCERTIFICABE.inc = inc
            dgvControl.Rows(0).Cells("SAF").Value = inc
        Else
            ELCERTIFICABE.inc = dgvControl.Rows(0).Cells("SAF").Value
        End If

        ELCERTIFICABE.t_doc_ref = tipo
        ELCERTIFICABE.ser_doc_ref = txtSer_two.Text
        ELCERTIFICABE.nro_doc_ref = txtNro_two.Text
        ELCERTIFICABE.art_cod = ComboBox2.Text

        ELCERTIFICABE.cantidad1 = txtNro_EnvTwo.Text

        ELCERTIFICABE.ctct_cod = ctct
        ELCERTIFICABE.Espesor = dgvControl.Rows(0).Cells("ESPESOR").Value
        ELCERTIFICABE.temple = dgvControl.Rows(0).Cells("temple").Value
        ELCERTIFICABE.diametro = dgvControl.Rows(0).Cells("DIAMETRO").Value
        ELCERTIFICABE.tratamiento_termico = dgvControl.Rows(0).Cells("TRATAMIENTO TERMICO").Value 'TRATAMIENTO TERMICO", "TRA. TERMICO
        ELCERTIFICABE.recubrimiento_termico = dgvControl.Rows(0).Cells("recubrimiento INTERIOR").Value
        ELCERTIFICABE.modelo = dgvControl.Rows(0).Cells("modelo").Value
        ELCERTIFICABE.cantidad_tapas_bulto = dgvControl.Rows(0).Cells("cantidad tapas bulto").Value
        ELCERTIFICABE.diametro_exterior = dgvControl.Rows(0).Cells("diametro exterior").Value
        ELCERTIFICABE.diametro_interior = dgvControl.Rows(0).Cells("diametro interior").Value
        ELCERTIFICABE.diametro_entre_unias = dgvControl.Rows(0).Cells("DIAMETRO ENTRE UÑAS").Value
        ELCERTIFICABE.altura_de_exterior = dgvControl.Rows(0).Cells("altura de exterior").Value
        ELCERTIFICABE.nivel_de_vacio = dgvControl.Rows(0).Cells("nivel de vacio").Value
        ELCERTIFICABE.seguridad_de_cierre = dgvControl.Rows(0).Cells("seguridad de cierre").Value

        ELCERTIFICABE.diametro_exterior_res = dgvControl.Rows(0).Cells("DIA EXT RES").Value
        ELCERTIFICABE.diametro_interior_res = dgvControl.Rows(0).Cells("DIA INT RES").Value
        ELCERTIFICABE.diametro_entre_unias_res = dgvControl.Rows(0).Cells("DIA UÑAS RES").Value
        ELCERTIFICABE.altura_de_exterior_res = dgvControl.Rows(0).Cells("ALT EXT RES").Value

        ELCERTIFICABE.txto1 = dgvControl.Rows(0).Cells("DIA_EXT_MEN").Value
        ELCERTIFICABE.txtm1 = dgvControl.Rows(0).Cells("DIA_EXT_MAY").Value
        ELCERTIFICABE.txto2 = dgvControl.Rows(0).Cells("DIA_INT_MEN").Value
        ELCERTIFICABE.txtm2 = dgvControl.Rows(0).Cells("DIA_INT_MAY").Value
        ELCERTIFICABE.txto3 = dgvControl.Rows(0).Cells("DIA_UNIA_MEN").Value
        ELCERTIFICABE.txtm3 = dgvControl.Rows(0).Cells("DIA_UNIA_MAY").Value
        ELCERTIFICABE.txto4 = dgvControl.Rows(0).Cells("ALT_EXT_MEN").Value
        ELCERTIFICABE.txtm4 = dgvControl.Rows(0).Cells("ALT_EXT_MAY").Value


        ELCERTIFICABE.fechac = txtFecEmi.Text
        ELCERTIFICABE.ctct_cod = ctct
        ELCERTIFICABE.medida = txtMedida.Text
        ELCERTIFICABE.fechadia = (DateTime.Now.ToString("dd/MM/yyyy")).ToString()

        If cmbEst.SelectedIndex = 0 Then
            ELCERTIFICABE.est = "H"
        ElseIf cmbEst.SelectedIndex = 1 Then
            ELCERTIFICABE.est = "A"
            twoEst = "A"
        End If

        ELCERTIFICABE.descri = DAcumula6.ToString()
        gsError = ELCERTIFICABL.SaveRowTwo(ELCERTIFICABE, twoEst, dgvLote)

        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

        If cmbEst.SelectedIndex = 1 Then
            Button1.Enabled = False

            twoEst = "M"
        ElseIf gsError = "OK" Then
            gsRptArgs = {}
            ReDim gsRptArgs(3)
            gsRptArgs(0) = "09"
            gsRptArgs(1) = ELCERTIFICABE.ser_doc_ref
            gsRptArgs(2) = ELCERTIFICABE.nro_doc_ref
            gsRptArgs(3) = ELCERTIFICABE.art_cod
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_ELTBACTA_TWOCAL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

            twoEst = "M"
        End If
    End Sub
    Private Sub cmbBus2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbBus2.SelectedIndexChanged
        txtBus2.Text = Nothing
    End Sub

    Private Sub txtBus2_TextChanged_1(sender As Object, e As EventArgs) Handles txtBus2.TextChanged
        'Dim dt As DataTable
        'Dim ELCERTIFICABL As New ELCERTIFICABL
        'If txtBus2.Text <> Nothing Then
        '    dgvMod.Rows.Clear()
        '    dt = ELCERTIFICABL.SelectAl3(cmbBus2.SelectedIndex, txtBus2.Text, txtBus2.Text)
        '    For Each row As DataRow In dt.Rows
        '        dgvMod.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
        '                        IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
        '                        IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
        '                        IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")),
        '                        IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
        '                        IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE")),
        '                        IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),
        '                        IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
        '                        IIf(IsDBNull(row("EST")), "", row("EST")))
        '    Next
        'Else
        '    dgvMod.Rows.Clear()
        '    dt = ELCERTIFICABL.SelectAl3("3", "3", "3")
        '
        '    For Each row As DataRow In dt.Rows
        '        dgvMod.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
        '                        IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
        '                        IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
        '                        IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")),
        '                        IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
        '                        IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE")),
        '                        IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),
        '                        IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
        '                        IIf(IsDBNull(row("EST")), "", row("EST")))
        '    Next
        'End If


        If cmbBus2.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = txtBus2.Text
        If sCode.Trim = "" Then
            dgvMod.DataSource = gdtMainData
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor

        Dim dtNew As DataTable
        dtNew = gdtMainData.Clone()
        Dim sCampo As String = cmbBus2.Text
        Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '%" & sCode & "%'")

        For Each ldrRow As DataRow In dataRows
            dtNew.ImportRow(ldrRow)
        Next
        dgvMod.DataSource = dtNew

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub dgvMod_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMod.CellDoubleClick
        Dim M As String
        M = dgvMod.CurrentRow.Index

        txtNro_two.Text = dgvMod.Rows(M).Cells("NUMERO").Value
        txtSer_two.Text = dgvMod.Rows(M).Cells("SERIE").Value
        btnBusTwo_Click(sender, e)
        ComboBox2.Text = dgvMod.Rows(M).Cells("ARTICULO").Value

        Dim dt As DataTable
        Dim ELCERTIFICABL As New ELCERTIFICABL
        dt = ELCERTIFICABL.SelectAl4(dgvMod.Rows(M).Cells("TIPO").Value, dgvMod.Rows(M).Cells("SERIE").Value, dgvMod.Rows(M).Cells("NUMERO").Value, dgvMod.Rows(M).Cells("ARTICULO").Value)

        For Each row As DataRow In dt.Rows
            dgvLote.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                 IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                 IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                 IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                 IIf(IsDBNull(row("FEC_PRO")), "", row("FEC_PRO")),
                                 IIf(IsDBNull(row("TURNO")), "", row("TURNO")),
                                 IIf(IsDBNull(row("LOTE")), "", row("LOTE")))
        Next
        twoEst = "M"
        If dgvMod.Rows(M).Cells("EST").Value = "H" Then
            cmbEst.SelectedIndex = 0
        ElseIf dgvMod.Rows(M).Cells("EST").Value = "A" Then
            cmbEst.SelectedIndex = 1
        End If
        btnMod_Click_1(sender, e)
        If dgvLote.RowCount = Nothing Then
            dgvLote.Enabled = False
        Else
            dgvLote.Enabled = True
        End If
        Button1.Enabled = True
        Button5.Enabled = True
    End Sub
    Private Function contar() As Boolean
        Dim DAcumula1 As Integer = "0"
        Dim DAcumula3 As String = ""
        Dim DAcumula4 As String = ""
        Dim DAcumula5 As String = ""
        Dim DAcumula7 As String = ""
        Dim DCant1 As Double = "0.000"
        Dim DCant As Double = "0.000"

        For i = 0 To dgvLote.Rows.Count - 1
            Dim DAcumula2 As Double = dgvLote.Rows(i).Cells("CANTIDAD").Value * 1000
            DCant += DAcumula2
            For i1 = 1 To 2
                If DAcumula2 >= dgvControl.Rows(0).Cells("cantidad tapas bulto").Value Then
                    DAcumula2 = DAcumula2 - dgvControl.Rows(0).Cells("cantidad tapas bulto").Value
                    DAcumula1 = DAcumula1 + 1
                    i1 = 1
                ElseIf DAcumula2 <> 0 Then
                    i1 = 4
                    DAcumula3 = "SALDO DE " + DAcumula2.ToString()
                Else
                    i1 = 4
                    DAcumula3 = ""
                End If
            Next
            If i >= 1 Then
                DAcumula4 = " / "
            End If
            If DAcumula1 = 0 Then
                DAcumula7 = ""
            ElseIf DAcumula3 <> Nothing Then
                DAcumula7 = DAcumula1.ToString() + " CAJAS + "
            Else
                DAcumula7 = DAcumula1.ToString() + " CAJAS"
            End If

            DAcumula6 = DAcumula6.ToString() + DAcumula4.ToString() + (dgvLote.Rows(i).Cells("LOTE").Value).ToString() + (" F/P ").ToString() + CDate(dgvLote.Rows(i).Cells("FECHA produccion").Value).ToString("dd/MM/yy ") + ("(" + DAcumula7.ToString() + DAcumula3.ToString() + ")").ToString()
            DAcumula3 = ""
            DAcumula1 = 0
        Next

        If DCant = Val(txtNro_EnvTwo.Text) * 1000 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class