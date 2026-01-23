
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FormInventario
    Public ARCHIVO As String
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private anho As String = DateTime.Now.Year
    Private mes As String = DateTime.Now.Month.ToString.PadLeft(2, "0")
    Private dia As String = DateTime.Now.Day.ToString.PadLeft(2, "0")
    Private mesnom As String = MonthName(mes).ToUpper
    Private direccionurl As String = "\\192.168.1.5\sistema\ASISTENCIA\" & anho & "\" & mesnom
    Dim xSheet As String = ""


    Private Sub btncargararch1_Click(sender As Object, e As EventArgs) Handles btncargararch.Click
        Try

            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                Dim ds As New DataSet
                Dim da As OleDbDataAdapter
                Dim dt As DataTable
                Dim conn As OleDbConnection

                'xSheet = "report"
                xSheet = "Hoja1"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    da = New OleDbDataAdapter("SELECT Codigo, Descripcion, Cantidad, Almacen, [Fecha de Corte]  FROM  [" & xSheet & "$]", conn)

                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    importarExcel(dt)
                    'DataGridView1.DataSource = ds
                    'DataGridView1.DataMember = "MyData"
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
        'Label3.Text = "Nro de Registros : " & dgvdatos.Rows.Count



    End Sub
    Sub importarExcel(ByVal DT As DataTable)
        Dim xDescripcion As String
        Dim xBuscar As String
        Dim xContador As Integer
        Dim xEncontrado As String = "Y"
        Dim xAnho, xMes As String
        Dim xFecha As String
        Dim xCodigo As String
        Dim xCantidad As String
        Dim xAlmacen As String

        For Each row As DataRow In DT.Rows

            xDescripcion = ARTICULOBL.getArticuloDescripcion(Convert.ToString(row("Codigo")).Trim.PadLeft(8, "0"))
            xFecha = row("Fecha de Corte").ToString().Substring(0, 10)
            xCodigo = row("Codigo").ToString
            xAlmacen = row("Almacen").ToString
            xCantidad = row("Cantidad").ToString


            If xAlmacen <> "0001" And xAlmacen <> "0002" And xAlmacen <> "0003" Then
                MessageBox.Show("Almacen no permitido...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If xCodigo.Length < 8 Then
                If xCodigo.Length = 7 Then
                    xCodigo = "0" + xCodigo

                End If
                If xCodigo.Length < 6 Then

                    MessageBox.Show("Codigo NO permitido...Debe de tener 8 digitos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else

                End If


            End If


            'dgvdatos.Rows.Add(Convert.ToString(row("Codigo")).Trim.PadLeft(8, "0"), xDescripcion, row("Cantidad"), row("Almacen"), xFecha)
            dgvdatos.Rows.Add(xCodigo.Trim.PadLeft(8, "0"), xDescripcion, xCantidad, xAlmacen, xFecha)

            '*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
            ' xBuscar = Convert.ToString(row("Codigo")).Substring(0, 4)
            xBuscar = xCodigo.Substring(0, 4)

            xContador = xContador + 1
            xAnho = row("Fecha de Corte").ToString().Substring(6, 4)
            xMes = row("Fecha de Corte").ToString().Substring(3, 2)


            If xContador = 1 Then
                'dgvdatox.Rows.Add(Convert.ToString(row("Codigo")).Substring(0, 4), xFecha, row("Almacen"), xAnho, xMes)
                dgvdatox.Rows.Add(xCodigo.Substring(0, 4), xFecha, xAlmacen, xAnho, xMes)

            End If
            xEncontrado = "N"
            For Each roww As DataGridViewRow In dgvdatox.Rows
                Dim codigo As String = roww.Cells("sublinea").Value.ToString().Substring(0, 4)
                If codigo.Contains(xBuscar.Trim) Then
                    xEncontrado = "Y"
                End If
            Next

            If xEncontrado = "N" Then

                ' dgvdatox.Rows.Add(Convert.ToString(row("Codigo")).Substring(0, 4), xFecha, row("Almacen"), xAnho, xMes)
                dgvdatox.Rows.Add(xCodigo.Substring(0, 4), xFecha, xAlmacen, xAnho, xMes)


            End If


        Next


    End Sub

    Sub SubirArchivo()
        Dim hora As String = "  " & DateTime.Now.ToString("HH-mm-ss tt")
        Dim fichero As New System.IO.FileInfo(direccionurl & "\" & dia & "-" & mes & "-" & anho & hora & ".xls")

        If Directory.Exists(direccionurl) Then
            If fichero.Exists = False Then
                System.IO.File.Copy(ARCHIVO, fichero.FullName)
            Else
                'fichero = New System.IO.FileInfo(direccionurl & "\" & dia & "-" & mes & "-" & anho & "-" & d & ".xls")
                'System.IO.File.Copy(ARCHIVO, fichero.FullName)
            End If
        Else
            My.Computer.FileSystem.CreateDirectory(direccionurl)
            System.IO.File.Copy(ARCHIVO, fichero.FullName)
        End If
    End Sub
    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click
        insertar()
    End Sub

    Sub insertar()
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Seleccione MEs y Año de Invetario")
            Exit Sub
        End If
        Dim codigo As String = ""
        Dim sublinea As String = ""
        Dim cantidad As Decimal = 0.00
        Dim codAlm As String = ""
        Dim fecCorte As String = ""
        Dim mes = ""
        mes = obtenerMes(ComboBox1.SelectedIndex)
        Dim anho = ComboBox2.Text
        Dim mensaje As String = ""
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar los Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                For i = 0 To dgvdatos.Rows.Count - 1
                    codigo = dgvdatos.Rows(i).Cells("Codigo").Value
                    cantidad = dgvdatos.Rows(i).Cells("Cantidad").Value
                    codAlm = dgvdatos.Rows(i).Cells("Almacen").Value

                    mensaje = ARTICULOBL.ProcesarInventario(codigo, cantidad, codAlm, mes, anho)
                    If mensaje <> "OK" Then
                        MsgBox("Error al Grabar Inventario")
                        Exit Sub
                    End If
                Next

                For j = 0 To dgvdatox.Rows.Count - 1
                    sublinea = dgvdatox.Rows(j).Cells(0).Value
                    fecCorte = dgvdatox.Rows(j).Cells(1).Value
                    codAlm = dgvdatox.Rows(j).Cells(2).Value
                    mes = dgvdatox.Rows(j).Cells(4).Value
                    anho = dgvdatox.Rows(j).Cells(3).Value
                    mensaje = ARTICULOBL.ProcesarInventario2(sublinea, fecCorte, codAlm, mes, anho)
                    If mensaje <> "OK" Then
                        MsgBox("Error al Grabar Inventario")
                        Exit Sub
                    End If
                Next

                For k = 0 To dgvdatox.Rows.Count - 1
                    sublinea = dgvdatox.Rows(k).Cells(0).Value
                    fecCorte = dgvdatox.Rows(k).Cells(1).Value
                    codAlm = dgvdatox.Rows(k).Cells(2).Value
                    mes = dgvdatox.Rows(k).Cells(4).Value
                    anho = dgvdatox.Rows(k).Cells(3).Value
                    mensaje = ARTICULOBL.ProcesarInventario3(sublinea, fecCorte, codAlm, mes, anho)
                    If mensaje <> "OK" Then
                        MsgBox("Error al Grabar Inventario")
                        Exit Sub
                    End If
                Next
            End If
            MsgBox("Inventario Actualizado Correctamente")
        End If
    End Sub

    Private Function obtenerMes(ByVal i As Int16) As String
        Dim mes = "00"
        Select Case i
            Case 0
                mes = "01"
            Case 1
                mes = "02"
            Case 2
                mes = "03"
            Case 3
                mes = "04"
            Case 4
                mes = "05"
            Case 5
                mes = "06"
            Case 6
                mes = "07"
            Case 7
                mes = "08"
            Case 8
                mes = "09"
            Case 9
                mes = "10"
            Case 10
                mes = "11"
            Case 11
                mes = "12"
        End Select
        Return mes
    End Function

    Private Function OkData() As Boolean
        If dgvdatos.Rows.Count < 1 Then
            MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
            btncargararch.Focus()
            Return False
        End If
        Return True
    End Function





    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvdatos.Rows.Clear()
        dgvdatos.DataSource = Nothing

        dgvdatox.Rows.Clear()
        dgvdatox.DataSource = Nothing

        'dgvdatos2.Columns.Add("", "")

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If dgvdatos.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvdatos.Rows.RemoveAt(dgvdatos.CurrentRow.Index)
            dgvdatos.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        dgvdatos.Rows.Clear()
        dgvdatos.Refresh()

        dgvdatox.Rows.Clear()
        dgvdatox.Refresh()

    End Sub
    'Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
    '    'Creamos las variables
    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
    '    Try
    '        'Añadimos el Libro al programa, y la hoja al libro
    '        exLibro = exApp.Workbooks.Add
    '        exHoja = exLibro.Worksheets.Add()
    '        ' ¿Cuantas columnas y cuantas filas?
    '        Dim NCol As Integer = ElGrid.ColumnCount
    '        Dim NRow As Integer = ElGrid.RowCount
    '        'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
    '        'For i As Integer = 1 To NCol
    '        exHoja.Cells.Item(1, 1) = "Art. Codigo" 'ElGrid.Columns(i - 1).Name.ToString
    '        'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
    '        'Next

    '        For Fila As Integer = 0 To NRow - 1
    '            For Col As Integer = 0 To NCol - 1
    '                exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
    '                'exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "@"
    '            Next
    '        Next
    '        'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
    '        exHoja.Rows.Item(1).Font.Bold = 1
    '        exHoja.Rows.Item(1).HorizontalAlignment = 3
    '        exHoja.Columns.AutoFit()
    '        'Aplicación visible
    '        exApp.Application.Visible = True
    '        exHoja = Nothing
    '        exLibro = Nothing
    '        exApp = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
    '        Return False
    '    End Try
    '    Return True
    'End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_plantilla.Click

        ExportToExcel(dgvdatos)
    End Sub

    Private Sub ExportToExcel(ByVal dataGridView As DataGridView)
        Dim excelApp As New Excel.Application()
        excelApp.Visible = True

        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        Dim columnCount As Integer = dataGridView.Columns.Count
        For i As Integer = 0 To columnCount - 1
            worksheet.Cells(1, i + 1) = dataGridView.Columns(i).HeaderText
            worksheet.Cells(1, i + 1).Font.Bold = True

        Next
        Dim rowCount As Integer = dataGridView.Rows.Count
        For i As Integer = 0 To rowCount - 1
            For j As Integer = 0 To columnCount - 1
                worksheet.Cells(i + 2, j + 1) = dataGridView.Rows(i).Cells(j).Value.ToString

            Next
        Next

        Dim tempFile As String = System.IO.Path.GetTempFileName() & ".xls"
        workbook.SaveAs(tempFile)

        ' Liberar recursos
        ReleaseComObject(worksheet)
        ReleaseComObject(workbook)

        'System.Diagnostics.Process.Start(tempFile)

    End Sub
    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class