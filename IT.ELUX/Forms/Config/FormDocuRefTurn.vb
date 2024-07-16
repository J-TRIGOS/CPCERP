Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDocuRefTurn
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private ELTBSTURNBL As New ELTBSTURNBL
    Private gdtMainData As DataTable
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub FormDocuRefTurn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable

        dgvbusqueda.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF")
        dgvbusqueda.Columns.Add("FEC_INI", "FEC_INI")
        dgvbusqueda.Columns.Add("FEC_FIN", "FEC_FIN")
        dgvbusqueda.Columns.Add("TIPO", "TIPO")
        dgvbusqueda.Columns.Add("CCO_COD", "CCO_COD")
        dgvbusqueda.Columns.Add("EST", "EST")

        dt = ELTBGRUPOBL.listgrupo
        GetCmb("cod", "nom", dt, cmbcosto)
        cmbccosto.Items.Add("")
        For i = 0 To cmbcosto.Items.Count - 1
            cmbcosto.SelectedIndex = i
            cmbccosto.Items.Add(cmbcosto.Text)
        Next

    End Sub

    Private Sub cmbccosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccosto.SelectedIndexChanged
        '    'dgvbusqueda.Columns.Clear()
        '
        '    Dim dt As DataTable
        '    Dim b As String = "0"
        '    dgvbusqueda.Rows.Clear()
        '    'dgvbusqueda.DataSource = Nothing
        '
        '    dt = ELTBSTURNBL.SearhDocuTurn(Mid(cmbccosto.Text, 1, 4))
        '
        '    For Each row As DataRow In dt.Rows
        '        dgvbusqueda.Rows.Add(
        '             IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
        '             IIf(IsDBNull(row("FEC_INI")), "", row("FEC_INI")),
        '             IIf(IsDBNull(row("FEC_FIN")), "", row("FEC_FIN")),
        '             IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
        '             IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),
        '             IIf(IsDBNull(row("EST")), "", row("EST")))
        '
        '        If dgvbusqueda.Rows(b).Cells("TIPO").Value = 0 Then
        '            dgvbusqueda.Rows(b).Cells("TIPO").Value = "DIA"
        '        Else
        '            dgvbusqueda.Rows(b).Cells("TIPO").Value = "NOCHE"
        '        End If
        '        b = b + 1
        '    Next
    End Sub

    Private Sub FormDocuRefTurn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        '
        'Dim dt As New DataTable
        '
        'FormELTBSTURN.dgvtiemper.Rows.Clear()
        'dt = ELTBSTURNBL.SearhDetTurn(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        '
        'For Each row As DataRow In dt.Rows
        '    FormELTBSTURN.dgvtiemper.Rows.Add(
        '                     IIf(IsDBNull(row("Codigo")), "", row("Codigo")),
        '                     IIf(IsDBNull(row("Nombre")), "", row("Nombre")))
        'Next
        'Dispose()
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
        lvbusqueda1.Items.Clear()
        Dim dt As New DataTable
        Dim item As ListViewItem
        Dim b As Integer = 0
        'dt = ELTBSTURNBL.SearhDetTurn(txtt_doc.Text, txtser_doc.Text, txt_num.Text)
        dt = ELTBSTURNBL.SearhDocuTurn(txtt_doc.Text, txtser_doc.Text, txt_num.Text)

        For Each row As DataRow In dt.Rows
            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("T_doc_ref")), "", row("T_doc_ref")))
            item.SubItems.Add(IIf(IsDBNull(row("SER_doc_ref")), "", row("SER_doc_ref")))
            item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")))
            item.SubItems.Add(IIf(IsDBNull(row("FEC_INI")), "", row("FEC_INI")))
            item.SubItems.Add(IIf(IsDBNull(row("FEC_FIN")), "", row("FEC_FIN")))
            item.SubItems.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")))
            item.SubItems.Add(IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))
            item.SubItems.Add(IIf(IsDBNull(row("EST")), "", row("EST")))

            If lvbusqueda1.Items(b).SubItems(5).Text = "0" Then
                lvbusqueda1.Items(b).SubItems(5).Text = "Dia"
            Else
                lvbusqueda1.Items(b).SubItems(5).Text = "Noche"
            End If
            'If dgvbusqueda.Rows(b).Cells("TIPO").Value = 0 Then
            '    dgvbusqueda.Rows(b).Cells("TIPO").Value = "DIA"
            'Else
            '    dgvbusqueda.Rows(b).Cells("TIPO").Value = "NOCHE"
            'End If
            b = b + 1
        Next


        '     If lvbusqueda.Items(b).SubItems(0).Text = Nothing Then
        '
        '     ElseIf lvbusqueda.Items(b).SubItems(0).Text = 0 Then
        '         lvbusqueda.Items(b).SubItems(0).Text = "Dia"
        '     Else
        '         lvbusqueda.Items(b).SubItems(0).Text = "Noche"
        '     End If
        '     'If dgvbusqueda.Rows(b).Cells("TIPO").Value = 0 Then
        '     '    dgvbusqueda.Rows(b).Cells("TIPO").Value = "DIA"
        '     'Else
        '     '    dgvbusqueda.Rows(b).Cells("TIPO").Value = "NOCHE"
        '     'End If
        '     b = b + 1
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        Dim val As String = "0"
        Dim item As ListViewItem
        Dim dt As New DataTable

        For i = 0 To lvbusqueda1.Items.Count - 1
            If lvbusqueda1.Items(i).Checked = True Then
                dt = ELTBSTURNBL.SearhDetTurn(lvbusqueda1.Items(i).SubItems(2).Text)
                For Each row As DataRow In dt.Rows

                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("codigo")), "", row("codigo")))
                    item.SubItems.Add(IIf(IsDBNull(row("nombre")), "", row("nombre")))

                    For j = 0 To FormELTBSTURN.dgvtiemper.Rows.Count - 1
                        If lvbusqueda.Items(0).SubItems(0).Text = FormELTBSTURN.dgvtiemper.Rows(j).Cells(0).Value Then 'lvbusqueda1.Items(i).SubItems(3).Text
                            val = "1"
                        End If
                    Next
                    If val <> "1" Then
                        FormELTBSTURN.dgvtiemper.Rows.Add(
                                        IIf(IsDBNull(row("Codigo")), "", row("Codigo")),
                                        IIf(IsDBNull(row("Nombre")), "", row("Nombre")))
                    Else
                        val = "0"
                    End If
                    lvbusqueda.Items.Clear()
                Next
            End If
        Next
        Dispose()
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda1.Items.Count - 1
                lvbusqueda1.Items(i).Checked = True
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