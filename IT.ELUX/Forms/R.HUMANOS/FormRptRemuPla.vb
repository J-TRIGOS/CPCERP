Imports IT.ELUX.BL
Public Class FormRptRemuPla
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub FormRptRemuPla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Planilla Resumen Cosumo"
        bprimero = True
        Dim dt As DataTable
        GetCmb("cod", "nom", dt, cmbc_costo3)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo4)
        dt = GUIAALMACENBL.SelectCCosto
        cmbsit1.SelectedIndex = 2
        cmbsit2.SelectedIndex = 2
        cmbsit1.Enabled = False
        cmbsit2.Enabled = False
        bprimero = False
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PLLA_PRDO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class