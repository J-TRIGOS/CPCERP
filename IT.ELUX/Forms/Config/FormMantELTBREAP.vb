Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBREAP
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBPROCBL As New ELTBPROCBL
    Private flagAccion As String = ""
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()

        txtcodigo.Clear()
        cmbdescripcion.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean

        If cmbdescripcion.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbdescripcion.Focus()
            Return False
        End If
        If cmbdescripcion.Text = "" Then
            MsgBox("Ingrese descripcion de moneda", MsgBoxStyle.Exclamation)
            cmbdescripcion.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBPROCBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("RCC_CODCAT")), "", Registro("RCC_CODCAT"))
            cmbdescripcion.SelectedIndex = IIf(IsDBNull(Registro("RCC_CODCAR")), -1, Registro("RCC_CODCAR"))
        Next

    End Sub
    Private Sub GetCmb()
        Dim dtUsuario As DataTable
        'Dim Registro As DataRow

        dtUsuario = ELTBPROCBL.SelectDescripcion()

        For Each Registro In dtUsuario.Rows
            cmbdescripcion.DataSource = dtUsuario
            cmbdescripcion.DisplayMember = dtUsuario.Columns(0).ColumnName
            cmbdescripcion.ValueMember = dtUsuario.Columns(1).ColumnName
            cmbdescripcion.SelectedIndex = -1
            txtcodigo.Clear()
        Next

    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dispose()
    End Sub
    '   Private FunctionsBL As New FunctionsBL
    Private Sub FormMantELTBREAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "Proceso"
        Me.Text = gpCaption
        txtcodigo.Enabled = False
        'pSetButtons(tsbForm, gsCodeButton, True, {})
        'pSetPermisos(tsbForm, "Tab", gsCodTab, gpCodSis)

        Select Case gnOpcion2
            Case 0
                flagAccion = "N"
                CleanVar()
            Case 1
                flagAccion = "M"
                GetData(gsCode)
            Case 2
                flagAccion = "C"
                GetCmb()

        End Select
    End Sub
    Private Sub cmbdescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdescripcion.SelectedIndexChanged
        If cmbdescripcion.SelectedIndex <> -1 Then
            txtcodigo.Text = cmbdescripcion.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'Agregar los datos al grid
        FormMantELTBArea.dgvCaracteristica.Rows.Add(txtcodigo.Text, cmbdescripcion.Text)
        Dispose()
    End Sub

    Private Sub FormMantELTBRECC_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose()
    End Sub

    Private Sub FormMantELTBREAP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class