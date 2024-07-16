Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormRegistroVacunas

    Dim VACUNABL As New VACUNABL
    Dim VACUNABE As New VACUNABE
    Private Sub FormRegistroVacunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro de Vacunación"
        Dim dtVacuna As New DataTable
        cmb_laboratorio.SelectedIndex = -1

        If gnOpcion = 1 Then
            dtVacuna = VACUNABL.ListadoVacuna(sTDoc)
            txt_codigo.Text = sTDoc
            txt_empleado.Text = sSDoc
            dgvListadoVac.DataSource = dtVacuna
            dgvListadoVac.Refresh()
            Dim filas = dgvListadoVac.Rows.Count
            cmb_dosis.SelectedIndex = filas
        End If

        If dgvListadoVac.Rows.Count > 0 Then
            For i = 0 To dgvListadoVac.Columns.Count - 1
                dgvListadoVac.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End If

    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "3711"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_codigo.Text = gLinea
                txt_empleado.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If

            Dim dtVacuna As New DataTable
            dtVacuna = VACUNABL.ListadoVacuna(txt_codigo.Text)
            dgvListadoVac.DataSource = dtVacuna
            dgvListadoVac.Refresh()
            Dim filas = dgvListadoVac.Rows.Count
            cmb_dosis.SelectedIndex = filas
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked

        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    SaveData()
                    Exit Sub
                Case "edit"
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    ImprimirReporte()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveData()
        VACUNABE.PER_COD = txt_codigo.Text
        VACUNABE.EMPLEADO = txt_empleado.Text
        VACUNABE.DOSIS = cmb_dosis.Text
        VACUNABE.LABORATORIO = cmb_laboratorio.Text
        VACUNABE.LUGAR = txt_lugar.Text
        VACUNABE.FEC_VACUNA = datFecVac.Value.ToString("dd/MM/yyyy")

        flagAccion = "N"
        gsError = VACUNABL.grabarDatos(VACUNABE, flagAccion)

        If gsError = "OK" Then
            'txt_codigo.Text = ""
            'txt_empleado.Text = ""
            'cmb_dosis.SelectedIndex = -1
            'cmb_laboratorio.SelectedIndex = -1
            'txt_lugar.Text = ""
            dgvListadoVac.DataSource = ""
            MsgBox("Datos Grabados Correc tamente")
            Dim dtVacuna As New DataTable
            dtVacuna = VACUNABL.ListadoVacuna( VACUNABE.PER_COD )
            dgvListadoVac.DataSource = dtVacuna
            dgvListadoVac.Refresh()
            Dim filas = dgvListadoVac.Rows.Count
            cmb_dosis.SelectedIndex = filas
            Select Case filas
                Case 1
                    datFecVac.Value = Today
                Case 2
                    datFecVac.Value = datFecVac.Value.AddDays(21)
                Case 3
                    datFecVac.Value = datFecVac.Value.AddMonths(3)
                Case Else
                    datFecVac.Value = datFecVac.Value.AddMonths(5)
            End Select
            'Dispose()
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FormRegistroVacunas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvListadoVac.Rows.Count > 0 Then
            Dim fila = dgvListadoVac.CurrentRow.Index
            If fila >= 0 Then
                Dim resp = MsgBox("Desea Eliminar el registro Seleccionado?", vbYesNo)
                If resp = 6 Then
                    flagAccion = "M"
                    VACUNABE.PER_COD = txt_codigo.Text
                    VACUNABE.DOSIS = dgvListadoVac.CurrentRow.Cells("DOSIS").Value
                    gsError = VACUNABL.grabarDatos(VACUNABE, flagAccion)
                    If gsError = "OK" Then
                        dgvListadoVac.Rows.Remove(dgvListadoVac.CurrentRow)
                        MsgBox("Registro Eliminado Correctamente")
                    End If
                End If
            Else
                MsgBox("Seleccione Fila Para Borrar")
            End If
        Else
            MsgBox("No hay registros para Eliminar")
        End If
        If dgvListadoVac.Rows.Count > 0 Then
            For i = 0 To dgvListadoVac.Columns.Count - 1
                dgvListadoVac.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Dim filas = dgvListadoVac.Rows.Count
            cmb_dosis.SelectedIndex = filas
        End If
    End Sub

    Private Sub ImprimirReporte()
        Dim dosis = cmb_dosis.SelectedIndex + 1
        Dim dias = 0
        Select Case dosis
            Case 1
                dias = 21
            Case 2
                dias = 90
            Case Else
                dias = 90
        End Select
        ReDim gsRptArgs(1)
        gsRptArgs(0) = dosis
        gsRptArgs(1) = dias
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_CRONOGRAMA_VACUNAS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub
End Class