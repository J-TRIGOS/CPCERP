Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormELTBCUENTA

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBCUENTABL As New ELTBCUENTABL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sSec As String
    Private MenuBL As New MenuBL
    Public boton As String

    Private Sub FormELTBCUENTAvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bPrimero = True
        'Cargar los combos
        Dim dt As DataTable
        dt = ELTBCUENTABL.SelectT_Moneda()
        GetCmb("cod", "nom", dt, cmb_moneda)
        cmb_moneda.SelectedIndex = -1

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
            Case 1
                flagAccion = "M"
                GetData(gsCode, sNDoc)
                txtcod.Enabled = False
        End Select

    End Sub
    Private Sub Limpiar()
        dtpfec_ingreso.Value = DateTime.Now.ToString("dd/MM/yyyy")
        cmb_año.SelectedIndex = 13
        txtcod.Text = ""
        txtcod_abono.Text = ""
        txtcod_cargo.Text = ""
        txtcta_cod.Text = ""
        txtcta_alt_cod.Text = ""
        txt_nom.Text = ""
        txt_cod_ajuste1.Text = ""
        txt_cod_ajuste2.Text = ""
        txt_cta_des1.Text = ""
        txt_cta_des2.Text = ""
        cmb_xtcmb.SelectedIndex = -1
        chk_x_cco.Checked = False
        chk_t_ajuste.Checked = False
        chk_x_modulo.Checked = False
        chk_ctct.Checked = False
        chk_x_tgasto.Checked = False
        chk_x_proy.Checked = False
        chk_x_linea.Checked = False
        chk_hco.Checked = False
        chk_xfuente.Checked = False
        chk_xpadre.Checked = False
        chk_t_conv.Checked = False
        chk_xsucu.Checked = False
        chk_tsaldo.Checked = False
        chk_tdoc.Checked = False
        chk_x_difcmb.Checked = False
        chk_xlabor.Checked = False
        chk_x_balance.Checked = False

    End Sub
    Private Sub GetData(ByVal sCode As String, ByVal gsCode2 As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBCUENTABL.SelectRow(gsCode, gsCode2)
        For Each Registro In dtUsuario.Rows
            cmb_año.Text = IIf(IsDBNull(Registro("ANHO")), "", Registro("ANHO"))
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtcta_cod.Text = IIf(IsDBNull(Registro("CTA_COD")), "", Registro("CTA_COD"))
            cmb_moneda.SelectedValue = IIf(IsDBNull(Registro("MON_COD")), "", Registro("MON_COD"))
            dtpfec_ingreso.Text = IIf(IsDBNull(Registro("FEC_ING_ULT")), "", Registro("FEC_ING_ULT"))
            If Registro("X_CCO") = "S" Then chk_x_cco.Checked = True Else chk_x_cco.Checked = False
            If Registro("X_CTCT") = "S" Then chk_ctct.Checked = True Else chk_ctct.Checked = False
            If Registro("X_T_GASTO") = "S" Then chk_x_tgasto.Checked = True Else chk_x_tgasto.Checked = False
            If Registro("X_PROY") = "S" Then chk_x_proy.Checked = True Else chk_x_proy.Checked = False
            If Registro("X_LINEA") = "S" Then chk_x_linea.Checked = True Else chk_x_linea.Checked = False
            If Registro("X_HCO") = "S" Then chk_hco.Checked = True Else chk_hco.Checked = False
            If Registro("X_FUENTE") = "S" Then chk_xfuente.Checked = True Else chk_xfuente.Checked = False
            If Registro("X_PADRE") = "S" Then chk_xpadre.Checked = True Else chk_xpadre.Checked = False
            If Registro("X_T_CONV") = "S" Then chk_t_conv.Checked = True Else chk_t_conv.Checked = False
            cmb_xtcmb.SelectedIndex = Registro("X_T_CMB")
            If Registro("X_T_SALDO") = "S" Then chk_tsaldo.Checked = True Else chk_tsaldo.Checked = False
            If Registro("X_T_DOC") = "S" Then chk_tdoc.Checked = True Else chk_tdoc.Checked = False
            txt_cta_des1.Text = IIf(IsDBNull(Registro("CTA_COD_DEST")), "", Registro("CTA_COD_DEST"))
            If Registro("X_DIF_CMB") = "S" Then chk_x_difcmb.Checked = True Else chk_x_difcmb.Checked = False
            If Registro("T_AJUSTE_INF_COD") = "S" Then chk_t_ajuste.Checked = True Else chk_t_ajuste.Checked = False
            If Registro("X_LABOR") = "S" Then chk_xlabor.Checked = True Else chk_xlabor.Checked = False
            If Registro("X_SUCU") = "S" Then chk_xsucu.Checked = True Else chk_xsucu.Checked = False
            If Registro("X_MODULO") = "S" Then chk_x_modulo.Checked = True Else chk_x_modulo.Checked = False
            If Registro("X_BALANCE") = "S" Then chk_x_balance.Checked = True Else chk_x_balance.Checked = False
            txt_cta_des2.Text = IIf(IsDBNull(Registro("CTA_COD_DEST_2")), "", Registro("CTA_COD_DEST_2"))
            txtcod_abono.Text = IIf(IsDBNull(Registro("BAL_COD_ABONO")), "", Registro("BAL_COD_ABONO"))
            txtcod_cargo.Text = IIf(IsDBNull(Registro("BAL_COD_CARGO")), "", Registro("BAL_COD_CARGO"))
            txtcta_alt_cod.Text = IIf(IsDBNull(Registro("CTA_ALT_COD")), "", Registro("CTA_ALT_COD"))
            txt_cod_ajuste1.Text = IIf(IsDBNull(Registro("CTA_COD_AJUSTE1")), "", Registro("CTA_COD_AJUSTE1"))
            txt_cod_ajuste2.Text = IIf(IsDBNull(Registro("CTA_COD_AJUSTE2")), "", Registro("CTA_COD_AJUSTE2"))
            txt_nom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
        Next
    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function

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
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBCUENTABE As New ELTBCUENTABE
                ELTBCUENTABE.anho = cmb_año.SelectedItem
                ELTBCUENTABE.cod = txtcod.Text
                ELTBCUENTABE.cta_cod = txtcta_cod.Text

                If cmb_moneda.SelectedIndex = -1 Then ELTBCUENTABE.mon_cod = "" Else ELTBCUENTABE.mon_cod = cmb_moneda.SelectedValue
                ELTBCUENTABE.nom = txt_nom.Text
                ELTBCUENTABE.fec_ing_ult = dtpfec_ingreso.Value
                If chk_x_cco.Checked = True Then ELTBCUENTABE.x_cco = "S" Else ELTBCUENTABE.x_cco = "N"
                If chk_ctct.Checked = True Then ELTBCUENTABE.x_ctct = "S" Else ELTBCUENTABE.x_ctct = "N"
                If chk_x_tgasto.Checked = True Then ELTBCUENTABE.x_t_gasto = "S" Else ELTBCUENTABE.x_t_gasto = "N"
                If chk_x_proy.Checked = True Then ELTBCUENTABE.x_proy = "S" Else ELTBCUENTABE.x_proy = "N"
                If chk_x_linea.Checked = True Then ELTBCUENTABE.x_linea = "S" Else ELTBCUENTABE.x_linea = "N"
                If chk_hco.Checked = True Then ELTBCUENTABE.x_hco = "S" Else ELTBCUENTABE.x_hco = "N"
                If chk_xfuente.Checked = True Then ELTBCUENTABE.x_fuente = "S" Else ELTBCUENTABE.x_fuente = "N"
                If chk_xpadre.Checked = True Then ELTBCUENTABE.x_padre = "S" Else ELTBCUENTABE.x_padre = "N"
                If chk_t_conv.Checked = True Then ELTBCUENTABE.x_t_conv = "S" Else ELTBCUENTABE.x_t_conv = "N"
                If cmb_xtcmb.SelectedItem = "" Then ELTBCUENTABE.x_t_cmb = "" Else ELTBCUENTABE.x_t_cmb = cmb_xtcmb.SelectedItem.Substring(0, 1)
                If chk_tsaldo.Checked = True Then ELTBCUENTABE.x_t_saldo = "S" Else ELTBCUENTABE.x_t_saldo = "N"
                If chk_tdoc.Checked = True Then ELTBCUENTABE.x_t_doc = "S" Else ELTBCUENTABE.x_t_doc = "N"
                ELTBCUENTABE.cta_cod_dest = txt_cta_des1.Text
                If chk_x_difcmb.Checked = True Then ELTBCUENTABE.x_dif_cmb = "S" Else ELTBCUENTABE.x_dif_cmb = "N"
                If chk_t_ajuste.Checked = True Then ELTBCUENTABE.ajuste_inf_cod = "S" Else ELTBCUENTABE.ajuste_inf_cod = "N"
                If chk_xlabor.Checked = True Then ELTBCUENTABE.x_labor = "S" Else ELTBCUENTABE.x_labor = "N"
                If chk_xsucu.Checked = True Then ELTBCUENTABE.x_sucu = "S" Else ELTBCUENTABE.x_sucu = "N"
                If chk_x_modulo.Checked = True Then ELTBCUENTABE.x_modulo = "S" Else ELTBCUENTABE.x_modulo = "N"
                If chk_x_balance.Checked = True Then ELTBCUENTABE.x_balance = "S" Else ELTBCUENTABE.x_balance = "N"
                ELTBCUENTABE.cta_cod_dest2 = txt_cta_des2.Text
                ELTBCUENTABE.bal_cod_abono = txtcod_abono.Text
                ELTBCUENTABE.bal_cod_cargo = txtcod_cargo.Text
                ELTBCUENTABE.cta_alt_cod = txtcta_alt_cod.Text
                ELTBCUENTABE.cta_cod_ajuste1 = txt_cod_ajuste1.Text
                ELTBCUENTABE.cta_cod_ajuste2 = txt_cod_ajuste2.Text

                gsError = ELTBCUENTABL.SaveRow(ELTBCUENTABE, flagAccion)
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
    Private Function OkData() As Boolean
        If txtcod.Text = "" Then
            MsgBox("Ingrese el Codigo", MsgBoxStyle.Exclamation)
            txtcod.Focus()
            Return False
        End If
        If flagAccion = "N" Then
            If ELTBCUENTABL.VerificarRepetido(cmb_año.SelectedItem, txtcod.Text) = True Then
                MsgBox("Ya Existe el codigo para este Año", MsgBoxStyle.Exclamation)
                txtcod.Focus()
                Return False
            End If
        End If
        Return True
    End Function
End Class