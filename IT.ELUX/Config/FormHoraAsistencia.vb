Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormHoraAsistencia
    Private GUIAALMACENBL As New GUIAALMACENBL
    Dim bPrimero As Boolean
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
        sBusAlm = "3"
        Dim frm As New FormPerGrupo
        frm.ShowDialog()

    End Sub

    Private Sub FormHoraAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        Me.Text = "Control de Asistencias"
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        'Dim dtFecha3 As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        bPrimero = False
    End Sub

    Private Sub FormHoraAsistencia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If chkmen.Checked Then
            ReDim gsRptArgs(2)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(2) = txtdni.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTPERASISTENCIAMES.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(3)
            gsRptArgs(0) = txtdni.Text
            gsRptArgs(1) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(2) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(3) = txtlinea_cod.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ASISTENCIA.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        Me.txtdni.Text = cmbdni.SelectedValue
    End Sub

    Private Sub txtlinea_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtdni.Text = "" Then
                sBusAlm = "71"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txtlinea_cod.Text = gLinea
                    txtnom_linea.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                MsgBox("Debe Limpiar el DNI")
            End If

        End If
    End Sub

    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.Text = "" Then
            cmbdni.SelectedIndex = -1
        Else
            cmbdni.SelectedValue = txtdni.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "71"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtlinea_cod.Text = gLinea
            txtnom_linea.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
End Class