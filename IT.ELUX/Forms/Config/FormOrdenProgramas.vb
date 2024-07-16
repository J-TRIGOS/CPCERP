Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormOrdenProgramas
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
    Private ARTICULOBL As New ARTICULOBL
    Private CCOSTOBL As New CCOSTOBL
    Private anho As String
    Private sArticulo As String

    Private Sub FormOrdenProgramas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfec_inicio.CustomFormat = "dd/MM/yyyy HH:mm:ss tt"
        dtpfec_inicio.Format = DateTimePickerFormat.Custom
        dtpfec_inicio.Value = DateTime.Now
        dtpfec_fin.CustomFormat = "dd/MM/yyyy HH:mm:ss tt"
        dtpfec_fin.Format = DateTimePickerFormat.Custom
        dtpfec_fin.Value = DateTime.Now
        cmbestado.SelectedIndex = 0
        anho = DateTime.Now.Year
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmbturno.SelectedIndex = 0
                txtdocumento.Text = anho & " - " & ELORDEN_PROGRAMBL.SelectMaxTransp(anho).PadLeft(7, "0")
                btnsolm.Enabled = False
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                Deshabilitar(False)
                gsCode7 = txtlin_prod.Text
                btnsolm.Enabled = True
                'Dim btn As New DataGridViewButtonColumn
                'If dgvt_doc.Columns(0).Name = "btnAprobar" Then
                'Else

                '    btn = New DataGridViewButtonColumn
                '    btn.HeaderText = "Cerrar"
                '    btn.Text = "Cerrar"
                '    btn.Name = "btnCerrar"
                '    btn.Frozen = True
                '    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                '    btn.FlatStyle = FlatStyle.Flat
                '    btn.UseColumnTextForButtonValue = True
                '    btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                '    dgvt_doc.Columns.Insert(0, btn)
                'End If
        End Select

    End Sub

    'Private Sub FormOrdenProgramas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    '    Dispose()
    'End Sub

    Sub Deshabilitar(ByVal F As Boolean)
        btnAgregar.Enabled = Not F
        'txtcco_co.Enabled = F
        'txtlin_prod.Enabled = Not F
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
            Case "exit"
                Dispose()
                Exit Sub
            Case "salir"
                Dispose()
                Exit Sub
            Case "pr"
                ReDim gsRptArgs(1)
                gsRptArgs(0) = RTrim(txtdocumento.Text.Substring(0, 4))
                gsRptArgs(1) = RTrim(txtdocumento.Text.Substring(7, 7))
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROW3.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "Print"
                ReDim gsRptArgs(1)
                gsRptArgs(0) = RTrim(txtdocumento.Text.Substring(0, 4))
                gsRptArgs(1) = RTrim(txtdocumento.Text.Substring(7, 7))
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROW2.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
        End Select
    End Sub

    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELORDEN_PROGRAMBE As New ELORDEN_PROGRAMBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELORDEN_PROGRAMBE.t_doc_ref = "PROG"
                If flagAccion = "N" Then
                    ELORDEN_PROGRAMBE.nro_doc_ref = ELORDEN_PROGRAMBL.SelectMaxTransp(DateTime.Now.Year).PadLeft(7, "0")
                    ELORDEN_PROGRAMBE.ser_doc_ref = dtpfec_inicio.Value.Year
                Else
                    ELORDEN_PROGRAMBE.ser_doc_ref = txtdocumento.Text.Substring(0, 4)
                    ELORDEN_PROGRAMBE.nro_doc_ref = txtdocumento.Text.Substring(7, 7)
                End If

                ELORDEN_PROGRAMBE.cco_cod = txtcco_cod.Text
                ELORDEN_PROGRAMBE.cod_area = txtlin_prod.Text
                ELORDEN_PROGRAMBE.cod_grupo = txtgrupo_tra.Text
                ELORDEN_PROGRAMBE.turno = cmbturno.SelectedIndex
                ELORDEN_PROGRAMBE.fec_gene = DateTime.Now.ToShortDateString
                ELORDEN_PROGRAMBE.fec_fin = dtpfec_fin.Value
                ELORDEN_PROGRAMBE.fec_ini = dtpfec_inicio.Value
                ELORDEN_PROGRAMBE.estado = cmbestado.SelectedIndex
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELORDEN_PROGRAMBL.SaveRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, flagAccion, dgvt_doc, ELORDEN_DET_PROGRAMBE)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Function OkData() As Boolean
        If txtcco_cod.Text = "" Then
            MsgBox("Ingrese el Centro costo", MsgBoxStyle.Exclamation)
            txtcco_cod.Focus()
            Return False
        End If
        'If txtgrupo_tra.Text = "" Then
        '    MsgBox("Ingrese el grupo de trabajo", MsgBoxStyle.Exclamation)
        '    txtgrupo_tra.Focus()
        '    Return False
        'End If
        If txtlin_prod.Text = "" Then
            MsgBox("Ingrese el Area", MsgBoxStyle.Exclamation)
            txtlin_prod.Focus()
            Return False
        End If
        'AGREGADO
        If cmbturno.SelectedIndex = -1 Then
            MsgBox("Ingrese el turno", MsgBoxStyle.Exclamation)
            cmbturno.Focus()
            Return False
        End If

        If dgvt_doc.Rows.Count < 1 Then
            MsgBox("Ingrese detalle a la programación", MsgBoxStyle.Exclamation)
            cmbturno.Focus()
            Return False
        End If
        'Dim fechafin As Date = dtpfec_inicio.Value
        'Dim fechafindos As Date = dtpfec_inicio.Value
        'Dim minutos As Double = 0
        'dgvt_doc.Rows(0).Cells("Fecha_ini").Value = fechafin
        'dgvt_doc.Rows(0).Cells("Fecha_Fin").Value = fechafindos.AddMinutes((dgvt_doc.Rows(0).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(0).Cells("Duracion").Value)
        ''minutos = (dgvt_doc.Rows(0).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(0).Cells("Duracion").Value
        'For i = 1 To dgvt_doc.Rows.Count - 1
        '    minutos = minutos + (dgvt_doc.Rows(i).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(i).Cells("Duracion").Value
        '    'minutos = minutos + dgvt_doc.Rows(i).Cells("Duracion").Value
        '    fechafindos = fechafin.AddMinutes(minutos)
        '    dgvt_doc.Rows(i).Cells("Fecha_ini").Value = fechafindos
        '    dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = fechafindos.AddMinutes(minutos)
        'Next
        Dim d As Double = 0
        Dim f As Integer = 0
        anho = dtpfec_inicio.Value.Year
        If flagAccion = "N" Then
            txtdocumento.Text = anho & " - " & ELORDEN_PROGRAMBL.SelectMaxTransp(anho).PadLeft(7, "0")
        End If
        dtpfec_fin.Value = dtpfec_inicio.Value
        For i = 0 To dgvt_doc.Rows.Count - 1
            f = f + 1
            d = dgvt_doc.Rows(i).Cells("Cantidad").Value * 60 / dgvt_doc.Rows(i).Cells("Duracion").Value
            If f > 1 Then
                dgvt_doc.Rows(i).Cells("Fecha_ini").Value = dtpfec_fin.Value
            End If
            dtpfec_fin.Value = dtpfec_fin.Value.AddMinutes(d)
            dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = dtpfec_fin.Value
            dgvt_doc.Rows(i).Cells("NUM_DIF").Value = d
            If f = dgvt_doc.Rows.Count - 1 Then
                dgvt_doc.Rows(i + 1).Cells("Fecha_ini").Value = dtpfec_fin.Value
            End If
        Next
        dgvt_doc.Rows(0).Cells("Fecha_ini").Value = dtpfec_inicio.Value
        Return True
    End Function

    Private Sub GetData(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim Dtcabezera, Dtdetalle As DataTable
        Dim Registro As DataRow
        Dim dt As DataTable
        Dtcabezera = ELORDEN_PROGRAMBL.SelectRow(sTdoc, sSDoc, sNDoc)
        For Each Registro In Dtcabezera.Rows
            txtdocumento.Text = Registro("SER_DOC_REF") & " - " & Registro("NRO_DOC_REF")
            Label11.Text = Registro("NRO_DOC_REF")
            'txtcco_co.Text = IIf(IsDBNull(Registro("C_COSTO")), "", Registro("C_COSTO"))
            'gsCode7 = 
            'lblcco_co.Text = IIf(IsDBNull(Registro("CCOSTO")), "", Registro("CCOSTO"))
            txtlin_prod.Text = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
            lbllin_prod.Text = IIf(IsDBNull(Registro("LPRO")), "", Registro("LPRO"))
            txtgrupo_tra.Text = IIf(IsDBNull(Registro("COD_GRUPO")), "", Registro("COD_GRUPO"))
            txtnomgrup.Text = IIf(IsDBNull(Registro("NGRU")), "", Registro("NGRU"))
            cmbturno.SelectedIndex = CInt(Registro("TURNO"))
            dtpfec_inicio.Value = Registro("FEC_INI")
            dtpfec_fin.Value = Registro("FEC_FIN")
            cmbestado.SelectedIndex = IIf(IsDBNull(Registro("ESTADO")), -1, Registro("ESTADO"))
            txtcco_cod.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD")) 'gsCode7
            dt = ELPAGO_DOCUMENTOBL.SelectCentroCostoCOD(txtcco_cod.Text)
            If dt.Rows.Count > 0 Then
                txtnom_cco.Text = dt.Rows(0).Item(1).ToString
            Else
                txtnom_cco.Text = ""
            End If
            'dt = ELORDEN_PROGRAMBL.SelectGroupDet(txtgrupo_tra.Text)
            'If dt.Rows.Count > 0 Then
            '    txtnom_cco.Text = dt.Rows(0).Item(1).ToString
            'Else
            '    txtnom_cco.Text = ""
            'End If
        Next
        Dtdetalle = ELORDEN_PROGRAMBL.SelectRowDetalle(sTdoc, sSDoc, sNDoc)
        For Each Detalle In Dtdetalle.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(Detalle("SEQ")), "", Detalle("SEQ")),'0'IIf(IsDBNull(Detalle("CTCT_COD")), "", Detalle("CTCT_COD")),'IIf(IsDBNull(Detalle("CLIENTE")), "", Detalle("CLIENTE")),'IIf(IsDBNull(Detalle("O_PRODUCCION")), "", Detalle("O_PRODUCCION")),
                              IIf(IsDBNull(Detalle("ART_COD")), "", Detalle("ART_COD")),            '1
                              IIf(IsDBNull(Detalle("ARTICULO")), "", Detalle("ARTICULO")),          '2
                              IIf(IsDBNull(Detalle("CANTIDAD")), "", Detalle("CANTIDAD")),          '3
                              IIf(IsDBNull(Detalle("PENDIENTE")), "", Detalle("PENDIENTE")),        '4
                              IIf(IsDBNull(Detalle("ATENTIDO")), "", Detalle("ATENTIDO")),          '5          -IIf(IsDBNull(Detalle("PENDIENTE")), "", Detalle("PENDIENTE")),'IIf(IsDBNull(Detalle("ATENTIDO")), "", Detalle("ATENTIDO")),          '5 IIf(IsDBNull(Detalle("FEC_GENE")), "", Detalle("FEC_GENE")),
                              IIf(IsDBNull(Detalle("DURACION")), "", Detalle("DURACION")),          '6
                              IIf(IsDBNull(Detalle("FEC_INI")), "", Detalle("FEC_INI")),            '7
                              IIf(IsDBNull(Detalle("FEC_FIN")), "", Detalle("FEC_FIN")),            '8
                              IIf(IsDBNull(Detalle("ESTADO")), "", Detalle("ESTADO")),              '9
                              IIf(IsDBNull(Detalle("PROC")), "", Detalle("PROC")),                  '10
                              IIf(IsDBNull(Detalle("NUM_DIF")), "", Detalle("NUM_DIF")),            '11
                              IIf(IsDBNull(Detalle("T_DOC_REF1")), "", Detalle("T_DOC_REF1")),      '12
                              IIf(IsDBNull(Detalle("SER_DOC_REF1")), "", Detalle("SER_DOC_REF1")),  '13
                              IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")),  '14
                              IIf(IsDBNull(Detalle("DIF_HORA")), "", Detalle("DIF_HORA"))) '15
        Next
        'Dim numero As Double
        'For i = 0 To dgvt_doc.Rows.Count - 1
        '    numero = numero + dgvt_doc.Rows(i).Cells("NUM_DIF").Value
        'Next
        'dtpfec_fin.Value = dtpfec_fin.Value.AddMinutes(numero)
    End Sub
#Region "Ordenar"
    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    Private Sub dgvCaracteristica_DragDrop(ByVal sender As Object,
                                   ByVal e As DragEventArgs) _
                                   Handles dgvt_doc.DragDrop
        Dim p As Point = dgvt_doc.PointToClient(New Point(e.X, e.Y))
        dragIndex = dgvt_doc.HitTest(p.X, p.Y).RowIndex
        If dragIndex > -1 Then

            If (e.Effect = DragDropEffects.Move) Then
                Dim dragRow As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
                dgvt_doc.Rows.RemoveAt(fromIndex)
                dgvt_doc.Rows.Insert(dragIndex, dragRow)
            End If
        End If

    End Sub

    Private Sub dgvCaracteristica_DragOver(ByVal sender As Object,
                                   ByVal e As DragEventArgs) _
                                   Handles dgvt_doc.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    'The mouse events

    Private Sub dgvCaracteristica_MouseDown(ByVal sender As Object,
                                    ByVal e As MouseEventArgs) _
                                    Handles dgvt_doc.MouseDown
        fromIndex = dgvt_doc.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2),
                                       e.Y - (dragSize.Height / 2)),
                             dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub dgvCaracteristica_MouseMove(ByVal sender As Object,
                                    ByVal e As MouseEventArgs) _
                                    Handles dgvt_doc.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
    AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                dgvt_doc.DoDragDrop(dgvt_doc.Rows(fromIndex),
                               DragDropEffects.Move)
            End If
        End If
    End Sub
#End Region

#Region "KeyDown"
    Private Sub txtlin_prod_LostFocus(sender As Object, e As EventArgs) Handles txtlin_prod.LostFocus
        If txtlin_prod.Text = "" Then
            lbllin_prod.Text = ""
            btnAgregar.Enabled = False
        Else
            Dim dt As DataTable
            'dt = ELORDEN_PROGRAMBL.SelectLineaProduSelect(txtlin_prod.Text, gsCode7)
            dt = ELORDEN_PROGRAMBL.SelectLineaProduSelect(txtlin_prod.Text)
            If dt.Rows.Count > 0 Then
                btnAgregar.Enabled = True
                txtlin_prod.Text = dt.Rows(0).Item(0).ToString
                lbllin_prod.Text = dt.Rows(0).Item(1).ToString
                gsCode7 = dt.Rows(0).Item(0).ToString
            Else
                MsgBox("No existe el Area")
                btnAgregar.Enabled = False
                txtlin_prod.Text = ""
                lbllin_prod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtlin_prod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlin_prod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "109"
            gsCode11 = txtcco_cod.Text
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                btnAgregar.Enabled = True
                txtlin_prod.Text = gLinea
                lbllin_prod.Text = gSubLinea
                gsCode7 = gLinea
                gsCode11 = ""
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
            gLinea = ""
            gSubLinea = ""
            gsCode11 = ""
            'gsCode7 = ""
        End If
    End Sub

    Private Sub txtcco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "101"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcco_cod.Text = gLinea
                txtnom_cco.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtgrupo_tra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgrupo_tra.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "234"
            gsCode11 = Me.txtcco_cod.Text
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtgrupo_tra.Text = gLinea
                txtnomgrup.Text = gSubLinea
                gsCode11 = ""
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
        gsCode11 = ""
        gLinea = ""
        gSubLinea = ""
    End Sub
#End Region

#Region "Boton"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        gsCode7 = txtcco_cod.Text
        Dim frm As New FormDocuRefContaff
        frm.ShowDialog()
        Dim minutos As Double = 0

        For i = 0 To dgvt_doc.Rows.Count - 1
            'MsgBox(dgvt_doc.Rows(i).Cells("DURACION").Value)
            minutos = minutos + (dgvt_doc.Rows(i).Cells("CANTIDAD").Value * 60) / dgvt_doc.Rows(i).Cells("DURACION").Value 'CInt(lvbusqueda1.Items(i).SubItems(11).Text) * 60 / CInt(lvbusqueda1.Items(i).SubItems(13).Text)
            dgvt_doc.Rows(i).Cells("NUM_DIF").Value = minutos
        Next
        dtpfec_fin.Value = dtpfec_inicio.Value.AddMinutes(minutos)
        gsCode7 = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "245"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcco_cod.Text = gLinea
            txtnom_cco.Text = gSubLinea
            gsCode7 = gLinea
            txtlin_prod.Text = ""
            lbllin_prod.Text = ""
            txtgrupo_tra.Text = ""
            txtnomgrup.Text = ""
            gLinea = ""
            gSubLinea = ""
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvt_doc.Rows.Count > 0 Then
            If flagAccion = "M" Then
                Dim ELORDEN_PROGRAMBE As New ELORDEN_PROGRAMBE
                Dim ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                'ELORDEN_PROGRAMBE.ser_doc_ref = txtdocumento.Text.Substring(0, 4)
                'ELORDEN_PROGRAMBE.nro_doc_ref = txtdocumento.Text.Substring(7, 7)
                'ORDENCOMPRABE.NRO_DOC_REF = txtnumero.Text
                ELORDEN_DET_PROGRAMBE.t_doc_ref = "PROG"
                ELORDEN_DET_PROGRAMBE.ser_doc_ref = txtdocumento.Text.Substring(0, 4)
                ELORDEN_DET_PROGRAMBE.nro_doc_ref = txtdocumento.Text.Substring(7, 7)
                ELORDEN_DET_PROGRAMBE.t_doc_ref1 = "OPRD"
                ELORDEN_DET_PROGRAMBE.ser_doc_ref1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                ELORDEN_DET_PROGRAMBE.nro_doc_ref1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                ELORDEN_DET_PROGRAMBE.cod_articulo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("COD_ARTICULO").Value
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELORDEN_PROGRAMBL.SaveRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, "R", dgvt_doc, ELORDEN_DET_PROGRAMBE)
            End If
            dgvt_doc.Rows.Remove(dgvt_doc.CurrentRow)
                dgvt_doc.Refresh()
                If dgvt_doc.Rows.Count = 0 Then
                    dtpfec_fin.Value = dtpfec_inicio.Value
                Else
                    Dim fechafin As Date = dtpfec_inicio.Value
                    Dim fechafindos As Date = dtpfec_inicio.Value
                    Dim minutos As Integer = 0
                    dgvt_doc.Rows(0).Cells("Fecha_ini").Value = fechafin
                    dgvt_doc.Rows(0).Cells("Fecha_Fin").Value = fechafindos.AddMinutes(dgvt_doc.Rows(0).Cells("Duracion").Value)

                    For i = 1 To dgvt_doc.Rows.Count - 1
                        minutos = minutos + (dgvt_doc.Rows(i).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(i).Cells("Duracion").Value
                        fechafindos = fechafin.AddMinutes(minutos)
                        dgvt_doc.Rows(i).Cells("Fecha_ini").Value = fechafindos
                        dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = fechafindos.AddMinutes(minutos)
                    Next
                End If
            Else
                MsgBox("No hay Registros que quitar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "109"
        gsCode11 = txtcco_cod.Text
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            btnAgregar.Enabled = True
            txtlin_prod.Text = gLinea
            lbllin_prod.Text = gSubLinea
            'gsCode7 = gLinea
            gLinea = ""
            gSubLinea = ""
        End If
        gLinea = ""
        gSubLinea = ""
        gsCode11 = ""
        'gsCode7 = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "234"
        gsCode11 = Me.txtcco_cod.Text
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtgrupo_tra.Text = gLinea
            txtnomgrup.Text = gSubLinea
            gsCode11 = ""
            gLinea = ""
            gSubLinea = ""
        End If
        gLinea = ""
        gSubLinea = ""
        gsCode11 = ""
    End Sub

#End Region

    Private Sub dtpfec_inicio_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_inicio.LostFocus
        Dim d As Double = 0
        Dim f As Integer = 0
        anho = dtpfec_inicio.Value.Year
        If flagAccion = "N" Then
            txtdocumento.Text = anho & " - " & ELORDEN_PROGRAMBL.SelectMaxTransp(anho).PadLeft(7, "0")
        End If
        If dgvt_doc.Rows.Count = 0 Then
            dtpfec_fin.Value = dtpfec_inicio.Value
            Exit Sub
        End If
        dtpfec_fin.Value = dtpfec_inicio.Value
        For i = 0 To dgvt_doc.Rows.Count - 1
            f = f + 1
            d = dgvt_doc.Rows(i).Cells("Cantidad").Value * 60 / dgvt_doc.Rows(i).Cells("Duracion").Value
            If f > 1 Then
                dgvt_doc.Rows(i).Cells("Fecha_ini").Value = dtpfec_fin.Value
            End If
            dtpfec_fin.Value = dtpfec_fin.Value.AddMinutes(d)
            dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = dtpfec_fin.Value
            dgvt_doc.Rows(i).Cells("NUM_DIF").Value = d
            If f = dgvt_doc.Rows.Count - 1 Then
                dgvt_doc.Rows(i + 1).Cells("Fecha_ini").Value = dtpfec_fin.Value
            End If
        Next
        dgvt_doc.Rows(0).Cells("Fecha_ini").Value = dtpfec_inicio.Value
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub

    Private Sub txtcco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcco_cod.LostFocus
        If txtcco_cod.TextLength > 2 Then
            txtnom_cco.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
        Else
            txtnom_cco.Text = ""
        End If
    End Sub

    Private Sub btnsolm_Click(sender As Object, e As EventArgs) Handles btnsolm.Click
        Dim item As ListViewItem
        If flagAccion = "M" Then
            Dim frm As New FormSolmOrden
            For i = 0 To dgvt_doc.Rows.Count - 1
                item = frm.lvbusqueda.Items.Add(dgvt_doc.Rows(i).Cells("COD_ARTICULO").Value)
                item.SubItems.Add(dgvt_doc.Rows(i).Cells("ARTICULO").Value)
                item.SubItems.Add(dgvt_doc.Rows(i).Cells("CANTIDAD").Value)
                item.SubItems.Add(Label11.Text)
                item.SubItems.Add(txtcco_cod.Text)
                item.SubItems.Add(txtlin_prod.Text)
                item.SubItems.Add(dgvt_doc.Rows(i).Cells("PROC").Value)
                item.SubItems.Add(dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value)
                item.SubItems.Add(dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value)
                item.SubItems.Add(ARTICULOBL.SelVerSerSolm("PROG", Mid(txtdocumento.Text, 1, 4), Label11.Text, dgvt_doc.Rows(i).Cells("COD_ARTICULO").Value))
                item.SubItems.Add(ARTICULOBL.SelVerNroSolm("PROG", Mid(txtdocumento.Text, 1, 4), Label11.Text, dgvt_doc.Rows(i).Cells("COD_ARTICULO").Value))
            Next
            frm.lblndoc.Text = Label11.Text
            frm.lbltdoc.Text = "PROG"
            frm.lblsdoc.Text = Mid(txtdocumento.Text, 1, 4)
            frm.ShowDialog()
        Else
            MsgBox("No se Ah guardado el programa")
        End If
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("No hay items para Sumar")
        Else
            Dim fechafin As Date = dtpfec_inicio.Value
            Dim fechafindos As Date = dtpfec_inicio.Value
            Dim minutos As Double = 0
            dgvt_doc.Rows(0).Cells("Fecha_ini").Value = fechafin
            dgvt_doc.Rows(0).Cells("Fecha_Fin").Value = fechafindos.AddMinutes((dgvt_doc.Rows(0).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(0).Cells("Duracion").Value)
            'minutos = (dgvt_doc.Rows(0).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(0).Cells("Duracion").Value
            If dgvt_doc.Rows.Count > 1 Then
                For i = 1 To dgvt_doc.Rows.Count - 1
                    minutos = minutos + (dgvt_doc.Rows(i).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(i).Cells("Duracion").Value
                    'minutos = minutos + dgvt_doc.Rows(i).Cells("Duracion").Value
                    fechafindos = fechafin.AddMinutes(minutos)
                    dgvt_doc.Rows(i).Cells("Fecha_ini").Value = fechafindos
                    dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = fechafindos.AddMinutes(minutos)
                Next
            End If

        End If
    End Sub

    Private Sub FormOrdenProgramas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        gsError = ELORDEN_PROGRAMBL.SaveRow1(ELPRODUCCIONBE, ELMVLOGSBE, "M1")
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    'Private Sub dgvt_doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt_doc.CellContentClick
    '    Dim senderGrid = DirectCast(sender, DataGridView)
    '    Dim Dtdetalle As DataTable
    '    If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
    '    e.RowIndex >= 0 Then
    '        sArticulo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("COD_ARTICULO").Value + " " + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ARTICULO").Value
    '        If e.ColumnIndex = 0 Then
    '            If MessageBox.Show("¿Esta seguro de cerrar el articulo " + sArticulo + " de la orden ?",
    '          Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    '          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
    '                Exit Sub
    '            End If
    '            'ELTBGRUPCORVALBL.SelectRow("0002", lstValor)
    '            'enviarCorreo()
    '            Dim ELORDEN_PROGRAMBE As New ELORDEN_PROGRAMBE
    '            Dim ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
    '            Dim ELMVLOGSBE As New ELMVLOGSBE
    '            'ELORDEN_PROGRAMBE.ser_doc_ref = txtdocumento.Text.Substring(0, 4)
    '            'ELORDEN_PROGRAMBE.nro_doc_ref = txtdocumento.Text.Substring(7, 7)
    '            'ORDENCOMPRABE.NRO_DOC_REF = txtnumero.Text
    '            ELORDEN_DET_PROGRAMBE.ser_doc_ref1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
    '            ELORDEN_DET_PROGRAMBE.nro_doc_ref1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
    '            ELORDEN_DET_PROGRAMBE.cod_articulo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("COD_ARTICULO").Value
    '            ELMVLOGSBE.log_codusu = gsCodUsr
    '            gsError = ELORDEN_PROGRAMBL.SaveRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, "C", dgvt_doc, ELORDEN_DET_PROGRAMBE)
    '            If gsError = "OK" Then
    '                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
    '                'cmb_serdoc.Enabled = False
    '                'sEstAlmac = cmbalmac.SelectedValue
    '                'Me.btnborrar.Enabled = False
    '                Me.btndocu.Enabled = False
    '                Me.btnAgregar.Enabled = False
    '                'Dim i As Integer
    '                'For i = 0 To 45
    '                '    dgvt_doc.Columns(i).ReadOnly = True
    '                'Next
    '                'Dispose()
    '                dgvt_doc.DataSource = Nothing
    '                'Dtdetalle = ELORDEN_PROGRAMBL.SelectRowDetalle(sTDoc, sSDoc, sNDoc)
    '                'For Each Detalle In Dtdetalle.Rows
    '                '    dgvt_doc.Rows.Add(IIf(IsDBNull(Detalle("SEQ")), "", Detalle("SEQ")),'0'IIf(IsDBNull(Detalle("CTCT_COD")), "", Detalle("CTCT_COD")),'IIf(IsDBNull(Detalle("CLIENTE")), "", Detalle("CLIENTE")),'IIf(IsDBNull(Detalle("O_PRODUCCION")), "", Detalle("O_PRODUCCION")),
    '                '                      IIf(IsDBNull(Detalle("ART_COD")), "", Detalle("ART_COD")),            '1
    '                '                      IIf(IsDBNull(Detalle("ARTICULO")), "", Detalle("ARTICULO")),          '2
    '                '                      IIf(IsDBNull(Detalle("CANTIDAD")), "", Detalle("CANTIDAD")),          '3
    '                '                      IIf(IsDBNull(Detalle("PENDIENTE")), "", Detalle("PENDIENTE")),        '4
    '                '                      IIf(IsDBNull(Detalle("ATENTIDO")), "", Detalle("ATENTIDO")),          '5          -IIf(IsDBNull(Detalle("PENDIENTE")), "", Detalle("PENDIENTE")),'IIf(IsDBNull(Detalle("ATENTIDO")), "", Detalle("ATENTIDO")),          '5 IIf(IsDBNull(Detalle("FEC_GENE")), "", Detalle("FEC_GENE")),
    '                '                      IIf(IsDBNull(Detalle("DURACION")), "", Detalle("DURACION")),          '6
    '                '                      IIf(IsDBNull(Detalle("FEC_INI")), "", Detalle("FEC_INI")),            '7
    '                '                      IIf(IsDBNull(Detalle("FEC_FIN")), "", Detalle("FEC_FIN")),            '8
    '                '                      IIf(IsDBNull(Detalle("ESTADO")), "", Detalle("ESTADO")),              '9
    '                '                      IIf(IsDBNull(Detalle("PROC")), "", Detalle("PROC")),                  '10
    '                '                      IIf(IsDBNull(Detalle("NUM_DIF")), "", Detalle("NUM_DIF")),            '11
    '                '                      IIf(IsDBNull(Detalle("T_DOC_REF1")), "", Detalle("T_DOC_REF1")),      '12
    '                '                      IIf(IsDBNull(Detalle("SER_DOC_REF1")), "", Detalle("SER_DOC_REF1")),  '13
    '                '                      IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")),  '14
    '                '                      IIf(IsDBNull(Detalle("DIF_HORA")), "", Detalle("DIF_HORA"))) '15
    '                'Next
    '                Dtdetalle = ELORDEN_PROGRAMBL.SelectRowDetalle(sTDoc, sSDoc, sNDoc)
    '                For Each Detalle In Dtdetalle.Rows
    '                    dgvt_doc.Rows.Add(IIf(IsDBNull(Detalle("SEQ")), "", Detalle("SEQ")),'0'IIf(IsDBNull(Detalle("CTCT_COD")), "", Detalle("CTCT_COD")),'IIf(IsDBNull(Detalle("CLIENTE")), "", Detalle("CLIENTE")),'IIf(IsDBNull(Detalle("O_PRODUCCION")), "", Detalle("O_PRODUCCION")),
    '                                      IIf(IsDBNull(Detalle("ART_COD")), "", Detalle("ART_COD")),            '1
    '                                      IIf(IsDBNull(Detalle("ARTICULO")), "", Detalle("ARTICULO")),          '2
    '                                      IIf(IsDBNull(Detalle("CANTIDAD")), "", Detalle("CANTIDAD")),          '3
    '                                      IIf(IsDBNull(Detalle("PENDIENTE")), "", Detalle("PENDIENTE")),        '4
    '                                      IIf(IsDBNull(Detalle("ATENTIDO")), "", Detalle("ATENTIDO")),          '5          -IIf(IsDBNull(Detalle("PENDIENTE")), "", Detalle("PENDIENTE")),'IIf(IsDBNull(Detalle("ATENTIDO")), "", Detalle("ATENTIDO")),          '5 IIf(IsDBNull(Detalle("FEC_GENE")), "", Detalle("FEC_GENE")),
    '                                      IIf(IsDBNull(Detalle("DURACION")), "", Detalle("DURACION")),          '6
    '                                      IIf(IsDBNull(Detalle("FEC_INI")), "", Detalle("FEC_INI")),            '7
    '                                      IIf(IsDBNull(Detalle("FEC_FIN")), "", Detalle("FEC_FIN")),            '8
    '                                      IIf(IsDBNull(Detalle("ESTADO")), "", Detalle("ESTADO")),              '9
    '                                      IIf(IsDBNull(Detalle("PROC")), "", Detalle("PROC")),                  '10
    '                                      IIf(IsDBNull(Detalle("NUM_DIF")), "", Detalle("NUM_DIF")),            '11
    '                                      IIf(IsDBNull(Detalle("T_DOC_REF1")), "", Detalle("T_DOC_REF1")),      '12
    '                                      IIf(IsDBNull(Detalle("SER_DOC_REF1")), "", Detalle("SER_DOC_REF1")),  '13
    '                                      IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")),  '14
    '                                      IIf(IsDBNull(Detalle("DIF_HORA")), "", Detalle("DIF_HORA"))) '15
    '                Next
    '            Else
    '                FormMain.LblError.Text = gsError
    '                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
    '            End If
    '        End If
    '    End If

    'End Sub
End Class