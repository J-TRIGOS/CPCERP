Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormExplosionadoAll
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBCOMPBL As New ELTBCOMPBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private dtExplComponente As DataTable
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Private bCuarto As Boolean = True
    Private valor As Boolean = True
    Private code As String = ""
    Private lin As String = ""
    Public a1 As String
    Public a2 As String
    Public a3 As String
    Public a4 As String
    Public x As String
#Region "Llenar combos"

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region

    Private Sub ClearPar()
        txtcodartpart.Text = ""
        txtnomartpart.Text = ""
    End Sub

    Private Function VerPar(ByVal valor As Boolean) As Boolean
        txtcodartpart.Visible = valor
        txtnomartpart.Visible = valor
    End Function

    Private Sub ClearCMP()
        cmbtipocomp.SelectedIndex = 0
        cmbLineas.SelectedIndex = -1
        cmbSublineas.SelectedIndex = -1
        txtcodart.Text = ""
        'cmbArticulo.SelectedIndex = -1
        txtnomart.Text = ""
        npdcantcomp.Value = 1
    End Sub

    Private Sub SaveData()

        'If MessageBox.Show("Desea grabar el Registro",
        '           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'End If

        'dgvcatalogo
        'gsError2 = ELTBESPEBL.SaveRow(ELTBESPEBE, flagAccion, dgvcatalogo, txtartcodigo.Text, cmbcatalogo.SelectedValue)
        Dim ELTBCOMPBE As New ELTBCOMPBE
        Dim ARTICULOBE As New ARTICULOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        'If flagAccion = "ER" Then
        If gsCode6 = "" Then
            If txtcodart.Text = "" Then
                ELTBCOMPBE.cmp_codart = txtartcodpri.Text
                ELTBCOMPBE.cmp_codcom = txtcodartpart.Text
                ELTBCOMPBE.cmp_cantidad = npdcantcomp.Value
                ELTBCOMPBE.cmp_factor = "0"
                ELTBCOMPBE.cmp_tipo = Mid(cmbtipocomp.Text, 1, 2)
            Else
                ELTBCOMPBE.cmp_codart = txtcodartpart.Text
                ELTBCOMPBE.cmp_codcom = txtcodart.Text
                ELTBCOMPBE.cmp_cantidad = npdcantcomp.Value
                ELTBCOMPBE.cmp_factor = "0"
                ELTBCOMPBE.cmp_tipo = Mid(cmbtipocomp.Text, 1, 2)
            End If

        Else
            ELTBCOMPBE.cmp_codart = txtcodartpart.Text
            ELTBCOMPBE.cmp_codcom = gsCode12
            ELTBCOMPBE.cmp_cantidad = gsCode4
            ELTBCOMPBE.cmp_factor = "0"
            ELTBCOMPBE.cmp_tipo = Mid(gsCode5, 1, 2)
        End If
        'gsError3 = ELTBCOMPBL.SaveRowCMP(ELTBCOMPBE, flagAccion, dgvcomponente, txtcodartpart.Text)
        'Else
        gsError3 = ELTBCOMPBL.SaveRowCMP(ELTBCOMPBE, flagAccion, dgvcomponente, txtartcodpri.Text)
        'End If
        'gsError = ARTICULOBL.SaveRowFast(ARTICULOBE, flagAccion, ELMVLOGSBE)
        If gsError3 = "OK" Then
            MsgBox("Se ah actualizado segun lo marcado")
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub SaveDataart()

        'If MessageBox.Show("Desea grabar el Registro",
        '           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'End If

        'dgvcatalogo
        'gsError2 = ELTBESPEBL.SaveRow(ELTBESPEBE, flagAccion, dgvcatalogo, txtartcodigo.Text, cmbcatalogo.SelectedValue)
        Dim ELTBCOMPBE As New ELTBCOMPBE
        Dim ARTICULOBE As New ARTICULOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE

        Dim cod As Integer
        'cmblinea.Enabled = True
        cod = ARTICULOBL.LastCodigo(cmbSublineas.SelectedValue) + 1

        If flagAccion = "M" Then
            If gsCode6 = "0" Then
                ARTICULOBE.art_cod = gsCode12
                ARTICULOBE.art_descri = gsCode3
            Else
                If txtcodart.Text = "" Then
                    If cod.ToString.Length < 8 Then
                        Me.txtcodart.Text = "0" & cod
                    Else
                        Me.txtcodart.Text = cod
                    End If
                    ARTICULOBE.art_cod = Me.txtcodart.Text
                    ARTICULOBE.art_descri = Me.txtnomart.Text
                    ARTICULOBE.cod = txtcodart.Text
                    ARTICULOBE.nom = txtnomart.Text
                Else
                    ARTICULOBE.art_cod = Me.txtcodartpart.Text
                    ARTICULOBE.art_descri = Me.txtnomartpart.Text
                End If

            End If
            'ARTICULOBE.art_descri = Me.txtnomartpart.Text
        Else
            If cod.ToString.Length < 8 Then
                Me.txtcodart.Text = "0" & cod
            Else
                Me.txtcodart.Text = cod
            End If
            ARTICULOBE.art_cod = Me.txtcodart.Text
            ARTICULOBE.art_descri = Me.txtnomart.Text
            ARTICULOBE.cod = txtcodart.Text
            ARTICULOBE.nom = txtnomart.Text
            'ARTICULOBE.art_cod = Me.txtcodart.Text
            'ARTICULOBE.art_descri = Me.txtnomart.Text
        End If
        ARTICULOBE.art_slinea = cmbSublineas.SelectedValue
        ARTICULOBE.ccosto_cod = lblcc.Text
        ARTICULOBE.alm_cod = lblcodalm.Text
        ARTICULOBE.uni_cod = lblund.Text
        ARTICULOBE.art_aproreq = "1"
        'ARTICULOBE.art_cod = txtcodart.Text
        ARTICULOBE.medida = ARTICULOBL.getListcmb15(RTrim(lblformato.Text))
        ARTICULOBE.medida_nuevo = lblformato.Text
        ARTICULOBE.cod_proc = lblproc.Text
        ARTICULOBE.art_solm = lblart_solm.Text
        ELMVLOGSBE.log_codusu = gsCodUsr
        'gsError3 = ELTBCOMPBL.SaveRowCMP(ELTBCOMPBE, flagAccion, dgvcomponente, txtartcodpri.Text)
        gsError = ARTICULOBL.SaveRowFast(ARTICULOBE, flagAccion, ELMVLOGSBE)
        If gsError = "OK" Then
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormExplosionadoAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        cmbtipocomp.SelectedIndex = 0
        npdcantcomp.Value = 1
        dgvarbol.Columns.Add("COD", "COD")
        dgvarbol.Columns.Add("MADRE", "MADRE")
        dgvcomponente.Columns.Add("TIPO", "TIPO")
        dgvcomponente.Columns.Add("CODIGO", "CODIGO")
        dgvcomponente.Columns.Add("CANTIDAD", "CANTIDAD")
        dgvcomponente.Columns.Add("MADRE", "MADRE")
        'dgvcomponente.Columns.Add("RAIZ", "RAIZ")

        dgvnivel1.Columns.Add("ART_COD", "ART_COD")
        dgvnivel1.Columns.Add("NOM_ART", "NOM_ART")

        Dim dtExplosion As New DataTable
        txtartcodpri.Text = gsCode
        txtnomartpri.Text = ARTICULOBL.SelectArt2(txtartcodpri.Text)
        dtExplosion = ARTICULOBL.SelectDescripcion
        GetCmb("lin_codigo", "lin_descri", dtExplosion, cmbLineas)

        'dtExplosion = ARTICULOBL.getListdgv4(gsCode)
        'For Each Registro In dtExplosion.Rows
        '    dgvcomponente.Rows.Add(IIf(IsDBNull(Registro("Tipo")), "", Registro("Tipo")),
        '                           IIf(IsDBNull(Registro("CODIGO")), "", Mid(Registro("CODIGO"), 1, 8)),
        '                           IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD")),
        '                           IIf(IsDBNull(Registro("MADRE")), "", Registro("MADRE")))
        'Next
        dtExplosion = ARTICULOBL.getListdgv3(gsCode)
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

        If dtExplosion.Rows.Count = 0 Then
            Dim sCode As String = ""
            With tvwExplosion
                sCode = txtartcodpri.Text
                Dim tns() As TreeNode
                tns = .Nodes.Find(sCode, True)
                .Nodes.Add(sCode, sCode + " - " + txtnomartpri.Text)
            End With
            'GroupBox1.Enabled = False
            tvwExplosion.ExpandAll()
            flagAccion = "N"
            txtcodartpart.Text = txtartcodpri.Text
            txtnomartpart.Text = txtnomartpri.Text
            cmbtipocomp.SelectedIndex = 0
            npdcantcomp.Value = 1
        Else
            'Explotar(gsCode, dtExplosion)
            'txtcodartpart.Text = txtartcodpri.Text
            'txtnomartpart.Text = txtnomartpri.Text
            'showExplosion()
            tvwExplosion.Nodes.Clear()
            Dim dt As DataTable
            Dim s As String = ""
            dt = ELETIQUETABL.SelectArticuloCOD(gsCode)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0).Item(1).ToString
            End If
            fnRecursiva(gsCode, gsCode + " - " + s, Nothing, 0)
            tvwExplosion.ExpandAll()
            'tvwExplosion.SelectedNode. = txtcodartpart.Text

            flagAccion = "M"
        End If
        bPrimero = False
        bCuarto = True
        Dim tvn() As TreeNode = tvwExplosion.Nodes.Find(gsCode, True)
        If tvn IsNot Nothing AndAlso tvn.Length > 0 Then
            tvwExplosion.SelectedNode = tvn(0)
        End If
        txtcodartpart.Text = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
        txtnomartpart.Text = ARTICULOBL.SelectArt2(txtcodartpart.Text)
    End Sub

    Private Sub fnRecursiva(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode, ByVal tipo As Integer)
        Dim NN As TreeNode
        Dim sTipo As String
        Dim dtDataTable As DataTable
        If N Is Nothing Then
            NN = tvwExplosion.Nodes.Add(Key, Txt, tipo, tipo)
        Else
            NN = N.Nodes.Add(Key, Txt, tipo, tipo)
        End If

        dtDataTable = ARTICULOBL.getListdgv1(Key)
        For Each row As DataRow In dtDataTable.Rows
            sTipo = CStr(row("tipo"))
            Dim nTipo As Integer = Val(sTipo)
            'sComponente = CStr(row("Componente"))
            fnRecursiva(Mid(row("CODIGO"), 1, 8), row("CODIGO"), NN, nTipo)
        Next row
    End Sub

    Private Sub showExplosion()
        Dim dtExplosion As New DataTable
        Dim sCode As String = ""
        Dim sChild As String
        Dim sTipo As String
        Dim sComponente As String
        Dim sCodComp As String
        Dim sCant As String
        Dim count As Integer = 0
        Dim c As Integer = 0
        Dim a As Integer = 0
        Dim rep As String = ""
        Dim nod As String = ""
        Dim Vart_cod() As String
        Dim Vnod() As String
        Dim tns() As TreeNode
        tvwExplosion.Nodes.Clear()

        With tvwExplosion

            For Each datarow In dtExplComponente.Rows
                'add parent
                sCode = CStr(datarow("CodArt"))
                sChild = CStr(datarow("CodComp"))
                sTipo = CStr(datarow("tipo"))
                sComponente = CStr(datarow("Componente"))
                sCant = CStr(datarow("Cant"))
                Dim nTipo As Integer = Val(sTipo)


                tns = .Nodes.Find(sCode, True)
                nod = sCode + "|" + nod
                rep = sChild + "|" + rep

                If tns.Length = 0 Then
                    .Nodes.Add(sCode, sCode + " - " + txtnomartpri.Text)
                    .Nodes(sCode).Nodes.Add(sChild, sChild + " - " + sComponente + " -> " + sCant, nTipo, nTipo)
                Else
                    tns(0).Nodes.Add(sChild, sChild + " - " + sComponente + " -> " + sCant, nTipo, nTipo)
                End If
            Next
        End With
        tvwExplosion.ExpandAll()
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
            If dtExplComponente.Rows.Count = 0 Then
                dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente, sCant)
            Else
                count = 0
                'For s = 0 To dtExplComponente.Rows.Count - 1
                '    If dtExplComponente.Rows(s).Item("CodArt").ToString = sCodArt And
                '        dtExplComponente.Rows(s).Item("CodComp").ToString = sCodComp And
                '        dtExplComponente.Rows(s).Item("Tipo").ToString = sTipo And
                '        dtExplComponente.Rows(s).Item("Componente").ToString = sComponente Then
                '        count = count + 1
                '        'Else
                '        '    count = 0
                '    End If
                'Next
                'If count = 0 Then
                dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente, sCant)
                'End If
            End If

            'recursivo
            Dim dtComp As New DataTable
            'dtComp = ARTICULOBL.getListdgv2(sCodComp, txtartcodpri.Text) ', count)
            dtComp = ARTICULOBL.getListdgv3(sCodComp)
            Explotar(sCodComp, dtComp)
        Next

    End Sub

    Private Sub tvwExplosion_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwExplosion.AfterSelect
        If bCuarto Then
            bCuarto = False
            Exit Sub
        End If
        lin = "1"
        bSegundo = True
        If tvwExplosion.SelectedNode.IsSelected Then
            txtcodartpart.Text = tvwExplosion.SelectedNode.ToString.Substring(10, 8)
            txtnomartpart.Text = ARTICULOBL.SelectArt2(txtcodartpart.Text)
            cmbLineas.SelectedIndex = -1
            cmbSublineas.SelectedIndex = -1
        End If
        'bSegundo = False
        'lin = ""
    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        'bSegundo = True
        If cmbLineas.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectDescripcion1(cmbLineas.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        End If
        bSegundo = False
    End Sub
    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        If bSegundo Then
            Exit Sub
        End If
        txtcodart.Text = ""
        txtnomart.Text = txtnomartpart.Text
    End Sub
    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If bPrimero Then Exit Sub
        'buscar articulo
        code = txtcodart.Text
        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"
        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If
        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)
        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If
        valor = False
        code = ""
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()
        If Mid(sFunc, 5, 4) = "func" Then
            sFunc = Mid(sFunc, 10)
        End If
        Select Case sFunc
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub
    Private Sub btnquitar_Click_1(sender As Object, e As EventArgs) Handles btnquitar.Click
        Dim c As Integer = 0
        gsCode6 = "0"
        Dim frm As New FormNewArt
        gsCode = txtcodartpart.Text
        frm.btnaceptar.Enabled = False
        frm.ShowDialog()
        tvwExplosion.Nodes.Clear()
        gsCode = txtartcodpri.Text
        Dim dt As DataTable
        Dim s As String = ""
        dt = ELETIQUETABL.SelectArticuloCOD(gsCode)
        If dt.Rows.Count > 0 Then
            s = dt.Rows(0).Item(1).ToString
        End If
        fnRecursiva(gsCode, gsCode + " - " + s, Nothing, 0)
        tvwExplosion.ExpandAll()
        gsCode = ""
        gsCode6 = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If dgvcomponente.Rows.Count > 0 Then
            dgvnivel1.Visible = True
            VerPar(False)
            ClearCMP()
            ClearPar()
            For i = 0 To dgvcomponente.Rows.Count - 1
                If dgvcomponente.Rows(i).Cells("MADRE").Value <> txtartcodpri.Text Then
                    dgvnivel1.Rows.Add(dgvcomponente.Rows(i).Cells("CODIGO").Value)
                End If
            Next
        Else
            MsgBox("No hay datos para buscar")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        If btnnuevo.Text = "Nuevo" Then
            ClearCMP()
            btnnuevo.Text = "Cancelar"
        Else
            btnnuevo.Text = "Nuevo"
        End If

    End Sub

    Private Sub dgvnivel1_DoubleClick(sender As Object, e As EventArgs) Handles dgvnivel1.DoubleClick
        If dgvnivel1.Rows.Count > 0 Then
            txtcodartpart.Text = dgvnivel1.Rows(dgvnivel1.CurrentRow.Index).Cells("ART_COD").Value
            txtnomartpart.Text = ARTICULOBL.SelectArt2(txtcodartpart.Text)
            dgvnivel1.Visible = False
            GroupBox1.Visible = True
            VerPar(True)
        End If
    End Sub

    Private Sub btnbus_Click(sender As Object, e As EventArgs) Handles btnbus.Click
        sBusAlm = "241"
        gsCode2 = cmbSublineas.SelectedValue
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        gsCode2 = ""
        If gLinea <> Nothing Then
            txtcodart.Text = gLinea
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        gsCode6 = ""
        Dim dt As DataTable
        Dim s As String = ""
        Dim dtExplosion As New DataTable
        'Dim cou As Integer
        'If dgvcomponente.Rows.Count <> 0 Then
        '    For i = 0 To dgvcomponente.Rows.Count - 1
        '        If dgvcomponente.Rows(i).Cells("CODIGO").Value = txtcodart.Text Then
        'If MessageBox.Show("Desea grabar el Registro",
        '           Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'End If
        'Exit Sub
        '        End If
        '    Next
        'End If

        If txtcodart.Text = "" Then
            Dim frm As New FormNewArt
            flagAccion = "N"
            frm.ShowDialog()
            lblcc.Text = gsCode8
            lblcodalm.Text = gsCode9
            lblformato.Text = gsCode10
            lblund.Text = gsCode11
            lblproc.Text = gsCode7
            lblart_solm.Text = gsCode13
            If gsCode8 = "" Then
                MsgBox("No se ah actualizado el articulo")
                Exit Sub
            Else
                SaveDataart()
            End If
            'SaveDataart()
            'dgvcomponente.Rows.Add(Mid(cmbtipocomp.Text, 1, 2), txtcodart.Text, npdcantcomp.Value, txtcodartpart.Text, txtartcodpri.Text)
            SaveData()
            'tvwExplosion.Nodes.Clear()
            'Do While dtExplComponente.Rows.Count > 0
            '    dtExplComponente.Rows.RemoveAt(dtExplComponente.Rows.Count - 1)
            'Loop
            'dtExplosion = ARTICULOBL.getListdgv3(txtartcodpri.Text)
            'Explotar(txtartcodpri.Text, dtExplosion)
            'showExplosion()
            flagAccion = "M"
            gsCode8 = ""
            gsCode9 = ""
            gsCode10 = ""
            gsCode11 = ""
            gsCode7 = ""
            gsCode13 = ""
        Else
            btnnuevo.Text = "Nuevo"
            'dgvcomponente.Rows.Add(Mid(cmbtipocomp.Text, 1, 2), txtcodart.Text, npdcantcomp.Value, txtcodartpart.Text, txtartcodpri.Text)
            SaveData()
            'tvwExplosion.Nodes.Clear()
            'Do While dtExplComponente.Rows.Count > 0
            '    dtExplComponente.Rows.RemoveAt(dtExplComponente.Rows.Count - 1)
            'Loop
            'dtExplosion = ARTICULOBL.getListdgv3(txtartcodpri.Text)
            'Explotar(txtartcodpri.Text, dtExplosion)
            'showExplosion()
        End If
        tvwExplosion.Nodes.Clear()
        gsCode = txtartcodpri.Text
        dt = ELETIQUETABL.SelectArticuloCOD(gsCode)
        If dt.Rows.Count > 0 Then
            s = dt.Rows(0).Item(1).ToString
        End If
        fnRecursiva(gsCode, gsCode + " - " + s, Nothing, 0)
        tvwExplosion.ExpandAll()
    End Sub

    Private Sub txtcodartpart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodartpart.KeyDown
        If e.KeyValue = Keys.F9 Then
            dgvnivel1.Visible = True
            GroupBox1.Visible = False
            If dgvcomponente.Rows.Count > 0 Then
                Do While dgvnivel1.Rows.Count > 0
                    dgvnivel1.Rows.RemoveAt(dgvnivel1.Rows.Count - 1)
                Loop
                For i = 0 To dgvcomponente.Rows.Count - 1
                    dgvnivel1.Rows.Add(dgvcomponente.Rows(i).Cells("CODIGO").Value,
                                       ARTICULOBL.SelectArt2(dgvcomponente.Rows(i).Cells("CODIGO").Value))
                Next
            End If
            dgvnivel1.Visible = True
        End If
    End Sub

    'Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    '    dgvnivel1.Visible = True
    '    GroupBox1.Visible = False
    '    If dgvcomponente.Rows.Count > 0 Then
    '        Do While dgvnivel1.Rows.Count > 0
    '            dgvnivel1.Rows.RemoveAt(dgvnivel1.Rows.Count - 1)
    '        Loop
    '        For i = 0 To dgvcomponente.Rows.Count - 1
    '            dgvnivel1.Rows.Add(dgvcomponente.Rows(i).Cells("CODIGO").Value,
    '                               ARTICULOBL.SelectArt2(dgvcomponente.Rows(i).Cells("CODIGO").Value))
    '        Next
    '    End If
    '    dgvnivel1.Visible = True
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gsCode6 = "0"
        Dim dtExplosion As New DataTable
        Dim frm As New FormNewArt
        frm.btnborrar.Enabled = False
        gsCode = txtcodartpart.Text
        gsCode2 = txtartcodpri.Text
        frm.ShowDialog()
        lblcc.Text = gsCode8
        lblcodalm.Text = gsCode9
        lblformato.Text = gsCode10
        lblund.Text = gsCode11
        lblproc.Text = gsCode7
        lbltipo.Text = gsCode5
        lblcantidad.Text = gsCode4
        lblart_solm.Text = gsCode13
        flagAccion = "M"
        If gsCode8 = "" And gsCode9 = "" And gsCode10 = "" And gsCode11 = "" And gsCode7 = "" And
           gsCode5 = "" Then
            MsgBox("No se ah actualizado el articulo")
            Exit Sub
        Else
            txtnomartpart.Text = gsCode3
            SaveDataart()
        End If
        'dgvcomponente.Rows.Add(Mid(cmbtipocomp.Text, 1, 2), txtcodart.Text, npdcantcomp.Value, txtcodartpart.Text, txtartcodpri.Text)
        'If dgvcomponente.Rows.Count > 1 Then
        '    For i = 0 To Me.dgvcomponente.Rows.Count - 1
        '        If dgvcomponente.Rows(i).Cells("CODIGO").Value = txtcodartpart.Text Then
        '            dgvcomponente.Rows(i).Cells("CANTIDAD").Value = Val(gsCode4)
        '            dgvcomponente.Rows(i).Cells("TIPO").Value = Mid(gsCode5, 1, 2)
        '        End If
        '    Next
        'End If
        SaveData()
        'tvwExplosion.Nodes.Clear()
        'Do While dtExplComponente.Rows.Count > 0
        '    dtExplComponente.Rows.RemoveAt(dtExplComponente.Rows.Count - 1)
        'Loop
        'dtExplosion = ARTICULOBL.getListdgv3(txtartcodpri.Text)
        'Explotar(txtartcodpri.Text, dtExplosion)
        'showExplosion()
        tvwExplosion.Nodes.Clear()
        gsCode = txtartcodpri.Text
        Dim dt As DataTable
        Dim s As String = ""
        dt = ELETIQUETABL.SelectArticuloCOD(gsCode)
        If dt.Rows.Count > 0 Then
            s = dt.Rows(0).Item(1).ToString
        End If
        fnRecursiva(gsCode, gsCode + " - " + s, Nothing, 0)
        tvwExplosion.ExpandAll()
        'flagAccion = "M"
        gsCode8 = ""
        gsCode9 = ""
        gsCode10 = ""
        gsCode11 = ""
        gsCode7 = ""
        gsCode6 = ""
        gsCode5 = ""
        gsCode4 = ""
        gsCode3 = ""
        gsCode12 = ""
        gsCode13 = ""
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmbLineas.SelectedValue = gLinea
            cmbSublineas.SelectedValue = gSubLinea
            txtcodart.Text = gArt
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

End Class