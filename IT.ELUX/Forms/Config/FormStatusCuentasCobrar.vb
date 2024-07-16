Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormStatusCuentasCobrar
    Private primero As Boolean
    Private primero2 As Boolean
    Dim CTCTBL As New CTCTBL

    Private Sub FormStatusCuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True

        Me.Text = "Status Cuentas por Cobrar"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        If gsUser = "OBEIZAGA" Then
            cmbcargoso.SelectedIndex = 0
        End If

        Dim dt As New DataTable
        dt = CTCTBL.SelectDepart()
        GetCmb("cod_depart", "nom_depart", dt, cmbDepart)
        'cmbDepart.SelectedIndex = -1

        primero = False
        primero2 = False
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormStatusCuentasCobrar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub


    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If cmbDepart.SelectedIndex <> -1 Then
            reporteUbigeo()
        End If
        If rdbop1.Checked = True Then
            'If gsUser = "OBEIZAGA" And cmbcargoso.SelectedIndex = 0 Then
            '    ReDim gsRptArgs(10)
            '    gsRptArgs(0) = txtvend.Text
            '    gsRptArgs(1) = txtvend1.Text
            '    gsRptArgs(2) = txtcliente1.Text
            '    gsRptArgs(3) = txtcliente2.Text
            '    If cmbtipo1.SelectedIndex = 1 Then
            '        gsRptArgs(4) = "80"
            '    ElseIf cmbtipo1.SelectedIndex = 2 Then
            '        gsRptArgs(4) = "01"
            '    ElseIf cmbtipo1.SelectedIndex = 3 Then
            '        gsRptArgs(4) = "07"
            '    Else
            '        gsRptArgs(4) = ""
            '    End If
            '    If cmbtipo2.SelectedIndex = 1 Then
            '        gsRptArgs(5) = "80"
            '    ElseIf cmbtipo2.SelectedIndex = 2 Then
            '        gsRptArgs(5) = "01"
            '    ElseIf cmbtipo2.SelectedIndex = 3 Then
            '        gsRptArgs(5) = "07"
            '    Else
            '        gsRptArgs(5) = ""
            '    End If
            '    gsRptArgs(6) = Format(dtpfec1.Value, "yyyy/MM/dd")
            '    gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            '    gsRptArgs(8) = cmbestado1.Text
            '    gsRptArgs(9) = cmbestado2.Text
            '    gsRptArgs(10) = cmbvencido.SelectedIndex
            '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CTAS_POR_COBRAR2.rpt"
            '    gsRptPath = gsPathRpt
            '    FormReportes.Show()
            '    'End If
            'Else
            ReDim gsRptArgs(13)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = txtvend.Text
            gsRptArgs(2) = txtvend1.Text
            gsRptArgs(3) = txtcliente1.Text
            gsRptArgs(4) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(5) = "80"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(5) = "01"
            ElseIf cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(5) = "07"
            Else
                gsRptArgs(5) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(6) = "80"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(6) = "01"
            ElseIf cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(6) = "07"
            Else
                gsRptArgs(6) = ""
            End If
            gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(8) = cmbestado1.Text
            gsRptArgs(9) = cmbestado2.Text
            gsRptArgs(10) = cmbvencido.SelectedIndex
            gsRptArgs(11) = ""
            gsRptArgs(12) = ""
            gsRptArgs(13) = ""
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CTAS_POR_COBRAR.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
            'End If
        Else
            ReDim gsRptArgs(12)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = txtvend.Text
            gsRptArgs(2) = txtvend1.Text
            gsRptArgs(3) = txtcliente1.Text
            gsRptArgs(4) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(5) = "80"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(5) = "01"
            ElseIf cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(5) = "07"
            Else
                gsRptArgs(5) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(6) = "80"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(6) = "01"
            ElseIf cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(6) = "07"
            Else
                gsRptArgs(6) = ""
            End If
            gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(8) = cmbestado1.Text
            gsRptArgs(9) = cmbestado2.Text
            gsRptArgs(10) = ""
            gsRptArgs(11) = ""
            gsRptArgs(12) = ""
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ESTADO_DOCUMENTOS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        End If

    End Sub


    Private Sub txtvend_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "41"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtvend.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtvend1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "41"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtvend1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub


    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente2.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub cmbestado1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbestado1.SelectedIndexChanged

    End Sub

    Private Sub cmbDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepart.SelectedIndexChanged
        'change line
        If primero Then Exit Sub

        '    primero = True
        Dim sCode As String = Mid(cmbDepart.SelectedValue, 1, 2)
        Dim dt As New DataTable

        primero = True
        dt = CTCTBL.SelectProv(sCode)
        GetCmb("cod_prov", "nom_prov", dt, cmbProv)
        primero = False
        'cmbProv.SelectedIndex = 0
    End Sub

    Private Sub cmbProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProv.SelectedIndexChanged
        'change line
        If primero Then Exit Sub

        '    primero = True
        Dim sCode As String = Mid(cmbProv.Text, 1, 4)
        Dim dt As New DataTable

        primero = True
        dt = CTCTBL.SelectDist(sCode)
        GetCmb("COD_DIST", "NOM_DIST", dt, cmbDist)
        primero = False
        'cmbDist.SelectedIndex = 0
    End Sub

    Private Sub reporteUbigeo()
        If rdbop1.Checked = True Then
            'If gsUser = "OBEIZAGA" And cmbcargoso.SelectedIndex = 0 Then
            '    ReDim gsRptArgs(10)
            '    gsRptArgs(0) = txtvend.Text
            '    gsRptArgs(1) = txtvend1.Text
            '    gsRptArgs(2) = txtcliente1.Text
            '    gsRptArgs(3) = txtcliente2.Text
            '    If cmbtipo1.SelectedIndex = 1 Then
            '        gsRptArgs(4) = "80"
            '    ElseIf cmbtipo1.SelectedIndex = 2 Then
            '        gsRptArgs(4) = "01"
            '    ElseIf cmbtipo1.SelectedIndex = 3 Then
            '        gsRptArgs(4) = "07"
            '    Else
            '        gsRptArgs(4) = ""
            '    End If
            '    If cmbtipo2.SelectedIndex = 1 Then
            '        gsRptArgs(5) = "80"
            '    ElseIf cmbtipo2.SelectedIndex = 2 Then
            '        gsRptArgs(5) = "01"
            '    ElseIf cmbtipo2.SelectedIndex = 3 Then
            '        gsRptArgs(5) = "07"
            '    Else
            '        gsRptArgs(5) = ""
            '    End If
            '    gsRptArgs(6) = Format(dtpfec1.Value, "yyyy/MM/dd")
            '    gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            '    gsRptArgs(8) = cmbestado1.Text
            '    gsRptArgs(9) = cmbestado2.Text
            '    gsRptArgs(10) = cmbvencido.SelectedIndex
            '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CTAS_POR_COBRAR2.rpt"
            '    gsRptPath = gsPathRpt
            '    FormReportes.Show()
            '    'End If
            'Else
            ReDim gsRptArgs(13)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = txtvend.Text
            gsRptArgs(2) = txtvend1.Text
            gsRptArgs(3) = txtcliente1.Text
            gsRptArgs(4) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(5) = "80"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(5) = "01"
            ElseIf cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(5) = "07"
            Else
                gsRptArgs(5) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(6) = "80"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(6) = "01"
            ElseIf cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(6) = "07"
            Else
                gsRptArgs(6) = ""
            End If
            gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(8) = cmbestado1.Text
            gsRptArgs(9) = cmbestado2.Text
            gsRptArgs(10) = cmbvencido.SelectedIndex
            If cmbDepart.SelectedIndex = -1 Then
                gsRptArgs(11) = ""
            Else
                gsRptArgs(11) = cmbDepart.Text.Substring(0, 2)
            End If

            If cmbProv.SelectedIndex = -1 Then
                gsRptArgs(12) = ""
            Else
                gsRptArgs(12) = cmbProv.Text.Substring(0, 4)
            End If

            If cmbDist.SelectedIndex = -1 Then
                gsRptArgs(13) = ""
            Else
                gsRptArgs(13) = cmbDist.Text.Substring(0, 6)
            End If
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CTAS_POR_COBRAR.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
            'End If
        Else
            ReDim gsRptArgs(12)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = txtvend.Text
            gsRptArgs(2) = txtvend1.Text
            gsRptArgs(3) = txtcliente1.Text
            gsRptArgs(4) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(5) = "80"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(5) = "01"
            ElseIf cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(5) = "07"
            Else
                gsRptArgs(5) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(6) = "80"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(6) = "01"
            ElseIf cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(6) = "07"
            Else
                gsRptArgs(6) = ""
            End If
            gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(8) = cmbestado1.Text
            gsRptArgs(9) = cmbestado2.Text

            If cmbDepart.SelectedIndex = -1 Then
                gsRptArgs(10) = ""
            Else
                gsRptArgs(10) = cmbDepart.Text.Substring(1, 2)
            End If

            If cmbProv.SelectedIndex = -1 Then
                gsRptArgs(11) = ""
            Else
                gsRptArgs(11) = cmbProv.Text.Substring(1, 4)
            End If

            If cmbDist.SelectedIndex = -1 Then
                gsRptArgs(12) = ""
            Else
                gsRptArgs(12) = cmbDist.Text.Substring(1, 6)
            End If
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ESTADO_DOCUMENTOS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbDepart.SelectedIndex = -1
        cmbProv.SelectedIndex = -1
        cmbDist.SelectedIndex = -1
    End Sub
End Class