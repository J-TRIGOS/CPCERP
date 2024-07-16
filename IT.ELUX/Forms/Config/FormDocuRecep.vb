Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormDocuRecep
    Private gpCaption As String
    Private ELTBDETPERCEPBL As New ELTBDETPERCEPBL
    Private Sub FormDocuRecep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpCaption = "Documento Referencia"
        Me.Text = gpCaption
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim dt As DataTable
        Dim item As ListViewItem
        If chkfecha.Checked Then
            lvbusqueda.Items.Clear()
            dt = ELTBDETPERCEPBL.list2(cmbaño.Text, (cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"), lblruc.Text)
            For Each row As DataRow In dt.Rows
                item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                item.SubItems.Add(IIf(IsDBNull(row("proveedor")), "", row("proveedor")))
                item.SubItems.Add(IIf(IsDBNull(row("NOM_PROVEEDOR")), "", row("NOM_PROVEEDOR")))
                item.SubItems.Add(IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")))
            Next
        Else
            lvbusqueda.Items.Clear()
            dt = ELTBDETPERCEPBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, lblruc.Text)
            For Each row As DataRow In dt.Rows
                item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")))
                item.SubItems.Add(IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")))
                item.SubItems.Add(IIf(IsDBNull(row("proveedor")), "", row("proveedor")))
                item.SubItems.Add(IIf(IsDBNull(row("NOM_PROVEEDOR")), "", row("NOM_PROVEEDOR")))
                item.SubItems.Add(IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")))
            Next
        End If

    End Sub

    Private Sub FormDocuRecep_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim dt As DataTable
        'dt = PROVISIONESBL.getListdgv2(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text, lvbusqueda1.Items(i).SubItems(2).Text)
        'For Each row As DataRow In dt.Rows
        Dim s As Integer = 0
        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked = True Then
                If FormELTBPERCEP.dgvt_doc.Rows.Count > 0 Then
                    For j = 0 To FormELTBPERCEP.dgvt_doc.Rows.Count - 1
                        If FormELTBPERCEP.dgvt_doc.Rows(j).Cells("T_DOC_REF1").Value = lvbusqueda.Items(i).SubItems(0).Text And
                           FormELTBPERCEP.dgvt_doc.Rows(j).Cells("SER_DOC_REF1").Value = lvbusqueda.Items(i).SubItems(1).Text And
                           FormELTBPERCEP.dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = lvbusqueda.Items(i).SubItems(2).Text Then
                            s = s + 1
                        End If

                    Next
                    If s = 0 Then
                        FormELTBPERCEP.dgvt_doc.Rows.Add(FormELTBPERCEP.txttdoc.Text, FormELTBPERCEP.txtsdoc.Text, FormELTBPERCEP.txtndoc.Text,
                                                    lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text,
                                                    lvbusqueda.Items(i).SubItems(3).Text, lvbusqueda.Items(i).SubItems(6).Text)
                    Else
                        MsgBox("El item ya se encuentra listado")
                        Exit Sub
                    End If
                Else
                    FormELTBPERCEP.dgvt_doc.Rows.Add(FormELTBPERCEP.txttdoc.Text, FormELTBPERCEP.txtsdoc.Text, FormELTBPERCEP.txtndoc.Text,
                                                   lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text,
                                                   lvbusqueda.Items(i).SubItems(3).Text, lvbusqueda.Items(i).SubItems(6).Text)
                End If

            End If
        Next

        'Next

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub chkfecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkfecha.CheckedChanged
        If chkfecha.Checked Then
            cmbaño.SelectedItem = sAño
            cmbmes.SelectedIndex = Month(Date.Today) - 1
            cmbaño.Enabled = True
            cmbmes.Enabled = True
        Else
            cmbaño.SelectedIndex = -1
            cmbmes.SelectedIndex = -1
            cmbaño.Enabled = False
            cmbmes.Enabled = False
        End If
    End Sub


End Class