Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptContrato
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private PERBL As New PERBL
    Private bprimero As Boolean
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo.Text = gLinea
            cmbc_costo.SelectedValue = gLinea
            txtc_costo.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo2.Text = gLinea
            cmbc_costo2.SelectedValue = gLinea
            txtc_costo2.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub FormRptContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Contratos"
        Dim dt As DataTable
        bprimero = True
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo2)
        dt = GUIAALMACENBL.SelectCCosto
        bprimero = False
    End Sub
    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
        End If
    End Sub

    Private Sub txtc_costo2_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo2.LostFocus
        If txtc_costo2.Text = "" Then
            cmbc_costo2.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo2.SelectedValue = txtc_costo2.Text
        If cmbc_costo2.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo2.Text = ""
        End If
    End Sub
    Private Sub txtcontrato_prdo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "72"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo1.Text = gLinea
                dtpfec_ini.Value = gSubLinea
                dtpfec_fin.Value = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub
    Private Sub txtcontrato_prdo_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo1.LostFocus
        If txtcontrato_prdo1.Text <> "" Then
            If PERBL.SelectContratoIni(txtcontrato_prdo1.Text).Length <> 0 Then
                dtpfec_ini.Checked = True
                dtpfec_ini.Value = PERBL.SelectContratoIni(txtcontrato_prdo1.Text)
                dtpfec_fin.Checked = True
                dtpfec_fin.Value = PERBL.SelectContratoFin(txtcontrato_prdo1.Text)
            End If
        Else
            dtpfec_ini.Checked = False
            dtpfec_fin.Checked = False
            'txtnom_linea.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "72"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo1.Text = gLinea
            dtpfec_ini.Value = gSubLinea
            dtpfec_fin.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If rdbobrero.Checked Then
            ReDim gsRptArgs(5)
            gsRptArgs(0) = txtcontrato_prdo1.Text
            gsRptArgs(1) = txtper1.Text
            gsRptArgs(2) = txtper2.Text
            gsRptArgs(3) = txtc_costo.Text
            gsRptArgs(4) = txtc_costo2.Text
            gsRptArgs(5) = txtcontrato_prdo2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_OBRERO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbempleado.Checked Then
            ReDim gsRptArgs(5)
            gsRptArgs(0) = txtcontrato_prdo1.Text
            gsRptArgs(1) = txtper1.Text
            gsRptArgs(2) = txtper2.Text
            gsRptArgs(3) = txtc_costo.Text
            gsRptArgs(4) = txtc_costo2.Text
            gsRptArgs(5) = txtcontrato_prdo2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_EMP.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbmotorizado.Checked Then
            ReDim gsRptArgs(5)
            gsRptArgs(0) = txtcontrato_prdo1.Text
            gsRptArgs(1) = txtper1.Text
            gsRptArgs(2) = txtper2.Text
            gsRptArgs(3) = txtc_costo.Text
            gsRptArgs(4) = txtc_costo2.Text
            gsRptArgs(5) = txtcontrato_prdo2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_MOTORIZADO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbcomercial.Checked Then
            ReDim gsRptArgs(5)
            gsRptArgs(0) = txtcontrato_prdo1.Text
            gsRptArgs(1) = txtper1.Text
            gsRptArgs(2) = txtper2.Text
            gsRptArgs(3) = txtc_costo.Text
            gsRptArgs(4) = txtc_costo2.Text
            gsRptArgs(5) = txtcontrato_prdo2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_AREA_COMERCIAL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub cmbc_costo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo2.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo2.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo2.Text = cmbc_costo2.SelectedValue
    End Sub

    Private Sub txtper1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper1.Text = gLinea
                txtnomper1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtper1_LostFocus(sender As Object, e As EventArgs) Handles txtper1.LostFocus
        If txtper1.Text = "" Then
            txtnomper1.Text = ""
            Exit Sub
        End If
        txtnomper1.Text = PERBL.SelectApeNom(txtper1.Text)
        If txtper1.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper1.Text = ""
        End If
    End Sub

    Private Sub txtper2_LostFocus(sender As Object, e As EventArgs) Handles txtper2.LostFocus
        If txtper2.Text = "" Then
            txtnomper2.Text = ""
            Exit Sub
        End If
        txtnomper2.Text = PERBL.SelectApeNom(txtper2.Text)
        If txtper2.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper2.Text = ""
        End If
    End Sub

    Private Sub txtper2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper2.Text = gLinea
                txtnomper2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "72"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo2.Text = gLinea
            dtpfec_ini2.Value = gSubLinea
            dtpfec_fin2.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcontrato_prdo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "72"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo2.Text = gLinea
                dtpfec_ini2.Value = gSubLinea
                dtpfec_fin2.Value = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper1.Text = gLinea
            txtnomper1.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper2.Text = gLinea
            txtnomper2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnsalir2.Click
        Dispose()
    End Sub

    Private Sub btnreporte2_Click(sender As Object, e As EventArgs) Handles btnreporte2.Click
        If rdbempleado.Checked Then
            ReDim gsRptArgs(4)
            gsRptArgs(0) = txtper3.Text
            gsRptArgs(1) = txtper4.Text
            gsRptArgs(2) = txtc_costo3.Text
            gsRptArgs(3) = txtc_costo4.Text
            'If dtpfec_ini3.Checked Then
            '    gsRptArgs(4) = Format(dtpfec_ini3.Value, "yyyy/MM/dd")
            'Else
            '    MsgBox("Debe Seleccionar la Fecha")
            'End If
            If dtpfec_ini4.Checked Then
                gsRptArgs(4) = Format(dtpfec_ini4.Value, "yyyy/MM/dd")
            Else
                MsgBox("Debe Seleccionar la Fecha")
            End If
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_EMP2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbobrero.Checked Then
            ReDim gsRptArgs(4)
            If dtpfec_ini4.Checked Then
                gsRptArgs(0) = Format(dtpfec_ini4.Value, "yyyy/MM/dd")
            Else
                MsgBox("Debe Seleccionar la Fecha")
            End If
            gsRptArgs(1) = txtper3.Text
            gsRptArgs(2) = txtper4.Text
            gsRptArgs(3) = txtc_costo3.Text
            gsRptArgs(4) = txtc_costo4.Text
            'If dtpfec_ini3.Checked Then
            '    gsRptArgs(4) = Format(dtpfec_ini3.Value, "yyyy/MM/dd")
            'Else
            '    MsgBox("Debe Seleccionar la Fecha")
            'End If

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_OBRERO2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbcomercial.Checked Then
            ReDim gsRptArgs(4)
            gsRptArgs(0) = txtper3.Text
            gsRptArgs(1) = txtper4.Text
            gsRptArgs(2) = txtc_costo3.Text
            gsRptArgs(3) = txtc_costo4.Text
            If dtpfec_ini4.Checked Then
                gsRptArgs(4) = Format(dtpfec_ini4.Value, "yyyy/MM/dd")
            Else
                MsgBox("Debe Seleccionar la Fecha")
            End If


            'If dtpfec_ini3.Checked Then
            '    gsRptArgs(4) = Format(dtpfec_ini3.Value, "yyyy/MM/dd")
            'Else
            '    MsgBox("Debe Seleccionar la Fecha")
            'End If

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCONTRATO_VENTAS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper3.Text = gLinea
            txtnomper3.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper4.Text = gLinea
            txtnomper4.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo3.Text = gLinea
            cmbc_costo3.SelectedValue = gLinea
            txtc_costo3.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo4.Text = gLinea
            cmbc_costo4.SelectedValue = gLinea
            txtc_costo4.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub cmbc_costo3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo3.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo3.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo3.Text = cmbc_costo3.SelectedValue
    End Sub

    Private Sub cmbc_costo4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo4.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo4.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo4.Text = cmbc_costo4.SelectedValue
    End Sub

    Private Sub txtper3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper3.Text = gLinea
                txtnomper3.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtper4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper4.Text = gLinea
                txtnomper4.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtper3_LostFocus(sender As Object, e As EventArgs) Handles txtper3.LostFocus
        If txtper3.Text = "" Then
            txtnomper3.Text = ""
            Exit Sub
        End If
        txtnomper3.Text = PERBL.SelectApeNom(txtper3.Text)
        If txtper3.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper3.Text = ""
        End If
    End Sub

    Private Sub txtper4_LostFocus(sender As Object, e As EventArgs) Handles txtper4.LostFocus
        If txtper4.Text = "" Then
            txtnomper4.Text = ""
            Exit Sub
        End If
        txtnomper4.Text = PERBL.SelectApeNom(txtper4.Text)
        If txtper4.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper4.Text = ""
        End If
    End Sub

    Private Sub txtc_costo3_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo3.LostFocus
        If txtc_costo3.Text = "" Then
            cmbc_costo3.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo3.SelectedValue = txtc_costo3.Text
        If cmbc_costo3.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo3.Text = ""
        End If
    End Sub

    Private Sub txtc_costo4_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo4.LostFocus
        If txtc_costo4.Text = "" Then
            cmbc_costo4.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo4.SelectedValue = txtc_costo4.Text
        If cmbc_costo4.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo4.Text = ""
        End If
    End Sub
End Class