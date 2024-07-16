Imports IT.ELUX.BL
Imports IT.ELUX.BE

Public Class FormProcesarQuincena
    Dim QUINCENABL As New QUINCENABL

    Private Sub FormProcesarQuincena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbAnho.Text = Today.Year.ToString
        cmbMes.SelectedIndex = Today.Month - 1
    End Sub
    Private Function mesNum(ByVal cmb As String) As String
        If cmbMes.SelectedItem = "Enero" Then
            Return "01"
        ElseIf cmbMes.SelectedItem = "Febrero" Then
            Return "02"
        ElseIf cmbMes.SelectedItem = "Marzo" Then
            Return "03"
        ElseIf cmbMes.SelectedItem = "Abril" Then
            Return "04"
        ElseIf cmbMes.SelectedItem = "Mayo" Then
            Return "05"
        ElseIf cmbMes.SelectedItem = "Junio" Then
            Return "06"
        ElseIf cmbMes.SelectedItem = "Julio" Then
            Return "07"
        ElseIf cmbMes.SelectedItem = "Agosto" Then
            Return "08"
        ElseIf cmbMes.SelectedItem = "Septiembre" Then
            Return "09"
        ElseIf cmbMes.SelectedItem = "Octubre" Then
            Return "10"
        ElseIf cmbMes.SelectedItem = "Noviembre" Then
            Return "11"
        ElseIf cmbMes.SelectedItem = "Diciembre" Then
            Return "12"
        End If
    End Function

    Private Sub getData()
        Dim NN = ""
        Dim dtQuincena As New DataTable
        If gsUser = "JFLORES" Then
            NN = "20"
        ElseIf gsUser = "JTRIGOS" Then
            NN = ""
        Else
            NN = "21"
        End If
        Dim mes As String = mesNum(cmbMes.Text)

        dtQuincena = QUINCENABL.ListadoPersonalQUincena(mes, cmbAnho.Text, NN)

        For i = 0 To dtQuincena.Rows.Count - 1
            dgvQuincena.Rows.Add()
            dgvQuincena.Rows(i).Cells("COD").Value = dtQuincena.Rows(i).Item("COD")
            dgvQuincena.Rows(i).Cells("EMPLEADO").Value = dtQuincena.Rows(i).Item("EMPLEADO")
            dgvQuincena.Rows(i).Cells("FECING").Value = dtQuincena.Rows(i).Item("FECING")
            dgvQuincena.Rows(i).Cells("QUINC").Value = dtQuincena.Rows(i).Item("QUINC")
            dgvQuincena.Rows(i).Cells("PRDO").Value = dtQuincena.Rows(i).Item("PRDO")
            dgvQuincena.Rows(i).Cells("BASICO").Value = dtQuincena.Rows(i).Item("BASICO")
            If dtQuincena.Rows(i).Item("DIAS") >= "15" Then
                dgvQuincena.Rows(i).Cells("DIAS").Value = "15"
            Else
                dgvQuincena.Rows(i).Cells("DIAS").Value = dtQuincena.Rows(i).Item("DIAS")
            End If
            If dtQuincena.Rows(i).Item("DIAS") <= 15 Then
                dgvQuincena.Rows(i).Cells("MONTO").Value = Math.Round((dtQuincena.Rows(i).Item("BASICO") / 30) * dtQuincena.Rows(i).Item("DIAS"), 2)
            Else
                dgvQuincena.Rows(i).Cells("MONTO").Value = Math.Round(dtQuincena.Rows(i).Item("BASICO") / 2, 2)
            End If
        Next
        For i = 0 To dgvQuincena.Columns.Count - 1
            dgvQuincena.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        dgvQuincena.Rows.Clear()
        getData()
    End Sub

    Private Sub FormProcesarQuincena_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim mes As String = mesNum(cmbMes.Text)
        gsError = QUINCENABL.SaveRow("N", cmbAnho.Text, mes, dgvQuincena)
        If gsError = "OK" Then
            MsgBox("Quincena procesada correctamente")
        End If
    End Sub
End Class