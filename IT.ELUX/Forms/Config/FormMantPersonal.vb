Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantPersonal
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private PERBL As New PERBL
    Private ASI_CPTOBL As New ASI_CPTOBL
    Private DERECHOHABBL As New DERECHOHABBL
    Private DHAB_DIRBL As New DHAB_DIRBL
    Private ELTBCLIENTEBL As New ELTBCLIENTEBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private catalogo As String = ""
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private Function OkData() As Boolean
        If txtcod.Text = "" Then
            MsgBox("Llene el Codigo", MsgBoxStyle.Exclamation)
            txtcod.Focus()
            Return False
        End If
        If txtnom1.Text = "" Then
            MsgBox("Ingrese Nombre del Personal", MsgBoxStyle.Exclamation)
            txtnom1.Focus()
            Return False
        End If
        If txtape1.Text = "" Then
            MsgBox("Ingrese Apellido del Personal", MsgBoxStyle.Exclamation)
            txtape1.Focus()
            Return False
        End If
        If cmbnn.SelectedIndex <= 0 Then
            MsgBox("Seleccione tipo del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmbx_sexo.SelectedIndex <= 0 Then
            MsgBox("Seleccione el sexo del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        'If txtubigeo_nac.TextLength = 0 Then
        '    MsgBox("Ingrese el ubigeo del personal", MsgBoxStyle.Exclamation)
        '    txtubigeo.Focus()
        '    Return False
        'End If
        If cmbt_rem.SelectedIndex <= 0 Then
            MsgBox("Seleccione el tipo de Remuneracion del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtcargo_cod.TextLength = 0 Then
            MsgBox("Seleccione el Cargo del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        'If txt_ccocod.TextLength <= 0 Or txt_ccocod.Text = "001" Then
        '    MsgBox("Seleccione el Centro Costo", MsgBoxStyle.Exclamation)
        '    txt_ccocod.Select()
        '    Return False
        'End If
        Return True
    End Function
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim co As Integer = 0
        Dim c As Integer = dgvdep.Rows.Count
        If c > 0 Then
            For i = 0 To dgvdep.Rows.Count - 1
                If dgvdep.Rows(i).Cells("VINCULO_COD").Value = "05" Then
                    co = co + 1
                End If
            Next
        End If
        If co > 0 And npdnro_hijo.Value = 0 Then
            If MessageBox.Show("¿Desea Poner la cantidad de Hijos?",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.No Then
                npdnro_hijo.Focus()
                Exit Sub
            End If
        End If
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim PERBE As New PERBE
        Dim ASI_CPTOBE As New ASI_CPTOBE
        Dim DERECHOHABBE As New DERECHOHABBE
        Dim DHAB_DIRBE As New DHAB_DIRBE
        PERBE.cod = txtcod.Text
        PERBE.APE1 = txtape1.Text
        PERBE.APE2 = txtape2.Text
        PERBE.NOM1 = txtnom1.Text
        PERBE.NOM2 = txtnom2.Text
        PERBE.ID_NRO = txtid_nro.Text
        PERBE.LE = txtle.Text
        PERBE.LM = txtlm.Text
        If cmbx_sexo.SelectedIndex = 1 Then
            PERBE.X_SEXO = "1"
        ElseIf cmbx_sexo.SelectedIndex = 2 Then
            PERBE.X_SEXO = "2"
        Else
            PERBE.X_SEXO = ""
        End If
        If cmbnn.SelectedIndex = 1 Then
            PERBE.NN = "21"
        ElseIf cmbnn.SelectedIndex = 2 Then
            PERBE.NN = "20"
        Else
            PERBE.NN = ""
        End If
        If cmbx_estciv.SelectedIndex = 1 Then
            PERBE.X_ESTCIV = "C"
        ElseIf cmbx_estciv.SelectedIndex = 2 Then
            PERBE.X_ESTCIV = "S"
        ElseIf cmbx_estciv.SelectedIndex = 3 Then
            PERBE.X_ESTCIV = "B"
        ElseIf cmbx_estciv.SelectedIndex = 4 Then
            PERBE.X_ESTCIV = "D"
        ElseIf cmbx_estciv.SelectedIndex = 5 Then
            PERBE.X_ESTCIV = "V"
        Else
            PERBE.X_ESTCIV = ""
        End If
        If cmbnac.SelectedIndex = 2 Then
            PERBE.NAC = "EXTRANJERO"
        ElseIf cmbnac.SelectedIndex = 1 Then
            PERBE.NAC = "PERUANO"
        Else
            PERBE.NAC = ""
        End If
        PERBE.NRO_HIJO = npdnro_hijo.Value
        PERBE.COD_EDUCATIVO = txtcod_educativo.Text
        PERBE.FEC_NAC = dtpfec_nac.Value
        PERBE.FECEMIDNI = dtpfec_emidni.Value
        PERBE.UBIGEO_NAC = txtubigeo_nac.Text
        PERBE.DIREC = txtdireccion.Text
        PERBE.TELF = txttelf.Text
        PERBE.UBIGEO = txtubigeo.Text
        PERBE.EMAIL = txtemail.Text
        If chkx_che.Checked Then
            PERBE.X_CHE = "S"
        Else
            PERBE.X_CHE = ""
        End If
        If cmbsit_cod.SelectedIndex = 1 Then
            PERBE.SIT_COD = "11"
        ElseIf cmbsit_cod.SelectedIndex = 2 Then
            PERBE.SIT_COD = "13"
        ElseIf cmbsit_cod.SelectedIndex = 3 Then
            PERBE.SIT_COD = "15"
        ElseIf cmbsit_cod.SelectedIndex = 4 Then
            PERBE.SIT_COD = "19"
        ElseIf cmbsit_cod.SelectedIndex = 5 Then
            PERBE.SIT_COD = "00"
        ElseIf cmbsit_cod.SelectedIndex = -1 Then
            PERBE.SIT_COD = ""
        End If
        PERBE.CARGO_COD = txtcargo_cod.Text
        'If cmbcco_cod.SelectedIndex = 1 Then
        '    PERBE.CCO_COD = "001"
        'End If
        PERBE.CCO_COD = "001"
        PERBE.CCO_COD_NUEVO = txt_ccocod.Text
        If cmbx_set.SelectedIndex = 1 Then
            PERBE.X_SET = "1"
        ElseIf cmbx_set.SelectedIndex = 2 Then
            PERBE.X_SET = "2"
        ElseIf cmbx_set.SelectedIndex = 3 Then
            PERBE.X_SET = "0"
        ElseIf cmbx_set.SelectedIndex = -1 Then
            PERBE.X_SET = ""
        End If
        If cmbt_trab.SelectedIndex = 1 Then
            PERBE.T_TRAB = "01"
        ElseIf cmbt_trab.SelectedIndex = 2 Then
            PERBE.T_TRAB = "02"
        ElseIf cmbt_trab.SelectedIndex = 3 Then
            PERBE.T_TRAB = "04"
        ElseIf cmbt_trab.SelectedIndex = 4 Then
            PERBE.T_TRAB = "14"
        ElseIf cmbt_trab.SelectedIndex = 5 Then
            PERBE.T_TRAB = "99"
        Else
            PERBE.T_TRAB = ""
        End If
        PERBE.CARGO_CODIGO = txtcargo_codigo.Text
        PERBE.CARGO = txtcargo.Text
        PERBE.LINEA_COD = txtlinea_cod.Text
        PERBE.TALLA = txttalla.Text
        PERBE.TALLA1 = txttalla1.Text
        PERBE.FEC_ING = dtpfec_ing.Value
        If dtpfec_icese.Checked = False Then
            PERBE.FECC_ICESE = Nothing
            If flagAccion = "M" Then
                flagAccion = "MM"
            End If
        ElseIf dtpfec_icese.Checked = True Then
            PERBE.FEC_ICESE = dtpfec_icese.Value
        End If
        If cmbmoti_baja_cod.SelectedIndex = 1 Then
            PERBE.MOTI_BAJA_COD = "01"
        ElseIf cmbmoti_baja_cod.SelectedIndex = 2 Then
            PERBE.MOTI_BAJA_COD = "03"
        ElseIf cmbmoti_baja_cod.SelectedIndex = 3 Then
            PERBE.MOTI_BAJA_COD = "05"
        ElseIf cmbmoti_baja_cod.SelectedIndex = 4 Then
            PERBE.MOTI_BAJA_COD = "06"
        ElseIf cmbmoti_baja_cod.SelectedIndex = 5 Then
            PERBE.MOTI_BAJA_COD = "09"
        ElseIf cmbmoti_baja_cod.SelectedIndex = 6 Then
            PERBE.MOTI_BAJA_COD = "07"
        ElseIf cmbmoti_baja_cod.SelectedIndex = -1 Then
            PERBE.MOTI_BAJA_COD = ""
        End If
        PERBE.CONTRATO_PRDO = txtcontrato_prdo.Text
        If cmbafp_cod.SelectedIndex = 1 Then
            PERBE.AFP_COD = "001"
        ElseIf cmbafp_cod.SelectedIndex = 2 Then
            PERBE.AFP_COD = "003"
        ElseIf cmbafp_cod.SelectedIndex = 3 Then
            PERBE.AFP_COD = "004"
        ElseIf cmbafp_cod.SelectedIndex = 4 Then
            PERBE.AFP_COD = "005"
        ElseIf cmbafp_cod.SelectedIndex = 5 Then
            PERBE.AFP_COD = "006"
        ElseIf cmbafp_cod.SelectedIndex = 6 Then
            PERBE.AFP_COD = "007"
        Else
            PERBE.AFP_COD = ""
        End If
        PERBE.NRO_AFP = txtnro_afp.Text
        PERBE.IPSS = txtipss.Text
        If txtgra_mes.TextLength > 0 Then
            PERBE.GRA_MES = txtgra_mes.Text
        End If

        If chkx_comision.Checked = True Then
            PERBE.X_COMISION = "1"
        Else
            PERBE.X_COMISION = ""
        End If
        If cmbcta_dolar.SelectedIndex = 2 Then
            PERBE.CTA_DOLAR = "1"
        ElseIf cmbcta_dolar.SelectedIndex = 1 Then
            PERBE.CTA_DOLAR = "2"
        ElseIf cmbcta_dolar.SelectedIndex = -1 Then
            PERBE.CTA_DOLAR = ""
        End If
        If chkx_vende.Checked = False Then
            PERBE.X_VENDE = ""
        Else
            PERBE.X_VENDE = "1"
        End If
        If chkt_gra.Checked = False Then
            PERBE.T_GRA = ""
        Else
            PERBE.T_GRA = "1"
        End If
        PERBE.NRO_CTA_BANCO = txtnro_cta_banco.Text
        PERBE.BCO_CTS_COD = txtbco_cts_cod.Text
        PERBE.NRO_CTA_CTS = txtnro_cta_cts.Text
        PERBE.OBS = txtobs.Text
        PERBE.MES_TIEMPO_SERV = npdmes_tiempo_serv.Value
        If cmbt_rem.SelectedIndex = 1 Then
            PERBE.T_REM = "01"
        ElseIf cmbt_rem.SelectedIndex = 2 Then
            PERBE.T_REM = "02"
        ElseIf cmbt_rem.SelectedIndex = 3 Then
            PERBE.T_REM = "03"
        ElseIf cmbt_rem.SelectedIndex = 4 Then
            PERBE.T_REM = "04"
        Else
            PERBE.T_REM = ""
        End If
        If txttot_dia.TextLength > 0 Then
            PERBE.TOT_DIA = txttot_dia.Text
        End If
        If txttot_hor.TextLength > 0 Then
            PERBE.TOT_HOR = txttot_hor.Text
        End If
        If txttot_min.TextLength > 0 Then
            PERBE.TOT_MIN = txttot_min.Text
        End If
        If txttarde.TextLength > 0 Then
            PERBE.TARDE = txttarde.Text
        End If
        PERBE.PER_ANHO = cmbañoq.Text
        PERBE.PER_QUINTA = npdvalquinta.Value
        If cmbafp_cod.SelectedIndex <> "5" Then
            PERBE.FEC_AFP = dtpfec_afp.Value
        End If
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = PERBL.SaveRow(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub FormMantCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        gsError = ""
        gpCaption = "Personal"
        Me.Text = gpCaption
        'Concepto
        dgvcpto.Columns.Add("DNI", "Dni") '
        dgvcpto.Columns.Add("NOMBRES_APELLIDOS", "NOMBRES_APELLIDOS") '
        dgvcpto.Columns.Add("CODIGO", "CODIGO") '
        dgvcpto.Columns.Add("DESCRIPCION", "DESCRIPCION")
        dgvcpto.Columns.Add("MONTO", "MONTO")

        'Dependientes
        dgvdep.Columns.Add("COD", "Codigo") '
        dgvdep.Columns.Add("APE1", "Apellido1") '
        dgvdep.Columns.Add("Ape2", "Apellido2") '
        dgvdep.Columns.Add("Nom1", "Nombre1")
        dgvdep.Columns.Add("Nom2", "Nombre2")
        dgvdep.Columns.Add("Fec_Nac", "Fec. Nac.")
        dgvdep.Columns.Add("X_TDOC", "Tip. Doc.")
        dgvdep.Columns.Add("LE", "Doc. Identidad")
        dgvdep.Columns.Add("vinculo_cod", "Vinculo")

        'Dir. Dependientes
        dgvdirdep.Columns.Add("DIR_COD", "Codigo") '
        dgvdirdep.Columns.Add("TIP_ZONA_COD", "Cod. Zona") '
        dgvdirdep.Columns.Add("nom_via", "Nom Via") '
        dgvdirdep.Columns.Add("NRO_VIA", "Nro. Via")
        dgvdirdep.Columns.Add("NRO_DPTO", "Nro. Dpto.")
        dgvdirdep.Columns.Add("INT_VIA", "Int. Via")
        dgvdirdep.Columns.Add("MZA_VIA", "Mza. Via")
        dgvdirdep.Columns.Add("LOTE_VIA", "Lt. Via")
        dgvdirdep.Columns.Add("KILOM_VIA", "Km. Via")
        dgvdirdep.Columns.Add("BLOCK_VIA", "Bloq. Via")
        dgvdirdep.Columns.Add("ETAPA_VIA", "Etapa Via")
        dgvdirdep.Columns.Add("TIP_ZONA_COD", "Zona Cod")
        dgvdirdep.Columns.Add("NOM_ZONA", "Zona Nom")
        dgvdirdep.Columns.Add("REF_ZONA", "Ref. Zona")
        dgvdirdep.Columns.Add("UBIGEO", "Ubigeo")
        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmbsit_cod.SelectedIndex = 1
                cmbcco_cod.SelectedIndex = 1
                cmbx_set.SelectedIndex = 3
                cmbt_trab.SelectedIndex = 3
                cmbnac.SelectedIndex = 1
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                bCuarto = "1"
                Dim dtAsiCPTO As DataTable = ASI_CPTOBL.SelectRow(txtcod.Text)
                'dgvt_doc.DataSource = dtAsiCPTO
                'dgvt_doc = PERSONALBL.getListdgv("03", sSDoc, sNDoc)
                For Each row As DataRow In dtAsiCPTO.Rows
                    dgvcpto.Rows.Add(IIf(IsDBNull(row("DNI")), "", row("DNI")),'0
                                      IIf(IsDBNull(row("NOMBRES_APELLIDOS")), "", row("NOMBRES_APELLIDOS")),
                                      IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")),
                                      IIf(IsDBNull(row("DESCRIPCION")), "", row("DESCRIPCION")),
                                      IIf(IsDBNull(row("MONTO")), 0, row("MONTO")))
                Next
                dtAsiCPTO = DERECHOHABBL.SelectRow(txtcod.Text)
                'dgvt_doc.DataSource = dtAsiCPTO
                'dgvt_doc = PERSONALBL.getListdgv("03", sSDoc, sNDoc)
                For Each row As DataRow In dtAsiCPTO.Rows
                    dgvdep.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")),'0
                                      IIf(IsDBNull(row("APE1")), "", row("APE1")),
                                      IIf(IsDBNull(row("Ape2")), "", row("Ape2")),
                                      IIf(IsDBNull(row("Nom1")), "", row("Nom1")),
                                      IIf(IsDBNull(row("Nom2")), "", row("Nom2")),
                                      Mid(IIf(IsDBNull(row("Fec_Nac")), "", row("Fec_Nac")), 1, 10),
                                      IIf(IsDBNull(row("X_TDOC")), "", row("X_TDOC")),
                                      IIf(IsDBNull(row("LE")), "", row("LE")),
                                      IIf(IsDBNull(row("vinculo_cod")), "", row("vinculo_cod")))
                Next
                dtAsiCPTO = DHAB_DIRBL.SelectRow(txtcod.Text)
                'dgvt_doc.DataSource = dtAsiCPTO
                'dgvt_doc = PERSONALBL.getListdgv("03", sSDoc, sNDoc)
                For Each row As DataRow In dtAsiCPTO.Rows
                    dgvdirdep.Rows.Add(IIf(IsDBNull(row("DIR_COD")), "", row("DIR_COD")),'0
                                      IIf(IsDBNull(row("TIP_VIA_COD")), "", row("TIP_VIA_COD")),
                                      IIf(IsDBNull(row("NOM_VIA")), "", row("NOM_VIA")),
                                      IIf(IsDBNull(row("NRO_VIA")), "", row("NRO_VIA")),
                                      IIf(IsDBNull(row("NRO_DPTO")), "", row("NRO_DPTO")),
                                      IIf(IsDBNull(row("INT_VIA")), "", row("INT_VIA")),
                                      IIf(IsDBNull(row("MZA_VIA")), "", row("MZA_VIA")),
                                      IIf(IsDBNull(row("LOTE_VIA")), "", row("LOTE_VIA")),
                                      IIf(IsDBNull(row("KILOM_VIA")), "", row("KILOM_VIA")),
                                      IIf(IsDBNull(row("BLOCK_VIA")), "", row("BLOCK_VIA")),
                                      IIf(IsDBNull(row("ETAPA_VIA")), "", row("ETAPA_VIA")),
                                      IIf(IsDBNull(row("TIP_ZONA_COD")), "", row("TIP_ZONA_COD")),
                                      IIf(IsDBNull(row("NOM_ZONA")), "", row("NOM_ZONA")),
                                      IIf(IsDBNull(row("REF_ZONA")), "", row("REF_ZONA")),
                                      IIf(IsDBNull(row("UBIGEO")), "", row("UBIGEO")))
                Next
                On Error Resume Next
                Dim sPath As String = gsIpserver & "sistema\E.ELUX\DNI\"
                'Dim sPath As String = Application.StartupPath & "\IMAGENES\"
                pbxArticulo.Image = Image.FromFile(sPath & txtcod.Text & ".jpg")
        End Select
        bPrimero = False
    End Sub
    Private Sub GetData(ByVal sCod As String)
        Dim dtPersonal As DataTable

        'MODIFICAR
        dtPersonal = PERBL.SelectRow(sCod)
        For Each Registro In dtPersonal.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtape1.Text = IIf(IsDBNull(Registro("APE1")), "", Registro("APE1"))
            txtape2.Text = IIf(IsDBNull(Registro("APE2")), "", Registro("APE2"))
            txtnom1.Text = IIf(IsDBNull(Registro("NOM1")), "", Registro("NOM1"))
            txtnom2.Text = IIf(IsDBNull(Registro("NOM2")), "", Registro("NOM2"))
            txtid_nro.Text = IIf(IsDBNull(Registro("ID_NRO")), "", Registro("ID_NRO"))
            txtle.Text = IIf(IsDBNull(Registro("LE")), "", Registro("LE"))
            txtlm.Text = IIf(IsDBNull(Registro("LM")), "", Registro("LM"))
            If IIf(IsDBNull(Registro("X_SEXO")), "", Registro("X_SEXO")) = "1" Then
                cmbx_sexo.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("X_SEXO")), "", Registro("X_SEXO")) = "2" Then
                cmbx_sexo.SelectedIndex = 2
            Else
                cmbx_sexo.SelectedIndex = -1
            End If
            If IIf(IsDBNull(Registro("NN")), "", Registro("NN")) = "21" Then
                cmbnn.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("NN")), "", Registro("NN")) = "20" Then
                cmbnn.SelectedIndex = 2
            Else
                cmbnn.SelectedIndex = -1
            End If
            If IIf(IsDBNull(Registro("x_estciv")), "", Registro("x_estciv")) = "C" Then
                cmbx_estciv.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("x_estciv")), "", Registro("x_estciv")) = "S" Then
                cmbx_estciv.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("x_estciv")), "", Registro("x_estciv")) = "B" Then
                cmbx_estciv.SelectedIndex = 3
            ElseIf IIf(IsDBNull(Registro("x_estciv")), "", Registro("x_estciv")) = "V" Then
                cmbx_estciv.SelectedIndex = 5
            ElseIf IIf(IsDBNull(Registro("x_estciv")), "", Registro("x_estciv")) = "D" Then
                cmbx_estciv.SelectedIndex = 4
            Else
                cmbx_estciv.SelectedIndex = -1
            End If
            If IIf(IsDBNull(Registro("NAC")), "", Registro("NAC")) = "PERUANO" Then
                cmbnac.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("NAC")), "", Registro("NAC")) = "EXTRANJERO" Then
                cmbnac.SelectedIndex = 2
            Else
                cmbnac.SelectedIndex = -1
            End If
            cmbañoq.SelectedText = IIf(IsDBNull(Registro("PER_ANHO")), "", Registro("PER_ANHO"))
            npdvalquinta.Value = IIf(IsDBNull(Registro("PER_ANHO")), 0, Registro("PER_ANHO"))
            npdnro_hijo.Value = IIf(IsDBNull(Registro("NRO_HIJO")), 0, Registro("NRO_HIJO"))
            txtcod_educativo.Text = IIf(IsDBNull(Registro("COD_EDUCATIVO")), "", Registro("COD_EDUCATIVO"))
            If IIf(IsDBNull(Registro("COD_EDUCATIVO")), "", Registro("COD_EDUCATIVO")) <> "" Then
                txtnom_educativo.Text = PERBL.SelectTipEducativo(IIf(IsDBNull(Registro("COD_EDUCATIVO")), "", Registro("COD_EDUCATIVO")))
            End If
            dtpfec_nac.Value = Registro("FEC_NAC")
            If Not IsDBNull(Registro("FEC_EMIDNI")) Then
                dtpfec_emidni.Value = Registro("FEC_EMIDNI")

            Else
                Lbl_alerta.Text = "Actualizar Fecha Emisión DNI"
            End If
            Me.txtubigeo_nac.Text = IIf(IsDBNull(Registro("UBIGEO_NAC")), "", Registro("UBIGEO_NAC"))
            Me.txtnom_ubi_dpto.Text = PERBL.SelectNomUbiDpto(IIf(IsDBNull(Registro("UBIGEO_NAC")), "", Registro("UBIGEO_NAC")))
            Me.txtnom_ubi_prov.Text = PERBL.SelectNomUbiProv(IIf(IsDBNull(Registro("UBIGEO_NAC")), "", Registro("UBIGEO_NAC")))
            Me.txtnom_ubi_nac.Text = PERBL.SelectNomUbiNac(IIf(IsDBNull(Registro("UBIGEO_NAC")), "", Registro("UBIGEO_NAC")))
            Me.txt_ccocod.Text = IIf(IsDBNull(Registro("CCO_COD_NUEVO")), "", Registro("CCO_COD_NUEVO"))
            Me.txt_nomcco.Text = IIf(IsDBNull(Registro("CENTRO_NUEVO")), "", Registro("CENTRO_NUEVO"))
            Me.txtdireccion.Text = IIf(IsDBNull(Registro("DIREC")), "", Registro("DIREC"))
            Me.txttelf.Text = IIf(IsDBNull(Registro("TELF")), "", Registro("TELF"))
            Me.txtubigeo.Text = IIf(IsDBNull(Registro("UBIGEO")), "", Registro("UBIGEO"))
            Me.txtnom_dirc_dpto.Text = PERBL.SelectNomUbiDpto(IIf(IsDBNull(Registro("UBIGEO")), "", Registro("UBIGEO")))
            Me.txtnom_ubi_direc.Text = PERBL.SelectNomUbiNac(IIf(IsDBNull(Registro("UBIGEO")), "", Registro("UBIGEO")))
            Me.txtemail.Text = IIf(IsDBNull(Registro("EMAIL")), "", Registro("EMAIL"))
            If IIf(IsDBNull(Registro("x_che")), "", Registro("x_che")) = "S" Then
                chkx_che.Checked = True
            Else
                chkx_che.Checked = False
            End If
            If IIf(IsDBNull(Registro("SIT_COD")), "", Registro("SIT_COD")) = "11" Then
                cmbsit_cod.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("SIT_COD")), "", Registro("SIT_COD")) = "13" Then
                cmbsit_cod.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("SIT_COD")), "", Registro("SIT_COD")) = "15" Then
                cmbsit_cod.SelectedIndex = 3
            ElseIf IIf(IsDBNull(Registro("SIT_COD")), "", Registro("SIT_COD")) = "19" Then
                cmbsit_cod.SelectedIndex = 4
            ElseIf IIf(IsDBNull(Registro("SIT_COD")), "", Registro("SIT_COD")) = "00" Then
                cmbsit_cod.SelectedIndex = 5
            Else
                cmbsit_cod.SelectedIndex = -1
            End If
            Me.txtcargo_cod.Text = IIf(IsDBNull(Registro("CARGO_COD")), "", Registro("CARGO_COD"))
            Me.txtnom_cargo.Text = PERBL.SelPerCargo(IIf(IsDBNull(Registro("CARGO_COD")), "", Registro("CARGO_COD")))

            cmbcco_cod.SelectedIndex = 1

            If IIf(IsDBNull(Registro("X_SET")), "", Registro("X_SET")) = "1" Then
                cmbx_set.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("X_SET")), "", Registro("X_SET")) = "2" Then
                cmbx_set.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("X_SET")), "", Registro("X_SET")) = "0" Then
                cmbx_set.SelectedIndex = 3
            Else
                cmbx_set.SelectedIndex = -1
            End If
            If IIf(IsDBNull(Registro("T_TRAB")), "", Registro("T_TRAB")) = "01" Then
                cmbt_trab.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("T_TRAB")), "", Registro("T_TRAB")) = "02" Then
                cmbt_trab.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("T_TRAB")), "", Registro("T_TRAB")) = "04" Then
                cmbt_trab.SelectedIndex = 3
            ElseIf IIf(IsDBNull(Registro("T_TRAB")), "", Registro("T_TRAB")) = "14" Then
                cmbt_trab.SelectedIndex = 4
            ElseIf IIf(IsDBNull(Registro("T_TRAB")), "", Registro("T_TRAB")) = "99" Then
                cmbt_trab.SelectedIndex = 5
            Else
                cmbt_trab.SelectedIndex = -1
            End If
            txtcargo_codigo.Text = IIf(IsDBNull(Registro("CARGO_CODIGO")), "", Registro("CARGO_CODIGO"))
            txtnom_cargo_codigo.Text = PERBL.SelPerCargoNew(IIf(IsDBNull(Registro("CARGO_CODIGO")), "", Registro("CARGO_CODIGO")))
            txtcargo.Text = IIf(IsDBNull(Registro("CARGO_ALTERNO")), "", Registro("CARGO_ALTERNO"))
            txtlinea_cod.Text = IIf(IsDBNull(Registro("LINEA_COD")), "", Registro("LINEA_COD"))
            txtnom_linea.Text = PERBL.SelLineaCod(IIf(IsDBNull(Registro("LINEA_COD")), "", Registro("LINEA_COD")))
            'txt_nomcco.Text = PERBL.SelCco_Cod(IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD")))
            txttalla.Text = IIf(IsDBNull(Registro("TALLA")), "", Registro("TALLA"))
            txttalla1.Text = IIf(IsDBNull(Registro("TALLA1")), "", Registro("TALLA1"))
            dtpfec_ing.Value = IIf(IsDBNull(Registro("FEC_ING")), Nothing, Registro("FEC_ING"))
            If IIf(IsDBNull(Registro("FEC_ICESE")), Nothing, Registro("FEC_ICESE")) <> Nothing Then
                dtpfec_icese.Checked = True
                dtpfec_icese.Value = Registro("FEC_ICESE")
            Else
                dtpfec_icese.Checked = False
            End If
            If IIf(IsDBNull(Registro("MOTI_BAJA_COD")), "", Registro("MOTI_BAJA_COD")) = "01" Then
                cmbmoti_baja_cod.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("MOTI_BAJA_COD")), "", Registro("MOTI_BAJA_COD")) = "03" Then
                cmbmoti_baja_cod.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("MOTI_BAJA_COD")), "", Registro("MOTI_BAJA_COD")) = "05" Then
                cmbmoti_baja_cod.SelectedIndex = 3
            ElseIf IIf(IsDBNull(Registro("MOTI_BAJA_COD")), "", Registro("MOTI_BAJA_COD")) = "06" Then
                cmbmoti_baja_cod.SelectedIndex = 4
            ElseIf IIf(IsDBNull(Registro("MOTI_BAJA_COD")), "", Registro("MOTI_BAJA_COD")) = "09" Then
                cmbmoti_baja_cod.SelectedIndex = 5
            ElseIf IIf(IsDBNull(Registro("MOTI_BAJA_COD")), "", Registro("MOTI_BAJA_COD")) = "07" Then
                cmbmoti_baja_cod.SelectedIndex = 6
            Else
                cmbmoti_baja_cod.SelectedIndex = -1
            End If
            txtcontrato_prdo.Text = IIf(IsDBNull(Registro("CONTRATO_PRDO")), "", Registro("CONTRATO_PRDO"))
            If IIf(IsDBNull(Registro("CONTRATO_PRDO")), Nothing, Registro("CONTRATO_PRDO")) <> Nothing Then
                dtpfec_ini.Checked = True
                dtpfec_fin.Checked = True
                dtpfec_ini.Value = PERBL.SelPrdoContratoIni(IIf(IsDBNull(Registro("CONTRATO_PRDO")), Nothing, Registro("CONTRATO_PRDO")))
                dtpfec_fin.Value = PERBL.SelPrdoContratoFin(IIf(IsDBNull(Registro("CONTRATO_PRDO")), Nothing, Registro("CONTRATO_PRDO")))
            End If
            If IIf(IsDBNull(Registro("AFP_COD")), "", Registro("AFP_COD")) = "001" Then
                cmbafp_cod.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("AFP_COD")), "", Registro("AFP_COD")) = "003" Then
                cmbafp_cod.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("AFP_COD")), "", Registro("AFP_COD")) = "004" Then
                cmbafp_cod.SelectedIndex = 3
            ElseIf IIf(IsDBNull(Registro("AFP_COD")), "", Registro("AFP_COD")) = "005" Then
                cmbafp_cod.SelectedIndex = 4
            ElseIf IIf(IsDBNull(Registro("AFP_COD")), "", Registro("AFP_COD")) = "006" Then
                cmbafp_cod.SelectedIndex = 5
            ElseIf IIf(IsDBNull(Registro("AFP_COD")), "", Registro("AFP_COD")) = "007" Then
                cmbafp_cod.SelectedIndex = 6
            Else
                cmbafp_cod.SelectedIndex = -1
            End If
            txtnro_afp.Text = IIf(IsDBNull(Registro("NRO_AFP")), "", Registro("NRO_AFP"))
            txtipss.Text = IIf(IsDBNull(Registro("IPSS")), "", Registro("IPSS"))
            txtgra_mes.Text = IIf(IsDBNull(Registro("GRA_MES")), "", Registro("GRA_MES"))
            If IIf(IsDBNull(Registro("X_COMISION")), "", Registro("X_COMISION")) = "1" Then
                chkx_comision.Checked = True
            Else
                chkx_comision.Checked = False
            End If
            If IIf(IsDBNull(Registro("CTA_DOLAR")), "", Registro("CTA_DOLAR")) = "2" Then
                cmbcta_dolar.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("CTA_DOLAR")), "", Registro("CTA_DOLAR")) = "1" Then
                cmbcta_dolar.SelectedIndex = 2
            Else
                cmbcta_dolar.SelectedIndex = -1
            End If
            If IIf(IsDBNull(Registro("X_VENDE")), "", Registro("X_VENDE")) = "" Then
                chkx_vende.Checked = False
            Else
                chkx_vende.Checked = True
            End If
            If IIf(IsDBNull(Registro("T_GRA")), "", Registro("T_GRA")) = "" Then
                chkt_gra.Checked = False
            Else
                chkt_gra.Checked = True
            End If
            txtnro_cta_banco.Text = IIf(IsDBNull(Registro("NRO_CTA_BANCO")), "", Registro("NRO_CTA_BANCO"))
            txtbco_cts_cod.Text = IIf(IsDBNull(Registro("BCO_CTS_COD")), "", Registro("BCO_CTS_COD"))
            txtd_bco_cts.Text = PERBL.SelCTABCOCTS(IIf(IsDBNull(Registro("BCO_CTS_COD")), Nothing, Registro("BCO_CTS_COD")))
            txtnro_cta_cts.Text = IIf(IsDBNull(Registro("NRO_CTA_CTS")), "", Registro("NRO_CTA_CTS"))
            txtobs.Text = IIf(IsDBNull(Registro("OBS")), "", Registro("OBS"))
            npdmes_tiempo_serv.Value = IIf(IsDBNull(Registro("MES_TIEMPO_SERV")), 0, Registro("MES_TIEMPO_SERV"))
            If IIf(IsDBNull(Registro("T_REM")), "", Registro("T_REM")) = "01" Then
                cmbt_rem.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("T_REM")), "", Registro("T_REM")) = "02" Then
                cmbt_rem.SelectedIndex = 2
            ElseIf IIf(IsDBNull(Registro("T_REM")), "", Registro("T_REM")) = "03" Then
                cmbt_rem.SelectedIndex = 3
            ElseIf IIf(IsDBNull(Registro("T_REM")), "", Registro("T_REM")) = "04" Then
                cmbt_rem.SelectedIndex = 4
            Else
                cmbt_rem.SelectedIndex = -1
            End If
            txttot_dia.Text = IIf(IsDBNull(Registro("TOT_DIA")), "", Registro("TOT_DIA"))
            txttot_hor.Text = IIf(IsDBNull(Registro("TOT_HOR")), "", Registro("TOT_HOR"))
            txttot_min.Text = IIf(IsDBNull(Registro("TOT_MIN")), "", Registro("TOT_MIN"))
            txttarde.Text = IIf(IsDBNull(Registro("TARDE")), "", Registro("TARDE"))
            Try
                dtpfec_afp.Value = IIf(IsDBNull(Registro("FEC_AFP")), Nothing, Registro("FEC_AFP"))
            Catch ex As Exception
                ' MsgBox("Por favor corrija fecha de registro de la afp")
            End Try

        Next
        Dim dt1 As DataTable
        dt1 = PERBL.SelectContratoprd(txtcod.Text)
        For Each Registro In dt1.Rows
            txt_cod_contrato.Text = IIf(IsDBNull(Registro("indice")), "", Registro("indice"))
            If txt_cod_contrato.Text <> "" Then
                dtp_ini_contrato.Checked = True
                dtp_fin_contrato.Checked = True
                dtp_ini_contrato.Value = IIf(IsDBNull(Registro("f_ini")), "", Registro("f_ini"))
                dtp_fin_contrato.Value = IIf(IsDBNull(Registro("f_fin")), "", Registro("f_fin"))
            End If
        Next
        If txt_cod_contrato.TextLength > 0 Then
            Label44.Visible = False
            txtcontrato_prdo.Visible = False
            dtpfec_ini.Visible = False
            dtpfec_fin.Visible = False
            Label40.Visible = False
            Label38.Visible = False
            Label39.Visible = False
        End If
    End Sub

    Private Sub btnnuevocpto_Click_1(sender As Object, e As EventArgs) Handles btnnuevocpto.Click
        Dim frm As New FormCptoPer
        gArt = ""
        frm.txtdni.Text = txtcod.Text
        frm.txtnom.Text = txtape1.Text & " " & txtape2.Text & " " & txtnom1.Text & " " & txtnom2.Text
        frm.ShowDialog()
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
                    If flagAccion = "N" Then
                        Exit Sub
                    End If
                    gsRptArgs = {}
                    ReDim gsRptArgs(0)
                    gsRptArgs(0) = txtcod.Text

                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_PER_SELECTROW.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmodificarcpto_Click(sender As Object, e As EventArgs) Handles btnmodificarcpto.Click
        'Dim dt As DataTable
        If dgvcpto.Rows.Count > 0 Then
            Dim frm As New FormCptoPer
            frm.txtdni.Text = dgvcpto.Rows(dgvcpto.CurrentRow.Index).Cells("DNI").Value
            frm.txtnom.Text = dgvcpto.Rows(dgvcpto.CurrentRow.Index).Cells("NOMBRES_APELLIDOS").Value
            frm.txtcpto_cod.Text = dgvcpto.Rows(dgvcpto.CurrentRow.Index).Cells("CODIGO").Value
            frm.txtnomcpto.Text = dgvcpto.Rows(dgvcpto.CurrentRow.Index).Cells("DESCRIPCION").Value
            frm.npdmonto.Value = dgvcpto.Rows(dgvcpto.CurrentRow.Index).Cells("MONTO").Value
            gArt = "0"
            frm.ShowDialog()
            gArt = ""
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnborrarcpto_Click(sender As Object, e As EventArgs) Handles btnborrarcpto.Click
        If dgvcpto.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvcpto.Rows.RemoveAt(dgvcpto.CurrentRow.Index)
            dgvcpto.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btnborrardep_Click(sender As Object, e As EventArgs) Handles btnborrardep.Click
        If dgvdep.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvdep.Rows.RemoveAt(dgvdep.CurrentRow.Index)
            dgvdep.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub
    Private Sub btnnuevodep_Click(sender As Object, e As EventArgs) Handles btnnuevodep.Click
        Dim valorMaximo As Integer = 0
        Dim valorMinimo As Integer = Integer.MaxValue
        Dim valor As String
        Dim frm As New FormDerechoHabiente
        For Each row As DataGridViewRow In dgvdep.Rows
            If Not row.IsNewRow Then
                If Convert.ToInt32(row.Cells("COD").Value) > valorMaximo Then
                    valorMaximo = Convert.ToInt32(row.Cells("COD").Value)
                End If
                If Convert.ToInt32(row.Cells("COD").Value) < valorMinimo Then
                    valorMinimo = Convert.ToInt32(row.Cells("COD").Value)
                End If
            End If
        Next
        If valorMaximo.ToString.Length = 1 Then
            valor = "0" & valorMaximo + 1
            frm.txtcod.Text = valor
        Else
            frm.txtcod.Text = valorMaximo + 1
        End If
        gArt = ""
        frm.ShowDialog()
    End Sub

    Private Sub btnmoddep_Click(sender As Object, e As EventArgs) Handles btnmoddep.Click
        ' Dim dt As DataTable
        If dgvdep.Rows.Count > 0 Then
            Dim frm As New FormDerechoHabiente
            frm.txtcod.Text = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("Cod").Value
            frm.txtnom1.Text = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("nom1").Value
            frm.txtnom2.Text = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("nom2").Value
            frm.txtape1.Text = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("ape1").Value
            frm.txtape2.Text = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("ape2").Value
            frm.dtpfec_nac.Value = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("fec_nac").Value
            If dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("X_TDOC").Value = "01" Then
                frm.cmbx_tdoc.SelectedIndex = 1
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("X_TDOC").Value = "11" Then
                frm.cmbx_tdoc.SelectedIndex = 2
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("X_TDOC").Value = "07" Then
                frm.cmbx_tdoc.SelectedIndex = 3
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("X_TDOC").Value = "04" Then
                frm.cmbx_tdoc.SelectedIndex = 4
            Else
                frm.cmbx_tdoc.SelectedIndex = -1
            End If
            If dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = "02" Then
                frm.cmbvinculo_cod.SelectedIndex = 1
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = "03" Then
                frm.cmbvinculo_cod.SelectedIndex = 2
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = "04" Then
                frm.cmbvinculo_cod.SelectedIndex = 3
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = "05" Then
                frm.cmbvinculo_cod.SelectedIndex = 4
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = "06" Then
                frm.cmbvinculo_cod.SelectedIndex = 5
            ElseIf dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = "07" Then
                frm.cmbvinculo_cod.SelectedIndex = 5
            Else
                frm.cmbvinculo_cod.SelectedIndex = -1
            End If
            frm.txtle.Text = dgvdep.Rows(dgvdep.CurrentRow.Index).Cells("LE").Value
            gArt = "0"
            frm.ShowDialog()
            gArt = ""
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub FormMantPersonal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btndirhabdepborrar_Click(sender As Object, e As EventArgs) Handles btndirhabdepborrar.Click
        If dgvdirdep.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvdirdep.Rows.RemoveAt(dgvdirdep.CurrentRow.Index)
            dgvdirdep.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btndirhabdepnuevo_Click(sender As Object, e As EventArgs) Handles btndirhabdepnuevo.Click
        Dim valorMaximo As Integer = 0
        Dim valorMinimo As Integer = Integer.MaxValue
        Dim valor As String
        Dim frm As New FormDirDep
        For Each row As DataGridViewRow In dgvdep.Rows
            If Not row.IsNewRow Then
                If Convert.ToInt32(row.Cells("DIR_COD").Value) > valorMaximo Then
                    valorMaximo = Convert.ToInt32(row.Cells("DIR_COD").Value)
                End If
                If Convert.ToInt32(row.Cells("DIR_COD").Value) < valorMinimo Then
                    valorMinimo = Convert.ToInt32(row.Cells("DIR_COD").Value)
                End If
            End If
        Next
        If valorMaximo.ToString.Length = 1 Then
            valor = "0" & valorMaximo + 1
            frm.txtcod.Text = valor
        Else
            frm.txtcod.Text = valorMaximo + 1
        End If
        gArt = ""
        frm.ShowDialog()
    End Sub

    Private Sub btndirhabdepmodificar_Click(sender As Object, e As EventArgs) Handles btndirhabdepmodificar.Click
        'Dim dt As DataTable
        If dgvdirdep.Rows.Count > 0 Then
            Dim frm As New FormDirDep
            frm.txtcod.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("dir_Cod").Value
            frm.txttip_via_cod.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("TIP_ZONA_COD").Value
            frm.txtnom_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("nom_via").Value
            frm.txtnro_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("nro_via").Value
            frm.txtnro_dpto.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("nro_dpto").Value
            frm.txtint_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("int_via").Value
            frm.txtmza_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("mza_via").Value
            frm.txtlote_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("LOTE_VIA").Value
            frm.txtkilom_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("KILOM_VIA").Value
            frm.txtblock_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("BLOCK_VIA").Value
            frm.txtetapa_via.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("ETAPA_VIA").Value
            frm.txttip_zona_cod.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("TIP_ZONA_COD").Value
            frm.txtnom_zona.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("NOM_ZONA").Value
            frm.txtref_zona.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("REF_ZONA").Value
            frm.txtubigeo.Text = dgvdirdep.Rows(dgvdirdep.CurrentRow.Index).Cells("UBIGEO").Value
            gArt = "0"
            frm.ShowDialog()
            gArt = ""
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub txtubigeo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubigeo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "68"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtubigeo.Text = gLinea
                txtnom_ubi_direc.Text = gSubLinea
                txtnom_dirc_dpto.Text = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub
    Private Sub txtubigeo_LostFocus(sender As Object, e As EventArgs) Handles txtubigeo.LostFocus
        If txtubigeo.Text <> "" Then
            txtnom_ubi_direc.Text = ELTBCLIENTEBL.SelectUbiDpto(txtubigeo.Text)
            txtnom_dirc_dpto.Text = ELTBCLIENTEBL.SelectUbiNom(txtubigeo.Text)
        Else
            txtnom_ubi_direc.Text = ""
            txtnom_dirc_dpto.Text = ""
        End If
    End Sub

    Private Sub txtubigeo_nac_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubigeo_nac.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "66"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing And gsCode3 <> Nothing Then
                txtubigeo_nac.Text = gLinea
                txtnom_ubi_nac.Text = gSubLinea
                txtnom_ubi_dpto.Text = gArt
                txtnom_ubi_prov.Text = gsCode3
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
                gsCode3 = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
                gsCode3 = Nothing
            End If
        End If
    End Sub
    Private Sub txtubigeo_nac_LostFocus(sender As Object, e As EventArgs) Handles txtubigeo_nac.LostFocus
        If txtubigeo_nac.Text <> "" Then
            txtnom_ubi_dpto.Text = ELTBCLIENTEBL.SelectUbigeonacdpt(txtubigeo_nac.Text)
            txtnom_ubi_prov.Text = ELTBCLIENTEBL.SelectUbigeonacprov(txtubigeo_nac.Text)
            txtnom_ubi_nac.Text = ELTBCLIENTEBL.SelectUbigeonacNom(txtubigeo_nac.Text)
        Else
            txtnom_ubi_dpto.Text = ""
            txtnom_ubi_prov.Text = ""
            txtnom_ubi_nac.Text = ""
        End If
    End Sub
    Private Sub txtcod_educativo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod_educativo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "67"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcod_educativo.Text = gLinea
                txtnom_educativo.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtcod_educativo_LostFocus(sender As Object, e As EventArgs) Handles txtcod_educativo.LostFocus
        If txtcod_educativo.Text <> "" Then
            txtnom_educativo.Text = PERBL.SelectCodEduNom(txtcod_educativo.Text)
        Else
            txtnom_educativo.Text = ""
        End If
    End Sub
    Private Sub txtcargo_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcargo_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "69"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcargo_cod.Text = gLinea
                txtnom_cargo.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtcargo_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcargo_cod.LostFocus
        If txtcargo_cod.Text <> "" Then
            txtnom_cargo.Text = PERBL.SelectCargoOcu(txtcargo_cod.Text)
        Else
            txtnom_cargo.Text = ""
        End If
    End Sub
    Private Sub txtcargo_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcargo_codigo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "70"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcargo_codigo.Text = gLinea
                txtnom_cargo_codigo.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtcargo_codigo_LostFocus(sender As Object, e As EventArgs) Handles txtcargo_codigo.LostFocus
        If txtcargo_codigo.Text <> "" Then
            txtnom_cargo_codigo.Text = PERBL.SelectCargoNom(txtcargo_codigo.Text)
        Else
            txtnom_cargo_codigo.Text = ""
        End If
    End Sub
    Private Sub txtlinea_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea_cod.KeyDown

        If txt_ccocod.Text = "" Then
            MsgBox("Selecciones Centro de Costo")
            txt_ccocod.Select()
            Exit Sub
        Else
            ccoCod = txt_ccocod.Text
        End If
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "71"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtlinea_cod.Text = gLinea
                txtnom_linea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtlinea_cod_LostFocus(sender As Object, e As EventArgs) Handles txtlinea_cod.LostFocus
        If txtlinea_cod.Text <> "" Then
            txtnom_linea.Text = PERBL.SelectLineaNom(txtlinea_cod.Text)
        Else
            txtnom_linea.Text = ""
        End If
    End Sub
    Private Sub txtcontrato_prdo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "72"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo.Text = gLinea
                dtpfec_ini.Value = gSubLinea
                dtpfec_fin.Value = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub
    Private Sub txtcontrato_prdo_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo.LostFocus
        If txtcontrato_prdo.Text <> "" Then
            If PERBL.SelectContratoIni(txtcontrato_prdo.Text).Length <> 0 Then
                dtpfec_ini.Checked = True
                dtpfec_ini.Value = PERBL.SelectContratoIni(txtcontrato_prdo.Text)
                dtpfec_fin.Checked = True
                dtpfec_fin.Value = PERBL.SelectContratoFin(txtcontrato_prdo.Text)

            End If
        Else
            dtpfec_ini.Checked = False
            dtpfec_fin.Checked = False
            txtnom_linea.Text = ""
        End If
    End Sub
    Private Sub txtbco_cts_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbco_cts_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "73"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtbco_cts_cod.Text = gLinea
                txtd_bco_cts.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtbco_cts_cod_LostFocus(sender As Object, e As EventArgs) Handles txtbco_cts_cod.LostFocus
        If txtbco_cts_cod.Text <> "" Then
            txtd_bco_cts.Text = PERBL.SelectBcoCTSNom(txtbco_cts_cod.Text)
        Else
            txtd_bco_cts.Text = ""
        End If
    End Sub

    Private Sub cmbsit_cod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsit_cod.SelectedIndexChanged

    End Sub

    Private Sub txtcod_LostFocus(sender As Object, e As EventArgs) Handles txtcod.LostFocus
        If txtcod.TextLength > 0 Then
            txtid_nro.Text = txtcod.Text
            txtle.Text = txtcod.Text
        Else
            txtid_nro.Text = ""
            txtle.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Boleta.Click
        ReDim gsRptArgs(3)
        gsRptArgs(0) = Txt_Periodo.Text
        If cmbnn.SelectedIndex = 1 Then
            gsRptArgs(1) = "21"
        ElseIf cmbnn.SelectedIndex = 2 Then
            gsRptArgs(1) = "20"
        Else
            gsRptArgs(1) = ""
        End If
        'gsRptArgs(1) = "20"
        gsRptArgs(2) = txtcod.Text
        gsRptArgs(3) = "MEN"

        PERBL.ActualizarSPBoleta(Txt_Periodo.Text)

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_PAGOX.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()

    End Sub

    Private Sub txt_ccocod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ccocod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "CCOCOD_PER"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_ccocod.Text = gLinea
                txt_nomcco.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
End Class