Imports IT.ELUX.BL
Imports System.Data.DataTable
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.IO
Public Class FormResumenLD2D

    Dim CONTABILIDADBL As New CONTABILIDADBL

    Private Sub FormResumenLD2D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drpAnho.Text = Today.Year.ToString()
        drpDesde.SelectedIndex = 0
        drpHasta.SelectedIndex = Today.Month - 1
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim mes1 = "00"
        Dim mes2 = "00"
        Select Case drpDesde.SelectedIndex
            Case 0
                mes1 = "01"
            Case 1
                mes1 = "02"
            Case 2
                mes1 = "03"
            Case 3
                mes1 = "04"
            Case 4
                mes1 = "05"
            Case 5
                mes1 = "06"
            Case 6
                mes1 = "07"
            Case 7
                mes1 = "08"
            Case 8
                mes1 = "09"
            Case 9
                mes1 = "10"
            Case 10
                mes1 = "11"
            Case 11
                mes1 = "12"
        End Select
        Select Case drpHasta.SelectedIndex
            Case 0
                mes2 = "01"
            Case 1
                mes2 = "02"
            Case 2
                mes2 = "03"
            Case 3
                mes2 = "04"
            Case 4
                mes2 = "05"
            Case 5
                mes2 = "06"
            Case 6
                mes2 = "07"
            Case 7
                mes2 = "08"
            Case 8
                mes2 = "09"
            Case 9
                mes2 = "10"
            Case 10
                mes2 = "11"
            Case 11
                mes2 = "12"
        End Select

        dgvLD.DataSource = CONTABILIDADBL.resumenLD(drpAnho.Text, mes1, mes2)

        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing

        Try

            worksheet = workbook.ActiveSheet
            worksheet.Name = "ExportedFromDatGrid"

            Dim CellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1

            For J As Integer = 0 To dgvLD.ColumnCount - 1
                worksheet.Cells(CellRowIndex, cellColumnIndex) = dgvLD.Columns(J).HeaderText
                cellColumnIndex += 1

            Next
            cellColumnIndex = 1
            CellRowIndex += 1

            For i As Integer = 0 To dgvLD.Rows.Count - 2
                For J As Integer = 0 To dgvLD.ColumnCount - 1
                    worksheet.Cells(CellRowIndex, cellColumnIndex) = dgvLD.Rows(i).Cells(J).Value.ToString()
                    cellColumnIndex += 1
                Next
                cellColumnIndex = 1
                CellRowIndex += 1
            Next
            Dim SaveDialog As New SaveFileDialog()
            SaveDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveDialog.FilterIndex = 2

            If SaveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(SaveDialog.FileName)
                MessageBox.Show("Export Successful")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try
    End Sub
End Class