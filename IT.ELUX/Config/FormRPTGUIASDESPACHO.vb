Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRPTGUIASDESPACHO
    Private GUIADESPACHOBL As New GUIADESPACHOBL

#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        'If bPrimero = False Then
        cmb.DataSource = dtSelect
        'If (cmbdir.Items.Count > 0) Then
        cmb.DisplayMember = sDescri

        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
        '    End If
        'End If
    End Function
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If cmbt_mov.SelectedIndex = 3 Then
            ReDim gsRptArgs(7)

            gsRptArgs(0) = Format(dtpfecini.Value, "yyyy/MM/dd")
            gsRptArgs(1) = Format(dtpfecfin.Value, "yyyy/MM/dd")

            gsRptArgs(2) = "SALM"


            'If cmbSer_doc.SelectedIndex = 0 Then
            '    gsRptArgs(1) = ""
            'ElseIf cmbSer_doc.SelectedIndex = 1 Then
            '    gsRptArgs(1) = "001"
            'ElseIf cmbSer_doc.SelectedIndex = 2 Then
            '    gsRptArgs(1) = "003"
            'ElseIf cmbSer_doc.SelectedIndex = 3 Then
            '    gsRptArgs(1) = "004"
            'End If
            gsRptArgs(3) = txtnro_doc.Text

            gsRptArgs(4) = txtcodart.Text
            gsRptArgs(5) = cmbctct_cod.SelectedValue
            gsRptArgs(6) = txtuserrep.Text
            gsRptArgs(7) = "E25"  ' cmbt_mov.SelectedIndex
            'If cmbdestino.SelectedIndex = 0 Then
            '    gsRptArgs(9) = ""
            'ElseIf cmbdestino.SelectedIndex = 1 Then
            '    gsRptArgs(9) = "0001"
            'ElseIf cmbdestino.SelectedIndex = 2 Then
            '    gsRptArgs(9) = "0002"
            'ElseIf cmbdestino.SelectedIndex = 3 Then
            '    gsRptArgs(9) = "0003"
            'End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_GUIASDESPACHO_E.rpt"

        Else
            ReDim gsRptArgs(9)
            gsRptArgs(0) = txtt_doc.Text
            If cmbSer_doc.SelectedIndex = 0 Then
                gsRptArgs(1) = ""
            ElseIf cmbSer_doc.SelectedIndex = 1 Then
                gsRptArgs(1) = "001"
            ElseIf cmbSer_doc.SelectedIndex = 2 Then
                gsRptArgs(1) = "003"
            ElseIf cmbSer_doc.SelectedIndex = 3 Then
                gsRptArgs(1) = "004"
            End If

            gsRptArgs(2) = txtnro_doc.Text
            gsRptArgs(3) = Format(dtpfecini.Value, "yyyy/MM/dd")
            gsRptArgs(4) = Format(dtpfecfin.Value, "yyyy/MM/dd")
            gsRptArgs(5) = txtcodart.Text
            gsRptArgs(6) = cmbctct_cod.SelectedValue
            gsRptArgs(7) = txtuserrep.Text
            If cmbt_mov.SelectedIndex = 0 Then
                gsRptArgs(8) = ""
            ElseIf cmbt_mov.SelectedIndex = 1 Then
                gsRptArgs(8) = "S31"
            ElseIf cmbt_mov.SelectedIndex = 2 Then
                gsRptArgs(8) = "S32"
            End If
            If cmbdestino.SelectedIndex = 0 Then
                gsRptArgs(9) = ""
            ElseIf cmbdestino.SelectedIndex = 1 Then
                gsRptArgs(9) = "0001"
            ElseIf cmbdestino.SelectedIndex = 2 Then
                gsRptArgs(9) = "0002"
            ElseIf cmbdestino.SelectedIndex = 3 Then
                gsRptArgs(9) = "0003"
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_GUIASDESPACHO.rpt"
        End If
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRPTGUIASDESPACHO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSer_doc.SelectedIndex = 0
        'cmbt_mov.SelectedIndex = 0
        cmbdestino.SelectedIndex = 0
        Dim dtFecha As Date
        dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfecini.Value = dtFecha
        Dim dt As DataTable
        dt = GUIADESPACHOBL.SelectCliente
        GetCmb("cod", "nom", dt, cmbctct_cod)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            cmbctct_cod.SelectedValue = gLinea
        Else
            gLinea = Nothing
        End If

        'Dim dt As DataTable
        'dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
        'GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        'cmbdir.SelectedValue = txtdir.Text
        'txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
        'cmbvendedor.SelectedValue = txtvendedor.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        sBusAlm = "37"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gArt <> Nothing Then
            txtcodart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "240"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtuserrep.Text = gLinea
        End If
    End Sub

    Private Sub FormRPTGUIASDESPACHO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub rbtentrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbtentrada.CheckedChanged
        cmbSer_doc.Enabled = False
        cmbdestino.Enabled = False
        cmbt_mov.Enabled = False
    End Sub

    Private Sub rbtsalida_CheckedChanged(sender As Object, e As EventArgs) Handles rbtsalida.CheckedChanged
        cmbSer_doc.Enabled = True
        cmbdestino.Enabled = True
        cmbt_mov.Enabled = True
    End Sub
End Class