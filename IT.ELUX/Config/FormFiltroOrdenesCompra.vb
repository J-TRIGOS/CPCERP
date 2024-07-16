﻿Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormFiltroOrdenesCompra
    'Private ARTICULOBL As New ARTICULOBL
    'Private ELETIQUETABL As New ELETIQUETABL
    'Private ELTBTAREOBL As New ELTBTAREOBL
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private ELETIQUETABL As New ELETIQUETABL
    'Private REQUERIMIENTOBL As New REQUERIMIENTOBL

    Private Sub GenerarFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpiar()
    End Sub
    Sub limpiar()
        'cmbanho.SelectedItem = DateTime.Now.ToString("yyyy")
        cmbanho.SelectedIndex = -1
        cmbmes.SelectedIndex = -1
        'cmbmes.SelectedIndex = DateTime.Now.Month - 1
        'cmbpendie.SelectedIndex = 1
    End Sub

    Private Sub txtruc_LostFocus(sender As Object, e As EventArgs) Handles txtruc.LostFocus
        If (txtruc.Text = "") Then
            lblruc.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectProveedorCOD(txtruc.Text)
            If dt.Rows.Count > 0 Then
                txtruc.Text = dt.Rows(0).Item(0).ToString
                lblruc.Text = dt.Rows(0).Item(1).ToString
            Else
                txtruc.Text = ""
                lblruc.Text = ""
            End If
        End If
    End Sub

    Private Sub txtruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtruc.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "98"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtruc.Text = gLinea
                lblruc.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim var1, var2, var4, var5, var7, var6, var3 As String

        If cmbanho.SelectedIndex = -1 Or cmbanho.SelectedIndex = 0 Then
            var1 = " "
        Else
            var1 = cmbanho.SelectedItem
        End If

        If cmbmes.SelectedIndex = -1 Or cmbmes.SelectedIndex = 0 Then
            var2 = " "
        Else
            var2 = (cmbmes.SelectedIndex).ToString.PadLeft(2, "0")
        End If

        If txt_serie.Text = "" Then
            var4 = " "
        Else
            var4 = txt_serie.Text
        End If
        If txtnomart1.Text = "" Then
            var3 = " "
        Else
            var3 = txtnomart1.Text
        End If
        If txtnro.Text = "" Then
            var5 = " "
        Else
            var5 = txtnro.Text
        End If

        If txtruc.Text = "" Then
            var7 = " "
        Else
            var7 = txtruc.Text
        End If

        If txtartcod.Text = "" Then
            var6 = " "
        Else
            var6 = txtartcod.Text
        End If

        Dim dt As New DataTable
        If FormMain.cmbaño.SelectedIndex <> -1 And FormMain.cmbmes.SelectedIndex <> -1 Then
            'dt = PROVISIONESBL.SelectProvAll(FormMain.cmbaño.SelectedItem, (FormMain.cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
            dt = ORDENCOMPRABL.SelectComAllFiltro(var1, var2, var4, var5, var7, var6, var3)
            'dt = REQUERIMIENTOBL.SelectComAllFiltro(var1, var2, var4, var5, var7, var6)
            FormMain.dgvt2.DataSource = dt
            FormMain.gdtMainData = dt
            FormMain.dgvt2.Refresh()
            'FormMain.dgvMain.CurrentCell = Nothing
            'FormMain.gHeader(FormMain.dgvMain)
            FormMain.tsbCamposSeek.Items.Add("NRO")
            FormMain.tsbCamposSeek.Items.Add("CODIGO")
            FormMain.tsbCamposSeek.Items.Add("ARTICULO")
            FormMain.tsbCamposSeek.Items.Add("FEC_GENE")
            FormMain.tsbCamposSeek.Items.Add("ESTADO")

            FormMain.lblRecNo.Text = FormMain.dgvt2.Rows.Count
        End If
    End Sub

    Private Sub txtartcod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtartcod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "250"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtartcod.Text = gLinea
                txtnomart.Text = gSubLinea
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub FormFiltroOrdenesCompra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtartcod_LostFocus(sender As Object, e As EventArgs) Handles txtartcod.LostFocus
        If (txtartcod.Text = "") Then
            txtnomart.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtartcod.Text)
            If dt.Rows.Count > 0 Then
                txtartcod.Text = dt.Rows(0).Item(0).ToString
                txtnomart.Text = dt.Rows(0).Item(1).ToString
                'Label5.Text = txtfam_Cod.Text
            Else
                txtartcod.Text = ""
                txtnomart.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "250"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtartcod.Text = gLinea
            txtnomart.Text = gSubLinea
            gLinea = ""
            gSubLinea = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "98"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtruc.Text = gLinea
            lblruc.Text = gSubLinea
        End If
    End Sub
End Class