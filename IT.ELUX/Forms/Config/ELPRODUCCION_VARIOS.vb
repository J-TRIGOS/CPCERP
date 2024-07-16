Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class ELPRODUCCION_VARIOS

    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private dtExplComponente, dt2 As DataTable
    Dim x As Integer = 0
    Dim chkstock, chktemporal As String
    Dim nro_doc_ref, ffff, ffff2 As String
    Dim sdoc As String = ""
    Dim ndoc As String = ""
    Dim cod_articulo() As String
    Dim cod As String = ""
    Dim cont As Integer = 0
    Dim cantidad As Double
    Dim contadorRecur As Integer = 0
    Public flag As String
    Dim fact1 As String

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub ELPRODUCCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvt_doc.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF")
        dgvt_doc.Columns.Add("SER_DOC_REF", "SER_DOC_REF")
        dgvt_doc.Columns.Add("ART_COD", "ART_COD")


        If sOp = "1" Then
            txtart_cod.Visible = True
            cmbarticulos.Visible = False
            lblpedido.Text = "0"
            lbl_atend.Text = "0"
            lblpendiente.Text = "0"
            Button1.Visible = True
            Dim dtExplosion As New DataTable
            Select Case gnOpcion
                Case 0
                    flagAccion = "N"
                    'GetData()
                    Limpiar()
                    dtExplComponente = New DataTable("TableName")
                    Dim column1 As DataColumn = New DataColumn("CodArt")
                    column1.DataType = System.Type.GetType("System.String")
                    Dim column2 As DataColumn = New DataColumn("CodComp")
                    column2.DataType = System.Type.GetType("System.String")
                    Dim column3 As DataColumn = New DataColumn("Tipo")
                    column3.DataType = System.Type.GetType("System.String")
                    Dim column4 As DataColumn = New DataColumn("Componente")
                    column4.DataType = System.Type.GetType("System.String")
                    Dim column5 As DataColumn = New DataColumn("Cant")
                    column5.DataType = System.Type.GetType("System.String")
                    dtExplComponente.Columns.Add(column1)
                    dtExplComponente.Columns.Add(column2)
                    dtExplComponente.Columns.Add(column3)
                    dtExplComponente.Columns.Add(column4)
                    dtExplComponente.Columns.Add(column5)

            End Select

        Else
            Dim Vnro_doc_ref1(), Vser_doc_ref1() As String
            Dim dtExplosion As New DataTable
            If flag <> "" Then
                gnOpcion = 1
            Else

                Vnro_doc_ref1 = gsCode7.Split("|")
                Vser_doc_ref1 = gsCode6.Split("|")  '
                For i = 0 To Vnro_doc_ref1.Count - 1
                    dgvt_doc.Rows.Add(Vnro_doc_ref1(i), Vser_doc_ref1(i), gsCode)
                Next
            End If

            Select Case gnOpcion
                Case 0
                    flagAccion = "N"
                    GetData()
                    Limpiar()

                    cmbarticulos.Items.Add(gsCode)
                    dtExplosion = ARTICULOBL.getListdgv1(gsCode)

                    dtExplComponente = New DataTable("TableName")
                    Dim column1 As DataColumn = New DataColumn("CodArt")
                    column1.DataType = System.Type.GetType("System.String")
                    Dim column2 As DataColumn = New DataColumn("CodComp")
                    column2.DataType = System.Type.GetType("System.String")
                    Dim column3 As DataColumn = New DataColumn("Tipo")
                    column3.DataType = System.Type.GetType("System.String")
                    Dim column4 As DataColumn = New DataColumn("Componente")
                    column4.DataType = System.Type.GetType("System.String")
                    Dim column5 As DataColumn = New DataColumn("Cant")
                    column5.DataType = System.Type.GetType("System.String")
                    dtExplComponente.Columns.Add(column1)
                    dtExplComponente.Columns.Add(column2)
                    dtExplComponente.Columns.Add(column3)
                    dtExplComponente.Columns.Add(column4)
                    dtExplComponente.Columns.Add(column5)

                    'Explotar(gsCode, dtExplosion)
                    'showExplosion()
                    Dim dt As DataTable
                    Dim s As String = ""
                    dt = ELETIQUETABL.SelectArticuloCOD(gsCode)
                    If dt.Rows.Count > 0 Then
                        s = dt.Rows(0).Item(1).ToString
                    End If
                    fnRecursiva(gsCode, gsCode + " - " + s, Nothing, 0)
                    tvwExplosion.ExpandAll()
                    tvwExplosion.SelectedNode = tvwExplosion.Nodes(0)
                    rdbtotal.Checked = True
                Case 1
                    flagAccion = "M"
                    GetDataModificar(sTDoc, sSDoc, sNDoc, sObsOp)

                    cmbarticulos.Items.Add(sObsOp)
                    dtExplosion = ARTICULOBL.getListdgv1(sObsOp)
                    tvwExplosion.Enabled = False
                    dtExplComponente = New DataTable("TableName")
                    Dim column1 As DataColumn = New DataColumn("CodArt")
                    column1.DataType = System.Type.GetType("System.String")
                    Dim column2 As DataColumn = New DataColumn("CodComp")
                    column2.DataType = System.Type.GetType("System.String")
                    Dim column3 As DataColumn = New DataColumn("Tipo")
                    column3.DataType = System.Type.GetType("System.String")
                    Dim column4 As DataColumn = New DataColumn("Componente")
                    column4.DataType = System.Type.GetType("System.String")
                    Dim column5 As DataColumn = New DataColumn("Cant")
                    column5.DataType = System.Type.GetType("System.String")
                    dtExplComponente.Columns.Add(column1)
                    dtExplComponente.Columns.Add(column2)
                    dtExplComponente.Columns.Add(column3)
                    dtExplComponente.Columns.Add(column4)
                    dtExplComponente.Columns.Add(column5)
                    'Explotar(sSDoc, dtExplosion)
                    'showExplosion()
                    Dim dt As DataTable
                    Dim s As String = ""
                    dt = ELETIQUETABL.SelectArticuloCOD(sObsOp)
                    If dt.Rows.Count > 0 Then
                        s = dt.Rows(0).Item(1).ToString
                    End If
                    fnRecursiva(sObsOp, sObsOp + " - " + s, Nothing, 0)
                    tvwExplosion.ExpandAll()
                    cmbarticulos.Text = lblcod_art.Text
                    cmbarticulos.Enabled = False
            End Select
        End If

    End Sub

    Private Sub fnRecursiva(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode, ByVal tipo As Integer)
        Dim NN As TreeNode
        Dim N1 As Integer
        Dim sTipo As String
        Dim dtDataTable As DataTable
        If N Is Nothing Then
            NN = tvwExplosion.Nodes.Add(Key, Txt, tipo, tipo)
            ffff = Key
        Else
            NN = N.Nodes.Add(Key, Txt, tipo, tipo)
            ffff = ffff & "|" & Key
        End If
        If cmbarticulos.Items.Count > 0 Then
            N1 = 0
            For i = 0 To cmbarticulos.Items.Count - 1
                If cmbarticulos.Items(i).ToString = Key Then
                    N1 = N1 + 1
                End If
            Next
            If N1 = 0 Then
                cmbarticulos.Items.Add(Key)
            End If
        Else
            cmbarticulos.Items.Add(Key)
        End If
        dtDataTable = ARTICULOBL.getListdgv1(Key)
        For Each row As DataRow In dtDataTable.Rows
            sTipo = CStr(row("tipo"))
            Dim nTipo As Integer = Val(sTipo)
            'sComponente = CStr(row("Componente"))

            fnRecursiva(Mid(row("CODIGO"), 1, 8), row("CODIGO"), NN, nTipo)
        Next row
    End Sub

    Private Sub fnRecursiva1(ByVal Key As String, ByVal factor As String)
        If factor = "0" Then
            factor = "1"
        End If
        Dim Vot_pendiente(), Vser_doc_ref1(), Vnro_doc_ref1() As String
        Vot_pendiente = gsCode11.Split("|")
        Vser_doc_ref1 = gsCode6.Split("|")  '
        Vnro_doc_ref1 = gsCode7.Split("|")
        Vot_pendiente = gsCode11.Split("|")
        cod = Key + "|" + cod
        cont = cont + 1
        Dim dtDataTable As DataTable

        Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        nro_doc_ref = ELPRODUCCIONBL.SelNRO(DateTime.Now.Year)
        ELPRODUCCIONBE.t_doc_ref = "OPRD"
        ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
        ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref.PadLeft(9, "0")
        ELPRODUCCIONBE.t_doc_ref1 = "OPRD" '"82"
        ELPRODUCCIONBE.ser_doc_ref1 = DateTime.Now.Year 'Vser_doc_ref1(i)
        ELPRODUCCIONBE.nro_doc_ref1 = nro_doc_ref 'Vnro_doc_ref1(i)
        ELPRODUCCIONBE.cod_art = Key
        ELPRODUCCIONBE.usuario = gsCodUsr
        ELPRODUCCIONBE.ot_pedido = txtcantidad.Text * factor ' Vcantidad(i)
        ELPRODUCCIONBE.ot_pendiente = txttotal.Text * factor - Vot_pendiente(0) 'Vot_despachado(i)
        ELPRODUCCIONBE.ot_atendido = Vot_pendiente(0)
        ELPRODUCCIONBE.Stoc_actual = ELPRODUCCIONBL.SelectStockArt(Key) 'lblstc_actual.Text
        ELPRODUCCIONBE.cod_art_expl = gsCode   'codigo articulo
        ELPRODUCCIONBE.opc_stock = chkstock
        ELPRODUCCIONBE.descripcion = txtdescripcion.Text
        ELPRODUCCIONBE.unidad_med = cmbunidad.SelectedText
        ELPRODUCCIONBE.opc_temporal = 1
        ELPRODUCCIONBE.demasia = cmbdemasia.Text
        ELPRODUCCIONBE.cant_generar = txttotal.Text * factor 'txttotal.Text
        ELPRODUCCIONBE.fec_ent = dtpfec_entre.Value
        ELPRODUCCIONBE.cant_consumo = txtcantidad.Text * factor
        ELMVLOGSBE.log_codusu = gsCodUsr
        flagAccion = "N"
        gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
        If gsError = "OK" Then
            'Dispose()
            If Key = lblcod_art.Text Then
                sdoc = ELPRODUCCIONBE.ser_doc_ref
                ndoc = nro_doc_ref.PadLeft(9, "0")
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
        dtDataTable = ARTICULOBL.getListdgv6(Key)
        For Each row As DataRow In dtDataTable.Rows
            fnRecursiva1(Mid(row("CODIGO"), 1, 8), row("CANTIDAD"))
        Next row
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)
        End If

        Select Case sFunc

            Case "delete"
                If MessageBox.Show("Desea Anular todos los Registros", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else

                    flagAccion = "E"
                    Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELPRODUCCIONBE.nro_doc_ref = sNDoc
                    ELPRODUCCIONBE.nro_doc_ref1 = sTDoc
                    ELPRODUCCIONBE.cod_art = sSDoc
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    Dim DATA As String
                    ' DATA = ELPRODUCCIONBL.SelectNroAnu(sTDoc, sSDoc, sNDoc)

                    gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
                    If gsError = "OK" Then
                        MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information)
                        Dispose()
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                End If
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub Explotar(ByVal sCodArt As String, ByVal dtExp As DataTable)
        Dim sTipo As String
        Dim sCodComp As String
        Dim sComponente As String
        Dim count As Integer = 0
        Dim sCant As Double = 0
        'Dim sRaiz As String
        'barrer dt
        For i = 0 To dtExp.Rows.Count - 1
            count = count + 1
            sTipo = dtExp.Rows(i).Item(0)
            sCodComp = Mid(dtExp.Rows(i).Item(1), 1, 8)
            sComponente = Mid(dtExp.Rows(i).Item(1), 11)
            sCant = dtExp.Rows(i).Item(2)
            ' dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente, sCant)
            If dtExplComponente.Rows.Count = 0 Then
                dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente, sCant)
            Else
                count = 0
                For s = 0 To dtExplComponente.Rows.Count - 1
                    If dtExplComponente.Rows(s).Item("CodArt").ToString = sCodArt And
                        dtExplComponente.Rows(s).Item("CodComp").ToString = sCodComp And
                        dtExplComponente.Rows(s).Item("Tipo").ToString = sTipo And
                        dtExplComponente.Rows(s).Item("Componente").ToString = sComponente Then
                        count = count + 1
                        'Else
                        '    count = 0
                    End If
                Next
                If count = 0 Then
                    dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente, sCant)
                End If
            End If
            'contadorRecur = contadorRecur + 1
            'If contadorRecur = 30 Then            
            '    MsgBox("El Articulo Tiene Componentes iguales", MsgBoxStyle.Information)
            '    Dispose()
            '    Exit Sub
            'End If
            'recursivo
            Dim dtComp As New DataTable
            dtComp = ARTICULOBL.getListdgv3(sCodComp)
            cmbarticulos.Items.Add(sCodComp)
            Explotar(sCodComp, dtComp)
        Next

    End Sub

    Private Sub showExplosion()
        Dim sCode As String = ""
        Dim sChild As String
        Dim sTipo As String
        Dim sComponente As String
        Dim sCant As String
        With tvwExplosion

            ffff = gsCode
            For Each datarow In dtExplComponente.Rows

                'add parent
                sCode = CStr(datarow("CodArt"))
                sChild = CStr(datarow("CodComp"))
                sTipo = CStr(datarow("tipo"))
                sComponente = CStr(datarow("Componente"))
                sCant = CStr(datarow("Cant"))
                Dim nTipo As Integer = Val(sTipo)

                Dim tns() As TreeNode
                tns = .Nodes.Find(sCode, True)

                If tns.Length = 0 Then
                    .Nodes.Add(sCode, sCode)
                    .Nodes(sCode).Nodes.Add(sChild, sChild + " - " + sComponente + " -> " + sCant, nTipo, nTipo)
                Else
                    tns(0).Nodes.Add(sChild, sChild + " - " + sComponente + " -> " + sCant, nTipo, nTipo)
                End If

                ffff = ffff & "|" & sChild
            Next

        End With

        tvwExplosion.ExpandAll()
        tvwExplosion.TabIndex = 0
    End Sub



    Private Function OkData() As Boolean

        If txtcantidad.Text.Trim() = "" Then cantidad = 0 Else cantidad = txtcantidad.Text
        If chkPorstock.Checked = True Then
            If cantidad <= 0 Then
                MsgBox("La cantidad a generar no puede ser menor a 0 ", MsgBoxStyle.Exclamation)
                tvwExplosion.Select()
                Return False
            End If
        End If

        'Try
        '    Dim a As String = tvwExplosion.SelectedNode.ToString
        'Catch ex As Exception
        '    MsgBox("Seleccione un nodo", MsgBoxStyle.Exclamation)
        '    Return False
        'End Try

        Return True
    End Function
    Private Sub Limpiar()
        'txtcod.Text = ELLIB_CONTBL.SelectMaxLibro().PadLeft(2, "0")
    End Sub
    Private Sub GetData()
        lblcod_art.Text = gsCode
        lblart_des.Text = gsCode2

        If sOp = "1" Then
            lblpedido.Text = 0
            'lblpendiente.Text = gsCode4
            lblpendiente.Text = 0
            lbl_atend.Text = 0

            txtcantidad.Text = 0
            txtdemasia.Text = 0
            txttotal.Text = 0
        Else
            dtpfec_entre.Enabled = True
            Dim VOT() As String
            VOT = gsCode7.Split("|")
            For x = 0 To VOT.Length - 1
                lblnro_doc_ref.Text = lblnro_doc_ref.Text + "-" + VOT(x)
            Next
            dtpfec_entre.Value = gsCode5
            lblpedido.Text = gsCode4
            'lblpendiente.Text = gsCode4
            lblpendiente.Text = gsCode9
            lbl_atend.Text = gsCode10
            lblstc_actual.Text = ELPRODUCCIONBL.SelectStockArt(gsCode)

            txtcantidad.Text = gsCode4
            txtdemasia.Text = CDbl(gsCode4) * 0.07
            txttotal.Text = (CDbl(gsCode4) * 0.07) + gsCode4
        End If


    End Sub

    Private Sub GetDataModificar(ByVal stdoc As String, ByVal ssdoc As String, ByVal sndoc As String, ByVal sart As String)

        dtpfec_entre.Enabled = False

        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPRODUCCIONBL.SelectRow(stdoc, ssdoc, sndoc, sObsOp)
        For Each Registro In dtUsuario.Rows
            lblnro_doc_ref.Text = sndoc 'stdoc
            lblcod_art.Text = IIf(IsDBNull(Registro("COD_ART")), "", Registro("COD_ART"))
            lblart_des.Text = IIf(IsDBNull(Registro("NOMBRE")), "", Registro("NOMBRE"))
            dtpfec_entre.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            lblpedido.Text = IIf(IsDBNull(Registro("OT_PEDIDO")), "", Registro("OT_PEDIDO"))
            lblpendiente.Text = IIf(IsDBNull(Registro("OT_PENDIENTE")), "", Registro("OT_PENDIENTE"))
            lbl_atend.Text = IIf(IsDBNull(Registro("OT_ATENDIDO")), "", Registro("OT_ATENDIDO"))
            lblstc_actual.Text = IIf(IsDBNull(Registro("STOCK")), "", Registro("STOCK"))
            txtcantidad.Text = Registro("CANT_GENERAR")
            txtdemasia.Text = Registro("PORCENTAJE")
            txttotal.Text = Registro("OT_PEDIDO")
            cmbdemasia.Text = Registro("DEMASIA")
        Next
    End Sub

    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            chkstock = "1"
            chk2.Checked = False
            chk3.Checked = False
        End If
    End Sub
    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            chkstock = "2"
            chk1.Checked = False
            chk3.Checked = False
        End If
    End Sub
    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            chkstock = "3"
            chk2.Checked = False
            chk1.Checked = False
        End If
    End Sub
    Private Sub chkPedido_CheckedChanged(sender As Object, e As EventArgs) Handles chkPedido.CheckedChanged
        If lblpedido.Text <> "" Then
            Dim b As Double
            If chkPedido.Checked = True Then
                chkPorstock.Checked = False
                txtcantidad.Enabled = False
                txtcantidad.Text = lblpedido.Text
                If cmbdemasia.Text = "" Then b = 0 Else b = cmbdemasia.Text
                txtdemasia.Text = CDbl(txtcantidad.Text) * b / 100
                txttotal.Text = (CDbl(txtcantidad.Text) * b / 100) + CDbl(txtcantidad.Text)
            Else
                chkPorstock.Checked = True
            End If
        End If
    End Sub
    Private Sub chkPorstock_CheckedChanged(sender As Object, e As EventArgs) Handles chkPorstock.CheckedChanged
        If chkPorstock.Checked = True Then
            chkPedido.Checked = False
            txtcantidad.Enabled = True
            txtcantidad.Focus()
        Else
            chkPedido.Checked = True
        End If
    End Sub

    Private Sub cmbarticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulos.SelectedIndexChanged
        'txtdescripcion.Text
        txtdescripcion.Text = ARTICULOBL.SelectArt2(cmbarticulos.Text)
        cmbunidad.Text = ARTICULOBL.SelectUniMed(cmbarticulos.Text)
        txtstk.Text = ARTICULOBL.SetStock(cmbarticulos.Text)

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        'CODIGO NUEVO DE PRODUCCION
        'Dim ar As String = ""
        Dim Vnro_doc_ref1(), Vcantidad(), Vot_despachado(), Vot_pendiente(), Varticulos_v(), Vser_doc_ref1() As String
        If gsCode7 <> Nothing Then
            Vser_doc_ref1 = gsCode6.Split("|")  '
            Vnro_doc_ref1 = gsCode7.Split("|")
            Vot_pendiente = gsCode11.Split("|")
        Else
            flagAccion = "N"
        End If

        If OkData() = False Then
            Exit Sub
        Else
            Dim dt As DataTable

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                If flag = "1" Then
                    flagAccion = "M"
                End If
                If flagAccion = "N" Then
                    If chknivel.Checked Then
                        Dim art As String
                        If sOp = "1" Then
                            art = txtart_cod.Text
                            gsCode = art
                        Else
                            art = cmbarticulos.Text
                        End If

                        If Mid(art, 1, 2) = "01" Or Mid(art, 1, 2) = "02" Or Mid(art, 1, 2) = "03" Or Mid(art, 1, 2) = "10" Or art = "05100012" Then
                            nro_doc_ref = ELPRODUCCIONBL.SelNRO(DateTime.Now.Year)
                            'nro_doc_ref = "0000071"
                            Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                            Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                            Dim ELMVLOGSBE As New ELMVLOGSBE
                            ELPRODUCCIONBE.t_doc_ref = "OPRD"
                            ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
                            ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref.PadLeft(9, "0")
                            ELPRODUCCIONBE.t_doc_ref1 = "OPRD" '"82"
                            ELPRODUCCIONBE.ser_doc_ref1 = DateTime.Now.Year 'Vser_doc_ref1(i)
                            ELPRODUCCIONBE.nro_doc_ref1 = nro_doc_ref 'Vnro_doc_ref1(i)
                            ELPRODUCCIONBE.cod_art = art
                            ELPRODUCCIONBE.usuario = gsCodUsr

                            'If ELPRODUCCIONBL.SelFact(art) = 0 Then
                            ELPRODUCCIONBE.fact = 1
                            'Else
                            '    ELPRODUCCIONBE.fact = ELPRODUCCIONBL.SelFact(gsCode)
                            'End If

                            ELPRODUCCIONBE.ot_pedido = txttotal.Text ' Vcantidad(i)
                            ELPRODUCCIONBE.ot_pendiente = (txttotal.Text * ELPRODUCCIONBE.fact) '- Vot_pendiente(0) 'Vot_despachado(i)
                            ELPRODUCCIONBE.ot_atendido = 0 'Vot_pendiente(0)
                            ELPRODUCCIONBE.Stoc_actual = ELPRODUCCIONBL.SelectStockArt(art) 'lblstc_actual.Text
                            ELPRODUCCIONBE.cod_art_expl = gsCode   'codigo articulo
                            ELPRODUCCIONBE.opc_stock = chkstock
                            ELPRODUCCIONBE.descripcion = txtdescripcion.Text
                            ELPRODUCCIONBE.unidad_med = cmbunidad.Text
                            ELPRODUCCIONBE.opc_temporal = 1
                            ELPRODUCCIONBE.demasia = cmbdemasia.Text
                            ELPRODUCCIONBE.cant_generar = txttotal.Text * ELPRODUCCIONBE.fact
                            ELPRODUCCIONBE.fec_ent = dtpfec_entre.Value
                            ELPRODUCCIONBE.cant_consumo = txtcantidad.Text '* ELPRODUCCIONBE.fact
                            ELMVLOGSBE.log_codusu = gsCodUsr
                            flagAccion = "N"
                            gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
                            If gsError = "OK" Then
                                If gsCode7 <> Nothing Then
                                    'If Vnro_doc_ref1.Count > 0 Then
                                    For i = 0 To Vnro_doc_ref1.Count - 2
                                        If Trim(lblcod_art.Text) = Trim(art) Then
                                            DET_DOCUMENTOBE.T_DOC_REF = "82"
                                            DET_DOCUMENTOBE.SER_DOC_REF = Vser_doc_ref1(i)
                                            DET_DOCUMENTOBE.NRO_DOC_REF = Vnro_doc_ref1(i)
                                            DET_DOCUMENTOBE.ART_COD = Trim(art)
                                            If rdbtotal.Checked = True Then
                                                gsError2 = ELPRODUCCIONBL.SaveRow2(DET_DOCUMENTOBE, flagAccion)
                                            End If
                                            gsError3 = ELPRODUCCIONBL.SaveRow3(ELPRODUCCIONBE, DET_DOCUMENTOBE, dgvt_doc, flagAccion)
                                        End If
                                    Next
                                    'If lblnro_doc_ref.Text = "" Then

                                    'Else
                                    If rdbtotal.Checked = True Then
                                        If gsError2 = "OK" Then
                                            MsgBox("Orden de Produccion guardada", MsgBoxStyle.Information)
                                        Else
                                            FormMain.LblError.Text = gsError2
                                            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                                        End If
                                    Else
                                        If gsError3 = "OK" Then
                                            MsgBox("Orden de Produccion guardada", MsgBoxStyle.Information)
                                        Else
                                            FormMain.LblError.Text = gsError2
                                            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                                        End If
                                    End If
                                End If
                                'MsgBox("Orden de Produccion guardada", MsgBoxStyle.Information)
                                'End If
                                gsCode = ""
                                Dispose()
                            Else
                                FormMain.LblError.Text = gsError
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("No se puede Programar articulos fuera de los almaces de producción")
                            Exit Sub
                        End If

                    Else
                        'If tvwExplosion.SelectedNode.ToString.Substring(10, 8).ToString = "" Then
                        '    tvwExplosion.SelectedNode = tvwExplosion.Nodes(0)
                        '    cmbarticulos.SelectedItem = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
                        'End If
                        Dim a As String = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
                        cmbarticulos.SelectedItem = a
                        If Mid(a, 1, 2) = "01" Or Mid(a, 1, 2) = "02" Or Mid(a, 1, 2) = "03" Or Mid(a, 1, 4) = "0512" Then
                        Else
                            MsgBox("No se puede Programar articulos fuera de los almaces de producción")
                            Exit Sub
                        End If
                        fact1 = ELPRODUCCIONBL.SelFact1(gsCode, a)
                        fnRecursiva1(a, fact1)
                        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                        If Vnro_doc_ref1.Count > 0 Then
                            For i = 0 To Vnro_doc_ref1.Count - 1
                                DET_DOCUMENTOBE.T_DOC_REF = "82"
                                DET_DOCUMENTOBE.SER_DOC_REF = Vser_doc_ref1(i)
                                DET_DOCUMENTOBE.NRO_DOC_REF = Vnro_doc_ref1(i)
                                DET_DOCUMENTOBE.ART_COD = a
                                gsError2 = ELPRODUCCIONBL.SaveRow2(DET_DOCUMENTOBE, flagAccion)

                            Next
                            If gsError2 = "OK" Then
                                MsgBox("Orden de Produccion guardada", MsgBoxStyle.Information)
                                If rdbtotal.Checked = True Then
                                    If sdoc <> "" Then
                                        Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                                        ELPRODUCCIONBE.ser_doc_ref = sdoc
                                        ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref.PadLeft(9, "0")
                                        gsError3 = ELPRODUCCIONBL.SaveRow3(ELPRODUCCIONBE, DET_DOCUMENTOBE, dgvt_doc, flagAccion)
                                    End If
                                End If
                                gsCode = ""
                                Dispose()
                            Else
                                FormMain.LblError.Text = gsError2
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            End If
                        End If

                    End If
                Else
                    Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE

                    ELPRODUCCIONBE.t_doc_ref = "OPRD"
                    ELPRODUCCIONBE.ser_doc_ref = sSDoc
                    ELPRODUCCIONBE.nro_doc_ref = sNDoc
                    ELPRODUCCIONBE.t_doc_ref1 = "OPRD" '"82"
                    ELPRODUCCIONBE.ser_doc_ref1 = sSDoc 'Vser_doc_ref1(i)
                    ELPRODUCCIONBE.nro_doc_ref1 = sNDoc 'Vnro_doc_ref1(i)
                    ELPRODUCCIONBE.cod_art = sObsOp
                    ELPRODUCCIONBE.demasia = cmbdemasia.Text
                    ELPRODUCCIONBE.cant_generar = txtcantidad.Text '* ELPRODUCCIONBE.fact
                    ELPRODUCCIONBE.ot_pedido = txttotal.Text ' Vcantidad(i)
                    ' ELPRODUCCIONBE.ot_pendiente = txttotal.Text
                    ELPRODUCCIONBE.usuario = gsCodUsr
                    gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
                    If gsError = "OK" Then
                        MsgBox("Orden de Produccion actualizada", MsgBoxStyle.Information)
                    Else
                        MsgBox("Error al Actualizar Produccion")
                        Exit Sub
                End If

            End If
            End If

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            tvwExplosion.Nodes.Clear()
            txtart_cod.Text = gArt
            txtdescripcion.Text = ARTICULOBL.SelectArt2(txtart_cod.Text)
            lblcod_art.Text = gArt
            lblart_des.Text = ARTICULOBL.SelectArt2(lblcod_art.Text)
            lblstc_actual.Text = ELPRODUCCIONBL.SelectStockArt(txtart_cod.Text)
            txtstk.Text = ELPRODUCCIONBL.SelectStockArt(txtart_cod.Text)
            cmbunidad.Text = ARTICULOBL.SelectUniMed(txtart_cod.Text)
            Dim dtExplosion As New DataTable
            dtExplosion = ARTICULOBL.getListdgv1(txtart_cod.Text)
            Dim dt As DataTable
            Dim s As String = ""
            dt = ELETIQUETABL.SelectArticuloCOD(txtart_cod.Text)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0).Item(1).ToString
            End If
            fnRecursiva(txtart_cod.Text, txtart_cod.Text + " - " + s, Nothing, 0)
            tvwExplosion.ExpandAll()
            tvwExplosion.SelectedNode = tvwExplosion.Nodes(0)
            rdbtotal.Checked = True
            gLinea = ""
            gSubLinea = ""
            gArt = ""
        Else
            gLinea = ""
            gSubLinea = ""
            gArt = ""
        End If


    End Sub

    Private Sub recursividad(ByVal sCodArt As String, ByVal dtExp As DataTable, ByVal nro_documento1 As String,
                             ByVal ser_documento1 As String, ByVal cantidad As String, ByVal ot_pendient As String,
                             ByVal ot_despacha As String)

        Dim sTipo, sCodComp, sComponente As String
        Dim dt As DataTable

        For i = 0 To dtExp.Rows.Count - 1
            sTipo = dtExp.Rows(i).Item(0)
            sCodComp = Mid(dtExp.Rows(i).Item(1), 1, 8)
            sComponente = dtExp.Rows(i).Item(2)

            'recursivo
            Dim dtComp As New DataTable
            dtComp = ARTICULOBL.getListdgv1(sCodComp)

            dt = ELPRODUCCIONBL.VerificarRepetido(sCodComp, nro_documento1)
            If dt.Rows.Count = 0 Then
                Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                nro_doc_ref = nro_doc_ref + 1
                nro_doc_ref = nro_doc_ref.PadLeft(9, "0")
                ELPRODUCCIONBE.t_doc_ref = "OPRD"
                ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
                ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref
                ELPRODUCCIONBE.t_doc_ref1 = "82"
                ELPRODUCCIONBE.ser_doc_ref1 = ser_documento1
                ELPRODUCCIONBE.nro_doc_ref1 = nro_documento1
                ELPRODUCCIONBE.cod_art = lblcod_art.Text
                ELPRODUCCIONBE.usuario = gsCodUsr
                ELPRODUCCIONBE.ot_pedido = Math.Truncate(txttotal.Text * sComponente) 'cantidad
                ELPRODUCCIONBE.ot_pendiente = Math.Truncate(txttotal.Text * sComponente) 'ot_pendient
                ELPRODUCCIONBE.ot_atendido = 0 'ot_despacha
                ELPRODUCCIONBE.Stoc_actual = ELPRODUCCIONBL.SelectStockArt(lblcod_art.Text) 'lblstc_actual.Text
                ELPRODUCCIONBE.cod_art_expl = sCodComp   'CODIGO DEL ARTICULO
                ELPRODUCCIONBE.opc_stock = chkstock
                ELPRODUCCIONBE.descripcion = txtdescripcion.Text
                'ojo
                ELPRODUCCIONBE.unidad_med = cmbunidad.Text
                ELPRODUCCIONBE.opc_temporal = sComponente   'LA CANTIDAD A MULTIPLICAR
                ELPRODUCCIONBE.demasia = cmbdemasia.Text
                ELPRODUCCIONBE.cant_generar = txttotal.Text * sComponente
                ELPRODUCCIONBE.fec_ent = dtpfec_entre.Value
                ELPRODUCCIONBE.cant_consumo = txtcantidad.Text
                flagAccion = "N"
                ELMVLOGSBE.log_codusu = gsCodUsr
                If Trim(sCodComp) = Trim(lblcod_art.Text) Then
                    sdoc = ELPRODUCCIONBE.ser_doc_ref
                    ndoc = nro_doc_ref
                End If
                gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)

            End If
            recursividad(sCodComp, dtComp, nro_documento1, ser_documento1, cantidad, ot_pendient, ot_despacha)
        Next
        If gsError = "OK" Then
            'PONER AKA GRID 2 CON LOS DATOS DEL ULTIMO CODIGO
        End If
    End Sub


    Private Sub txtcantidad_LostFocus(sender As Object, e As EventArgs) Handles txtcantidad.LostFocus
        Dim a, b As Double
        If txtcantidad.Text = "" Then a = 0 Else a = txtcantidad.Text
        If cmbdemasia.Text = "" Then b = 0 Else b = cmbdemasia.Text
        If a > 0 Then
            txtdemasia.Text = CDbl(txtcantidad.Text) * b / 100
            txttotal.Text = (CDbl(txtcantidad.Text) * b / 100) + CDbl(txtcantidad.Text)
        End If
    End Sub

    Private Sub cmbdemasia_LostFocus(sender As Object, e As EventArgs) Handles cmbdemasia.LostFocus
        If txtcantidad.Text = "" Then txtcantidad.Text = 0
        If cmbdemasia.Text = "" Then cmbdemasia.Text = 0
        If CDbl(txtcantidad.Text) > 0 Then
            txtdemasia.Text = CDbl(txtcantidad.Text) * CDbl(cmbdemasia.Text) / 100
            txttotal.Text = (CDbl(txtcantidad.Text) * CDbl(cmbdemasia.Text) / 100) + CDbl(txtcantidad.Text)
        End If
    End Sub

    Private Sub tvwExplosion_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwExplosion.AfterSelect
        If sOp = "1" Then
            txtart_cod.Text = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
        Else
            cmbarticulos.SelectedItem = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
        End If


    End Sub

    Private Sub ELPRODUCCION_VARIOS_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class