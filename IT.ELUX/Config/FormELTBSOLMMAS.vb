Public Class FormELTBSOLMMAS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvtiemper.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvtiemper.Rows.RemoveAt(dgvtiemper.CurrentRow.Index)
            dgvtiemper.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "3"
        'Dim frm As New FormPerGrupo
        Dim frm As New FormPerGrupoHora
            frm.ShowDialog()
            gsCode10 = ""

    End Sub
End Class