Imports System.ComponentModel
Imports vb = Microsoft.VisualBasic
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.IO

Public Class FormPerHoraOM
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBMANTENIMIENTOBL As New ELTBMANTENIMIENTOBL
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private REPORTE_TRABAJOBL As New REPORTE_TRABAJOBL
    Private gdtMainData As DataTable
    Private dt1 As New DataTable
    Private Rn As DataRow = dt1.NewRow()

#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormPerHoraOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = Nothing
        If sBusAlm = "5" Then
            dt = ELTBMANTENIMIENTOBL.gArea(gsCode10)
        Else
            dt = GUIAALMACENBL.SelectCCosto
        End If
        GetCmb("cod", "nom", dt, cmbcosto)
        cmbccosto.Items.Clear()
        cmbccosto.Items.Add("")
        For i = 0 To cmbcosto.Items.Count - 1
            cmbcosto.SelectedIndex = i
            cmbccosto.Items.Add(cmbcosto.Text)
        Next
        'Dim dt As DataTable
        If sBusAlm = "2" Then
            dt = ELTBGRUPOBL.listcco_cod(Trim(gsCode10))
        ElseIf sBusAlm = "3" Then
            DetalleTecnico()
            Button1.Text = "Pasar"
            If chkcerrado.Checked = True Then
                dt = REPORTE_TRABAJOBL.listcco_cod_c(Trim(gsCode10))
            Else
                dt = REPORTE_TRABAJOBL.listcco_cod(Trim(gsCode10))
            End If
        ElseIf sBusAlm = "4" Then
            dt = ELTBGRUPOBL.listcco_cod(Trim(gsCode10))
        ElseIf sBusAlm = "5" Then
            directorio(FormELTBMANTENIMIENTO.cmbareades.SelectedValue)
            dt = dt1
        End If
        gdtMainData = dt
        dgvbusqueda.DataSource = dt
        dgvbusqueda.Refresh()
        tsbCamposSeek.Items.Clear()
        'get columns of DGV
        For Each col As DataGridViewColumn In dgvbusqueda.Columns
            ' MessageBox.Show(col.Name)
            tsbCamposSeek.Items.Add(col.Name)
        Next
        Cursor.Current = Cursors.Default
        If dgvbusqueda.Rows.Count > 0 Then
            tsbCamposSeek.SelectedIndex = 1
        End If
        If sBusAlm = "5" Then
            cmbcosto.SelectedValue = FormELTBMANTENIMIENTO.cmbareades.SelectedValue
        Else
            cmbcosto.SelectedValue = gsCode10
        End If

        cmbccosto.Text = cmbcosto.Text
        Me.ActiveControl = tsTextSearch.Control
    End Sub

    Private Sub cmbccosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccosto.SelectedIndexChanged
        Dim dt As DataTable
        dgvbusqueda.DataSource = Nothing
        If sBusAlm = "2" Then
            If cmbccosto.SelectedIndex <> 0 Then
                dt = ELTBGRUPOBL.listcco_cod(Trim(Mid(cmbccosto.Text, 1, 3)))
                dgvbusqueda.DataSource = dt
                dgvbusqueda.Refresh()
                gdtMainData = dt
                tsbCamposSeek.Items.Clear()
                'get columns of DGV
                For Each col As DataGridViewColumn In dgvbusqueda.Columns
                    ' MessageBox.Show(col.Name)
                    tsbCamposSeek.Items.Add(col.Name)
                Next
                Cursor.Current = Cursors.Default
                'limpiar busqueda
                'lblRecNo.Text = dgvbusqueda.Rows.Count
                'dgv color
                dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.EnableHeadersVisualStyles = False
            Else
                tsbCamposSeek.Items.Clear()
            End If
        ElseIf sBusAlm = "3" Then
            If cmbccosto.SelectedIndex <> 0 Then
                If chkcerrado.Checked = True Then
                    dt = REPORTE_TRABAJOBL.listcco_cod_c(Trim(Mid(cmbccosto.Text, 1, 3)))
                Else
                    dt = REPORTE_TRABAJOBL.listcco_cod(Trim(Mid(cmbccosto.Text, 1, 3)))
                End If
                dgvbusqueda.DataSource = dt
                dgvbusqueda.Refresh()
                gdtMainData = dt
                tsbCamposSeek.Items.Clear()
                'get columns of DGV
                For Each col As DataGridViewColumn In dgvbusqueda.Columns
                    ' MessageBox.Show(col.Name)
                    tsbCamposSeek.Items.Add(col.Name)
                Next
                Cursor.Current = Cursors.Default
                'limpiar busqueda
                'lblRecNo.Text = dgvbusqueda.Rows.Count
                'dgv color
                dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.EnableHeadersVisualStyles = False

                If dgvbusqueda.Rows.Count > 0 Then
                    If dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("TIPO").Value = "MANTENIMIENTO" Then
                        Intervencion.Visible = True
                        cmbIntervencion.Visible = True
                    Else
                        Intervencion.Visible = False
                        cmbIntervencion.Visible = False
                    End If
                End If
            Else
                tsbCamposSeek.Items.Clear()
            End If
        ElseIf sBusAlm = "4" Then
            If cmbccosto.SelectedIndex <> 0 Then
                dt = ELTBGRUPOBL.listcco_cod(Trim(Mid(cmbccosto.Text, 1, 3)))
                dgvbusqueda.DataSource = dt
                dgvbusqueda.Refresh()
                gdtMainData = dt
                tsbCamposSeek.Items.Clear()
                'get columns of DGV
                For Each col As DataGridViewColumn In dgvbusqueda.Columns
                    ' MessageBox.Show(col.Name)
                    tsbCamposSeek.Items.Add(col.Name)
                Next
                Cursor.Current = Cursors.Default
                'limpiar busqueda
                'lblRecNo.Text = dgvbusqueda.Rows.Count
                'dgv color
                dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.EnableHeadersVisualStyles = False
            Else
                tsbCamposSeek.Items.Clear()
            End If
        ElseIf sBusAlm = "5" Then
            If cmbccosto.SelectedIndex <> 0 Then
                directorio(Trim(Mid(cmbccosto.Text, 1, 4)))
                dt = dt1
                dgvbusqueda.DataSource = dt
                dgvbusqueda.Refresh()
                gdtMainData = dt
                tsbCamposSeek.Items.Clear()
                'get columns of DGV
                For Each col As DataGridViewColumn In dgvbusqueda.Columns
                    ' MessageBox.Show(col.Name)
                    tsbCamposSeek.Items.Add(col.Name)
                Next
                Cursor.Current = Cursors.Default
                'limpiar busqueda
                'lblRecNo.Text = dgvbusqueda.Rows.Count
                'dgv color
                dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
                dgvbusqueda.EnableHeadersVisualStyles = False
            Else
                tsbCamposSeek.Items.Clear()
            End If
        End If
    End Sub
    Private Sub tsTextSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tsTextSearch.KeyDown

        If e.KeyValue = Keys.Down Then
            dgvbusqueda.Select()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub
    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        Dim valor As Boolean
        If sBusAlm = "2" Then
            If FormELTBSTIEMOM.dgvtiemper.Rows.Count > 0 Then
                For i = 0 To FormELTBSTIEMOM.dgvtiemper.Rows.Count - 1
                    If FormELTBSTIEMOM.dgvtiemper.Rows(i).Cells("Codigo").Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormELTBSTIEMOM.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value),
                                                IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value),
                                                IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value))
        ElseIf sBusAlm = "3" Then
            '
            ' Nothing
            '
        ElseIf sBusAlm = "4" Then
            If FormELTBMANTENIMIENTO.dtgvtecnico.Rows.Count > 0 Then
                For i = 0 To FormELTBMANTENIMIENTO.dtgvtecnico.Rows.Count - 1
                    If FormELTBMANTENIMIENTO.dtgvtecnico.Rows(i).Cells("PER_COD").Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormELTBMANTENIMIENTO.dtgvtecnico.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value),
                                                IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "H")
        ElseIf sBusAlm = "5" Then
            If FormELTBMANTENIMIENTO.dtgvplano.Rows.Count > 0 Then
                For i = 0 To FormELTBMANTENIMIENTO.dtgvplano.Rows.Count - 1
                    If FormELTBMANTENIMIENTO.dtgvplano.Rows(i).Cells("cod_pla").Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Este Plano ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormELTBMANTENIMIENTO.dtgvplano.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value),
                                                     IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value),
                                                     IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value),
                                                     Trim(Mid(cmbccosto.Text, 1, 4)))
        End If
    End Sub
    Private Sub dgvbusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvbusqueda.KeyDown

        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val As String = ""
        Dim valor As Boolean
        If sBusAlm = "2" Then
            If FormELTBSTIEMOM.dgvtiemper.Rows.Count > 0 Then
                For j = 0 To dgvbusqueda.Rows.Count - 1
                    For i = 0 To FormELTBSTIEMOM.dgvtiemper.Rows.Count - 1
                        If FormELTBSTIEMOM.dgvtiemper.Rows(i).Cells(0).Value = dgvbusqueda.Rows(j).Cells(0).Value Then
                            val = "1"
                        End If
                    Next
                    If val <> "1" Then
                        FormELTBSTIEMOM.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(0).Value), "", dgvbusqueda.Rows(j).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(1).Value), "", dgvbusqueda.Rows(j).Cells(1).Value), IIf(IsDBNull(dgvbusqueda.Rows(j).Cells(2).Value), "", dgvbusqueda.Rows(j).Cells(2).Value))
                    Else
                        val = ""
                    End If
                Next
            Else
                For i = 0 To dgvbusqueda.Rows.Count - 1
                    FormELTBSTIEMOM.dgvtiemper.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(0).Value), "", dgvbusqueda.Rows(i).Cells(0).Value), IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(1).Value), "", dgvbusqueda.Rows(i).Cells(1).Value), IIf(IsDBNull(dgvbusqueda.Rows(i).Cells(2).Value), "", dgvbusqueda.Rows(i).Cells(2).Value))
                Next
            End If
        ElseIf sBusAlm = "3" Then
            If OkData() = False Then
                Exit Sub
            End If
#Region "Fecha"
            Dim a As String = ""
            Dim HO As Integer = 0
            Dim MI As Integer = 0
            Dim SE As Integer = 0

            Dim date1, date2 As DateTime
            date1 = FormReporte_Trabajo.dtpfec_gene.Value.ToShortDateString
            date2 = dtpfec_termino.Value.ToShortDateString
            date1 = date1.AddHours(dtphoragene.Value.Hour)
            date1 = date1.AddMinutes(dtphoragene.Value.Minute)
            date1 = date1.AddSeconds(dtphoragene.Value.Second)

            date2 = date2.AddHours(dtphoratermino.Value.Hour)
            date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
            date2 = date2.AddSeconds(dtphoratermino.Value.Second)

            If DateTime.Compare(date1, date2) >= 0 Then
                MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
                dtphoragene.Focus()
                Exit Sub
            Else
                If dgvbusqueda.Rows.Count > 0 Then
                    'For i = dgvdiaper.CurrentRow.Index To dgvdiaper.Rows.Count - 1
                    '    a = IIf(IsDBNull(dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Hora_Inicio").Value), "", dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Hora_Inicio").Value)
                    '        If a = "" Then
                    HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
                    MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                    SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
                    MI = MI Mod 60
                    SE = SE Mod 60
                    ''   If HO > "18" Then
                    ''       'MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                    ''       'dtpfec_termino.Focus()
                    ''       Exit Sub
                    ''   End If
                    '                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Hora_Inicio").Value = dtphoragene.Text
                    '                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Hora_Final").Value = dtphoratermino.Text
                    '                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FEC_INICIO").Value = Mid(dtphoragene.Value, 1, 10)
                    '                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FEC_TERMINO").Value = Mid(dtphoratermino.Value, 1, 10)
                    '                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Num_Hora").Value = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
                    '           'dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Dif_Hora").Value = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                    '                dgvdiaper.Refresh()
                    '        End If
                    ' Next
                Else
                    MsgBox("No hay campos en el grid para agregar")
                    Exit Sub
                End If
            End If
#End Region
            If FormReporte_Trabajo.dgvdiaper.Rows.Count > 0 Then
                For i = 0 To FormReporte_Trabajo.dgvdiaper.Rows.Count - 1
                    If FormReporte_Trabajo.dgvdiaper.Rows(i).Cells("NRO_DOC_REF").Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Esta Orden de Mantenimiento ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            Dim dtOM As DataTable
            Dim Registro As DataRow
            Dim ser As String

            ser = FormMain.cmbaño.Text
            dtOM = REPORTE_TRABAJOBL.SelectRowOM(ser, dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            For Each Registro In dtOM.Rows
                FormReporte_Trabajo.dgvdiaper.Rows.Add("", IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF")),                                      '0-1
                                                           IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF")),                                  '2
                                                           IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF")),                                  '3
                                                           IIf(IsDBNull(Registro("CCO_CODORI")), "", Registro("CCO_CODORI")),                                    '4
                                                           IIf(IsDBNull(Registro("NOM_CCO")), "", Registro("NOM_CCO")),                                          '5
                                                           IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")),                                          '6
                                                           IIf(IsDBNull(Registro("NOM_ART")), "", Registro("NOM_ART")),                                          '7
                                                           txtobs.Text,                                                                                          '8
                                                           dtphoragene.Text,                                                                                     '9
                                                           dtphoratermino.Text,                                                                                  '10
                                                           (HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")),'11
                                                           Mid(dtphoragene.Value, 1, 10),                                                                        '12
                                                           Mid(dtphoratermino.Value, 1, 10),                                                                     '13
                                                           IIf(IsDBNull(Registro("COD_TIP")), "", Registro("COD_TIP")),                                          '14
                                                           IIf(IsDBNull(Registro("TIP_NOM")), "", Registro("TIP_NOM")),                                          '15
                                                           IIf(IsDBNull(Registro("COD_EST")), "", Registro("COD_EST")),                                          '16
                                                           cmbIntervencion.SelectedIndex)                                                                        '17
            Next
            Dispose()
        ElseIf sBusAlm = "4" Then
            If FormReporte_Trabajo.dgvdiaper.Rows.Count > 0 Then
                For i = 0 To FormReporte_Trabajo.dgvdiaper.Rows.Count - 1
                    If FormReporte_Trabajo.dgvdiaper.Rows(i).Cells("NRO_DOC_REF").Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Esta Orden de Mantenimiento ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            Dim dtOM As DataTable
            Dim Registro As DataRow
            Dim ser As String

            ser = FormMain.cmbaño.Text
            dtOM = REPORTE_TRABAJOBL.SelectRowOM(ser, dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            For Each Registro In dtOM.Rows
                FormReporte_Trabajo.dgvdiaper.Rows.Add("", IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF")),
                                                           IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF")),
                                                           IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF")),
                                                           IIf(IsDBNull(Registro("CCO_CODORI")), "", Registro("CCO_CODORI")),
                                                           IIf(IsDBNull(Registro("NOM_CCO")), "", Registro("NOM_CCO")),
                                                           IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD")),
                                                           IIf(IsDBNull(Registro("NOM_ART")), "", Registro("NOM_ART")))
            Next
        ElseIf sBusAlm = "5" Then
            If FormELTBMANTENIMIENTO.dtgvplano.Rows.Count > 0 Then
                For i = 0 To FormELTBMANTENIMIENTO.dtgvplano.Rows.Count - 1
                    If FormELTBMANTENIMIENTO.dtgvplano.Rows(i).Cells("cod_pla").Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        valor = True
                        MsgBox("Este Plano ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If

            FormELTBMANTENIMIENTO.dtgvplano.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value),
                                                     IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value),
                                                     IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value),
                                                     Trim(Mid(cmbccosto.Text, 1, 4)))
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged
        If tsbCamposSeek.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = tsTextSearch.Text
        If sCode.Trim = "" Then
            dgvbusqueda.DataSource = gdtMainData
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor

        Dim dtNew As DataTable
        dtNew = gdtMainData.Clone()
        Dim sCampo As String = tsbCamposSeek.Text
        Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '%" & sCode & "%'")

        For Each ldrRow As DataRow In dataRows
            dtNew.ImportRow(ldrRow)
        Next
        dgvbusqueda.DataSource = dtNew

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub chkcerrado_CheckedChanged(sender As Object, e As EventArgs) Handles chkcerrado.CheckedChanged
        'cmbccosto_SelectedIndexChanged(sender, e)
        FormPerHoraOM_Load(sender, e)
    End Sub
    Private Sub DetalleTecnico()
        dtpfec_inicio.Value = FormReporte_Trabajo.dtpfec_gene.Value

        dtphoragene.Format = DateTimePickerFormat.Custom
        dtphoragene.CustomFormat = "HH:mm:ss tt"
        dtphoragene.Text = "12:00:00 a.m."
        dtphoratermino.Format = DateTimePickerFormat.Custom
        dtphoratermino.CustomFormat = "HH:mm:ss tt"
        dtphoratermino.Text = "12:00:00 a.m."


        Dim VL As String = 100
        Width = 752
        Height = 342 + VL
        GroupBox2.Size = New Point(724, VL)
        GroupBox1.Location = New Point(6, 27 + VL)
        GroupBox2.Location = New Point(6, 27)
        Location = New Point(0, 0)
        GroupBox2.Visible = True

        CentrarFormulario()
        Button1.Text = "Pasar"

    End Sub

    Private Sub CentrarFormulario()
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle
        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Width + Parent.Left
            y = r.Height - Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Width
            y = r.Height - Height
        End If
        x = CInt(x / 2)
        y = CInt(y / 2)

        StartPosition = FormStartPosition.Manual
        Location = New Point(x, y)
    End Sub
#Region "Tecnicos OM"
    Private Sub dtpfec_termino_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_termino.LostFocus

        If FormReporte_Trabajo.dtpfec_gene.Value.Date <= dtpfec_termino.Value.Date Then
            dtphoratermino.Text = dtpfec_termino.Value
            If DateTime.Now.ToString("mm") = "01" Then
                FormReporte_Trabajo.cmbserie.Text = DateTime.Now.ToString("yyyy")
            End If
        Else
            MsgBox("La fecha de termino debe ser mayor a la fecha inicial")
            dtpfec_termino.Focus()
            dtpfec_termino.Value = FormReporte_Trabajo.dtpfec_gene.Value
        End If
    End Sub
    Private Sub dtphoratermino_LostFocus(sender As Object, e As EventArgs) Handles dtphoratermino.LostFocus
        Dim date1, date2 As DateTime
        date1 = FormReporte_Trabajo.dtpfec_gene.Value.ToShortDateString
        date2 = dtpfec_termino.Value.ToShortDateString
        date1 = date1.AddHours(dtphoragene.Value.Hour)
        date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        date1 = date1.AddSeconds(dtphoragene.Value.Second)

        date2 = date2.AddHours(dtphoratermino.Value.Hour)
        date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        date2 = date2.AddSeconds(dtphoratermino.Value.Second)

        If DateTime.Compare(date1, date2) >= 0 Then
            'txtobs.Text = DateTime.Compare(date1, date2)
            MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
            dtphoragene.Focus()
        Else
            txtdifhora.Text = Nothing
            Dim HO As Integer = 0
            Dim MI As Integer = 0
            Dim SE As Integer = 0

            HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
            MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
            SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
            MI = MI Mod 60
            SE = SE Mod 60
            If HO > "18" Then
                MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                dtpfec_termino.Focus()
                Exit Sub
            End If
            txtdifhora.Text = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
        End If
    End Sub

#End Region
    Private Function OkData() As Boolean
        Dim p As String = 0
        If sBusAlm = "3" Then
            If dgvbusqueda.RowCount = 0 Then
                MsgBox("No hay datos", MsgBoxStyle.Exclamation)
                dgvbusqueda.Focus()
                Return False
            End If
            If txtdifhora.Text = "" Then
                MsgBox("Ajuste la Horade inicio o fin", MsgBoxStyle.Exclamation)
                dtphoragene.Focus()
                Return False
            End If
            If txtobs.Text = "" Then
                MsgBox("Ingrese una descripcion", MsgBoxStyle.Exclamation)
                txtobs.Focus()
                Return False
            End If
            If cmbIntervencion.Visible = True Then
                If cmbIntervencion.SelectedIndex = -1 Then
                    MsgBox("Ingrese una Intervencion", MsgBoxStyle.Exclamation)
                    cmbIntervencion.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Sub dgvbusqueda_Click(sender As Object, e As EventArgs) Handles dgvbusqueda.Click

        If sBusAlm = "3" Then
            If dgvbusqueda.Rows.Count > 0 Then
                If dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("TIPO").Value = "MANTENIMIENTO" Then
                    Intervencion.Visible = True
                    cmbIntervencion.Visible = True
                Else
                    Intervencion.Visible = False
                    cmbIntervencion.Visible = False
                End If
            End If
        End If

    End Sub
    Private Sub directorio(ByVal dato As String)
        dt1.Columns.Clear()
        dt1.Rows.Clear()
        Dim n As String
        Dim ruta As String
        ruta = gsIpserver & "Planos\" & dato & "\"
        Dim newCurrentDirectory As DirectoryInfo = New DirectoryInfo(ruta)
        Dim directoryArray As DirectoryInfo() = newCurrentDirectory.GetDirectories()
        Dim fileArray As FileInfo() = newCurrentDirectory.GetFiles()
        Dim file As FileInfo

        dt1.Columns.Add("COD")
        dt1.Columns.Add("NOM")
        dt1.Columns.Add("FORMATO")

        For Each file In fileArray
            If (Mid(file.Name, 9, 1) = "-") Then
                If (Mid(file.Name, 10, 2) > 9) Then
                    n = Len(file.Name) - 18
                    dt1.Rows.Add(vb.Left(file.Name, 11),
                    Mid(file.Name, 15, n),
                    vb.Right(file.Name, 4))
                Else
                    n = Len(file.Name) - 17
                    dt1.Rows.Add(vb.Left(file.Name, 10),
                    Mid(file.Name, 14, n),
                    vb.Right(file.Name, 4))
                End If
            Else
                n = Len(file.Name) - 15
                dt1.Rows.Add(vb.Left(file.Name, 8),
                   Mid(file.Name, 12, n),
                    vb.Right(file.Name, 4))
            End If
        Next
        'dtgelement.DataSource = dt1
        Button1.Text = "Pasar"
    End Sub


End Class