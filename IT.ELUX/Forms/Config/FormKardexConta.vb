Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports Scripting
Public Class FormKardexConta
    Private ELTBKARDEXBL As New ELTBKARDEXBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private ELTBKARDEXITEMBL As New ELTBKARDEXITEMBL
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
        If gsCode13 <> "3" And gsCode13 <> "4" And gsCode12 <> "1" Then
            If MessageBox.Show("Desea grabar el Registro",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
        End If
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBKARDEXBE As New ELTBKARDEXBE
        Dim smes As String = ""
        If cmbmes3.SelectedIndex = 0 Then
            smes = "01"
        ElseIf cmbmes3.SelectedIndex = 1 Then
            smes = "02"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            smes = "03"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            smes = "04"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            smes = "05"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            smes = "06"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            smes = "07"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            smes = "08"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            smes = "09"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            smes = "10"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            smes = "11"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            smes = "12"
        End If

        'ELTBKARDEXBE.AÑO = cmbaño2.Text & smes
        'ELTBKARDEXBE.AÑO = cmbaño.Text
        'ELTBKARDEXBE.FEC1 = dtpini.Value.Day & "/" & dtpini.Value.Month & "/" & dtpini.Value.Year
        'ELTBKARDEXBE.FEC1 = dtpini.Value
        'ELTBKARDEXBE.FEC2 = dtpfin.Value.Day & "/" & dtpfin.Value.Month & "/" & dtpfin.Value.Year
        'ELTBKARDEXBE.FEC2 = dtpfin.Value
        'ELTBKARDEXBE.ALM = gsCodAlm
        If gsCode13 = "1" Then
            ELTBKARDEXBE.AÑO = cmbaño2.Text & smes
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N2", dgvt_doc3, txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text)
        ElseIf gsCode13 = "2" Then
            ELTBKARDEXBE.AÑO = cmbaño5.Text & mes(cmbmes7.Text)
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N3", dgvt_doc5, txtsublinea5.Text, "", txtcodart5.Text)
            If dgvretrans.Rows.Count > 0 Then
                gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N3", dgvretrans, txtsublinea5.Text, "TRANS", txtcodart5.Text)
            End If
        ElseIf gsCode13 = "3" Then
            ELTBKARDEXBE.AÑO = cmbaño5.Text
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N4", dgvtransferencia, txtsublinea5.Text, "", txtcodart5.Text)
            'PARA ALMACEN
        ElseIf gsCode13 = "4" Then
            ELTBKARDEXBE.AÑO = cmbaño3.Text & mes(cmbmes3.Text)
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N5", dgvtransferencia3, txtsublinea3.Text, "", txtcodart3.Text)
        ElseIf gsCode13 = "5" Then
            ELTBKARDEXBE.AÑO = cmbaño3.Text & mes(cmbmes3.Text)
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N7", dgvt_doc3, txtsublinea3.Text, "", txtcodart3.Text)
            If gsCode11 = "3" Then
                gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N7", dgvretrans3, txtsublinea3.Text, gsCode11, txtcodart3.Text)
            End If

        Else
            ELTBKARDEXBE.AÑO = cmbaño3.Text & smes
            gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "N1", dgvt_doc3, txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text)
        End If

        If gsError = "OK" Then
            If gsCode13 <> "3" And gsCode13 <> "4" And gsCode13 <> "5" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            End If
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

        If gsUser = "JTRIGOS" Then
            chkLista.Visible = True
        End If

        cmbaño2.Text = sAño
        cmbmes1.SelectedIndex = 0
        cmbaño3.Text = sAño
        cmbmes3.SelectedIndex = 0
        cmbaño4.Text = sAño
        cmbmes5.SelectedIndex = 0
        cmbalmacen4.SelectedIndex = 0
        cmbaño5.Text = sAño
        cmbmes7.SelectedIndex = 0
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
        dgvt_doc2.Columns.Add("NRO_RPD", "ORD. PRD.") '31
        dgvt_doc2.Columns.Add("PRECIO_SOLES", "Precio Dolares") '32
        dgvt_doc2.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '33
        dgvt_doc2.Columns.Add("CUENTA", "CUENTA") '34
        dgvt_doc2.Columns.Add("CUENTA_DEST", "CUENTA_DEST") '35

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
        dgvt_doc3.Columns.Add("PRECIO_SOLES", "Precio Dolares") '31
        dgvt_doc3.Columns.Add("NRO_RPD", "ORD. PRD.") '32
        dgvt_doc3.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '33
        dgvt_doc3.Columns.Add("CUENTA", "CUENTA") '34
        dgvt_doc3.Columns.Add("CUENTA_DEST", "CUENTA_DEST") '35

        dgvnegativo3.Columns.Add("ART_COD", "ART_COD")

        '-------
        dgvt_doc4.Columns.Add("nInicial", "Cantidad Inicial") '0
        dgvt_doc4.Columns.Add("PERIODO", "Prdo.") '1
        dgvt_doc4.Columns.Add("RUC", "Ruc") '2
        dgvt_doc4.Columns.Add("RAZON_SOCIAL", "Raz. Social") '3
        dgvt_doc4.Columns.Add("ESTABLECIMIENTO", "Establecimiento") '4
        dgvt_doc4.Columns.Add("FAM_CONT", "Fam. Cont") '5
        dgvt_doc4.Columns.Add("ART_COD", "Codigo Articulo") '6
        dgvt_doc4.Columns.Add("NOM_ART", "Desc.") '7
        dgvt_doc4.Columns.Add("UNIDAD", "Und.") '8
        dgvt_doc4.Columns.Add("FECHA", "Fecha") '9
        dgvt_doc4.Columns.Add("ALM_COD", "Cod. Alm.") '10
        dgvt_doc4.Columns.Add("TIPO_DOC", "T. Doc.") '11
        dgvt_doc4.Columns.Add("SERIE_NRO", "Ser. Nro.") '12
        dgvt_doc4.Columns.Add("NRO_DOCU", "Nro. Doc.") '13
        dgvt_doc4.Columns.Add("TIPO_OPERACION", "Tip. Op.") '14
        dgvt_doc4.Columns.Add("cod_ope", "Cod. Ope.") '15
        dgvt_doc4.Columns.Add("nom_ope", "Nom. Ope.") '16
        dgvt_doc4.Columns.Add("CANT_ENTRADA", "Cant. Ent.") '17
        dgvt_doc4.Columns.Add("CANT_SALIDA", "Cant. Sal.") '18
        dgvt_doc4.Columns.Add("ACUMULADO", "Acumulado") '19
        dgvt_doc4.Columns.Add("PRECIO", "Precio") '20
        dgvt_doc4.Columns.Add("PRECIO_ENTRADA", "Precio Entrada") '21
        dgvt_doc4.Columns.Add("PRECIO_SALIDA", "Precio Salida") '22
        dgvt_doc4.Columns.Add("COSTO_ENTRADA", "Costo Entrada") '23
        dgvt_doc4.Columns.Add("PRECIO_SALDO", "Precio Saldo") '24
        dgvt_doc4.Columns.Add("Costo_Saldo", "Costo Saldo") '25
        dgvt_doc4.Columns.Add("Cantidad_Saldo", "Cantidad Saldo") '26
        dgvt_doc4.Columns.Add("T_MOVIN", "Tipo Movimiento") '27
        dgvt_doc4.Columns.Add("NOM_T_MOVIN", "Nombre Tip. Movimiento") '28
        dgvt_doc4.Columns.Add("DOC_REQ", "Req. Compra") '29Soles
        dgvt_doc4.Columns.Add("DOC_OREQ", "Orden. Compra") '30
        dgvt_doc4.Columns.Add("PRECIO_SOLES", "Precio Dolares") '31
        dgvt_doc4.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '32

        dgvnegativo4.Columns.Add("ART_COD", "ART_COD")

        'para actualizar oprd
        dgvkardex.Columns.Add("T_DOC_REF", "T_DOC_REF")
        dgvkardex.Columns.Add("SER_DOC_REF", "SER_DOC_REF")
        dgvkardex.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF")
        dgvkardex.Columns.Add("ART_COD", "ART_COD")

        '-------
        dgvt_doc5.Columns.Add("nInicial", "Cantidad Inicial") '0
        dgvt_doc5.Columns.Add("PERIODO", "Prdo.") '1
        dgvt_doc5.Columns.Add("RUC", "Ruc") '2
        dgvt_doc5.Columns.Add("RAZON_SOCIAL", "Raz. Social") '3
        dgvt_doc5.Columns.Add("ESTABLECIMIENTO", "Establecimiento") '4
        dgvt_doc5.Columns.Add("FAM_CONT", "Fam. Cont") '5
        dgvt_doc5.Columns.Add("ART_COD", "Codigo Articulo") '6
        dgvt_doc5.Columns.Add("NOM_ART", "Desc.") '7
        dgvt_doc5.Columns.Add("UNIDAD", "Und.") '8
        dgvt_doc5.Columns.Add("FECHA", "Fecha") '9
        dgvt_doc5.Columns.Add("ALM_COD", "Cod. Alm.") '10
        dgvt_doc5.Columns.Add("TIPO_DOC", "T. Doc.") '11
        dgvt_doc5.Columns.Add("SERIE_NRO", "Ser. Nro.") '12
        dgvt_doc5.Columns.Add("NRO_DOCU", "Nro. Doc.") '13
        dgvt_doc5.Columns.Add("TIPO_OPERACION", "Tip. Op.") '14
        dgvt_doc5.Columns.Add("cod_ope", "Cod. Ope.") '15
        dgvt_doc5.Columns.Add("nom_ope", "Nom. Ope.") '16
        dgvt_doc5.Columns.Add("CANT_ENTRADA", "Cant. Ent.") '17
        dgvt_doc5.Columns.Add("CANT_SALIDA", "Cant. Sal.") '18
        dgvt_doc5.Columns.Add("ACUMULADO", "Acumulado") '19
        dgvt_doc5.Columns.Add("PRECIO", "Precio") '20
        dgvt_doc5.Columns.Add("PRECIO_ENTRADA", "Precio Entrada") '21
        dgvt_doc5.Columns.Add("PRECIO_SALIDA", "Precio Salida") '22
        dgvt_doc5.Columns.Add("COSTO_ENTRADA", "Costo Entrada") '23
        dgvt_doc5.Columns.Add("PRECIO_SALDO", "Precio Saldo") '24
        dgvt_doc5.Columns.Add("Costo_Saldo", "Costo Saldo") '25
        dgvt_doc5.Columns.Add("Cantidad_Saldo", "Cantidad Saldo") '26
        dgvt_doc5.Columns.Add("T_MOVIN", "Tipo Movimiento") '27
        dgvt_doc5.Columns.Add("NOM_T_MOVIN", "Nombre Tip. Movimiento") '28
        dgvt_doc5.Columns.Add("DOC_REQ", "Req. Compra") '29
        dgvt_doc5.Columns.Add("DOC_OREQ", "Orden. Compra") '30
        dgvt_doc5.Columns.Add("PRECIO_SOLES", "Precio Dolares") '31
        dgvt_doc5.Columns.Add("NRO_RPD", "ORD. PRD.") '32
        dgvt_doc5.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '33



        '-------
        dgvretrans.Columns.Add("nInicial", "Cantidad Inicial") '0
        dgvretrans.Columns.Add("PERIODO", "Prdo.") '1
        dgvretrans.Columns.Add("RUC", "Ruc") '2
        dgvretrans.Columns.Add("RAZON_SOCIAL", "Raz. Social") '3
        dgvretrans.Columns.Add("ESTABLECIMIENTO", "Establecimiento") '4
        dgvretrans.Columns.Add("FAM_CONT", "Fam. Cont") '5
        dgvretrans.Columns.Add("ART_COD", "Codigo Articulo") '6
        dgvretrans.Columns.Add("NOM_ART", "Desc.") '7
        dgvretrans.Columns.Add("UNIDAD", "Und.") '8
        dgvretrans.Columns.Add("FECHA", "Fecha") '9
        dgvretrans.Columns.Add("ALM_COD", "Cod. Alm.") '10
        dgvretrans.Columns.Add("TIPO_DOC", "T. Doc.") '11
        dgvretrans.Columns.Add("SERIE_NRO", "Ser. Nro.") '12
        dgvretrans.Columns.Add("NRO_DOCU", "Nro. Doc.") '13
        dgvretrans.Columns.Add("TIPO_OPERACION", "Tip. Op.") '14
        dgvretrans.Columns.Add("cod_ope", "Cod. Ope.") '15
        dgvretrans.Columns.Add("nom_ope", "Nom. Ope.") '16
        dgvretrans.Columns.Add("CANT_ENTRADA", "Cant. Ent.") '17
        dgvretrans.Columns.Add("CANT_SALIDA", "Cant. Sal.") '18
        dgvretrans.Columns.Add("ACUMULADO", "Acumulado") '19
        dgvretrans.Columns.Add("PRECIO", "Precio") '20
        dgvretrans.Columns.Add("PRECIO_ENTRADA", "Precio Entrada") '21
        dgvretrans.Columns.Add("PRECIO_SALIDA", "Precio Salida") '22
        dgvretrans.Columns.Add("COSTO_ENTRADA", "Costo Entrada") '23
        dgvretrans.Columns.Add("PRECIO_SALDO", "Precio Saldo") '24
        dgvretrans.Columns.Add("Costo_Saldo", "Costo Saldo") '25
        dgvretrans.Columns.Add("Cantidad_Saldo", "Cantidad Saldo") '26
        dgvretrans.Columns.Add("T_MOVIN", "Tipo Movimiento") '27
        dgvretrans.Columns.Add("NOM_T_MOVIN", "Nombre Tip. Movimiento") '28
        dgvretrans.Columns.Add("DOC_REQ", "Req. Compra") '29
        dgvretrans.Columns.Add("DOC_OREQ", "Orden. Compra") '30
        dgvretrans.Columns.Add("PRECIO_SOLES", "Precio Dolares") '31
        dgvretrans.Columns.Add("NRO_RPD", "ORD. PRD.") '32
        dgvretrans.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '33
        dgvretrans.Columns.Add("CUENTA", "CUENTA") '34
        dgvretrans.Columns.Add("cuenta_dest", "cuenta_dest") '35


        '-------
        dgvretrans3.Columns.Add("nInicial", "Cantidad Inicial") '0
        dgvretrans3.Columns.Add("PERIODO", "Prdo.") '1
        dgvretrans3.Columns.Add("RUC", "Ruc") '2
        dgvretrans3.Columns.Add("RAZON_SOCIAL", "Raz. Social") '3
        dgvretrans3.Columns.Add("ESTABLECIMIENTO", "Establecimiento") '4
        dgvretrans3.Columns.Add("FAM_CONT", "Fam. Cont") '5
        dgvretrans3.Columns.Add("ART_COD", "Codigo Articulo") '6
        dgvretrans3.Columns.Add("NOM_ART", "Desc.") '7
        dgvretrans3.Columns.Add("UNIDAD", "Und.") '8
        dgvretrans3.Columns.Add("FECHA", "Fecha") '9
        dgvretrans3.Columns.Add("ALM_COD", "Cod. Alm.") '10
        dgvretrans3.Columns.Add("TIPO_DOC", "T. Doc.") '11
        dgvretrans3.Columns.Add("SERIE_NRO", "Ser. Nro.") '12
        dgvretrans3.Columns.Add("NRO_DOCU", "Nro. Doc.") '13
        dgvretrans3.Columns.Add("TIPO_OPERACION", "Tip. Op.") '14
        dgvretrans3.Columns.Add("cod_ope", "Cod. Ope.") '15
        dgvretrans3.Columns.Add("nom_ope", "Nom. Ope.") '16
        dgvretrans3.Columns.Add("CANT_ENTRADA", "Cant. Ent.") '17
        dgvretrans3.Columns.Add("CANT_SALIDA", "Cant. Sal.") '18
        dgvretrans3.Columns.Add("ACUMULADO", "Acumulado") '19
        dgvretrans3.Columns.Add("PRECIO", "Precio") '20
        dgvretrans3.Columns.Add("PRECIO_ENTRADA", "Precio Entrada") '21
        dgvretrans3.Columns.Add("PRECIO_SALIDA", "Precio Salida") '22
        dgvretrans3.Columns.Add("COSTO_ENTRADA", "Costo Entrada") '23
        dgvretrans3.Columns.Add("PRECIO_SALDO", "Precio Saldo") '24
        dgvretrans3.Columns.Add("Costo_Saldo", "Costo Saldo") '25
        dgvretrans3.Columns.Add("Cantidad_Saldo", "Cantidad Saldo") '26
        dgvretrans3.Columns.Add("T_MOVIN", "Tipo Movimiento") '27
        dgvretrans3.Columns.Add("NOM_T_MOVIN", "Nombre Tip. Movimiento") '28
        dgvretrans3.Columns.Add("DOC_REQ", "Req. Compra") '29
        dgvretrans3.Columns.Add("DOC_OREQ", "Orden. Compra") '30
        dgvretrans3.Columns.Add("PRECIO_SOLES", "Precio Dolares") '31
        dgvretrans3.Columns.Add("NRO_RPD", "ORD. PRD.") '32
        dgvretrans3.Columns.Add("COSTO_SALIDA", "COSTO_SALIDA") '33
        dgvretrans.Columns.Add("CUENTA", "CUENTA") '34
        dgvretrans.Columns.Add("cuenta_dest", "cuenta_dest") '35

        dgvnegativo5.Columns.Add("ART_COD", "ART_COD")

        'DGVTRANSFERENCIA
        dgvtransferencia.Columns.Add("SERIE_NRO", "SERIE_NRO") '0
        dgvtransferencia.Columns.Add("NRO_DOCU", "NRO_DOCU.") '1
        dgvtransferencia.Columns.Add("ART_COD", "ART_COD") '2
        dgvtransferencia.Columns.Add("NRO_PRECIOSALDO", "NRO_PRECIOSALDO") '3
        dgvtransferencia.Columns.Add("ANHO", "ANHO") '3

        'DGVTRANSFERENCIA3
        dgvtransferencia3.Columns.Add("SERIE_NRO", "SERIE_NRO") '0
        dgvtransferencia3.Columns.Add("NRO_DOCU", "NRO_DOCU.") '1
        dgvtransferencia3.Columns.Add("ART_COD", "ART_COD") '2
        dgvtransferencia3.Columns.Add("NRO_PRECIOSALDO", "NRO_PRECIOSALDO") '3
        dgvtransferencia3.Columns.Add("ANHO", "ANHO") '3

        'dgvsolm
        dgvsolmnro.Columns.Add("ART_COD", "ART_COD")
        dgvsolmnro.Columns.Add("NRO_OP", "NRO_OP")
        dgvsolmnro.Columns.Add("ANHO", "ANHO")
        dgvsolmnro.Columns.Add("FECHA", "FECHA")


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
        Dim en As Double = 0
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
            ElseIf cmbaño2.Text = "2022" Then
                dt1 = ELTBKARDEXBL.SelRowKar5(cmbaño2.Text, mes(cmbmes1.Text), mes(cmbmes2.Text), gsCodAlm,
                                   IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
            ElseIf cmbaño2.Text = "2023" Then
                dt1 = ELTBKARDEXBL.SelRowKarxCont(cmbaño2.Text, mes(cmbmes1.Text), mes(cmbmes2.Text), gsCodAlm,
                                   IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
            End If
            If dt1.Rows.Count > 0 Then
                Dim alto = 0
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
                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "S28" Then
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
                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E21" And
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
                    ElseIf IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
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
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text, "")
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                        acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        contadorentrada = contadorentrada + 1
                                        cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If

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
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text, "")
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
                                            If dt2.Rows.Count = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
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
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text, "")
                                            For Each row1 As DataRow In dt2.Rows
                                                precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                            Next
                                            If precioentrada = 0 Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
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
                            If en <> 1 Then
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
                            End If
                            en = 0
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
                            If contadorentrada = 1 Then
                                en = 1
                            End If

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
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text, "")
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
                            en = en + 1
                        Else
                            contadorentrada = contadorentrada + 1
                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                            If precioentrada = 0 Then
                                dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño2.Text, "")
                                For Each row1 As DataRow In dt2.Rows
                                    entralop = entralop + 1
                                    If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                        precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                    Else
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                Next
                            End If
                            costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            costosaldo = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            acumuladocosto = costosaldo
                            preciosalida = 0
                            cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                            preciopromentrada = precioentrada 'precioentrada + preciopromentrada
                            preciosaldo = preciopromentrada
                        End If
                    End If
                End If
                Dim nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                If nro_prd = "" Then
                    nro_prd = ELTBKARDEXBL.SelNroPrd00ALM("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
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
                                                         precioentrada, '21
                                                         preciosalida,'22
                                                         costoentrada,'23
                                                         preciosaldo,'24
                                                         costosaldo,'25
                                                         cantidadsaldo,'26
                                                         IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")),'27
                                                         IIf(IsDBNull(row("MOV_NOM")), 0, row("MOV_NOM")),'28
                                                         IIf(IsDBNull(row("DOC_REQ")), 0, row("DOC_REQ")),'29
                                                         IIf(IsDBNull(row("DOC_OREQ")), 0, row("DOC_OREQ")),'30
                                                         nro_prd,
                                                         IIf(IsDBNull(row("PRECIO_SOLES")), 0, row("PRECIO_SOLES")),'31
                                                         costosalida,
                                                         IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")), '32,33
                                                         IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST"))) '34


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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_VALOR_2019_EXCEL_PRUEBA.rpt"
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_TOTAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndif_Click(sender As Object, e As EventArgs) Handles btndif.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsRptArgs(2) = "1"
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFALMTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsal_Click(sender As Object, e As EventArgs) Handles btndifsal.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsaldo_Click(sender As Object, e As EventArgs) Handles btndifsaldo.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño2.Text
        gsRptArgs(1) = txtsublinea.Text
        gsRptArgs(2) = "1"
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALDOTEMP.rpt"
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_VALOR_FAMILIA.rpt"
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
        'Private Sub btngenerar3_Click(sender As Object, e As EventArgs) Handles btngenerar3.Click
        Cursor.Current = Cursors.WaitCursor
        Dim dc As Integer = 0
        If txtsublinea3.TextLength = 0 And txtcodart3.Text = "" And txtfam_Cod3.Text = "" Then
            If MessageBox.Show("Desea generar el kardex",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            dc = 1
            'Exit Sub
        End If
        If txtcodart3.TextLength = 0 Then
            dc = 1
        End If
        dgvtcod3.DataSource = Nothing
        dgvt_doc3.Rows.Clear()
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim dt3 As DataTable
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
        Dim dw As DataTable
        Dim dwCN As Double = 0
        Dim dtrans As Double = 0
        Dim cuentadt As String = ""
        Dim cuenta_destdt As String = ""
        'dt = ELTBKARDEXBL.SelRow1()
        Do
            If dwCN = 0 Then
                'dgvtcod5.DataSource = Nothing
                dgvt_doc3.Rows.Clear()
                dgvretrans3.DataSource = Nothing
                dgvretrans3.Rows.Clear()
                contador = 0
                If cmbaño3.Text = "2019" Then
                    dt = ELTBKARDEXBL.SelRow2(txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text)
                Else
                    If chkLista.Checked = True Then
                        dt = ELTBKARDEXBL.SelListaArt(txtsublinea3.Text)
                    Else
                        dt = ELTBKARDEXBL.SelRow3(txtsublinea3.Text, txtfam_Cod3.Text, txtcodart3.Text, cmbaño3.Text)
                    End If
                End If
                dgvtcod3.DataSource = dt
                For Each Registro In dt.Rows
                    If cmbaño3.Text = "2021" Then
                        dt1 = ELTBKARDEXBL.SelRowKar4(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                           IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
                    ElseIf cmbaño3.Text = "2022" Then
                        dt1 = ELTBKARDEXBL.SelRowKarx6(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                           IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
                    ElseIf cmbaño3.Text = "2023" Then
                        dt1 = ELTBKARDEXBL.SelRowKarx7(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                           IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
                    ElseIf cmbaño3.Text = "2024" Then
                        dt1 = ELTBKARDEXBL.SelRowKarx8(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                           IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
                    End If

                    Dim dtFecCompra As New DataTable
                    Dim fila As DataRow = dt1.NewRow()
                    If dt1.Rows.Count > 0 Then
                        For Each row As DataRow In dt1.Rows
                            'If row("TIPO_OPERACION") = "E19" Then
                            '    dtFecCompra = ELTBKARDEXBL.ActualizarFechaCompra(row("ART_COD"), row("TIPO_DOC"), row("SERIE_NRO"), row("NRO_DOCU"))
                            '    If dtFecCompra.Rows.Count > 0 Then
                            '        'If dtFecCompra.Rows.Count > 0 And dtFecCompra.Rows(0).Item(0).ToString <> "" Then
                            '        If row("FECHA") >= dtFecCompra.Rows(0).Item(0) Then
                            '            row("FECHA") = dtFecCompra.Rows(0).Item(0)
                            '        End If
                            '    End If
                            'End If

                            'If row("TIPO_DOC") = "07" Then
                            '    row("CANT_SALIDA") = row("CANT_ENTRADA")
                            '    row("CANT_ENTRADA") = 0
                            'End If

                            'If row("ART_COD") = "05980072" And row("NRO_DOCU") = "2542" Then
                            '    fila = procesarArticulo(row, dt1)
                            '    row("CANT_ENTRADA") = 4000
                            'End If

                            'If row("ART_COD") = "05020337" And row("TIPO_OPERACION") = "S31" Then
                            '    fila = procesarArticulo1(row, dt1)
                            'End If     
                        Next
                        'If IIf(IsDBNull(fila(12)), "", fila(12)) <> "" Then
                        '    dt1.Rows.Add(fila)
                        'End If
                        'dt1.DefaultView.Sort = ("FECHA ASC, TIPO_OPERACION ASC, NRO_DOCU ASC")

                        'dt1 = dt1.DefaultView.ToTable()
                    End If

                    Dim INICIAL As Double = 0
                    Dim c As Integer = 0
                    Dim val_c As Integer = 0
                    Dim nro_prd As String = ""
                    For Each row As DataRow In dt1.Rows
                        contador = contador + 1
                        nro_prd = ""
                        'If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) = "07" Then
                        '    'MsgBox(IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")))
                        '    Dim BB As String = ""

                        'End If
                        cuentadt = ""
                        cuenta_destdt = ""
                        dt3 = Nothing
                        If IIf(IsDBNull(row("MOV_CODTRA")), "", row("MOV_CODTRA")) = "E19" Then
                            If IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")) = "07" Then
                                Dim MS1 As String = cmbaño3.Text & mes(cmbmes3.Text)
                                Dim MS2 As String = cmbaño3.Text & mes(cmbmes4.Text)
                                dt3 = ELTBKARDEXBL.SelCuentaComprasNC(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
                                For Each row1 As DataRow In dt3.Rows
                                    cuentadt = IIf(IsDBNull(row1("cuenta")), "", row1("cuenta"))
                                Next
                                dt3 = ELTBKARDEXBL.SelCuenta_destComprasNC(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
                                For Each row1 As DataRow In dt3.Rows
                                    cuenta_destdt = IIf(IsDBNull(row1("cuenta_dest")), "", row1("cuenta_dest"))
                                Next

                            Else
                                If IIf(IsDBNull(row("cuenta")), "", row("cuenta")) = "" Then
                                    dt3 = ELTBKARDEXBL.SelCuentaCompras(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text)
                                    For Each row1 As DataRow In dt3.Rows
                                        cuentadt = IIf(IsDBNull(row1("cuenta")), "", row1("cuenta"))
                                    Next
                                End If
                                If IIf(IsDBNull(row("cuenta_dest")), "", row("cuenta_dest")) = "" Then
                                    dt3 = ELTBKARDEXBL.SelCuenta_destCompras(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text)
                                    For Each row1 As DataRow In dt3.Rows
                                        cuenta_destdt = IIf(IsDBNull(row1("cuenta_dest")), "", row1("cuenta_dest"))
                                    Next
                                End If
                            End If
                        Else
                            If IIf(IsDBNull(row("MOV_CODTRA")), "", row("MOV_CODTRA")) = "02" Then
                                cuentadt = IIf(IsDBNull(row("cuenta")), "", row("cuenta"))
                                cuenta_destdt = IIf(IsDBNull(row("cuenta_dest")), "", row("cuenta_dest"))
                            End If
                        End If

                        If IIf(IsDBNull(row("MOV_T_DOC_REF1")), "", row("MOV_T_DOC_REF1")) = "SOLM" Then
                            nro_prd = ELTBKARDEXBL.SelPrdSolm("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                            If nro_prd.Length = 0 Then
                                nro_prd = ELTBKARDEXBL.SelPrdSolmSABC("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                         IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                         IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                            End If
                        End If
                        If IIf(IsDBNull(row("MOV_T_DOC_REF1")), "", row("MOV_T_DOC_REF1")) = "REIN" Then
                            nro_prd = ELTBKARDEXBL.SelNroRein("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                        End If
                        If IIf(IsDBNull(row("MOV_T_DOC_REF1")), "", row("MOV_T_DOC_REF1")) = "RFAL" Then
                            nro_prd = ELTBKARDEXBL.SelNroFall("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                        End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                            Try
                                'PRECIO
                                nro_prd = ELTBKARDEXBL.SelNroRein("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                If nro_prd = "" Then
                                    nro_prd = ELTBKARDEXBL.SelNroReinSABC("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                              IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                              IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                              IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                End If
                                Dim F As Date = IIf(IsDBNull(row("FECHA")), "", row("FECHA"))
                                If IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")) = "0213485" Then
                                    Dim ll As String = ""
                                End If

                                If (nro_prd).Length > 0 Then
                                    dt2 = ELTBKARDEXBL.SelPrecioPRDSolmKARDEXK(nro_prd,
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                 "S23", F)
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_salida")), 0, row1("precio_salida")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_salida")), 0, row1("precio_salida"))
                                        Else
                                            'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                    If precioentrada = 0 Then
                                        If dgvtcod3.Rows.Count > 0 Then
                                            If cmbaño3.Text = "2022" Then
                                                If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                   dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "S23" Then
                                                    precioentrada = preciosalida
                                                ElseIf dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                        (dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E23" Or dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "S28" Or
                                                        dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E10" Or dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E24") Then
                                                    precioentrada = preciosaldo
                                                Else
                                                    precioentrada = preciosaldo
                                                End If
                                            Else
                                                If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                   dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "S23" Then
                                                    precioentrada = preciosalida
                                                ElseIf dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                        dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E23" Then
                                                    precioentrada = preciosaldo
                                                Else
                                                    precioentrada = preciosaldo
                                                End If
                                            End If

                                        End If
                                    End If
                                    dt2 = Nothing
                                End If
                            Catch ex As Exception
                            End Try
                        End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), "", row("MOV_CODTRA")) = "E12" Then
                            Try
                                'BUSQUEDA DE ORDEN DE PRODUCCION
                                nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                                    'PRECIO
                                    dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                        Else
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                End If
                            Catch ex As Exception
                            End Try
                        End If
                        'If contador = 88 Then
                        '    contador = contador
                        'End If
                        'If IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")) = "05042844" Then
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
                                    'contador = contador -  1
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
                                            If costosaldo < 0 Then
                                                costosaldo = 0
                                            End If
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
                            ElseIf IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))

                                                dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text, "1")
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
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
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text, "1")
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
                                        acumulado = Math.Round(acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")), 3)
                                        contadorsalida = contadorsalida + 1
                                        costoentrada = 0
                                        'If IIf(IsDBNull(row("TIPO_DOC")), 0, row("TIPO_DOC")) = "07" Then
                                        '    preciosalida = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        'Else
                                        preciosalida = Math.Round(preciosaldo, 4)
                                        'End If

                                        precioentrada = 0
                                        cantidadsaldo = acumulado
                                        costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                        costosaldo = Math.Round(acumuladocosto, 2) - Math.Round(costosalida, 2) 'acumulado * preciosaldo
                                        If costosaldo < 0 Then
                                            costosaldo = 0
                                        End If
                                        'costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
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
                                                Else 'SelPrecioOC
                                                    Dim MS1 As String = cmbaño3.Text & mes(cmbmes3.Text)
                                                    Dim MS2 As String = cmbaño3.Text & mes(cmbmes4.Text)
                                                    dt2 = ELTBKARDEXBL.SelPrecioOc(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
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
                                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text, "1")
                                                    For Each row1 As DataRow In dt2.Rows
                                                        entralop = entralop + 1
                                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                        Else
                                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                        End If
                                                    Next
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    preciosalida = 0
                                                Else
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
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
                                                If IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")) = "07" Then
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                Else
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
                                                Dim MS1 As String = cmbaño3.Text & mes(cmbmes3.Text)
                                                Dim MS2 As String = cmbaño3.Text & mes(cmbmes4.Text)
                                                dt2 = ELTBKARDEXBL.SelPrecioOc(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                             IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                             IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
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
                                    If dt2.Rows.Count = 0 Then
                                        Dim MS1 As String = cmbaño3.Text & mes(cmbmes3.Text)
                                        Dim MS2 As String = cmbaño3.Text & mes(cmbmes4.Text)
                                        dt2 = ELTBKARDEXBL.SelPrecioOc(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                     IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
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
                                    'acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text, "1")
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
                            If costosaldo < 0 Then
                                costosaldo = costosaldo
                                contador = contador
                            End If
                            dgvt_doc3.Rows.Add(IIf(IsDBNull(row("nInicial")), 0, row("nInicial")), '0
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
                                                                 nro_prd,'32 
                                                                 costosalida, cuentadt, cuenta_destdt) '32
                        End If
                        val_c = 0
                        'End If
                    Next
                Next
            Else 'REPROCESO DE TRANSFERENCIA Y REINGRESO
                contador = 0
                For Each Registro In dw.Rows
                    If cmbaño3.Text = "2022" Then
                        dt1 = ELTBKARDEXBL.SelRowKarx6(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                       IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")))
                    ElseIf cmbaño3.Text = "2023" Then
                        dt1 = ELTBKARDEXBL.SelRowKarx7(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text), gsCodAlm,
                                       IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")))
                    End If
                    Dim dtFecCompra As New DataTable
                    Dim fila As DataRow = dt1.NewRow()
                    If dt1.Rows.Count > 0 Then
                        For Each row As DataRow In dt1.Rows
                            If row("TIPO_DOC") = "07" Then
                                row("CANT_SALIDA") = row("CANT_ENTRADA")
                                row("CANT_ENTRADA") = 0
                            End If
                        Next
                    End If
                    Dim INICIAL As Double = 0
                    Dim c As Integer = 0
                    Dim val_c As Integer = 0
                    Dim nro_prd As String = ""
                    For Each row As DataRow In dt1.Rows
                        contador = contador + 1
                        cuentadt = ""
                        cuenta_destdt = ""
                        If IIf(IsDBNull(row("MOV_CODTRA")), "", row("MOV_CODTRA")) = "E19" Then
                            If IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")) = "07" Then
                                Dim MS1 As String = cmbaño3.Text & mes(cmbmes3.Text)
                                Dim MS2 As String = cmbaño3.Text & mes(cmbmes4.Text)
                                dt3 = ELTBKARDEXBL.SelCuentaComprasNC(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
                                For Each row1 As DataRow In dt3.Rows
                                    cuentadt = IIf(IsDBNull(row1("cuenta")), "", row1("cuenta"))
                                Next
                                dt3 = ELTBKARDEXBL.SelCuenta_destComprasNC(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), MS1, MS2)
                                For Each row1 As DataRow In dt3.Rows
                                    cuenta_destdt = IIf(IsDBNull(row1("cuenta_dest")), "", row1("cuenta_dest"))
                                Next

                            Else
                                If IIf(IsDBNull(row("cuenta")), "", row("cuenta")) = "" Then
                                    dt3 = ELTBKARDEXBL.SelCuentaCompras(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                 IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),
                                                                 IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text)
                                    For Each row1 As DataRow In dt3.Rows
                                        cuentadt = IIf(IsDBNull(row1("cuenta")), "", row1("cuenta"))
                                    Next
                                End If
                                If IIf(IsDBNull(row("cuenta_dest")), "", row("cuenta_dest")) = "" Then
                                    dt3 = ELTBKARDEXBL.SelCuenta_destCompras(IIf(IsDBNull(row("TIPO_DOC")), "", row("TIPO_DOC")),
                                                                  IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                                  IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño3.Text)
                                    For Each row1 As DataRow In dt3.Rows
                                        cuenta_destdt = IIf(IsDBNull(row1("cuenta_dest")), "", row1("cuenta_dest"))
                                    Next
                                End If
                            End If
                        Else
                            If IIf(IsDBNull(row("MOV_CODTRA")), "", row("MOV_CODTRA")) = "02" Then
                                cuentadt = IIf(IsDBNull(row("cuenta")), "", row("cuenta"))
                                cuenta_destdt = IIf(IsDBNull(row("cuenta_dest")), "", row("cuenta_dest"))
                            End If
                        End If
                        If IIf(IsDBNull(row("MOV_T_DOC_REF1")), "", row("MOV_T_DOC_REF1")) = "SOLM" Then
                            nro_prd = ELTBKARDEXBL.SelPrdSolm("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                            If nro_prd.Length = 0 Then
                                nro_prd = ELTBKARDEXBL.SelPrdSolmSABC("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                         IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                         IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                            End If
                        End If
                        If IIf(IsDBNull(row("MOV_T_DOC_REF1")), "", row("MOV_T_DOC_REF1")) = "REIN" Then
                            nro_prd = ELTBKARDEXBL.SelNroRein("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                        End If
                        If IIf(IsDBNull(row("MOV_T_DOC_REF1")), "", row("MOV_T_DOC_REF1")) = "RFAL" Then
                            nro_prd = ELTBKARDEXBL.SelNroFall("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                        End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                            Try
                                'PRECIO
                                nro_prd = ELTBKARDEXBL.SelNroRein("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                If nro_prd = "" Then
                                    nro_prd = ELTBKARDEXBL.SelNroReinSABC("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                              IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                              IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                              IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                End If
                                Dim F As Date = IIf(IsDBNull(row("FECHA")), "", row("FECHA"))
                                If IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")) = "0213485" Then
                                    Dim ll As String = ""
                                End If

                                If (nro_prd).Length > 0 Then
                                    dt2 = ELTBKARDEXBL.SelPrecioPRDSolmKARDEXK(nro_prd,
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                 "S23", F)
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_salida")), 0, row1("precio_salida")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_salida")), 0, row1("precio_salida"))
                                        Else
                                            'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                    If cmbaño3.Text = "2022" Then
                                        If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                   dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "S23" Then
                                            precioentrada = preciosalida
                                        ElseIf dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                        (dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E23" Or dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "S28" Or
                                                        dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E10" Or dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E24") Then
                                            precioentrada = preciosaldo
                                        Else
                                            precioentrada = preciosaldo
                                        End If
                                    Else
                                        If dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                   dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "S23" Then
                                            precioentrada = preciosalida
                                        ElseIf dgvt_doc3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) And
                                                        dgvt_doc3.Rows(contador - 2).Cells("T_MOVIN").Value = "E23" Then
                                            precioentrada = preciosaldo
                                        Else
                                            precioentrada = preciosaldo
                                        End If
                                    End If
                                    dt2 = Nothing
                                End If
                            Catch ex As Exception
                            End Try
                        End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), "", row("MOV_CODTRA")) = "E12" Then
                            Try
                                'BUSQUEDA DE ORDEN DE PRODUCCION
                                nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                                    'PRECIO
                                    dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                        Else
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                End If
                            Catch ex As Exception
                            End Try
                        End If
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
                                    'contador = contador -  1
                                    If dgvretrans3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                    If dgvretrans3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                        If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                            contadorsalida = contadorsalida + 1
                                            costoentrada = 0
                                            preciosalida = preciosaldo
                                            precioentrada = 0
                                            cantidadsaldo = acumulado
                                            costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                            costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                            If costosaldo < 0 Then
                                                costosaldo = 0
                                            End If
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
                            ElseIf IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                               IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                If dgvretrans3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))

                                                dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
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
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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

                                If dgvretrans3.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then

                                    If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                        acumulado = Math.Round(acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")), 3)
                                        contadorsalida = contadorsalida + 1
                                        costoentrada = 0
                                        preciosalida = Math.Round(preciosaldo, 4)
                                        precioentrada = 0
                                        cantidadsaldo = acumulado
                                        costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                        costosaldo = Math.Round(acumuladocosto, 2) - Math.Round(costosalida, 2) 'acumulado * preciosaldo
                                        If costosaldo < 0 Then
                                            costosaldo = 0
                                        End If
                                        'costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
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
                                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
                                                    For Each row1 As DataRow In dt2.Rows
                                                        entralop = entralop + 1
                                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                        Else
                                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                        End If
                                                    Next
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    preciosalida = 0
                                                Else
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) <> "E12" Then
                                                        precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    End If
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                                        Try
                                            'BUSQUEDA DE ORDEN DE PRODUCCION
                                            nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                            'PRECIO
                                            dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                        Catch ex As Exception

                                        End Try

                                    End If
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) <> "E12" Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
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
                                    'acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) <> "E12" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                    preciopromentrada = precioentrada 'precioentrada + preciopromentrada
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    costosaldo = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    acumuladocosto = costosaldo
                                    preciosalida = 0
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosaldo = preciopromentrada
                                End If
                            End If
                        End If
                        If val_c = 0 Then
                            If costosaldo < 0 Then
                                costosaldo = costosaldo
                                contador = contador
                            End If
                            dgvretrans3.Rows.Add(INICIAL, '0
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
                                                             nro_prd,'32   
                                                             costosalida, cuentadt, cuenta_destdt) '33
                        End If
                        val_c = 0
                        dtrans = 1
                    Next
                Next
            End If

            If dc = 1 Then
                If dwCN = 0 Then
                    dw = Nothing
                    dw = ELTBKARDEXBL.SelPrecioTransf3(cmbaño3.Text, mes(cmbmes3.Text), mes(cmbmes4.Text))
                    For Each row As DataRow In dw.Rows
                        dgvtransferencia3.Rows.Add(IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                  IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                  IIf(IsDBNull(row("NRO_PRECIOSALDO")), 0, row("NRO_PRECIOSALDO")), cmbaño3.Text)
                    Next
                    gsCode13 = "5"
                    gsCode12 = "1"
                    SaveData()
                    gsCode12 = ""
                    gsCode13 = "4"
                    SaveData()
                    gsCode13 = ""
                    Dim see As String
                End If
                dwCN = dwCN + 1
            Else
                dwCN = 2
                If dgvretrans3.Rows.Count >= 0 Then
                    gsCode13 = "5"
                    gsCode12 = "1"
                    gsCode11 = "3"
                    SaveData()
                    gsCode13 = ""
                    gsCode12 = ""
                    gsCode11 = ""
                End If
            End If

        Loop While dwCN < 2
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_VALOR_2019_EXCEL_PRUEBA.rpt"
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
        gsCode13 = "5"
        gsCode11 = ""
        SaveData()
        gsCode13 = ""
    End Sub

    Private Sub btncons3_Click(sender As Object, e As EventArgs) Handles btncons3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsRptArgs(2) = ""
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_TOTAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndif3_Click(sender As Object, e As EventArgs) Handles btndif3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsRptArgs(2) = ""
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFALMTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsal3_Click(sender As Object, e As EventArgs) Handles btndifsal3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALTEMP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btndifsaldo3_Click(sender As Object, e As EventArgs) Handles btndifsaldo3.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = txtsublinea3.Text
        gsRptArgs(2) = ""
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTKARDEX_DIFSALDOTEMP.rpt"
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_VALOR_FAMILIA.rpt"
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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Cursor.Current = Cursors.WaitCursor
        If txtsublinea4.TextLength = 0 And txtcodart4.Text = "" And txtfam_Cod4.Text = "" Then
            If MessageBox.Show("Desea generar el kardex",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            'Exit Sub
        End If
        dgvtcod4.DataSource = Nothing
        dgvt_doc4.Rows.Clear()
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
        Dim calm As String = Mid(cmbalmacen4.Text, 1, 4)
        'dt = ELTBKARDEXBL.SelRow1()

        dt = ELTBKARDEXBL.SelRow3(txtsublinea4.Text, txtfam_Cod4.Text, txtcodart4.Text, cmbaño4.Text)
        dgvtcod4.DataSource = dt
        For Each Registro In dt.Rows
            If cmbaño4.Text >= "2021" Then
                dt1 = ELTBKARDEXBL.SelRowKar7(cmbaño4.Text, mes(cmbmes4.Text), mes(cmbmes4.Text), gsCodAlm,
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
                            If dgvt_doc4.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                            If dgvt_doc4.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                        If dgvt_doc4.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                                        IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño4.Text, "3")
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
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño4.Text, "3")
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

                        If dgvt_doc4.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                                     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño4.Text, "3")
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
                    dgvt_doc4.Rows.Add(IIf(IsDBNull(row("nInicial")), 0, row("nInicial")), '0
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

    Private Function procesarArticulo(ByVal row As DataRow, ByVal dt1 As DataTable) As DataRow

        Dim fila As DataRow = dt1.NewRow()
        fila(0) = row(0)
        fila(1) = row(1)
        fila(2) = row(2)
        fila(3) = row(3)
        fila(4) = row(4)
        fila(5) = row(5)
        fila(6) = row(6)
        fila(7) = row(7)
        fila(8) = row(8)
        fila(9) = Convert.ToDateTime("17/08/2022")
        fila(10) = row(10)
        fila(11) = row(11)
        fila(12) = "2542-1"
        fila(13) = row(13)
        fila(14) = row(14)
        fila(15) = row(15)
        fila(16) = 800
        fila(17) = row(17)
        fila(18) = row(18)
        fila(19) = row(19)
        fila(20) = row(20)
        fila(21) = row(21)
        fila(22) = row(22)
        fila(23) = row(23)
        fila(24) = row(24)
        fila(25) = row(25)
        fila(26) = row(26)
        Return fila
    End Function

    Private Function procesarArticulo1(ByVal row As DataRow, ByVal dt1 As DataTable) As DataRow

        Dim fila As DataRow = dt1.NewRow()
        fila(0) = row(0)
        fila(1) = row(1)
        fila(2) = row(2)
        fila(3) = row(3)
        fila(4) = row(4)
        fila(5) = row(5)
        fila(6) = row(6)
        fila(7) = row(7)
        fila(8) = row(8)
        fila(9) = Convert.ToDateTime("01/06/2022")
        fila(10) = "SALM"
        fila(11) = "ALM"
        fila(12) = "0216405"
        fila(13) = "E19"
        fila(14) = "02"
        fila(15) = "COMPRA"
        fila(16) = 45
        fila(17) = 0
        fila(18) = row(18)
        fila(19) = row(19)
        fila(20) = 15.41
        fila(21) = "E19"
        fila(22) = "ENTRADA POR COMPRA"
        fila(23) = row(23)
        fila(24) = row(24)
        fila(25) = row(25)
        fila(26) = row(26)
        Return fila
    End Function

    Private Sub btnactop_Click(sender As Object, e As EventArgs) Handles btnactop.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Cursor.Current = Cursors.WaitCursor
        Dim dc As Integer = 0
        If txtsublinea5.TextLength = 0 And txtcodart5.Text = "" Then
            If MessageBox.Show("Desea generar el kardex",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            dc = 1
            'Exit Sub
        End If
        If txtcodart5.TextLength = 0 Then
            dc = 1
        End If

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
        Dim dw As DataTable
        Dim dwCN As Double = 0

        Do
            If dwCN = 0 Then
                dgvtcod5.DataSource = Nothing
                dgvt_doc5.Rows.Clear()
                dgvretrans.DataSource = Nothing
                dgvretrans.Rows.Clear()
                contador = 0
                'dt = ELTBKARDEXBL.SelRow1()
                dt = ELTBKARDEXBL.SelRow4(txtsublinea5.Text, txtcodart5.Text, cmbaño5.Text)
                dgvtcod5.DataSource = dt
                For Each Registro In dt.Rows
                    If cmbaño5.Text = "2022" Then
                        dt1 = ELTBKARDEXBL.SelRowKarPP6(cmbaño5.Text, mes(cmbmes7.Text), mes(cmbmes8.Text), gsCodAlm,
                                       IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
                    ElseIf cmbaño5.Text = "2023" Then
                        dt1 = ELTBKARDEXBL.SelRowKarPP6(cmbaño5.Text, mes(cmbmes7.Text), mes(cmbmes8.Text), gsCodAlm,
                                       IIf(IsDBNull(Registro("STK_CODART")), "", Registro("STK_CODART")))
                    End If
                    Dim dtFecCompra As New DataTable
                    Dim fila As DataRow = dt1.NewRow()
                    If dt1.Rows.Count > 0 Then
                        For Each row As DataRow In dt1.Rows
                            'If row("TIPO_OPERACION") = "E19" Then
                            '    dtFecCompra = ELTBKARDEXBL.ActualizarFechaCompra(row("ART_COD"), row("TIPO_DOC"), row("SERIE_NRO"), row("NRO_DOCU"))
                            '    If dtFecCompra.Rows.Count > 0 Then
                            '        'If dtFecCompra.Rows.Count > 0 And dtFecCompra.Rows(0).Item(0).ToString <> "" Then
                            '        If row("FECHA") >= dtFecCompra.Rows(0).Item(0) Then
                            '            row("FECHA") = dtFecCompra.Rows(0).Item(0)
                            '        End If
                            '    End If
                            'End If

                            If row("TIPO_DOC") = "07" Then
                                row("CANT_SALIDA") = row("CANT_ENTRADA")
                                row("CANT_ENTRADA") = 0
                            End If

                            'If row("ART_COD") = "05980072" And row("NRO_DOCU") = "2542" Then
                            '    fila = procesarArticulo(row, dt1)
                            '    row("CANT_ENTRADA") = 4000
                            'End If

                            'If row("ART_COD") = "05020337" And row("TIPO_OPERACION") = "S31" Then
                            '    fila = procesarArticulo1(row, dt1)
                            'End If
                        Next
                        'If IIf(IsDBNull(fila(12)), "", fila(12)) <> "" Then
                        '    dt1.Rows.Add(fila)
                        'End If
                        'dt1.DefaultView.Sort = ("FECHA ASC, TIPO_OPERACION ASC, NRO_DOCU ASC")
                        'dt1 = dt1.DefaultView.ToTable()
                    End If


                    Dim INICIAL As Double = 0
                    Dim c As Integer = 0
                    Dim val_c As Integer = 0
                    Dim nro_prd As String = ""
                    For Each row As DataRow In dt1.Rows
                        nro_prd = ""
                        contador = contador + 1
                        'If contador = 88 Then
                        '    contador = contador
                        'End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                            Try
                                'BUSQUEDA DE ORDEN DE PRODUCCION
                                nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                                    'PRECIO
                                    dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                    For Each row1 As DataRow In dt2.Rows
                                        entralop = entralop + 1
                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                        Else
                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                        End If
                                    Next
                                End If
                            Catch ex As Exception
                            End Try
                        End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "S23" Then
                            Try
                                'BUSQUEDA DE ORDEN DE PRODUCCION
                                nro_prd = ELTBKARDEXBL.SelNroSolmPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                dgvsolmnro.Rows.Add(IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                    nro_prd,
                                                    cmbaño5.Text,
                                                    IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                    IIf(IsDBNull(row("FECHA")), 0, row("FECHA")))
                            Catch ex As Exception
                            End Try
                        End If
                        'RECEPCION
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                            Try
                                'PRECIO
                                nro_prd = ELTBKARDEXBL.SelNroRein("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                dt2 = ELTBKARDEXBL.SelPrecioPRDSolm(nro_prd,
                                                                 IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                                                 "S23", IIf(IsDBNull(row("FECHA")), "", row("FECHA")))
                                For Each row1 As DataRow In dt2.Rows
                                    entralop = entralop + 1
                                    If IIf(IsDBNull(row1("precio_salida")), 0, row1("precio_salida")) > 0 Then
                                        precioentrada = IIf(IsDBNull(row1("precio_salida")), 0, row1("precio_salida"))
                                    Else
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                Next
                            Catch ex As Exception
                            End Try
                        End If
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
                                    'contador = contador -  1
                                    If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                    If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                        If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                            contadorsalida = contadorsalida + 1
                                            costoentrada = 0
                                            preciosalida = preciosaldo
                                            precioentrada = 0
                                            cantidadsaldo = acumulado
                                            costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                            costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                            If costosaldo < 0 Then
                                                costosaldo = 0
                                            End If
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
                            ElseIf IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                               IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))

                                                dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
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
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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

                                If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then

                                    If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                        acumulado = Math.Round(acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")), 3)
                                        contadorsalida = contadorsalida + 1
                                        costoentrada = 0
                                        preciosalida = Math.Round(preciosaldo, 4)
                                        precioentrada = 0
                                        cantidadsaldo = acumulado
                                        costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                        costosaldo = Math.Round(acumuladocosto, 2) - Math.Round(costosalida, 2) 'acumulado * preciosaldo
                                        If costosaldo < 0 Then
                                            costosaldo = 0
                                        End If
                                        'costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
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
                                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                    'dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                    '     IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                    '     IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text)
                                                    'For Each row1 As DataRow In dt2.Rows
                                                    '    entralop = entralop + 1
                                                    '    If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    '        precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                    '    Else
                                                    '        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    '    End If
                                                    'Next
                                                    ' linea 4488 se declara
                                                    'precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    preciosalida = 0
                                                Else
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) <> "E12" Then
                                                        precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    End If
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                                        Try
                                            'BUSQUEDA DE ORDEN DE PRODUCCION
                                            nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                            'PRECIO
                                            dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                        Catch ex As Exception

                                        End Try

                                    End If
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) <> "E12" Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
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
                                    'acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) <> "E12" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                    preciopromentrada = precioentrada 'precioentrada + preciopromentrada
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    costosaldo = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    acumuladocosto = costosaldo
                                    preciosalida = 0
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosaldo = preciopromentrada
                                End If
                            End If
                        End If
                        If val_c = 0 Then
                            If costosaldo < 0 Then
                                costosaldo = costosaldo
                                contador = contador
                            End If
                            dgvt_doc5.Rows.Add(INICIAL, '0
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
                                                             nro_prd,'32   
                                                             costosalida) '33
                        End If
                        val_c = 0
                    Next
                Next
            Else 'REPROCESO DE TRANSFERENCIA Y REINGRESO
                'dgvtcod5.DataSource = Nothing
                'dgvt_doc5.Rows.Clear()
                contador = 0
                'dt = ELTBKARDEXBL.SelRow4(txtsublinea5.Text, txtcodart5.Text, cmbaño5.Text)
                'dgvtcod5.DataSource = dw
                For Each Registro In dw.Rows
                    If cmbaño5.Text = "2022" Then
                        dt1 = ELTBKARDEXBL.SelRowKarPP6(cmbaño5.Text, mes(cmbmes7.Text), mes(cmbmes8.Text), gsCodAlm,
                                       IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")))
                    ElseIf cmbaño5.Text = "2023" Then
                        dt1 = ELTBKARDEXBL.SelRowKarPP6(cmbaño5.Text, mes(cmbmes7.Text), mes(cmbmes8.Text), gsCodAlm,
                                       IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")))
                    End If
                    Dim dtFecCompra As New DataTable
                    Dim fila As DataRow = dt1.NewRow()
                    If dt1.Rows.Count > 0 Then
                        For Each row As DataRow In dt1.Rows
                            If row("TIPO_DOC") = "07" Then
                                row("CANT_SALIDA") = row("CANT_ENTRADA")
                                row("CANT_ENTRADA") = 0
                            End If
                        Next
                    End If


                    Dim INICIAL As Double = 0
                    Dim c As Integer = 0
                    Dim val_c As Integer = 0
                    Dim nro_prd As String = ""
                    For Each row As DataRow In dt1.Rows
                        contador = contador + 1
                        'If contador = 88 Then
                        '    contador = contador
                        'End If
                        If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                            Try
                                'BUSQUEDA DE ORDEN DE PRODUCCION
                                nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                'PRECIO
                                dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                For Each row1 As DataRow In dt2.Rows
                                    entralop = entralop + 1
                                    If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                        precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                    Else
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                Next
                            Catch ex As Exception
                            End Try
                        End If
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
                                    'contador = contador -  1
                                    If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                    If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
                                        If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                            acumulado = acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                            contadorsalida = contadorsalida + 1
                                            costoentrada = 0
                                            preciosalida = preciosaldo
                                            precioentrada = 0
                                            cantidadsaldo = acumulado
                                            costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                            costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
                                            If costosaldo < 0 Then
                                                costosaldo = 0
                                            End If
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
                            ElseIf IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                               IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E18" Or
                                            IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) = "E23" Then
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))

                                                dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                            IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                            IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                acumulado = acumulado - IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                contadorentrada = contadorentrada + 1
                                                cantentrada = -IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
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
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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

                                If dgvt_doc5.Rows(contador - 2).Cells("ART_COD").Value = IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then

                                    If IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA")) = 0 Then
                                        acumulado = Math.Round(acumulado - IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA")), 3)
                                        contadorsalida = contadorsalida + 1
                                        costoentrada = 0
                                        preciosalida = Math.Round(preciosaldo, 4)
                                        precioentrada = 0
                                        cantidadsaldo = acumulado
                                        costosalida = preciosalida * IIf(IsDBNull(row("CANT_SALIDA")), 0, row("CANT_SALIDA"))
                                        costosaldo = Math.Round(acumuladocosto, 2) - Math.Round(costosalida, 2) 'acumulado * preciosaldo
                                        If costosaldo < 0 Then
                                            costosaldo = 0
                                        End If
                                        'costosaldo = acumuladocosto - costosalida 'acumulado * preciosaldo
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
                                                If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E17" Then
                                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
                                                    For Each row1 As DataRow In dt2.Rows
                                                        entralop = entralop + 1
                                                        If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                            precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                        Else
                                                            precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                        End If
                                                    Next
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    preciosalida = 0
                                                Else
                                                    contadorentrada = contadorentrada + 1
                                                    cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) <> "E12" Then
                                                        precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                    End If
                                                    'precioentrada = preciosaldo 'IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) = "E12" Then
                                        Try
                                            'BUSQUEDA DE ORDEN DE PRODUCCION
                                            nro_prd = ELTBKARDEXBL.SelNroPrd("SALM", IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                          IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                          IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO")))
                                            'PRECIO
                                            dt2 = ELTBKARDEXBL.SelPrecioPRD(nro_prd,
                                                             IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
                                            For Each row1 As DataRow In dt2.Rows
                                                entralop = entralop + 1
                                                If IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni")) > 0 Then
                                                    precioentrada = IIf(IsDBNull(row1("precio_uni")), 0, row1("precio_uni"))
                                                Else
                                                    precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                                End If
                                            Next
                                        Catch ex As Exception

                                        End Try

                                    End If
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
                                            If IIf(IsDBNull(row("MOV_CODTRA")), 0, row("MOV_CODTRA")) <> "E12" Then
                                                precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                            End If
                                            cantentrada = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
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
                                    'acumulado = acumulado + IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    dt2 = ELTBKARDEXBL.SelPrecio2(IIf(IsDBNull(row("SERIE_NRO")), "", row("SERIE_NRO")),'12
                                                         IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),
                                                         IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")), cmbaño5.Text, "2")
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
                                    If IIf(IsDBNull(row("MOV_CODTRA")), "0", row("MOV_CODTRA")) <> "E12" Then
                                        precioentrada = IIf(IsDBNull(row("PRECIO")), 0, row("PRECIO"))
                                    End If
                                    preciopromentrada = precioentrada 'precioentrada + preciopromentrada
                                    costoentrada = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    costosaldo = precioentrada * IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    acumuladocosto = costosaldo
                                    preciosalida = 0
                                    cantidadsaldo = IIf(IsDBNull(row("CANT_ENTRADA")), 0, row("CANT_ENTRADA"))
                                    preciosaldo = preciopromentrada
                                End If
                            End If
                        End If
                        If val_c = 0 Then
                            If costosaldo < 0 Then
                                costosaldo = costosaldo
                                contador = contador
                            End If
                            dgvretrans.Rows.Add(INICIAL, '0
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
                                                             nro_prd,'32   
                                                             costosalida) '33
                        End If
                        val_c = 0
                    Next
                Next
            End If
            If dc = 1 Then
                If dwCN = 0 Then
                    dw = Nothing
                    dw = ELTBKARDEXBL.SelPrecioTransf(cmbaño5.Text, mes(cmbmes7.Text), mes(cmbmes8.Text))
                    For Each row As DataRow In dw.Rows
                        dgvtransferencia.Rows.Add(IIf(IsDBNull(row("SERIE_NRO")), 0, row("SERIE_NRO")),
                                                  IIf(IsDBNull(row("NRO_DOCU")), 0, row("NRO_DOCU")),
                                                  IIf(IsDBNull(row("ART_COD")), 0, row("ART_COD")),
                                                  IIf(IsDBNull(row("NRO_PRECIOSALDO")), 0, row("NRO_PRECIOSALDO")), cmbaño5.Text)
                    Next
                    gsCode13 = "2"
                    SaveData()
                End If
                gsCode13 = "3"
                SaveData()
                dwCN = dwCN + 1
            Else
                dwCN = 2
            End If

        Loop While dwCN < 2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvt_doc5.Rows.Count = 0 Then
            MsgBox("No ah realizado ninguna corrida de articulos")
            Exit Sub
        End If
        gsCode13 = "2"
        SaveData()
        gsCode13 = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(5)
        gsRptArgs(0) = cmbaño5.Text
        gsRptArgs(1) = mes(cmbmes7.Text)
        gsRptArgs(2) = mes(cmbmes8.Text)
        gsRptArgs(3) = txtsublinea5.Text
        gsRptArgs(4) = txtcodart5.Text
        gsRptArgs(5) = "3"
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_VALOR_2019_EXCEL_PRUEBA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnKardexProd_Click(sender As Object, e As EventArgs) Handles btnKardexProd.Click
        If cmbmes4.SelectedIndex = -1 Then
            MsgBox("Ingrese el mes")
            Exit Sub
        End If
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(4)
        gsRptArgs(0) = cmbaño3.Text
        gsRptArgs(1) = mes(cmbmes3.Text)
        gsRptArgs(2) = mes(cmbmes4.Text)
        gsRptArgs(3) = txtfam_Cod3.Text
        gsRptArgs(4) = txtcodart3.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_KARDEXTEMP_PROD1.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim dt As DataTable
        dgvretransc.Rows.Clear()
        dt = ELTBKARDEXBL.SelectTEMP_KARDEX_MOV(cmbaño2.Text)
        For Each row1 As DataRow In dt.Rows
            dgvretransc.Rows.Add(IIf(IsDBNull(row1("SERIE_NRO")), "", row1("SERIE_NRO")),
                                 IIf(IsDBNull(row1("NRO_DOCU")), "", row1("NRO_DOCU")),
                                 IIf(IsDBNull(row1("ART_COD")), "", row1("ART_COD")),
                                 IIf(IsDBNull(row1("FECHA")), "", row1("FECHA")),
                                 IIf(IsDBNull(row1("PRECIO_SALIDA")), "", row1("PRECIO_SALIDA")),
                                 IIf(IsDBNull(row1("S_REFERENCIA")), "", row1("S_REFERENCIA")),
                                 IIf(IsDBNull(row1("N_REFERENCIA")), "", row1("N_REFERENCIA")),
                                 IIf(IsDBNull(row1("ART_REFERENCIA")), "", row1("ART_REFERENCIA")))
        Next
        gsCode13 = "7"
        SaveDataItmKar()
    End Sub

    Private Sub SaveDataItmKar()
        If MessageBox.Show("Desea grabar el Registro",
                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim ELTBKARDEXITEMBE As New ELTBKARDEXITEMBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        'ELTBKARDEXITEMBE.T_DOC_REF = txtt_doc.Text
        'ELTBKARDEXITEMBE.SER_DOC_REF = txts_doc.Text
        'ELTBKARDEXITEMBE.NRO_DOC_REF = txtn_doc.Text
        'ELTBKARDEXITEMBE.ART_COD = txtart_cod.Text
        'ELTBKARDEXITEMBE.PERIODO = cmbaño.Text
        'ELTBKARDEXITEMBE.UPRECIO_COMPRA = npdprecio.Value

        For i = 0 To dgvretransc.Rows.Count - 1
            ELTBKARDEXITEMBE.T_DOC_REF = "SALM"
            ELTBKARDEXITEMBE.SER_DOC_REF = dgvretransc.Rows(i).Cells("S_REFERENCIA").Value
            ELTBKARDEXITEMBE.NRO_DOC_REF = dgvretransc.Rows(i).Cells("N_REFERENCIA").Value
            ELTBKARDEXITEMBE.ART_COD = dgvretransc.Rows(i).Cells("ART_REFERENCIA").Value
            ELTBKARDEXITEMBE.FEC_GENE = dgvretransc.Rows(i).Cells("FECHA").Value
            ELTBKARDEXITEMBE.UPRECIO_COMPRA = dgvretransc.Rows(i).Cells("PRECIO_SALIDA").Value
            ELTBKARDEXITEMBE.TIPO = "1"
            ELTBKARDEXITEMBE.PERIODO = cmbaño2.Text
            gsError = ELTBKARDEXITEMBL.SaveRow(ELTBKARDEXITEMBE, ELMVLOGSBE, "E")
        Next
        For i = 0 To dgvretransc.Rows.Count - 1
            ELTBKARDEXITEMBE.T_DOC_REF = "SALM"
            ELTBKARDEXITEMBE.SER_DOC_REF = dgvretransc.Rows(i).Cells("S_REFERENCIA").Value
            ELTBKARDEXITEMBE.NRO_DOC_REF = dgvretransc.Rows(i).Cells("N_REFERENCIA").Value
            ELTBKARDEXITEMBE.ART_COD = dgvretransc.Rows(i).Cells("ART_REFERENCIA").Value
            ELTBKARDEXITEMBE.FEC_GENE = dgvretransc.Rows(i).Cells("FECHA").Value
            ELTBKARDEXITEMBE.UPRECIO_COMPRA = dgvretransc.Rows(i).Cells("PRECIO_SALIDA").Value
            ELTBKARDEXITEMBE.TIPO = "1"
            ELTBKARDEXITEMBE.X_PRECIO = "1"
            ELTBKARDEXITEMBE.PERIODO = cmbaño2.Text
            If ELTBKARDEXITEMBE.SER_DOC_REF.Length > 0 Then
                gsError = ELTBKARDEXITEMBL.SaveRow(ELTBKARDEXITEMBE, ELMVLOGSBE, "N")
            End If

        Next
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
        'End If
        'Dim dt As DataTable
        'FormELTB_KARDEXITEM.dgvt_doc.Rows.Clear()
        ''FormELTB_KARDEXITEM.dgvt_doc.Rows.DATASOURCE = "" 
        ''If txtart_cod.TextLength > 0 Then
        'dt = ELTBKARDEXITEMBL.SelectRow(txtart_cod.Text, cmbaño.Text, 1, "")
        '    For Each row As DataRow In dt.Rows
        '        FormELTB_KARDEXITEM.dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
        '                          IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
        '                          IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
        '                          IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'3
        '                          IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'4
        '                          IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'5
        '                          IIf(IsDBNull(row("T_MOVINV")), "", row("T_MOVINV")),'6
        '                          IIf(IsDBNull(row("UPRECIO_COMPRA")), "", row("UPRECIO_COMPRA")),'7
        '                          IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'8
        '                          IIf(IsDBNull(row("X_FEC")), "", row("X_FEC")),'9
        '                          IIf(IsDBNull(row("X_SUP")), "", row("X_SUP")), '10
        '                          IIf(IsDBNull(row("X_CANT")), "", row("X_CANT")), '11
        '                          IIf(IsDBNull(row("X_PRECIO")), "", row("X_PRECIO")), '11
        '                          IIf(IsDBNull(row("PERIODO")), "", row("PERIODO"))) '12
        '    Next
        'End If
    End Sub
End Class