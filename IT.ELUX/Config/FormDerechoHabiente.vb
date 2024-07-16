Imports System.ComponentModel

Public Class FormDerechoHabiente
    Private Sub FormDerechoHabiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Dependiente"
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If gArt = "0" Then
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("NOM1").Value = txtnom1.Text
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("NOM2").Value = txtnom2.Text
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("APE1").Value = txtape1.Text
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("APE2").Value = txtape2.Text
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("LE").Value = txtle.Text
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("FEC_NAC").Value = Format(dtpfec_nac.Value, "dd/MM/yyyy")
            Dim val As String
            Dim val1 As String
            If cmbx_tdoc.SelectedIndex = 1 Then
                val = "01"
            ElseIf cmbx_tdoc.SelectedIndex = 2 Then
                val = "11"
            ElseIf cmbx_tdoc.SelectedIndex = 3 Then
                val = "07"
            ElseIf cmbx_tdoc.SelectedIndex = 4 Then
                val = "04"
            Else
                val = ""
            End If
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("X_TDOC").Value = val
            If cmbvinculo_cod.SelectedIndex = 1 Then
                val1 = "02"
            ElseIf cmbvinculo_cod.SelectedIndex = 2 Then
                val1 = "03"
            ElseIf cmbvinculo_cod.SelectedIndex = 3 Then
                val1 = "04"
            ElseIf cmbvinculo_cod.SelectedIndex = 4 Then
                val1 = "05"
            ElseIf cmbvinculo_cod.SelectedIndex = 5 Then
                val1 = "06"
            Else
                val1 = ""
            End If
            FormMantPersonal.dgvdep.Rows(FormMantPersonal.dgvdep.CurrentRow.Index).Cells("VINCULO_COD").Value = val1
            Dispose()
        Else
            Dim val As String
            Dim val1 As String
            If cmbx_tdoc.SelectedIndex = 1 Then
                val = "01"
            ElseIf cmbx_tdoc.SelectedIndex = 2 Then
                val = "11"
            ElseIf cmbx_tdoc.SelectedIndex = 3 Then
                val = "07"
            ElseIf cmbx_tdoc.SelectedIndex = 4 Then
                val = "04"
            Else
                val = ""
            End If
            If cmbvinculo_cod.SelectedIndex = 1 Then
                val1 = "02"
            ElseIf cmbvinculo_cod.SelectedIndex = 2 Then
                val1 = "03"
            ElseIf cmbvinculo_cod.SelectedIndex = 3 Then
                val1 = "04"
            ElseIf cmbvinculo_cod.SelectedIndex = 4 Then
                val1 = "05"
            ElseIf cmbvinculo_cod.SelectedIndex = 5 Then
                val1 = "06"
            Else
                val1 = ""
            End If
            FormMantPersonal.dgvdep.Rows.Add(txtcod.Text, txtape1.Text, txtape2.Text, txtnom1.Text, txtnom2.Text,
                                             Format(dtpfec_nac.Value, "dd/MM/yyyy"), val, txtle.Text, val1)
            Dispose()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDerechoHabiente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class