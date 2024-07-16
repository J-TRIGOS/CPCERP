
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class ELPRODUCCION

    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private ARTICULOBL As New ARTICULOBL
    Private dtExplComponente, dt2 As DataTable
    Dim x As Integer = 0
    Dim chkstock, chktemporal As String
    Dim nro_doc_ref As String
    Dim cantidad As Double

    Private Sub ELPRODUCCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                GetData()
                Limpiar()
            Case 1
                flagAccion = "M"
                GetData()
        End Select

        'explosion de materiales
        Dim dtExplosion As New DataTable
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

        dtExplComponente.Columns.Add(column1)
        dtExplComponente.Columns.Add(column2)
        dtExplComponente.Columns.Add(column3)
        dtExplComponente.Columns.Add(column4)

        Explotar(gsCode, dtExplosion)
        showExplosion()

    End Sub
    Private Sub Explotar(ByVal sCodArt As String, ByVal dtExp As DataTable)
        Dim sTipo As String
        Dim sCodComp As String
        Dim sComponente As String

        'barrer dt
        For i = 0 To dtExp.Rows.Count - 1
            sTipo = dtExp.Rows(i).Item(0)
            sCodComp = Mid(dtExp.Rows(i).Item(1), 1, 8)
            sComponente = Mid(dtExp.Rows(i).Item(1), 11)

            dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente)

            'recursivo
            Dim dtComp As New DataTable
            dtComp = ARTICULOBL.getListdgv1(sCodComp)
            cmbarticulos.Items.Add(sCodComp)
            Explotar(sCodComp, dtComp)

        Next

    End Sub

    Private Sub showExplosion()
        Dim sCode As String = ""
        Dim sChild As String
        Dim sTipo As String
        Dim sComponente As String

        With tvwExplosion

            For Each datarow In dtExplComponente.Rows

                'add parent
                sCode = CStr(datarow("CodArt")) 'CStr(datarow("CodArt"))
                sChild = CStr(datarow("CodComp"))
                sTipo = CStr(datarow("tipo"))
                sComponente = CStr(datarow("Componente"))
                Dim nTipo As Integer = Val(sTipo)

                Dim tns() As TreeNode
                tns = .Nodes.Find(sCode, True)

                If tns.Length = 0 Then

                    .Nodes.Add(sCode, sCode)
                    .Nodes(sCode).Nodes.Add(sChild, sChild + " - " + sComponente, nTipo, nTipo)
                Else

                    tns(0).Nodes.Add(sChild, sChild + " - " + sComponente, nTipo, nTipo)
                End If

            Next
        End With

        tvwExplosion.ExpandAll()
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If
        Select Case sFunc

            Case "save"
                SaveData()
                Exit Sub
            Case "delete"
                'DeleteData()
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub

    Private Sub recursividad(ByVal sCodArt As String, ByVal dtExp As DataTable)
        Dim sTipo, sCodComp, sComponente As String

        For i = 0 To dtExp.Rows.Count - 1
            sTipo = dtExp.Rows(i).Item(0)
            sCodComp = Mid(dtExp.Rows(i).Item(1), 1, 8)
            sComponente = dtExp.Rows(i).Item(2)

            'recursivo
            Dim dtComp As New DataTable
            dtComp = ARTICULOBL.getListdgv1(sCodComp)

            Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELPRODUCCIONBE.t_doc_ref = "OPRD"
            ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
            ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref
            ELPRODUCCIONBE.t_doc_ref1 = "82"
            ELPRODUCCIONBE.ser_doc_ref1 = lblnro_doc_ref.Text.Substring(0, 4)
            ELPRODUCCIONBE.nro_doc_ref1 = lblnro_doc_ref.Text.Substring(7, 7)
            ELPRODUCCIONBE.cod_art = lblcod_art.Text
            ELPRODUCCIONBE.usuario = gsCodUsr
            ELPRODUCCIONBE.ot_pedido = lblpedido.Text
            ELPRODUCCIONBE.ot_pendiente = lblpendiente.Text
            ELPRODUCCIONBE.ot_atendido = lbl_atend.Text
            ELPRODUCCIONBE.Stoc_actual = lblstc_actual.Text
            ELPRODUCCIONBE.cod_art_expl = sCodComp   'CODIGO DEL ARTICULO
            ELPRODUCCIONBE.opc_stock = chkstock
            ELPRODUCCIONBE.descripcion = txtdescripcion.Text
            ELPRODUCCIONBE.unidad_med = cmbunidad.SelectedItem
            ELPRODUCCIONBE.opc_temporal = sComponente   ' LA CANTIDAD A MULTIPLICAR
            ELPRODUCCIONBE.demasia = cmbdemasia.Text
            ELPRODUCCIONBE.cant_generar = txttotal.Text
            ELPRODUCCIONBE.fec_gene = dtpfec_entre.Value

            gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
            recursividad(sCodComp, dtComp)
        Next
        If gsError = "OK" Then
            'PONER AKA GRID 2 CON LOS DATOS DEL ULTIMO CODIGO
        End If
    End Sub
    Private Sub SaveData()

        If OkData() = False Then
            Exit Sub
        Else

            Dim a As String = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
            nro_doc_ref = ELPRODUCCIONBL.SelectMaxTransp().PadLeft(9, "0")

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else

                Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELPRODUCCIONBE.t_doc_ref = "OPRD"
                ELPRODUCCIONBE.ser_doc_ref = DateTime.Now.Year
                ELPRODUCCIONBE.nro_doc_ref = nro_doc_ref
                ELPRODUCCIONBE.t_doc_ref1 = "82"
                ELPRODUCCIONBE.ser_doc_ref1 = lblnro_doc_ref.Text.Substring(0, 4)
                ELPRODUCCIONBE.nro_doc_ref1 = lblnro_doc_ref.Text.Substring(7, 7)
                ELPRODUCCIONBE.cod_art = lblcod_art.Text
                ELPRODUCCIONBE.usuario = gsCodUsr
                ELPRODUCCIONBE.ot_pedido = lblpedido.Text
                ELPRODUCCIONBE.ot_pendiente = lblpendiente.Text
                ELPRODUCCIONBE.ot_atendido = lbl_atend.Text
                ELPRODUCCIONBE.Stoc_actual = lblstc_actual.Text
                ELPRODUCCIONBE.cod_art_expl = a   'codigo articulo
                ELPRODUCCIONBE.opc_stock = chkstock
                ELPRODUCCIONBE.descripcion = txtdescripcion.Text
                ELPRODUCCIONBE.unidad_med = cmbunidad.SelectedItem
                ELPRODUCCIONBE.opc_temporal = 1
                ELPRODUCCIONBE.demasia = cmbdemasia.Text
                ELPRODUCCIONBE.cant_generar = txttotal.Text
                ELPRODUCCIONBE.fec_gene = dtpfec_entre.Value

                gsError = ELPRODUCCIONBL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagAccion)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If chknivel.Checked = False Then
                        Dim dt1 As New DataTable
                        dt1 = ARTICULOBL.getListdgv1(a)
                        recursividad(a, dt1)
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
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

        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese una descripción", MsgBoxStyle.Exclamation)
            tvwExplosion.Select()
            Return False
        End If

        Try
            Dim a As String = tvwExplosion.SelectedNode.ToString
        Catch ex As Exception
            MsgBox("Seleccione un nodo", MsgBoxStyle.Exclamation)
            Return False
        End Try

        Return True
    End Function
    Private Sub Limpiar()
        'txtcod.Text = ELLIB_CONTBL.SelectMaxLibro().PadLeft(2, "0")
    End Sub

    Private Sub GetData()
        lblcod_art.Text = gsCode
        lblart_des.Text = gsCode2
        lblnro_doc_ref.Text = gsCode6 + " - " + gsCode7
        dtpfec_entre.Value = gsCode5
        lblpedido.Text = gsCode4
        lblpendiente.Text = gsCode3
        lblstc_actual.Text = ELPRODUCCIONBL.SelectStockArt(gsCode)

        txtcantidad.Text = gsCode4
        txtdemasia.Text = CDbl(gsCode4) * 0.07
        txttotal.Text = (CDbl(gsCode4) * 0.07) + gsCode4

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
    Private Sub ELPRODUCCION_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
    Private Sub chkPedido_CheckedChanged(sender As Object, e As EventArgs) Handles chkPedido.CheckedChanged
        If lblpedido.Text <> "" Then
#Disable Warning BC42024 ' Variable local sin usar: 'a'.
            Dim a, b As Double
#Enable Warning BC42024 ' Variable local sin usar: 'a'.
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
        Dim a, b As Double
        If txtcantidad.Text = "" Then a = 0 Else a = txtcantidad.Text
        If cmbdemasia.Text = "" Then b = 0 Else b = cmbdemasia.Text
        If a > 0 Then
            txtdemasia.Text = CDbl(txtcantidad.Text) * b / 100
            txttotal.Text = (CDbl(txtcantidad.Text) * b / 100) + CDbl(txtcantidad.Text)
        End If
    End Sub
End Class