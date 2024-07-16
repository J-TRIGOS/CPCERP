Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDocuRefLtBanco
    Private LETRASBL As New LETRASBL
    Private Sub FormDocuRefLtBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Letras Banco"
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        lvbusqueda1.Items.Clear()
        Dim dt As DataTable
        Dim item As ListViewItem
        Dim var1, var2, var3 As String
        If dtpfecha.Checked Then
            Dim fec As Date = Nothing
            fec = dtpfecha.Value

            dt = LETRASBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, fec)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                    'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                    item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                    item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                    item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM_MONEDA")), "", row("NOM_MONEDA")))
                    item.SubItems.Add(IIf(IsDBNull(row("PRECIO")), "", row("PRECIO")))
                Next
            End If
        Else
            dt = LETRASBL.list2(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                    'item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                    item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                    item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_rEF")))
                    item.SubItems.Add(IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCTC")), "", row("NOM_CTCTC")))
                    item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM_MONEDA")), "", row("NOM_MONEDA")))
                    item.SubItems.Add(IIf(IsDBNull(row("PRECIO")), "", row("PRECIO")))
                Next
            End If
        End If

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormDocuRefLtBanco_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim contador As Integer = 0
        For i = 0 To lvbusqueda1.Items.Count - 1
            If lvbusqueda1.Items(i).Checked = True Then
                FormLetrasBanco.dgvt_doc.Rows.Add(lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                             lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text,
                                             lvbusqueda1.Items(i).SubItems(4).Text, lvbusqueda1.Items(i).SubItems(5).Text,
                                             lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(7).Text)
            End If
        Next
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items.Item(i).ForeColor = Color.Red Or lvbusqueda1.Items.Item(i).ForeColor = Color.Yellow Then
                    lvbusqueda1.Items(i).Checked = False
                Else
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

    Private Sub lvbusqueda1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda1.ItemCheck
        'Dim dt As DataTable
        Dim contador As Integer = 0
        If FormLetrasBanco.dgvt_doc.Rows.Count > 0 Then
            If lvbusqueda1.Items(e.Index).Checked = True Then
                Exit Sub
            Else
                For i = 0 To FormLetrasBanco.dgvt_doc.Rows.Count - 1
                    If FormLetrasBanco.dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = lvbusqueda1.Items(e.Index).SubItems(2).Text Then
                        'lvbusqueda1.Items(e.Index).Checked = False
                        MsgBox("Este Documento ya se encuentra listado")
                        Exit Sub
                    End If
                Next
            End If
        End If

        FormLetrasBanco.dgvt_doc.Rows.Add(lvbusqueda1.Items(e.Index).SubItems(0).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(1).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(2).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(3).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(4).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(5).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(6).Text,
                                          lvbusqueda1.Items(e.Index).SubItems(7).Text)
    End Sub
End Class