Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormSUBSIDIOMONTOS
    Private CTS_BL As New CTS_BL
    Private PERBL As New PERBL
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dt As DataTable
        'MODIFICAR
        dt = CTS_BL.SelectRow(sS_Ref, sN_Ref, sT_Ref)
        For Each row In dt.Rows
            txtper1.Text = IIf(IsDBNull(row("PER_COD")), "", row("PER_COD"))
            If IIf(IsDBNull(row("FEC_INI")), "", row("FEC_INI")) <> "" Then
                dtpfec_ini.Value = IIf(IsDBNull(row("FEC_INI")), "", row("FEC_INI"))
                dtpfec_ini.Checked = True
            End If
            If IIf(IsDBNull(row("FEC_FIN")), "", row("FEC_FIN")) <> "" Then
                dtpfecfin.Value = IIf(IsDBNull(row("FEC_FIN")), "", row("FEC_FIN"))
                dtpfecfin.Checked = True
            End If
            txt_periodo.Text = IIf(IsDBNull(row("PRDO_PAGO")), "", row("PRDO_PAGO"))
            'CTS
            npdmonto_cts.Value = IIf(IsDBNull(row("MONTO_CTS")), 0, row("MONTO_CTS"))
            npdprov_acum_cts.Value = IIf(IsDBNull(row("prov_acum_cts")), 0, row("prov_acum_cts"))
            npddif_ajuste_cts.Value = IIf(IsDBNull(row("dif_ajuste_cts")), 0, row("dif_ajuste_cts"))
            'VACA
            npdvacaciones.Value = IIf(IsDBNull(row("vacaciones")), 0, row("vacaciones"))
            npdprov_acum_vaca.Value = IIf(IsDBNull(row("prov_acum_vaca")), 0, row("prov_acum_vaca"))
            npddif_ajuste_vaca.Value = IIf(IsDBNull(row("dif_ajuste_vaca")), 0, row("dif_ajuste_vaca"))
            'GRATI
            npdgrati.Value = IIf(IsDBNull(row("GRATI")), 0, row("GRATI"))
            ndpprov_acum_grati.Value = IIf(IsDBNull(row("prov_acum_grati")), 0, row("prov_acum_grati"))
            npddif_ajuste_grati.Value = IIf(IsDBNull(row("dif_ajuste_grati")), 0, row("dif_ajuste_grati"))

            npdhextras.Value = IIf(IsDBNull(row("hextras")), 0, row("hextras"))
            npdcomision.Value = IIf(IsDBNull(row("comision")), 0, row("comision"))
            npdotros.Value = IIf(IsDBNull(row("comision")), 0, row("comision"))
            npddscto_quinta.Value = IIf(IsDBNull(row("dscto_quinta")), 0, row("dscto_quinta"))
            npdotros_dsctos.Value = IIf(IsDBNull(row("otros_dsctos")), 0, row("otros_dsctos"))
            npdmonto_prest.Value = IIf(IsDBNull(row("monto_prest")), 0, row("monto_prest"))
            txtnomper1.Text = PERBL.SelectApeNom(txtper1.Text)
        Next
    End Sub
    Private Sub FormSUBSIDIOMONTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
            Case 1
                flagAccion = "M"
                Dim s As String
                GetData(sTDoc, sSDoc, sNDoc)
                txtper1.ReadOnly = True
                txt_periodo.Enabled = False
        End Select
    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim nro As String
        Dim mesaño As String
        Dim m As String
        Dim m1 As Integer = 0
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim CTSBE As New CTSBE
        CTSBE.PER_COD = txtper1.Text
        CTSBE.USUARIO = gsUser
        CTSBE.ANHO = dtpfec_ini.Value.Year
        CTSBE.MONTO = npdmonto_cts.Value
        CTSBE.MES = dtpfec_ini.Value.Month
        CTSBE.HEXTRAS = npdhextras.Value
        CTSBE.GRATI = npdgrati.Value
        CTSBE.MESES = 0
        CTSBE.DIAS = 0
        CTSBE.NOMBRE = ""
        CTSBE.INTERES = 0
        CTSBE.PRDO_PAGO = txt_periodo.Text
        CTSBE.VACACIONES = npdvacaciones.Value
        CTSBE.MONTO_CTS = npdmonto_cts.Value
        CTSBE.COMISION = npdcomision.Value
        CTSBE.SUBSIDIO = npdsubsidio.Value
        CTSBE.OTROS = npdotros.Value
        Dim s As String
        If dtpfec_ini.Checked Then
            CTSBE.FEC_INI = dtpfec_ini.Value
            s = "0"
        End If
        If dtpfecfin.Checked Then
            CTSBE.FEC_FIN = dtpfecfin.Value
        End If
        CTSBE.DSCTO_QUINTA = npddscto_quinta.Value
        CTSBE.OTROS_DSCTOS = npdotros_dsctos.Value
        CTSBE.PROV_ACUM_CTS = npdprov_acum_cts.Value
        CTSBE.PROV_ACUM_VACA = npdprov_acum_vaca.Value
        CTSBE.DIF_AJUSTE_CTS = npddif_ajuste_cts.Value
        CTSBE.DIF_AJUSTE_GRATI = npddif_ajuste_grati.Value
        CTSBE.MONTO_PREST = npdmonto_prest.Value
        gsError = CTS_BL.SaveRow(CTSBE, ELMVLOGSBE, flagAccion, s)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
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

    Private Sub txtper1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper1.KeyDown

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

    Private Sub FormSUBSIDIOMONTOS_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
End Class