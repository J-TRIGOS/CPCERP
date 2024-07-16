Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptSegOrdProd
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private bprimero As Boolean
    Private Sub FormRptSegOrdProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bprimero = True
        Me.Text = "Reporte De Seguimiento de Movimientos de Ordenes de Porduccion"
        'cmbaño.SelectedItem = sAño
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        Dim dt As DataTable
        Dim item As ListViewItem
        dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto1()
        For Each row As DataRow In dt.Rows
            item = lvccosto.Items.Add(IIf(IsDBNull(row("COD")), "", row("COD")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
        Next
        cmbmes1.SelectedIndex = Month(Date.Today)
        bprimero = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptSegOrdProd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
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
            ReDim gsRptArgs(4)
            'gsRptArgs(0) = cmbaño.SelectedItem
            'gsRptArgs(1) = s
            gsRptArgs(0) = txtnumero.Text
            gsRptArgs(1) = txtcodart.Text
            If dtpfec1.Checked Then
                gsRptArgs(2) = Format(dtpfec1.Value, "yyyy/MM/dd")
            Else
                gsRptArgs(2) = ""
            End If
            If dtpfec1.Checked Then
                gsRptArgs(3) = Format(dtpfec2.Value, "yyyy/MM/dd")
            Else
                gsRptArgs(3) = ""
            End If
            If dtpfec1.Checked Then
                gsRptArgs(4) = ""
            Else
                gsRptArgs(4) = cmbaño.Text
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTSEGPROD_ORD.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

        Else
            Dim sf1 As String = ""
            Dim sf2 As String = ""
            If dtpfec1.Checked Then
                sf1 = Format(dtpfec1.Value, "yyyy/MM/dd")
                sf2 = Format(dtpfec2.Value, "yyyy/MM/dd")
            Else
                sf1 = ""
                sf2 = ""
            End If
            ELORDEN_PROGRAMBL.ReportePrograma("ESOP", cmbaño.SelectedItem, s, d.PadLeft(2, "0"), t, "", "")
            For i = 0 To lvccosto.Items.Count - 1
                If lvccosto.Items(i).Checked Then
                    ELORDEN_PROGRAMBL.ReportePrograma("SOP", txtnumero.Text, sf1, sf2, txtcodart.Text,
                                                      lvccosto.Items(i).SubItems(0).Text, cmbaño.Text)
                End If
            Next
            'ReDim gsRptArgs()
            dgvt_doc.DataSource = Nothing
            dgvt_doc.DataSource = ELORDEN_PROGRAMBL.RPTSEGPRDORD()
            If dgvt_doc.Rows.Count > 0 Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    ELORDEN_PROGRAMBL.ReportePrograma("SOP1", dgvt_doc.Rows(i).Cells("numero").Value, "", "", "", "", "")
                Next
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTSEGPROD_ORD2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
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

    Private Sub dtpfec1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfec1.ValueChanged
        If dtpfec1.Checked Then
            dtpfec2.Enabled = True
            cmbaño.SelectedIndex = -1
            cmbaño.Enabled = False
        Else
            dtpfec2.Enabled = False
            cmbaño.Text = sAño
            cmbaño.Enabled = True
        End If
    End Sub
End Class