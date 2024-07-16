Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuRefRecep
    Private ARTICULOBL As New ARTICULOBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private LETRASBL As New LETRASBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELTBRECEPCOMPBL As New ELTBRECEPCOMPBL

    Private Sub FormDocuRefRecep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Filtrado de Ordenes de Compra"
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDocuRefRecep_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim dt As DataTable
        Dim item As ListViewItem
        dt = ELTBRECEPCOMPBL.list1("OREQ", txtser_doc.Text, txt_num.Text)
        For Each row As DataRow In dt.Rows
            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))  '0
            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))                         '1
            item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))         '2
            item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))         '3
            item.SubItems.Add(IIf(IsDBNull(row("art_cod")), "", row("art_cod")))                 '4
            item.SubItems.Add(IIf(IsDBNull(row("nom_art")), "", row("nom_art")))                 '5
            item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))               '6
            item.SubItems.Add(IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))                 '7
            item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))               '8
            item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCT")), "", row("NOM_CTCT")))               '9
            item.SubItems.Add(IIf(IsDBNull(row("EST")), "", row("EST")))                         '10
            item.SubItems.Add(IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")))               '11
            item.SubItems.Add(IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")))                 '12
            item.SubItems.Add(IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")))                 '13
            item.SubItems.Add(IIf(IsDBNull(row("SREQ")), "", row("SREQ")))                       '14
            item.SubItems.Add(IIf(IsDBNull(row("NREQ")), "", row("NREQ")))                       '15
            item.SubItems.Add(IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")))                   '16
            item.SubItems.Add(IIf(IsDBNull(row("ART_VENTA")), "", row("ART_VENTA")))             '17
            item.SubItems.Add(IIf(IsDBNull(row("CT")), "", row("CT")))             '18
            item.SubItems.Add(IIf(IsDBNull(row("ART_PRECIO")), "", row("ART_PRECIO")))             '19
            item.SubItems.Add(IIf(IsDBNull(row("ART_PRECIOPROM")), "", row("ART_PRECIOPROM")))             '20
            item.SubItems.Add(IIf(IsDBNull(row("ART_PRECIOPROMN")), "", row("ART_PRECIOPROMN")))             '21
        Next
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim s As Integer = 0
        Dim dt As DataTable
        Dim contador As Integer = 0
        For i = 0 To lvbusqueda1.Items.Count - 1
            If lvbusqueda1.Items(i).Checked = True Then
                'dt = ELTBRECEPCOMPBL.getListdgv1(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text)
                'For Each row As DataRow In dt.Rows
                s = 0
                For l = 0 To FormMantFCRecepComp.dgvt_doc.Rows.Count - 1
                    If FormMantFCRecepComp.dgvt_doc.Rows(l).Cells("ART_COD").Value = lvbusqueda1.Items(i).SubItems(4).Text Then 'IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) Then 14
                        s = s + 1
                    End If
                Next
                If s = 0 Then
                    contador = contador + 1
                    FormMantFCRecepComp.dgvt_doc.Rows.Add(FormMantFCRecepComp.txtt_doc_ref.Text, FormMantFCRecepComp.cmb_serdoc.Text, FormMantFCRecepComp.txtnro_doc_ref.Text,
                                                 "OREQ", lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text,
                                                 "", "", "", "", "",'10
                                                 lvbusqueda1.Items(i).SubItems(8).Text, lvbusqueda1.Items(i).SubItems(9).Text,
                                                 lvbusqueda1.Items(i).SubItems(11).Text, lvbusqueda1.Items(i).SubItems(4).Text,'14
                                                 lvbusqueda1.Items(i).SubItems(5).Text, FormMantFCRecepComp.dtpfec_gene.Value,
                                                 lvbusqueda1.Items(i).SubItems(7).Text, lvbusqueda1.Items(i).SubItems(12).Text,'18
                                                 lvbusqueda1.Items(i).SubItems(19).Text, lvbusqueda1.Items(i).SubItems(20).Text,'20
                                                 lvbusqueda1.Items(i).SubItems(21).Text, '21
                                                 lvbusqueda1.Items(i).SubItems(13).Text, lvbusqueda1.Items(i).SubItems(14).Text,
                                                 lvbusqueda1.Items(i).SubItems(15).Text, lvbusqueda1.Items(i).SubItems(16).Text,
                                                 lvbusqueda1.Items(i).SubItems(17).Text, "", lvbusqueda1.Items(i).SubItems(18).Text)
                    'Next
                End If
            End If
        Next
        FormMantFCRecepComp.Label6.Text = contador
    End Sub

    Private Sub txtser_doc_TextChanged(sender As Object, e As EventArgs) Handles txtser_doc.TextChanged
        If txtser_doc.TextLength > 0 Then
            chkser.Checked = True
        Else
            chkser.Checked = False
        End If
    End Sub

    Private Sub txt_num_TextChanged(sender As Object, e As EventArgs) Handles txt_num.TextChanged
        If txt_num.TextLength > 0 Then
            chknum.Checked = True
        Else
            chknum.Checked = False
        End If
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = False Then
                    lvbusqueda1.Items(i).Checked = True
                End If

            Next
        Else
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = True Then
                    lvbusqueda1.Items(i).Checked = False
                End If
            Next
        End If
    End Sub
End Class