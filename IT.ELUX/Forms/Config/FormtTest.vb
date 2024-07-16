Imports IT.ELUX.BL


Public Class FormtTest

    Dim primero As Boolean

    Private ARTICULOBL As New ARTICULOBL

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub FormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True

        Dim dt As New DataTable

        dt = ARTICULOBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbcentrocosto)

        primero = False
    End Sub


    Private Sub txtcodcco_LostFocus(sender As Object, e As EventArgs) Handles txtcodcco.LostFocus
        If txtcodcco.Text = "" Then
            cmbcentrocosto.SelectedValue = ""
            Exit Sub
        End If
        cmbcentrocosto.SelectedValue = txtcodcco.Text
        If cmbcentrocosto.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtcodcco.Text = ""
        End If
    End Sub

    Private Sub cmbcentrocosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcentrocosto.SelectedIndexChanged
        If primero Then
            Exit Sub
        End If
        If cmbcentrocosto.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtcodcco.Text = cmbcentrocosto.SelectedValue
    End Sub

End Class