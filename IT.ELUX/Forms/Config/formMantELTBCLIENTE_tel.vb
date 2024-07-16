Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Public Class formMantELTBCLIENTE_tel
    Private ELTBCLIENTEBL As New ELTBCLIENTEBL
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        If OkData() = False Then
            Exit Sub
        Else
            If flagAccion1 = "N" Then

                If FormMantELTBCLIENTE.dgvt_tel.Rows.Count > 0 Then
                    FormMantELTBCLIENTE.dgvt_tel.Rows.Add(lblcor_cod.Text, txtnom.Text, txtcontacto.Text, IIf(chkcontatel.Checked = True, "SI", "NO"), txtobservacion.Text, npdlineacredito.Text, npdlineadol.Text)
                    For i As Integer = 0 To FormMantELTBCLIENTE.dgvt_tel.Rows.Count - 1
                        FormMantELTBCLIENTE.dgvt_tel.Rows(i).Cells("L_CREDITO").Value = npdlineacredito.Text
                        FormMantELTBCLIENTE.dgvt_tel.Rows(i).Cells("L_DCREDITO").Value = npdlineadol.Text
                    Next
                Else
                    FormMantELTBCLIENTE.dgvt_tel.Rows.Add(lblcor_cod.Text, txtnom.Text, txtcontacto.Text, IIf(chkcontatel.Checked = True, "SI", "NO"), txtobservacion.Text, npdlineacredito.Text, npdlineadol.Text)
                End If
            Else
                    FormMantELTBCLIENTE.dgvt_tel.Rows(FormMantELTBCLIENTE.dgvt_tel.CurrentRow.Index).Cells("TEL_COD").Value = lblcor_cod.Text
                FormMantELTBCLIENTE.dgvt_tel.Rows(FormMantELTBCLIENTE.dgvt_tel.CurrentRow.Index).Cells("NOM").Value = txtnom.Text
                FormMantELTBCLIENTE.dgvt_tel.Rows(FormMantELTBCLIENTE.dgvt_tel.CurrentRow.Index).Cells("CONTACTO").Value = txtcontacto.Text
                FormMantELTBCLIENTE.dgvt_tel.Rows(FormMantELTBCLIENTE.dgvt_tel.CurrentRow.Index).Cells("X_CONT").Value = IIf(chkcontatel.Checked = True, "SI", "NO")
                FormMantELTBCLIENTE.dgvt_tel.Rows(FormMantELTBCLIENTE.dgvt_tel.CurrentRow.Index).Cells("OBSERVACION").Value = txtobservacion.Text
                For i As Integer = 0 To FormMantELTBCLIENTE.dgvt_tel.Rows.Count - 1
                    FormMantELTBCLIENTE.dgvt_tel.Rows(i).Cells("L_CREDITO").Value = npdlineacredito.Text
                    FormMantELTBCLIENTE.dgvt_tel.Rows(i).Cells("L_DCREDITO").Value = npdlineadol.Text
                Next

            End If
            txtnom.Text = ""
            txtcontacto.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Function OkData() As Boolean
        If txtnom.Text = "" Then
            MsgBox("Ingrese el Telefono", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub formMantELTBCLIENTE_tel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (FormMantELTBCLIENTE.flagAccion = "N") Then
            npdlineacredito.Text = 0.00
            'Else
            '    If flagAccion1 <> "M" Then
            '        Dim strarr() As String
            '        strarr = ELTBCLIENTEBL.VerificarLinea(FormMantELTBCLIENTE.txtruc.Text.Trim).Split("|")
            '        If strarr(0) = "" Then
            '            npdlineacredito.Text = 0.00
            '        Else
            '            npdlineacredito.Text = strarr(0).Trim
            '            npdlineadol.Text = strarr(1).Trim
            '        End If
            '    End If

        End If
    End Sub

    Private Sub npdlineacredito_Leave(sender As Object, e As EventArgs) Handles npdlineacredito.Leave
        If npdlineacredito.Text <> "" Then
            npdlineacredito.Text = Format(Val(CDec(npdlineacredito.Text)), "##,##0.00")
        Else
            npdlineacredito.Text = 0
        End If
    End Sub

    Private Sub npdlineadol_Leave(sender As Object, e As EventArgs) Handles npdlineadol.Leave
        If npdlineadol.Text <> "" Then
            npdlineadol.Text = Format(Val(CDec(npdlineadol.Text)), "##,##0.00")
        Else
            npdlineadol.Text = 0
        End If
    End Sub
    Private Sub npdlineacredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles npdlineacredito.KeyPress, npdlineadol.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
End Class