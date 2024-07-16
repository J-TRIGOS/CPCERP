Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELSUBSIDIOS

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    ' Private ELTBALMACENBL As New ELTBALMACENBL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private ELPERMISOSBL As New ELPERMISOSBL
    Private Sub DeleteData()

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        flagAccion = "E"
        Dim ELTBALMACENBE As New ELTBALMACENBE
        ELTBALMACENBE.alm_codigo = Trim(txtndoc.Text)

        Dim dTable As New DataTable
        Dim ELPERMISOSBE As New ELPERMISOSBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELPERMISOSBE.ndoc = txtndoc.Text
        ELPERMISOSBE.sdoc = txtsdoc.Text
        gsError = ELPERMISOSBL.SaveRowS(ELPERMISOSBE, ELMVLOGSBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormELSUBSIDIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Dim año As String = DateTime.Now.ToString("yyyy")
                txtsdoc.Text = DateTime.Now.ToString("yyyy")
                txtndoc.Text = ELPERMISOSBL.SelectNro(año)
                dtpfec_ini.Value = DateTime.Now.ToString("dd/MM/yyyy")
                dtpfec_fin.Value = DateTime.Now.ToString("dd/MM/yyyy")
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                Deshabilitar(False)
                GetData(sTDoc, sSDoc)
                txtsdoc.Text = sTDoc
                txtndoc.Text = sSDoc
        End Select

        Dim mes As String = dtpfec_ini.Value.Month
        Dim anho As String = dtpfec_ini.Value.Year
        If Len(mes) = 1 Then
            mes = "0" + mes
        End If
        Dim periodo = anho + mes
        Dim dtPeriodos As DataTable

        dtPeriodos = ELBCALCULOSUBSIDIO.CalculoPeriodos(periodo)
        Dim row As DataRow = dtPeriodos.Rows(dtPeriodos.Rows.Count - 1)
        DgvPagos.Columns.Add("NOM", "NOM")
        DgvPagos.Columns.Add("MES1", CStr(row("MES1")))
        DgvPagos.Columns.Add("MES2", CStr(row("MES2")))
        DgvPagos.Columns.Add("MES3", CStr(row("MES3")))
        DgvPagos.Columns.Add("MES4", CStr(row("MES4")))
        DgvPagos.Columns.Add("MES5", CStr(row("MES5")))
        DgvPagos.Columns.Add("MES6", CStr(row("MES6")))
        DgvPagos.Columns.Add("MES7", CStr(row("MES7")))
        DgvPagos.Columns.Add("MES8", CStr(row("MES8")))
        DgvPagos.Columns.Add("MES9", CStr(row("MES9")))
        DgvPagos.Columns.Add("MES10", CStr(row("MES10")))
        DgvPagos.Columns.Add("MES11", CStr(row("MES11")))
        DgvPagos.Columns.Add("MES12", CStr(row("MES12")))
        'DgvPagos.Columns.Add("TOTAL", "TOTAL")
        'DgvPagos.Columns.Add("DIAS", "DIAS")
        DgvPagos.Visible = False
    End Sub

    Sub Deshabilitar(ByVal F As Boolean)
        'txtper_cod.Enabled = F
        'txtprdo_cod.Enabled = F
        'chkactivar2.Checked = Not F
        'GroupBox2.Enabled = Not F
        'chkactivar.Checked = Not F
        'GroupBox1.Enabled = Not F
    End Sub
    Private Sub Limpiar()
        cmb_motivo.SelectedItem = DateTime.Now.ToString("yyyy")
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
                If DateTime.Now.ToString("yyyyMM") = dtpfec_ini.Value.ToString("yyyyMM") Then
                    DeleteData()
                Else
                    MsgBox("Esta fuera de mes")
                End If

            Case "exit"
                Dispose()
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
                Dim ELPERMISOSBE As New ELPERMISOSBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELPERMISOSBE.sdoc = txtsdoc.Text
                ELPERMISOSBE.ndoc = txtndoc.Text
                ELPERMISOSBE.per_cod = txtper_cod.Text
                'ELPERMISOSBE.dias = txtdias.text
                ELPERMISOSBE.fec_ini = dtpfec_ini.Value.ToShortDateString
                ELPERMISOSBE.fec_fin = dtpfec_fin.Value.ToShortDateString
                ELPERMISOSBE.observacion = txtdescripcion.Text
                ELPERMISOSBE.subs = txtsubsidio.Text

                If txtminutos.Text = "" Then
                    ELPERMISOSBE.minutos = "0"
                Else
                    ELPERMISOSBE.minutos = txtminutos.Text
                End If
                If txtminutos1.Text = "" Then
                    ELPERMISOSBE.minutos1 = "0"
                Else
                    ELPERMISOSBE.minutos1 = txtminutos1.Text
                End If

                Select Case cmb_motivo.SelectedIndex
                    Case 0
                        ELPERMISOSBE.motivo = "M"
                    Case 1
                        ELPERMISOSBE.motivo = "D"
                End Select
                Select Case cmb_motivo1.SelectedIndex
                    Case 0
                        ELPERMISOSBE.motivo1 = "D"
                    Case 1
                        ELPERMISOSBE.motivo1 = "C"
                    Case 2
                        ELPERMISOSBE.motivo1 = "E"
                    Case 3
                        ELPERMISOSBE.motivo1 = "M"
                    Case 4
                        ELPERMISOSBE.motivo1 = "N"
                End Select
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELPERMISOSBL.SaveRowS(ELPERMISOSBE, ELMVLOGSBE, flagAccion)
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

        'If flagAccion = "N" Then
        '    If ELPERIODOBL.VerificarRepetido(cmb_año.SelectedItem, cmb_mes.SelectedItem.ToString.Substring(0, 2)) = True Then
        '        MsgBox("Ya existe el Periodo para este año y mes", MsgBoxStyle.Exclamation)
        '        Return False
        '    End If
        'End If
        If txtper_cod.Text = "" Then
            MsgBox("Ingrese dni del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese una observacion", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmb_motivo.SelectedIndex = -1 Then
            MsgBox("Seleccione un motivo", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmb_motivo1.SelectedIndex = -1 Then
            MsgBox("Seleccione una contingencia", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPERMISOSBL.SelectRowS(sTDoc, sSDoc)
        For Each Registro In dtUsuario.Rows
            txtper_cod.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            lblper_cod.Text = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            dtpfec_ini.Value = Registro("F_INICIO")
            dtpfec_fin.Value = Registro("F_FINAL")
            txtdescripcion.Text = IIf(IsDBNull(Registro("OBSERVACION")), "", Registro("OBSERVACION"))
            txtsubsidio.Text = IIf(IsDBNull(Registro("SUBSIDIO")), "", Registro("SUBSIDIO"))
            txtminutos.Text = IIf(IsDBNull(Registro("DESCTO")), "", Registro("DESCTO"))
            txtminutos1.Text = IIf(IsDBNull(Registro("COSTO_EMP")), "", Registro("COSTO_EMP"))
            cmb_motivo.SelectedItem = IIf(IsDBNull(Registro("MOTIVO")), "", Registro("MOTIVO"))
            cmb_motivo1.SelectedItem = IIf(IsDBNull(Registro("MOTIVO_SALUD")), "", Registro("MOTIVO_SALUD"))
        Next
    End Sub

    Private Sub txtper_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtper_cod.KeyPress, txtminutos.KeyPress, txtminutos1.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtper_cod_LostFocus(sender As Object, e As EventArgs) Handles txtper_cod.LostFocus
        If (txtper_cod.Text = "") Then
            lblper_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBTAREOBL.SelectPerCOD(txtper_cod.Text)
            If dt.Rows.Count > 0 Then
                txtper_cod.Text = dt.Rows(0).Item(0).ToString
                lblper_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtper_cod.Text = ""
                lblper_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtper_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "63"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub FormELPERMISOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub dtpfec_ini_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_ini.LostFocus
        dtpfec_fin.Value = dtpfec_ini.Value
    End Sub
    Private Sub dtpfec_fin_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_fin.LostFocus
        If flagAccion = "N" Then
            txtndoc.Text = ELPERMISOSBL.SelectNro(dtpfec_ini.Value.Year)
            txtsdoc.Text = DateTime.Now.ToString("yyyy")
        End If
    End Sub

    Private ELBCALCULOSUBSIDIO As New ELBCALCULOSUBSIDIO
    Private Sub Btn_Calculo_Click(sender As Object, e As EventArgs) Handles Btn_Calculo.Click
        DgvPagos.Visible = True
        DgvPagos.Rows.Clear()
        Dim cod = txtper_cod.Text
        Dim fecha = dtpfec_ini.Value
        Dim dtPagos As New DataTable
        Dim diasSubsi = (dtpfec_fin.Value - dtpfec_ini.Value)
        Dim dias As Integer = diasSubsi.Days + 1
        Dim pagoTotal = 0
        Dim diasTotal = 0
        Dim dtPeriodo As DataTable
        Dim periodo = 0
        Dim dtListaPeriodos As DataTable
        Dim ListaPeriodos As New ELPERIODOS
        dtPeriodo = ELBCALCULOSUBSIDIO.BuscarPeriodo(fecha)
        periodo = dtPeriodo.Rows(0).Item(0)
        dtListaPeriodos = ELBCALCULOSUBSIDIO.ListaPeriodos(periodo)
        With ListaPeriodos
            .MES1 = dtListaPeriodos.Rows(0).Item(0)
            .MES2 = dtListaPeriodos.Rows(1).Item(0)
            .MES3 = dtListaPeriodos.Rows(2).Item(0)
            .MES4 = dtListaPeriodos.Rows(3).Item(0)
            .MES5 = dtListaPeriodos.Rows(4).Item(0)
            .MES6 = dtListaPeriodos.Rows(5).Item(0)
            .MES7 = dtListaPeriodos.Rows(6).Item(0)
            .MES8 = dtListaPeriodos.Rows(7).Item(0)
            .MES9 = dtListaPeriodos.Rows(8).Item(0)
            .MES10 = dtListaPeriodos.Rows(9).Item(0)
            .MES11 = dtListaPeriodos.Rows(10).Item(0)
            .MES12 = dtListaPeriodos.Rows(11).Item(0)
        End With
        dtPagos = ELBCALCULOSUBSIDIO.CalculoSubsidio(cod, periodo, dtpfec_ini.Value, dtpfec_fin.Value, ListaPeriodos)
        'DgvPagos.DataSource = dtPagos.DefaultView
        For Each row As DataRow In dtPagos.Rows
            DgvPagos.Rows.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")),'0
                                  IIf(IsDBNull(row("MES1")), "", row("MES1")),'2
                                  IIf(IsDBNull(row("MES2")), "", row("MES2")),'3
                                  IIf(IsDBNull(row("MES3")), "", row("MES3")),'4
                                  IIf(IsDBNull(row("MES4")), "", row("MES4")),'5
                                  IIf(IsDBNull(row("MES5")), "", row("MES5")),'6
                                  IIf(IsDBNull(row("MES6")), "", row("MES6")),'7
                                  IIf(IsDBNull(row("MES7")), "", row("MES7")),'8
                                  IIf(IsDBNull(row("MES8")), "", row("MES8")),'9
                                  IIf(IsDBNull(row("MES9")), "", row("MES9")), '10
                                  IIf(IsDBNull(row("MES10")), "", row("MES10")), '11
                                  IIf(IsDBNull(row("MES11")), "", row("MES11")),'12
                                  IIf(IsDBNull(row("MES12")), "", row("MES12"))) '13
            ' IIf(IsDBNull(row("TOTAL")), "", row("TOTAL")),'14
            ' IIf(IsDBNull(row("DIAS")), "", row("DIAS"))) '15)
        Next
        'pagoTotal = DgvPagos.CurrentRow.Cells(14).Value
        'diasTotal = DgvPagos.CurrentRow.Cells(15).Value
        Dim subsidido = (pagoTotal / diasTotal) * dias
        subsidido = Format(subsidido, “##,##0.00”)
        LblDias.Text = dias.ToString + " Día(s) Subsidiado(s) y un pago de S/ " + subsidido.ToString
        dtPagos.Dispose()
        Dim i As Integer
        For i = 0 To DgvPagos.Columns.Count - 1
            DgvPagos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Try
            DgvPagos.CurrentCell = DgvPagos.Rows(0).Cells(7)
        Catch ex As Exception
            MsgBox("No hay datos en el detalle")
        End Try
    End Sub
End Class