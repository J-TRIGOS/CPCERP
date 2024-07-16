Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRVEI
    Private ELTBPERCEPBL As New ELTBPERCEPBL
    Private PROVISIONESBL As New PROVISIONESBL


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sBusAlm = "105"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtctct_cod.Text = gLinea
            txtnomctct.Text = gSubLinea
            'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtctct_cod_LostFocus(sender As Object, e As EventArgs) Handles txtctct_cod.LostFocus
        If txtctct_cod.TextLength > 0 Then
            If PROVISIONESBL.SelectT_Prov(txtctct_cod.Text).Length = 0 Then
                txtnomctct.Text = ""
            Else
                txtnomctct.Text = PROVISIONESBL.SelectT_Prov(txtctct_cod.Text)
            End If

        Else
            txtnomctct.Text = ""
        End If
    End Sub

    Private Sub txtctct_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtctct_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "105"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtctct_cod.Text = gLinea
                txtnomctct.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
    End Sub

End Class