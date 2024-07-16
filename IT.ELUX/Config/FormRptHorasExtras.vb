Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormRptHorasExtras
    Private CCOSTOBL As New CCOSTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private PERBL As New PERBL
    Private ELPROGRAMACIONBL As New ELPROGRAMACIONBL

    Private Sub FormRptHorasExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Horas Extras"
        Dim dtFecha As Date
        dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
        cmbmes2.SelectedIndex = Month(Date.Today)
        dtpfecini2.Value = dtFecha
        dtpfecini3.Value = dtFecha
        If gsUser = "JFLORES" Or gsUser = "JMONTES" Or gsUser = "SISTEMA" Then
            rdbincon.Visible = True
        Else
            rdbincon.Visible = False
        End If
        'cmbest2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "48"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuserrep.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcco_cod.Text = gLinea
            txtnomcco.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni.Text = gLinea
            txtnomape.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtdni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni.Text = gLinea
                txtnomape.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtdni2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni2.Text = gLinea
                txtnomape2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub txtcco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "29"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcco_cod.Text = gLinea
                txtnomcco.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcco_cod2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcco_cod2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "29"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcco_cod2.Text = gLinea
                txtnomcco2.Text = CCOSTOBL.SelectNom(txtcco_cod2.Text)
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "71"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtlinea.Text = gLinea
            txtnomlinea.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtlinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea.KeyDown
        If CheckBox1.Checked = False Then
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "71"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txtlinea.Text = gLinea
                    txtnomlinea.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub txtlinea2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "71"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtlinea2.Text = gLinea
                txtnomlinea2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If rdbdet.Checked Then
            ReDim gsRptArgs(9)
            gsRptArgs(0) = txtnro.Text
            gsRptArgs(1) = cmbaño.SelectedItem
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = "12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(3) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(3) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(3) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(3) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(3) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(3) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(3) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(3) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(3) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(3) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(3) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(3) = "12"
            End If
            gsRptArgs(4) = txtdni.Text
            gsRptArgs(5) = txtcco_cod.Text
            gsRptArgs(6) = txtlinea.Text
            If cmbest.SelectedIndex = 1 Then
                gsRptArgs(7) = "PR"
            ElseIf cmbest.SelectedIndex = 2 Then
                gsRptArgs(7) = "D"
            ElseIf cmbest.SelectedIndex = 3 Then
                gsRptArgs(7) = "PE"
            ElseIf cmbest.SelectedIndex = 4 Then
                gsRptArgs(7) = "A"
            Else
                gsRptArgs(7) = ""
            End If

            gsRptArgs(8) = txtuserrep.Text
            gsRptArgs(9) = txt_periodo.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTELTBSTIEM_SELALL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbboleta.Checked Then
            'If txtdni2.TextLength = 0 Then
            '    MsgBox("Ponga un dni")
            '    Exit Sub
            'End If
            ReDim gsRptArgs(6)
            gsRptArgs(0) = txtnro2.Text
            If cmbaño1.SelectedIndex <> -1 And txtnro2.TextLength > 0 Then
                gsRptArgs(1) = cmbaño1.Text
            Else
                gsRptArgs(1) = Format(dtpfecini2.Value, "yyyy/MM/dd")
            End If

            gsRptArgs(2) = Format(dtpfecfin2.Value, "yyyy/MM/dd")
            gsRptArgs(3) = txtdni.Text
            gsRptArgs(4) = txtcco_cod.Text
            gsRptArgs(5) = txtlinea.Text
            'If cmbest2.SelectedIndex = 0 Then
            '    gsRptArgs(6) = "H"
            'ElseIf cmbest.SelectedIndex = 1 Then
            '    gsRptArgs(6) = "A"
            'End If
            gsRptArgs(6) = cmbproc.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTELTBSTIEM_SELROWALL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            dgvinc.Rows.Clear()
            dgvinc.Columns.Add("T_DOC_REF", "T_DOC_REF")
            dgvinc.Columns.Add("SER_DOC_REF", "SER_DOC_REF")
            dgvinc.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF")
            dgvinc.Columns.Add("PER_COD", "PER_COD")
            dgvinc.Columns.Add("FEC_INICIO", "FEC_INICIO")
            dgvinc.Columns.Add("FEC_TERMINO", "FEC_TERMINO")
            dgvinc.Columns.Add("HORA_INICIO", "HORA_INICIO")
            dgvinc.Columns.Add("HORA_TERMINO", "HORA_TERMINO")
            dgvinc.Columns.Add("FEC_GENE", "FEC_GENE")
            dgvinc.Columns.Add("NUM_DIF", "NUM_DIF")
            dgvinc.Columns.Add("FECHA_MAX", "FECHA_MAX")
            dgvinc.Columns.Add("FECHA_MIN", "FECHA_MIN")
            dgvtiemper.Rows.Clear()
            dgvtiemper.Columns.Add("COD", "COD")
            dgvtiemper.Columns.Add("FECHA", "FECHA")
            Dim dt As DataTable
            dt = PERBL.SelPerHorTareo(Format(dtpfecini3.Value, "yyyy/MM/dd"), Format(dtpfecfin3.Value, "yyyy/MM/dd"))
            For Each row As DataRow In dt.Rows
                dgvtiemper.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")),
                                    IIf(IsDBNull(row("FECHA")), "", row("FECHA")))
            Next
            Dim PERBE As New PERBE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            gsError = PERBL.Save(PERBE, ELMVLOGSBE, dgvtiemper, "TA")
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                'Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
            dt = PERBL.SelPerHorTareo(Format(dtpfecini3.Value, "yyyy/MM/dd"), Format(dtpfecfin3.Value, "yyyy/MM/dd"))
            For Each row As DataRow In dt.Rows
                dgvtiemper.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                    IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                    IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                    IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                                    IIf(IsDBNull(row("FEC_INICIO")), "", row("FEC_INICIO")),
                                    IIf(IsDBNull(row("FEC_TERMINO")), "", row("FEC_TERMINO")),
                                    IIf(IsDBNull(row("HORA_INICIO")), "", row("HORA_INICIO")),
                                    IIf(IsDBNull(row("HORA_TERMINO")), "", row("HORA_TERMINO")),
                                    IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),
                                    IIf(IsDBNull(row("NUM_DIF")), "", row("NUM_DIF")),
                                    IIf(IsDBNull(row("FECHA_MAX")), "", row("FECHA_MAX")),
                                    IIf(IsDBNull(row("FECHA_MIN")), "", row("FECHA_MIN")))

            Next
            gsError = PERBL.Save(PERBE, ELMVLOGSBE, dgvtiemper, "TH")
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                'Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
            'ReDim gsRptArgs(3)
            'gsRptArgs(0) = Format(dtpfecini3.Value, "yyyy/MM/dd")
            'gsRptArgs(1) = Format(dtpfecfin3.Value, "yyyy/MM/dd")
            'gsRptArgs(2) = cmbtareo.Text
            'gsRptArgs(3) = cmbprogramacion.Text
            'gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTPERASINC.rpt"
            'gsRptPath = gsPathRpt
            'FormReportes.ShowDialog()

        End If

    End Sub

    Private Sub txtuserrep_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuserrep.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "48"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtuserrep.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcco_cod.LostFocus
        If txtcco_cod.TextLength > 2 Then
            txtnomcco.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
        Else
            txtnomcco.Text = ""
        End If
    End Sub

    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.Text = "" Then
            txtnomape.Text = ""
            Exit Sub
        End If
        txtnomape.Text = PERBL.SelectApeNom(txtdni.Text)
        If txtnomape.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtnomape.Text = ""
        End If
    End Sub

    Private Sub txtlinea_LostFocus(sender As Object, e As EventArgs) Handles txtlinea.LostFocus
        If CheckBox1.Checked = False Then
            If (txtlinea.Text = "") Then
                txtnomlinea.Text = ""
            Else
                Dim dt As DataTable
                dt = ELPROGRAMACIONBL.SelectAreaCOD(txtlinea.Text)
                If dt.Rows.Count > 0 Then
                    txtlinea.Text = dt.Rows(0).Item(0).ToString
                    txtnomlinea.Text = dt.Rows(0).Item(1).ToString
                Else
                    txtlinea.Text = ""
                    txtnomlinea.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtnro_LostFocus(sender As Object, e As EventArgs) Handles txtnro.LostFocus
        If txtnro.TextLength <> 0 Then
            txtnro.Text = txtnro.Text.PadLeft(7, "0")
        Else
            txtnro.Text = ""
        End If

    End Sub

    Private Sub rdbdet_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdet.CheckedChanged
        If rdbdet.Checked Then
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
        ElseIf rdbboleta.Checked Then
            Panel1.Visible = False
            Panel2.Visible = True
            Panel3.Visible = False
        ElseIf rdbincon.Checked Then
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
        End If
    End Sub

    Private Sub rdbboleta_CheckedChanged(sender As Object, e As EventArgs) Handles rdbboleta.CheckedChanged
        If rdbboleta.Checked Then
            Panel1.Visible = False
            Panel2.Visible = True
            Panel3.Visible = False
        ElseIf rdbdet.Checked Then
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
        ElseIf rdbincon.Checked Then
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcco_cod2.Text = gLinea
            txtnomcco2.Text = CCOSTOBL.SelectNom(txtcco_cod2.Text)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "71"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtlinea2.Text = gLinea
            txtnomlinea2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni2.Text = gLinea
            txtnomape2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim dt As DataTable = ARTICULOBL.getListcmblin1()
        GetCmb("cod", "nom", dt, cmbc_costo)
        If CheckBox1.Checked = True Then
            txtlinea.Text = Nothing
            txtnomlinea.Text = Nothing
            Button3.Enabled = False
            cmbc_costo.Visible = True

        Else
            cmbc_costo.Visible = False
            Button3.Enabled = True
        End If
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged

        Try
            txtlinea.Text = cmbc_costo.SelectedValue
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtlinea_TextChanged(sender As Object, e As EventArgs) Handles txtlinea.TextChanged
        If CheckBox1.Checked Then
            cmbc_costo.SelectedValue = txtlinea.Text
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        sBusAlm = "85"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txt_periodo.Text = gLinea
            dtpfec_ini.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtnro2_LostFocus(sender As Object, e As EventArgs) Handles txtnro2.LostFocus
        If txtnro2.TextLength > 0 Then
            cmbaño1.Enabled = True
            cmbaño.SelectedItem = sAño
        Else
            cmbaño1.Enabled = False
            cmbaño.SelectedItem = -1
        End If
    End Sub

    Private Sub txtnro2_TextChanged(sender As Object, e As EventArgs) Handles txtnro2.TextChanged
        If txtnro2.TextLength = 7 Then
            cmbaño1.Enabled = True
            cmbaño.SelectedItem = sAño
        Else
            cmbaño1.Enabled = False
            cmbaño.SelectedItem = -1
        End If
    End Sub

    Private Sub rdbincon_CheckedChanged(sender As Object, e As EventArgs) Handles rdbincon.CheckedChanged
        If rdbboleta.Checked Then
            Panel1.Visible = False
            Panel2.Visible = True
            Panel3.Visible = False
        ElseIf rdbdet.Checked Then
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
        ElseIf rdbincon.Checked Then
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
        End If
    End Sub

    Private Sub FormRptHorasExtras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class