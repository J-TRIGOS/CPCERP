Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormBusFechProv
    Public fec As Date
    Public fec2 As Date
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private Sub FormBusFechProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cambiar Fecha de Provision"
        dgv.Columns.Add("NRO_DOC_REF", "Numero") '0
        dgv.Columns.Add("ctct_cod", "Codigo") '1
        dgv.Columns.Add("nom", "nom") '2
        dgv.Columns.Add("fec_prov", "fec_prov") '3
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = False Then
                    lvbusqueda.Items(i).Checked = True
                End If

            Next
        Else
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    lvbusqueda.Items(i).Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label2.Text <> 0 Then
            If MessageBox.Show("Desea Cambiar la Fecha",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            dgv.Rows.Clear()
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    dgv.Rows.Add(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                    dgv.Refresh()
                End If
            Next
            chkmarcar.Checked = False
            Dim ORDENCOMPRABE As New ORDENCOMPRABE
            Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ORDENCOMPRABE.FEC_PROV = dtpfecha1.Value
            gsError = ORDENCOMPRABL.SaveRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, "PROV", dgv)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If

            Dim frm As New FormFiltroFecha
            Dim dt As DataTable
            Dim item As ListViewItem
            dt = ORDENCOMPRABL.lv_fec(fec, fec2)
            lvbusqueda.Items.Clear()
            Label2.Text = 0
            For Each row As DataRow In dt.Rows
                item = lvbusqueda.Items.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                item.SubItems.Add(IIf(IsDBNull(row("FEC_PROV")), "", row("FEC_PROV")))
            Next
            If lvbusqueda.Items.Count = 0 Then
                MsgBox("No hay Ordenes Pendientes con esta fecha")
            End If

        Else
            MsgBox("No ah seleccionado ninguna fecha de Provsion para cambiar")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub FormBusFechProv_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class