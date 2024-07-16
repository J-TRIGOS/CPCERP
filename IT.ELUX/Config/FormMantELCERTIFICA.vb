Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormMantELCERTIFICA
    Dim flagAccion As String

    Private Sub FormMantELCERTIFICA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormELCERTIFICA.dgvControl.RowCount <> Nothing Then
            cbxEspe.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("ESPESOR").Value
            txtTemp.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("TEMPLE").Value
            cbxDiam.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIAMETRO").Value
            cbxTraTer.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("TRATAMIENTO TERMICO").Value
            txtRecTer.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("RECUBRIMIENTO INTERIOR").Value
            cbxMod.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("MODELO").Value
            txtTapBul.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("CANTIDAD TAPAS BULTO").Value
            txtDiaExt1.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIAMETRO EXTERIOR").Value
            txtDiaInt.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIAMETRO INTERIOR").Value
            txtDiaUña.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIAMETRO ENTRE UÑAS").Value
            txtAltExt.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("ALTURA DE EXTERIOR").Value
            txtNvl1.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("NIVEL DE VACIO").Value
            nudSegCie.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("SEGURIDAD DE CIERRE").Value
            txto1.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIA_EXT_MEN").Value
            txtm1.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIA_EXT_MAY").Value
            txto2.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIA_INT_MEN").Value
            txtm2.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIA_INT_MAY").Value
            txto3.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIA_UNIA_MEN").Value
            txtm3.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("DIA_UNIA_MAY").Value
            txto4.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("ALT_EXT_MEN").Value
            txtm4.Text = FormELCERTIFICA.dgvControl.Rows("0").Cells("ALT_EXT_MAY").Value
        End If
    End Sub
    Private Sub cabezera(e As KeyPressEventArgs)
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cbxEspe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEspe.KeyPress
        cabezera(e)
    End Sub

    Private Sub cbxMod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxMod.KeyPress
        cabezera(e)
    End Sub
    Private Sub cbxDiam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxDiam.KeyPress
        cabezera(e)
    End Sub
    Private Sub cbxDiam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDiam.SelectedIndexChanged
        If cbxDiam.Text = "58" Then
            txtTapBul.Text = "1500"
        ElseIf cbxDiam.Text = "63" Then
            txtTapBul.Text = "1200"
        ElseIf cbxDiam.Text = "70" Then
            txtTapBul.Text = "1000"
        ElseIf cbxDiam.Text = "77" Then
            txtTapBul.Text = "850"
        ElseIf cbxDiam.Text = "82" Then
            txtTapBul.Text = "650"
        End If
    End Sub

    Private Sub cbxTraTer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTraTer.KeyPress
        cabezera(e)
    End Sub

    Private Sub txto1_ValueChanged(sender As Object, e As EventArgs) Handles txto1.ValueChanged
        txtp1.Text = (txto1.Value + txtm1.Value) / 2
    End Sub

    Private Sub txto2_ValueChanged(sender As Object, e As EventArgs) Handles txto2.ValueChanged
        txtp2.Text = (txto2.Value + txtm2.Value) / 2
    End Sub

    Private Sub txto3_ValueChanged(sender As Object, e As EventArgs) Handles txto3.ValueChanged
        txtp3.Text = (txto3.Value + txtm3.Value) / 2
    End Sub

    Private Sub txto4_ValueChanged(sender As Object, e As EventArgs) Handles txto4.ValueChanged
        txtp4.Text = (txto4.Value + txtm4.Value) / 2
    End Sub

    Private Sub txtm1_ValueChanged(sender As Object, e As EventArgs) Handles txtm1.ValueChanged
        txtp1.Text = (txto1.Value + txtm1.Value) / 2
    End Sub

    Private Sub txtm2_ValueChanged(sender As Object, e As EventArgs) Handles txtm2.ValueChanged
        txtp2.Text = (txto2.Value + txtm2.Value) / 2
    End Sub

    Private Sub txtm3_ValueChanged(sender As Object, e As EventArgs) Handles txtm3.ValueChanged
        txtp3.Text = (txto3.Value + txtm3.Value) / 2
    End Sub

    Private Sub txtm4_ValueChanged(sender As Object, e As EventArgs) Handles txtm4.ValueChanged
        txtp4.Text = (txto4.Value + txtm4.Value) / 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saf As String

        If FormELCERTIFICA.dgvControl.RowCount <> Nothing Then
            saf = FormELCERTIFICA.dgvControl.Rows("0").Cells("saf").Value
        End If
        FormELCERTIFICA.dgvControl.Rows.Clear()
        FormELCERTIFICA.dgvControl.Rows.Add(cbxEspe.Text, txtTemp.Text, cbxDiam.Text, cbxTraTer.Text, txtRecTer.Text, cbxMod.Text, txtTapBul.Text, txtDiaExt1.Text, txtDiaInt.Text, txtDiaUña.Text, txtAltExt.Text, txtNvl1.Text, nudSegCie.Text, txtp1.Text, txtp2.Text, txtp3.Text, txtp4.Text, saf, txto1.Text, txtm1.Text, txto2.Text, txtm2.Text, txto3.Text, txtm3.Text, txto4.Text, txtm4.Text)

        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub
End Class