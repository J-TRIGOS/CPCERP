Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptOrdenProgam
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
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

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptProdCCO_COD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bprimero = True
        Me.Text = "Reporte Costo de articulo produccion por C.Costo"
        cmbaño.SelectedItem = sAño
        cmbturno.SelectedIndex = 0
        Dim dt As DataTable
        Dim item As ListViewItem
        dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto1()
        For Each row As DataRow In dt.Rows
            item = lvccosto.Items.Add(IIf(IsDBNull(row("COD")), "", row("COD")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
        Next
        'GetCmb("cod", "nom", dt, cmbc_costo)
        cmbmes1.SelectedIndex = Month(Date.Today)
        npdDia.Value = Date.Today.Day
        'dt = GUIAALMACENBL.SelectCCosto
        'GetCmb("cod", "nom", dt, cmbc_costo2)
        bprimero = False
    End Sub

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

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
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
        If chkdia.Checked Then
            d = npdDia.Value
        Else
            d = "0"
        End If
        If chkturno.Checked Then
            t = cmbturno.SelectedIndex
        Else
            t = ""
        End If
        If cmbmes1.SelectedIndex = 1 Then
            s = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            s = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            s = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            s = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            s = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            s = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            s = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            s = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            s = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            s = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            s = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            s = "12"
        End If
        If c = 0 Then
            ReDim gsRptArgs(4)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = s
            gsRptArgs(2) = txtc_costo.Text
            gsRptArgs(3) = d.PadLeft(2, "0")
            gsRptArgs(4) = t
            If cmbmes1.SelectedIndex = -1 Or cmbmes1.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar Mes")
            Else
                If chkprueba.Checked Then
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROWOP.rpt"
                Else
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROW.rpt"
                End If

                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If
        Else

            ELORDEN_PROGRAMBL.ReportePrograma("EL", cmbaño.SelectedItem, s, d.PadLeft(2, "0"), t, txtc_costo.Text, "")
            For i = 0 To lvccosto.Items.Count - 1
                If lvccosto.Items(i).Checked Then
                    ELORDEN_PROGRAMBL.ReportePrograma("Programa", cmbaño.Text, s, d.PadLeft(2, "0"), t, lvccosto.Items(i).SubItems(0).Text, "")
                End If
            Next
            If chkprueba.Checked Then
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROW1OP.rpt"
            Else
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROW1.rpt"
            End If

            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
        'Dim dt As String = ELORDEN_PROGRAMBL.ReportePrograma("Programa")

    End Sub

    Private Sub FormRptOrdenProgam_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub chkdia_CheckedChanged(sender As Object, e As EventArgs) Handles chkdia.CheckedChanged
        If chkdia.Checked Then
            npdDia.Enabled = True
        Else
            npdDia.Enabled = False
        End If
    End Sub

    Private Sub chkturno_CheckedChanged(sender As Object, e As EventArgs) Handles chkturno.CheckedChanged
        If chkturno.Checked Then
            cmbturno.SelectedIndex = 0
            cmbturno.Enabled = True
        Else
            cmbturno.SelectedIndex = -1
            cmbturno.Enabled = False
        End If
    End Sub
End Class
