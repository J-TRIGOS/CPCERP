Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBCATA
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBCATABL As New ELTBCATABL
    Private ELTBRECCBL As New ELTBRECCBL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

#Region "Ordenar"
    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    Private Sub dgvCaracteristica_DragDrop(ByVal sender As Object,
                                   ByVal e As DragEventArgs) _
                                   Handles dgvCaracteristica.DragDrop
        Dim p As Point = dgvCaracteristica.PointToClient(New Point(e.X, e.Y))
        dragIndex = dgvCaracteristica.HitTest(p.X, p.Y).RowIndex
        If dragIndex > -1 Then

            If (e.Effect = DragDropEffects.Move) Then
                Dim dragRow As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
                dgvCaracteristica.Rows.RemoveAt(fromIndex)
                dgvCaracteristica.Rows.Insert(dragIndex, dragRow)
            End If
        End If

    End Sub

    Private Sub dgvCaracteristica_DragOver(ByVal sender As Object,
                                   ByVal e As DragEventArgs) _
                                   Handles dgvCaracteristica.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    'The mouse events

    Private Sub dgvCaracteristica_MouseDown(ByVal sender As Object,
                                    ByVal e As MouseEventArgs) _
                                    Handles dgvCaracteristica.MouseDown
        fromIndex = dgvCaracteristica.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2),
                                       e.Y - (dragSize.Height / 2)),
                             dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub dgvCaracteristica_MouseMove(ByVal sender As Object,
                                    ByVal e As MouseEventArgs) _
                                    Handles dgvCaracteristica.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
    AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                dgvCaracteristica.DoDragDrop(dgvCaracteristica.Rows(fromIndex),
                               DragDropEffects.Move)
            End If
        End If
    End Sub
#End Region
    Private Sub CleanVar()

        txtcodigo.Text = ELTBCATABL.LastCodigo()
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

        dtUsuario = ELTBCATABL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("CAT_CODIGO")), "", Registro("CAT_CODIGO"))
            txtdescri.Text = IIf(IsDBNull(Registro("CAT_DESCRI")), "", Registro("CAT_DESCRI"))
            cmbcodest.SelectedIndex = IIf(IsDBNull(Registro("CAT_CODEST")), -1, Registro("CAT_CODEST"))
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
        'Manda los parameteros a los campos correspondientes del catalogo
        Dim ELTBCATABE As New ELTBCATABE
        ELTBCATABE.cat_codigo = RTrim(txtcodigo.Text)
        ELTBCATABE.cat_descri = RTrim(txtdescri.Text)
        ELTBCATABE.cat_codest = IIf(cmbcodest.SelectedIndex = 0, "0", "1")

        'Recibe los parametros de la caracteristica y arma el catalogo
        Dim ELTBRECCBE As New ELTBRECCBE
        ELTBRECCBE.rcc_codcat = RTrim(txtcodigo.Text)

        gsError2 = ELTBRECCBL.SaveRow(ELTBRECCBE, flagAccion, dgvCaracteristica, txtcodigo.Text)
        'Next
        gsError = ELTBCATABL.SaveRow(ELTBCATABE, flagAccion)
        If gsError = "OK" And gsError2 = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
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
        Dim ELTBCATABE As New ELTBCATABE
        ELTBCATABE.cat_codigo = Trim(txtcodigo.Text)

        Dim dTable As New DataTable

        gsError = ELTBCATABL.SaveRow(ELTBCATABE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FormMntUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gsError = ""
        gsError2 = ""
        gpCaption = "Catalogo"
        Me.Text = gpCaption
        txtcodigo.Enabled = False
        'Definir las columnas del grid
        dgvCaracteristica.Columns.Add("Columna_Codigo", "Codigo")
        dgvCaracteristica.Columns.Add("Caracteristicas", "Caracteristicas")
        'Opcion de Busqueda
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()

            Case 1
                flagAccion = "M"
                GetData(gsCode)
                Dim dt As New DataTable
                dt = ELTBRECCBL.SelectRow(txtcodigo.Text)
                'Recorre el data row para mostrar en el grid
                For Each row As DataRow In dt.Rows
                    dgvCaracteristica.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")), IIf(IsDBNull(row("CARACTERISTICAS")), "", row("CARACTERISTICAS")))
                Next
                'Borra la caracteristica de la base de datos


                dgvCaracteristica.Refresh()
        End Select
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
        Dim frm As New FormMantELTBRECC
        gnOpcion2 = 2
        frm.ShowDialog()
        dgvCaracteristica.Refresh()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvCaracteristica.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvCaracteristica.Rows.RemoveAt(dgvCaracteristica.CurrentRow.Index)
            dgvCaracteristica.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub FormMantELTBCATA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

End Class