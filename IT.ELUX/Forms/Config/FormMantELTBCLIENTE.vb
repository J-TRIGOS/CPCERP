Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormMantELTBCLIENTE
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBCLIENTEBL As New ELTBCLIENTEBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Public flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private MenuBL As New MenuBL

    Private Sub FormMantELTBCLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        'Cargar los combos
        Dim dt As DataTable
        dt = ELTBCLIENTEBL.SelectVendedor()
        GetCmb("cod", "nom", dt, cmbvendedor)
        dt = ELTBCLIENTEBL.SelectCondiPago()
        GetCmb("cod", "nom", dt, cmbCondPago)
        'AGREGAR COLUMNAS A DIRECCION
        dgvt_dir.Columns.Add("DIR_COD", "Seq") '0
        dgvt_dir.Columns.Add("NOM", "Dirección") '1
        dgvt_dir.Columns.Add("DPTO", "Departamento") '2
        dgvt_dir.Columns.Add("DISTRITO", "Distrito") '3
        dgvt_dir.Columns.Add("PROV", "Provincia") '4
        dgvt_dir.Columns.Add("UBIGEO", "Ubigeo") '5
        'dgvt_dir.Columns.Add("X_CONT", "Contabilidad") '6

        'AGREGAR COLUMNAS A CORREO
        dgvt_cor.Columns.Add("COR_COD", "Seq") '0
        dgvt_cor.Columns.Add("NOM", "Correo ") '1
        dgvt_cor.Columns.Add("CONTACTO", "Contacto") '2
        dgvt_cor.Columns.Add("CARGO", "Cargo") '3
        dgvt_cor.Columns.Add("TELEFONO", "Telefono") '4
        'dgvt_cor.Columns.Add("X_CONT", "Contabilidad") '5        

        'AGREGAR COLUMNAS A COBRANZAS
        dgvt_tel.Columns.Add("TEL_COD", "Seq") '0
        dgvt_tel.Columns.Add("NOM", "Numero de Telefono") '1
        dgvt_tel.Columns.Add("CONTACTO", "Contacto") '2
        dgvt_tel.Columns.Add("X_CONT", "Contabilidad") '3
        dgvt_tel.Columns.Add("OBSERVACION", "Observacion") '4
        dgvt_tel.Columns.Add("L_Credito", "L. Credito S/.") '5
        dgvt_tel.Columns.Add("L_DCredito", "L. Credito $") '5

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"

            Case 1
                If sOp = "1" Then
                    flagAccion = "M"
                    GetData(gsCode)
                    'General.Enabled = False
                    txtruc.Enabled = False
                    cmbnego_cop.Enabled = False
                    txtnom.Enabled = False
                    txtdir.Enabled = False
                    txtpais.Enabled = False
                    btn_ubigeo.Enabled = False
                    txttelef.Enabled = False
                    txtvend_resp.Enabled = False
                    txtDNI.Enabled = False
                    txt_codfpago.Enabled = False
                    chkextranjero.Enabled = False
                    chkprotocolo.Enabled = False
                    chkproveedor.Enabled = False
                    cmbvendedor.Enabled = False
                    cmbCondPago.Enabled = False
                    txtruc.Enabled = False
                    TabPage2.Enabled = False
                    'TabPage3.Enabled = False
                    Me.btnimprimir.Visible = False
                Else
                    flagAccion = "M"
                    GetData(gsCode)
                End If

        End Select
        bPrimero = False

    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub txtruc_Leave(sender As Object, e As EventArgs) Handles txtruc.Leave
        'If txtruc.Text <> "" Then
        '    Dim dt As DataTable
        '    Dim Registro As DataRow
        '    dt = ELTBCLIENTEBL.SelectRow(txtruc.Text)
        '    If dt.Rows.Count = 0 Then
        '        flagAccion = "N"
        '        'LIMPIAR TEXTOS Y CMB
        If flagAccion = "N" Then
            lblcodigo.Text = txtruc.Text
        End If
        'txtnom.Text = ""
        'txtdir.Text = ""
        'lblubigeo.Text = ""
        'lblciudad.Text = ""
        'lbldistrito.Text = ""
        'lblprovincia.Text = ""
        'txttelef.Text = ""
        'txtpais.Text = ""
        'txtDNI.Text = ""
        'txtvend_resp.Text = ""
        'cmbnego_cop.SelectedIndex = -1
        'cmbciiucod.SelectedIndex = -1
        'cmbvendedor.SelectedIndex = -1
        'cmbCondPago.SelectedIndex = -1
        'LiberarGrids()
        '    Else
        '        flagAccion = "M"
        '        LiberarGrids()
        '        'LLENAR DATOS DEL RUC
        '        For Each Registro In dt.Rows
        '            lblcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
        '            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
        '            txtdir.Text = IIf(IsDBNull(Registro("DIR")), "", Registro("DIR"))
        '            lblubigeo.Text = IIf(IsDBNull(Registro("UBIGEO")), "", Registro("UBIGEO"))
        '            lbldistrito.Text = IIf(IsDBNull(Registro("DIST")), "", Registro("DIST"))
        '            lblprovincia.Text = IIf(IsDBNull(Registro("CIUDAD")), "", Registro("CIUDAD"))
        '            lblciudad.Text = IIf(IsDBNull(Registro("CIUDAD")), "", Registro("CIUDAD"))
        '            txttelef.Text = IIf(IsDBNull(Registro("TELEF")), "", Registro("TELEF"))
        '            lblpais.Text = IIf(IsDBNull(Registro("PAIS")), "", Registro("PAIS"))
        '            txtpais.Text = IIf(IsDBNull(Registro("PAIS_COD")), "", Registro("PAIS_COD"))
        '            txtDNI.Text = IIf(IsDBNull(Registro("DNI")), "", Registro("DNI"))
        '            txtvend_resp.Text = IIf(IsDBNull(Registro("VEND_RESP")), "", Registro("VEND_RESP"))
        '            cmbciiucod.SelectedValue = IIf(IsDBNull(Registro("CIIU_COD")), "0", Registro("CIIU_COD"))
        '            cmbvendedor.SelectedValue = IIf(IsDBNull(Registro("VEND_RESP")), "0", Registro("VEND_RESP"))
        '            txt_codfpago.Text = IIf(IsDBNull(Registro("COD_FPAGO")), "", Registro("COD_FPAGO"))
        '            cmbCondPago.SelectedValue = IIf(IsDBNull(Registro("COD_FPAGO")), "0", Registro("COD_FPAGO"))
        '            Select Case IIf(IsDBNull(Registro("NEGO_COD")), "", Registro("NEGO_COD"))
        '                Case ""
        '                    cmbnego_cop.SelectedText = -1
        '                Case "E"
        '                    cmbnego_cop.SelectedIndex = 0
        '                Case "B"
        '                    cmbnego_cop.SelectedIndex = 1
        '                Case "R"
        '                    cmbnego_cop.SelectedIndex = 2
        '            End Select

        '            If IIf(IsDBNull(Registro("X_EXT")), "0", Registro("X_EXT")) = 0 Then
        '                chkextranjero.Checked = False
        '            Else
        '                chkextranjero.Checked = True
        '            End If
        '            If IIf(IsDBNull(Registro("EFIC_COD")), "0", Registro("EFIC_COD")) = 0 Then
        '                chkprotocolo.Checked = False
        '            Else
        '                chkprotocolo.Checked = True
        '            End If
        '            If IIf(IsDBNull(Registro("X_PROV")), "0", Registro("X_PROV")) = 0 Then
        '                chkproveedor.Checked = False
        '            Else
        '                chkproveedor.Checked = True
        '            End If

        '        Next
        '        'LLENAR GRID DIRECCIONES
        '        Dim dtGrid As DataTable
        '        dtGrid = ELTBCLIENTEBL.SelectRowGrid(txtruc.Text, "DIR")
        '        For Each row As DataRow In dtGrid.Rows
        '            dgvt_dir.Rows.Add(IIf(IsDBNull(row("DIR_COD")), "", row("DIR_COD")),'0
        '                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
        '                              IIf(IsDBNull(row("DPTO")), "", row("DPTO")),'2
        '                              IIf(IsDBNull(row("DISTRITO")), "", row("DISTRITO")),'3
        '                              IIf(IsDBNull(row("PROV")), "", row("PROV")),'4
        '                              IIf(IsDBNull(row("UBIGEO")), "", row("UBIGEO")),'5
        '                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT"))) '6
        '        Next
        '        'LLENAR GRID CORREO'
        '        dtGrid = ELTBCLIENTEBL.SelectRowGrid(txtruc.Text, "COR")
        '        For Each row As DataRow In dtGrid.Rows
        '            dgvt_cor.Rows.Add(IIf(IsDBNull(row("COR_COD")), "", row("COR_COD")),'0
        '                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
        '                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO")),'2
        '                              IIf(IsDBNull(row("CARGO")), "", row("CARGO")),'3
        '                              IIf(IsDBNull(row("TELEFONO")), "", row("TELEFONO")),'4
        '                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT"))) '5                  
        '        Next
        '        'LLENAR GRID TELEFONO'
        '        dtGrid = ELTBCLIENTEBL.SelectRowGrid(txtruc.Text, "TEL")
        '        For Each row As DataRow In dtGrid.Rows
        '            dgvt_tel.Rows.Add(IIf(IsDBNull(row("TEL_COD")), "", row("TEL_COD")),'0
        '                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
        '                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO")),
        '                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT"))) '2
        '        Next
        '    End If
        'Else
        '    flagAccion = "N"
        '    'LIMPIAR TEXTOS Y CMBS
        '    lblcodigo.Text = ""
        '    txtnom.Text = ""
        '    txtdir.Text = ""
        '    lblubigeo.Text = ""
        '    lblciudad.Text = ""
        '    lbldistrito.Text = ""
        '    lblprovincia.Text = ""
        '    txttelef.Text = ""
        '    txtpais.Text = ""
        '    txtDNI.Text = ""
        '    txtvend_resp.Text = ""
        '    cmbnego_cop.SelectedIndex = -1
        '    cmbciiucod.SelectedIndex = -1
        '    cmbvendedor.SelectedIndex = -1
        '    cmbCondPago.SelectedIndex = -1
        '    LiberarGrids()
        'End If

    End Sub

    Private Sub GetData(ByVal sCode As String)
        Dim dt As DataTable
        Dim Registro As DataRow
        dt = ELTBCLIENTEBL.SelectRow(sCode)
        'LLENAR DATOS DEL RUC
        For Each Registro In dt.Rows
            txtruc.Text = IIf(IsDBNull(Registro("RUC")), "", Registro("RUC"))
            lblcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtdir.Text = IIf(IsDBNull(Registro("DIR")), "", Registro("DIR"))
            lblubigeo.Text = IIf(IsDBNull(Registro("UBIGEO")), "", Registro("UBIGEO"))
            lbldistrito.Text = IIf(IsDBNull(Registro("DIST")), "", Registro("DIST"))
            lblprovincia.Text = IIf(IsDBNull(Registro("CIUDAD")), "", Registro("CIUDAD"))
            lblciudad.Text = IIf(IsDBNull(Registro("CIUDAD")), "", Registro("CIUDAD"))
            txttelef.Text = IIf(IsDBNull(Registro("TELEF")), "", Registro("TELEF"))
            lblpais.Text = IIf(IsDBNull(Registro("PAIS")), "", Registro("PAIS"))
            txtpais.Text = IIf(IsDBNull(Registro("PAIS_COD")), "", Registro("PAIS_COD"))
            txtDNI.Text = IIf(IsDBNull(Registro("DNI")), "", Registro("DNI"))
            txtvend_resp.Text = IIf(IsDBNull(Registro("VEND_RESP")), "", Registro("VEND_RESP"))
            txtser_cod.Text = IIf(IsDBNull(Registro("CIIU_COD")), "", Registro("CIIU_COD"))
            lblser_cod.Text = IIf(IsDBNull(Registro("CIU_NOM")), "", Registro("CIU_NOM"))
            cmbvendedor.SelectedValue = IIf(IsDBNull(Registro("VEND_RESP")), "0", Registro("VEND_RESP"))
            txt_codfpago.Text = IIf(IsDBNull(Registro("COD_FPAGO")), "", Registro("COD_FPAGO"))
            cmbCondPago.SelectedValue = IIf(IsDBNull(Registro("COD_FPAGO")), "0", Registro("COD_FPAGO"))
            txt_obspago.Text = IIf(IsDBNull(Registro("OBS")), "", Registro("OBS"))
            npddigverf.Value = IIf(IsDBNull(Registro("DIGITO_VERF")), 0, Registro("DIGITO_VERF"))
            If IIf(IsDBNull(Registro("DIA1")), "", Registro("DIA1")) = "" Then
                chkcierre.Checked = False
            Else
                chkcierre.Checked = True
            End If

            Select Case IIf(IsDBNull(Registro("NEGO_COD")), "", Registro("NEGO_COD"))
                Case ""
                    cmbnego_cop.SelectedText = -1
                Case "E"
                    cmbnego_cop.SelectedIndex = 0
                Case "B"
                    cmbnego_cop.SelectedIndex = 1
                Case "R"
                    cmbnego_cop.SelectedIndex = 2
            End Select

            If IIf(IsDBNull(Registro("X_EXT")), "0", Registro("X_EXT")) = 0 Then
                chkextranjero.Checked = False
            Else
                chkextranjero.Checked = True
            End If
            If IIf(IsDBNull(Registro("EFIC_COD")), "0", Registro("EFIC_COD")) = 0 Then
                chkprotocolo.Checked = False
            Else
                chkprotocolo.Checked = True
            End If
            If IIf(IsDBNull(Registro("X_PROV")), "0", Registro("X_PROV")) = 0 Then
                chkproveedor.Checked = False
            Else
                chkproveedor.Checked = True
            End If
            If IIf(IsDBNull(Registro("X_RET")), "0", Registro("X_RET")) = 0 Then
                chkretenedor.Checked = False
            Else
                chkretenedor.Checked = True
            End If
            If IIf(IsDBNull(Registro("X_PER")), "0", Registro("X_PER")) = 0 Then
                chkpercepcion.Checked = False
            Else
                chkpercepcion.Checked = True
            End If
        Next
        'LLENAR GRID DIRECCIONES
        Dim dtGrid As DataTable
        dtGrid = ELTBCLIENTEBL.SelectRowGrid(sCode, "DIR")
        For Each row As DataRow In dtGrid.Rows
            dgvt_dir.Rows.Add(IIf(IsDBNull(row("DIR_COD")), "", row("DIR_COD")),'0
                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
                              IIf(IsDBNull(row("DPTO")), "", row("DPTO")),'2
                              IIf(IsDBNull(row("DISTRITO")), "", row("DISTRITO")),'3
                              IIf(IsDBNull(row("PROV")), "", row("PROV")),'4
                              IIf(IsDBNull(row("UBIGEO")), "", row("UBIGEO"))) ','5
            'IIf(IsDBNull(row("X_CONT")), "", row("X_CONT")))  '6
        Next
        'LLENAR GRID CORREO'
        dtGrid = ELTBCLIENTEBL.SelectRowGrid(sCode, "COR")
        For Each row As DataRow In dtGrid.Rows
            dgvt_cor.Rows.Add(IIf(IsDBNull(row("COR_COD")), "", row("COR_COD")),'0
                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO")),'2
                              IIf(IsDBNull(row("CARGO")), "", row("CARGO")),'3
                              IIf(IsDBNull(row("TELEFONO")), "", row("TELEFONO"))) ','4
            'IIf(IsDBNull(row("X_CONT")), "", row("X_CONT"))  '5                  
        Next
        'LLENAR GRID TELEFONO'
        dtGrid = ELTBCLIENTEBL.SelectRowGrid(sCode, "TEL")
        For Each row As DataRow In dtGrid.Rows
            dgvt_tel.Rows.Add(IIf(IsDBNull(row("TEL_COD")), "", row("TEL_COD").ToString.Trim),'0
                              IIf(IsDBNull(row("NOM")), "", row("NOM").ToString.Trim),'1
                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO").ToString.Trim), '2
                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT").ToString.Trim), '3
                              IIf(IsDBNull(row("OBSERVACION")), "", row("OBSERVACION").ToString.Trim), '4
                              IIf(IsDBNull(row("L_CREDITO")), "", row("L_CREDITO").ToString.Trim),  '5
                              IIf(IsDBNull(row("L_DCREDITO")), "", row("L_DCREDITO").ToString.Trim))  '6
        Next
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If dgvt_tel.Rows.Count = 0 Then
                MsgBox("Si no Pone por lo menos un Numero de Telefono en la pestaña de Cobranza no se podran realizar Facturas", MsgBoxStyle.Critical, "Precaucion")
            End If

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBCLIENTEBE As New ELTBCLIENTEBE
                ELTBCLIENTEBE.cod = lblcodigo.Text
                ELTBCLIENTEBE.ruc = txtruc.Text
                ELTBCLIENTEBE.nom = txtnom.Text
                ELTBCLIENTEBE.dni = txtDNI.Text
                ELTBCLIENTEBE.dir = txtdir.Text
                ELTBCLIENTEBE.dist = lbldistrito.Text
                ELTBCLIENTEBE.ciudad = lblciudad.Text
                ELTBCLIENTEBE.telef = txttelef.Text
                ELTBCLIENTEBE.vend_resp = txtvend_resp.Text
                ELTBCLIENTEBE.pais = lblpais.Text
                ELTBCLIENTEBE.ubigeo = lblubigeo.Text
                ELTBCLIENTEBE.x_cli = "1"
                ELTBCLIENTEBE.obs = txt_obspago.Text

                If chkextranjero.Checked = True Then
                    ELTBCLIENTEBE.x_ext = "1"
                Else
                    ELTBCLIENTEBE.x_ext = "0"
                End If
                If chkproveedor.Checked = True Then
                    ELTBCLIENTEBE.x_prov = "1"
                Else
                    ELTBCLIENTEBE.x_prov = "0"
                End If
                If chkprotocolo.Checked = True Then
                    ELTBCLIENTEBE.efic_cod = "1"
                Else
                    ELTBCLIENTEBE.efic_cod = "0"
                End If

                If cmbnego_cop.SelectedIndex = 0 Then
                    ELTBCLIENTEBE.nego_cod = "E"
                ElseIf cmbnego_cop.SelectedIndex = 1 Then
                    ELTBCLIENTEBE.nego_cod = "B"
                Else
                    ELTBCLIENTEBE.nego_cod = "R"
                End If
                If chkretenedor.Checked = True Then
                    ELTBCLIENTEBE.x_ret = "1"
                Else
                    ELTBCLIENTEBE.x_ret = "0"
                End If
                If chkpercepcion.Checked = True Then
                    ELTBCLIENTEBE.x_per = "1"
                Else
                    ELTBCLIENTEBE.x_per = "0"
                End If
                ELTBCLIENTEBE.ciiu_cod = txtser_cod.Text
                ELTBCLIENTEBE.Fec_cred = DateTime.Now.ToString("dd/MM/yyyy")
                ELTBCLIENTEBE.Dia4 = gsCodUsr
                ELTBCLIENTEBE.cod_fpago = txt_codfpago.Text
                ELTBCLIENTEBE.pais_cod = txtpais.Text
                ELTBCLIENTEBE.digverif = npddigverf.Value
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELTBCLIENTEBL.SaveRow(ELTBCLIENTEBE, flagAccion, dgvt_dir, dgvt_cor, dgvt_tel, ELMVLOGSBE)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

            End If
        End If
    End Sub
    Sub LiberarGrids()
        dgvt_dir.Rows.Clear()
        dgvt_cor.Rows.Clear()
        dgvt_tel.Rows.Clear()
        dgvt_tel.DataSource = Nothing
        dgvt_cor.DataSource = Nothing
        dgvt_dir.DataSource = Nothing
        chkextranjero.Checked = False
        chkprotocolo.Checked = False
        chkproveedor.Checked = False
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
            Case "bcliente"
                If ELTBCLIENTEBL.VerificarCliente(lblcodigo.Text) = "0" Then
                    If MessageBox.Show("Desea Bloquear al Cliente",
                      gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If
                    ELTBCLIENTEBL.VerificarCliente(lblcodigo.Text)
                    Dim ELTBCLIENTEBE As New ELTBCLIENTEBE
                    ELTBCLIENTEBE.cod = lblcodigo.Text
                    ELTBCLIENTEBE.Dia1 = "1"
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELTBCLIENTEBL.SaveRow(ELTBCLIENTEBE, "UC", dgvt_dir, dgvt_cor, dgvt_tel, ELMVLOGSBE)
                    If gsError = "OK" Then
                        MsgBox("Se ah bloqueado Correctamente al Cliente", MsgBoxStyle.Information)
                    End If
                Else
                    If MessageBox.Show("Desea Desbloquear al Cliente",
                      gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If
                    ELTBCLIENTEBL.VerificarCliente(lblcodigo.Text)
                    Dim ELTBCLIENTEBE As New ELTBCLIENTEBE
                    ELTBCLIENTEBE.cod = lblcodigo.Text
                    ELTBCLIENTEBE.Dia1 = ""
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELTBCLIENTEBL.SaveRow(ELTBCLIENTEBE, "UC", dgvt_dir, dgvt_cor, dgvt_tel, ELMVLOGSBE)

                    If gsError = "OK" Then
                        MsgBox("Se ah bloqueado Correctamente al Cliente", MsgBoxStyle.Information)
                    End If
                End If
        End Select
    End Sub
    Private Function OkData() As Boolean
        If chkextranjero.Checked = True Then
            If txtpais.Text = "" Then
                MsgBox("Ingrese Pais del Cliente", MsgBoxStyle.Exclamation)
                txtpais.Focus()
                Return False
            End If
        Else
            'If txtruc.Text.Length <> 11 And txtruc.Text.Length <> 8 Then
            '    MsgBox("El Ruc Debe contener 11 u 8 digitos", MsgBoxStyle.Exclamation)
            '    txtruc.Focus()
            '    Return False
            'End If
            If txtser_cod.Text = "" Then
                MsgBox("Seleccione la Actividad/ Servicio", MsgBoxStyle.Exclamation)
                txtser_cod.Focus()
                Return False
            End If
            If lblubigeo.Text = "" Then
                MsgBox("Ingrese Ubigeo del Cliente", MsgBoxStyle.Exclamation)
                btn_ubigeo.Focus()
                Return False
            End If
        End If
        If flagAccion = "N" Then
            If ELTBCLIENTEBL.VerificarRepetido(txtruc.Text) = True Then
                MsgBox("El Ruc ya Existe", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        If txtvend_resp.Text = "" Then
            MsgBox("Ingrese el Nombre del Vendendor", MsgBoxStyle.Exclamation)
            txtvend_resp.Focus()
            Return False
        End If

        If txtnom.Text = "" Then
            MsgBox("Ingrese los Nombres del Cliente", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If

        If dgvt_dir.Rows.Count < 1 Then
            MsgBox("Ingrese al menos 1 Direccion en la pestaña de Direcciones", MsgBoxStyle.Exclamation)
            TabCorreo.SelectTab(1)
            Return False
        End If
        If dgvt_cor.Rows.Count < 1 Then
            MsgBox("Ingrese al menos 1 Correo en la pestaña de Correos", MsgBoxStyle.Exclamation)
            TabCorreo.SelectTab(2)
            Return False
        End If
        If txtpais.Text = "PA" And npddigverf.Value = 0 Then
            MsgBox("Ingrese el digito verificador del Proveedor", MsgBoxStyle.Exclamation)
            npddigverf.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btn_ubigeo_Click(sender As Object, e As EventArgs) Handles btn_ubigeo.Click
        sBusAlm = "43"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing And gCodAct <> Nothing Then
            lblubigeo.Text = gLinea
            lbldistrito.Text = gSubLinea
            lblprovincia.Text = gArt
            lblciudad.Text = gCodAct
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
            gCodAct = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
            gCodAct = Nothing
        End If

    End Sub

    Private Sub txt_codfpago_Lostfocus(ByVal sender As Object, ByVal e As EventArgs) Handles txt_codfpago.LostFocus
        If txt_codfpago.Text = "" Then
            cmbCondPago.SelectedIndex = -1
        Else
            Dim dt As DataTable
            dt = ELTBCLIENTEBL.SelectCondicionCod(txt_codfpago.Text)
            If dt.Rows.Count > 0 Then
                txt_codfpago.Text = dt.Rows(0).Item(0).ToString
                cmbCondPago.SelectedValue = dt.Rows(0).Item(0).ToString
            Else
                txt_codfpago.Text = ""
                cmbCondPago.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub txtvend_resp_Lostfocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtvend_resp.LostFocus
        If txtvend_resp.Text = "" Then
            cmbvendedor.SelectedIndex = -1
        Else
            Dim dt As DataTable
            dt = ELTBCLIENTEBL.SelectVendeCod(txtvend_resp.Text)
            If dt.Rows.Count > 0 Then
                txtvend_resp.Text = dt.Rows(0).Item(0).ToString
                cmbvendedor.SelectedValue = dt.Rows(0).Item(0).ToString
            Else
                txtvend_resp.Text = ""
                cmbvendedor.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub cmbCondPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCondPago.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        End If
        txt_codfpago.Text = cmbCondPago.SelectedValue
    End Sub
    Private Sub cmbvendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvendedor.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        End If
        txtvend_resp.Text = cmbvendedor.SelectedValue
    End Sub

    Private Sub FormMantELTBCLIENTE_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub txtpais_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpais.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "50"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtpais.Text = gLinea
                lblpais.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtpais_Leave(sender As Object, e As EventArgs) Handles txtpais.Leave
        If txtpais.Text = "" Then
            lblpais.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBCLIENTEBL.SelectPaisCod(txtpais.Text)
            If dt.Rows.Count > 0 Then
                txtpais.Text = dt.Rows(0).Item(0).ToString
                lblpais.Text = dt.Rows(0).Item(1).ToString
            Else
                txtpais.Text = ""
                lblpais.Text = ""
            End If
        End If
    End Sub
#Region "BOTONES DE TAB PAGES"
    Private Sub btnborrardir_Click(sender As Object, e As EventArgs) Handles btnborrardir.Click
        dgvt_dir.Rows.Remove(dgvt_dir.CurrentRow)
        dgvt_dir.Refresh()
    End Sub
    Private Sub btnborrarcor_Click(sender As Object, e As EventArgs) Handles btnborrarcor.Click
        dgvt_cor.Rows.Remove(dgvt_cor.CurrentRow)
        dgvt_cor.Refresh()
    End Sub
    Private Sub btnborrartel_Click(sender As Object, e As EventArgs) Handles btnborrartel.Click
        dgvt_tel.Rows.Remove(dgvt_tel.CurrentRow)
        dgvt_tel.Refresh()
    End Sub

    Private Sub btnagregarcor_Click(sender As Object, e As EventArgs) Handles btnagregarcor.Click
        flagAccion1 = "N"
        Dim frm As New formMantELTBCLIENTE_cor
        If dgvt_cor.Rows.Count < 1 Then
            frm.lblcor_cod.Text = "01"
        Else
            frm.lblcor_cod.Text = (dgvt_cor.Rows.Count + 1).ToString.PadLeft(2, "0")
        End If
        frm.ShowDialog()
    End Sub

    Private Sub btnmodificarcor_Click(sender As Object, e As EventArgs) Handles btnmodificarcor.Click
        flagAccion1 = "M"
        Dim frm As New formMantELTBCLIENTE_cor
        If dgvt_cor.Rows.Count > 0 Then
            frm.lblcor_cod.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("COR_COD").Value
            frm.txtnom.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("NOM").Value
            frm.txtcontacto.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("CONTACTO").Value
            frm.txtcargo.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("CARGO").Value
            frm.txttelefono.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("TELEFONO").Value
            'frm.chkcontacor.Checked = IIf(dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("X_CONT").Value = "SI", True, False)
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnagregartel_Click(sender As Object, e As EventArgs) Handles btnagregartel.Click
        flagAccion1 = "N"
        Dim frm As New formMantELTBCLIENTE_tel
        If dgvt_tel.Rows.Count < 1 Then
            frm.lblcor_cod.Text = "01"
            frm.npdlineacredito.Text = 0
            frm.npdlineadol.Text = 0
        Else
            frm.lblcor_cod.Text = (dgvt_tel.Rows.Count + 1).ToString.PadLeft(2, "0")
            If dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("L_CREDITO").Value <> "" Then
                frm.npdlineacredito.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("L_CREDITO").Value
                frm.npdlineadol.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("L_DCREDITO").Value
            End If
        End If
        frm.ShowDialog()
    End Sub
    Private Sub btnmodificartel_Click(sender As Object, e As EventArgs) Handles btnmodificartel.Click
        flagAccion1 = "M"
        Dim frm As New formMantELTBCLIENTE_tel
        If dgvt_tel.Rows.Count > 0 Then
            frm.lblcor_cod.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("TEL_COD").Value
            frm.txtnom.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("NOM").Value
            frm.txtcontacto.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("CONTACTO").Value
            frm.chkcontatel.Checked = IIf(dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("X_CONT").Value = "SI", True, False)
            frm.txtobservacion.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("OBSERVACION").Value
            frm.npdlineacredito.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("L_CREDITO").Value
            frm.npdlineadol.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("L_DCREDITO").Value
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnagregardir_Click(sender As Object, e As EventArgs) Handles btnagregardir.Click
        flagAccion1 = "N"
        Dim frm As New FormMantELTBCLIENTE_dir
        If dgvt_dir.Rows.Count < 1 Then
            frm.lblseqdir.Text = "01"
        Else
            frm.lblseqdir.Text = (dgvt_dir.Rows.Count + 1).ToString.PadLeft(2, "0")
        End If
        frm.ShowDialog()
    End Sub
    Private Sub btnmodificardir_Click(sender As Object, e As EventArgs) Handles btnmodificardir.Click
        flagAccion1 = "M"
        Dim frm As New FormMantELTBCLIENTE_dir
        If dgvt_dir.Rows.Count > 0 Then
            frm.lblseqdir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("DIR_COD").Value
            frm.txtdirdir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("NOM").Value
            frm.lblubigeodir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("UBIGEO").Value
            frm.lbldistritodir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("DISTRITO").Value
            frm.lblprovinciadir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("PROV").Value
            'frm.chkcontadir.Checked = IIf(dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("X_CONT").Value = "SI", True, False)
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub chkextranjero_CheckedChanged(sender As Object, e As EventArgs) Handles chkextranjero.CheckedChanged
        If chkextranjero.Checked = True Then
            txtpais.Enabled = True
        Else
            txtpais.Enabled = False
        End If
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        ReDim gsRptArgs(1)
        gsRptArgs(0) = RTrim(txtruc.Text)
        gsRptArgs(1) = RTrim("TEL")
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_CLIENTETEL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
        Exit Sub
    End Sub


    Private Sub txtser_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtser_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "45"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtser_cod.Text = gLinea
                lblser_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtser_cod_Leave(sender As Object, e As EventArgs) Handles txtser_cod.Leave
        If txtser_cod.Text = "" Then
            lblser_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBCLIENTEBL.SelectCiuuCod(txtser_cod.Text)
            If dt.Rows.Count > 0 Then
                txtser_cod.Text = dt.Rows(0).Item(0).ToString
                lblser_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtser_cod.Text = ""
                lblser_cod.Text = ""
                MsgBox("El CIIU no existe en el sistema")
            End If
        End If
    End Sub

    Private Sub lblubigeo_Leave(sender As Object, e As EventArgs) Handles lblubigeo.Leave
        If lblubigeo.Text = "" Then
            lbldistrito.Text = ""
            lblprovincia.Text = ""
            lblciudad.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBCLIENTEBL.SelectUbigeoCod(lblubigeo.Text)
            If dt.Rows.Count > 0 Then
                lblubigeo.Text = dt.Rows(0).Item(0).ToString
                lbldistrito.Text = dt.Rows(0).Item(1).ToString
                lblprovincia.Text = dt.Rows(0).Item(2).ToString
                lblciudad.Text = dt.Rows(0).Item(3).ToString
            Else
                lblubigeo.Text = ""
                lbldistrito.Text = ""
                lblprovincia.Text = ""
                lblciudad.Text = ""
            End If
        End If
    End Sub

#End Region
End Class