Imports IT.ELUX.BL
Public Class FormRPTREMGLOBAL
    Private ELPERIODOBL As New ELPERIODOBL
    Private PERBL As New PERBL
    Private GUIAALMACENBL As New GUIAALMACENBL
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
    Private Sub FormRPTREMGLOBAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Remuneracion Global"
        cmbaño.Text = sAño
        cmbaño1.Text = sAño
        cmbmes.SelectedIndex = 1
        cmbmes1.SelectedIndex = Month(Date.Today)
        If gsUser = "JMONTES" Then
            Cmbt_per1.Text = "OBREROS"
            Cmbt_per2.Text = "OBREROS"
            Cmbt_per1.Enabled = False
            Cmbt_per2.Enabled = False
        End If
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        'Dim dt1 As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo1)
        dt = GUIAALMACENBL.SelectCCosto
        bprimero = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo1.Text = gLinea
            cmbc_costo1.SelectedValue = gLinea
            txtc_costo1.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
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

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = txtper1.Text
        gsRptArgs(1) = txtper2.Text
        If Cmbt_per1.SelectedIndex = 1 Then
            gsRptArgs(2) = "20"
        ElseIf Cmbt_per1.SelectedIndex = 2 Then
            gsRptArgs(2) = "21"
        Else
            gsRptArgs(2) = ""
        End If
        If Cmbt_per2.SelectedIndex = 1 Then
            gsRptArgs(3) = "20"
        ElseIf Cmbt_per2.SelectedIndex = 2 Then
            gsRptArgs(3) = "21"
        Else
            gsRptArgs(3) = ""
        End If
        gsRptArgs(4) = txtc_costo.Text
        gsRptArgs(5) = txtc_costo1.Text
        gsRptArgs(6) = cmbaño.Text
        gsRptArgs(7) = cmbaño1.Text
        If cmbmes.SelectedIndex = 1 Then
            gsRptArgs(8) = "01"
        ElseIf cmbmes.SelectedIndex = 2 Then
            gsRptArgs(8) = "02"
        ElseIf cmbmes.SelectedIndex = 3 Then
            gsRptArgs(8) = "03"
        ElseIf cmbmes.SelectedIndex = 4 Then
            gsRptArgs(8) = "04"
        ElseIf cmbmes.SelectedIndex = 5 Then
            gsRptArgs(8) = "05"
        ElseIf cmbmes.SelectedIndex = 6 Then
            gsRptArgs(8) = "06"
        ElseIf cmbmes.SelectedIndex = 7 Then
            gsRptArgs(8) = "07"
        ElseIf cmbmes.SelectedIndex = 8 Then
            gsRptArgs(8) = "08"
        ElseIf cmbmes.SelectedIndex = 9 Then
            gsRptArgs(8) = "09"
        ElseIf cmbmes.SelectedIndex = 10 Then
            gsRptArgs(8) = "10"
        ElseIf cmbmes.SelectedIndex = 11 Then
            gsRptArgs(8) = "11"
        ElseIf cmbmes.SelectedIndex = 12 Then
            gsRptArgs(8) = "12"
        End If
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(9) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(9) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(9) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(9) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(9) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(9) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(9) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(9) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(9) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(9) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(9) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(9) = "12"
        End If
        'gsRptArgs(3) = txtmedida1.Text
        'gsRptArgs(4) = txtmedida2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTREMUGLOBALx.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class