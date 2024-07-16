
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormDocuRefContaff
    Dim gpCaption As String
    Private CUENTABANCOBL As New CUENTABANCOBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private ARTICULOBL As New ARTICULOBL
    Dim Valores() As String
    Dim ValSer() As String
    Dim val As String
    Dim valS As String
    Dim txtdif As String = ""
    Dim fla As String = ""
    Dim contar As Integer = 0
    Private Sub SaveData()
        Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        For i = 0 To lvbusqueda1.Items.Count - 1
            If lvbusqueda1.Items(i).Checked = True Then
                ELPRODUCCIONBE.t_doc_ref = lvbusqueda1.Items(i).SubItems(0).Text
                ELPRODUCCIONBE.ser_doc_ref = lvbusqueda1.Items(i).SubItems(1).Text
                ELPRODUCCIONBE.nro_doc_ref = lvbusqueda1.Items(i).SubItems(2).Text
                ELPRODUCCIONBE.cod_art = lvbusqueda1.Items(i).SubItems(3).Text
                ELPRODUCCIONBE.estado = "T"
                gsError = ELORDEN_PROGRAMBL.SaveRow1(ELPRODUCCIONBE, ELMVLOGSBE, "M")
            End If
        Next

    End Sub
    Private Sub FormDocuRefContaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvt_doc.Columns.Add("FECHA_EMISION", "FECHA_EMISION")
        dgvt_doc.Columns.Add("COD_ART", "COD_ART")
        dgvt_doc.Columns.Add("ART_DESCRI", "ART_DESCRI")
        dgvt_doc.Columns.Add("CANT_PEDIDA", "CANT_PEDIDA")
        dgvt_doc.Columns.Add("CANT_PRODUCIDA", "CANT_PRODUCIDA")
        dgvt_doc.Columns.Add("CANT_PENDIENTE", "CANT_PENDIENTE")
        dgvt_doc.Columns.Add("STOCK", "STOCK")
        dgvt_doc.Columns.Add("UNIDHORA", "UNIDHORA")
        dgvt_doc.Columns.Add("PROC", "PROC")
        dgvt_doc.Columns.Add("CCOSTO_COD", "CCOSTO_COD")
        dgvt_doc.Columns.Add("CANT_OT", "CANT_OT")
        lvbusqueda1.Items.Clear()
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim item As ListViewItem
        Dim c As Integer = 0
        Dim a As Integer = 0
        Dim nro_doc_ref As Integer
        Dim ind() As String
        Dim indi As Integer = 0
        Dim art As String = ""
        Dim acu_ot As Double = 0
        Dim acu_pen As Double = 0
        Dim acu_pedida As Double = 0
        Dim acu_pro As Double = 0
        Dim acu_at As Double = 0
        Dim stk As Double = 0
        Dim art_exp As String = ""
        Dim fec As Date
        dt = ELORDEN_PROGRAMBL.list1(gsCode7)
        For Each row As DataRow In dt.Rows
            'If FormOrdenProgramas.dgvt_doc.Rows.Count > 0 Then
            '    For i = 0 To FormOrdenProgramas.dgvt_doc.Rows.Count - 1
            'If FormOrdenProgramas.dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value <> row("SERIE") Or
            '           FormOrdenProgramas.dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value <> IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD")) Or
            '           FormOrdenProgramas.dgvt_doc.Rows(i).Cells("Cod_Articulo").Value <> IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")) Then
            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO"))) '0
                        item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE"))) ' 1
                        item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD"))) '2
                        'item.SubItems.Add(IIf(IsDBNull(row("ORDEN_TRABAJ")), "", row("ORDEN_TRABAJ")))
                        'item.SubItems.Add(IIf(IsDBNull(row("FECHA_EMISION")), "", row("FECHA_EMISION")))
                        'item.SubItems.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")))
                        'item.SubItems.Add(IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE")))
                        item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART"))) '3
                        item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI"))) '4
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA"))) '5
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA"))) '6
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE"))) '7
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT"))) '8
                        item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK"))) '9
                        item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA"))) '10
                        item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC"))) '11
            'End If
        Next
        If lvbusqueda1.Items.Count > 0 Then
            For i = 0 To lvbusqueda1.Items.Count - 1
                For j = 0 To lvbusqueda1.Items.Count - 1
                    If i <> j Then
                        If lvbusqueda1.Items(i).SubItems(3).Text = lvbusqueda1.Items(j).SubItems(3).Text Then
                            c = c + 1
                            'art = lvbusqueda1.Items(j).SubItems(3).Text
                        End If
                    End If
                Next
            Next
            If c > 0 Then
                If MessageBox.Show("Se encontraron articulos iguales,¿Desea Fusionar las Ordenes?",
                                   "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else

                    Dim b As Integer = 0
                    'Dim d As Integer = 0
                    For i = 0 To lvbusqueda1.Items.Count - 1
                        For j = 0 To lvbusqueda1.Items.Count - 1
                            If i <> j Then
                                If lvbusqueda1.Items(i).SubItems(3).Text = lvbusqueda1.Items(j).SubItems(3).Text Then
                                    If lvart.Items.Count = 0 Then
                                        lvart.Items.Add(lvbusqueda1.Items(j).SubItems(3).Text)
                                    Else
                                        b = 0
                                        For z = 0 To lvart.Items.Count - 1
                                            If lvart.Items(z).SubItems(0).Text = lvbusqueda1.Items(j).SubItems(3).Text Then
                                                b = b + 1
                                            End If
                                        Next
                                        If b = 0 Then
                                            lvart.Items.Add(lvbusqueda1.Items(j).SubItems(3).Text)
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    For z = 0 To lvart.Items.Count - 1
                        UnirArt(lvart.Items(z).SubItems(0).Text, 1)
                    Next


                    'c = 0
                    'For i = 0 To lvbusqueda1.Items.Count - 1
                    '    For j = 0 To lvbusqueda1.Items.Count - 1
                    '        If i <> j Then
                    '            If lvbusqueda1.Items(i).SubItems(3).Text = lvbusqueda1.Items(j).SubItems(3).Text Then
                    '                c = c + 1
                    '                acu_ot = acu_ot + lvbusqueda1.Items(j).SubItems(8).Text
                    '                art = lvbusqueda1.Items(j).SubItems(3).Text
                    '                acu_pen = acu_pen + lvbusqueda1.Items(j).SubItems(7).Text
                    '                acu_pedida = acu_pedida + lvbusqueda1.Items(j).SubItems(5).Text
                    '                acu_pro = acu_pro + lvbusqueda1.Items(j).SubItems(6).Text
                    '                If c = 1 Then
                    '                    dt1 = ELPRODUCCIONBL.SelFec(lvbusqueda1.Items(j).SubItems(1).Text, lvbusqueda1.Items(j).SubItems(2).Text)
                    '                    For Each row As DataRow In dt1.Rows
                    '                        fec = row("FEC_ENT")
                    '                        art_exp = row("COD_ART_EXPL")
                    '                    Next
                    '                End If
                    '            End If
                    '        End If

                    '    Next
                    'Next
                    'fla = flagAccion
                    'nro_doc_ref = ELPRODUCCIONBL.SelNRO(DateTime.Now.Year)
                    'Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                    'Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    'Dim ELMVLOGSBE As New ELMVLOGSBE
                    'ELPRODUCCIONBE.t_doc_ref = "OPRD"
                    'ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
                    'ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref
                    'ELPRODUCCIONBE.t_doc_ref1 = "OPRD" '"82"
                    'ELPRODUCCIONBE.ser_doc_ref1 = DateTime.Now.Year 'Vser_doc_ref1(i)
                    'ELPRODUCCIONBE.nro_doc_ref1 = nro_doc_ref 'Vnro_doc_ref1(i)
                    'ELPRODUCCIONBE.cod_art = art
                    'ELPRODUCCIONBE.usuario = gsCodUsr
                    'If ELPRODUCCIONBL.SelFact(art) = 0 Then
                    '    ELPRODUCCIONBE.fact = 1
                    'Else
                    '    ELPRODUCCIONBE.fact = ELPRODUCCIONBL.SelFact(art)
                    'End If

                    'ELPRODUCCIONBE.ot_pedido = acu_pedida ' Vcantidad(i)
                    'ELPRODUCCIONBE.ot_pendiente = acu_pen 'Vot_despachado(i)
                    'ELPRODUCCIONBE.ot_atendido = acu_pro
                    'ELPRODUCCIONBE.Stoc_actual = ELPRODUCCIONBL.SelectStockArt(art) 'lblstc_actual.Text
                    'ELPRODUCCIONBE.cod_art_expl = art_exp   'codigo articulo
                    'ELPRODUCCIONBE.opc_stock = "0"
                    'ELPRODUCCIONBE.descripcion = ARTICULOBL.SelectNom(art)
                    'ELPRODUCCIONBE.unidad_med = ARTICULOBL.SelectUniMed(art)
                    'ELPRODUCCIONBE.opc_temporal = 1
                    'ELPRODUCCIONBE.demasia = "0"
                    'ELPRODUCCIONBE.cant_generar = acu_pedida
                    'ELPRODUCCIONBE.fec_ent = fec
                    'ELPRODUCCIONBE.cant_consumo = acu_pedida'txtcantidad.Text * ELPRODUCCIONBE.fact
                    'ELMVLOGSBE.log_codusu = gsCodUsr
                    'flagAccion = "N"
                    'gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
                    'If gsError = "OK" Then
                    '    If gsError2 = "OK" Then
                    '        MsgBox("Orden de Produccion guardada", MsgBoxStyle.Information)
                    '    Else
                    '        FormMain.LblError.Text = gsError2
                    '        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    '    End If

                    'Else
                    '    FormMain.LblError.Text = gsError
                    '    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    'End If
                End If
            End If
        End If
        lvbusqueda1.Items.Clear()
        dt = ELORDEN_PROGRAMBL.list1(gsCode7)
        For Each row As DataRow In dt.Rows
            'If FormOrdenProgramas.dgvt_doc.Rows.Count > 0 Then
            '    For i = 0 To FormOrdenProgramas.dgvt_doc.Rows.Count - 1
            '        If FormOrdenProgramas.dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value <> IIf(IsDBNull(row("SERIE")), "", row("SERIE")) Or
            '           FormOrdenProgramas.dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value <> IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD")) Or
            '           FormOrdenProgramas.dgvt_doc.Rows(i).Cells("Cod_Articulo").Value <> IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")) Then
            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")))
                        item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
                        item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD")))
                        'item.SubItems.Add(IIf(IsDBNull(row("ORDEN_TRABAJ")), "", row("ORDEN_TRABAJ")))
                        'item.SubItems.Add(IIf(IsDBNull(row("FECHA_EMISION")), "", row("FECHA_EMISION")))
                        'item.SubItems.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")))
                        'item.SubItems.Add(IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE")))
                        item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")))
                        item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI")))
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA")))
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA")))
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE")))
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT")))
                        item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK")))
                        item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA")))
                        item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC")))
            'End If
        Next
        '    Else
        '        item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")))
        '        item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
        '        item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD")))
        '        'item.SubItems.Add(IIf(IsDBNull(row("ORDEN_TRABAJ")), "", row("ORDEN_TRABAJ")))
        '        'item.SubItems.Add(IIf(IsDBNull(row("FECHA_EMISION")), "", row("FECHA_EMISION")))
        '        'item.SubItems.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")))
        '        'item.SubItems.Add(IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE")))
        '        item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")))
        '        item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI")))
        '        item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA")))
        '        item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA")))
        '        item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE")))
        '        item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT")))
        '        item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK")))
        '        item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA")))
        '        item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC")))
        '    End If
        'Next
    End Sub
    Private Sub UnirArt(ByVal arts As String, ByVal indice As Integer)
        contar = 0
        Valores = Nothing
        ValSer = Nothing
        val = ""
        valS = ""
        lvcrear1.Items.Clear()
        dgvt_doc.Rows.Clear()
        Dim dt As DataTable
        Dim nro_doc_ref As Integer
        Dim item As ListViewItem
        dt = ELORDEN_PROGRAMBL.list1(gsCode7)
        For Each row As DataRow In dt.Rows
            If FormOrdenProgramas.dgvt_doc.Rows.Count > 0 Then
                For i = 0 To FormOrdenProgramas.dgvt_doc.Rows.Count - 1
                    If FormOrdenProgramas.dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value <> row("SERIE") Or
                       FormOrdenProgramas.dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value <> IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD")) Or
                       FormOrdenProgramas.dgvt_doc.Rows(i).Cells("Cod_Articulo").Value <> IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")) Then
                        item = lvcrear1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO"))) '0
                        item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE"))) ' 1
                        item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD"))) '2
                        item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART"))) '3
                        item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI"))) '4
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA"))) '5
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA"))) '6
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE"))) '7
                        item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT"))) '8
                        item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK"))) '9
                        item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA"))) '10
                        item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC"))) '11

                    End If
                Next
            Else
                item = lvcrear1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO"))) '0
                item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE"))) ' 1
                item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD"))) '2
                item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART"))) '3
                item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI"))) '4
                item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA"))) '5
                item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA"))) '6
                item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE"))) '7
                item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT"))) '8
                item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK"))) '9
                item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA"))) '10
                item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC"))) '11

            End If
        Next

        For i = 0 To lvcrear1.Items.Count - 1
            If lvcrear1.Items(i).SubItems(3).Text = arts Then
                contar = contar + 1
                val = lvcrear1.Items(i).SubItems(2).Text & "|" & val
                valS = lvcrear1.Items(i).SubItems(1).Text & "|" & valS
            End If
        Next
        If contar >= 2 Then
            Valores = val.Split("|")
            ValSer = valS.Split("|")
            dt = ELORDEN_PROGRAMBL.ListArt(FormOrdenProgramas.txtcco_cod.Text, arts)
            For Each row As DataRow In dt.Rows
                dgvt_doc.Rows.Add(IIf(IsDBNull(row("FECHA_EMISION")), "", row("FECHA_EMISION")),
                                  IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")),
                                  IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI")),
                                  IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA")),
                                  IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA")),
                                  IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE")),
                                  IIf(IsDBNull(row("STOCK")), "", row("STOCK")),
                                  IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA")),
                                  IIf(IsDBNull(row("PROC")), "", row("PROC")),
                                  IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT")))
            Next
            If Valores.Count > 0 Then
                nro_doc_ref = ELPRODUCCIONBL.SelNRO(DateTime.Now.Year)
                For i = 0 To dgvt_doc.Rows.Count - 1
                    Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELPRODUCCIONBE.t_doc_ref = "OPRD"
                    ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
                    ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref.ToString.PadLeft(7, "0")
                    ELPRODUCCIONBE.t_doc_ref1 = "OPRD" '"82"
                    ELPRODUCCIONBE.ser_doc_ref1 = DateTime.Now.Year 'Vser_doc_ref1(i)
                    ELPRODUCCIONBE.nro_doc_ref1 = nro_doc_ref.ToString.PadLeft(7, "0") 'Vnro_doc_ref1(i)
                    ELPRODUCCIONBE.cod_art = arts
                    ELPRODUCCIONBE.usuario = gsCodUsr
                    If ELPRODUCCIONBL.SelFact(arts) = 0 Then
                        ELPRODUCCIONBE.fact = 1
                    Else
                        ELPRODUCCIONBE.fact = ELPRODUCCIONBL.SelFact(arts)
                    End If

                    ELPRODUCCIONBE.ot_pedido = dgvt_doc.Rows(i).Cells("CANT_PEDIDA").Value ' Vcantidad(i)
                    ELPRODUCCIONBE.ot_pendiente = dgvt_doc.Rows(i).Cells("CANT_PENDIENTE").Value 'Vot_despachado(i)
                    ELPRODUCCIONBE.ot_atendido = dgvt_doc.Rows(i).Cells("CANT_PRODUCIDA").Value
                    ELPRODUCCIONBE.Stoc_actual = ELPRODUCCIONBL.SelectStockArt(arts) 'lblstc_actual.Text
                    ELPRODUCCIONBE.cod_art_expl = "" ' dgvt_doc.Rows(i).Cells("ART_EXPL").Value   'codigo articulo
                    ELPRODUCCIONBE.opc_stock = "0"
                    ELPRODUCCIONBE.descripcion = dgvt_doc.Rows(i).Cells("ART_DESCRI").Value
                    ELPRODUCCIONBE.unidad_med = ARTICULOBL.SelectUniMed(arts)
                    ELPRODUCCIONBE.opc_temporal = 1
                    ELPRODUCCIONBE.demasia = "0"
                    ELPRODUCCIONBE.cant_generar = dgvt_doc.Rows(i).Cells("CANT_PEDIDA").Value
                    ELPRODUCCIONBE.fec_ent = dgvt_doc.Rows(i).Cells("FECHA_EMISION").Value
                    ELPRODUCCIONBE.cant_consumo = dgvt_doc.Rows(i).Cells("CANT_OT").Value 'txtcantidad.Text * ELPRODUCCIONBE.fact
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    flagAccion = "N"
                    gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
                Next
                For i = 0 To Valores.Count - 2
                    Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELPRODUCCIONBE.nro_doc_ref = Valores(i)
                    ELPRODUCCIONBE.ser_doc_ref = ValSer(i)
                    ELPRODUCCIONBE.ndoc = nro_doc_ref.ToString.PadLeft(7, "0")
                    gsError2 = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, "ORD")
                Next
            End If
        End If



    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If lvbusqueda1.Items.Count <= 0 Then
            MsgBox("No hay datos para pasar ", MsgBoxStyle.Information)
        Else

            Dim a As Integer = FormOrdenProgramas.dgvt_doc.Rows.Count
            Dim b As Double = 0
            If flagAccion1 = "N" Then
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        If a > 0 Then
                            For j = 0 To FormOrdenProgramas.dgvt_doc.Rows.Count - 1
                                If FormOrdenProgramas.dgvt_doc.Rows(j).Cells("SER_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(1).Text And
                                FormOrdenProgramas.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(2).Text And
                                FormOrdenProgramas.dgvt_doc.Rows(j).Cells("Cod_Articulo").Value = lvbusqueda1.Items(i).SubItems(3).Text Then
                                    MsgBox("Este articulo ya se encuentra listado elija otro")
                                    Exit Sub
                                End If
                            Next
                        End If

                        If CInt(lvbusqueda1.Items(i).SubItems(10).Text) = 0 Then
                            Dim frm As New FormOrdenProgramas_Agregar
                            If MessageBox.Show("Artículo sin duración desea vincularle un proceso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Else
                                frm.lblcod_art.Text = lvbusqueda1.Items(i).SubItems(3).Text
                                frm.lbldes_art.Text = lvbusqueda1.Items(i).SubItems(4).Text
                                frm.ShowDialog()
                                FormDocuRefContaff_Load(sender, e)
                            End If
                            Exit Sub
                        End If
                    End If
                Next

                Dim indic As Integer = FormOrdenProgramas.dgvt_doc.Rows.Count
                If indic > 0 Then
                    Dim fechafin As Date = FormOrdenProgramas.dgvt_doc.Rows(indic - 1).Cells("Fecha_Fin").Value
                    Dim fechafindos As Date = FormOrdenProgramas.dgvt_doc.Rows(indic - 1).Cells("Fecha_Fin").Value

                    For i = 0 To lvbusqueda1.Items.Count - 1
                        If lvbusqueda1.Items(i).Checked = True Then
                            a = a + 1
                            b = CInt(lvbusqueda1.Items(i).SubItems(7).Text) * 60 / CInt(lvbusqueda1.Items(i).SubItems(10).Text)
                            fechafindos = fechafindos.AddMinutes(b)

                            txtdif = Nothing
                            Dim HO As Integer = 0
                            Dim MI As Integer = 0
                            Dim SE As Integer = 0
                            Dim MI1 As Integer = 0

                            HO = DateDiff(DateInterval.Hour, fechafin, fechafindos)
                            MI = DateDiff(DateInterval.Minute, fechafin, fechafindos)
                            SE = DateDiff(DateInterval.Second, fechafin, fechafindos)
                            MI1 = MI Mod 60
                            SE = SE Mod 60
                            txtdif = HO + Math.Round(MI1 / 60, 2)
                            'txtdif = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")

                            FormOrdenProgramas.dgvt_doc.Rows.Add(a, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text,
                                                                    lvbusqueda1.Items(i).SubItems(5).Text, lvbusqueda1.Items(i).SubItems(7).Text,
                                                                    lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(10).Text,
                                                                    fechafin, fechafindos, "ACTIVO", Trim(lvbusqueda1.Items(i).SubItems(11).Text),
                                                                    txtdif, lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                                                    lvbusqueda1.Items(i).SubItems(2).Text)
                            fechafin = fechafin.AddMinutes(b)
                        End If
                    Next
                Else
                    Dim fechafin As Date = FormOrdenProgramas.dtpfec_inicio.Value
                    Dim fechafindos As Date = FormOrdenProgramas.dtpfec_inicio.Value

                    For i = 0 To lvbusqueda1.Items.Count - 1
                        If lvbusqueda1.Items(i).Checked = True Then
                            a = a + 1
                            b = CInt(lvbusqueda1.Items(i).SubItems(7).Text) * 60 / CInt(lvbusqueda1.Items(i).SubItems(10).Text)
                            fechafindos = fechafindos.AddMinutes(b)
                            txtdif = Nothing
                            Dim HO As Integer = 0
                            Dim MI As Integer = 0
                            Dim SE As Integer = 0
                            Dim MI1 As Integer = 0

                            HO = DateDiff(DateInterval.Hour, fechafin, fechafindos)
                            MI = DateDiff(DateInterval.Minute, fechafin, fechafindos)
                            SE = DateDiff(DateInterval.Second, fechafin, fechafindos)
                            MI1 = MI Mod 60
                            SE = SE Mod 60
                            txtdif = HO + Math.Round(MI1 / 60, 2)
                            'fechafindos = fechafindos.AddMinutes(CInt(lvbusqueda1.Items(i).SubItems(13).Text))
                            FormOrdenProgramas.dgvt_doc.Rows.Add(a, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text,
                                                                    lvbusqueda1.Items(i).SubItems(5).Text, lvbusqueda1.Items(i).SubItems(7).Text,
                                                                    lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(10).Text,
                                                                    fechafin, fechafindos, "ACTIVO", Trim(lvbusqueda1.Items(i).SubItems(11).Text),
                                                                    txtdif, lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                                                    lvbusqueda1.Items(i).SubItems(2).Text)
                            fechafin = fechafin.AddMinutes(b)
                        End If
                    Next
                End If
                SaveData()
                Dispose()
            Else
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        If a > 0 Then
                            For j = 0 To FormOrdenProgramas.dgvt_doc.Rows.Count - 1
                                If FormOrdenProgramas.dgvt_doc.Rows(j).Cells("SER_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(1).Text And
                                FormOrdenProgramas.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = lvbusqueda1.Items(i).SubItems(2).Text And
                                FormOrdenProgramas.dgvt_doc.Rows(j).Cells("Cod_Articulo").Value = lvbusqueda1.Items(i).SubItems(3).Text Then
                                    MsgBox("Este articulo ya se encuentra listado elija otro")
                                    Exit Sub
                                End If
                            Next
                        End If

                        If CInt(lvbusqueda1.Items(i).SubItems(10).Text) = 0 Then
                            Dim frm As New FormOrdenProgramas_Agregar
                            If MessageBox.Show("Artículo sin duración desea vincularle un proceso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Else
                                frm.lblcod_art.Text = lvbusqueda1.Items(i).SubItems(3).Text
                                frm.lbldes_art.Text = lvbusqueda1.Items(i).SubItems(4).Text
                                frm.ShowDialog()
                                FormDocuRefContaff_Load(sender, e)
                            End If
                            Exit Sub
                        End If
                    End If
                Next

                Dim indic As Integer = FormOrdenProgramas.dgvt_doc.Rows.Count
                If indic > 0 Then
                    Dim fechafin As Date = FormOrdenProgramas.dgvt_doc.Rows(indic - 1).Cells("Fecha_Fin").Value
                    Dim fechafindos As Date = FormOrdenProgramas.dgvt_doc.Rows(indic - 1).Cells("Fecha_Fin").Value

                    For i = 0 To lvbusqueda1.Items.Count - 1
                        If lvbusqueda1.Items(i).Checked = True Then
                            a = a + 1
                            b = CInt(lvbusqueda1.Items(i).SubItems(7).Text) * 60 / CInt(lvbusqueda1.Items(i).SubItems(10).Text)
                            fechafindos = fechafindos.AddMinutes(b)

                            txtdif = Nothing
                            Dim HO As Integer = 0
                            Dim MI As Integer = 0
                            Dim SE As Integer = 0
                            Dim MI1 As Integer = 0

                            HO = DateDiff(DateInterval.Hour, fechafin, fechafindos)
                            MI = DateDiff(DateInterval.Minute, fechafin, fechafindos)
                            SE = DateDiff(DateInterval.Second, fechafin, fechafindos)
                            MI1 = MI Mod 60
                            SE = SE Mod 60
                            txtdif = HO + Math.Round(MI1 / 60, 2)
                            'txtdif = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")

                            FormOrdenProgramas.dgvt_doc.Rows.Add(a, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text,
                                                                    lvbusqueda1.Items(i).SubItems(5).Text, lvbusqueda1.Items(i).SubItems(7).Text,
                                                                    lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(10).Text,
                                                                    fechafin, fechafindos, "ACTIVO", Trim(lvbusqueda1.Items(i).SubItems(11).Text),
                                                                    txtdif, lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                                                    lvbusqueda1.Items(i).SubItems(2).Text)
                            fechafin = fechafin.AddMinutes(b)
                        End If
                    Next
                Else
                    Dim fechafin As Date = FormOrdenProgramas.dtpfec_inicio.Value
                    Dim fechafindos As Date = FormOrdenProgramas.dtpfec_inicio.Value

                    For i = 0 To lvbusqueda1.Items.Count - 1
                        If lvbusqueda1.Items(i).Checked = True Then
                            a = a + 1
                            b = CInt(lvbusqueda1.Items(i).SubItems(7).Text) * 60 / CInt(lvbusqueda1.Items(i).SubItems(10).Text)
                            fechafindos = fechafindos.AddMinutes(b)
                            txtdif = Nothing
                            Dim HO As Integer = 0
                            Dim MI As Integer = 0
                            Dim SE As Integer = 0
                            Dim MI1 As Integer = 0

                            HO = DateDiff(DateInterval.Hour, fechafin, fechafindos)
                            MI = DateDiff(DateInterval.Minute, fechafin, fechafindos)
                            SE = DateDiff(DateInterval.Second, fechafin, fechafindos)
                            MI1 = MI Mod 60
                            SE = SE Mod 60
                            txtdif = HO + Math.Round(MI1 / 60, 2)
                            'fechafindos = fechafindos.AddMinutes(CInt(lvbusqueda1.Items(i).SubItems(13).Text))
                            FormOrdenProgramas.dgvt_doc.Rows.Add(a, lvbusqueda1.Items(i).SubItems(3).Text, lvbusqueda1.Items(i).SubItems(4).Text,
                                                                    lvbusqueda1.Items(i).SubItems(5).Text, lvbusqueda1.Items(i).SubItems(7).Text,
                                                                    lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(10).Text,
                                                                    fechafin, fechafindos, "ACTIVO", Trim(lvbusqueda1.Items(i).SubItems(11).Text),
                                                                    txtdif, lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                                                    lvbusqueda1.Items(i).SubItems(2).Text)
                            fechafin = fechafin.AddMinutes(b)
                        End If
                    Next
                End If
                SaveData()
                Dispose()
            End If

        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        If lvbusqueda1.Items.Count = 0 Then
            MsgBox("No hay items para anular")
        Else
            If lvbusqueda1.CheckedItems.Count = 0 Then
                MsgBox("Seleccione algun item que desee anular")
            Else
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                        Dim ELMVLOGSBE As New ELMVLOGSBE
                        ELPRODUCCIONBE.t_doc_ref = lvbusqueda1.Items(i).SubItems(0).Text
                        ELPRODUCCIONBE.ser_doc_ref = lvbusqueda1.Items(i).SubItems(1).Text
                        ELPRODUCCIONBE.nro_doc_ref = lvbusqueda1.Items(i).SubItems(2).Text
                        ELPRODUCCIONBE.cod_art = lvbusqueda1.Items(i).SubItems(3).Text
                        ELMVLOGSBE.log_codusu = gsCodUsr
                        gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, "AO")
                        If gsError = "OK" Then
                            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                            FormMain.LblError.Text = ""
                        Else
                            FormMain.LblError.Text = gsError
                            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                        End If
                    End If
                Next
                lvbusqueda1.Items.Clear()
                Dim dt As DataTable
                Dim item As ListViewItem

                dt = ELORDEN_PROGRAMBL.list1(gsCode7)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO"))) '0
                    item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE"))) ' 1
                    item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD"))) '2
                    item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART"))) '3
                    item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI"))) '4
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA"))) '5
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA"))) '6
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE"))) '7
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT"))) '8
                    item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK"))) '9
                    item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA"))) '10
                    item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC"))) '11
                Next
            End If
        End If
    End Sub

    Private Sub FormDocuRefContaff_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim frm As New ELPRODUCCION_VARIOS
        Dim a As String = gsCode7
        Dim b As String = flagAccion
        gsCode7 = ""
        For i = 0 To lvbusqueda1.Items.Count - 1
            If lvbusqueda1.Items(i).Checked = True Then
                sTDoc = lvbusqueda1.Items(i).SubItems(0).Text
                sNDoc = lvbusqueda1.Items(i).SubItems(2).Text
                sObsOp = lvbusqueda1.Items(i).SubItems(3).Text
                sSDoc = lvbusqueda1.Items(i).SubItems(1).Text
                frm.flag = "1"
                frm.ShowDialog()

            End If
        Next
        Dim dt As DataTable
        Dim item As ListViewItem
        lvbusqueda1.Items.Clear()
        flagAccion = b
        gsCode7 = a
        dt = ELORDEN_PROGRAMBL.list1(gsCode7)
        For Each row As DataRow In dt.Rows
            'If FormOrdenProgramas.dgvt_doc.Rows.Count > 0 Then
            '    For i = 0 To FormOrdenProgramas.dgvt_doc.Rows.Count - 1
            'If FormOrdenProgramas.dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value <> row("SERIE") Or
            '           FormOrdenProgramas.dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value <> IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD")) Or
            '           FormOrdenProgramas.dgvt_doc.Rows(i).Cells("Cod_Articulo").Value <> IIf(IsDBNull(row("COD_ART")), "", row("COD_ART")) Then
            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO"))) '0
            item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE"))) ' 1
            item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD"))) '2
            item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART"))) '3
            item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI"))) '4
            item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA"))) '5
            item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA"))) '6
            item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE"))) '7
            item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT"))) '8
            item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK"))) '9
            item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA"))) '10
            item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC"))) '11
            'End If
        Next
    End Sub
    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = False Then
                    lvbusqueda1.Items(i).Checked = True
                End If

            Next
        Else
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = True Then
                    lvbusqueda1.Items(i).Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub FormDocuRefContaff_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click

        If lvbusqueda1.Items.Count = 0 Then
            MsgBox("No hay items para cerrar")
        Else
            If lvbusqueda1.CheckedItems.Count = 0 Then
                MsgBox("Seleccione algun item que desee cerrar")
            Else
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        'Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                        'Dim ELMVLOGSBE As New ELMVLOGSBE
                        'ELPRODUCCIONBE.t_doc_ref = lvbusqueda1.Items(i).SubItems(0).Text
                        'ELPRODUCCIONBE.ser_doc_ref = lvbusqueda1.Items(i).SubItems(1).Text
                        'ELPRODUCCIONBE.nro_doc_ref = lvbusqueda1.Items(i).SubItems(2).Text
                        'ELPRODUCCIONBE.cod_art = lvbusqueda1.Items(i).SubItems(3).Text
                        'ELMVLOGSBE.log_codusu = gsCodUsr
                        'gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, "AO")
                        Dim ELORDEN_PROGRAMBE As New ELORDEN_PROGRAMBE
                        Dim ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
                        Dim ELMVLOGSBE As New ELMVLOGSBE
                        ELORDEN_DET_PROGRAMBE.ser_doc_ref1 = lvbusqueda1.Items(i).SubItems(1).Text
                        ELORDEN_DET_PROGRAMBE.nro_doc_ref1 = lvbusqueda1.Items(i).SubItems(2).Text
                        ELORDEN_DET_PROGRAMBE.cod_articulo = lvbusqueda1.Items(i).SubItems(3).Text
                        ELMVLOGSBE.log_codusu = gsCodUsr
                        gsError = ELORDEN_PROGRAMBL.SaveRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, "C", dgvt_doc, ELORDEN_DET_PROGRAMBE)

                        If gsError = "OK" Then
                            MsgBox("Se Cerro Correctamente", MsgBoxStyle.Information)
                            FormMain.LblError.Text = ""
                        Else
                            FormMain.LblError.Text = gsError
                            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                        End If
                    End If
                Next
                lvbusqueda1.Items.Clear()
                Dim dt As DataTable
                Dim item As ListViewItem

                dt = ELORDEN_PROGRAMBL.list1(gsCode7)
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO"))) '0
                    item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE"))) ' 1
                    item.SubItems.Add(IIf(IsDBNull(row("ORDEN_PROD")), "", row("ORDEN_PROD"))) '2
                    item.SubItems.Add(IIf(IsDBNull(row("COD_ART")), "", row("COD_ART"))) '3
                    item.SubItems.Add(IIf(IsDBNull(row("ART_DESCRI")), "", row("ART_DESCRI"))) '4
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_PEDIDA")), "", row("CANT_PEDIDA"))) '5
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_PRODUCIDA")), "", row("CANT_PRODUCIDA"))) '6
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_PENDIENTE")), "", row("CANT_PENDIENTE"))) '7
                    item.SubItems.Add(IIf(IsDBNull(row("CANT_OT")), "", row("CANT_OT"))) '8
                    item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK"))) '9
                    item.SubItems.Add(IIf(IsDBNull(row("UNIDHORA")), "", row("UNIDHORA"))) '10
                    item.SubItems.Add(IIf(IsDBNull(row("PROC")), "", row("PROC"))) '11
                Next
            End If
        End If
    End Sub
End Class