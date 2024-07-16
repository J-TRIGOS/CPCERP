Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormELTBDETMTIEM
    Private ELTBMTIEMBL As New ELTBMTIEMBL
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub FormELTBDETMTIEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dtphoragene.Format = DateTimePickerFormat.Custom
        dtphoragene.CustomFormat = "HH:mm:ss tt"

        dtphoratermino.Format = DateTimePickerFormat.Custom
        dtphoratermino.CustomFormat = "HH:mm:ss tt"

        dt = ELTBMTIEMBL.SelectActi
        GetCmb("cod", "nom", dt, cmbactividad)
        cmbactividad.SelectedValue = txtact.Text
    End Sub
    Private Sub dtpfec_inicio_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_inicio.LostFocus
        dtphoragene.Value = dtpfec_inicio.Value
    End Sub
    Private Sub dtpfec_termino_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_termino.LostFocus
        If FormELTBSTiem.dtpfec_gene.Value.Date <= dtpfec_termino.Value.Date Then
            dtphoratermino.Text = dtpfec_termino.Value
            If DateTime.Now.ToString("mm") = "01" Then
                FormELTBSTiem.cmbserie.Text = DateTime.Now.ToString("yyyy")
            End If
        Else
            MsgBox("La fecha de termino debe ser mayor a la fecha inicial")
            dtpfec_termino.Focus()
        End If
    End Sub
    Private Sub dtphoratermino_LostFocus(sender As Object, e As EventArgs) Handles dtphoratermino.LostFocus
        Dim date1, date2 As DateTime

        date1 = FormELTBSTiem.dtpfec_gene.Value.ToShortDateString
        date2 = dtpfec_termino.Value.ToShortDateString

        date1 = date1.AddHours(dtphoragene.Value.Hour)
        date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        date1 = date1.AddSeconds(dtphoragene.Value.Second)

        date2 = date2.AddHours(dtphoratermino.Value.Hour)
        date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        date2 = date2.AddSeconds(dtphoratermino.Value.Second)

        If DateTime.Compare(date1, date2) >= 0 Then
            MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
            dtphoragene.Focus()
        Else
            txtdifhora.Text = Nothing
            Dim HO As Integer = 0
            Dim MI As Integer = 0
            Dim SE As Integer = 0

            HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
            MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
            SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
            MI = MI Mod 60
            SE = SE Mod 60
            If HO > "18" Then
                'MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                'dtpfec_termino.Focus()
                'Exit Sub
            End If
            txtdifhora.Text = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        'Dim frm As New FormELTBSTiem
        Dim a As String = ""
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value = dtpfec_inicio.Value
        'For i = 0 To FormELTBSTiem.dgvtiemper.Rows.Count - 1
        a = dtphoragene.Value
        'If a = "" Then
        HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
        MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
        SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
        MI = MI Mod 60
        SE = SE Mod 60
        If HO > "17" Then
            'MsgBox("La hora mayor a las horas permitidas cambiar fechas")
            'dtpfec_termino.Focus()
            'Exit Sub
        End If
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value = dtphoragene.Text
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("Hora_Final").Value = dtphoratermino.Text
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value = Mid(dtpfec_inicio.Value, 1, 10)
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("FEC_TERMINO").Value = Mid(dtpfec_termino.Value, 1, 10)
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("Num_Hora").Value = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("Dif_Hora").Value = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("COD_REALIZAR").Value = cmbactividad.SelectedValue
        FormELTBSTIEMOM.dgvtiemper.Rows(FormELTBSTIEMOM.dgvtiemper.CurrentRow.Index).Cells("ACT_REALIZAR").Value = cmbactividad.Text
        FormELTBSTIEMOM.dgvtiemper.Refresh()
        '    End If
        'Next
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormELTBDETMTIEM_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class