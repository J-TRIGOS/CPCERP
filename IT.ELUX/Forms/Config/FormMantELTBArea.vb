Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBArea
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBAREABL As New ELTBAREABL
    Private ELTBREAPBL As New ELTBREAPBL
    Private ARTICULOBL As New ARTICULOBL
    Private flagAccion As String = ""
    Private bPrimero As Boolean = True
    Dim s As String = ""
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

#Region "Llenar combos"

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region

    Private Sub CleanVar()
        txtcod.Text = ELTBAREABL.LastCodigo()
        txtdescripcion.Clear()
        cmbestado.SelectedIndex = -1
        cmbccosto.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese descripcion de moneda", MsgBoxStyle.Exclamation)
            txtdescripcion.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBAREABL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtdescripcion.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            Select Case Registro("SITUACION").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
            End Select
            cmbccosto.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), -1, Registro("CCO_COD"))
            txtcco_cod.Text = cmbccosto.SelectedValue
        Next
    End Sub

    Private Sub SaveData()
        If s = "1" Then
            If MessageBox.Show("Desea grabar el Registro",
                  "IT.ELUX", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
        End If

        If OkData() = False Then
            Exit Sub
        End If
        'Manda los parameteros a los campos correspondientes del catalogo
        Dim ELTBAREABE As New ELTBAREABE
        'ELTBAREABE.cod = RTrim(txtcod.Text)
        'ELTBAREABE.nom = RTrim(txtdescripcion.Text)
        'ELTBAREABE.situacion = IIf(cmbestado.SelectedIndex = 0, "H", "A")
        ELTBAREABE.cco_cod = cmbccosto.SelectedValue
        'Recibe los parametros de la caracteristica y arma el catalogo
        Dim ELTBREAPBE As New ELTBREAPBE
        ELTBREAPBE.COD_AREA = RTrim(txtcod.Text)

        gsError2 = ELTBREAPBL.SaveRow(ELTBREAPBE, flagAccion, dgvCaracteristica, txtcod.Text)
        'Next
        gsError = ELTBAREABL.SaveRow(ELTBAREABE, flagAccion, dgvarea)
        If gsError = "OK" And gsError2 = "OK" Then
            If s = "1" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Dispose()
            End If
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
        Dim ELTBAREABE As New ELTBAREABE
        ELTBAREABE.cod = Trim(txtcod.Text)

        Dim dTable As New DataTable

        gsError = ELTBAREABL.SaveRow(ELTBAREABE, flagAccion, dgvarea)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FormMantELTBArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvarea.Columns.Add("COD", "Codigo")
        dgvarea.Columns.Add("NOM", "Nom. Area")
        dgvarea.Columns.Add("EST", "Estado")

        gsError = ""
        gsError2 = ""
        'bPrimero = True
        gpCaption = "Linea C. Costo"
        Me.Text = gpCaption
        txtcod.Enabled = False
        Dim dt As DataTable
        dt = ARTICULOBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbccosto)
        'Definir las columnas del grid
        dgvCaracteristica.Columns.Add("Columna_Codigo", "Codigo")
        dgvCaracteristica.Columns.Add("Caracteristicas", "Caracteristicas")
        bPrimero = False
        'Opcion de Busqueda
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                'cmbccosto.SelectedIndex = -1
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                'Dim dt As New DataTable
                'dt = ELTBREAPBL.SelectRow(txtcod.Text)
                ''Recorre el data row para mostrar en el grid
                'For Each row As DataRow In dt.Rows
                '    dgvCaracteristica.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")), IIf(IsDBNull(row("PROCESOS")), "", row("PROCESOS")))
                'Next
                dt = ELTBREAPBL.SelAreaCCO(txtcco_cod.Text)
                Dim es As String = ""
                For Each row As DataRow In dt.Rows
                    If IIf(IsDBNull(row("EST")), "", row("EST")) = "H" Then
                        es = "Activo"
                    Else
                        es = "Inactivo"
                    End If
                    dgvarea.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")), IIf(IsDBNull(row("NOM")), "", row("NOM")), es)
                Next
                cmbccosto.Enabled = False
                txtcco_cod.ReadOnly = True
                dgvCaracteristica.Refresh()
        End Select

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

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If
        Select Case sFunc

            Case "save"
                s = "1"
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
        Dim frm As New FormMantELTBREAP
        gnOpcion2 = 2
        frm.ShowDialog()
        dgvCaracteristica.Refresh()
    End Sub

    Private Sub FormMantELTBArea_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub cmbccosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccosto.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbccosto.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtcco_cod.Text = cmbccosto.SelectedValue
    End Sub

    Private Sub txtcco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcco_cod.LostFocus
        If txtcco_cod.Text = "" Then
            cmbccosto.SelectedIndex = -1
            Exit Sub
        End If
        cmbccosto.SelectedValue = txtcco_cod.Text
        If cmbccosto.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtcco_cod.Text = ""
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            cmbccosto.SelectedValue = gLinea
            gLinea = Nothing
        End If
    End Sub

    Private Sub btnborrar1_Click(sender As Object, e As EventArgs) Handles btnborrar1.Click
        If dgvarea.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If

            dgvarea.Rows.RemoveAt(dgvarea.CurrentRow.Index)
            dgvarea.Refresh()
            SaveData()
            s = ""
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnagregar1.Click
        'txtcco_cod.ReadOnly = True
        'cmbccosto.Enabled = False
        'txtdescripcion.ReadOnly = False
        'cmbestado.SelectedIndex = 0
        'txtdescripcion.Text = ""
        'txtcod.Text = ELTBAREABL.LastCodigo()
        'btnmodificar1.Enabled = True
        'gsCode11 = "1"

        If txtcco_cod.TextLength = 0 Then
            MsgBox("Debe seleccionar un centro de Costo")
            txtcco_cod.Select()
            Exit Sub
        End If
        Dim frm As New FormDetMantArea
        Dim es As String
        gsCode7 = "N"
        gsCode6 = txtcco_cod.Text
        'frm.txtcod.Text = ELTBAREABL.LastCodigo()
        frm.ShowDialog()
        dgvarea.Rows.Clear()
        Dim dt As DataTable
        dt = ELTBREAPBL.SelAreaCCO(txtcco_cod.Text)
        For Each row As DataRow In dt.Rows
            If IIf(IsDBNull(row("EST")), "", row("EST")) = "H" Then
                es = "Activo"
            Else
                es = "Inactivo"
            End If
            dgvarea.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")), IIf(IsDBNull(row("NOM")), "", row("NOM")), es)
        Next
        gsCode7 = ""
        gsCode6 = ""
    End Sub

    Private Sub btnagregar1_Click(sender As Object, e As EventArgs)
        Dim frm As New FormDetMantArea
        Dim es As String
        frm.txtcod.Enabled = False
        If dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("EST").Value = "Activo" Then
            frm.cmbestado.SelectedIndex = 0
        Else
            frm.cmbestado.SelectedIndex = 1
        End If
        gsCode6 = txtcco_cod.Text
        frm.txtcod.Text = dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("COD").Value
        frm.txtdescripcion.Text = dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("NOM").Value
        gsCode7 = "M"
        frm.ShowDialog()
        dgvarea.Rows.Clear()
        Dim dt As DataTable
        dt = ELTBREAPBL.SelAreaCCO(txtcco_cod.Text)
        For Each row As DataRow In dt.Rows
            If IIf(IsDBNull(row("EST")), "", row("EST")) = "H" Then
                es = "Activo"
            Else
                es = "Inactivo"
            End If
            dgvarea.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")), IIf(IsDBNull(row("NOM")), "", row("NOM")), es)
        Next
        gsCode6 = ""
        gsCode7 = ""
        'Dim es As String
        'Dim c As Integer = 0
        'If cmbestado.SelectedIndex <> -1 Or txtdescripcion.TextLength > 0 Then
        '    If cmbestado.SelectedIndex = 0 Then
        '        es = "Activo"
        '    Else
        '        es = "Inactivo"
        '    End If
        '    If flagAccion = "N" Then
        '        dgvarea.Rows.Add(txtcod.Text, txtdescripcion.Text, es)
        '    Else
        '        If gsCode11 = "1" Then
        '            If dgvarea.Rows.Count >= 1 Then
        '                For i = 0 To dgvarea.Rows.Count - 1
        '                    If dgvarea.Rows(i).Cells("COD").Value >= ELTBAREABL.LastCodigo() Then
        '                        c = c + 1
        '                        txtcod.Text = ELTBAREABL.LastCodigo() + c
        '                        txtcod.Text = txtcod.Text.PadLeft(4, "0")
        '                    End If
        '                Next
        '                dgvarea.Rows.Add(txtcod.Text, txtdescripcion.Text, es)
        '            Else
        '                dgvarea.Rows.Add(txtcod.Text, txtdescripcion.Text, es)
        '                gsCode = ""
        '            End If

        '        Else
        '            dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("COD").Value = txtcod.Text
        '            dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("NOM").Value = txtdescripcion.Text
        '            dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("EST").Value = es
        '        End If
        '    End If
        '    btnmodificar1.Enabled = False
        'Else

        'End If
    End Sub

    Private Sub dgvarea_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvarea.CellMouseDoubleClick
        txtcod.Text = dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("COD").Value
        txtdescripcion.Text = dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("NOM").Value
        If dgvarea.Rows(dgvarea.CurrentRow.Index).Cells("EST").Value = "Activo" Then
            cmbestado.SelectedIndex = 0
        Else
            cmbestado.SelectedIndex = 1
        End If
    End Sub
End Class