Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuRefDet
    Private gpCaption As String
    Private ELTBDETRACCIONBL As New ELTBDETRACCIONBL
    Private Sub FormDocuRefDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpCaption = "Documento Referencia"
        Me.Text = gpCaption
    End Sub
    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
    End Sub
    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If lvbusqueda.Visible = True Then
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
        ElseIf lvbusqueda.Visible = True Then
            If chkmarcar.Checked Then
                For i = 0 To lvbusqueda.Items.Count - 1
                    If lvbusqueda.Items.Item(i).ForeColor = Color.Red Or lvbusqueda.Items.Item(i).ForeColor = Color.Yellow Then
                        lvbusqueda.Items(i).Checked = False
                    Else
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
        End If

    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub txtt_doc_TextChanged(sender As Object, e As EventArgs) Handles txtt_doc.TextChanged
        If txtt_doc.TextLength > 0 Then
            chktipo.Checked = True
        Else
            chktipo.Checked = False
        End If
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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim dt As DataTable
        Dim item As ListViewItem
        lvbusqueda.Items.Clear()
        dt = ELTBDETRACCIONBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, txt_prov.Text)
        For Each row As DataRow In dt.Rows
            item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
            item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
            item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
            item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
            item.SubItems.Add(IIf(IsDBNull(row("proveedor")), "", row("proveedor")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM_PROVEEDOR")), "", row("NOM_PROVEEDOR")))
        Next
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim dt As DataTable
        Dim i As Int32 = 0
        Dim cont1 As Integer = 0
        Dim contador As Integer = 0
        ' Dim item As ListViewItem
        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked = True Then
                dt = ELTBDETRACCIONBL.getListdgv1(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text, lvbusqueda.Items(i).SubItems(5).Text)
                For Each row As DataRow In dt.Rows
                    contador = contador + 1
                    FormELTBDETRACCION.dgvt_doc.Rows.Add(FormELTBDETRACCION.txtt_doc.Text, FormELTBDETRACCION.cmb_serdoc.Text,
                                                 FormELTBDETRACCION.txtnumero.Text, IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                                 IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")), IIf(IsDBNull(row("NOM_CTCT")), "", row("NOM_CTCT")),
                                                 IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")),
                                                 IIf(IsDBNull(row("MONTO_PAGADO")), 0, row("MONTO_PAGADO")), IIf(IsDBNull(row("porcentaje")), 0, row("porcentaje")), IIf(IsDBNull(row("PROGRAMA")), "", row("PROGRAMA")),
                                                 IIf(IsDBNull(row("FARDO")), "", row("FARDO")), IIf(IsDBNull(row("CTA_CBCO")), "", row("CTA_CBCO")), IIf(IsDBNull(row("TOTAL")), 0, row("TOTAL")))
                Next
            End If
        Next

    End Sub
End Class