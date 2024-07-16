Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormOrdenMantenimiento
    Private ELORDEN_MANTBL As New ELORDEN_MANTBL
    ' Private ELORDEN_DET_MANTBE As New ELORDEN_DET_MANTBE
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    '  Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    '  Private ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
    '  Private ARTICULOBL As New ARTICULOBL
    Private CCOSTOBL As New CCOSTOBL
    Private anho As String
    Private sArticulo As String

    Private Sub GetData(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim Dtcabezera, Dtdetalle As DataTable
        Dim Registro As DataRow
        Dim dt As DataTable
        Dtcabezera = ELORDEN_MANTBL.SelectRow(sTdoc, sSDoc, sNDoc)
        For Each Registro In Dtcabezera.Rows
            txtdocumento.Text = Registro("SER_DOC_REF") & " - " & Registro("NRO_DOC_REF")
            Label11.Text = Registro("NRO_DOC_REF")
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
        Next
        Dtdetalle = ELORDEN_MANTBL.SelectRowDetalle(sTdoc, sSDoc, sNDoc)
        For Each Detalle In Dtdetalle.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(Detalle("SEQ")), "", Detalle("SEQ")),                     '0  
                               IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")),  '1
                               IIf(IsDBNull(Detalle("FEC_GENE")), "", Detalle("FEC_GENE")),          '2
                               IIf(IsDBNull(Detalle("PRIORIDAD")), "", Detalle("PRIORIDAD")),        '3
                               IIf(IsDBNull(Detalle("ASUNTO")), "", Detalle("ASUNTO")),              '4
                               IIf(IsDBNull(Detalle("ART_COD")), "", Detalle("ART_COD")),            '5  
                               IIf(IsDBNull(Detalle("NOM_ART")), "", Detalle("NOM_ART")),            '6
                               IIf(IsDBNull(Detalle("DESCSOL")), "", Detalle("DESCSOL")),            '7
                               IIf(IsDBNull(Detalle("EST")), "", Detalle("EST")),                    '8
                               IIf(IsDBNull(Detalle("T_DOC_REF1")), "", Detalle("T_DOC_REF1")),      '9
                               IIf(IsDBNull(Detalle("SER_DOC_REF1")), "", Detalle("SER_DOC_REF1")),  '10
                               IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")))  '11
        Next
    End Sub

    Private Sub FormOrdenMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                txtdocumento.Text = anho & " - " & ELORDEN_MANTBL.SelectMaxTransp(anho).PadLeft(7, "0")
                btnsolm.Enabled = False
                Deshabilitar(True)
                txtcco_cod.Text = "113"
                txtcco_cod_LostFocus(sender, e)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                Deshabilitar(False)
                gsCode7 = txtlin_prod.Text
                btnsolm.Enabled = True
        End Select
    End Sub

    Sub Deshabilitar(ByVal F As Boolean)
        btnAgregar.Enabled = Not F

    End Sub

#Region "KeyDown"
    Private Sub txtlin_prod_LostFocus(sender As Object, e As EventArgs) Handles txtlin_prod.LostFocus
        If txtlin_prod.Text = "" Then
            lbllin_prod.Text = ""
            btnAgregar.Enabled = False
        Else
            Dim dt As DataTable
            'dt = ELORDEN_PROGRAMBL.SelectLineaProduSelect(txtlin_prod.Text, gsCode7)
            dt = ELORDEN_MANTBL.SelectLineaMantSelect(txtlin_prod.Text, txtcco_cod.Text)
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
                btnAgregar.Enabled = True
                txtcco_cod.Text = gLinea
                txtnom_cco.Text = gSubLinea
            End If
            e.Handled = True
        End If
        txtlin_prod.Text = ""
        lbllin_prod.Text = ""
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
    Private Sub txtcco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcco_cod.LostFocus
        If txtcco_cod.TextLength > 2 Then
            txtnom_cco.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
            'btnAgregar.Enabled = True
        Else
            txtnom_cco.Text = ""
            'btnAgregar.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "101" ' "245"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            btnAgregar.Enabled = True
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
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        '       If dgvt_doc.Rows.Count = 0 Then
        '           MsgBox("No hay items para Sumar")
        '       Else
        '           Dim fechafin As Date = dtpfec_inicio.Value
        '           Dim fechafindos As Date = dtpfec_inicio.Value
        '           Dim minutos As Double = 0
        '           dgvt_doc.Rows(0).Cells("Fecha_ini").Value = fechafin
        '           dgvt_doc.Rows(0).Cells("Fecha_Fin").Value = fechafindos.AddMinutes((dgvt_doc.Rows(0).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(0).Cells("Duracion").Value)
        '           'minutos = (dgvt_doc.Rows(0).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(0).Cells("Duracion").Value
        '           If dgvt_doc.Rows.Count > 1 Then
        '               For i = 1 To dgvt_doc.Rows.Count - 1
        '                   minutos = minutos + (dgvt_doc.Rows(i).Cells("PENDIENTE").Value * 60) / dgvt_doc.Rows(i).Cells("Duracion").Value
        '                   'minutos = minutos + dgvt_doc.Rows(i).Cells("Duracion").Value
        '                   fechafindos = fechafin.AddMinutes(minutos)
        '                   dgvt_doc.Rows(i).Cells("Fecha_ini").Value = fechafindos
        '                   dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = fechafindos.AddMinutes(minutos)
        '               Next
        '           End If
        '
        '       End If
    End Sub

#Region "Boton"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        gsCode7 = txtlin_prod.Text
        Dim frm As New FormDocuRefMant
        frm.ShowDialog()
        'Dim minutos As Double = 0
        '
        'For i = 0 To dgvt_doc.Rows.Count - 1
        '    'MsgBox(dgvt_doc.Rows(i).Cells("DURACION").Value)
        '    minutos = minutos + (dgvt_doc.Rows(i).Cells("CANTIDAD").Value * 60) / dgvt_doc.Rows(i).Cells("DURACION").Value 'CInt(lvbusqueda1.Items(i).SubItems(11).Text) * 60 / CInt(lvbusqueda1.Items(i).SubItems(13).Text)
        '    dgvt_doc.Rows(i).Cells("NUM_DIF").Value = minutos
        'Next
        'dtpfec_fin.Value = dtpfec_inicio.Value.AddMinutes(minutos)
        'gsCode7 = ""
    End Sub

    Private Sub FormOrdenMantenimiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
            Case "Print"
                ReDim gsRptArgs(1)
                gsRptArgs(0) = RTrim(txtdocumento.Text.Substring(0, 4))
                gsRptArgs(1) = RTrim(txtdocumento.Text.Substring(7, 7))
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTORDEN_MANT_SELROW.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
                'Case "anular"
                '
                '    If MessageBox.Show("Desea anular el documento",
                '       "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                '       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                '        Exit Sub
                '    End If
                '
                '
                '
                '
                '    Dim ELORDEN_MANTBE As New ELORDEN_MANTBE
                '    Dim ELMVLOGSBE As New ELMVLOGSBE
                '    Dim ELORDEN_DET_MANTBE As New ELORDEN_DET_MANTBE
                '
                '    ELORDEN_MANTBE.t_doc_ref = sTDoc
                '    ELORDEN_MANTBE.ser_doc_ref = sSDoc
                '    ELORDEN_MANTBE.nro_doc_ref = sNDoc
                '
                '
                '    'Dim ELMVLOGSBE As New ELMVLOGSBE
                '    'ELMVLOGSBE.log_codusu = gsCodUsr
                '    gsError = ELORDEN_MANTBL.SaveRow(ELORDEN_MANTBE, ELMVLOGSBE, "A", dgvt_doc, ELORDEN_DET_MANTBE)
                '    If gsError = "OK" Then
                '        MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                '
                '        tsbGrabar.Enabled = False
                '        tsbimprimir.Enabled = False
                '
                '        Dispose()
                '    Else
                '        FormMain.LblError.Text = gsError
                '        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                '    End If
        End Select
    End Sub
#End Region
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELORDEN_MANTBE As New ELORDEN_MANTBE
                Dim ELORDEN_DET_MANTBE As New ELORDEN_DET_MANTBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELORDEN_MANTBE.t_doc_ref = "PMANT"
                If flagAccion = "N" Then
                    ELORDEN_MANTBE.nro_doc_ref = ELORDEN_MANTBL.SelectMaxTransp(DateTime.Now.Year).PadLeft(7, "0")
                    ELORDEN_MANTBE.ser_doc_ref = dtpfec_inicio.Value.Year
                Else
                    ELORDEN_MANTBE.ser_doc_ref = txtdocumento.Text.Substring(0, 4)
                    ELORDEN_MANTBE.nro_doc_ref = txtdocumento.Text.Substring(7, 7)
                End If

                ELORDEN_MANTBE.cco_cod = txtcco_cod.Text
                ELORDEN_MANTBE.cod_area = txtlin_prod.Text
                ELORDEN_MANTBE.cod_grupo = txtgrupo_tra.Text
                ELORDEN_MANTBE.turno = cmbturno.SelectedIndex
                ELORDEN_MANTBE.fec_gene = DateTime.Now.ToShortDateString
                ELORDEN_MANTBE.fec_fin = dtpfec_fin.Value
                ELORDEN_MANTBE.fec_ini = dtpfec_inicio.Value
                ELORDEN_MANTBE.estado = cmbestado.SelectedIndex
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELORDEN_MANTBL.SaveRow(ELORDEN_MANTBE, ELMVLOGSBE, flagAccion, dgvt_doc, ELORDEN_DET_MANTBE)
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

        ' Dim d As Double = 0
        ' Dim f As Integer = 0
        ' anho = dtpfec_inicio.Value.Year
        If flagAccion = "N" Then
            txtdocumento.Text = anho & " - " & ELORDEN_MANTBL.SelectMaxTransp(anho).PadLeft(7, "0")
        End If

        'dtpfec_fin.Value = dtpfec_inicio.Value
        'For i = 0 To dgvt_doc.Rows.Count - 1
        '    f = f + 1
        '    d = dgvt_doc.Rows(i).Cells("Cantidad").Value * 60 / dgvt_doc.Rows(i).Cells("Duracion").Value
        '    If f > 1 Then
        '        dgvt_doc.Rows(i).Cells("Fecha_ini").Value = dtpfec_fin.Value
        '    End If
        '    dtpfec_fin.Value = dtpfec_fin.Value.AddMinutes(d)
        '    dgvt_doc.Rows(i).Cells("Fecha_Fin").Value = dtpfec_fin.Value
        '    dgvt_doc.Rows(i).Cells("NUM_DIF").Value = d
        '    If f = dgvt_doc.Rows.Count - 1 Then
        '        dgvt_doc.Rows(i + 1).Cells("Fecha_ini").Value = dtpfec_fin.Value
        '    End If
        'Next
        'dgvt_doc.Rows(0).Cells("Fecha_ini").Value = dtpfec_inicio.Value
        Return True
    End Function

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click

        Dim ELORDEN_MANTBE As New ELORDEN_MANTBE

        Dim ELTBMANTENIMIENTOBE As New ELTBMANTENIMIENTOBE

        Dim ELMVLOGSBE As New ELMVLOGSBE
        If dgvt_doc.Rows.Count > 0 Then
            If flagAccion = "M" Then
                If MessageBox.Show("Desea Eliminar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                ELORDEN_MANTBE.t_doc_ref = "PMANT"
                ELORDEN_MANTBE.ser_doc_ref = txtdocumento.Text.Substring(0, 4)
                ELORDEN_MANTBE.nro_doc_ref = txtdocumento.Text.Substring(7, 7)

                ELTBMANTENIMIENTOBE.T_DOC_REF = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
                ELTBMANTENIMIENTOBE.SER_DOC_REF = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                ELTBMANTENIMIENTOBE.NRO_DOC_REF = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                ELTBMANTENIMIENTOBE.ART_COD = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
                ELTBMANTENIMIENTOBE.EST = "0"
                gsError = ELORDEN_MANTBL.SaveRow1(ELTBMANTENIMIENTOBE, ELORDEN_MANTBE, ELMVLOGSBE, "M")
            End If
            dgvt_doc.Rows.Remove(dgvt_doc.CurrentRow)
            dgvt_doc.Refresh()

            If dgvt_doc.Rows.Count = 0 Then
                dtpfec_fin.Value = dtpfec_inicio.Value
            End If
        Else
            MsgBox("No hay Registros que quitar", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub txtgrupo_tra_LostFocus(sender As Object, e As EventArgs) Handles txtgrupo_tra.LostFocus
        If txtgrupo_tra.Text = "" Then
            txtnomgrup.Text = ""
        End If
    End Sub

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle
    Private Sub dgvt_doc_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles dgvt_doc.DragDrop
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

    Private Sub dgvt_doc_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles dgvt_doc.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvt_doc_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvt_doc.MouseDown

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

    Private Sub dgvt_doc_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvt_doc.MouseMove

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
    AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                dgvt_doc.DoDragDrop(dgvt_doc.Rows(fromIndex),
                               DragDropEffects.Move)
            End If
        End If

    End Sub

End Class