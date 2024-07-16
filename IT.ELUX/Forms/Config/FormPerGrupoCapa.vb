Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormPerGrupoCapa
    Private ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Private gdtMainData As DataTable

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormPerGrupoCapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = ELTBCAPACITACIONBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbcosto)
        cmbccosto.Items.Add("")
        For i = 0 To cmbcosto.Items.Count - 1
            cmbcosto.SelectedIndex = i
            cmbccosto.Items.Add(cmbcosto.Text)
        Next
        'Dim dt As DataTable
        dt = ELTBCAPACITACIONBL.list(Trim(gsCode10))
        gdtMainData = dt
        dgvbusqueda.DataSource = dt
        'dgvbusqueda.Refresh()
        tsbCamposSeek.Items.Clear()
        'get columns of DGV
        For Each col As DataGridViewColumn In dgvbusqueda.Columns
            ' MessageBox.Show(col.Name)
            tsbCamposSeek.Items.Add(col.Name)
        Next
        Cursor.Current = Cursors.Default
        tsbCamposSeek.SelectedIndex = 1
        cmbcosto.SelectedValue = gsCode10
        cmbccosto.Text = cmbcosto.Text

        Me.ActiveControl = tsTextSearch.Control
        tsbCamposSeek.SelectedIndex = 1
    End Sub

    Private Sub cmbccosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccosto.SelectedIndexChanged
        Dim dt As DataTable
        dgvbusqueda.DataSource = Nothing
        If cmbccosto.SelectedIndex <> 0 Then
            dt = ELTBCAPACITACIONBL.list(Trim(Mid(cmbccosto.Text, 1, 3)))
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
            'lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        Else
            dt = ELTBCAPACITACIONBL.list(Trim(Mid(cmbccosto.Text, 1, 3)))
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False

            'tsbCamposSeek.Items.Clear()
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
    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        'If sBusAlm = "1" Then
        'gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        Dim valor As Boolean
        If FormELTBCAPACITACION.dgvt_doc.Rows.Count > 0 Then
            For i = 0 To FormELTBCAPACITACION.dgvt_doc.Rows.Count - 1
                If FormELTBCAPACITACION.dgvt_doc.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                    valor = True
                    MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                    Exit Sub
                End If
            Next
        End If

        gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        FormELTBCAPACITACION.nom = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        Dispose()

        'FormELTBCAPACITACION.dgvt_doc.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value))
        'End If
    End Sub

    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged
        If tsbCamposSeek.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = tsTextSearch.Text

        If sCode.Trim = "" Then
            dgvbusqueda.DataSource = gdtMainData
            'lblRecNo.Text = dgvbusqueda.Rows.Count
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

        'lblRecNo.Text = dgvbusqueda.Rows.Count

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val As String = ""
        'If sBusAlm = "1" Then
        'gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        Dim valor As Boolean
        If FormELTBCAPACITACION.dgvt_doc.Rows.Count > 0 Then
            For j = 0 To dgvbusqueda.Rows.Count - 1
                For i = 0 To FormELTBCAPACITACION.dgvt_doc.Rows.Count - 1
                    If FormELTBCAPACITACION.dgvt_doc.Rows(i).Cells(0).Value = dgvbusqueda.Rows(j).Cells(0).Value Then
                        val = "1"
                    End If
                Next
                If val <> "1" Then
                    FormELTBCAPACITACION.dgvt_doc.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(0).Value), "", dgvbusqueda.Rows(j).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(1).Value), "", dgvbusqueda.Rows(j).Cells(1).Value))
                Else
                    val = ""
                End If
            Next
        Else
            For i = 0 To dgvbusqueda.Rows.Count - 1
                FormELTBCAPACITACION.dgvt_doc.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(0).Value), "", dgvbusqueda.Rows(i).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(1).Value), "", dgvbusqueda.Rows(i).Cells(1).Value))
            Next
        End If

        'End If
    End Sub

    Private Sub dgvbusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvbusqueda.KeyDown
        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub
End Class