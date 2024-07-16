Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetEvaluacion
    Public tipo As String
    Public ser As String
    Public nro As String
    Private Sub chkM_CheckedChanged(sender As Object, e As EventArgs) Handles chkM.CheckedChanged
        If chkM.Checked Then
            chkR.Checked = False
            chkB.Checked = False
        Else
            chkM.Checked = False
        End If
    End Sub
    Private Sub chkR_CheckedChanged(sender As Object, e As EventArgs) Handles chkR.CheckedChanged
        If chkR.Checked Then
            chkM.Checked = False
            chkB.Checked = False
        Else
            chkR.Checked = False
        End If
    End Sub
    Private Sub chkB_CheckedChanged(sender As Object, e As EventArgs) Handles chkB.CheckedChanged
        If chkB.Checked Then
            chkM.Checked = False
            chkR.Checked = False
        Else
            chkB.Checked = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles chkS.CheckedChanged
        If chkS.Checked Then
            chkN.Checked = False
        End If
    End Sub
    Private Sub chkN_CheckedChanged(sender As Object, e As EventArgs) Handles chkN.CheckedChanged
        If chkN.Checked Then
            chkS.Checked = False
        End If
    End Sub
    Private Sub chkSi_CheckedChanged(sender As Object, e As EventArgs) Handles chkSi.CheckedChanged
        If chkSi.Checked Then
            chkNo.Checked = False
        End If
    End Sub
    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        If chkNo.Checked Then
            chkSi.Checked = False
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
    Private Sub FormMantDetEvaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormMantDetEvaluacion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub SaveData()

        If OkData() = False Then
            Exit Sub
        End If
        Try
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("RPTA1").Value = txtrpta1.Text
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("RPTA2").Value = rpta2.Text
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("RPTA3").Value = rpta3.Text
            If chkM.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = 0
            ElseIf chkR.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = 1
            ElseIf chkB.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("EVA_CAPA").Value = 2
            End If
            If chkS.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("ENT_CAPA").Value = 0
            ElseIf chkN.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("ENT_CAPA").Value = 1
            End If
            If chkSi.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("CAPA_NUE").Value = 0
            ElseIf chkNo.Checked = True Then
                FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("CAPA_NUE").Value = 1
            End If
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("SURGERENCIA").Value = sgcia.Text
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("COMENTARIOS").Value = cmtro.Text
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("NOT_CAPA").Value = npdNoEva.Value
            FormELTBEVALUACION.dgvt_doc.Rows(FormELTBEVALUACION.dgvt_doc.CurrentRow.Index).Cells("NOT_EVA").Value = npdNoCap.Value
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function OkData() As Boolean
        If txtrpta1.Text = "" Then
            MsgBox("Ingresar respuesta 1", MsgBoxStyle.Exclamation)
            Return False
        End If
        If rpta2.Text = "" Then
            MsgBox("Ingresar respuesta 2", MsgBoxStyle.Exclamation)
            Return False
        End If
        If rpta3.Text = "" Then
            MsgBox("Ingresar respuesta 3", MsgBoxStyle.Exclamation)
            Return False
        End If
        If sgcia.Text = "" Then
            MsgBox("Ingresar surgerencia", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmtro.Text = "" Then
            MsgBox("Ingresar comentario", MsgBoxStyle.Exclamation)
            Return False
        End If
        If npdNoEva.Text = "" Then
            MsgBox("Ingresar nota de evaluación", MsgBoxStyle.Exclamation)
            Return False
        End If
        If npdNoCap.Text = "" Then
            MsgBox("Ingresar nota de capacitación", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

End Class