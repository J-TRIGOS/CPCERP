Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormELTBCUENTA_OPE
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBREGISTRO_NROBL As New ELTBREGISTRO_NROBL
    Private ELTBMOVIMIENTOBL As New ELTBMOVIMIENTOBL
    Private ELTBCUENTA_OPEBL As New ELTBCUENTA_OPEBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sSec As String
    Private MenuBL As New MenuBL
    Public boton As String

    Private Sub FormELTBCUENTA_OPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        'Cargar los combos
        Dim dt As DataTable
        dt = ELTBREGISTRO_NROBL.SelectTipOpe(DateTime.Now.ToString("yyyy"))
        GetCmb("cod", "nom", dt, cmb_tipope)
        cmb_tipope.SelectedIndex = -1

        dt = ELTBMOVIMIENTOBL.SelectT_Documento()
        GetCmb("cod", "nom", dt, cmb_t_doc_cod)
        cmb_t_doc_cod.SelectedIndex = -1

        dt = ELTBCUENTA_OPEBL.SelectTipImpto()
        GetCmb("cod", "nom", dt, cmb_codimpto)
        cmb_codimpto.SelectedIndex = -1

        bPrimero = False
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
        cmbaño.SelectedItem = DateTime.Now.ToString("yyyy")
        txt_tipope.Enabled = F
        cmb_tipope.Enabled = F
        cmb_t_doc_cod.Enabled = F
        chkafecto.Enabled = F
        chkinafecto.Enabled = F
        txtcodimpto.Enabled = F
        cmb_codimpto.Enabled = F
    End Sub
    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal gArt As String, ByVal sop As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        If sNDoc = "AFECTO" Then sNDoc = "S" Else sNDoc = "N"

        dtUsuario = ELTBCUENTA_OPEBL.SelectRow(sTDoc, sSDoc, sNDoc, gArt, sop)
        For Each Registro In dtUsuario.Rows

            txt_tipope.Text = sTDoc
            cmb_tipope.SelectedValue = sTDoc
            cmb_t_doc_cod.SelectedValue = sSDoc
            If sNDoc = "S" Then chkafecto.Checked = True Else chkinafecto.Checked = True
            txtcodimpto.Text = gArt
            cmb_codimpto.SelectedValue = gArt
            txtcodiniS.Text = IIf(IsDBNull(Registro("CTA_INIS")), "", Registro("CTA_INIS"))
            lblcodiniS.Text = IIf(IsDBNull(Registro("NOM1")), "", Registro("NOM1"))
            txtcodiniD.Text = IIf(IsDBNull(Registro("CTA_INID")), "", Registro("CTA_INID"))
            lblcodiniD.Text = IIf(IsDBNull(Registro("NOM2")), "", Registro("NOM2"))
            txtcodiniletraS.Text = IIf(IsDBNull(Registro("CTA_INISL")), "", Registro("CTA_INISL"))
            lblcodiniletraS.Text = IIf(IsDBNull(Registro("NOM3")), "", Registro("NOM3"))
            txtcodiniletraD.Text = IIf(IsDBNull(Registro("CTA_INIDL")), "", Registro("CTA_INIDL"))
            lblcodiniletraD.Text = IIf(IsDBNull(Registro("NOM4")), "", Registro("NOM4"))
            cmbsigno.SelectedItem = IIf(IsDBNull(Registro("SIGNO")), "", Registro("SIGNO"))
        Next
    End Sub
    Private Sub Limpiar()
        txt_tipope.Text = ""
        cmb_tipope.SelectedIndex = -1
        chkafecto.Checked = False
        chkinafecto.Checked = False
        txtcodimpto.Text = ""
        cmb_codimpto.SelectedIndex = -1
        txtcodiniS.Text = ""
        lblcodiniS.Text = ""
        txtcodiniD.Text = ""
        lblcodiniD.Text = ""
        txtcodiniletraS.Text = ""
        lblcodiniletraS.Text = ""
        txtcodiniletraD.Text = ""
        lblcodiniletraD.Text = ""
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function

    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBCUENTA_OPBE As New ELTBCUENTA_OPBE

                ELTBCUENTA_OPBE.t_ope_cod = txt_tipope.Text
                ELTBCUENTA_OPBE.t_doc_cod = cmb_t_doc_cod.SelectedValue
                If (chkafecto.Checked = True) Then ELTBCUENTA_OPBE.status = "S" Else ELTBCUENTA_OPBE.status = "N"
                ELTBCUENTA_OPBE.impto_cod = txtcodimpto.Text
                ELTBCUENTA_OPBE.cta_inis = txtcodiniS.Text
                ELTBCUENTA_OPBE.cta_inid = txtcodiniD.Text
                ELTBCUENTA_OPBE.cta_inisl = txtcodiniletraS.Text
                ELTBCUENTA_OPBE.cta_inidl = txtcodiniletraD.Text
                ELTBCUENTA_OPBE.signo = cmbsigno.SelectedItem
                ELTBCUENTA_OPBE.anho = cmbaño.SelectedItem

                gsError = ELTBCUENTA_OPEBL.SaveRow(ELTBCUENTA_OPBE, flagAccion)
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
        If txt_tipope.Text = "" Then
            MsgBox("Ingrese Tipo de operación", MsgBoxStyle.Exclamation)
            txt_tipope.Focus()
            Return False
        End If

        If cmb_t_doc_cod.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo Documento", MsgBoxStyle.Exclamation)
            cmb_t_doc_cod.Focus()
            Return False
        End If

        If chkafecto.Checked = False And chkinafecto.Checked = False Then
            MsgBox("Seleccione un Status", MsgBoxStyle.Exclamation)
            cmb_t_doc_cod.Focus()
            Return False
        End If

        If txtcodimpto.Text = "" Then
            MsgBox("Ingrese el Cod. importe", MsgBoxStyle.Exclamation)
            txtcodimpto.Focus()
            Return False
        End If
        If flagAccion = "N" Then
            Dim afecto As String
            If chkafecto.Checked = True Then afecto = "S" Else afecto = "N"
            If ELTBCUENTA_OPEBL.VerificarRepetido(txt_tipope.Text, cmb_t_doc_cod.SelectedValue, afecto, txtcodimpto.Text) = True Then
                MsgBox("Ya Existe esta cuenta prefijada", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If
        Return True
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
    Private Sub cmb_codimpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_codimpto.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        Else
            txtcodimpto.Text = cmb_codimpto.SelectedValue
        End If
    End Sub
    Private Sub cmb_tipope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipope.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        Else
            txt_tipope.Text = cmb_tipope.SelectedValue
        End If
    End Sub


    Private Sub txt_tipope_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipope.KeyDown
        'If e.KeyValue = Keys.F9 or Key.f10 Then
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "48"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_tipope.Text = gLinea
                cmb_tipope.SelectedValue = gLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tipope_LostFocus(sender As Object, e As EventArgs) Handles txt_tipope.LostFocus
        If (txt_tipope.Text = "") Then
            cmb_tipope.SelectedValue = -1
        Else
            Dim dt As DataTable
            dt = ELTBREGISTRO_NROBL.SelectTipOpeCOD(DateTime.Now.ToString("yyyy"), txt_tipope.Text)
            If dt.Rows.Count > 0 Then
                txt_tipope.Text = dt.Rows(0).Item(0).ToString
                cmb_tipope.SelectedValue = dt.Rows(0).Item(0).ToString
            Else
                txt_tipope.Text = ""
                cmb_tipope.SelectedValue = -1
            End If
        End If
    End Sub
    Private Sub txtcodimpto_LostFocus(sender As Object, e As EventArgs) Handles txtcodimpto.LostFocus
        If (txtcodimpto.Text = "") Then
            cmb_codimpto.SelectedValue = -1
        Else
            Dim dt As DataTable
            dt = ELTBCUENTA_OPEBL.SelectTipImptoCOD(txtcodimpto.Text)
            If dt.Rows.Count > 0 Then
                txtcodimpto.Text = dt.Rows(0).Item(0).ToString
                cmb_codimpto.SelectedValue = dt.Rows(0).Item(0).ToString
            Else
                txtcodimpto.Text = ""
                cmb_codimpto.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub chkafecto_CheckedChanged(sender As Object, e As EventArgs) Handles chkafecto.CheckedChanged
        If chkafecto.Checked = True Then
            chkinafecto.Checked = False
        End If
    End Sub
    Private Sub chkinafecto_CheckedChanged(sender As Object, e As EventArgs) Handles chkinafecto.CheckedChanged
        If chkinafecto.Checked = True Then
            chkafecto.Checked = False
        End If
    End Sub

    Private Sub txtcodiniS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodiniS.KeyDown, txtcodiniD.KeyDown, txtcodiniletraS.KeyDown, txtcodiniletraD.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "54"
            Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()

            Select Case opcion
                Case 1
                    txtcodiniS.Text = gLinea
                    lblcodiniS.Text = gSubLinea
                Case 2
                    txtcodiniD.Text = gLinea
                    lblcodiniD.Text = gSubLinea
                Case 3
                    txtcodiniletraS.Text = gLinea
                    lblcodiniletraS.Text = gSubLinea
                Case 4
                    txtcodiniletraD.Text = gLinea
                    lblcodiniletraD.Text = gSubLinea
            End Select

            e.Handled = True
        End If
    End Sub

End Class