Imports IT.ELUX.BL

Public Class FormRptAsientoPla
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

        If txt_periodo.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo.Focus()
            Exit Sub
        End If



        If cmbt_pago.SelectedIndex = -1 Then
            MsgBox("Seleccione el tipo", MsgBoxStyle.Exclamation)
            cmbt_pago.Focus()
            Exit Sub
        End If

        Dim sAnioNumero, sMesNumero As String
        sAnioNumero = cboAnio.Text
        sMesNumero = Funciones.Right(String.Format("0{0}", cboMes.SelectedIndex), 2)


        If MessageBox.Show(String.Format("Desea procesar el Año {0} Y Mes {1}", sAnioNumero, sMesNumero),
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim oAsientoBL As New AsientoPlaBL
        oAsientoBL.Procesar(sAnioNumero, sMesNumero, txt_periodo.Text, cmbt_pago.Text.Substring(0, 3))
        MsgBox("Se generó el Asiento", MsgBoxStyle.Information)

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

    Private Sub BtnDestino_Click(sender As Object, e As EventArgs) Handles BtnDestino.Click
        If cboAnio.SelectedIndex = -1 Then
            MsgBox("Seleccione el Año", MsgBoxStyle.Exclamation)
            cboAnio.Focus()
            Exit Sub
        End If

        Dim AnioActual As Integer = Date.Today.Year
        Dim AnioSelect As Integer = CInt(cboAnio.Text)

        If (AnioSelect < AnioActual) Then
            MsgBox("Seleccione el Año mayor o Igual", MsgBoxStyle.Exclamation)
            cboAnio.Focus()
            Exit Sub
        End If

        If cboMes.SelectedIndex = -1 Then
            MsgBox("Seleccione el mes", MsgBoxStyle.Exclamation)
            cboMes.Focus()
            Exit Sub
        End If


        If cmbt_pago.SelectedIndex = -1 Then
            MsgBox("Seleccione el tipo", MsgBoxStyle.Exclamation)
            cmbt_pago.Focus()
            Exit Sub
        End If

        Dim sAnioNumero, sMesNumero As String
        sAnioNumero = cboAnio.Text
        sMesNumero = Funciones.Right(String.Format("0{0}", cboMes.SelectedIndex), 2)


        If MessageBox.Show(String.Format("Desea procesar el Año {0} Y Mes {1}", sAnioNumero, sMesNumero),
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim oAsientoBL As New AsientoPlaBL
        oAsientoBL.Procesar2(sAnioNumero, sMesNumero, cmbt_pago.Text.Substring(0, 3))
        MsgBox("Se generó el Asiento", MsgBoxStyle.Information)
    End Sub


End Class