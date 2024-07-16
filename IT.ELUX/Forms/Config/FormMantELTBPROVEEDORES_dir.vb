Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormMantELTBPROVEEDORES_dir

    Private ELTBCLIENTEBL As New ELTBCLIENTEBL

    Private Sub btn_ubigeo_Click(sender As Object, e As EventArgs) Handles btn_ubigeo.Click
        sBusAlm = "44"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()

        lblubigeodir.Text = gLinea
        lbldistritodir.Text = gSubLinea
        lblprovinciadir.Text = gArt
    End Sub

    Private Sub btncancelardir_Click(sender As Object, e As EventArgs) Handles btncancelardir.Click
        Me.Close()
    End Sub

    Private Sub btnaceptardir_Click(sender As Object, e As EventArgs) Handles btnaceptardir.Click
        If OkData() = False Then
            Exit Sub
        Else
            If flagAccion1 = "N" Then
                FormMantELTBPROVEEDORES.dgvt_dir.Rows.Add(lblseqdir.Text, txtdirdir.Text, lblprovinciadir.Text,
                                              lbldistritodir.Text, lblprovinciadir.Text, lblubigeodir.Text, IIf(chkcontadir.Checked = True, "SI", "NO"))
            Else
                FormMantELTBPROVEEDORES.dgvt_dir.Rows(FormMantELTBPROVEEDORES.dgvt_dir.CurrentRow.Index).Cells("DIR_COD").Value = lblseqdir.Text
                FormMantELTBPROVEEDORES.dgvt_dir.Rows(FormMantELTBPROVEEDORES.dgvt_dir.CurrentRow.Index).Cells("NOM").Value = txtdirdir.Text
                FormMantELTBPROVEEDORES.dgvt_dir.Rows(FormMantELTBPROVEEDORES.dgvt_dir.CurrentRow.Index).Cells("UBIGEO").Value = lblubigeodir.Text
                FormMantELTBPROVEEDORES.dgvt_dir.Rows(FormMantELTBPROVEEDORES.dgvt_dir.CurrentRow.Index).Cells("DISTRITO").Value = lbldistritodir.Text
                FormMantELTBPROVEEDORES.dgvt_dir.Rows(FormMantELTBPROVEEDORES.dgvt_dir.CurrentRow.Index).Cells("PROV").Value = lblprovinciadir.Text
                FormMantELTBPROVEEDORES.dgvt_dir.Rows(FormMantELTBPROVEEDORES.dgvt_dir.CurrentRow.Index).Cells("X_CONT").Value = IIf(chkcontadir.Checked = True, "SI", "NO")
            End If
            txtdirdir.Text = ""
            lblubigeodir.Text = ""
            lbldistritodir.Text = ""
            lblprovinciadir.Text = ""
            Me.Close()
        End If
    End Sub

    Private Function OkData() As Boolean
        If txtdirdir.Text = "" Then
            MsgBox("Ingrese la Direccion", MsgBoxStyle.Exclamation)
            txtdirdir.Focus()
            Return False
        End If
        If FormMantELTBCLIENTE.chkextranjero.Checked = False Then
            If lblubigeodir.Text = "" Then
                MsgBox("Ingrese el Ubigeo", MsgBoxStyle.Exclamation)
                btn_ubigeo.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub lblubigeodir_Leave(sender As Object, e As EventArgs)
        If lblubigeodir.Text = "" Then
            lbldistritodir.Text = ""
            lblprovinciadir.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBCLIENTEBL.SelectUbigeoCod(lblubigeodir.Text)
            If dt.Rows.Count > 0 Then
                lblubigeodir.Text = dt.Rows(0).Item(0).ToString
                lbldistritodir.Text = dt.Rows(0).Item(1).ToString
                lblprovinciadir.Text = dt.Rows(0).Item(2).ToString
            Else
                lblubigeodir.Text = ""
                lbldistritodir.Text = ""
                lblprovinciadir.Text = ""
            End If
        End If
    End Sub

    Private Sub FormMantELTBPROVEEDORES_dir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class