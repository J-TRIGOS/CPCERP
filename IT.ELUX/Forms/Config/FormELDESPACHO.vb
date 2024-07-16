Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormELDESPACHO

    Dim ELDESPACHOBL As New ELDESPACHOBL

    Private Sub dgvDespacho_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvDespacho.CellPainting
        If e.RowIndex = -1 Then Exit Sub

        Dim dgvTemp As DataGridView = sender
        Dim sCellStock As DataGridViewCell = dgvDespacho.Rows(e.RowIndex).Cells(1)
        Dim sCellFFecha As DataGridViewCell = dgvDespacho.Rows(e.RowIndex).Cells(0)


        'stock  GREED
        If (sCellStock.Value > 0) Then

            sCellStock.Style.BackColor = Color.FromArgb(126, 197, 84)
            sCellStock.Style.SelectionBackColor = Color.FromArgb(126, 197, 84)
        End If

        'dias fuera de fecha    RED
        If (sCellFFecha.Value >= 0) Then

            sCellFFecha.Style.BackColor = Color.FromArgb(246, 64, 54)
            sCellFFecha.Style.SelectionBackColor = Color.FromArgb(246, 64, 54)
        Else
            'dias en negativo  (yellow)
            If (sCellFFecha.Value >= -3) Then
                sCellFFecha.Style.BackColor = Color.Yellow
                sCellFFecha.Style.SelectionBackColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvDespacho.RowPostPaint

        ''Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        ''row.DefaultCellStyle.BackColor = Color.LightBlue
        ''row.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        ''row.DefaultCellStyle.SelectionForeColor = DataGridView1.ForeColor


        If (dgvDespacho.Rows(e.RowIndex).Selected) Then
            Dim pen = New Pen(Color.Red) With {.Width = 2}

            Dim x As Integer = e.RowBounds.Left + CInt((pen.Width + pen.Width Mod 2) / 2)
            Dim y As Integer = e.RowBounds.Top + CInt((pen.Width + pen.Width Mod 2) / 2)
            Dim width As Integer = e.RowBounds.Width - 2 * CInt((pen.Width + pen.Width Mod 2) / 2)
            Dim height As Integer = e.RowBounds.Height - 2 * CInt((pen.Width + pen.Width Mod 2) / 2)

            e.Graphics.DrawRectangle(pen, x, y, width, height)
            '     aaa = e.RowIndex
        End If
        ''  

        'If e.RowIndex = aaa Then
        '    Dim pen = New Pen(Color.Red) With {.Width = 2}

        '    Dim x As Integer = e.RowBounds.Left + CInt((pen.Width + pen.Width Mod 2) / 2)
        '    Dim y As Integer = e.RowBounds.Top + CInt((pen.Width + pen.Width Mod 2) / 2)
        '    Dim width As Integer = e.RowBounds.Width - 2 * CInt((pen.Width + pen.Width Mod 2) / 2)
        '    Dim height As Integer = e.RowBounds.Height - 2 * CInt((pen.Width + pen.Width Mod 2) / 2)

        '    e.Graphics.DrawRectangle(pen, x, y, width, height)
        'End If
        ' dgvDespacho.ClearSelection()



        'Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(2)

        'If (cell.Value = "01") Then

        '    cell.Style.BackColor = Color.BlueViolet
        'End If

    End Sub

    Private Sub FormELDESPACHO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        dt = ELDESPACHOBL.SelectAll
        dgvDespacho.DataSource = dt
        dgvDespacho.Refresh()

        dgvDespacho.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        dgvDespacho.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
        dgvDespacho.EnableHeadersVisualStyles = False


        dgvDespacho.DefaultCellStyle.SelectionBackColor = Color.FromArgb(170, 168, 172)
        dgvDespacho.DefaultCellStyle.SelectionForeColor = Color.Black

        'frozen
        dgvDespacho.Columns(0).Frozen = True
        dgvDespacho.Columns(1).Frozen = True
        'alinear
        dgvDespacho.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDespacho.Columns("CANTIDAD").DefaultCellStyle.Format = "N0"

        dgvDespacho.Columns("STOCK").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDespacho.Columns("STOCK").DefaultCellStyle.Format = "N0"
        'dgvDespacho.Columns(0).HeaderCell.Style.ForeColor = Color.Red
    End Sub

    Private Sub FormELDESPACHO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    'Private Sub dgvDespacho_Paint(sender As Object, e As PaintEventArgs) Handles dgvDespacho.Paint

    '    dgvDespacho.Columns.Item(0).DefaultCellStyle.BackColor = Color.Azure

    'End Sub
End Class