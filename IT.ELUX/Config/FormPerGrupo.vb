Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormPerGrupo
    Private gpCaption As String
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Private ELTBMANTENIMIENTOBL As New ELTBMANTENIMIENTOBL
    Dim gdtMainData As DataTable
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormPerGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sBusAlm = "3" Then
            Dim dt As DataTable
            dt = ELTBGRUPOBL.list2("")
            gdtMainData = dt
            dgvbusqueda.DataSource = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            tsbCamposSeek.SelectedIndex = 1
        ElseIf sBusAlm = "5" Then
            Dim dt As DataTable
            dt = ELTBGRUPOBL.list2("")
            gdtMainData = dt
            dgvbusqueda.DataSource = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            tsbCamposSeek.SelectedIndex = 1
        ElseIf sBusAlm = "2" Then
            Dim dt As DataTable
            dt = ELTBGRUPOBL.list2(Trim(gsCode10))
            gdtMainData = dt
            dgvbusqueda.DataSource = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            tsbCamposSeek.SelectedIndex = 1
        ElseIf sBusAlm = "6" Then
            Dim dt As DataTable
            dt = ELTBCAPACITACIONBL.list("")
            gdtMainData = dt
            dgvbusqueda.DataSource = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            tsbCamposSeek.SelectedIndex = 1
        ElseIf sBusAlm = "7" Then
            Dim dt As DataTable
            dt = ELTBMANTENIMIENTOBL.list("")
            gdtMainData = dt
            dgvbusqueda.DataSource = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            tsbCamposSeek.SelectedIndex = 1
        Else
            Dim dt As DataTable
            dt = ELTBGRUPOBL.list1()
            gdtMainData = dt
            dgvbusqueda.DataSource = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            tsbCamposSeek.SelectedIndex = 1
        End If
        'tsbCamposSeek.SelectedIndex = 0
        Me.ActiveControl = tsTextSearch.Control
    End Sub

    Private Sub FormPerGrupo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged

        If tsbCamposSeek.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = tsTextSearch.Text

        If sCode.Trim = "" Then
            dgvbusqueda.DataSource = gdtMainData
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor


        Dim dtNew As DataTable

        ' copy table structure
        dtNew = gdtMainData.Clone()

        'obtener nombre de campo
        Dim sCampo As String = tsbCamposSeek.Text

        'buscar valor del txt en dt
        Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " LIKE '%" & sCode & "%'")

        For Each ldrRow As DataRow In dataRows
            dtNew.ImportRow(ldrRow)
        Next
        dgvbusqueda.DataSource = dtNew
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        If sBusAlm = "1" Then
            Dim valor As Boolean
            If FormMantELTBGRUPO.dgvCaracteristica.Rows.Count > 0 Then
                For i = 0 To FormMantELTBGRUPO.dgvCaracteristica.Rows.Count - 1
                    If FormMantELTBGRUPO.dgvCaracteristica.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormMantELTBGRUPO.dgvCaracteristica.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value))
        ElseIf sBusAlm = "2" Then
            Dim valor As Boolean
            If FormELTBSTiem.dgvtiemper.Rows.Count > 0 Then
                For i = 0 To FormELTBSTiem.dgvtiemper.Rows.Count - 1
                    If FormELTBSTiem.dgvtiemper.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormELTBSTiem.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value))
        ElseIf sBusAlm = "3" Then
            FormHoraAsistencia.txtdni.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            FormHoraAsistencia.cmbdni.SelectedValue = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            Dispose()
        ElseIf sBusAlm = "4" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "5" Then
            'Dim valor As Boolean
            'If FormMantTurnoNoche.dgvdatos.Rows.Count > 0 Then
            '    For i = 0 To FormMantTurnoNoche.dgvdatos.Rows.Count - 1
            '        If FormMantTurnoNoche.dgvdatos.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
            '            valor = True
            '            MsgBox("Esta persona ya se encuentra listada, favor elija otra")
            '            Exit Sub
            '        End If
            '    Next
            'End If
            'FormMantTurnoNoche.dgvdatos.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value))
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "6" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            Dispose()
        ElseIf sBusAlm = "7" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
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
End Class