Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantSublines
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELSUBLINESBL As New ELSUBLINESBL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()
        If gsCode3 < 1000 And gsCode3.Length <> 4 Then
            txtcodigo.Text = "0" & gsCode3
        Else
            txtcodigo.Text = gsCode3
        End If
        'ELSUBLINESBL.LastCodigo(Mid(gsCode, 1, 2))
        txtdescri.Clear()
        cmbcodest.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean

        If cmbcodest.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbcodest.Focus()
            Return False
        End If
        If txtdescri.Text = "" Then
            MsgBox("Ingrese descripcion de moneda", MsgBoxStyle.Exclamation)
            txtdescri.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode2 As String)
        Dim dt As DataTable
        Dim Registro As DataRow

        dt = ELSUBLINESBL.SelectRow(gsCode2)

        For Each Registro In dt.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("LIN_CODIGO")), "", Registro("LIN_CODIGO"))
            txtdescri.Text = IIf(IsDBNull(Registro("LIN_DESCRI")), "", Registro("LIN_DESCRI"))
            cmbcodest.SelectedIndex = IIf(IsDBNull(Registro("LIN_CODEST")), -1, Registro("LIN_CODEST"))
        Next

    End Sub

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If

        Dim ELSUBLINESBE As New ELSUBLINESBE
        'VER
        ELSUBLINESBE.lin_codigo = Trim(txtcodigo.Text)
        ELSUBLINESBE.lin_descri = RTrim(txtdescri.Text)
        ELSUBLINESBE.lin_codest = IIf(cmbcodest.SelectedIndex = 0, "0", "1")

        'gsError = ELSUBLINESBL.SaveRow(ELSUBLINESBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub


    Private Sub FormMntUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "SubLinea"
        Me.Text = gpCaption
        txtcodigo.Enabled = False
        'pSetButtons(tsbForm, gsCodeButton, True, {})
        'pSetPermisos(tsbForm, "Tab", gsCodTab, gpCodSis)

        Select Case gnOpcion2
            Case 0
                flagAccion = "N"
                CleanVar()
                'Dim frm As New FormMantELTBLINES
                'frm.dgvSublines.Refresh()

            Case 1
                flagAccion = "M"
                GetData(gsCode2)

        End Select

    End Sub


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If gnOpcion2 = 1 Then
            FormMantELTBLINES.dgvSublines.Rows(FormMantELTBLINES.dgvSublines.CurrentRow.Index).Cells(0).Value = txtcodigo.Text
            FormMantELTBLINES.dgvSublines.Rows(FormMantELTBLINES.dgvSublines.CurrentRow.Index).Cells(1).Value = txtdescri.Text
            FormMantELTBLINES.dgvSublines.Rows(FormMantELTBLINES.dgvSublines.CurrentRow.Index).Cells(2).Value = cmbcodest.SelectedItem
            Dispose()
        Else
            FormMantELTBLINES.dgvSublines.Rows.Add(txtcodigo.Text, txtdescri.Text, cmbcodest.SelectedItem)
            Dispose()
        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dispose()
    End Sub

    Private Sub FormMantSublines_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class