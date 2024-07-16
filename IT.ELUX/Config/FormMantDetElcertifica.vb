Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormMantDetElcertifica
    Dim labels As String
    Dim i1 As Integer = 0
    Dim i As Integer = 0
    Public twoE As String

    Private Sub FormMantDetElcertifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBusqueda.Columns.Add("TIPO", "TIPO")
        dgvBusqueda.Columns.Add("SERIE", "SERIE")
        dgvBusqueda.Columns.Add("NUMERO", "NRO. DOCU")
        dgvBusqueda.Columns.Add("PRODUCTO", "PRODUCTO")
        dgvBusqueda.Columns.Add("CANTIDAD", "CANTIDAD")
        dgvBusqueda.Columns.Add("FECHA PRODUCCION", "FEC. PRODUCCION")
        dgvBusqueda.Columns.Add("TURNO", "TURNO")
        dgvBusqueda.Columns.Add("LOTE", "LOTE")
        dgvBusqueda.Columns.Add("CANTIDAD1", "CANTIDAD1")
        dgvBusqueda.Columns.Add("REGISTRO", "REGISTRO")
        dgvBusqueda.Columns("CANTIDAD1").Visible = False
        dgvBusqueda.Columns("REGISTRO").Visible = False
        Me.dgvBusqueda.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv1.Columns.Add("SERIE", "SERIE")
        dgv1.Columns.Add("NUMERO", "NRO. DOCU")
        dgv1.Columns.Add("CANTIDAD", "CANTIDAD")
        dgv1.Columns.Add("TURNO", "TURNO")
        dgv1.Columns.Add("LOTE1", "LOTE1")
        Button4_Click(sender, e)
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Button4_Click(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dgvBusqueda.Rows.Clear()
        dgv1.Rows.Clear()
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        Dim b As String = "0"
        Dim i2 As Integer = 0
        Dim dt As DataTable
        Dim ELCERTIFICABL As New ELCERTIFICABL
        i = 0
        i1 = 0
        If twoE = "N" Then
            dt = ELCERTIFICABL.list1(TextBox4.Text, "12", TextBox3.Text, "N1")
            For Each row As DataRow In dt.Rows

                dgvBusqueda.Rows.Add(
                                 IIf(IsDBNull(row("t_doc_ref")), "", row("t_doc_ref")),
                                 IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")),
                                 IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")),
                                 IIf(IsDBNull(row("art_cod")), "", row("art_cod")),
                                 IIf(IsDBNull(row("cantidad")), "", row("cantidad")),
                                 IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")),
                                 IIf(IsDBNull(row("turno")), "", row("turno")),
                                 IIf(IsDBNull(row("lote1")), "", row("lote1")),
                                 IIf(IsDBNull(row("cantidad1")), "", row("cantidad1")))

                If dgvBusqueda.Rows(b).Cells("cantidad1").Value = Nothing Then
                    dgvBusqueda.Rows(b).Cells("cantidad1").Value = "0"
                Else
                    dgvBusqueda.Rows(b).Cells("cantidad").Value = dgvBusqueda.Rows(b).Cells("cantidad").Value - dgvBusqueda.Rows(b).Cells("cantidad1").Value
                    dgvBusqueda.Rows(b).Cells("cantidad").Value = Format(dgvBusqueda.Rows(b).Cells("cantidad").Value, "0.000")
                End If
                b = b + 1

            Next
            If dgvBusqueda.RowCount <> Nothing Then
                If FormELCERTIFICA.dgvLote.Rows.Count >= 0 Then
                    For i2 = 0 To dgvBusqueda.Rows.Count - 1
                        TextBox6.ReadOnly = False
                        Button2.Enabled = True
                        For j = 0 To FormELCERTIFICA.dgvLote.Rows.Count - 1
                            If dgvBusqueda.Rows(i2).Cells("NUMERO").Value = FormELCERTIFICA.dgvLote.Rows(j).Cells("NUMERO").Value And dgvBusqueda.Rows(i2).Cells("turno").Value = FormELCERTIFICA.dgvLote.Rows(j).Cells("turno").Value And dgvBusqueda.Rows(i2).Cells(1).Value <> Nothing Then
                                dgvBusqueda.Rows(i2).Cells("cantidad").Value = dgvBusqueda.Rows(i2).Cells("cantidad").Value - FormELCERTIFICA.dgvLote.Rows(j).Cells("cantidad").Value
                            End If
                        Next
                    Next
                End If
                If TextBox6.ReadOnly = False Then
                    TextBox5.Text = dgvBusqueda.Rows(i).Cells("cantidad").Value
                Else
                    TextBox5.Text = ""
                End If
            End If
        Else
            dt = ELCERTIFICABL.list1(TextBox4.Text, "12", TextBox3.Text, "N2")
            For Each row As DataRow In dt.Rows
                dgvBusqueda.Rows.Add(
                                     IIf(IsDBNull(row("t_doc_ref")), "", row("t_doc_ref")),
                                     IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")),
                                     IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")),
                                     IIf(IsDBNull(row("art_cod")), "", row("art_cod")),
                                     IIf(IsDBNull(row("cantidad")), "", row("cantidad")),
                                     IIf(IsDBNull(row("fec_gene")), "", row("fec_gene")),
                                     IIf(IsDBNull(row("turno")), "", row("turno")),
                                     IIf(IsDBNull(row("lote1")), "", row("lote1")),
                                     IIf(IsDBNull(row("cantidad1")), "", row("cantidad1")))

                If dgvBusqueda.Rows(b).Cells("cantidad1").Value = Nothing Then
                    dgvBusqueda.Rows(b).Cells("cantidad1").Value = "0"
                Else
                    dgvBusqueda.Rows(b).Cells("cantidad").Value = dgvBusqueda.Rows(b).Cells("cantidad").Value - dgvBusqueda.Rows(b).Cells("cantidad1").Value
                    dgvBusqueda.Rows(b).Cells("cantidad").Value = Format(dgvBusqueda.Rows(b).Cells("cantidad").Value, "0.000")
                End If
                b = b + 1
            Next
            b = "0"
            dt = ELCERTIFICABL.list1(TextBox4.Text, TextBox2.Text, TextBox3.Text, "M1")
            For Each row As DataRow In dt.Rows
                dgv1.Rows.Add(
                                         IIf(IsDBNull(row("ser_doc_ref")), "", row("ser_doc_ref")),
                                         IIf(IsDBNull(row("nro_doc_ref")), "", row("nro_doc_ref")),
                                         IIf(IsDBNull(row("cantidad")), "", row("cantidad")),
                                         IIf(IsDBNull(row("turno")), "", row("turno")),
                                         IIf(IsDBNull(row("lote1")), "", row("lote1")))
            Next
            If dgvBusqueda.RowCount <> Nothing Then
                If dgv1.Rows.Count >= 0 Then
                    For i2 = 0 To dgvBusqueda.Rows.Count - 1
                        For j = 0 To dgv1.Rows.Count - 1
                            If dgvBusqueda.Rows(i2).Cells("NUMERO").Value = dgv1.Rows(j).Cells("NUMERO").Value And dgvBusqueda.Rows(i2).Cells("SERIE").Value = dgv1.Rows(j).Cells("SERIE").Value And dgvBusqueda.Rows(i2).Cells("turno").Value = dgv1.Rows(j).Cells("turno").Value And dgvBusqueda.Rows(i2).Cells("lote").Value = dgv1.Rows(j).Cells("LOTE1").Value Then
                                dgvBusqueda.Rows(i2).Cells("cantidad").Value = dgv1.Rows(j).Cells("cantidad").Value + Val(dgvBusqueda.Rows(i2).Cells("cantidad").Value)
                                dgvBusqueda.Rows(i2).Cells("cantidad").Value = Format(dgvBusqueda.Rows(i2).Cells("cantidad").Value, "0.000")
                                dgvBusqueda.Rows(i2).Cells("REGISTRO").Value = dgv1.Rows(j).Cells("cantidad").Value
                            End If
                        Next
                    Next
                End If
            End If
            TextBox6.ReadOnly = True
            Button2.Enabled = False
            If dgvBusqueda.RowCount <> Nothing Then
                TextBox6.ReadOnly = False
                Button2.Enabled = True
                TextBox5.Text = dgvBusqueda.Rows(i).Cells("cantidad").Value
            End If
        End If
    End Sub

    Private Sub dgvBusqueda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellClick
        i = dgvBusqueda.CurrentRow.Index
        TextBox6.Text = Nothing
        TextBox5.Text = Nothing
        TextBox5.Text = dgvBusqueda.Rows(i).Cells("cantidad").Value
        If i1 <> Nothing And TextBox5.Text <> Nothing Then
            dgvBusqueda.Rows(i).Cells("cantidad").Value = CType(TextBox5.Text, Decimal)
        End If
        i1 = dgvBusqueda.CurrentRow.Index
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim z As Double

        If TextBox6.Text = Nothing And i1 <> i Then
            If TextBox5.Text = Nothing Then
                dgvBusqueda.Rows(i1).Cells("cantidad").Value = Nothing
            Else
                dgvBusqueda.Rows(i1).Cells("cantidad").Value = CType(TextBox5.Text, Decimal) - 0
            End If

        ElseIf TextBox6.Text = Nothing And TextBox5.Text <> Nothing Then
            dgvBusqueda.Rows(i1).Cells("cantidad").Value = CType(TextBox5.Text, Decimal)

        Else
            If TextBox6.Text <> Nothing And TextBox5.Text <> Nothing Then
                z = TextBox5.Text
                If z >= TextBox6.Text Then
                    dgvBusqueda.Rows(i1).Cells("cantidad").Value = CType(TextBox5.Text, Decimal) - CType(TextBox6.Text, Decimal)
                Else
                    MessageBox.Show("Ingresar cantidad menor")

                End If

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim contador As Integer = 0
        Dim val As String = ""
        Dim tr As Integer = -1
        If TextBox6.ReadOnly = False Then
            If twoE = "N" Then
                Dim ELCERTIFICABL As New ELCERTIFICABL
                If dgvBusqueda.CurrentRow.Index > -1 And dgvBusqueda.Rows(i).Cells(1).Value <> Nothing And TextBox5.Text <> Nothing Then
                    i = dgvBusqueda.CurrentRow.Index
                    If FormELCERTIFICA.dgvLote.Rows.Count > 0 Then
                        For j = 0 To FormELCERTIFICA.dgvLote.Rows.Count - 1
                            If dgvBusqueda.Rows(i).Cells("NUMERO").Value = FormELCERTIFICA.dgvLote.Rows(j).Cells("NUMERO").Value And dgvBusqueda.Rows(i).Cells("TURNO").Value = FormELCERTIFICA.dgvLote.Rows(j).Cells("turno").Value Then
                                val = "1"
                            End If
                        Next
                    End If
                    If TextBox5.Text = Nothing Then
                        TextBox5.Text = 0
                    End If
                    If TextBox6.Text = Nothing Then
                        TextBox6.Text = 0
                    End If
                    If val <> "1" And CType(TextBox5.Text, Decimal) >= CType(TextBox6.Text, Decimal) Then
                        FormELCERTIFICA.dgvLote.Rows.Add(
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("TIPO").Value)), "", (dgvBusqueda.Rows(i).Cells("TIPO").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("SERIE").Value)), "", (dgvBusqueda.Rows(i).Cells("SERIE").Value)),
                                IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("NUMERO").Value)), "", (dgvBusqueda.Rows(i).Cells("NUMERO").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("PRODUCTO").Value)), "", (dgvBusqueda.Rows(i).Cells("PRODUCTO").Value)),
                            IIf(IsDBNull((CType(TextBox6.Text, Decimal))), "", (CType(TextBox6.Text, Decimal))),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("FECHA PRODUCCION").Value)), "", (dgvBusqueda.Rows(i).Cells("FECHA PRODUCCION").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("TURNO").Value)), "", (dgvBusqueda.Rows(i).Cells("TURNO").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("LOTE").Value)), "", (dgvBusqueda.Rows(i).Cells("LOTE").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("cantidad1").Value)), "", (dgvBusqueda.Rows(i).Cells("cantidad1").Value)))
                        TextBox5.Text = CType(TextBox5.Text, Decimal) - CType(TextBox6.Text, Decimal)
                        TextBox6.Text = Nothing
                        TextBox5.Text = Nothing
                        'Button2.Enabled = False
                        'TextBox6.ReadOnly = True
                    ElseIf TextBox6.Text > dgvBusqueda.Rows(i).Cells("cantidad").Value And val <> "1" Then
                        MessageBox.Show("Ingresar cantidad menor")
                    Else
                        val = ""
                        MessageBox.Show("Lote repetido")
                    End If
                Else
                    MessageBox.Show("Ingresar Cantidad")
                End If
            Else
                If dgvBusqueda.CurrentRow.Index > -1 And dgvBusqueda.Rows(i).Cells(1).Value <> Nothing And TextBox6.Text <> Nothing Then
                    i = dgvBusqueda.CurrentRow.Index

                    If FormELCERTIFICA.dgvLote.Rows.Count >= 0 Then
                        For j = 0 To FormELCERTIFICA.dgvLote.Rows.Count - 1
                            If tr = -1 Then
                                If dgvBusqueda.Rows(i).Cells("NUMERO").Value = FormELCERTIFICA.dgvLote.Rows(j).Cells("NUMERO").Value And dgvBusqueda.Rows(i).Cells("turno").Value = FormELCERTIFICA.dgvLote.Rows(j).Cells("turno").Value Then
                                    tr = j
                                    FormELCERTIFICA.dgvLote.Rows.RemoveAt(FormELCERTIFICA.dgvLote.Rows(j).Index)
                                End If
                            End If
                        Next
                    End If
                    If CType(TextBox5.Text, Decimal) >= CType(TextBox6.Text, Decimal) Then
                        FormELCERTIFICA.dgvLote.Rows.Add(
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("TIPO").Value)), "", (dgvBusqueda.Rows(i).Cells("TIPO").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("SERIE").Value)), "", (dgvBusqueda.Rows(i).Cells("SERIE").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("NUMERO").Value)), "", (dgvBusqueda.Rows(i).Cells("NUMERO").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("PRODUCTO").Value)), "", (dgvBusqueda.Rows(i).Cells("PRODUCTO").Value)),
                            IIf(IsDBNull((CType(TextBox6.Text, Decimal))), "", (CType(TextBox6.Text, Decimal))),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("FECHA PRODUCCION").Value)), "", (dgvBusqueda.Rows(i).Cells("FECHA PRODUCCION").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("TURNO").Value)), "", (dgvBusqueda.Rows(i).Cells("TURNO").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("LOTE").Value)), "", (dgvBusqueda.Rows(i).Cells("LOTE").Value)),
                            IIf(IsDBNull((dgvBusqueda.Rows(i).Cells("cantidad1").Value)), "", (dgvBusqueda.Rows(i).Cells("cantidad1").Value)))
                        If tr > -1 Then
                            TextBox5.Text = CType(TextBox5.Text, Decimal) - CType(TextBox6.Text, Decimal) '+ FormELCERTIFICA.dgvLote.Rows(tr).Cells("Cantidad").Value
                        Else
                            TextBox5.Text = CType(TextBox5.Text, Decimal) - CType(TextBox6.Text, Decimal)
                        End If
                        TextBox6.Text = Nothing
                        TextBox5.Text = Nothing
                        'TextBox6.ReadOnly = True
                        'Button2.Enabled = False
                    Else
                        MessageBox.Show("Ingresar cantidad menor")
                    End If

                Else
                    MessageBox.Show("Ingresar Cantidad")
                End If

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub FormMantDetElcertifica_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class