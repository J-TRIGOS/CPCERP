Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELPERIODO

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELPERIODOBL As New ELPERIODOBL
    Private ELTBTAREOBL As New ELTBTAREOBL

    Private Sub FormELPERIODO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                Deshabilitar(False)
                GetData(gsCode)
        End Select
    End Sub
    Sub Deshabilitar(ByVal F As Boolean)
        'txtper_cod.Enabled = F
        'txtprdo_cod.Enabled = F
        'chkactivar2.Checked = Not F
        'GroupBox2.Enabled = Not F
        'chkactivar.Checked = Not F
        'GroupBox1.Enabled = Not F
    End Sub
    Private Sub Limpiar()
        Dim a As Integer = DateTime.Now.Month
        lblcod.Text = ELPERIODOBL.SelectMaxPeriodo()
        cmb_mes.SelectedIndex = a - 1
        cmb_año.SelectedItem = DateTime.Now.ToString("yyyy")
        chkactivar.Checked = False
        GroupBox1.Enabled = False
        cmbt_personal.SelectedIndex = -1
        cmbproc.SelectedItem = "NO"
        dtpfec_pag.Value = DateSerial(Year(DateTime.Now), Month(DateTime.Now) + 1, 0)
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
                Dim ELPERIODOBE As New ELPERIODOBE
                ELPERIODOBE.cod = lblcod.Text
                ELPERIODOBE.nroant = ELPERIODOBE.cod - 1
                ELPERIODOBE.num = cmb_año.SelectedItem & cmb_mes.SelectedItem.ToString.Substring(0, 2)
                ELPERIODOBE.anho = cmb_año.SelectedItem
                ELPERIODOBE.nromes = cmb_mes.SelectedItem.ToString.Substring(0, 2)

                If chkactivar.Checked = False Then
                    ELPERIODOBE.fec_ini = Nothing
                    ELPERIODOBE.fec_fin = Nothing
                Else
                    ELPERIODOBE.fec_ini = dtpfec_ini.Value
                    ELPERIODOBE.fec_fin = dtpfec_fin.Value
                End If

                ELPERIODOBE.fec_pag = dtpfec_pag.Value
                If cmbt_personal.SelectedIndex = -1 Then
                    ELPERIODOBE.t_per_cod = ""
                Else
                    ELPERIODOBE.t_per_cod = (cmbt_personal.SelectedIndex + 1).ToString.PadLeft(3, "0")
                End If

                If cmbproc.SelectedIndex = 0 Then
                    ELPERIODOBE.x_cont = "N"
                Else
                    ELPERIODOBE.x_cont = "S"
                End If

                gsError = ELPERIODOBL.SaveRow(ELPERIODOBE, flagAccion)
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

        If flagAccion = "N" Then
            If ELPERIODOBL.VerificarRepetido(cmb_año.SelectedItem, cmb_mes.SelectedItem.ToString.Substring(0, 2)) = True Then
                MsgBox("Ya existe el Periodo para este año y mes", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPERIODOBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows
            lblcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            cmb_año.SelectedItem = IIf(IsDBNull(Registro("AÑO")), "", Registro("AÑO"))
            cmb_mes.SelectedIndex = CInt(Registro("MES")) - 1

            If IsDBNull(Registro("F_INICIO")) Then
                dtpfec_ini.Value = DateTime.Now
                dtpfec_fin.Value = DateTime.Now
                chkactivar.Checked = False
                GroupBox1.Enabled = False
            Else
                dtpfec_ini.Value = Registro("F_INICIO")
                dtpfec_fin.Value = Registro("F_FINAL")
                chkactivar.Checked = True
                GroupBox1.Enabled = True
            End If

            If IsDBNull(Registro("T_PERSONAL")) Then
                cmbt_personal.SelectedIndex = -1
            Else
                cmbt_personal.SelectedItem = Registro("T_PERSONAL")
            End If
            cmbproc.SelectedItem = IIf(IsDBNull(Registro("PROCESADO")), "", Registro("PROCESADO"))
            dtpfec_pag.Value = IIf(IsDBNull(Registro("F_PAGO")), "", Registro("F_PAGO"))

        Next
    End Sub
    Private Sub chkactivar_CheckedChanged(sender As Object, e As EventArgs) Handles chkactivar.CheckedChanged
        If chkactivar.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub FormELPERIODO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class