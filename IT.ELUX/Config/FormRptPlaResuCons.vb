Imports IT.ELUX.BL
Public Class FormRptPlaResuCons
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELPERIODOBL As New ELPERIODOBL
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


    Private Sub cmbc_costo5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo5.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo5.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo5.Text = cmbc_costo5.SelectedValue
    End Sub

    Private Sub cmbc_costo6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo6.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo6.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo6.Text = cmbc_costo6.SelectedValue
    End Sub

    Private Sub cmbc_costo7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo7.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo7.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo7.Text = cmbc_costo7.SelectedValue
    End Sub

    Private Sub cmbc_costo8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo8.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo8.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo8.Text = cmbc_costo8.SelectedValue
    End Sub
    Private Sub FormRptPlaResuCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsUser <> "COSTOS" Then
            Me.Text = "Planilla Resumen Cosumo"
            Dim dt As DataTable
            bprimero = True
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo2)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo3)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo4)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo5)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo6)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo7)
            dt = GUIAALMACENBL.SelectCCosto
            GetCmb("cod", "nom", dt, cmbc_costo8)
            bprimero = False
        Else
            Me.Text = "Planilla Resumen Cosumo"
            Dim dt As DataTable
            bprimero = True
            TabPage1.Enabled = False
            TabPage2.Enabled = False
            TabPage3.Enabled = False
            TabPage4.Focus()
            'TabPage4.Enabled = False
            dt = GUIAALMACENBL.SelectCCosto1
            GetCmb("cod", "nom", dt, cmbc_costo7)
            dt = GUIAALMACENBL.SelectCCosto1
            GetCmb("cod", "nom", dt, cmbc_costo8)
            bprimero = False
        End If

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
        cmbc_costo2.SelectedValue = txtc_costo.Text
        If cmbc_costo2.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo2.Text = ""
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

    Private Sub txtc_costo5_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo5.LostFocus
        If txtc_costo5.Text = "" Then
            cmbc_costo3.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo5.SelectedValue = txtc_costo5.Text
        If cmbc_costo5.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo5.Text = ""
        End If
    End Sub

    Private Sub txtc_costo6_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo6.LostFocus
        If txtc_costo6.Text = "" Then
            cmbc_costo6.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo6.SelectedValue = txtc_costo6.Text
        If cmbc_costo6.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo6.Text = ""
        End If
    End Sub
    Private Sub txtc_costo7_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo7.LostFocus
        If txtc_costo7.Text = "" Then
            cmbc_costo7.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo7.SelectedValue = txtc_costo6.Text
        If cmbc_costo7.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo7.Text = ""
        End If
    End Sub

    Private Sub txtc_costo8_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo8.LostFocus
        If txtc_costo8.Text = "" Then
            cmbc_costo8.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo8.SelectedValue = txtc_costo6.Text
        If cmbc_costo8.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo8.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo1.Text = gLinea
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo2.Text = gLinea
            dtpfec_ini2.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo3.Text = gLinea
            dtpfec_ini3.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo4.Text = gLinea
            dtpfec_ini4.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(4)
        If cmbtipo.SelectedIndex = 1 Then
            gsRptArgs(0) = "MEN"
        Else
            gsRptArgs(0) = "GRA"
        End If
        'gsRptArgs() = txtcontrato_prdo1.Text
        gsRptArgs(1) = txtc_costo.Text
        gsRptArgs(2) = txtc_costo2.Text
        gsRptArgs(3) = txtcontrato_prdo1.Text
        gsRptArgs(4) = txtcontrato_prdo2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PLLA_CCOSTO_RESU_CONSOLIDA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtcontrato_prdo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "72"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo2.Text = gLinea
                dtpfec_ini2.Value = gArt
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

    Private Sub txtcontrato_prdo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo2.Text = gLinea
                dtpfec_ini2.Value = gArt
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
    Private Sub txtcontrato_prdo3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo3.Text = gLinea
                dtpfec_ini3.Value = gArt
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
    Private Sub txtcontrato_prdo4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo4.Text = gLinea
                dtpfec_ini4.Value = gArt
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
    Private Sub txtcontrato_prdo5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo5.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo5.Text = gLinea
                dtpfec_ini5.Value = gArt
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
    Private Sub txtcontrato_prdo6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo6.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo6.Text = gLinea
                dtpfec_ini6.Value = gArt
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
    Private Sub txtcontrato_prdo7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo7.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo7.Text = gLinea
                dtpfec_ini7.Value = gArt
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

    Private Sub txtcontrato_prdo8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo8.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo8.Text = gLinea
                dtpfec_ini8.Value = gArt
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

    Private Sub txtdni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni.Text = gLinea
                txtnomper.Text = gSubLinea
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
                txtnomper2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtdni3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni3.Text = gLinea
                txtnomper3.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtdni4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni4.Text = gLinea
                txtnomper4.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtdni5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni5.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni5.Text = gLinea
                txtnomper5.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtdni6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni6.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni6.Text = gLinea
                txtnomper6.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(8)
        If cmbtipo2.SelectedIndex = 1 Then
            gsRptArgs(0) = "MEN"
        Else
            gsRptArgs(0) = "GRA"
        End If
        gsRptArgs(1) = txtcontrato_prdo3.Text
        gsRptArgs(2) = txtcontrato_prdo4.Text
        gsRptArgs(3) = txtdni.Text
        gsRptArgs(4) = txtdni2.Text
        If cmbsit1.Text = "Empleado" Then
            gsRptArgs(5) = "21"
        ElseIf cmbsit1.Text = "Obrero" Then
            gsRptArgs(5) = "20"
        End If
        If cmbsit2.Text = "Empleado" Then
            gsRptArgs(6) = "21"
        ElseIf cmbsit2.Text = "Obrero" Then
            gsRptArgs(6) = "20"
        End If
        gsRptArgs(7) = txtc_costo3.Text
        gsRptArgs(8) = txtc_costo4.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PLLA_PRDO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo5.Text = gLinea
            dtpfec_ini5.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo6.Text = gLinea
            dtpfec_ini6.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(8)
        If cmbtipo3.SelectedIndex = 1 Then
            gsRptArgs(0) = "MEN"
        Else
            gsRptArgs(0) = "GRA"
        End If
        gsRptArgs(1) = txtcontrato_prdo5.Text
        gsRptArgs(2) = txtcontrato_prdo6.Text
        gsRptArgs(3) = txtdni3.Text
        gsRptArgs(4) = txtdni4.Text
        If cmbsit3.Text = "Empleado" Then
            gsRptArgs(5) = "21"
        ElseIf cmbsit3.Text = "Obrero" Then
            gsRptArgs(5) = "20"
        End If
        If cmbsit4.Text = "Empleado" Then
            gsRptArgs(6) = "21"
        ElseIf cmbsit4.Text = "Obrero" Then
            gsRptArgs(6) = "20"
        End If
        gsRptArgs(7) = txtc_costo5.Text
        gsRptArgs(8) = txtc_costo6.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PLLA_PRDO_CCOSTO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Cursor.Current = Cursors.WaitCursor
        If txtcontrato_prdo7.TextLength = 0 Then
            MsgBox("Debe ingresar el periodo")
            Exit Sub
        End If
        If txtcontrato_prdo8.TextLength = 0 Then
            MsgBox("Debe ingresar el periodo")
            Exit Sub
        End If
        If cmbtipo4.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar el codigo de pago")
            Exit Sub
        End If
        ReDim gsRptArgs(8)

        gsRptArgs(0) = txtcontrato_prdo7.Text
        gsRptArgs(1) = txtcontrato_prdo8.Text
        gsRptArgs(2) = txtdni5.Text
        gsRptArgs(3) = txtdni6.Text
        'If cmbsit5.Text = "Empleado" Then
        '    gsRptArgs(5) = "21"
        'ElseIf cmbsit5.Text = "Obrero" Then
        '    gsRptArgs(5) = "20"
        'End If
        'If cmbsit6.Text = "Empleado" Then
        '    gsRptArgs(6) = "21"
        'ElseIf cmbsit6.Text = "Obrero" Then
        '    gsRptArgs(6) = "20"
        'End If
        gsRptArgs(4) = txtc_costo7.Text
        gsRptArgs(5) = txtc_costo8.Text
        gsRptArgs(6) = gsUser
        If cmbtipo4.SelectedIndex = 1 Then
            gsRptArgs(7) = "MEN"
        Else
            gsRptArgs(7) = "GRA"
        End If
        If cmbtipo4.SelectedIndex = 1 Then
            gsRptArgs(8) = "MEN"
        Else
            gsRptArgs(8) = "GRA"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PLLA_PRDO_CCOSTO_AREA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo7.Text = gLinea
            dtpfec_ini7.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcontrato_prdo8.Text = gLinea
            dtpfec_ini8.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dispose()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dispose()
    End Sub

    Private Sub txtcontrato_prdo9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo9.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcontrato_prdo9.Text = gLinea
                dtpfec_ini9.Value = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                'gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcontrato_prdo9.Text = gLinea
            dtpfec_ini9.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            'gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcontrato_prdo9_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo9.LostFocus
        If txtcontrato_prdo9.TextLength = 0 Then
            dtpfec_ini9.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo9.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini9.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo9.Text)
                dtpfec_ini9.Checked = True
            End If
        End If

    End Sub

    Private Sub txtcontrato_prdo8_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo8.LostFocus
        If txtcontrato_prdo8.TextLength = 0 Then
            dtpfec_ini8.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo8.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini8.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo8.Text)
                dtpfec_ini8.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo7_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo7.LostFocus
        If txtcontrato_prdo7.TextLength = 0 Then
            dtpfec_ini7.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo7.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini7.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo7.Text)
                dtpfec_ini7.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo6_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo6.LostFocus
        If txtcontrato_prdo6.TextLength = 0 Then
            dtpfec_ini6.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo6.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini6.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo6.Text)
                dtpfec_ini6.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo5_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo5.LostFocus
        If txtcontrato_prdo5.TextLength = 0 Then
            dtpfec_ini5.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo5.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini5.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo5.Text)
                dtpfec_ini5.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo4_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo4.LostFocus
        If txtcontrato_prdo4.TextLength = 0 Then
            dtpfec_ini4.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo4.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini4.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo4.Text)
                dtpfec_ini4.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo3_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo3.LostFocus
        If txtcontrato_prdo3.TextLength = 0 Then
            dtpfec_ini3.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo3.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini3.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo3.Text)
                dtpfec_ini3.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo2_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo2.LostFocus
        If txtcontrato_prdo2.TextLength = 0 Then
            dtpfec_ini2.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo2.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini2.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo2.Text)
                dtpfec_ini2.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo1_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo1.LostFocus
        If txtcontrato_prdo1.TextLength = 0 Then
            dtpfec_ini.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo1.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo1.Text)
                dtpfec_ini.Checked = True
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txtcontrato_prdo10.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PROV_GRATI.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dispose()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dispose()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txtcontrato_prdo9.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PROV_CTS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txtcontrato_prdo11.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PROV_VACACIONES.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtcontrato_prdo10_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo10.LostFocus
        If txtcontrato_prdo10.TextLength = 0 Then
            dtpfec_ini10.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo10.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini10.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo10.Text)
                dtpfec_ini10.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo11_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo11.LostFocus
        If txtcontrato_prdo11.TextLength = 0 Then
            dtpfec_ini11.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo11.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini11.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo11.Text)
                dtpfec_ini11.Checked = True
            End If
        End If
    End Sub

    Private Sub FormRptPlaResuCons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class