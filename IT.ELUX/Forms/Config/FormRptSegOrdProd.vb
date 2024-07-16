Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptSegOrdProd
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private bprimero As Boolean
    Private Sub FormRptSegOrdProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If gsUser = "JTRIGOS" Or gsUser = "MRODAS" Or gsUser = "SISTEMA" Or gsUser = "MRODAS" Or gsUser = "COSTOS" Or gsUser = "JHUAYLLACAYAN" Then
            btnreporte.Enabled = True
        Else
            btnreporte.Enabled = False
            lvccosto.Enabled = False
            dtpfec1.Enabled = False
            dtpfec2.Enabled = False
            cmbaño.Enabled = True
            cmbmes1.Enabled = True
        End If

        If gsUser = "DCONDOR" Or gsUser = "COSTOS" Or gsUser = "JQUICHCA" Then
            btnreporte.Enabled = True
            dtpfec1.Enabled = True
            dtpfec2.Enabled = True
        End If

        Dim dtCC As New DataTable
        dtCC = ARTICULOBL.ListadoCC()
        GetCmb("COD", "NOM", dtCC, cmbCentroCosto)
        bprimero = True
        Me.Text = "Reporte De Seguimiento de Movimientos de Ordenes de Porduccion"
        cmbaño.SelectedItem = sAño
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        Dim dt As DataTable
        Dim item As ListViewItem
        dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto1()
        For Each row As DataRow In dt.Rows
            item = lvccosto.Items.Add(IIf(IsDBNull(row("COD")), "", row("COD")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
        Next

        'cmbmes1.SelectedIndex = -1
        'cmbaño.SelectedIndex = -1
        cmbaño.Enabled = True
        bprimero = False
        cmbaño.Text = Today.Year

        If gsUser = "DCONDOR" Or gsUser = "MRODAS" Or gsUser = "JTRIGOS" Or gsUser = "SISTEMA" Or gsUser = "COSTOS" Or gsUser = "JHUAYLLACAYAN" Then
            For i = 0 To lvccosto.Items.Count - 1
                lvccosto.Items(i).Checked = True
            Next
            dtpfec1.Value = "01/01/" & cmbaño.Text
        End If
        lvccosto.Enabled = False

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

    Private Sub FormRptSegOrdProd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click




        Dim resp = MsgBox("Desea Procesar el Seguimiento", MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If
        Dim c As Integer = 0
        Dim d As String = "0"
        Dim s As String = ""
        Dim t As String = ""
        gsRptArgs = {}
        For i = 0 To lvccosto.Items.Count - 1
            If lvccosto.Items(i).Checked Then
                c = c + 1
            End If
        Next
        If c = 0 Then
            ReDim gsRptArgs(8)
            If txtnumero.Text <> "" Then
                gsRptArgs(3) = cmbaño.Text & "-" & txtnumero.Text
            Else
                gsRptArgs(3) = ""
            End If

            If cmbCentroCosto.SelectedIndex = -1 Then

            Else
                gsRptArgs(0) = cmbCentroCosto.Text.Substring(0, 3)
                'MsgBox(gsRptArgs(1))
            End If

            If cmbmes1.SelectedIndex = -1 Then

            Else
                gsRptArgs(1) = obtenerMesAct(cmbmes1.SelectedIndex - 1)
            End If
            If cmbaño.SelectedIndex = -1 Then

            Else
                gsRptArgs(2) = cmbaño.Text
            End If
            gsRptArgs(4) = txtcodart.Text
            gsRptArgs(5) = txt_codcons.Text
            gsRptArgs(6) = "N"
            gsRptArgs(7) = ""
            gsRptArgs(8) = cmbaño.Text & "-" & txtnumero.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_NUEVO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

        Else
            If gsUser = "DCONDOR" Or gsUser = "COSTOS" Then
                If txtnumero.Text = "" Then
                    MsgBox("Ingrese Numero OP")
                    Exit Sub
                End If

            End If
            Dim sf1 As String = ""
            Dim sf2 As String = ""
            If dtpfec1.Checked Then
                sf1 = Format(dtpfec1.Value, "yyyy/MM/dd")
                sf2 = Format(dtpfec2.Value, "yyyy/MM/dd")
            Else
                sf1 = ""
                sf2 = ""
            End If
            ELORDEN_PROGRAMBL.ReportePrograma("ESOP", cmbaño.SelectedItem, s, d.PadLeft(2, "0"), t, "", "", txtnumero.Text)
            For i = 0 To lvccosto.Items.Count - 1
                If lvccosto.Items(i).Checked Then
                    ELORDEN_PROGRAMBL.ReportePrograma("SOP", txtnumero.Text, sf1, sf2, txtcodart.Text,
                                                     lvccosto.Items(i).SubItems(0).Text, cmbaño.Text, "")
                End If
            Next
            ' ReDim gsRptArgs()
            dgvt_doc.DataSource = Nothing
            dgvt_doc.DataSource = ELORDEN_PROGRAMBL.RPTSEGPRDORD(txtnumero.Text)
            If dgvt_doc.Rows.Count > 0 Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    ELORDEN_PROGRAMBL.ReportePrograma("AOP1", dgvt_doc.Rows(i).Cells("numero").Value, s, "", t, "", "", "")
                    ELORDEN_PROGRAMBL.ReportePrograma("SOP1", dgvt_doc.Rows(i).Cells("numero").Value, "", "", "", "", "", "")
                    ELORDEN_PROGRAMBL.ReportePrograma("SOP2", dgvt_doc.Rows(i).Cells("numero").Value, "", "", "", "", "", "")
                Next
            End If

            'IMPRESION REPORTE
            ReDim gsRptArgs(8)
            If txtnumero.Text <> "" Then
                gsRptArgs(3) = cmbaño.Text & "-" & txtnumero.Text
            Else
                gsRptArgs(3) = ""
            End If

            If cmbCentroCosto.SelectedIndex = -1 Then

            Else
                gsRptArgs(0) = cmbCentroCosto.Text.Substring(0, 3)
                'MsgBox(gsRptArgs(1))
            End If

            If cmbmes1.SelectedIndex = -1 Then

            Else
                gsRptArgs(1) = obtenerMesAct(cmbmes1.SelectedIndex - 1)
            End If
            If cmbaño.SelectedIndex = -1 Then

            Else
                gsRptArgs(2) = cmbaño.Text
            End If
            gsRptArgs(4) = txtcodart.Text
            gsRptArgs(5) = txt_codcons.Text
            gsRptArgs(6) = "N"
            gsRptArgs(7) = ""
            gsRptArgs(8) = cmbaño.Text & "-" & txtnumero.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_NUEVO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

        End If

        'NUEVO
        'Dim sf1 As String = ""
        'Dim sf2 As String = ""
        'Dim mes1 As String = ""
        'If dtpfec1.Checked Then
        '    sf1 = Format(dtpfec1.Value, "yyyy/MM/dd")
        '    sf2 = Format(dtpfec2.Value, "yyyy/MM/dd")
        'Else
        '    sf1 = ""
        '    sf2 = ""
        'End If
        'If cmbmes1.SelectedIndex > 0 Then
        '    Select Case cmbmes1.SelectedIndex
        '        Case 0
        '            mes1 = "01"
        '        Case 1
        '            mes1 = "02"
        '        Case 2
        '            mes1 = "03"
        '        Case 3
        '            mes1 = "04"
        '        Case 5
        '            mes1 = "05"
        '        Case 6
        '            mes1 = "06"
        '        Case 7
        '            mes1 = "07"
        '        Case 8
        '            mes1 = "08"
        '        Case 9
        '            mes1 = "09"
        '        Case 10
        '            mes1 = "11"
        '        Case 11
        '            mes1 = "12"
        '    End Select
        '    ELORDEN_PROGRAMBL.ReportePrograma("ESOP1", cmbaño.SelectedItem, mes1, "".PadLeft(2, "0"), txtcodart.Text, txtnumero.Text, "")
        '    For i = 0 To lvccosto.Items.Count - 1
        '        If lvccosto.Items(i).Checked Then
        '            ELORDEN_PROGRAMBL.ReportePrograma("SOP", txtnumero.Text, sf1, sf2, txtcodart.Text,
        '                                              lvccosto.Items(i).SubItems(0).Text, cmbaño.Text)
        '        End If
        '    Next
        '    'ReDim gsRptArgs()
        '    dgvt_doc.DataSource = Nothing
        '    dgvt_doc.DataSource = ELORDEN_PROGRAMBL.RPTSEGPRDORD()
        '    If dgvt_doc.Rows.Count > 0 Then
        '        For i = 0 To dgvt_doc.Rows.Count - 1
        '            ELORDEN_PROGRAMBL.ReportePrograma("AOP1", dgvt_doc.Rows(i).Cells("numero").Value, "", "", "", "", "")
        '            ELORDEN_PROGRAMBL.ReportePrograma("SOP1", dgvt_doc.Rows(i).Cells("numero").Value, "", "", "", "", "")
        '        Next
        '    End If
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodart.Text = gLinea
            txtnomart.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If

    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F10 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart.Text = gLinea
                txtnomart.Text = gSubLinea
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

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If txtcodart.TextLength > 0 Then
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            'txtunidad.Text = ARTICULOBL.SelectUniMed(txtcodart.Text)
        Else
            txtcodart.Text = ""
            txtnomart.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub

    Private Sub txtnumero_LostFocus(sender As Object, e As EventArgs) Handles txtnumero.LostFocus
        If txtnumero.TextLength = 0 Then
            txtnumero.Text = ""
        Else
            txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
        End If

    End Sub

    'Private Sub dtpfec1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfec1.ValueChanged
    '    If dtpfec1.Checked Then
    '        dtpfec2.Enabled = True
    '        cmbaño.SelectedIndex = -1
    '        cmbaño.Enabled = False
    '    Else
    '        dtpfec2.Enabled = False
    '        cmbaño.Text = sAño
    '        cmbaño.Enabled = True
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim gsRptArgs(8)
        If txtnumero.Text <> "" Then
            gsRptArgs(3) = cmbaño.Text & "-" & txtnumero.Text
        Else
            gsRptArgs(3) = ""
        End If

        If cmbCentroCosto.SelectedIndex = -1 Then

        Else
            gsRptArgs(0) = cmbCentroCosto.Text.Substring(0, 3)
            'MsgBox(gsRptArgs(1))
        End If

        If cmbmes1.SelectedIndex = -1 Then

        Else
            gsRptArgs(1) = obtenerMesAct(cmbmes1.SelectedIndex - 1)
        End If
        If cmbaño.SelectedIndex = -1 Then

        Else
            gsRptArgs(2) = cmbaño.Text
        End If
        gsRptArgs(4) = txtcodart.Text
        gsRptArgs(5) = txt_codcons.Text
        gsRptArgs(6) = "N"
        gsRptArgs(7) = ""
        gsRptArgs(8) = cmbaño.Text & "-" & txtnumero.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_NUEVO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub


    Private Function obtenerMesAct(ByVal index As Integer) As String
        Dim mes = ""
        Select Case index
            Case 0
                mes = "01"
            Case 1
                mes = "02"
            Case 2
                mes = "03"
            Case 3
                mes = "04"
            Case 4
                mes = "05"
            Case 5
                mes = "06"
            Case 6
                mes = "07"
            Case 7
                mes = "08"
            Case 8
                mes = "09"
            Case 9
                mes = "10"
            Case 10
                mes = "11"
            Case 11
                mes = "12"
        End Select
        Return mes
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txt_codcons.Text = gLinea
            txt_nomcons.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txt_codcons_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codcons.KeyDown
        If e.KeyValue = Keys.F10 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_codcons.Text = gLinea
                txt_nomcons.Text = gSubLinea
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

    Private Sub txt_codcons_LostFocus(sender As Object, e As EventArgs) Handles txt_codcons.LostFocus
        If txt_codcons.TextLength > 0 Then
            txt_nomcons.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            'txtunidad.Text = ARTICULOBL.SelectUniMed(txtcodart.Text)
        Else
            txt_codcons.Text = ""
            txt_nomcons.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub
End Class