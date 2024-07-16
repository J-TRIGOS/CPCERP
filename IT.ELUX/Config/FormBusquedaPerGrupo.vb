Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormBusquedaPerGrupo
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private gdtMainData As DataTable
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormBusquedaPerGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = ELTBGRUPOBL.listgrupo
        GetCmb("cod", "nom", dt, cmbcosto)
        cmbccosto.Items.Add("")
        For i = 0 To cmbcosto.Items.Count - 1
            cmbcosto.SelectedIndex = i
            cmbccosto.Items.Add(cmbcosto.Text)
        Next
        'Cursor.Current = Cursors.WaitCursor
        ''Dim dt As DataTable
        'If sBusAlm = "1" Then
        '    dt = ELTBGRUPOBL.SearhDetGrup("")
        '    dgvbusqueda.DataSource = dt
        '    dgvbusqueda.Refresh()
        '    gdtMainData = dt
        '    tsbCamposSeek.Items.Clear()
        '    'get columns of DGV
        '    For Each col As DataGridViewColumn In dgvbusqueda.Columns
        '        ' MessageBox.Show(col.Name)
        '        tsbCamposSeek.Items.Add(col.Name)
        '    Next
        '    Cursor.Current = Cursors.Default
        '    'limpiar busqueda
        '    lblRecNo.Text = dgvbusqueda.Rows.Count
        '    'dgv color
        '    dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        '    dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
        '    dgvbusqueda.EnableHeadersVisualStyles = False
        'End If
        'tsbCamposSeek.SelectedIndex = 3
        'Me.ActiveControl = tsTextSearch.Control
    End Sub

    Private Sub FormBusquedaPerGrupo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    'Private Sub cmbccosto_Click(sender As Object, e As EventArgs) Handles cmbccosto.Click

    'End Sub

    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged
        If tsbCamposSeek.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = tsTextSearch.Text

        If sCode.Trim = "" Then
            dgvbusqueda.DataSource = gdtMainData
            lblRecNo.Text = dgvbusqueda.Rows.Count
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor


        Dim dtNew As DataTable

        ' copy table structure
        dtNew = gdtMainData.Clone()

        'obtener nombre de campo
        Dim sCampo As String = tsbCamposSeek.Text

        'buscar valor del txt en dt
        Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '%" & sCode & "%'")

        For Each ldrRow As DataRow In dataRows
            dtNew.ImportRow(ldrRow)
        Next
        dgvbusqueda.DataSource = dtNew

        lblRecNo.Text = dgvbusqueda.Rows.Count

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub cmbccosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccosto.SelectedIndexChanged
        Dim dt As DataTable
        dgvbusqueda.DataSource = Nothing
        If sBusAlm = "1" Then
            If cmbccosto.SelectedIndex <> 0 Then
                dt = ELTBGRUPOBL.SearhDetGrup(Mid(cmbccosto.Text, 1, 4))
                dgvbusqueda.DataSource = dt
                dgvbusqueda.Refresh()
                gdtMainData = dt
                tsbCamposSeek.Items.Clear()
                'get columns of DGV
                For Each col As DataGridViewColumn In dgvbusqueda.Columns
                    ' MessageBox.Show(col.Name)
                    tsbCamposSeek.Items.Add(col.Name)
                Next
                Cursor.Current = Cursors.Default
                'limpiar busqueda
                lblRecNo.Text = dgvbusqueda.Rows.Count
                'dgv color
                dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.EnableHeadersVisualStyles = False
            Else
                tsbCamposSeek.Items.Clear()
            End If
        End If
        If dgvbusqueda.Rows.Count <> 0 Then
            If cmbccosto.SelectedIndex <> 0 Then
                tsbCamposSeek.SelectedIndex = 3
                Me.ActiveControl = tsTextSearch.Control
            Else
                tsbCamposSeek.SelectedIndex = -1
            End If
        End If

    End Sub
    Private Sub tsTextSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tsTextSearch.KeyDown
        If e.KeyValue = Keys.Down Then
            dgvbusqueda.Select()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub
    Private Sub dgvbusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvbusqueda.KeyDown
        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        If sBusAlm = "1" Then
            'gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dim valor As Boolean
            If FormELTBSTiem.dgvtiemper.Rows.Count > 0 Then
                For i = 0 To FormELTBSTiem.dgvtiemper.Rows.Count - 1
                    If FormELTBSTiem.dgvtiemper.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value Then
                        valor = True
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormELTBSTiem.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val As String = ""
        If sBusAlm = "1" Then
            'gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dim valor As Boolean
            If FormELTBSTiem.dgvtiemper.Rows.Count > 0 Then
                For j = 0 To dgvbusqueda.Rows.Count - 1
                    For i = 0 To FormELTBSTiem.dgvtiemper.Rows.Count - 1
                        If FormELTBSTiem.dgvtiemper.Rows(i).Cells(0).Value = dgvbusqueda.Rows(j).Cells(2).Value Then
                            val = "1"
                        End If
                    Next
                    If val <> "1" Then
                        FormELTBSTiem.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(2).Value), "", dgvbusqueda.Rows(j).Cells(2).Value), IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(3).Value), "", dgvbusqueda.Rows(j).Cells(3).Value))
                    Else
                        val = ""
                    End If
                Next
            Else
                For i = 0 To dgvbusqueda.Rows.Count - 1
                    FormELTBSTiem.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(2).Value), "", dgvbusqueda.Rows(i).Cells(2).Value), IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(3).Value), "", dgvbusqueda.Rows(i).Cells(3).Value))
                Next
            End If

        End If
    End Sub
End Class