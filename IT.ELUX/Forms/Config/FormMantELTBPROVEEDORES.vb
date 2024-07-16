Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Public Class FormMantELTBPROVEEDORES
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBPROVEEDORESBL As New ELTBPROVEEDORESBL
    Private ELTBCLIENTEBL As New ELTBCLIENTEBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private MenuBL As New MenuBL

    Private Sub FormMantELTBPROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        'Cargar los combos
        Dim dt As DataTable
        dt = ELTBPROVEEDORESBL.SelectVendedor()
        GetCmb("cod", "nom", dt, cmbvendedor)

        'AGREGAR COLUMNAS A DIRECCION
        dgvt_dir.Columns.Add("DIR_COD", "Seq") '0
        dgvt_dir.Columns.Add("NOM", "Dirección") '1
        dgvt_dir.Columns.Add("DPTO", "Departamento") '2
        dgvt_dir.Columns.Add("DISTRITO", "Distrito") '3
        dgvt_dir.Columns.Add("PROV", "Provincia") '4
        dgvt_dir.Columns.Add("UBIGEO", "Ubigeo") '5
        dgvt_dir.Columns.Add("X_CONT", "Contabilidad") '6

        'AGREGAR COLUMNAS A CORREO
        dgvt_cor.Columns.Add("COR_COD", "Seq") '0
        dgvt_cor.Columns.Add("NOM", "Correo ") '1
        dgvt_cor.Columns.Add("CONTACTO", "Contacto") '2
        dgvt_cor.Columns.Add("CARGO", "Cargo") '3
        dgvt_cor.Columns.Add("TELEFONO", "Telefono") '4
        dgvt_cor.Columns.Add("X_CONT", "Contabilidad") '5        

        'AGREGAR COLUMNAS A TELEFONOS
        dgvt_tel.Columns.Add("TEL_COD", "Seq") '0
        dgvt_tel.Columns.Add("NOM", "Numero de Telefono") '1
        dgvt_tel.Columns.Add("CONTACTO", "Contacto") '2
        dgvt_tel.Columns.Add("X_CONT", "Contabilidad") '2

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
            Case 1
                flagAccion = "M"
                GetData(gsCode)
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
        If txtruc.Text <> "" Then
            'Dim dt As DataTable
            'Dim Registro As DataRow
            'dt = ELTBPROVEEDORESBL.SelectRow(txtruc.Text)
            'If dt.Rows.Count = 0 Then
            '    flagAccion = "N"
            'LIMPIAR TEXTOS Y CMB
            lblcodigo.Text = txtruc.Text
            '        txtnom.Text = ""
            '        txtdir.Text = ""
            '        lblubigeo.Text = ""
            '        lblciudad.Text = ""
            '        lbldistrito.Text = ""
            '        lblprovincia.Text = ""
            '        txttelef.Text = ""
            '        txtpais.Text = ""
            '        txtDNI.Text = ""
            '        txtvend_resp.Text = ""
            '        cmbnego_cop.SelectedIndex = -1
            '        cmbciiucod.SelectedIndex = -1
            '        cmbvendedor.SelectedIndex = -1
            '        LiberarGrids()
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
            '            txtpais.Text = IIf(IsDBNull(Registro("PAIS")), "", Registro("PAIS"))
            '            txtDNI.Text = IIf(IsDBNull(Registro("DNI")), "", Registro("DNI"))
            '            txtvend_resp.Text = IIf(IsDBNull(Registro("VEND_RESP")), "", Registro("VEND_RESP"))
            '            cmbciiucod.SelectedValue = IIf(IsDBNull(Registro("CIIU_COD")), "0", Registro("CIIU_COD"))
            '            cmbvendedor.SelectedValue = IIf(IsDBNull(Registro("VEND_RESP")), "0", Registro("VEND_RESP"))
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
            '            If IIf(IsDBNull(Registro("X_CLI")), "0", Registro("X_CLI")) = 0 Then
            '                chkcliente.Checked = False
            '            Else
            '                chkcliente.Checked = True
            '            End If
            '            If IIf(IsDBNull(Registro("X_RET")), "0", Registro("X_RET")) = 0 Then
            '                chkretenedor.Checked = False
            '            Else
            '                chkretenedor.Checked = True
            '            End If
            '            If IIf(IsDBNull(Registro("X_PER")), "0", Registro("X_PER")) = 0 Then
            '                chkpercepcion.Checked = False
            '            Else
            '                chkpercepcion.Checked = True
            '            End If



            '        Next
            '        'LLENAR GRID DIRECCIONES
            '        Dim dtGrid As DataTable
            '        dtGrid = ELTBPROVEEDORESBL.SelectRowGrid(txtruc.Text, "DIR")
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
            '        dtGrid = ELTBPROVEEDORESBL.SelectRowGrid(txtruc.Text, "COR")
            '        For Each row As DataRow In dtGrid.Rows
            '            dgvt_cor.Rows.Add(IIf(IsDBNull(row("COR_COD")), "", row("COR_COD")),'0
            '                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
            '                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO")),'2
            '                              IIf(IsDBNull(row("CARGO")), "", row("CARGO")),'3
            '                              IIf(IsDBNull(row("TELEFONO")), "", row("TELEFONO")),'4
            '                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT"))) '5                  
            '        Next
            '        'LLENAR GRID TELEFONO'
            '        dtGrid = ELTBPROVEEDORESBL.SelectRowGrid(txtruc.Text, "TEL")
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
            '    cmbvendedor.SelectedIndex = -1
            '    LiberarGrids()
        End If
    End Sub
    Private Sub GetData(ByVal sCode As String)
        Dim dt As DataTable
        Dim Registro As DataRow
        dt = ELTBPROVEEDORESBL.SelectRow(sCode)
        'LLENAR DATOS DEL RUC
        For Each Registro In dt.Rows
            txtruc.Text = sCode
            lblcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtdir.Text = IIf(IsDBNull(Registro("DIR")), "", Registro("DIR"))
            lblubigeo.Text = IIf(IsDBNull(Registro("UBIGEO")), "", Registro("UBIGEO"))
            lbldistrito.Text = IIf(IsDBNull(Registro("DIST")), "", Registro("DIST"))
            lblprovincia.Text = IIf(IsDBNull(Registro("CIUDAD")), "", Registro("CIUDAD"))
            lblciudad.Text = IIf(IsDBNull(Registro("CIUDAD")), "", Registro("CIUDAD"))
            txttelef.Text = IIf(IsDBNull(Registro("TELEF")), "", Registro("TELEF"))
            txtpais.Text = IIf(IsDBNull(Registro("PAIS")), "", Registro("PAIS"))
            txtDNI.Text = IIf(IsDBNull(Registro("DNI")), "", Registro("DNI"))
            txtvend_resp.Text = IIf(IsDBNull(Registro("VEND_RESP")), "", Registro("VEND_RESP"))
            txtser_cod.Text = IIf(IsDBNull(Registro("CIIU_COD")), "0", Registro("CIIU_COD"))
            txtserv.Text = IIf(IsDBNull(Registro("COD_DET")), "", Registro("COD_DET"))
            txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(txtserv.Text)
            npdporc.Value = IIf(IsDBNull(Registro("PORC")), 0, Registro("PORC"))
            txtcta.Text = IIf(IsDBNull(Registro("CTA")), "", Registro("CTA"))
            cmbvendedor.SelectedValue = IIf(IsDBNull(Registro("VEND_RESP")), "0", Registro("VEND_RESP"))
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
            If IIf(IsDBNull(Registro("X_CLI")), "0", Registro("X_CLI")) = 0 Then
                chkcliente.Checked = False
            Else
                chkcliente.Checked = True
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
        dtGrid = ELTBPROVEEDORESBL.SelectRowGrid(sCode, "DIR")
        For Each row As DataRow In dtGrid.Rows
            dgvt_dir.Rows.Add(IIf(IsDBNull(row("DIR_COD")), "", row("DIR_COD")),'0
                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
                              IIf(IsDBNull(row("DPTO")), "", row("DPTO")),'2
                              IIf(IsDBNull(row("DISTRITO")), "", row("DISTRITO")),'3
                              IIf(IsDBNull(row("PROV")), "", row("PROV")),'4
                              IIf(IsDBNull(row("UBIGEO")), "", row("UBIGEO")),'5
                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT")))  '6
        Next
        'LLENAR GRID CORREO'
        dtGrid = ELTBPROVEEDORESBL.SelectRowGrid(sCode, "COR")
        For Each row As DataRow In dtGrid.Rows
            dgvt_cor.Rows.Add(IIf(IsDBNull(row("COR_COD")), "", row("COR_COD")),'0
                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO")),'2
                              IIf(IsDBNull(row("CARGO")), "", row("CARGO")),'3
                              IIf(IsDBNull(row("TELEFONO")), "", row("TELEFONO")),'4
                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT")))  '5                  
        Next
        'LLENAR GRID TELEFONO'
        dtGrid = ELTBPROVEEDORESBL.SelectRowGrid(sCode, "TEL")
        For Each row As DataRow In dtGrid.Rows
            dgvt_tel.Rows.Add(IIf(IsDBNull(row("TEL_COD")), "", row("TEL_COD")),'0
                              IIf(IsDBNull(row("NOM")), "", row("NOM")),'1
                              IIf(IsDBNull(row("CONTACTO")), "", row("CONTACTO")), '2
                              IIf(IsDBNull(row("X_CONT")), "", row("X_CONT")))  '3
        Next
    End Sub
    Private Sub SaveData()

        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBPROVEEDORESBE As New ELTBPROVEEDORESBE
                ELTBPROVEEDORESBE.cod = RTrim(lblcodigo.Text)
                ELTBPROVEEDORESBE.ruc = RTrim(txtruc.Text)
                ELTBPROVEEDORESBE.nom = txtnom.Text
                ELTBPROVEEDORESBE.dni = txtDNI.Text
                ELTBPROVEEDORESBE.dir = txtdir.Text
                ELTBPROVEEDORESBE.dist = lbldistrito.Text
                ELTBPROVEEDORESBE.ciudad = lblciudad.Text
                ELTBPROVEEDORESBE.telef = txttelef.Text
                ELTBPROVEEDORESBE.vend_resp = txtvend_resp.Text
                ELTBPROVEEDORESBE.pais = txtpais.Text
                ELTBPROVEEDORESBE.ubigeo = lblubigeo.Text
                ELTBPROVEEDORESBE.x_prov = "1"
                If chkextranjero.Checked = True Then
                    ELTBPROVEEDORESBE.x_ext = "1"
                Else
                    ELTBPROVEEDORESBE.x_ext = "0"
                End If
                If chkcliente.Checked = True = True Then
                    ELTBPROVEEDORESBE.x_cli = "1"
                Else
                    ELTBPROVEEDORESBE.x_cli = "0"
                End If
                If chkprotocolo.Checked = True Then
                    ELTBPROVEEDORESBE.efic_cod = "1"
                Else
                    ELTBPROVEEDORESBE.efic_cod = "0"
                End If
                If chkretenedor.Checked = True Then
                    ELTBPROVEEDORESBE.x_ret = "1"
                Else
                    ELTBPROVEEDORESBE.x_ret = "0"
                End If
                If chkpercepcion.Checked = True Then
                    ELTBPROVEEDORESBE.x_per = "1"
                Else
                    ELTBPROVEEDORESBE.x_per = "0"
                End If

                If cmbnego_cop.SelectedIndex = 0 Then
                    ELTBPROVEEDORESBE.nego_cod = "E"
                ElseIf cmbnego_cop.SelectedIndex = 1 Then
                    ELTBPROVEEDORESBE.nego_cod = "B"
                Else
                    ELTBPROVEEDORESBE.nego_cod = "R"
                End If
                ELTBPROVEEDORESBE.ciiu_cod = txtser_cod.Text
                ELTBPROVEEDORESBE.Fec_cred = DateTime.Now.ToString("dd/MM/yyyy")
                ELTBPROVEEDORESBE.Dia4 = gsCodUsr
                ELTBPROVEEDORESBE.cta = txtcta.Text
                ELTBPROVEEDORESBE.porc = npdporc.Value
                ELTBPROVEEDORESBE.coddet = txtserv.Text
                gsError = ELTBPROVEEDORESBL.SaveRow(ELTBPROVEEDORESBE, flagAccion, dgvt_dir, dgvt_cor, dgvt_tel)
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
        chkcliente.Checked = False
        chkretenedor.Checked = False
        chkpercepcion.Checked = False
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
            Case "delete"
                'DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

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
            If txtDNI.Text = "" Then
                If txtruc.Text.Length <> 11 Then
                    MsgBox("El Ruc Debe contener 11 digitos", MsgBoxStyle.Exclamation)
                    txtruc.Focus()
                    Return False
                End If
            Else
                If txtruc.Text.Length <> 8 Then
                    MsgBox("El Ruc Debe contener 8 digitos", MsgBoxStyle.Exclamation)
                    txtruc.Focus()
                    Return False
                End If
            End If
            If dgvt_dir.Rows.Count < 1 Then
                MsgBox("Ingrese al menos 1 Direccion en la pestaña de Direcciones", MsgBoxStyle.Exclamation)
                TabCorreo.SelectTab(1)
                Return False
            End If
            If txtser_cod.Text = "" Then
                MsgBox("Seleccione la Actividad/ Servicio", MsgBoxStyle.Exclamation)
                txtser_cod.Focus()
                Return False
            End If
            If lblubigeo.Text = "" Then
                MsgBox("Ingrese Ubigeo del Proveedor", MsgBoxStyle.Exclamation)
                btn_ubigeo.Focus()
                Return False
            End If
            If txtser_cod.Text = "" Then
                MsgBox("Ingrese CIIU del Proveedor", MsgBoxStyle.Exclamation)
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
        If txtnom.Text = "" Then
            MsgBox("Ingrese los Nombres del Proveedor", MsgBoxStyle.Exclamation)
            txtnom.Focus()
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

        lblubigeo.Text = gLinea
        lbldistrito.Text = gSubLinea
        lblprovincia.Text = gArt
        lblciudad.Text = gCodAct
    End Sub

    Private Sub txtruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtruc.KeyPress
        'If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
        '    e.Handled = True
        'End If
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        '    MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        'End If
    End Sub

    Private Sub cmbvendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvendedor.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        End If
        txtvend_resp.Text = cmbvendedor.SelectedValue
    End Sub

    Private Sub FormMantELTBPROVEEDORES_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnborrardir_Click(sender As Object, e As EventArgs) Handles btnborrardir.Click
        dgvt_dir.Rows.Remove(dgvt_dir.CurrentRow)
    End Sub

    Private Sub btnborrarcor_Click(sender As Object, e As EventArgs) Handles btnborrarcor.Click
        dgvt_cor.Rows.Remove(dgvt_cor.CurrentRow)
    End Sub

    Private Sub btnborrartel_Click(sender As Object, e As EventArgs) Handles btnborrartel.Click
        dgvt_tel.Rows.Remove(dgvt_tel.CurrentRow)
    End Sub


    Private Sub btnagregardir_Click(sender As Object, e As EventArgs) Handles btnagregardir.Click
        flagAccion1 = "N"
        Dim frm As New FormMantELTBPROVEEDORES_dir
        If dgvt_dir.Rows.Count < 1 Then
            frm.lblseqdir.Text = "01"
        Else
            frm.lblseqdir.Text = (dgvt_dir.Rows.Count + 1).ToString.PadLeft(2, "0")
        End If
        frm.ShowDialog()
    End Sub

    Private Sub btnmodificardir_Click(sender As Object, e As EventArgs) Handles btnmodificardir.Click
        flagAccion1 = "M"
        Dim frm As New FormMantELTBPROVEEDORES_dir
        If dgvt_dir.Rows.Count > 0 Then
            frm.lblseqdir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("DIR_COD").Value
            frm.txtdirdir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("NOM").Value
            frm.lblubigeodir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("UBIGEO").Value
            frm.lbldistritodir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("DISTRITO").Value
            frm.lblprovinciadir.Text = dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("PROV").Value
            frm.chkcontadir.Checked = IIf(dgvt_dir.Rows(dgvt_dir.CurrentRow.Index).Cells("X_CONT").Value = "SI", True, False)
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnagregartel_Click(sender As Object, e As EventArgs) Handles btnagregartel.Click
        flagAccion1 = "N"
        Dim frm As New FormMantELTBPROVEEDORES_tel
        If dgvt_tel.Rows.Count < 1 Then
            frm.lblcor_cod.Text = "01"
        Else
            frm.lblcor_cod.Text = (dgvt_tel.Rows.Count + 1).ToString.PadLeft(2, "0")
        End If
        frm.ShowDialog()
    End Sub

    Private Sub btnmodificartel_Click(sender As Object, e As EventArgs) Handles btnmodificartel.Click
        flagAccion1 = "M"
        Dim frm As New FormMantELTBPROVEEDORES_tel
        If dgvt_tel.Rows.Count > 0 Then
            frm.lblcor_cod.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("TEL_COD").Value
            frm.txtnom.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("NOM").Value
            frm.txtcontacto.Text = dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("CONTACTO").Value
            frm.chkcontatel.Checked = IIf(dgvt_tel.Rows(dgvt_tel.CurrentRow.Index).Cells("X_CONT").Value = "SI", True, False)
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnagregarcor_Click(sender As Object, e As EventArgs) Handles btnagregarcor.Click
        flagAccion1 = "N"
        Dim frm As New FormMantELTBPROVEEDORES_cor
        If dgvt_cor.Rows.Count < 1 Then
            frm.lblcor_cod.Text = "01"
        Else
            frm.lblcor_cod.Text = (dgvt_cor.Rows.Count + 1).ToString.PadLeft(2, "0")
        End If
        frm.ShowDialog()
    End Sub

    Private Sub btnmodificarcor_Click(sender As Object, e As EventArgs) Handles btnmodificarcor.Click
        flagAccion1 = "M"
        Dim frm As New FormMantELTBPROVEEDORES_cor
        If dgvt_cor.Rows.Count > 0 Then
            frm.lblcor_cod.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("COR_COD").Value
            frm.txtnom.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("NOM").Value
            frm.txtcontacto.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("CONTACTO").Value
            frm.txtcargo.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("CARGO").Value
            frm.txttelefono.Text = dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("TELEFONO").Value
            frm.chkcontacor.Checked = IIf(dgvt_cor.Rows(dgvt_cor.CurrentRow.Index).Cells("X_CONT").Value = "SI", True, False)
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
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
    Private Sub chkextranjero_CheckedChanged(sender As Object, e As EventArgs) Handles chkextranjero.CheckedChanged
        If chkextranjero.Checked = True Then
            txtpais.Enabled = True
            txtser_cod.Text = 0
        Else
            txtpais.Enabled = False
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
                'txtser_cod.Text = ""
                'lblser_cod.Text = ""
                If MessageBox.Show("El CIIU no existe en el sistema, ¿Desea guardar un nuevo CIIU?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    txtser_cod.Text = ""
                    lblser_cod.Text = ""
                    Exit Sub
                Else
                    FormCIIU.val = "N"
                    FormCIIU.txtcodigo.Text = txtser_cod.Text
                    FormCIIU.ShowDialog()
                    txtser_cod.Focus()
                End If
                'MsgBox("El CIIU no existe en el sistema")
            End If
        End If
    End Sub

    Private Sub txtruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtruc.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnom.Focus()
        End If
    End Sub

    Private Sub txtnom_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnom.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtdir.Focus()
        End If
    End Sub

    Private Sub txtt_serv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserv.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "232"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtserv.Text = gLinea
                txtnomserv.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub
End Class