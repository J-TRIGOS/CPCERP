Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormOrdenProgramas_Agregar

    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
    Private ELORDEN_PROGRAMBE As New ELORDEN_PROGRAMBE
    Dim dg As DataGridView

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ELMVLOGSBE As New ELMVLOGSBE
        If txtprc_prod.Text = "" Then
            MsgBox("Ingrese el Proceso del artículo", MsgBoxStyle.Exclamation)
            txtprc_prod.Focus()
        Else
            Dim fla As String = flagAccion
            flagAccion = "AA"
            ELORDEN_DET_PROGRAMBE.cod_articulo = Trim(lblcod_art.Text)
            ELORDEN_DET_PROGRAMBE.seq = txtprc_prod.Text
            ELMVLOGSBE.log_codusu = gsCodUsr
            gsError = ELORDEN_PROGRAMBL.SaveRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, flagAccion, dg, ELORDEN_DET_PROGRAMBE)
            flagAccion = fla
            Dispose()
        End If
    End Sub

    Private Sub txtprc_prod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprc_prod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "110"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtprc_prod.Text = gLinea
                lbllin_prod.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub txtprc_prod_LostFocus(sender As Object, e As EventArgs) Handles txtprc_prod.LostFocus
        If (txtprc_prod.Text = "") Then
            lbllin_prod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELORDEN_PROGRAMBL.SelectProcesoCOD(txtprc_prod.Text)
            If dt.Rows.Count > 0 Then
                txtprc_prod.Text = dt.Rows(0).Item(0).ToString
                lbllin_prod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtprc_prod.Text = ""
                lbllin_prod.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gsCode2 = "N"
        gsCode3 = flagAccion
        FormMantELTBPROC.ShowDialog()
        gsCode2 = ""
        flagAccion = gsCode3
        gsCode3 = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "110"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtprc_prod.Text = gLinea
            lbllin_prod.Text = gSubLinea
            gLinea = ""
            gSubLinea = ""
        End If
    End Sub
End Class