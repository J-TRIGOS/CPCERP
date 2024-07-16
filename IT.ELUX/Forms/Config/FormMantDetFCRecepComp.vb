Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetFCRecepComp
    Private ELTBRECEPCOMPBL As New ELTBRECEPCOMPBL

    Private Sub FormMantDetFCRecepComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Detalle Recepcion"
        If gnOpcion2 = 0 Then
            txtnro_doc_ref1.Enabled = True
            cmbser_doc_ref1.Enabled = True
        Else
            cmbser_doc_ref1.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtproveedor.Text = gLinea
                txtnom_proveedor.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcodart.Text = gLinea
                txtnom_art.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtproveedor.Text = "" Then
            MsgBox("Ingrese el proveedor")
            Exit Sub
        End If
        If txtcodart.Text = "" Then
            MsgBox("Ingrese el articulo")
            Exit Sub
        End If
        If txtser_docu.TextLength > 0 And txtnro_docu.TextLength > 0 Then
            If cmbt_doc.SelectedIndex = -1 Then
                MsgBox("Seleccione el tipo de documento")
                Exit Sub
            End If
        End If


        If gnOpcion2 = 0 Then
            Dim s As String
            If cmbt_doc.SelectedIndex = 0 Then
                s = "01"
            ElseIf cmbt_doc.SelectedIndex = 1 Then
                s = "03"
            ElseIf cmbt_doc.SelectedIndex = 2 Then
                s = "07"
            ElseIf cmbt_doc.SelectedIndex = 3 Then
                s = "08"
            End If
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("CTCT_COD").Value = txtproveedor.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("NOM_CTCT").Value = txtnom_proveedor.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value = txtcodart.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = txtnom_art.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = s
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("SER_DOCU").Value = txtser_docu.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU").Value = txtnro_docu.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("SER_DOCU1").Value = txtser_docu1.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value = txtnro_docu1.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value = cmbser_doc_ref1.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text
            'FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("FEC_GENE").Value = dtpfec_gene.Value
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = npdcantidad.Value
            FormMantFCRecepComp.dgvt_doc.Rows(FormMantFCRecepComp.dgvt_doc.CurrentRow.Index).Cells("EST").Value = "0"
            FormMantFCRecepComp.Label6.Text = FormMantFCRecepComp.dgvt_doc.Rows.Count
        ElseIf gnOpcion2 = 1 Then
            Dim s As String
            If cmbt_doc.SelectedIndex = 0 Then
                s = "01"
            ElseIf cmbt_doc.SelectedIndex = 1 Then
                s = "03"
            ElseIf cmbt_doc.SelectedIndex = 2 Then
                s = "07"
            ElseIf cmbt_doc.SelectedIndex = 3 Then
                s = "08"
            End If
            FormMantFCRecepComp.dgvt_doc.Rows.Add(FormMantFCRecepComp.txtt_doc_ref.Text, '0
                                                  FormMantFCRecepComp.cmb_serdoc.Text,'1
                                                  FormMantFCRecepComp.txtnro_doc_ref.Text, '2
                                                  "OREQ", '3
                                                  cmbser_doc_ref1.Text,'4
                                                  txtnro_doc_ref1.Text, '5
                                                  s, '6
                                                  txtser_docu.Text, '6
                                                  txtnro_docu.Text,'7
                                                  txtser_docu1.Text, '8
                                                  txtnro_docu1.Text,'9
                                                  txtproveedor.Text,'10
                                                  txtnom_proveedor.Text,'11
                                                  npdcantidad.Value,'12
                                                  txtcodart.Text,'13
                                                  txtnom_art.Text,'14
                                                  dtpfec_gene.Value) '15
            'FormMantFCRecepComp.Label6.Text = FormMantFCRecepComp.dgvt_doc.Rows.Count
        End If
        Dispose()
    End Sub

    Private Sub FormMantDetFCRecepComp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtnro_docu_LostFocus(sender As Object, e As EventArgs) Handles txtnro_docu.LostFocus
        Dim num As String = ELTBRECEPCOMPBL.VerNum(txtnro_docu.Text, txtser_docu.Text, txtproveedor.Text)
        If num <> FormMantFCRecepComp.txtnro_doc_ref.Text Then
            If num.Length > 0 Then
                If MessageBox.Show("Este facura se encuentra listada en el numero: " & num & " Desea Continuar?",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    txtnro_docu.Focus()
                    Exit Sub
                End If
                'MsgBox(")

            End If
        End If
    End Sub

    Private Sub txtnro_docu_TextChanged(sender As Object, e As EventArgs) Handles txtnro_docu.TextChanged
        If flagAccion = "N" Then
            If txtser_docu.TextLength = 0 Then
                MsgBox("Debe Ingresar primero la serie")
                txtnro_docu.Text = ""
                txtser_docu.Focus()
                Exit Sub
            End If
        End If

    End Sub
End Class