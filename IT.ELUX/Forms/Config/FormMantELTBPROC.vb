Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBPROC
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBPROCBL As New ELTBPROCBL
    Private ELTBREPOBL As New ELTBREPOBL
    Dim PRODUCCIONBL As New PRODUCCIONBL
    Private flagAccion As String = ""

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

        txtcodigo.Text = ELTBPROCBL.LastCodigo()
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
            MsgBox("Ingrese descripcion del proceso", MsgBoxStyle.Exclamation)
            txtdescri.Focus()
            Return False
        End If
        If npdunihora.Value = 0 Then
            MsgBox("Ingrese las unidades por hora", MsgBoxStyle.Exclamation)
            npdunihora.Focus()
            Return False
        End If
        If rdbfrac.Checked = False And rdbsec.Checked = False Then
            MsgBox("Seleccione el tipo de proceso", MsgBoxStyle.Exclamation)
            'txtdescri.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBPROCBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtdescri.Text = IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))
            cmbcodest.SelectedIndex = IIf(IsDBNull(Registro("EST")), -1, Registro("EST"))
            npdunihora.Value = IIf(IsDBNull(Registro("UNIDHORA")), 0, Registro("UNIDHORA"))
            If Trim(IIf(IsDBNull(Registro("TIPO")), -1, Registro("TIPO"))) = "1" Then
                rdbfrac.Checked = True
            ElseIf Trim(IIf(IsDBNull(Registro("TIPO")), -1, Registro("TIPO"))) = "2" Then
                rdbsec.Checked = True
            End If
            npdtpases.Value = IIf(IsDBNull(Registro("NPASES_PROC")), 0, Registro("NPASES_PROC"))
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
        Dim ELTBPROCBE As New ELTBPROCBE
        ELTBPROCBE.cod = RTrim(txtcodigo.Text)
        ELTBPROCBE.descripcion = RTrim(txtdescri.Text)
        ELTBPROCBE.est = IIf(cmbcodest.SelectedIndex = 0, "0", "1")
        If rdbfrac.Checked Then
            ELTBPROCBE.tipo = "1"
        ElseIf rdbsec.Checked Then
            ELTBPROCBE.tipo = "2"
        End If
        ELTBPROCBE.unidhora = npdunihora.Value
        ELTBPROCBE.npases_proc = npdtpases.Value
        'Recibe los parametros de la caracteristica y arma el catalogo
        Dim ELTBREPOBE As New ELTBREPOBE
        ELTBREPOBE.RPO_CODPROC = RTrim(txtcodigo.Text)
        ELTBREPOBE.CANTIDAD = npdunihora.Value
        ' ELTBREPOBE.CAN
        Dim fla As String = flagAccion
        If gsCode2 = "N" Then
            flagAccion = "N"
            txtcodigo.Text = ELTBPROCBL.LastCodigo()
            ELTBPROCBE.cod = RTrim(txtcodigo.Text)

        End If
        gsError2 = ELTBREPOBL.SaveRow(ELTBREPOBE, flagAccion, dgvCaracteristica, txtcodigo.Text)
        'Next
        gsError = ELTBPROCBL.SaveRow(ELTBPROCBE, flagAccion)

        If rdbfrac.Checked = True And dgvCaracteristica.Rows.Count > 0 Then
            Dim codOperacon = txtcodigo.Text
            Dim codProceso As String = ""
            Dim cantidad = 0
            For i = 0 To dgvCaracteristica.Rows.Count - 1
                codProceso = dgvCaracteristica.Rows(i).Cells(0).Value
                cantidad = dgvCaracteristica.Rows(i).Cells(3).Value
                PRODUCCIONBL.ActualizarProcesos(codOperacon, codProceso, cantidad)
            Next
        End If
        flagAccion = fla
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
        Dim ELTBPROCBE As New ELTBPROCBE
        ELTBPROCBE.cod = Trim(txtcodigo.Text)

        Dim dTable As New DataTable

        gsError = ELTBPROCBL.SaveRow(ELTBPROCBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub

    '   Private FunctionsBL As New FunctionsBL
    Private Sub FormELTBProcesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gsError = ""
        gsError2 = ""
        gpCaption = "Proceso"
        Me.Text = gpCaption
        txtcodigo.Enabled = False
        'Definir las columnas del grid
        dgvCaracteristica.Columns.Add("Columna_Codigo", "Codigo")
        dgvCaracteristica.Columns.Add("Caracteristicas", "Caracteristicas")
        dgvCaracteristica.Columns.Add("npases", "Numero_Pases")
        dgvCaracteristica.Columns.Add("unidhora", "Unid. x Hora")
        If estadoProduccion = "1" Then
            gnOpcion = 1
        End If
        'Opcion de Busqueda
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()

            Case 1
                flagAccion = "M"
                GetData(gsCode)
                Dim dt As New DataTable
                dt = ELTBREPOBL.SelectRow(txtcodigo.Text)
                'Recorre el data row para mostrar en el grid
                For Each row As DataRow In dt.Rows
                    dgvCaracteristica.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")), IIf(IsDBNull(row("OPERACIONES")), "", row("OPERACIONES")), IIf(IsDBNull(row("NPASES")), "", row("NPASES")),
                    IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA")))
                Next
                'Borra la caracteristica de la base de datos
                estadoProduccion = "0"

                dgvCaracteristica.Refresh()
        End Select

        If rdbfrac.Checked = True Then
            For i = 0 To dgvCaracteristica.Rows.Count - 1
                dgvCaracteristica.Rows(i).Cells("UNIDHORA").ReadOnly = False
                dgvCaracteristica.Rows(i).Cells("Columna_Codigo").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("npases").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("Caracteristicas").ReadOnly = True
            Next
        Else
            For i = 0 To dgvCaracteristica.Rows.Count - 1
                dgvCaracteristica.Rows(i).Cells("UNIDHORA").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("Columna_Codigo").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("npases").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("Caracteristicas").ReadOnly = True
            Next
        End If
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
           ' Case "delete"
           '     DeleteData()
            Case "exit"
                Dispose()
                Exit Sub
            Case "anular"
                If MessageBox.Show("Desea anular el documento",
                   "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim ELTBPROCBE As New ELTBPROCBE
                ELTBPROCBE.cod = RTrim(txtcodigo.Text)

                ''Dim ELMVLOGSBE As New ELMVLOGSBE
                ''ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELTBPROCBL.SaveRow(ELTBPROCBE, "A")
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

        End Select
    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        sNDoc = ""
        Dim frm As New FormMantELTBREPO
        gnOpcion2 = 2
        frm.ShowDialog()
        dgvCaracteristica.Refresh()
        npdtpases.Value = npdtpases.Value + sNDoc
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

    Private Sub FormELTBProcesos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub ActualizarProceso()
        Dim codigo = txtcodigo.Text
        Dim unidxhora = npdunihora.Value
        Try
            ELTBREPOBL.ActualizarUnidxHora(codigo, unidxhora)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdbfrac_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfrac.CheckedChanged
        If rdbfrac.Checked = True Then
            For i = 0 To dgvCaracteristica.Rows.Count - 1
                dgvCaracteristica.Rows(i).Cells("UNIDHORA").ReadOnly = False
                dgvCaracteristica.Rows(i).Cells("Columna_Codigo").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("npases").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("Caracteristicas").ReadOnly = True
            Next
        Else
            For i = 0 To dgvCaracteristica.Rows.Count - 1
                dgvCaracteristica.Rows(i).Cells("UNIDHORA").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("Columna_Codigo").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("npases").ReadOnly = True
                dgvCaracteristica.Rows(i).Cells("Caracteristicas").ReadOnly = True
            Next
        End If
    End Sub
End Class