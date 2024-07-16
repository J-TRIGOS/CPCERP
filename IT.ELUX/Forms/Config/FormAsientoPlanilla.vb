Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormAsientoPlanilla
    Private PERBL As New PERBL
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If

            Select Case sFunc
                Case "exit"
                    Dispose()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormAsientoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.Text = sAño
        txttdoc.Text = "9999"
        ComboBox1.Text = sAño
        cmbaño1.Text = sAño
        txttdoc1.Text = "9999"
        Me.cmbaño.Text = sAño
        Me.dtpfec_ini.Enabled = False
    End Sub

    Private Sub FormAsientoPlanilla_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If txtndoc1.Text = "" Or txttdoc1.Text = "" Or npdtcmb1.Value = 0 Then
            MsgBox("Ingrese todos los valores")
            Exit Sub
        End If
        Dim fla As String = ""
        If rdbplan1.Checked Then
            fla = "PLAN1"
        End If
        If rdbgra1.Checked Then
            fla = "GRA1"
        End If
        If rdbcts1.Checked Then
            fla = "CTS1"
        End If
        If rdbvaca1.Checked Then
            fla = "VACA1"
        End If
        gsError = PERBL.InsAsPlan(txttdoc1.Text, cmbaño1.Text, txtndoc1.Text, npdtcmb1.Value, dtpfecha1.Value, fla, txtcontrato_prdo1.Text)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'txttdoc.Text = ""
            txtndoc1.Text = ""
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub txt_periodo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo.KeyDown

        If e.KeyValue = Keys.F9 Then
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
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Desea grabar el Registro",
                  Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If txtndoc.Text = "" Or txttdoc.Text = "" Or npdtcmb.Value = 0 Then
            MsgBox("Ingrese todos los valores")
            Exit Sub
        End If
        Dim fla As String = ""
        If rdbplan.Checked Then
            fla = "PLAN"
        End If
        If rdbgra.Checked Then
            fla = "GRA"
        End If
        If rdbcts.Checked Then
            fla = "CTS"
        End If
        If rdbvaca.Checked Then
            fla = "VACA"
        End If
        gsError = PERBL.InsAsPlan(txttdoc.Text, cmbaño.Text, txtndoc.Text, npdtcmb.Value, dtpfecha.Value, fla, txtcontrato_prdo9.Text)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'txttdoc.Text = ""
            txtndoc.Text = ""
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub txtcontrato_prdo1_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo1.LostFocus
        If txtcontrato_prdo1.TextLength = 0 Then
            dtpfec_ini1.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo1.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini1.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo1.Text)
                dtpfec_ini1.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcontrato_prdo1.Text = gLinea
                dtpfec_ini1.Value = gArt
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
    Private Sub btnsalir_Click_1(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If cmbaño.SelectedIndex >= 0 And cmbmes1.SelectedIndex >= 0 And txt_periodo.TextLength > 0 And cmbt_pago.SelectedIndex >= 0 Then
            Dim mespl As String = ""
            Dim t As String = ""
            If cmbmes1.SelectedIndex = 1 Then
                mespl = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                mespl = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                mespl = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                mespl = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                mespl = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                mespl = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                mespl = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                mespl = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                mespl = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                mespl = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                mespl = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                mespl = "12"
            End If
            mespl = cmbaño.Text & mespl
            t = cmbt_pago.Text
            If t = "MENSUAL" Then
                t = "MEN"
            Else
                t = "GRA"
            End If
            gsError = ELPERIODOBL.SaveRowAllMes("INSMOV", txt_periodo.Text, mespl, t)
            If gsError = "OK" Then
                MsgBox("Planilla Mensual Generada", MsgBoxStyle.Information)
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Generar Planilla", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub txt_periodo_LostFocus(sender As Object, e As EventArgs) Handles txt_periodo.LostFocus
        If txt_periodo.TextLength = 0 Then
            dtpfec_ini.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo1.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini.Text = ELPERIODOBL.SelectFecPRd(txt_periodo.Text)
                dtpfec_ini.Checked = True
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = ComboBox1.SelectedItem
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbt_pago.SelectedIndex = 0 Then
            gsRptArgs(2) = "MEN"
        Else
            gsRptArgs(2) = "GRA"
        End If
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPT_PREPLANILLA.rpt"
        gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

    End Sub
End Class