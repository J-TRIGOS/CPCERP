Imports IT.ELUX.BL

Public Class FormRptMayor

    Private Sub FormRptMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAnio.SelectedItem = sAño
        cboMes.SelectedIndex = Month(Date.Today) - 1
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnProcesar_Click(sender As Object, e As EventArgs) Handles BtnProcesar.Click


        If cboAnio.SelectedIndex = -1 Then
            MsgBox("Seleccione el Año", MsgBoxStyle.Exclamation)
            cboAnio.Focus()
            Exit Sub
        End If
        If cboMes.SelectedIndex = -1 Then
            MsgBox("Seleccione el mes", MsgBoxStyle.Exclamation)
            cboMes.Focus()
            Exit Sub
        End If

        Dim sAnioNumero, sMesNumero As String
        sAnioNumero = cboAnio.Text
        If cboMes.SelectedIndex = 0 Then
            sMesNumero = "01"
        ElseIf cboMes.SelectedIndex = 1 Then
            sMesNumero = "02"
        ElseIf cboMes.SelectedIndex = 2 Then
            sMesNumero = "03"
        ElseIf cboMes.SelectedIndex = 3 Then
            sMesNumero = "04"
        ElseIf cboMes.SelectedIndex = 4 Then
            sMesNumero = "05"
        ElseIf cboMes.SelectedIndex = 5 Then
            sMesNumero = "06"
        ElseIf cboMes.SelectedIndex = 6 Then
            sMesNumero = "07"
        ElseIf cboMes.SelectedIndex = 7 Then
            sMesNumero = "08"
        ElseIf cboMes.SelectedIndex = 8 Then
            sMesNumero = "09"
        ElseIf cboMes.SelectedIndex = 9 Then
            sMesNumero = "10"
        ElseIf cboMes.SelectedIndex = 10 Then
            sMesNumero = "11"
        ElseIf cboMes.SelectedIndex = 11 Then
            sMesNumero = "12"
        End If
        'sMesNumero = Funciones.Right(String.Format("0{0}", cboMes.SelectedIndex), 2)

        If MessageBox.Show(String.Format("Desea procesar el Año {0} Y Mes {1}", sAnioNumero, sMesNumero),
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        Dim oMayorBL As New MayorBL()
        oMayorBL.Procesar(sAnioNumero, sMesNumero)
        MsgBox("Realizó Mayorización", MsgBoxStyle.Information)

    End Sub


End Class