Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormAsignarFamilia

    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private ARTICULOBL As New ARTICULOBL
    Private bprimero As Boolean = True
    Private gpCaption As String
    Dim dt As DataTable

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "56"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart.Text = gLinea
                lbldescripcion.Text = gSubLinea
                BuscarFamilia(gLinea)
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True

        End If
        gLinea = Nothing
        gSubLinea = Nothing
    End Sub

    Sub BuscarFamilia(ByVal articulo As String)
        dt = ELETIQUETABL.BuscarFamArt(articulo)
        If dt.Rows.Count > 0 Then
            txtfam_Cod.Text = dt.Rows(0).Item(0).ToString
            lblfam_cod.Text = dt.Rows(0).Item(1).ToString
            Label5.Text = txtfam_Cod.Text
        Else
            txtfam_Cod.Text = ""
            lblfam_cod.Text = ""
        End If
    End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If (txtcodart.Text = "") Then
            lbldescripcion.Text = ""
            txtfam_Cod.Text = ""
            lblfam_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcodart.Text)
            If dt.Rows.Count > 0 Then
                txtcodart.Text = dt.Rows(0).Item(0).ToString
                lbldescripcion.Text = dt.Rows(0).Item(1).ToString
                BuscarFamilia(txtcodart.Text)
                Label5.Text = txtfam_Cod.Text
            Else
                txtcodart.Text = ""
                lbldescripcion.Text = ""
            End If
        End If
    End Sub
    Private Sub txtfam_Cod_LostFocus(sender As Object, e As EventArgs) Handles txtfam_Cod.LostFocus
        If (txtfam_Cod.Text = "") Then
            lblfam_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectFamiliaCOD(txtfam_Cod.Text)
            If dt.Rows.Count > 0 Then
                txtfam_Cod.Text = dt.Rows(0).Item(0).ToString
                lblfam_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtfam_Cod.Text = ""
                lblfam_cod.Text = ""
            End If
        End If
    End Sub
    Private Sub txtfam_Cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfam_Cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "116"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtfam_Cod.Text = gLinea
                lblfam_cod.Text = gSubLinea
            Else
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtcodart.Text = "" Then
            MsgBox("Ingrese el codigo de artículo", MsgBoxStyle.Exclamation)
            txtcodart.Focus()
        Else
            If MessageBox.Show("Desea actualizar la Familia",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If

            flagAccion = "MF"
            Dim ELMVLOGSBE As New ELMVLOGSBE
            Dim ARTICULOBE As New ARTICULOBE
            ARTICULOBE.art_cod = Trim(txtcodart.Text)
            ARTICULOBE.fam1 = txtfam_Cod.Text
            ARTICULOBE.fam2 = Label5.Text
            ELMVLOGSBE.log_codusu = gsCodUsr
            gsError = ARTICULOBL.SaveRow(ARTICULOBE, flagAccion, ELMVLOGSBE)
            If gsError = "OK" Then
                MsgBox("Articulo Actualizado", MsgBoxStyle.Information)
            Else
                FormMain.LblError.Text = gsError2
                MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub FormAsignarFamilia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

End Class