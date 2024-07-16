Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormTBMOVIMIENTO

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBMOVIMIENTOBL As New ELTBMOVIMIENTOBL
    Private ELTBTIPOCAMBIOBL As New ELTBTIPOCAMBIOBL
    Private flagAccion As String = ""
    Private MenuBL As New MenuBL

    Private Sub FormTBMOVIMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = ELTBMOVIMIENTOBL.SelectT_Moneda()
        GetCmb("cod", "nom", dt, cmb_moneda)
        cmb_moneda.SelectedIndex = -1

        dt = ELTBMOVIMIENTOBL.SelectT_Documento()
        GetCmb("cod", "nom", dt, cmb_t_doc_cod)
        cmb_t_doc_cod.SelectedIndex = -1

        dt = ELTBMOVIMIENTOBL.SelectTipOpe(DateTime.Now.ToString("yyyy"))
        GetCmb("cod", "nom", dt, cmb_tipope)
        cmb_tipope.SelectedIndex = -1

        Dim dtUsuario As DataTable
        dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(DateTime.Now.ToString("dd/MM/yyyy"))
        If dtUsuario.Rows.Count > 0 Then
            For Each Registro In dtUsuario.Rows
                txtt_cmb.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
            Next
        Else
            MsgBox("No hay Tipo de Cambio para el dia de hoy", MsgBoxStyle.Exclamation)
        End If

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                habilitar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc, gArt, sOp)
                habilitar(False)
        End Select
    End Sub
    Private Sub habilitar(ByVal F As Boolean)
        cmb_año.Enabled = F
        cmb_mes.Enabled = F
        cmb_tipope.Enabled = F
        txtnro_reg.Enabled = F
    End Sub
    Private Sub Limpiar()
        Dim a As Integer = DateTime.Now.Month
        'dtpfec_ingreso.Value = DateTime.Now.ToString("dd/MM/yyyy")
        cmb_año.SelectedIndex = 13
        cmb_tipope.SelectedIndex = -1
        cmb_mes.SelectedIndex = a - 1
        txtcta_cod.Text = ""
        txtnro_reg.Text = ""
        cmb_t_doc_cod.SelectedIndex = -1
        txtser_nro.Text = ""
        txtcomp_nro.Text = ""
        txtcta_cod.Text = ""
        cmbsigno.SelectedIndex = -1
        cmb_moneda.SelectedIndex = -1
        txtimpor.Text = 0
        txtimpor_me.Text = 0
        txtcomp_cpto.Text = ""
        txtruc.Text = ""
        txtt_cmb.Text = ""
        txtx_prov.Text = ""
        txtimpto.Text = ""
        txtctct_reg.Text = ""
        txtvolumen.Text = ""
        lblseq.Text = ""
    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function
    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal gArt As String, ByVal Sop As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBMOVIMIENTOBL.SelectRow(sTDoc, sSDoc, sNDoc, gArt, Sop)
        For Each Registro In dtUsuario.Rows
            cmb_año.SelectedItem = sTDoc
            cmb_mes.SelectedIndex = sSDoc - 1
            cmb_tipope.SelectedValue = sNDoc
            txtnro_reg.Text = gArt
            lblseq.Text = Sop
            cmb_t_doc_cod.SelectedValue = IIf(IsDBNull(Registro("T_DOC_COD")), "", Registro("T_DOC_COD"))
            txtser_nro.Text = IIf(IsDBNull(Registro("SERIE_NRO")), "", Registro("SERIE_NRO"))
            txtcomp_nro.Text = IIf(IsDBNull(Registro("COMP_NRO")), "", Registro("COMP_NRO"))
            txtcta_cod.Text = IIf(IsDBNull(Registro("CTA_COD")), "", Registro("CTA_COD"))
            cmbsigno.SelectedItem = IIf(IsDBNull(Registro("SIGNO")), "", Registro("SIGNO"))
            cmb_moneda.SelectedValue = IIf(IsDBNull(Registro("MON_COD")), "", Registro("MON_COD"))
            txtimpor.Text = IIf(IsDBNull(Registro("IMPOR")), "", Registro("IMPOR"))
            txtimpor_me.Text = IIf(IsDBNull(Registro("IMPOR_ME")), "", Registro("IMPOR_ME"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC")), "", Registro("FEC"))
            txtcomp_cpto.Text = IIf(IsDBNull(Registro("COMP_CPTO")), "", Registro("COMP_CPTO"))
            dtpcom_fech.Text = IIf(IsDBNull(Registro("COMP_FEC")), "", Registro("COMP_FEC"))
            txtruc.Text = IIf(IsDBNull(Registro("RUC")), "", Registro("RUC"))
            txtt_cmb.Text = IIf(IsDBNull(Registro("T_CMB")), "", Registro("T_CMB"))
            txtx_prov.Text = IIf(IsDBNull(Registro("X_PROV")), "", Registro("X_PROV"))
            txtimpto.Text = IIf(IsDBNull(Registro("IMPTO_COD")), "", Registro("IMPTO_COD"))
            txtctct_reg.Text = IIf(IsDBNull(Registro("CTCT_REG_NRO")), "", Registro("CTCT_REG_NRO"))
            txtvolumen.Text = IIf(IsDBNull(Registro("VOLUMEN")), "", Registro("VOLUMEN"))
        Next
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
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBMOVIMIENTOBE As New ELTBMOVIMIENTOBE
                ELTBMOVIMIENTOBE.anho = cmb_año.SelectedItem
                ELTBMOVIMIENTOBE.mes = cmb_mes.SelectedItem.ToString.Substring(0, 2)
                ELTBMOVIMIENTOBE.t_ope_cod = cmb_tipope.SelectedValue
                ELTBMOVIMIENTOBE.reg_nro = txtnro_reg.Text

                If flagAccion = "N" Then
                    ELTBMOVIMIENTOBE.seq = ELTBMOVIMIENTOBL.SelectMaxTransp(cmb_año.SelectedItem, cmb_mes.SelectedItem.ToString.Substring(0, 2), cmb_tipope.SelectedValue, txtnro_reg.Text)
                Else
                    ELTBMOVIMIENTOBE.seq = lblseq.Text
                End If
                ELTBMOVIMIENTOBE.cta_cod = txtcta_cod.Text
                ELTBMOVIMIENTOBE.fec = dtpfecha.Value.ToString("dd/MM/yyyy")
                ELTBMOVIMIENTOBE.serie_nro = txtser_nro.Text
                If cmb_t_doc_cod.SelectedIndex = -1 Then
                    ELTBMOVIMIENTOBE.t_doc_cod = ""
                Else
                    ELTBMOVIMIENTOBE.t_doc_cod = cmb_t_doc_cod.SelectedValue
                End If
                If cmb_moneda.SelectedIndex = -1 Then
                    ELTBMOVIMIENTOBE.mon_cod = ""
                Else
                    ELTBMOVIMIENTOBE.mon_cod = cmb_moneda.SelectedValue
                End If
                ELTBMOVIMIENTOBE.impto_cod = txtimpto.Text
                ELTBMOVIMIENTOBE.comp_cpto = txtcomp_cpto.Text
                ELTBMOVIMIENTOBE.comp_fec = dtpcom_fech.Value.ToString("dd/MM/yyyy")
                ELTBMOVIMIENTOBE.comp_nro = txtcomp_nro.Text
                ELTBMOVIMIENTOBE.ctct_reg_nro = txtctct_reg.Text
                ELTBMOVIMIENTOBE.impor = txtimpor.Text
                ELTBMOVIMIENTOBE.impor_me = txtimpor_me.Text
                ELTBMOVIMIENTOBE.ruc = txtruc.Text
                If cmbsigno.SelectedIndex = -1 Then
                    ELTBMOVIMIENTOBE.signo = ""
                Else
                    ELTBMOVIMIENTOBE.signo = cmbsigno.SelectedItem
                End If
                If txtt_cmb.Text = "" Then
                    ELTBMOVIMIENTOBE.t_cmb = "0"
                Else
                    ELTBMOVIMIENTOBE.t_cmb = txtt_cmb.Text
                End If
                ELTBMOVIMIENTOBE.x_prov = txtx_prov.Text
                If txtvolumen.Text = "" Then
                    ELTBMOVIMIENTOBE.volumen = "0"
                Else
                    ELTBMOVIMIENTOBE.volumen = txtvolumen.Text
                End If


                gsError = ELTBMOVIMIENTOBL.SaveRow(ELTBMOVIMIENTOBE, flagAccion)
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
        If cmb_tipope.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo de Operación", MsgBoxStyle.Exclamation)
            cmb_tipope.Focus()
            Return False
        End If
        If txtnro_reg.Text = "" Then
            MsgBox("Ingrese el Nro de registro", MsgBoxStyle.Exclamation)
            txtnro_reg.Focus()
            Return False
        End If
        If txtcta_cod.Text = "" Then
            MsgBox("Ingrese la Cuenta ", MsgBoxStyle.Exclamation)
            txtcta_cod.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub dtpcom_fech_ValueChanged(sender As Object, e As EventArgs) Handles dtpcom_fech.ValueChanged
        Dim dtUsuario As DataTable
        dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(dtpcom_fech.Value.ToString("dd/MM/yyyy"))

        If dtUsuario.Rows.Count > 0 Then
            For Each Registro In dtUsuario.Rows
                txtt_cmb.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
            Next
        Else
            MsgBox("No hay Tipo de Cambio para esta fecha", MsgBoxStyle.Exclamation)
            txtt_cmb.Text = ""
        End If

    End Sub
End Class