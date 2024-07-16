Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDirDep
    Dim PERBL As New PERBL
    Private Sub FormDirDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Direccion Dependiente"
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDirDep_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If gArt = "0" Then
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("tip_via_cod").Value = txttip_via_cod.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("nom_via").Value = txtnom_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("nro_via").Value = txtnro_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("nro_dpto").Value = txtnro_dpto.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("int_via").Value = txtint_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("mza_via").Value = txtmza_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("lote_via").Value = txtlote_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("kilom_via").Value = txtkilom_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("block_via").Value = txtblock_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("etapa_via").Value = txtetapa_via.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("tip_zona_cod").Value = txttip_zona_cod.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("nom_zona").Value = txtnom_zona.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("ref_zona").Value = txtref_zona.Text
            FormMantPersonal.dgvdirdep.Rows(FormMantPersonal.dgvdirdep.CurrentRow.Index).Cells("ubigeo").Value = txtubigeo.Text
            Dispose()
        Else
            FormMantPersonal.dgvdirdep.Rows.Add(txtcod.Text, txttip_via_cod.Text, txtnom_via.Text, txtnro_via.Text, txtnro_dpto.Text, txtint_via.Text,
                                             txtmza_via.Text, txtlote_via.Text, txtkilom_via.Text, txtblock_via.Text, txtetapa_via.Text, txttip_zona_cod.Text,
                                             txtnom_zona.Text, txtref_zona.Text, txtubigeo.Text)
            Dispose()
        End If
    End Sub

    Private Sub txttip_via_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txttip_via_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "80"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txttip_via_cod.Text = gLinea
                txtnom_via.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txttip_via_cod_LostFocus(sender As Object, e As EventArgs) Handles txttip_via_cod.LostFocus
        If txttip_via_cod.Text <> "" Then
            txtnom_via.Text = PERBL.SelPerViaRow(txttip_via_cod.Text)
        Else
            txtnom_via.Text = ""
        End If
    End Sub

    Private Sub txttip_zona_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txttip_zona_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "81"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txttip_via_cod.Text = gLinea
                txtnom_via.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txttip_zona_cod_LostFocus(sender As Object, e As EventArgs) Handles txttip_zona_cod.LostFocus
        If txttip_zona_cod.Text <> "" Then
            txtnom_zona.Text = PERBL.SelPerZonaRow(txttip_zona_cod.Text)
        Else
            txtnom_zona.Text = ""
        End If
    End Sub
End Class