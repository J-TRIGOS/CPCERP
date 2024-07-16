Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBLINES
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELSUBLINESBL As New ELSUBLINESBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()

        txtcodigo.Text = ELTBLINESBL.LastCodigo()
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

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBLINESBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
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

        Dim ELTBLINESBE As New ELTBLINESBE
        ELTBLINESBE.lin_codigo = RTrim(txtcodigo.Text)
        ELTBLINESBE.lin_descri = RTrim(txtdescri.Text)
        ELTBLINESBE.lin_codest = IIf(cmbcodest.SelectedIndex = 0, "0", "1")

        Dim ELSUBLINESBE As New ELSUBLINESBE
        'VER
        ELSUBLINESBE.lin_codigo = RTrim(txtcodigo.Text)
        gsError2 = ELSUBLINESBL.SaveRow(ELSUBLINESBE, flagAccion, dgvSublines)

        gsError = ELTBLINESBL.SaveRow(ELTBLINESBE, flagAccion)
        If gsError = "OK" And gsError2 = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub DeleteData()

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        flagAccion = "E"
        Dim ELTBLINESBE As New ELTBLINESBE
        ELTBLINESBE.lin_codigo = Trim(txtcodigo.Text)

        'Dim dTable As New DataTable

        gsError = ELTBLINESBL.SaveRow(ELTBLINESBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub DeleteDataSubLine(ByVal ssubline As String)

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        flagAccion = "S"
        Dim ELTBLINESBE As New ELTBLINESBE
        ELTBLINESBE.lin_codigo = ssubline


        gsError = ELTBLINESBL.SaveRow(ELTBLINESBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            ' Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormMntELTBLINES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "Lineas"
        Me.Text = gpCaption
        txtcodigo.Enabled = False
        dgvSublines.Columns.Add("LIN_CODIGO", "Codigo")
        dgvSublines.Columns.Add("LIN_DESCRI", "Caracteristicas")
        dgvSublines.Columns.Add("LIN_CODEST", "Estado")
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                Dim dt As New DataTable
                dt = ELSUBLINESBL.SelectAll(Mid(Me.txtcodigo.Text, 1, 2))
                'Recorre el data row para mostrar en el grid
                For Each row As DataRow In dt.Rows
                    dgvSublines.Rows.Add(IIf(IsDBNull(row("LIN_CODIGO")), "", row("LIN_CODIGO")), IIf(IsDBNull(row("LIN_DESCRI")), "", row("LIN_DESCRI")), IIf(IsDBNull(row("LIN_CODEST")), "", row("LIN_CODEST")))
                Next
                'Borra la caracteristica de la base de datos


                dgvSublines.Refresh()
        End Select

        'Dim dt As New DataTable
        'dt = ELSUBLINESBL.SelectAll(Mid(Me.txtcodigo.Text, 1, 2))
        'dgvSublines.DataSource = dt
        'dgvSublines.Refresh()
    End Sub

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
                DeleteData()

            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim frm As New FormMantSublines
        gnOpcion2 = 0
        'dgvSublines.Refresh()
        Dim valorMaximo As Integer = 0


        For Each row As DataGridViewRow In dgvSublines.Rows
            If Not row.IsNewRow Then
                If Convert.ToInt32(row.Cells("LIN_CODIGO").Value) > valorMaximo Then
                    valorMaximo = Convert.ToInt32(row.Cells("LIN_CODIGO").Value)
                End If
            End If
        Next
        If dgvSublines.Rows.Count = 0 Then
            gsCode3 = Mid(txtcodigo.Text, 1, 2) & 0 & (valorMaximo + 1)
        Else
            gsCode3 = valorMaximo + 1 'dgvSublines.Rows.Count + 1

        End If
        frm.ShowDialog()
        'Dim dt As New DataTable
        'dt = ELSUBLINESBL.SelectAll(Mid(Me.txtcodigo.Text, 1, 2))
        'dgvSublines.DataSource = dt
        dgvSublines.Refresh()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'Modifica entrando a la sub linea ya realiza el cambio
        Dim frm As New FormMantSublines
        gsCode2 = dgvSublines.Rows(dgvSublines.CurrentRow.Index).Cells(0).Value
        gnOpcion2 = 1
        frm.ShowDialog()
        gnOpcion2 = Nothing
        Dim dt As New DataTable
        'dgvSublines.DataSource = Nothing
        'dt = ELSUBLINESBL.SelectAll(Mid(Me.txtcodigo.Text, 1, 2))
        'dgvSublines.DataSource = dt

        dgvSublines.Refresh()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvSublines.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvSublines.Rows.RemoveAt(dgvSublines.CurrentRow.Index)
            dgvSublines.Refresh()
        Else
            MsgBox("No hay datos")
        End If
        'DeleteDataSubLine(dgvSublines.Rows(dgvSublines.CurrentRow.Index).Cells(0).Value)
        'Dim dt As New DataTable
        'dt = ELSUBLINESBL.SelectAll(Mid(Me.txtcodigo.Text, 1, 2))
        'dgvSublines.DataSource = dt
        'dgvSublines.Refresh()
    End Sub

    Private Sub FormMantELTBLINES_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class