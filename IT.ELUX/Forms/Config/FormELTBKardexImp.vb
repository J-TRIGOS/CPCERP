Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormELTBKardexImp
    Private ELTBKARDEXIMPBL As New ELTBKARDEXIMPBL

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim FRM As New FormDocuRefKardexImp
        FRM.ShowDialog()
    End Sub

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
            exHoja.Cells.Item(1, 1) = "Razon Social" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 2) = "Apellido Paterno" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 3) = "Apellido Materno" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 4) = "Tipo Documento" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 5) = "RUC/DNI" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 6) = "Nº Letra o Factura" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 7) = "Vencimiento" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 8) = "Importe" 'ElGrid.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            'Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
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

    Private Sub FormELTBKardexImp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = ELTBKARDEXIMPBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        txtt_doc.Text = "DIMP"
        cmbt_doc.SelectedIndex = 0
        dgvt_doc.Columns.Add("T_DOC_REF", "TIPO") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "SERIE") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "NUMERO") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "TIPO") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "SERIE") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "NUMERO") '5
        dgvt_doc.Columns.Add("FEC_GENE", "FECHA") '6
        dgvt_doc.Columns.Add("UNIDAD", "UNIDAD") '7
        dgvt_doc.Columns.Add("ART_COD", "ARTICULO") '8
        dgvt_doc.Columns.Add("NOM_ART", "DESCRIPCION") '9
        dgvt_doc.Columns.Add("CANTIDAD", "CANTIDAD") '10
        dgvt_doc.Columns.Add("PROVEEDOR", "PROVEEDOR") '11
        dgvt_doc.Columns.Add("UPRECIO_COMPRA", "PRECIO COMPRA") '12
        dgvt_doc.Columns.Add("UPRECIO_DCOMPRA", "PRECIO DCOMPRA") '13
        dgvt_doc.Columns.Add("T_IGV", "TOTAL IGV") '14
        dgvt_doc.Columns.Add("T_DIGV", "TOTAL DIGV") '15
        dgvt_doc.Columns.Add("EST", "ESTADO") '16
        dgvt_doc.Columns.Add("FEC_DOCU", "FEC. DOCUM.") '17
        dgvt_doc.Columns.Add("ADVALORE", "ADVALORE") '18
        dgvt_doc.Columns.Add("T_CMB", "TIPO CAMBIO") '19

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmb_serdoc.Text = DateTime.Now.ToString("yyyy")
                txtnumero.Text = ELTBKARDEXIMPBL.LastCodigo(cmb_serdoc.Text).PadLeft(7, "0")
                cmbestado.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                dt = ELTBKARDEXIMPBL.SelectRowdET(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dt.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'6
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'7
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'8
                                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'9
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'10
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'11
                                      IIf(IsDBNull(row("UPRECIO_COMPRA")), "", row("UPRECIO_COMPRA")),'12
                                      IIf(IsDBNull(row("UPRECIO_DCOMPRA")), "", row("UPRECIO_DCOMPRA")),'13
                                      IIf(IsDBNull(row("T_IGV")), "", row("T_IGV")),'14
                                      IIf(IsDBNull(row("T_DIGV")), "", row("T_DIGV")),'15
                                      IIf(IsDBNull(row("EST")), "", row("EST")),'16
                                      IIf(IsDBNull(row("FEC_DOCU")), "", row("FEC_DOCU")),'17
                                      IIf(IsDBNull(row("ADVALORE")), "", row("ADVALORE"))) '18
                Next
        End Select
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        dgvt_doc.Columns(6).Visible = False
        dgvt_doc.Columns(7).Visible = False
        dgvt_doc.Columns(11).Visible = False
        'dgvt_doc.Columns(12).Visible = False
        'dgvt_doc.Columns(13).Visible = False
        dgvt_doc.Columns(14).Visible = False
        dgvt_doc.Columns(15).Visible = False
        dgvt_doc.Columns(16).Visible = False
        dgvt_doc.Columns(17).Visible = False
        'dgvt_doc.Columns(18).Visible = False
        dgvt_doc.Columns(19).Visible = False
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ELTBKARDEXIMPBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 0
            Else
                cmbestado.SelectedIndex = 1
            End If
            txttprecio_compra.Text = IIf(IsDBNull(Registro("TPRECIO_COMPRA")), 0, Registro("TPRECIO_COMPRA"))
            txtt_dcto.Text = 0
            txtt_dcto_dolar.Text = 0
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), 0, Registro("TPRECIO_DCOMPRA"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), 0, Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_DIGV")), 0, Registro("T_DIGV"))
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), 0, Registro("MONEDA"))
            dtpfecdua.Text = IIf(IsDBNull(Registro("FEC_DUA")), 0, Registro("FEC_DUA"))
            txtnumdua.Text = IIf(IsDBNull(Registro("NUM_DUA")), "", Registro("NUM_DUA"))
            dtpfecnro.Text = IIf(IsDBNull(Registro("FEC_DOCU")), "", Registro("FEC_DOCU"))
            txt_nrofactimp.Text = IIf(IsDBNull(Registro("NRO_DOCU")), "", Registro("NRO_DOCU"))
            txtproveedor.Text = IIf(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            txtnomproveedor.Text = ELTBKARDEXIMPBL.SelectT_Prov(txtproveedor.Text)
            cmbmon.SelectedValue = IIf(IsDBNull(Registro("MONEDA")), 0, Registro("MONEDA"))
            txttcompras.Text = Val(txttprecio_compra.Text) + Val(txtt_igv.Text) + Val(txtt_dcto.Text)
            txttcomprad.Text = Val(txttprecio_dcompra.Text) + Val(txtt_igv_dolar.Text) + Val(txtt_dcto_dolar.Text)
            txtobservacion.Text = IIf(IsDBNull(Registro("observa")), 0, Registro("observa"))
            txtnro_oreq.Text = IIf(IsDBNull(Registro("NRO_OREQ")), 0, Registro("NRO_OREQ"))
        Next
    End Sub
    Private Sub txtproveedor_LostFocus(sender As Object, e As EventArgs) Handles txtproveedor.LostFocus
        If txtproveedor.TextLength > 0 Then
            Dim prov As String = ELTBKARDEXIMPBL.SelectT_Prov(txtproveedor.Text)
            If prov.Length > 0 Then
                txtnomproveedor.Text = prov
            Else
                txtnomproveedor.Text = ""
            End If
        Else
            txtproveedor.Text = ""
            txtnomproveedor.Text = ""
        End If
    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "105"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtproveedor.Text = gLinea
                txtnomproveedor.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        'If e.KeyValue = Keys.Enter Then
        '    txtobserva.Focus()
        'End If
    End Sub

    Private Sub FormELTBKardexImp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dispose()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           "Kardex Imp", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Dim mesaño As String
            Dim m As String
            Select Case sFunc

                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = RTrim(txtt_doc.Text)
                    gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                    gsRptArgs(2) = RTrim(txtnumero.Text)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_IMPRESION_FC.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub

                Case "anular"

                    If MessageBox.Show("Desea anular el documento",
                       "Kardex Imp.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If

                    'Dim FACTURACIONBE As New FACTURACIONBE
                    'Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    'FACTURACIONBE.T_DOC_REF = txtt_doc.Text
                    'FACTURACIONBE.SER_DOC_REF = cmb_serdoc.Text
                    'FACTURACIONBE.NRO_DOC_REF = txtnumero.Text

                    'Dim ELMVLOGSBE As New ELMVLOGSBE
                    'ELMVLOGSBE.log_codusu = gsCodUsr
                    'mesaño = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
                    'm = Mid(dtpfecha.Value, 4, 2)
                    'gsError = FACTURACIONBL.SaveRow(FACTURACIONBE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc)
                    'If gsError = "OK" Then
                    '    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    '    gsError2 = FACTURACIONBL.AsientoFC("Asiento", mesaño, m, RTrim(txtnumero.Text), cmb_serdoc.Text, txtt_doc.Text, FACTURACIONBE.EST, dgvt_doc)
                    '    If gsError2 = "OK" Then
                    '        MsgBox("Asiento Creado", MsgBoxStyle.Information)
                    '        cmb_serdoc.Enabled = False
                    '        'sEstAlmac = cmbalmac.SelectedValue
                    '        Me.btnborrar.Enabled = False
                    '        Me.btndocu.Enabled = False
                    '        Me.btnagregar.Enabled = False
                    '        Dim i As Integer
                    '        For i = 0 To 45
                    '            dgvt_doc.Columns(i).ReadOnly = True
                    '        Next
                    '        'Dispose()
                    '    Else
                    '        FormMain.LblError.Text = gsError2
                    '        MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
                    '    End If

                    'Else
                    '    FormMain.LblError.Text = gsError
                    '    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    'End If
                    'Exit Sub
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveData()
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La factura no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   "Kardex Imp.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim nro As String
        Dim mesaño As String
        Dim m As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBKARDEXIMPBE As New ELTBKARDEXIMPBE
        Dim ELTBDETKARDEXIMPBE As New ELTBDETKARDEXIMPBE
        ELMVLOGSBE.log_codusu = gsUser
        ELTBKARDEXIMPBE.T_DOC_REF = txtt_doc.Text
        ELTBKARDEXIMPBE.SER_DOC_REF = cmb_serdoc.Text
        ELTBKARDEXIMPBE.NRO_DOC_REF = txtnumero.Text
        ELTBKARDEXIMPBE.FEC_GENE = dtpfecha.Text
        ELTBKARDEXIMPBE.PROVEEDOR = txtproveedor.Text
        ELTBKARDEXIMPBE.OBSERVA = txtobservacion.Text
        ELTBKARDEXIMPBE.MONEDA = txtmon.Text
        ELTBKARDEXIMPBE.NRO_DOCU = txt_nrofactimp.Text
        ELTBKARDEXIMPBE.FEC_DOCU = dtpfecnro.Text
        ELTBKARDEXIMPBE.NRO_DUA = txtnumdua.Text
        ELTBKARDEXIMPBE.FEC_DUA = dtpfecdua.Text
        ELTBKARDEXIMPBE.PERSONAL = gsUser
        ELTBKARDEXIMPBE.SER_OREQ = "001"
        ELTBKARDEXIMPBE.NRO_OREQ = txtnro_oreq.Text
        ELTBKARDEXIMPBE.SER_DOCU = cmbsguia.Text
        ELTBKARDEXIMPBE.NRO_GUIA = txtnguia.Text

        If cmbestado.SelectedIndex = 0 Then
            ELTBKARDEXIMPBE.EST = "H"
        Else
            ELTBKARDEXIMPBE.EST = "A"
        End If
        gsError = ELTBKARDEXIMPBL.SaveRow(ELTBKARDEXIMPBE, ELTBDETKARDEXIMPBE, ELMVLOGSBE, flagAccion, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Function OkData() As Boolean
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("Ingrese al menos un campo de detalle", MsgBoxStyle.Exclamation)
            btndocu.Select()
            Return False
        End If
        If dtpfecha.Value.Year <> cmb_serdoc.Text Then
            MsgBox("El año es distinto al que se intenta declarar", MsgBoxStyle.Exclamation)
            btndocu.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("No hay datos para mayorizar")
            Exit Sub
        End If
        Dim dt As DataTable
        Dim frm As New FormELTBKARDEXIMPCOSTO
        'dg2
        frm.dgvt_doc2.Columns.Add("T_DOC_REF", "TIPO") '0
        frm.dgvt_doc2.Columns.Add("SER_DOC_REF", "SERIE") '1
        frm.dgvt_doc2.Columns.Add("NRO_DOC_REF", "NUMERO") '2
        frm.dgvt_doc2.Columns.Add("T_DOC_REF1", "TIPO") '3
        frm.dgvt_doc2.Columns.Add("SER_DOC_REF1", "SERIE") '4
        frm.dgvt_doc2.Columns.Add("NRO_DOC_REF1", "NUMERO") '5
        frm.dgvt_doc2.Columns.Add("UNIDAD", "UNIDAD") '6
        frm.dgvt_doc2.Columns.Add("ART_COD", "CODIGO") '7
        frm.dgvt_doc2.Columns.Add("NOM_ART", "DESCRIPCION") '8
        frm.dgvt_doc2.Columns.Add("CANTIDAD", "CANTIDAD") '9
        frm.dgvt_doc2.Columns.Add("TPRECIO_COMPRA", "PRECIO COMPRA") '10
        frm.dgvt_doc2.Columns.Add("ANCHO", "ANCHO") '11
        frm.dgvt_doc2.Columns.Add("LARGO", "LARGO") '12
        frm.dgvt_doc2.Columns.Add("DATO_CONV", "DATO_CONV") '13
        frm.dgvt_doc2.Columns.Add("PESO", "PESO") '14
        frm.dgvt_doc2.Columns.Add("CTO_RPTO", "Costo Repartido") '15
        frm.dgvt_doc2.Columns.Add("CTO_TOT", "Costo Total") '16
        frm.dgvt_doc2.Columns.Add("Precio_uni", "Precio Unitario") '17
        frm.dgvt_doc2.Columns.Add("Costo_comun", "Costo Comun") '18
        frm.dgvt_doc2.Columns.Add("Cantidad_total", "Cantidad Total") '19
        frm.dgvt_doc2.Columns.Add("Precio_total", "Precio Total") '20
        frm.dgvt_doc2.Columns.Add("Peso_Total", "Peso Total") '21
        frm.dgvt_doc2.Columns.Add("TIPO", "TIPO") '22
        'frm.dgvt_doc2.Columns.Add("ADVALORE", "ADVALORE") '23
        dt = ELTBKARDEXIMPBL.SelectRowCost(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                frm.dgvt_doc2.Rows.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                       IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                       IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),
                                       IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                       IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                       IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                       IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                       IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                       IIf(IsDBNull(row("NOM")), "", row("NOM")),
                                       IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")),
                                       IIf(IsDBNull(row("COSTO_TOTAL")), 0, row("COSTO_TOTAL")),
                                       0, 0, 0,
                                       IIf(IsDBNull(row("PESO")), 0, row("PESO")),
                                       IIf(IsDBNull(row("COSTO_REPARTIDO")), 0, row("COSTO_REPARTIDO")),
                                       IIf(IsDBNull(row("COSTO_TOTAL")), 0, row("COSTO_TOTAL")),
                                       IIf(IsDBNull(row("PRECIO_UNITARIO")), 0, row("PRECIO_UNITARIO")),
                                       IIf(IsDBNull(row("COSTO_COMUN")), 0, row("COSTO_COMUN")),
                                       IIf(IsDBNull(row("CANTIDAD_TOTAL")), 0, row("CANTIDAD_TOTAL")),
                                       IIf(IsDBNull(row("PRECIO_TOTAL")), 0, row("PRECIO_TOTAL")),
                                       IIf(IsDBNull(row("PESO_TOTAL")), 0, row("PESO_TOTAL")),
                                       IIf(IsDBNull(row("TIPO")), 0, row("TIPO")))
            Next
        Else
            For i = 0 To dgvt_doc.Rows.Count - 1
                frm.dgvt_doc2.Rows.Add(dgvt_doc.Rows(i).Cells("T_DOC_REF").Value,
                                       dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value,
                                       dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value,
                                       dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value,
                                       dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value,
                                       dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value,
                                       dgvt_doc.Rows(i).Cells("UNIDAD").Value,
                                       dgvt_doc.Rows(i).Cells("ART_COD").Value,
                                       dgvt_doc.Rows(i).Cells("NOM_ART").Value,
                                       dgvt_doc.Rows(i).Cells("CANTIDAD").Value,
                                       (dgvt_doc.Rows(i).Cells("CANTIDAD").Value * dgvt_doc.Rows(i).Cells("UPRECIO_COMPRA").Value) + Val(dgvt_doc.Rows(i).Cells("ADVALORE").Value))
            Next
        End If
        frm.dgvt_doc2.Columns(11).Visible = False
        frm.dgvt_doc2.Columns(12).Visible = False
        frm.dgvt_doc2.Columns(13).Visible = False
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Esta seguro de Eliminar los campos",
                           "Kardex Imp", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

            Exit Sub
        End If
        'For i = 0 To dgvt_doc.Rows.Count - 1
        dgvt_doc.Rows.Clear()
        'Next
        dgvt_doc.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim dtArticulo As DataTable
        'dtArticulo = LETRASBL.getListdgvletras()
        'dgvsegundo.DataSource = dtArticulo
        'dgvsegundo.Refresh()
        'Call GridAExcel(dgvsegundo)
    End Sub
End Class