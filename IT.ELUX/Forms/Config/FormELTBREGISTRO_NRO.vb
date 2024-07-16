Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormELTBREGISTRO_NRO
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBREGISTRO_NROBL As New ELTBREGISTRO_NROBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sSec As String
    Private MenuBL As New MenuBL
    Public boton As String

    Private Sub FormELTBREGISTRO_NRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        'Cargar los combos
        Dim dt As DataTable
        dt = ELTBREGISTRO_NROBL.SelectTipOpe(DateTime.Now.ToString("yyyy"))
        GetCmb("cod", "nom", dt, cmb_tipope)
        cmb_tipope.SelectedIndex = -1

        dt = ELTBREGISTRO_NROBL.SelectPrefBanco()
        GetCmb("cod", "nom", dt, cmb_prefBanco)
        cmb_prefBanco.SelectedIndex = -1
        bPrimero = False
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                habilItar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc, gArt)
                habilItar(False)
        End Select
    End Sub
    Private Sub habilitar(ByVal F As Boolean)
        cmb_año.Enabled = F
        cmb_mes.Enabled = F
        cmb_tipope.Enabled = F
        txt_tipope.Enabled = F
        cmb_prefBanco.Enabled = F
        txt_prefBanco.Enabled = F
    End Sub
    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal gArt As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBREGISTRO_NROBL.SelectRow(sTDoc, sSDoc, sNDoc, gArt)
        For Each Registro In dtUsuario.Rows
            cmb_año.SelectedItem = sTDoc
            cmb_mes.SelectedIndex = sSDoc - 1
            txt_tipope.Text = sNDoc
            cmb_tipope.SelectedValue = sNDoc
            txt_prefBanco.Text = gArt
            cmb_prefBanco.SelectedValue = gArt
            txtnro_reg.Text = IIf(IsDBNull(Registro("REG_NRO")), "", Registro("REG_NRO"))
        Next
    End Sub
    Private Sub Limpiar()
        Dim a As Integer = DateTime.Now.Month
        cmb_tipope.SelectedIndex = -1
        txt_tipope.Text = ""
        cmb_mes.SelectedIndex = a - 1
        cmb_prefBanco.SelectedIndex = -1
        txt_prefBanco.Text = ""
        cmb_año.SelectedItem = DateTime.Now.ToString("yyyy")
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
                Dim ELTBREGISTRO_NROBE As New ELTBREGISTRO_NROBE
                ELTBREGISTRO_NROBE.anho = cmb_año.SelectedItem
                ELTBREGISTRO_NROBE.mes = cmb_mes.SelectedItem.ToString.Substring(0, 2)
                ELTBREGISTRO_NROBE.t_ope_cod = cmb_tipope.SelectedValue
                ELTBREGISTRO_NROBE.pref_bco = cmb_prefBanco.SelectedValue
                ELTBREGISTRO_NROBE.reg_nro = txtnro_reg.Text

                gsError = ELTBREGISTRO_NROBL.SaveRow(ELTBREGISTRO_NROBE, flagAccion)
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
            MsgBox("Ingrese tipo de operación", MsgBoxStyle.Exclamation)
            txt_tipope.Focus()
            Return False
        End If
        If txt_prefBanco.Text = "" Then
            MsgBox("Ingrese tipo de prefico banco", MsgBoxStyle.Exclamation)
            txt_prefBanco.Focus()
            Return False
        End If
        If txtnro_reg.Text = "" Then
            MsgBox("Ingrese el nro de registro", MsgBoxStyle.Exclamation)
            txtnro_reg.Focus()
            Return False
        End If
        If flagAccion = "N" Then
            If ELTBREGISTRO_NROBL.VerificarRepetido(cmb_año.SelectedItem, cmb_mes.SelectedItem.ToString.Substring(0, 2), txt_tipope.Text, txt_prefBanco.Text) = True Then
                MsgBox("Ya Existe el registro con estos datos", MsgBoxStyle.Exclamation)
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
    Private Sub cmb_tipope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipope.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        Else
            txt_tipope.Text = cmb_tipope.SelectedValue
            If flagAccion = "N" And cmb_prefBanco.SelectedIndex > 0 Then
                If (cmb_prefBanco.SelectedValue = "$") Then
                    txtnro_reg.Text = cmb_año.SelectedItem.Substring(2, 2) & cmb_mes.SelectedItem.ToString.Substring(0, 2) & "0001"
                Else
                    txtnro_reg.Text = cmb_año.SelectedItem.Substring(2, 2) & cmb_mes.SelectedItem.ToString.Substring(0, 2) & cmb_prefBanco.SelectedValue & "0001"
                End If
            End If
        End If
    End Sub
    Private Sub cmb_prefBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prefBanco.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        Else
            txt_prefBanco.Text = cmb_prefBanco.SelectedValue
            If flagAccion = "N" Then
                If (cmb_prefBanco.SelectedValue = "$") Then
                    txtnro_reg.Text = cmb_año.SelectedItem.Substring(2, 2) & cmb_mes.SelectedItem.ToString.Substring(0, 2) & "0001"
                Else
                    txtnro_reg.Text = cmb_año.SelectedItem.Substring(2, 2) & cmb_mes.SelectedItem.ToString.Substring(0, 2) & cmb_prefBanco.SelectedValue & "0001"
                End If
            End If
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

    Private Sub txt_prefBanco_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_prefBanco.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "49"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_prefBanco.Text = gLinea
                cmb_prefBanco.SelectedValue = gLinea
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
    Private Sub txt_prefBanco_LostFocus(sender As Object, e As EventArgs) Handles txt_prefBanco.LostFocus
        If (txt_prefBanco.Text = "") Then
            cmb_prefBanco.SelectedValue = -1
        Else
            Dim dt As DataTable
            dt = ELTBREGISTRO_NROBL.SelectPrefBancoCOD(txt_prefBanco.Text)
            If dt.Rows.Count > 0 Then
                txt_prefBanco.Text = dt.Rows(0).Item(0).ToString
                cmb_prefBanco.SelectedValue = dt.Rows(0).Item(0).ToString
            Else
                txt_prefBanco.Text = ""
                cmb_prefBanco.SelectedValue = -1
            End If
        End If
    End Sub
End Class