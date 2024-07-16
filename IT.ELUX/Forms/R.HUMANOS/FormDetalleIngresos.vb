Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports Microsoft.Office.Interop

Public Class FormDetalleIngresos
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    ' Private ELTBALMACENBL As New ELTBALMACENBL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private ELPERMISOSBL As New ELPERMISOSBL
    Private ELBCALCULOSUBSIDIO As New ELBCALCULOSUBSIDIO


    Private Sub FormDetalleIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ingresos por Trabajador"
        Dim mes As String = Today.ToString("MM")
        Dim anho As String = Today.ToString("yyyy")
        If Len(mes) = 1 Then
            mes = "0" + mes
        End If
        Dim periodo = anho + mes
        Dim dtPeriodos As DataTable

        dtPeriodos = ELBCALCULOSUBSIDIO.CalculoPeriodos(periodo)
        Dim row As DataRow = dtPeriodos.Rows(dtPeriodos.Rows.Count - 1)
        DgvPagos.Columns.Add("NOM", "NOM")
        DgvPagos.Columns.Add("T_PAGO", "T_PAGO")
        DgvPagos.Columns.Add("MES1", CStr(row("MES1")))
        DgvPagos.Columns.Add("MES2", CStr(row("MES2")))
        DgvPagos.Columns.Add("MES3", CStr(row("MES3")))
        DgvPagos.Columns.Add("MES4", CStr(row("MES4")))
        DgvPagos.Columns.Add("MES5", CStr(row("MES5")))
        DgvPagos.Columns.Add("MES6", CStr(row("MES6")))
        DgvPagos.Columns.Add("MES7", CStr(row("MES7")))
        DgvPagos.Columns.Add("MES8", CStr(row("MES8")))
        DgvPagos.Columns.Add("MES9", CStr(row("MES9")))
        DgvPagos.Columns.Add("MES10", CStr(row("MES10")))
        DgvPagos.Columns.Add("MES11", CStr(row("MES11")))
        DgvPagos.Columns.Add("MES12", CStr(row("MES12")))
        'DgvPagos.Columns.Add("TOTAL", "TOTAL")
        'DgvPagos.Columns.Add("DIAS", "DIAS")
        DgvPagos.Visible = False
    End Sub

    Private Sub txtper_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "63-O"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormDetalleIngresos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Dim xlapp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlapp = New Excel.Application
        xlWorkBook = xlapp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("Hoja1"), Excel.Worksheet)

        For k = 0 To DgvPagos.ColumnCount - 1
            xlWorkSheet.Cells(1, k + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Cells(1, k + 1) = DgvPagos.Columns(k).HeaderText
        Next
        For i = 0 To DgvPagos.RowCount - 1
            For j = 0 To DgvPagos.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Cells(i + 2, j + 1) =
                    DgvPagos(j, i).Value.ToString()
            Next
        Next

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.FileName = "INGRESOS " & lblper_cod.Text
        SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            MsgBox("Archivo Exportado")
        Else
            Return
        End If
        xlWorkBook.Close()
        xlapp.Quit()
    End Sub

    Private Sub Btn_Calculo_Click_1(sender As Object, e As EventArgs) Handles Btn_Calculo.Click
        DgvPagos.Visible = True
        DgvPagos.Rows.Clear()
        Dim cod = txtper_cod.Text
        Dim fecha = Today.ToString("dd/MM/yyyy")
        Dim dtPagos As New DataTable
        Dim diasSubsi = 0
        Dim dias As Integer = 0
        Dim pagoTotal = 0
        Dim diasTotal = 0
        Dim dtPeriodo As DataTable
        Dim periodo = 0
        Dim dtListaPeriodos As DataTable
        Dim ListaPeriodos As New ELPERIODOS
        dtPeriodo = ELBCALCULOSUBSIDIO.BuscarPeriodo(fecha)
        periodo = dtPeriodo.Rows(0).Item(0)
        dtListaPeriodos = ELBCALCULOSUBSIDIO.ListaPeriodos(periodo)
        With ListaPeriodos
            .MES1 = dtListaPeriodos.Rows(0).Item(0)
            .MES2 = dtListaPeriodos.Rows(1).Item(0)
            .MES3 = dtListaPeriodos.Rows(2).Item(0)
            .MES4 = dtListaPeriodos.Rows(3).Item(0)
            .MES5 = dtListaPeriodos.Rows(4).Item(0)
            .MES6 = dtListaPeriodos.Rows(5).Item(0)
            .MES7 = dtListaPeriodos.Rows(6).Item(0)
            .MES8 = dtListaPeriodos.Rows(7).Item(0)
            .MES9 = dtListaPeriodos.Rows(8).Item(0)
            .MES10 = dtListaPeriodos.Rows(9).Item(0)
            .MES11 = dtListaPeriodos.Rows(10).Item(0)
            .MES12 = dtListaPeriodos.Rows(11).Item(0)
        End With
        dtPagos = ELBCALCULOSUBSIDIO.CalculoIngresos(cod, periodo, Today.ToString("dd/MM/yyyy"), Today.ToString("dd/MM/yyyy"), ListaPeriodos)
        'DgvPagos.DataSource = dtPagos.DefaultView
        For Each row As DataRow In dtPagos.Rows
            DgvPagos.Rows.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")),'0
                                  IIf(IsDBNull(row("T_PAGO")), "", row("T_PAGO")),'2
                                  IIf(IsDBNull(row("MES1")), "", row("MES1")),'2
                                  IIf(IsDBNull(row("MES2")), "", row("MES2")),'3
                                  IIf(IsDBNull(row("MES3")), "", row("MES3")),'4
                                  IIf(IsDBNull(row("MES4")), "", row("MES4")),'5
                                  IIf(IsDBNull(row("MES5")), "", row("MES5")),'6
                                  IIf(IsDBNull(row("MES6")), "", row("MES6")),'7
                                  IIf(IsDBNull(row("MES7")), "", row("MES7")),'8
                                  IIf(IsDBNull(row("MES8")), "", row("MES8")),'9
                                  IIf(IsDBNull(row("MES9")), "", row("MES9")), '10
                                  IIf(IsDBNull(row("MES10")), "", row("MES10")), '11
                                  IIf(IsDBNull(row("MES11")), "", row("MES11")),'12
                                  IIf(IsDBNull(row("MES12")), "", row("MES12"))) '13
            ' IIf(IsDBNull(row("TOTAL")), "", row("TOTAL")),'14
            ' IIf(IsDBNull(row("DIAS")), "", row("DIAS"))) '15)
        Next
        'pagoTotal = DgvPagos.CurrentRow.Cells(14).Value
        'diasTotal = DgvPagos.CurrentRow.Cells(15).Value
        Dim subsidido = (pagoTotal / diasTotal) * dias
        subsidido = Format(subsidido, “##,##0.00”)
        ' LblDias.Text = dias.ToString + " Día(s) Subsidiado(s) y un pago de S/ " + subsidido.ToString
        dtPagos.Dispose()
        Dim i As Integer
        For i = 0 To DgvPagos.Columns.Count - 1
            DgvPagos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Try
            DgvPagos.CurrentCell = DgvPagos.Rows(0).Cells(7)
        Catch ex As Exception
            MsgBox("No hay datos en el detalle")
        End Try
    End Sub
End Class