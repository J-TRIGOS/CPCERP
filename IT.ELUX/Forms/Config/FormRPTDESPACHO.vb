Imports System.ComponentModel

Public Class FormRPTDESPACHO
    Private Sub FormRPTDESPACHO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormRPTDESPACHO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente.Text = gLinea
            txtNomCliente.Text = gSubLinea
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnArticulo.Click
        sBusAlm = "122"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gArt <> Nothing And gSubLinea <> Nothing Then
            txtCodArt.Text = gArt
            txtNomArt.Text = gSubLinea
            gArt = Nothing
            gSubLinea = Nothing
        Else
            gArt = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rs As String
        gsRptArgs = {}
        ReDim gsRptArgs(3)
        gsRptArgs(0) = TextBox1.Text
        gsRptArgs(1) = txtCodArt.Text
        gsRptArgs(2) = txtcliente.Text
        gsRptArgs(3) = Format(dtpfecini.Value, "dd/MM/yyyy")
        rs = Format(dtpfecini.Value, "dd/MM/yyyy")
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ELTBDESPACHO_DOCU.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text = "" Then
            txtNomCliente.Text = ""
        End If
    End Sub

    Private Sub txtCodArt_TextChanged(sender As Object, e As EventArgs) Handles txtCodArt.TextChanged
        If txtCodArt.Text = "" Then
            txtNomArt.Text = ""
        End If
    End Sub
End Class