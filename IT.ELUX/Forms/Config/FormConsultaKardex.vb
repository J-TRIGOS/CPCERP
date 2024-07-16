
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormConsultaKardex
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private bprimero As Boolean = True
    Private gpCaption As String
    Private kardex As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sBusAlm = "56"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodart.Text = gLinea
            lbldescripcion.Text = gSubLinea
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
        If gArt = "1" Or gArt = "S" Then
            lblsituacion.ForeColor = Color.FromArgb(31, 126, 33)
            lblsituacion.Text = "SI ESTA CONTEMPLADO KARDEX"
        Else
            If gArt = "" Or gArt = Nothing Then
                btnasignar.Enabled = True
                lblsituacion.ForeColor = Color.FromArgb(255, 51, 51)
                lblsituacion.Text = "NO ESTA CONTEMPLADO KARDEX"
            Else
                btnasignar.Enabled = False
                lblsituacion.ForeColor = Color.FromArgb(255, 51, 51)
                lblsituacion.Text = "NO ESTA CONTEMPLADO KARDEX"
            End If
        End If
        Exit Sub
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown

        If e.KeyValue = Keys.F9 Then
            sBusAlm = "56"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart.Text = gLinea
                lbldescripcion.Text = gSubLinea
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If

            If gArt = "1" Or gArt = "S" Then
                lblsituacion.ForeColor = Color.FromArgb(31, 126, 33)
                lblsituacion.Text = "SI ESTA CONTEMPLADO KARDEX"
            Else
                If gArt = "" Or gArt = Nothing Then
                    btnasignar.Enabled = False
                    lblsituacion.ForeColor = Color.FromArgb(255, 51, 51)
                    lblsituacion.Text = "NO ESTA CONTEMPLADO KARDEX"
                Else
                    btnasignar.Enabled = True
                    lblsituacion.ForeColor = Color.FromArgb(255, 51, 51)
                    lblsituacion.Text = "NO ESTA CONTEMPLADO KARDEX"
                End If
            End If
            e.Handled = True
        End If
        Exit Sub
    End Sub
    Private Sub txtcodart_Leave(sender As Object, e As EventArgs) Handles txtcodart.Leave
        If txtcodart.TextLength > 0 Then
            Dim strarr() As String
            strarr = ARTICULOBL.SelectArt3(txtcodart.Text.Trim).Split("|")
            If ARTICULOBL.SelectArt3(txtcodart.Text.Trim) = "" Then
                MsgBox("No existe el codigo Articulo", MsgBoxStyle.Information)
                txtcodart.Text = ""
                lbldescripcion.Text = ""
                lblsituacion.Text = ""
                btnasignar.Enabled = False
            Else
                lbldescripcion.Text = strarr(0)
                If strarr(1) = "1" Or strarr(1) = "S" Then
                    btnasignar.Enabled = True
                    kardex = ""
                    lblsituacion.ForeColor = Color.FromArgb(31, 126, 33)
                    lblsituacion.Text = "SI ESTA CONTEMPLADO KARDEX"
                Else
                    kardex = "1"
                    btnasignar.Enabled = True
                    lblsituacion.ForeColor = Color.FromArgb(255, 51, 51)
                    lblsituacion.Text = "NO ESTA CONTEMPLADO KARDEX"
                End If
            End If
        Else
            btnasignar.Enabled = False
            lbldescripcion.Text = ""
            lblsituacion.Text = ""
        End If
    End Sub

    Private Sub FormConsultaKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnasignar.Enabled = False
    End Sub

    Private Sub btnasignar_Click(sender As Object, e As EventArgs) Handles btnasignar.Click

        If MessageBox.Show("Esta seguro de Actualiar el Registro",
                           "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        Else
            flagAccion = "MK"
            Dim ELMVLOGSBE As New ELMVLOGSBE
            Dim ARTICULOBE As New ARTICULOBE
            ARTICULOBE.art_cod = Trim(txtcodart.Text)
            ARTICULOBE.x_kardex = kardex
            gsError = ARTICULOBL.SaveRow(ARTICULOBE, flagAccion, ELMVLOGSBE)
            If gsError = "OK" Then
                MsgBox("Se Actualizó el articulo", MsgBoxStyle.Information)
                If kardex = "" Then
                    lblsituacion.ForeColor = Color.FromArgb(255, 51, 51)
                    lblsituacion.Text = "NO ESTA CONTEMPLADO KARDEX"
                Else
                    lblsituacion.ForeColor = Color.FromArgb(31, 126, 33)
                    lblsituacion.Text = "SI ESTA CONTEMPLADO KARDEX"
                End If

                btnasignar.Enabled = False
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Actualizar", MsgBoxStyle.Critical)
            End If
        End If
        Button1.Focus()
    End Sub
End Class