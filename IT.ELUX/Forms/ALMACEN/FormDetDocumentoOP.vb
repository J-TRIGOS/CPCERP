Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDetDocumentoOP
    Private ELTBDETDOCOPBL As New ELTBDETDOCOPBL

    Private Sub FormDetDocumentoOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie Documento") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero Documento") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Tipo") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Ser. OP") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Nro. OP") '5
        dgvt_doc.Columns.Add("ART_COD", "Articulo") '5
        dgvt_doc.Columns.Add("CANTIDAD", "CANTIDAD") '6
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        dgvt_doc.Columns(3).Visible = False
        'dgvt_doc.Columns(5).Visible = False

        If flagAccion = "N" Then
            cmb_serop.Text = DateTime.Now.Date.Year
        ElseIf flagAccion = "M" Then
            cmb_serop.Text = DateTime.Now.Date.Year

            Dim dtArticulo As DataTable
            dtArticulo = ELTBDETDOCOPBL.SelectRow(lbltdoc.Text, lblsdoc.Text, lblndoc.Text, lblart.Text)
            For Each row As DataRow In dtArticulo.Rows
                dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                          IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                          IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                          IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                          IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                          IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                          IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'6
                                          IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD"))) '7

            Next
        End If
        ''dtArticulo = ELTBDETDOCOPBL.SelectRow("09", lbltdoc.Text, sNDoc, "") 


        cmbarticulo.SelectedIndex = 0
        For l = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
            If FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("ART_COD").Value = cmbarticulo.Text Then
                npdcantidad.Value = FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("CANTIDAD").Value
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtnroop.TextLength > 0 And npdcantidad.Value > 0 Then
            Dim val As String = ""
            If dgvt_doc.Rows.Count > 0 Then
                For j = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(j).Cells("NRO_DOC_REF1").Value = txtnroop.Text Then
                        val = "1"
                    End If
                Next
            End If
            If val = "" Then
                Me.dgvt_doc.Rows.Add(lbltdoc.Text, lblsdoc.Text, lblndoc.Text, "OPRD", cmb_serop.Text, txtnroop.Text, cmbarticulo.Text, npdcantidad.Value)
                txtnroop.Text = ""
                npdcantidad.Value = 0
            Else
                MessageBox.Show("No se puede repetir el nro de OP")
            End If
        Else
            MsgBox("Debe completar el numero de op o la cantidad")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub FormDetDocumentoOP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtnroop_LostFocus(sender As Object, e As EventArgs) Handles txtnroop.LostFocus
        If txtnroop.TextLength > 0 Then
            txtnroop.Text = txtnroop.Text.PadLeft(9, "0")
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        Select Case sFunc
            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub

    Private Sub SaveData()
        Dim ELTBDETDOCOPBE As New ELTBDETDOCOPBE
        ELTBDETDOCOPBE.T_DOC_REF = lbltdoc.Text
        ELTBDETDOCOPBE.SER_DOC_REF = lblsdoc.Text
        ELTBDETDOCOPBE.NRO_DOC_REF = lblndoc.Text

        gsError = ELTBDETDOCOPBL.SaveRow(ELTBDETDOCOPBE, flagAccion, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cmbarticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulo.SelectedIndexChanged
        ' Dim i As Integer = cmbarticulo.SelectedIndex
        ' If cmbarticulo.SelectedIndex <> -1 Then
        '     For Each row As DataGridViewRow In dgvt_doc.Rows
        '         lblnom.Text = dgvt_doc.Rows(i).Cells("NOM_ART").Value
        '         ' txtcantidad.Text = dgvt_doc.Rows(i).Cells("CANTIDAD").Value
        '     Next
        ' End If
        'txtnroop.Text = ""
        Dim ELTBMANTENIMIENTOBL As New ELTBMANTENIMIENTOBL
        Try
            lblnom.Text = ELTBMANTENIMIENTOBL.SelectNom(cmbarticulo.Text)

            For l = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
                If FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("ART_COD").Value = cmbarticulo.Text Then
                    npdcantidad.Value = FormMantGuiaDespacho.dgvt_doc.Rows(l).Cells("CANTIDAD").Value
                End If
            Next

        Catch
            MsgBox("La Maquina Equipo o Articulo no existe")
        End Try
        txtnroop.Text = ""
        ' npdcantidad.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "261"
        gsCode11 = cmbarticulo.Text
        gsCode2 = cmb_serop.Text
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtnroop.Text = gLinea
            '   cmbsublinea.SelectedValue = gSubLinea
            '   cmbart.SelectedValue = gArt
            '   txtcodart.Text = gArt
            '   Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            '   GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            '   txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            '   cmbart.SelectedValue = txtcodart.Text
            '   gLinea = Nothing
            '   gSubLinea = Nothing
            '   gArt = Nothing

        End If
        gLinea = Nothing
        gSubLinea = Nothing
        gArt = Nothing
    End Sub
End Class