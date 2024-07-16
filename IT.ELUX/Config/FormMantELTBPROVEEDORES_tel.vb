Public Class FormMantELTBPROVEEDORES_tel
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        If OkData() = False Then
            Exit Sub
        Else
            If flagAccion1 = "N" Then
                FormMantELTBPROVEEDORES.dgvt_tel.Rows.Add(lblcor_cod.Text, txtnom.Text, txtcontacto.Text, IIf(chkcontatel.Checked = True, "SI", "NO"))
            Else
                FormMantELTBPROVEEDORES.dgvt_tel.Rows(FormMantELTBPROVEEDORES.dgvt_tel.CurrentRow.Index).Cells("TEL_COD").Value = lblcor_cod.Text
                FormMantELTBPROVEEDORES.dgvt_tel.Rows(FormMantELTBPROVEEDORES.dgvt_tel.CurrentRow.Index).Cells("NOM").Value = txtnom.Text
                FormMantELTBPROVEEDORES.dgvt_tel.Rows(FormMantELTBPROVEEDORES.dgvt_tel.CurrentRow.Index).Cells("CONTACTO").Value = txtcontacto.Text
                FormMantELTBPROVEEDORES.dgvt_tel.Rows(FormMantELTBPROVEEDORES.dgvt_tel.CurrentRow.Index).Cells("X_CONT").Value = IIf(chkcontatel.Checked = True, "SI", "NO")
            End If
            txtnom.Text = ""
            txtcontacto.Text = ""
            Me.Close()
        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Function OkData() As Boolean
        If txtnom.Text = "" Then
            MsgBox("Ingrese el Telefono", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If
        Return True
    End Function
End Class