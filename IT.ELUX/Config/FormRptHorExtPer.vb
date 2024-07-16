Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormRptHorExtPer
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private TMP_HOREXTBL As New TMP_HOREXTBL
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

    Private Sub FormRptHorExtPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Horas Extras Personal"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        bprimero = True
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo2)
        bprimero = False
    End Sub

    Private Sub FormRptHorExtPer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        Dim TMP_HOREXTBE As New TMP_HOREXTBE
        TMP_HOREXTBE.cco_cod = txtc_costo.Text
        TMP_HOREXTBE.anho = cmbaño.Text
        'TMP_HOREXTBE.prdo_cod = txt_periodo.Text
        'TMP_HOREXTBE.prdo_cod1 = txt_periodo1.Text
        TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "ESOP")
        For i = 1 To 3
            TMP_HOREXTBE.tipo = i
            TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "SOP")
        Next
        If txtc_costo.Text = "" Then
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "101"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "102"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "103"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "104"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "105"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "107"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "108"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "109"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "110"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "111"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "113"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "114"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "116"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "117"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "118"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "119"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "203"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "106"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = "120"
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
        Else
            For i = 1 To 12
                For j = 1 To 3
                    TMP_HOREXTBE.cco_cod = txtc_costo.Text
                    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
                    TMP_HOREXTBE.tipo = j
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C0")
                    TMP_HOREXTBL.ReportePrograma(TMP_HOREXTBE, "C1")
                Next
            Next
        End If
        'For i = 1 To 12
        '    TMP_HOREXTBE.cco_cod = "101"
        '    TMP_HOREXTBE.mes = i.ToString.PadLeft(2, "0")
        '    'TMP_HOREXTBE.tipo = j

        'Next
        gsRptArgs = {}
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_HORAS_EXTRAS_PER_PRDO1.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
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

End Class