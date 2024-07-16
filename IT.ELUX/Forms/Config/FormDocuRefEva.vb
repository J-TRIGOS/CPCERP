Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDocuRefEva
    Dim ELTBEVALUACIONBL As New ELTBEVALUACIONBL
    Dim ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Dim nro As String
    Public Form As String
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub FormDocuRefEva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvbusqueda.Columns.Add("T_DOC_REF", "TIPO")
        lvbusqueda.Columns.Add("SER_DOC_REF", "SERIE")
        lvbusqueda.Columns.Add("NRO_DOC_REF", "NUMERO")
        lvbusqueda.Columns.Add("PER_COD", "DNI")
        lvbusqueda.Columns.Add("NOM", "CAPACITADOR")
        lvbusqueda.Columns.Add("FECHA", "FECHA")
        lvbusqueda.Columns("NOM").Width = 280
        lvbusqueda.Columns("FECHA").Width = 85
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
        If Form = "capacitacion" Then
            dt = ELTBEVALUACIONBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, 0)
            For Each row As DataRow In dt.Rows
                item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")))
                item.SubItems.Add(IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")))
                item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
            Next
        ElseIf Form = "evaluacion" Then
            dt = ELTBEVALUACIONBL.list1(txtt_doc.Text, txtser_doc.Text, txt_num.Text, 2)
            For Each row As DataRow In dt.Rows
                item = lvbusqueda.Items.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")))
                item.SubItems.Add(IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")))
                item.SubItems.Add(IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")))
                item.SubItems.Add(IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")))
                item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
            Next
        End If
        Label2.Text = 0
    End Sub

    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            Label2.Text += 1
        Else
            Label2.Text -= 1
        End If
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click

        Dim dt As DataTable
        Dim i As Int32 = 0
        Dim cont1 As Integer = 0
        Dim contador As Integer = 0

        If Form = "evaluacion" Then
            If Label2.Text > 1 Then
                MsgBox("Seleccionar solo un item")
                Exit Sub
            End If
            If FormELTBEVALUACION.dgvt_doc.RowCount > 0 Then
                Exit Sub
            End If
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    dt = ELTBEVALUACIONBL.getListdgv1(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text, lvbusqueda.Items(i).SubItems(3).Text)
                    For Each row As DataRow In dt.Rows
                        contador = contador + 1
                        FormELTBEVALUACION.dgvt_doc.Rows.Add(FormELTBEVALUACION.txtt_doc.Text,
                                                             FormELTBEVALUACION.cmb_serdoc.Text,
                                                             FormELTBEVALUACION.txtnumero.Text,
                                                             IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                                             IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                             IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),
                                                             IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")))
                    Next
                End If
            Next
        ElseIf Form = "capacitacion" Then
            If Label2.Text > 1 Then
                MsgBox("Seleccionar solo un item")
                Exit Sub
            End If
            If FormELTBCAPACITACION.dgvt_doc.RowCount > 0 Then
                Exit Sub
            End If
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    dt = ELTBCAPACITACIONBL.getListdgv1(lvbusqueda.Items(i).SubItems(0).Text, lvbusqueda.Items(i).SubItems(1).Text, lvbusqueda.Items(i).SubItems(2).Text)

                    'IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)

                    For Each row As DataRow In dt.Rows
                        contador = contador + 1
                        FormELTBCAPACITACION.txtdni.Text = IIf(IsDBNull(row("PER_COD")), "", row("PER_COD"))
                        FormELTBCAPACITACION.txtTema.Text = IIf(IsDBNull(row("TEMA")), "", row("TEMA"))
                        FormELTBCAPACITACION.txtactivo.Text = IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD"))
                        FormELTBCAPACITACION.cmbTipo.SelectedIndex = IIf(IsDBNull(row("TIPO")), "", row("TIPO"))
                        FormELTBCAPACITACION.txtobserva.Text = IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA"))
                        FormELTBCAPACITACION.dgvt_doc.Rows.Add(FormELTBCAPACITACION.txtt_doc.Text,
                                                              FormELTBCAPACITACION.cmb_serdoc.Text,
                                                              FormELTBCAPACITACION.txtnumero.Text,
                                                               IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                                               IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                                               FormELTBCAPACITACION.txtnumero.Text,
                                                               IIf(IsDBNull(row("PER_COD1")), "", row("PER_COD1")),
                                                               IIf(IsDBNull(row("NOM")), "", row("NOM")),
                                                               IIf(IsDBNull(row("LINEA_COD")), "", row("LINEA_COD")))
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub txt_num_LostFocus(sender As Object, e As EventArgs) Handles txt_num.LostFocus
        If txt_num.TextLength > 0 Then
            nro = txt_num.Text
            If nro.Length = 1 Then
                txt_num.Text = "000000" & nro
            ElseIf nro.Length = 2 Then
                txt_num.Text = "00000" & nro
            ElseIf nro.Length = 3 Then
                txt_num.Text = "0000" & nro
            ElseIf nro.Length = 4 Then
                txt_num.Text = "000" & nro
            ElseIf nro.Length = 5 Then
                txt_num.Text = "00" & nro
            ElseIf nro.Length = 6 Then
                txt_num.Text = "0" & nro
            ElseIf nro.Length = 7 Then
                txt_num.Text = nro
            End If
        Else
            txt_num.Text = ""
        End If
    End Sub
End Class