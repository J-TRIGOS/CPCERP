Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports Scripting
Public Class FormKardexConta
    Private ELTBKARDEXBL As New ELTBKARDEXBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private ELETIQUETABL As New ELETIQUETABL
    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            'For i As Integer = 1 To NCol
            exHoja.Cells.Item(1, 1) = "Art. Codigo" 'ElGrid.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            'Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                    'exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "@"
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Private Function mes(ByVal cmb As String) As String
        If cmb = "Enero" Then
            Return "01"
        ElseIf cmb = "Febrero" Then
            Return "02"
        ElseIf cmb = "Marzo" Then
            Return "03"
        ElseIf cmb = "Abril" Then
            Return "04"
        ElseIf cmb = "Mayo" Then
            Return "05"
        ElseIf cmb = "Junio" Then
            Return "06"
        ElseIf cmb = "Julio" Then
            Return "07"
        ElseIf cmb = "Agosto" Then
            Return "08"
        ElseIf cmb = "Septiembre" Then
            Return "09"
        ElseIf cmb = "Octubre" Then
            Return "10"
        ElseIf cmb = "Noviembre" Then
            Return "11"
        ElseIf cmb = "Diciembre" Then
            Return "12"
        End If

    End Function
    Private Sub SaveData()
        'If dgvt_doc.Rows.Count = 0 Then
        '    MsgBox("La factura no tiene items")
        '    Exit Sub
        'End If
        If MessageBox.Show("Desea grabar el Registro",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBKARDEXBE As New ELTBKARDEXBE

        ELTBKARDEXBE.AÑO = cmbaño2.Text
        'ELTBKARDEXBE.AÑO = cmbaño.Text
        'ELTBKARDEXBE.FEC1 = dtpini.Value.Day & "/" & dtpini.Value.Month & "/" & dtpini.Value.Year
        'ELTBKARDEXBE.FEC1 = dtpini.Value
        'ELTBKARDEXBE.FEC2 = dtpfin.Value.Day & "/" & dtpfin.Value.Month & "/" & dtpfin.Value.Year
        'ELTBKARDEXBE.FEC2 = dtpfin.Value
        'ELTBKARDEXBE.ALM = gsCodAlm
        If gsCode13 = "1" Then
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N2", dgvt_doc3, txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text)
        Else
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N1", dgvt_doc2, txtsublinea.Text, txtfam_Cod.Text, txtcodart.Text)
        End If

        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dim dt As DataTable
            'dt = ELTBKARDEXBL.SelectAll()
            'dgvt_doc.DataSource = dt
            'dgvt_doc.Refresh()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormKardexConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño2.Text = sAño
        cmbmes1.SelectedIndex = 0
        cmbaño3.Text = sAño
        cmbmes3.SelectedIndex = 0
        Me.Text = "Kardex Contable"

        'Me.Text = "Kardex Contable"
        dgvt_doc2.Columns.Add("nInicial", "Cantidad Inicial") '0
        dgvt_doc2.Columns.Add("PERIODO", "Prdo.") '1
        dgvt_doc2.Columns.Add("RUC", "Ruc") '2
        dgvt_doc2.Columns.Add("RAZON_SOCIAL", "Raz. Social") '3
        dgvt_doc2.Columns.Add("ESTABLECIMIENTO", "Establecimiento") '4
        dgvt_doc2.Columns.Add("FAM_CONT", "Fam. Cont") '5
        dgvt_doc2.Columns.Add("ART_COD", "Codigo Articulo") '6
        dgvt_doc2.Columns.Add("NOM_ART", "Desc.") '7
        dgvt_doc2.Columns.Add("UNIDAD", "Und.") '8
        dgvt_doc2.Columns.Add("FECHA", "Fecha") '9
        dgvt_doc2.Columns.Add("ALM_COD", "Cod. Alm.") '10
        dgvt_doc2.Columns.Add("TIPO_DOC", "T. Doc.") '11
        dgvt_doc2.Columns.Add("SERIE_NRO", "Ser. Nro.") '12
        dgvt_doc2.Columns.Add("NRO_DOCU", "Nro. Doc.") '13
        dgvt_doc2.Columns.Add("TIPO_OPERACION", "Tip. Op.") '14
        dgvt_doc2.Columns.Add("cod_ope", "Cod. Ope.") '15
        dgvt_doc2.Columns.Add("nom_ope", "Nom. Ope.") '16
        dgvt_doc2.Columns.Add("CANT_ENTRADA", "Cant. Ent.") '17
        dgvt_doc2.Columns.Add("CANT_SALIDA", "Cant. Sal.") '18
        dgvt_doc2.Columns.Add("ACUMULADO", "Acumulado") '19
        dgvt_doc2.Columns.Add("PRECIO", "Precio") '20
        dgvt_doc2.Columns.Add("PRECIO_ENTRADA", "Precio Entrada") '21
        dgvt_doc2.Columns.Add("PRECIO_SALIDA", "Precio Salida") '22
        dgvt_doc2.Columns.Add("COSTO_ENTRADA", "Costo Entrada") '23
        dgvt_doc2.Columns.Add("PRECIO_SALDO", "Precio Saldo") '24
        dgvt_doc2.Columns.Add("Costo_Saldo", "Costo Saldo") '25
        dgvt_doc2.Columns.Add("Cantidad_Saldo", "Cantidad Saldo") '26
        dgvt_doc2.Columns.Add("T_MOVIN", "Tipo Movimiento") '27
        dgvt_doc2.Columns.Add("NOM_T_MOVIN", "Nombre Tip. Movimiento") '28
        dgvt_doc2.Columns.Add("DOC_REQ", "Req. Compra") '29
        dgvt_doc2.Columns.Add("DOC_OREQ", "Orden. Compra") '30
        dgvt_doc2.Columns.Add("PRECIO_SOLES", "Precio Soles") '31
        dgvt_doc2.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '32

        dgvnegativo.Columns.Add("ART_COD", "ART_COD")
        '-------
        dgvt_doc3.Columns.Add("nInicial", "Cantidad Inicial") '0
        dgvt_doc3.Columns.Add("PERIODO", "Prdo.") '1
        dgvt_doc3.Columns.Add("RUC", "Ruc") '2
        dgvt_doc3.Columns.Add("RAZON_SOCIAL", "Raz. Social") '3
        dgvt_doc3.Columns.Add("ESTABLECIMIENTO", "Establecimiento") '4
        dgvt_doc3.Columns.Add("FAM_CONT", "Fam. Cont") '5
        dgvt_doc3.Columns.Add("ART_COD", "Codigo Articulo") '6
        dgvt_doc3.Columns.Add("NOM_ART", "Desc.") '7
        dgvt_doc3.Columns.Add("UNIDAD", "Und.") '8
        dgvt_doc3.Columns.Add("FECHA", "Fecha") '9
        dgvt_doc3.Columns.Add("ALM_COD", "Cod. Alm.") '10
        dgvt_doc3.Columns.Add("TIPO_DOC", "T. Doc.") '11
        dgvt_doc3.Columns.Add("SERIE_NRO", "Ser. Nro.") '12
        dgvt_doc3.Columns.Add("NRO_DOCU", "Nro. Doc.") '13
        dgvt_doc3.Columns.Add("TIPO_OPERACION", "Tip. Op.") '14
        dgvt_doc3.Columns.Add("cod_ope", "Cod. Ope.") '15
        dgvt_doc3.Columns.Add("nom_ope", "Nom. Ope.") '16
        dgvt_doc3.Columns.Add("CANT_ENTRADA", "Cant. Ent.") '17
        dgvt_doc3.Columns.Add("CANT_SALIDA", "Cant. Sal.") '18
        dgvt_doc3.Columns.Add("ACUMULADO", "Acumulado") '19
        dgvt_doc3.Columns.Add("PRECIO", "Precio") '20
        dgvt_doc3.Columns.Add("PRECIO_ENTRADA", "Precio Entrada") '21
        dgvt_doc3.Columns.Add("PRECIO_SALIDA", "Precio Salida") '22
        dgvt_doc3.Columns.Add("COSTO_ENTRADA", "Costo Entrada") '23
        dgvt_doc3.Columns.Add("PRECIO_SALDO", "Precio Saldo") '24
        dgvt_doc3.Columns.Add("Costo_Saldo", "Costo Saldo") '25
        dgvt_doc3.Columns.Add("Cantidad_Saldo", "Cantidad Saldo") '26
        dgvt_doc3.Columns.Add("T_MOVIN", "Tipo Movimiento") '27
        dgvt_doc3.Columns.Add("NOM_T_MOVIN", "Nombre Tip. Movimiento") '28
        dgvt_doc3.Columns.Add("DOC_REQ", "Req. Compra") '29
        dgvt_doc3.Columns.Add("DOC_OREQ", "Orden. Compra") '30
        dgvt_doc3.Columns.Add("PRECIO_SOLES", "Precio Soles") '31
        dgvt_doc3.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '32

        dgvnegativo3.Columns.Add("ART_COD", "ART_COD")

        'dgvnegativo.Columns.Add("CANTIDAD", "CANTIDAD")
    End Sub


    Private Sub FormKardexConta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btngenerar2_Click(sender As Object, e As EventArgs) Handles btngenerar2.Click
        Cursor.Current = Cursors.WaitCursor
        If txtsublinea.TextLength = 0 And txtcodart.Text = "" And txtfam_Cod.Text = "" Then
            If MessageBox.Show("Desea generar el kardex",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            'Exit Sub
        End If
        dgvtcod2.DataSource = Nothing
        dgvt_doc2.Rows.Clear()
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim marca As String = 0
        Dim contador As Integer = 0
        Dim acumulado As Double = 0
        Dim acumulado1 As Double = 0
        Dim acumuladocosto As Double = 0
        Dim stockacum As Double = 0
        Dim cantentrada As Double = 0
        Dim precioentrada As Double = 0
        Dim precioinicial As Double = 0
        Dim preciosalida As Double = 0
        Dim contadorentrada As Integer = 0
        Dim contadorsalida As Integer = 0
        Dim costoentrada As Double = 0
        Dim costosalida As Double = 0
        Dim entralop As Integer = 0
        Dim preciosaldo As Double = 0
        Dim cantidadsaldo As Double = 0
        Dim preciopromentrada As Double = 0
        Dim precioprom As Double = 0
        Dim precio As Double = 0
        Dim costosaldo As Double = 0
        Dim totalsaldo As Double = 0
        Dim entrada As Double = 0
        Dim salida As Double = 0
        'dt = ELTBKARDEXBL.SelRow1()
        If cmbaño2.Text = "2019" Then
            dt = ELTBKARDEXBL.SelRow2(txtsublinea.Text, txtfam_Cod.Text, txtcodart.Text)
        Else
            dt = ELTBKARDEXBL.SelRow3(txtsublinea.Text, txtfam_Cod.Text, txtcodart.Text, cmbaño2.Text)
        End If
        dgvtcod2.DataSource = dt
        For Each Registro In dt.Rows
            If cmbaño2.Text = "2019" Then
                dt1 = ELTBKARDEXBL.SelRowKar1(cmbaño2.Text, mes(cmbmes1.Text), mes(cmbmes2.Text), gsCodAlm,
                                   IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
            ElseIf cmbaño2.Text = "2020" Then
                dt1 = ELTBKARDEXBL.SelRowKar2(cmbaño2.Text, mes(cmbmes1.Text), mes(cmbmes2.Text), gsCodAlm,
                                   IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
            ElseIf cmbaño2.Text = "2021" Then
                dt1 = ELTBKARDEXBL.SelRowKar3(cmbaño2.Text, mes(cmbmes1.Text), mes(cmbmes2.Text), gsCodAlm,
                                   IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
            End If
            Dim INICIAL As Double = 0
            Dim c As Integer = 0
            Dim val_c As Integer = 0
            For Each row As DataRow In dt1.Rows
                contador = contador + 1
                If contador > 1 Then
                    salida = 0
                    entrada = 0
                    cantentrada = 0
                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "S28" Then
                        val_c = ELTBKARDEXBL.SelTipMov(IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                      IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                      IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                      IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                        If val_c = 0 Then
                            'contador = contador - 1
                            If dgvt_doc2.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    contadorsalida = contadorsalida + 1
                                    costoentrada = 0
                                    preciosalida = preciosaldo
                                    precioentrada = 0
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                        IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                        acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            'dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                            '             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                            '             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                            '             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            'For Each row1 As DataRow In dt2.Rows
                                            'entralop = entralop + 1
                                            '    If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            '        precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            '    Else
                                            '        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            '    End If
                                            'Next
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            'If entralop = 0 Then
                                            '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            'End If
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        preciosaldo = costosaldo / cantidadsaldo
                                        costosalida = 0
                                    Else
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                      IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                      IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                            preciosalida = 0
                                            contadorsalida = 0

                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        If cantidadsaldo <> 0 Then
                                            preciosaldo = costosaldo / cantidadsaldo
                                        Else
                                            preciosaldo = 0
                                        End If

                                        costosalida = 0
                                    End If
                                End If
                            Else
                                acumulado = 0
                                preciosalida = 0
                                precioentrada = 0
                                acumuladocosto = 0
                                costosaldo = 0
                                costosalida = 0
                                salida = 0
                                entrada = 0
                                contadorentrada = 0
                                contadorsalida = 0
                                preciopromentrada = 0
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * cantidadsaldo
                                    preciosaldo = preciosalida
                                    precioentrada = 0
                                    costosaldo = acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                    costoentrada = 0
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    'preciosalida = precioentrada
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                                        contadorentrada = contadorentrada + 1
                                        'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                  IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosaldo = precioentrada
                                        costosaldo = costoentrada
                                        acumuladocosto = costosaldo
                                        'costo
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciopromentrada = precioentrada + preciopromentrada
                                        precioprom = preciopromentrada / contadorentrada
                                        precioentrada = precioprom
                                        preciosaldo = precioentrada
                                        cantidadsaldo = acumulado

                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = acumulado
                                        cantentrada = 0
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        marca = 1
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                    End If
                                    'aca
                                    cantidadsaldo = acumulado
                                    costosaldo = 0 + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                    If marca = 1 Then
                                        costoentrada = 0
                                        precioentrada = 0
                                        marca = 0
                                    End If
                                End If
                            End If
                        Else
                            contador = contador - 1
                        End If
                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E21" And
                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05990193" Then
                        If IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0189704" Or
                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0191502" Or
                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0191891" Or
                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0192338" Then
                            If dgvt_doc2.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    contadorsalida = contadorsalida + 1
                                    costoentrada = 0
                                    preciosalida = preciosaldo
                                    precioentrada = 0
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                        IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                        acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Or
                                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E21" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                                   IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                            IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                    IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                    IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        preciosaldo = costosaldo / cantidadsaldo
                                        costosalida = 0
                                    Else
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                                   IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                            IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                            preciosalida = 0
                                            contadorsalida = 0

                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        If cantidadsaldo <> 0 Then
                                            preciosaldo = costosaldo / cantidadsaldo
                                        Else
                                            preciosaldo = 0
                                        End If

                                        costosalida = 0
                                    End If
                                End If
                            Else
                                acumulado = 0
                                preciosalida = 0
                                precioentrada = 0
                                acumuladocosto = 0
                                costosaldo = 0
                                costosalida = 0
                                salida = 0
                                entrada = 0
                                contadorentrada = 0
                                contadorsalida = 0
                                preciopromentrada = 0
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * cantidadsaldo
                                    preciosaldo = preciosalida
                                    precioentrada = 0
                                    costosaldo = acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                    costoentrada = 0
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    'preciosalida = precioentrada
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                                        contadorentrada = contadorentrada + 1
                                        'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                                   IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosaldo = precioentrada
                                        costosaldo = costoentrada
                                        acumuladocosto = costosaldo
                                        'costo
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciopromentrada = precioentrada + preciopromentrada
                                        precioprom = preciopromentrada / contadorentrada
                                        precioentrada = precioprom
                                        preciosaldo = precioentrada
                                        cantidadsaldo = acumulado

                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = acumulado
                                        cantentrada = 0
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        marca = 1
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                    End If
                                    'aca
                                    cantidadsaldo = acumulado
                                    costosaldo = 0 + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                    If marca = 1 Then
                                        costoentrada = 0
                                        precioentrada = 0
                                        marca = 0
                                    End If
                                End If
                            End If
                        End If
                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Or
                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Or
                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E24" Then 'EN CASO QUE NO CARGUE EL PRECIO POR MOVIMIENTO
                        If dgvt_doc2.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                contadorsalida = contadorsalida + 1
                                costoentrada = 0
                                preciosalida = preciosaldo
                                precioentrada = 0
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                acumuladocosto = costosaldo
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                    IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E17" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E21" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E27" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E10" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E24" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))

                                        dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                        contadorsalida = 0
                                        'ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                        '        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                        '        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                        '    contadorentrada = contadorentrada + 1
                                        '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        '    entralop = 0
                                        '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    preciosalida = 0
                                        '    contadorsalida = 0
                                        'ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        'Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        '    contadorentrada = contadorentrada + 1
                                        '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    preciosalida = 0
                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                Else
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                        acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                        preciosalida = 0
                                        contadorsalida = 0

                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    If cantidadsaldo <> 0 Then
                                        preciosaldo = costosaldo / cantidadsaldo
                                    Else
                                        preciosaldo = 0
                                    End If

                                    costosalida = 0
                                End If
                            End If
                        Else
                            acumulado = 0
                            preciosalida = 0
                            precioentrada = 0
                            acumuladocosto = 0
                            costosaldo = 0
                            costosalida = 0
                            salida = 0
                            entrada = 0
                            contadorentrada = 0
                            contadorsalida = 0
                            preciopromentrada = 0
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * cantidadsaldo
                                preciosaldo = preciosalida
                                precioentrada = 0
                                costosaldo = acumulado * preciosaldo
                                acumuladocosto = costosaldo
                                costoentrada = 0
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                'preciosalida = precioentrada
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E21" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E27" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E10" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E24" Then
                                    contadorentrada = contadorentrada + 1
                                    'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                        Else
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                    If entralop = 0 Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                    entralop = 0
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosaldo = precioentrada
                                    costosaldo = costoentrada
                                    acumuladocosto = costosaldo
                                    'costo
                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciopromentrada = precioentrada + preciopromentrada
                                    precioprom = preciopromentrada / contadorentrada
                                    precioentrada = precioprom
                                    preciosaldo = precioentrada
                                    cantidadsaldo = acumulado

                                    'ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                    '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    cantidadsaldo = acumulado
                                    '    cantentrada = 0
                                    '    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    marca = 1
                                    'Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                    '    contadorentrada = contadorentrada + 1
                                    '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    preciosalida = 0
                                End If
                                'aca
                                cantidadsaldo = acumulado
                                costosaldo = 0 + costoentrada
                                acumuladocosto = costosaldo
                                preciosaldo = costosaldo / cantidadsaldo
                                costosalida = 0
                                If marca = 1 Then
                                    costoentrada = 0
                                    precioentrada = 0
                                    marca = 0
                                End If
                            End If
                        End If
                    Else 'aca

                        If dgvt_doc2.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                contadorsalida = contadorsalida + 1
                                costoentrada = 0
                                preciosalida = preciosaldo
                                precioentrada = 0
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                acumuladocosto = costosaldo
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                    IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                            IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If
                                        If IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) <> "PMPM2020121001-1" Then
                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                        ElseIf IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "PMPM2020121001-1" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                            IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                        End If
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                        contadorsalida = 0
                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                    IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                    IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                        contadorsalida = 0
                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        'modificado 01/10/2021
                                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E21" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                                            For Each row1 As DataRow In dt2.Rows
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Next
                                            'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                        Else
                                            precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                        End If

                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                Else
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                        acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                            preciosalida = 0
                                            contadorsalida = 0

                                        End If
                                        cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    If cantidadsaldo <> 0 Then
                                        preciosaldo = costosaldo / cantidadsaldo
                                    Else
                                        preciosaldo = 0
                                    End If

                                    costosalida = 0
                                End If
                            End If
                        Else
                            acumulado = 0
                            preciosalida = 0
                            precioentrada = 0
                            acumuladocosto = 0
                            costosaldo = 0
                            costosalida = 0
                            salida = 0
                            entrada = 0
                            contadorentrada = 0
                            contadorsalida = 0
                            preciopromentrada = 0
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * cantidadsaldo
                                preciosaldo = preciosalida
                                precioentrada = 0
                                costosaldo = acumulado * preciosaldo
                                acumuladocosto = costosaldo
                                costoentrada = 0
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                'preciosalida = precioentrada
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                                    contadorentrada = contadorentrada + 1
                                    'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                        dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                    Else
                                        dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                              IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                              IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                              IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                    End If

                                    For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosaldo = precioentrada
                                        costosaldo = costoentrada
                                        acumuladocosto = costosaldo
                                        'costo
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciopromentrada = precioentrada + preciopromentrada
                                        precioprom = preciopromentrada / contadorentrada
                                        precioentrada = precioprom
                                        preciosaldo = precioentrada
                                        cantidadsaldo = acumulado

                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = acumulado
                                        cantentrada = 0
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        marca = 1
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosalida = 0
                                End If
                                'aca
                                cantidadsaldo = acumulado
                                costosaldo = 0 + costoentrada
                                acumuladocosto = costosaldo
                                preciosaldo = costosaldo / cantidadsaldo
                                costosalida = 0
                                If marca = 1 Then
                                    costoentrada = 0
                                    precioentrada = 0
                                    marca = 0
                                End If
                            End If
                        End If
                    End If

                Else
                    'contador = contador + 1
                    INICIAL = IIf(IsDBNull(row("nInicial")), 0, row("nInicial"))
                    If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                        acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                        preciosalida = precioentrada
                        precioentrada = 0
                    ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                        acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                            contadorentrada = contadorentrada + 1
                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                            Else
                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                            End If

                            For Each row1 As DataRow In dt2.Rows
                                entralop = entralop + 1
                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                Else
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                End If
                            Next
                            If entralop = 0 Then
                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            End If
                            entralop = 0
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = precioentrada + preciopromentrada
                            costosaldo = costoentrada
                            acumuladocosto = costosaldo
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            precioprom = preciopromentrada / contadorentrada
                            preciosaldo = precioprom
                            precioentrada = precioprom
                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E21" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E27" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E10" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E24" Then
                            contadorentrada = contadorentrada + 1
                            acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                            For Each row1 As DataRow In dt2.Rows
                                entralop = entralop + 1
                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                Else
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                End If
                            Next
                            If entralop = 0 Then
                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            End If
                            entralop = 0
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciosaldo = precioentrada
                            costosaldo = costoentrada
                            acumuladocosto = costosaldo
                            'costo
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = precioentrada + preciopromentrada
                            precioprom = preciopromentrada / contadorentrada
                            precioentrada = precioprom
                            preciosaldo = precioentrada
                            cantidadsaldo = acumulado
                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                            precioentrada = 0 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            costoentrada = 0 'precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costosaldo = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            acumuladocosto = costosaldo
                            cantentrada = 0
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) 'precioentrada + preciopromentrada
                            preciosaldo = preciopromentrada
                        Else
                            contadorentrada = contadorentrada + 1
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costosaldo = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            acumuladocosto = costosaldo
                            preciosalida = 0
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) 'precioentrada + preciopromentrada
                            preciosaldo = preciopromentrada
                        End If
                    End If
                End If
                If val_c = 0 Then
                    dgvt_doc2.Rows.Add(INICIAL, '0
                                                         IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")),'1
                                                         IIf(IsDBNull(row("RUC")), "", row("RUC")),'2
                                                         IIf(IsDBNull(row("RAZON_SOCIAL")), "", row("RAZON_SOCIAL")),'3
                                                         IIf(IsDBNull(row("ESTABLECIMIENTO")), "", row("ESTABLECIMIENTO")),'4
                                                         IIf(IsDBNull(row("FAM_CONT")), "", row("FAM_CONT")),'5
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'6
                                                         IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'7
                                                         IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'8
                                                         IIf(IsDBNull(row("FECHA")), "", row("FECHA")),'9
                                                         IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),'10
                                                         IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),'11
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),'13
                                                         IIf(IsDBNull(row("TIPO_OPERACION")), "", row("TIPO_OPERACION")),'14
                                                         IIf(IsDBNull(row("cod_ope")), "", row("cod_ope")),'15
                                                         IIf(IsDBNull(row("nom_ope")), "", row("nom_ope")),'16
                                                         cantentrada,'17
                                                         IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")),'18
                                                         0,'acumulado,'19
                                                         precio,'20
                                                         precioentrada, preciosalida,'21,22
                                                         costoentrada,'23
                                                         preciosaldo,'24
                                                         costosaldo,'25
                                                         cantidadsaldo,'26
                                                         IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")),'27
                                                         IIf(IsDBNull(row("MOV_NOM")), 0, row("MOV_NOM")),'28
                                                         IIf(IsDBNull(row("DOC_REQ")), 0, row("DOC_REQ")),'29
                                                         IIf(IsDBNull(row("DOC_OREQ")), 0, row("DOC_OREQ")),'30
                                                         IIf(IsDBNull(row("PRECIO_SOLES")), 0, row("PRECIO_SOLES")),'31
                                                         costosalida) '32
                End If
                val_c = 0
            Next
        Next

    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(5)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = mes(cmbmes1.Text)
        gsRptArgs(2) = mes(cmbmes2.Text)
        gsRptArgs(3) = txtsublinea.Text
        gsRptArgs(4) = txtcodart.Text
        gsRptArgs(5) = "1"
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_KARDEX_VALOR_2019_EXCEL_PRUEBA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub txtlinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "229"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtlinea.Text = Trim(gLinea)
                txtnomlinea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtsublinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "230"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtlinea.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtsublinea.Text = Trim(gLinea)
                txtnomsublinea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            gsCode7 = ""
        End If
    End Sub
    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
        Else
            txtnomsublinea.Text = ""
        End If
    End Sub

    Private Sub txtlinea_TextChanged(sender As Object, e As EventArgs) Handles txtlinea.TextChanged
        If txtlinea.TextLength = "4" Then
            txtsublinea.Enabled = True
        Else
            'txtsublinea.Enabled = False
            'txtcodart.Enabled = False
            'txtcodart.Text = ""
            'txtnomart.Text = ""
            txtnomlinea.Text = ""
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
        End If
    End Sub
    Private Sub txtlinea_LostFocus(sender As Object, e As EventArgs) Handles txtlinea.LostFocus
        If txtlinea.TextLength = 4 Then
            txtnomlinea.Text = ELTBLINESBL.SelectDescri(txtlinea.Text)
            If txtnomlinea.TextLength > 0 Then
                txtsublinea.Enabled = True
            Else
                txtsublinea.Enabled = False
            End If
        Else
            txtnomlinea.Text = ""
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
            'txtsublinea.Enabled = False
        End If
    End Sub
    Private Sub txtfam_Cod_LostFocus(sender As Object, e As EventArgs) Handles txtfam_Cod.LostFocus
        If (txtfam_Cod.Text = "") Then
            lblfam_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectFamiliaCOD(txtfam_Cod.Text)
            If dt.Rows.Count > 0 Then
                txtfam_Cod.Text = dt.Rows(0).Item(0).ToString
                lblfam_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtfam_Cod.Text = ""
                lblfam_cod.Text = ""
            End If
        End If
    End Sub
    Private Sub txtfam_Cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfam_Cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "116"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtfam_Cod.Text = gLinea
                lblfam_cod.Text = gSubLinea
            Else
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvtcod2.Rows.Count = 0 Then
            MsgBox("No ah realizado ninguna corrida de articulos")
            Exit Sub
        End If
        SaveData()
    End Sub

    Private Sub btncons_Click(sender As Object, e As EventArgs) Handles btncons.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsRptArgs(2) = "1"
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_TOTAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndif_Click(sender As Object, e As EventArgs) Handles btndif.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsRptArgs(2) = "1"
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFALMTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsal_Click(sender As Object, e As EventArgs) Handles btndifsal.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsaldo_Click(sender As Object, e As EventArgs) Handles btndifsaldo.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsRptArgs(2) = "1"
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALDOTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnfam_Click(sender As Object, e As EventArgs) Handles btnfam.Click
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = mes(cmbmes1.Text)
        gsRptArgs(2) = mes(cmbmes2.Text)
        gsRptArgs(3) = txtsublinea.Text
        gsRptArgs(4) = txtfam_Cod.Text
        gsRptArgs(5) = txtcodart.Text
        gsRptArgs(6) = "1"
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_KARDEX_VALOR_FAMILIA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If (txtcodart.Text = "") Then
            lbldescripcion.Text = ""
            txtfam_Cod.Text = ""
            lblfam_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcodart.Text)
            If dt.Rows.Count > 0 Then
                txtcodart.Text = dt.Rows(0).Item(0).ToString
                lbldescripcion.Text = dt.Rows(0).Item(1).ToString
                BuscarFamilia(txtcodart.Text)
                'Label5.Text = txtfam_Cod.Text
            Else
                txtcodart.Text = ""
                lbldescripcion.Text = ""
            End If
        End If
    End Sub
    Sub BuscarFamilia(ByVal articulo As String)
        Dim dt As DataTable
        dt = ELETIQUETABL.BuscarFamArt(articulo)
        If dt.Rows.Count > 0 Then
            txtfam_Cod.Text = dt.Rows(0).Item(0).ToString
            lblfam_cod.Text = dt.Rows(0).Item(1).ToString
            'Label5.Text = txtfam_Cod.Text
        Else
            txtfam_Cod.Text = ""
            lblfam_cod.Text = ""
        End If
    End Sub
    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "56"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart.Text = gLinea
                lbldescripcion.Text = gSubLinea
                BuscarFamilia(gLinea)
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True

        End If
        gLinea = Nothing
        gSubLinea = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim contador As Integer = 0
        Do While dgvnegativo.Columns.Count > 0
            dgvnegativo.Columns.RemoveAt(dgvnegativo.Columns.Count - 1)
        Loop
        dgvnegativo.Columns.Add("ART_COD", "ART_COD")
        If dgvt_doc2.Rows.Count > 0 Then
            For i = 0 To dgvt_doc2.Rows.Count - 1
                If dgvt_doc2.Rows(i).Cells("CANTIDAD_SALDO").Value < 0 Then
                    If i > 0 Then
                        If contador > 0 Then
                            If dgvnegativo.Rows(contador - 1).Cells("ART_COD").Value <> dgvt_doc2.Rows(i - 1).Cells("ART_COD").Value Then
                                dgvnegativo.Rows.Add(dgvt_doc2.Rows(i).Cells("ART_COD").Value)
                                contador = contador + 1
                            End If
                        Else
                            dgvnegativo.Rows.Add(dgvt_doc2.Rows(i).Cells("ART_COD").Value)
                            contador = contador + 1
                        End If

                    Else
                        dgvnegativo.Rows.Add(dgvt_doc2.Rows(i).Cells("ART_COD").Value)
                        contador = contador + 1
                    End If

                End If
            Next
        Else
            MsgBox("No hay datos que comparar")
        End If

        If dgvnegativo.Rows.Count = 0 Then
            MsgBox("No se encontraron articulos negativos")
        Else
            Call GridAExcel(dgvnegativo)
        End If
    End Sub
    'kardex 2

    Private Sub btngenerar3_Click(sender As Object, e As EventArgs) Handles btngenerar3.Click
        Cursor.Current = Cursors.WaitCursor
        If txtsublinea3.TextLength = 0 And txtcodart3.Text = "" And txtfam_Cod3.Text = "" Then
            If MessageBox.Show("Desea generar el kardex",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            'Exit Sub
        End If
        dgvtcod3.DataSource = Nothing
        dgvt_doc3.Rows.Clear()
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim marca As String = 0
        Dim contador As Integer = 0
        Dim acumulado As Double = 0
        Dim acumulado1 As Double = 0
        Dim acumuladocosto As Double = 0
        Dim stockacum As Double = 0
        Dim cantentrada As Double = 0
        Dim precioentrada As Double = 0
        Dim precioinicial As Double = 0
        Dim preciosalida As Double = 0
        Dim contadorentrada As Integer = 0
        Dim contadorsalida As Integer = 0
        Dim costoentrada As Double = 0
        Dim costosalida As Double = 0
        Dim entralop As Integer = 0
        Dim preciosaldo As Double = 0
        Dim cantidadsaldo As Double = 0
        Dim preciopromentrada As Double = 0
        Dim precioprom As Double = 0
        Dim precio As Double = 0
        Dim costosaldo As Double = 0
        Dim totalsaldo As Double = 0
        Dim entrada As Double = 0
        Dim salida As Double = 0
        'dt = ELTBKARDEXBL.SelRow1()
        If cmbaño3.Text = "2019" Then
            dt = ELTBKARDEXBL.SelRow2(txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text)
        Else
            dt = ELTBKARDEXBL.SelRow3(txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text, cmbaño3.Text)
        End If
        dgvtcod3.DataSource = dt
        For Each Registro In dt.Rows
            If cmbaño3.Text = "2021" Then
                dt1 = ELTBKARDEXBL.SelRowKar4(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                   IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
            End If
            Dim INICIAL As Double = 0
            Dim c As Integer = 0
            Dim val_c As Integer = 0
            For Each row As DataRow In dt1.Rows
                contador = contador + 1
                If contador > 1 Then
                    salida = 0
                    entrada = 0
                    cantentrada = 0
                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "S28" Then
                        val_c = ELTBKARDEXBL.SelTipMov(IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                      IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                      IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                      IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                        If val_c = 0 Then
                            'contador = contador - 1
                            If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    contadorsalida = contadorsalida + 1
                                    costoentrada = 0
                                    preciosalida = preciosaldo
                                    precioentrada = 0
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                        IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                        acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            'dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                            '             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                            '             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                            '             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            'For Each row1 As DataRow In dt2.Rows
                                            'entralop = entralop + 1
                                            '    If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            '        precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            '    Else
                                            '        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            '    End If
                                            'Next
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            'If entralop = 0 Then
                                            '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            'End If
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        preciosaldo = costosaldo / cantidadsaldo
                                        costosalida = 0
                                    Else
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                      IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                      IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                            preciosalida = 0
                                            contadorsalida = 0

                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        If cantidadsaldo <> 0 Then
                                            preciosaldo = costosaldo / cantidadsaldo
                                        Else
                                            preciosaldo = 0
                                        End If

                                        costosalida = 0
                                    End If
                                End If
                            Else
                                acumulado = 0
                                preciosalida = 0
                                precioentrada = 0
                                acumuladocosto = 0
                                costosaldo = 0
                                costosalida = 0
                                salida = 0
                                entrada = 0
                                contadorentrada = 0
                                contadorsalida = 0
                                preciopromentrada = 0
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * cantidadsaldo
                                    preciosaldo = preciosalida
                                    precioentrada = 0
                                    costosaldo = acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                    costoentrada = 0
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    'preciosalida = precioentrada
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                                        contadorentrada = contadorentrada + 1
                                        'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                  IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosaldo = precioentrada
                                        costosaldo = costoentrada
                                        acumuladocosto = costosaldo
                                        'costo
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciopromentrada = precioentrada + preciopromentrada
                                        precioprom = preciopromentrada / contadorentrada
                                        precioentrada = precioprom
                                        preciosaldo = precioentrada
                                        cantidadsaldo = acumulado

                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = acumulado
                                        cantentrada = 0
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        marca = 1
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                    End If
                                    'aca
                                    cantidadsaldo = acumulado
                                    costosaldo = 0 + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                    If marca = 1 Then
                                        costoentrada = 0
                                        precioentrada = 0
                                        marca = 0
                                    End If
                                End If
                            End If
                        Else
                            contador = contador - 1
                        End If
                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E21" And
                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05990193" Then
                        If IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0189704" Or
                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0191502" Or
                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0191891" Or
                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0192338" Then
                            If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    contadorsalida = contadorsalida + 1
                                    costoentrada = 0
                                    preciosalida = preciosaldo
                                    precioentrada = 0
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                        IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                        acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Or
                                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E21" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                                   IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                            IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                    IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                    IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            entralop = 0
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                            contadorsalida = 0
                                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            preciosalida = 0
                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        preciosaldo = costosaldo / cantidadsaldo
                                        costosalida = 0
                                    Else
                                        If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            contadorentrada = contadorentrada + 1
                                            cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                                   IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                            Else
                                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                            IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            End If

                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                            If entralop = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            entralop = 0
                                            costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                            preciosalida = 0
                                            contadorsalida = 0

                                        End If
                                        cantidadsaldo = acumulado
                                        costosaldo = acumuladocosto + costoentrada
                                        acumuladocosto = costosaldo
                                        If cantidadsaldo <> 0 Then
                                            preciosaldo = costosaldo / cantidadsaldo
                                        Else
                                            preciosaldo = 0
                                        End If

                                        costosalida = 0
                                    End If
                                End If
                            Else
                                acumulado = 0
                                preciosalida = 0
                                precioentrada = 0
                                acumuladocosto = 0
                                costosaldo = 0
                                costosalida = 0
                                salida = 0
                                entrada = 0
                                contadorentrada = 0
                                contadorsalida = 0
                                preciopromentrada = 0
                                If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                    acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                    preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    cantidadsaldo = acumulado
                                    costosalida = preciosalida * cantidadsaldo
                                    preciosaldo = preciosalida
                                    precioentrada = 0
                                    costosaldo = acumulado * preciosaldo
                                    acumuladocosto = costosaldo
                                    costoentrada = 0
                                ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    'preciosalida = precioentrada
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                                        contadorentrada = contadorentrada + 1
                                        'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                                   IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosaldo = precioentrada
                                        costosaldo = costoentrada
                                        acumuladocosto = costosaldo
                                        'costo
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciopromentrada = precioentrada + preciopromentrada
                                        precioprom = preciopromentrada / contadorentrada
                                        precioentrada = precioprom
                                        preciosaldo = precioentrada
                                        cantidadsaldo = acumulado

                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        cantidadsaldo = acumulado
                                        cantentrada = 0
                                        cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        marca = 1
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                    End If
                                    'aca
                                    cantidadsaldo = acumulado
                                    costosaldo = 0 + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                    If marca = 1 Then
                                        costoentrada = 0
                                        precioentrada = 0
                                        marca = 0
                                    End If
                                End If
                            End If
                        End If
                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Or
                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                           IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                        If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                contadorsalida = contadorsalida + 1
                                costoentrada = 0
                                preciosalida = preciosaldo
                                precioentrada = 0
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                acumuladocosto = costosaldo
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                    IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E17" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                                        IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))

                                        dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                        contadorsalida = 0
                                        'ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                        '        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                        '        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                        '    contadorentrada = contadorentrada + 1
                                        '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        '    entralop = 0
                                        '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    preciosalida = 0
                                        '    contadorsalida = 0
                                        'ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        'Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        '    contadorentrada = contadorentrada + 1
                                        '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        '    preciosalida = 0
                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                Else
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                        acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                        preciosalida = 0
                                        contadorsalida = 0

                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    If cantidadsaldo <> 0 Then
                                        preciosaldo = costosaldo / cantidadsaldo
                                    Else
                                        preciosaldo = 0
                                    End If

                                    costosalida = 0
                                End If
                            End If
                        Else
                            acumulado = 0
                            preciosalida = 0
                            precioentrada = 0
                            acumuladocosto = 0
                            costosaldo = 0
                            costosalida = 0
                            salida = 0
                            entrada = 0
                            contadorentrada = 0
                            contadorsalida = 0
                            preciopromentrada = 0
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * cantidadsaldo
                                preciosaldo = preciosalida
                                precioentrada = 0
                                costosaldo = acumulado * preciosaldo
                                acumuladocosto = costosaldo
                                costoentrada = 0
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                'preciosalida = precioentrada
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" Or
                                    IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                    contadorentrada = contadorentrada + 1
                                    'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                        Else
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                    If entralop = 0 Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                    entralop = 0
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosaldo = precioentrada
                                    costosaldo = costoentrada
                                    acumuladocosto = costosaldo
                                    'costo
                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciopromentrada = precioentrada + preciopromentrada
                                    precioprom = preciopromentrada / contadorentrada
                                    precioentrada = precioprom
                                    preciosaldo = precioentrada
                                    cantidadsaldo = acumulado

                                    'ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                    '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    cantidadsaldo = acumulado
                                    '    cantentrada = 0
                                    '    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    marca = 1
                                    'Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                    '    contadorentrada = contadorentrada + 1
                                    '    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    '    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    '    preciosalida = 0
                                End If
                                'aca
                                cantidadsaldo = acumulado
                                costosaldo = 0 + costoentrada
                                acumuladocosto = costosaldo
                                preciosaldo = costosaldo / cantidadsaldo
                                costosalida = 0
                                If marca = 1 Then
                                    costoentrada = 0
                                    precioentrada = 0
                                    marca = 0
                                End If
                            End If
                        End If
                    Else 'aca

                        If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                contadorsalida = contadorsalida + 1
                                costoentrada = 0
                                preciosalida = preciosaldo
                                precioentrada = 0
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                acumuladocosto = costosaldo
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "07" And
                                    IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) <> "97" Then
                                    acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                            IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                        contadorsalida = 0
                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" And
                                IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "0190286" And
                                IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "05580182" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        entralop = 0
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                        contadorsalida = 0
                                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E24" Then 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        preciosalida = 0
                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    preciosaldo = costosaldo / cantidadsaldo
                                    costosalida = 0
                                Else
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E19" Then
                                        acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                            dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                        Else
                                            dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                        IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                        IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                        End If

                                        For Each row1 As DataRow In dt2.Rows
                                            entralop = entralop + 1
                                            If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Else
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                        Next
                                        If entralop = 0 Then
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                        entralop = 0
                                        costoentrada = -(precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")))
                                        preciosalida = 0
                                        contadorsalida = 0

                                    End If
                                    cantidadsaldo = acumulado
                                    costosaldo = acumuladocosto + costoentrada
                                    acumuladocosto = costosaldo
                                    If cantidadsaldo <> 0 Then
                                        preciosaldo = costosaldo / cantidadsaldo
                                    Else
                                        preciosaldo = 0
                                    End If

                                    costosalida = 0
                                End If
                            End If
                        Else
                            acumulado = 0
                            preciosalida = 0
                            precioentrada = 0
                            acumuladocosto = 0
                            costosaldo = 0
                            costosalida = 0
                            salida = 0
                            entrada = 0
                            contadorentrada = 0
                            contadorsalida = 0
                            preciopromentrada = 0
                            If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                cantidadsaldo = acumulado
                                costosalida = preciosalida * cantidadsaldo
                                preciosaldo = preciosalida
                                precioentrada = 0
                                costosaldo = acumulado * preciosaldo
                                acumuladocosto = costosaldo
                                costoentrada = 0
                            ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                                acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                'preciosalida = precioentrada
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                                    contadorentrada = contadorentrada + 1
                                    'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                        dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                         IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                                    Else
                                        dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                              IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                              IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                              IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                    End If

                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                        Else
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                    If entralop = 0 Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                    entralop = 0
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosaldo = precioentrada
                                    costosaldo = costoentrada
                                    acumuladocosto = costosaldo
                                    'costo
                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciopromentrada = precioentrada + preciopromentrada
                                    precioprom = preciopromentrada / contadorentrada
                                    precioentrada = precioprom
                                    preciosaldo = precioentrada
                                    cantidadsaldo = acumulado

                                ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    cantidadsaldo = acumulado
                                    cantentrada = 0
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    marca = 1
                                Else 'If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                    contadorentrada = contadorentrada + 1
                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosalida = 0
                                End If
                                'aca
                                cantidadsaldo = acumulado
                                costosaldo = 0 + costoentrada
                                acumuladocosto = costosaldo
                                preciosaldo = costosaldo / cantidadsaldo
                                costosalida = 0
                                If marca = 1 Then
                                    costoentrada = 0
                                    precioentrada = 0
                                    marca = 0
                                End If
                            End If
                        End If
                    End If

                Else
                    'contador = contador + 1
                    INICIAL = IIf(IsDBNull(row("nInicial")), 0, row("nInicial"))
                    If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                        acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                        preciosalida = precioentrada
                        precioentrada = 0
                    ElseIf IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")) = 0 Then
                        acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E19" Then
                            contadorentrada = contadorentrada + 1
                            If IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) = "02014335" And
                                               IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")) = "187218" Then
                                dt2 = ELTBKARDEXBL.SelPrecio(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                             IIf(IsDBNull(row("CANT_ENTRADA")), "", row("CANT_ENTRADA")))
                            Else
                                dt2 = ELTBKARDEXBL.SelPrecio1(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                            End If

                            For Each row1 As DataRow In dt2.Rows
                                entralop = entralop + 1
                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                Else
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                End If
                            Next
                            If entralop = 0 Then
                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            End If
                            entralop = 0
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = precioentrada + preciopromentrada
                            costosaldo = costoentrada
                            acumuladocosto = costosaldo
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            precioprom = preciopromentrada / contadorentrada
                            preciosaldo = precioprom
                            precioentrada = precioprom
                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E18" Or
                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                            contadorentrada = contadorentrada + 1
                            acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text)
                            For Each row1 As DataRow In dt2.Rows
                                entralop = entralop + 1
                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                Else
                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                End If
                            Next
                            If entralop = 0 Then
                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            End If
                            entralop = 0
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciosaldo = precioentrada
                            costosaldo = costoentrada
                            acumuladocosto = costosaldo
                            'costo
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = precioentrada + preciopromentrada
                            precioprom = preciopromentrada / contadorentrada
                            precioentrada = precioprom
                            preciosaldo = precioentrada
                            cantidadsaldo = acumulado
                        ElseIf IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "02" Then
                            precioentrada = 0 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            costoentrada = 0 'precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costosaldo = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            acumuladocosto = costosaldo
                            cantentrada = 0
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) 'precioentrada + preciopromentrada
                            preciosaldo = preciopromentrada
                        Else
                            contadorentrada = contadorentrada + 1
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costosaldo = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            acumuladocosto = costosaldo
                            preciosalida = 0
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO")) 'precioentrada + preciopromentrada
                            preciosaldo = preciopromentrada
                        End If
                    End If
                End If
                If val_c = 0 Then
                    dgvt_doc3.Rows.Add(INICIAL, '0
                                                         IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")),'1
                                                         IIf(IsDBNull(row("RUC")), "", row("RUC")),'2
                                                         IIf(IsDBNull(row("RAZON_SOCIAL")), "", row("RAZON_SOCIAL")),'3
                                                         IIf(IsDBNull(row("ESTABLECIMIENTO")), "", row("ESTABLECIMIENTO")),'4
                                                         IIf(IsDBNull(row("FAM_CONT")), "", row("FAM_CONT")),'5
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'6
                                                         IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'7
                                                         IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'8
                                                         IIf(IsDBNull(row("FECHA")), "", row("FECHA")),'9
                                                         IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),'10
                                                         IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),'11
                                                         IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),'13
                                                         IIf(IsDBNull(row("TIPO_OPERACION")), "", row("TIPO_OPERACION")),'14
                                                         IIf(IsDBNull(row("cod_ope")), "", row("cod_ope")),'15
                                                         IIf(IsDBNull(row("nom_ope")), "", row("nom_ope")),'16
                                                         cantentrada,'17
                                                         IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")),'18
                                                         0,'acumulado,'19
                                                         precio,'20
                                                         precioentrada, preciosalida,'21,22
                                                         costoentrada,'23
                                                         preciosaldo,'24
                                                         costosaldo,'25
                                                         cantidadsaldo,'26
                                                         IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")),'27
                                                         IIf(IsDBNull(row("MOV_NOM")), 0, row("MOV_NOM")),'28
                                                         IIf(IsDBNull(row("DOC_REQ")), 0, row("DOC_REQ")),'29
                                                         IIf(IsDBNull(row("DOC_OREQ")), 0, row("DOC_OREQ")),'30
                                                         IIf(IsDBNull(row("PRECIO_SOLES")), 0, row("PRECIO_SOLES")),'31
                                                         costosalida) '32
                End If
                val_c = 0
            Next
        Next

    End Sub

    Private Sub btnreporte3_Click(sender As Object, e As EventArgs) Handles btnreporte3.Click
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(5)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = mes(cmbmes3.Text)
        gsRptArgs(2) = mes(cmbmes4.Text)
        gsRptArgs(3) = txtsublinea3.Text
        gsRptArgs(4) = txtcodart3.Text
        gsRptArgs(5) = ""
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_KARDEX_VALOR_2019_EXCEL_PRUEBA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub txtlinea3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "229"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtlinea3.Text = Trim(gLinea)
                txtnomlinea3.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtsublinea3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "230"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtlinea3.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtsublinea3.Text = Trim(gLinea)
                txtnomsublinea3.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            gsCode7 = ""
        End If
    End Sub
    Private Sub txtsublinea3_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea3.LostFocus
        If txtsublinea3.TextLength = 4 Then
            txtnomsublinea3.Text = ELTBLINESBL.SelectDescri(txtsublinea3.Text)
        Else
            txtnomsublinea3.Text = ""
        End If
    End Sub

    Private Sub txtlinea3_TextChanged(sender As Object, e As EventArgs) Handles txtlinea3.TextChanged
        If txtlinea3.TextLength = "4" Then
            txtsublinea3.Enabled = True
        Else
            'txtsublinea.Enabled = False
            'txtcodart.Enabled = False
            'txtcodart.Text = ""
            'txtnomart.Text = ""
            txtnomlinea3.Text = ""
            txtsublinea3.Text = ""
            txtnomsublinea3.Text = ""
        End If
    End Sub
    Private Sub txtlinea3_LostFocus(sender As Object, e As EventArgs) Handles txtlinea3.LostFocus
        If txtlinea3.TextLength = 4 Then
            txtnomlinea3.Text = ELTBLINESBL.SelectDescri(txtlinea3.Text)
            If txtnomlinea3.TextLength > 0 Then
                txtsublinea3.Enabled = True
            Else
                txtsublinea3.Enabled = False
            End If
        Else
            txtnomlinea3.Text = ""
            txtsublinea3.Text = ""
            txtnomsublinea3.Text = ""
            'txtsublinea.Enabled = False
        End If
    End Sub
    Private Sub txtfam_Cod3_LostFocus(sender As Object, e As EventArgs) Handles txtfam_Cod3.LostFocus
        If (txtfam_Cod3.Text = "") Then
            lblfam_cod3.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectFamiliaCOD(txtfam_Cod3.Text)
            If dt.Rows.Count > 0 Then
                txtfam_Cod3.Text = dt.Rows(0).Item(0).ToString
                lblfam_cod3.Text = dt.Rows(0).Item(1).ToString
            Else
                txtfam_Cod3.Text = ""
                lblfam_cod3.Text = ""
            End If
        End If
    End Sub
    Private Sub txtfam_Cod3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfam_Cod3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "116"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtfam_Cod3.Text = gLinea
                lblfam_cod3.Text = gSubLinea
            Else
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If dgvtcod3.Rows.Count = 0 Then
            MsgBox("No ah realizado ninguna corrida de articulos")
            Exit Sub
        End If
        gsCode13 = "1"
        SaveData()
        gsCode13 = ""
    End Sub

    Private Sub btncons3_Click(sender As Object, e As EventArgs) Handles btncons3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsRptArgs(2) = ""
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_TOTAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndif3_Click(sender As Object, e As EventArgs) Handles btndif3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsRptArgs(2) = ""
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFALMTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsal3_Click(sender As Object, e As EventArgs) Handles btndifsal3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsaldo3_Click(sender As Object, e As EventArgs) Handles btndifsaldo3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsRptArgs(2) = ""
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALDOTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnfam3_Click(sender As Object, e As EventArgs) Handles btnfam3.Click
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = mes(cmbmes3.Text)
        gsRptArgs(2) = mes(cmbmes3.Text)
        gsRptArgs(3) = txtsublinea3.Text
        gsRptArgs(4) = txtfam_Cod3.Text
        gsRptArgs(5) = txtcodart3.Text
        gsRptArgs(6) = ""
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_KARDEX_VALOR_FAMILIA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub txtcodart3_LostFocus(sender As Object, e As EventArgs) Handles txtcodart3.LostFocus
        If (txtcodart3.Text = "") Then
            lbldescripcion3.Text = ""
            txtfam_Cod3.Text = ""
            lblfam_cod3.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcodart3.Text)
            If dt.Rows.Count > 0 Then
                txtcodart3.Text = dt.Rows(0).Item(0).ToString
                lbldescripcion3.Text = dt.Rows(0).Item(1).ToString
                BuscarFamilia3(txtcodart3.Text)
                'Label5.Text = txtfam_Cod.Text
            Else
                txtcodart3.Text = ""
                lbldescripcion3.Text = ""
            End If
        End If
    End Sub
    Sub BuscarFamilia3(ByVal articulo As String)
        Dim dt As DataTable
        dt = ELETIQUETABL.BuscarFamArt(articulo)
        If dt.Rows.Count > 0 Then
            txtfam_Cod3.Text = dt.Rows(0).Item(0).ToString
            lblfam_cod3.Text = dt.Rows(0).Item(1).ToString
            'Label5.Text = txtfam_Cod.Text
        Else
            txtfam_Cod3.Text = ""
            lblfam_cod3.Text = ""
        End If
    End Sub
    Private Sub txtcodart3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "56"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart3.Text = gLinea
                lbldescripcion3.Text = gSubLinea
                BuscarFamilia3(gLinea)
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True

        End If
        gLinea = Nothing
        gSubLinea = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim contador As Integer = 0
        Do While dgvnegativo3.Columns.Count > 0
            dgvnegativo3.Columns.RemoveAt(dgvnegativo3.Columns.Count - 1)
        Loop
        dgvnegativo3.Columns.Add("ART_COD", "ART_COD")
        If dgvt_doc3.Rows.Count > 0 Then
            For i = 0 To dgvt_doc3.Rows.Count - 1
                If dgvt_doc3.Rows(i).Cells("CANTIDAD_SALDO").Value < 0 Then
                    If i > 0 Then
                        If contador > 0 Then
                            If dgvnegativo3.Rows(contador - 1).Cells("ART_COD").Value <> dgvt_doc3.Rows(i - 1).Cells("ART_COD").Value Then
                                dgvnegativo3.Rows.Add(dgvt_doc3.Rows(i).Cells("ART_COD").Value)
                                contador = contador + 1
                            End If
                        Else
                            dgvnegativo3.Rows.Add(dgvt_doc3.Rows(i).Cells("ART_COD").Value)
                            contador = contador + 1
                        End If

                    Else
                        dgvnegativo3.Rows.Add(dgvt_doc3.Rows(i).Cells("ART_COD").Value)
                        contador = contador + 1
                    End If

                End If
            Next
        Else
            MsgBox("No hay datos que comparar")
        End If

        If dgvnegativo3.Rows.Count = 0 Then
            MsgBox("No se encontraron articulos negativos")
        Else
            Call GridAExcel(dgvnegativo3)
        End If
    End Sub
End Class