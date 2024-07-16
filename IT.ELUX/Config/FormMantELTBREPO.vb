Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBREPO
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBOPERBL As New ELTBOPERBL
    Private flagAccion As String = ""
    Private Sub CleanVar()

        txtcodigo.Clear()
        cmbdescripcion.SelectedIndex = -1
    End Sub


    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBOPERBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            cmbdescripcion.SelectedIndex = IIf(IsDBNull(Registro("DESCRIPCION")), -1, Registro("DESCRIPCION"))
        Next

    End Sub
    Private Sub GetCmb()
        Dim dtUsuario As DataTable
        'Dim Registro As DataRow

        dtUsuario = ELTBOPERBL.SelectDescripcion()

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

    Private Sub FormMantELTBREPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "Operaciones"
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
            sNDoc = npdpases.Value
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'Agregar los datos al grid
        FormMantELTBPROC.dgvCaracteristica.Rows.Add(txtcodigo.Text, cmbdescripcion.Text, npdpases.Value)
        Dispose()
    End Sub

    Private Sub FormMantELTBRECC_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose()
    End Sub
End Class