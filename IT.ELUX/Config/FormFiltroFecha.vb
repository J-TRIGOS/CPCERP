Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormFiltroFecha
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub FormFiltroFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Buscar Fechas de Provision"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfecha1.Value = dtFecha
    End Sub

    Private Sub FormFiltroFecha_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FormBusFechProv
        Dim dt As DataTable
        Dim item As ListViewItem
        Dim fec As Date = Nothing
        Dim fec2 As Date = Nothing
        fec = dtpfecha1.Value
        fec2 = dtpfecha2.Value
        dt = ORDENCOMPRABL.lv_fec(fec, fec2)
        For Each row As DataRow In dt.Rows
            item = frm.lvbusqueda.Items.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
            item.SubItems.Add(IIf(IsDBNull(row("FEC_PROV")), "", row("FEC_PROV")))
        Next
        If frm.lvbusqueda.Items.Count > 0 Then
            frm.fec = dtpfecha1.Value
            frm.fec2 = dtpfecha2.Value
            frm.ShowDialog()
        Else
            MsgBox("No hay Ordenes Pendientes con esta fecha")
        End If

    End Sub
End Class