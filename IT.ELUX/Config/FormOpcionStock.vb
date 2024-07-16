Public Class FormOpcionStock
    Public sublinea As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rdbsi.Checked Then
            gnOpcion3 = "S"
            FormMain.cAlm = cmbalmacen.SelectedIndex
            Dispose()
        ElseIf rdbno.Checked Then
            gnOpcion3 = "N"
            FormMain.cAlm = cmbalmacen.SelectedIndex
            Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gnOpcion3 = Nothing
        Dispose()
    End Sub

    Private Sub FormOpcionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Opcion de Busqueda"
        If sublinea = 1 Then
            'If FormMain.cmblinea.SelectedValue = "0200" And FormMain.cmbsublinea.SelectedValue = "0216" Then
            Label6.Visible = True
                cmbalmacen.Visible = True
                GroupBox1.Height = 105
            'If FormMain.cmbalmacen.SelectedIndex = 0 Then
            '    cmbalmacen.SelectedIndex = 1
            'ElseIf FormMain.cmbalmacen.SelectedIndex = 1 Then
            '    cmbalmacen.SelectedIndex = 2
            'ElseIf FormMain.cmbalmacen.SelectedIndex = 2 Then
            '    cmbalmacen.SelectedIndex = 3
            'End If
            cmbalmacen.SelectedIndex = 0
            'End If
            sublinea = Nothing
        End If
    End Sub
End Class