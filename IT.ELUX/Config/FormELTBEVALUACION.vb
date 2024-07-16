Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.IO
Public Class FormELTBEVALUACION
    Dim ELTBEVALUACIONBL As New ELTBEVALUACIONBL

    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable

        dtUsuario = ELTBEVALUACIONBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))

            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            dtpfec.Text = IIf(IsDBNull(Registro("FEC_DIA")), "", Registro("FEC_DIA"))

            Select Case Registro("EST").ToString
                Case 0
                    cmbestado.SelectedIndex = 0
                Case 1
                    cmbestado.SelectedIndex = 1
                    tsbGrabar.Enabled = False
                    tsbimprimir.Enabled = False
                Case 2
                    cmbestado.SelectedIndex = 2
                    cmbestado.Enabled = False
            End Select
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If

            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
        Next


    End Sub
    Private Sub FormELTBEVALUACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "EVALUACION"

        dgvt_doc.Columns.Add("T_DOC_REF", "Documento")     '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie")       '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero")      '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento")    '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie")      '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero")     '5
        dgvt_doc.Columns.Add("PER_COD", "Nro. Dni.")       '6
        dgvt_doc.Columns.Add("RPTA1", "Respuesta 1")       '7
        dgvt_doc.Columns.Add("RPTA2", "Respuesta 2")       '8
        dgvt_doc.Columns.Add("RPTA3", "Respuesta 3")       '9
        dgvt_doc.Columns.Add("EVA_CAPA", "Eva_capa")       '10
        dgvt_doc.Columns.Add("ENT_CAPA", "Ent_capa")       '11
        dgvt_doc.Columns.Add("CAPA_NUE", "Capa_nue")       '12
        dgvt_doc.Columns.Add("SURGERENCIA", "Surgerencia") '13
        dgvt_doc.Columns.Add("COMENTARIOS", "comentarios") '14
        dgvt_doc.Columns.Add("NOT_CAPA", "Not_capa")       '15
        dgvt_doc.Columns.Add("NOT_EVA", "nota")            '16

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtt_doc.Text = "TEVA"
                cmbt_doc.SelectedIndex = 0
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                cmbt_doc.SelectedIndex = 0
                Dim dtCapacitados As DataTable
                dtCapacitados = ELTBEVALUACIONBL.getListdgv(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dtCapacitados.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),'6
                                      IIf(IsDBNull(row("RPTA1")), "", row("RPTA1")),'7
                                      IIf(IsDBNull(row("RPTA2")), "", row("RPTA2")),'8
                                      IIf(IsDBNull(row("RPTA3")), "", row("RPTA3")),'9
                                      IIf(IsDBNull(row("EVA_CAPA")), "", row("EVA_CAPA")),'10
                                      IIf(IsDBNull(row("ENT_CAPA")), "", row("ENT_CAPA")),'11
                                      IIf(IsDBNull(row("CAPA_NUE")), "", row("CAPA_NUE")),'12
                                      IIf(IsDBNull(row("SURGERENCIA")), "", row("SURGERENCIA")),'13
                                      IIf(IsDBNull(row("COMENTARIOS")), "", row("COMENTARIOS")),'14
                                      IIf(IsDBNull(row("NOT_CAPA")), "", row("NOT_CAPA")),'15
                                      IIf(IsDBNull(row("NOT_EVA")), "", row("NOT_EVA"))) '16
                Next
        End Select

        dgvt_doc.Columns("RPTA1").Visible = False
        dgvt_doc.Columns("RPTA2").Visible = False
        dgvt_doc.Columns("RPTA3").Visible = False
        dgvt_doc.Columns("EVA_CAPA").Visible = False
        dgvt_doc.Columns("ENT_CAPA").Visible = False
        dgvt_doc.Columns("CAPA_NUE").Visible = False
        dgvt_doc.Columns("SURGERENCIA").Visible = False
        dgvt_doc.Columns("COMENTARIOS").Visible = False
        dgvt_doc.Columns("NOT_CAPA").Visible = False
        'dgvt_doc.Columns("NOT_EVA").Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FormDocuRefEva
        frm.txtt_doc.ReadOnly = True
        frm.txtt_doc.Text = "CSEG"
        frm.txtser_doc.Text = "001"
        frm.Form = "evaluacion"
        frm.ShowDialog()
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Dim nro As String
        txtnumero.Text = ""
        nro = ELTBEVALUACIONBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
        If nro.Length = 1 Then
            txtnumero.Text = "000000" & nro
        ElseIf nro.Length = 2 Then
            txtnumero.Text = "00000" & nro
        ElseIf nro.Length = 3 Then
            txtnumero.Text = "0000" & nro
        ElseIf nro.Length = 4 Then
            txtnumero.Text = "000" & nro
        ElseIf nro.Length = 5 Then
            txtnumero.Text = "00" & nro
        ElseIf nro.Length = 6 Then
            txtnumero.Text = "0" & nro
        ElseIf nro.Length = 7 Then
            txtnumero.Text = nro
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "228"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtdni.Text = gLinea
            txtnom.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvt_doc.RowCount > 0 Then
            Dim frm As New FormMantDetEvaluacion
            frm.tipo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
            frm.ser = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            frm.nro = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            'frm.nro = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PER_COD").Value
            frm.txtrpta1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("RPTA1").Value
            frm.rpta2.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("RPTA2").Value
            frm.rpta3.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("RPTA3").Value
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = Nothing Then
                frm.chkM.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = 0 Then
                frm.chkR.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = 1 Then
                frm.chkR.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = 2 Then
                frm.chkB.Checked = True
            End If
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ENT_CAPA").Value = Nothing Then
                frm.chkS.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ENT_CAPA").Value = 0 Then
                frm.chkN.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ENT_CAPA").Value = 1 Then
                frm.chkN.Checked = True
            End If
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CAPA_NUE").Value = Nothing Then
                frm.chkSi.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CAPA_NUE").Value = 0 Then
                frm.chkNo.Checked = True
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CAPA_NUE").Value = 1 Then
                frm.chkNo.Checked = True
            End If
            frm.sgcia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SURGERENCIA").Value
            frm.cmtro.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("COMENTARIOS").Value
            frm.npdNoEva.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOT_CAPA").Value)
            frm.npdNoCap.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOT_EVA").Value)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()
        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If

        Select Case sFunc
            Case "save"
                SaveData()
                Exit Sub
            'Case "delete"
            '    DeleteData()

            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                If flagAccion = "M" Then
                    For z = 0 To dgvt_doc.Rows.Count - 1
                        If dgvt_doc.Rows(z).Cells("NOT_EVA").Value <> Nothing Then
                            gsRptArgs = {}
                            ReDim gsRptArgs(3)
                            gsRptArgs(0) = txtt_doc.Text
                            gsRptArgs(1) = cmb_serdoc.Text
                            gsRptArgs(2) = txtnumero.Text
                            gsRptArgs(3) = dgvt_doc.Rows(z).Cells("PER_COD").Value
                            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ELTBEVALUACION.rpt"
                            gsRptPath = gsPathRpt
                            FormReportes.ShowDialog()
                        End If
                    Next
                End If

            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                   "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim ELTBEVALUACIONBE As New ELTBEVALUACIONBE

                ELTBEVALUACIONBE.T_DOC_REF = txtt_doc.Text
                ELTBEVALUACIONBE.SER_DOC_REF = cmb_serdoc.Text
                ELTBEVALUACIONBE.NRO_DOC_REF = txtnumero.Text

                gsError = ELTBEVALUACIONBL.SaveRow(ELTBEVALUACIONBE, "A", dgvt_doc)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

                    tsbGrabar.Enabled = False
                    tsbimprimir.Enabled = False
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

        End Select
    End Sub
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If OkData() = False Then
            Exit Sub
        End If
        Try
            Dim ELTBEVALUACIONBE As New ELTBEVALUACIONBE
            If flagAccion = "N" Then
                Dim nro As String
                txtnumero.Text = ""
                nro = ELTBEVALUACIONBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
                If nro.Length = 1 Then
                    txtnumero.Text = "000000" & nro
                ElseIf nro.Length = 2 Then
                    txtnumero.Text = "00000" & nro
                ElseIf nro.Length = 3 Then
                    txtnumero.Text = "0000" & nro
                ElseIf nro.Length = 4 Then
                    txtnumero.Text = "000" & nro
                ElseIf nro.Length = 5 Then
                    txtnumero.Text = "00" & nro
                ElseIf nro.Length = 6 Then
                    txtnumero.Text = "0" & nro
                ElseIf nro.Length = 7 Then
                    txtnumero.Text = nro
                End If
            End If

            ELTBEVALUACIONBE.T_DOC_REF = RTrim(txtt_doc.Text)
            ELTBEVALUACIONBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            ELTBEVALUACIONBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            ELTBEVALUACIONBE.FEC_GENE = RTrim(dtpfecha.Value)
            ELTBEVALUACIONBE.EST = cmbestado.SelectedIndex

            ELTBEVALUACIONBE.EVALUADOR = txtdni.Text
            ELTBEVALUACIONBE.OBSERVA = txtobserva.Text
            ELTBEVALUACIONBE.FECHA = RTrim(dtpfec.Text)

            ELTBEVALUACIONBE.T_DOC_REF1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
            ELTBEVALUACIONBE.SER_DOC_REF1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            ELTBEVALUACIONBE.NRO_DOC_REF1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value


            gsError = ELTBEVALUACIONBL.SaveRow(ELTBEVALUACIONBE, flagAccion, dgvt_doc)
            If gsError = "OK" Then

                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                flagAccion = "M"
                Dispose()

            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function OkData() As Boolean
        If txtnom.Text = "" Then
            MsgBox("Ingresar evaluador", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmbestado.SelectedValue = 1 Then
            MsgBox("El registro esta anulado", MsgBoxStyle.Exclamation)
            txtdni.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub FormELTBEVALUACION_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged
        If Len(txtdni.Text) = 8 Then
            txtnom.Text = ""
            If txtdni.Text = "" Then
                txtnom.Text = ""
                Exit Sub
            End If
            txtnom.Text = ELTBEVALUACIONBL.SelectNroDni(txtdni.Text)
            If txtnom.Text = "" Then
                MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
                txtdni.Text = ""

            End If
        End If
    End Sub
End Class