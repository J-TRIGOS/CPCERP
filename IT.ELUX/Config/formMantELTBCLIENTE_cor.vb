Public Class formMantELTBCLIENTE_cor
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        If OkData() = False Then
            Exit Sub
        Else
            If flagAccion1 = "N" Then
                FormMantELTBCLIENTE.dgvt_cor.Rows.Add(lblcor_cod.Text, txtnom.Text, txtcontacto.Text,
                                             txtcargo.Text, txttelefono.Text)
            Else
                FormMantELTBCLIENTE.dgvt_cor.Rows(FormMantELTBCLIENTE.dgvt_cor.CurrentRow.Index).Cells("COR_COD").Value = lblcor_cod.Text
                FormMantELTBCLIENTE.dgvt_cor.Rows(FormMantELTBCLIENTE.dgvt_cor.CurrentRow.Index).Cells("NOM").Value = txtnom.Text
                FormMantELTBCLIENTE.dgvt_cor.Rows(FormMantELTBCLIENTE.dgvt_cor.CurrentRow.Index).Cells("CONTACTO").Value = txtcontacto.Text
                FormMantELTBCLIENTE.dgvt_cor.Rows(FormMantELTBCLIENTE.dgvt_cor.CurrentRow.Index).Cells("CARGO").Value = txtcargo.Text
                FormMantELTBCLIENTE.dgvt_cor.Rows(FormMantELTBCLIENTE.dgvt_cor.CurrentRow.Index).Cells("TELEFONO").Value = txttelefono.Text
                'FormMantELTBCLIENTE.dgvt_cor.Rows(FormMantELTBCLIENTE.dgvt_cor.CurrentRow.Index).Cells("X_CONT").Value = IIf(chkcontacor.Checked = True, "SI", "NO")
            End If
        End If

        txtnom.Text = ""
        txtcontacto.Text = ""
        txtcargo.Text = ""
        txttelefono.Text = ""

        Me.Close()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Function OkData() As Boolean
        If txtnom.Text = "" Then
            MsgBox("Ingrese el Correo", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If
        Return True
    End Function
End Class