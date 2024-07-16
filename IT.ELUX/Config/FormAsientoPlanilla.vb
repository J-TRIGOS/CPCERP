Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormAsientoPlanilla
    Private PERBL As New PERBL
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If

            Select Case sFunc

                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If txtndoc.Text = "" Or txttdoc.Text = "" Or npdtcmb.Value = 0 Then
            MsgBox("Ingrese todos los valores")
            Exit Sub
        End If
        Dim fla As String = ""
        If rdbplan.Checked Then
            fla = "PLAN"
        End If
        If rdbgra.Checked Then
            fla = "GRA"
        End If
        If rdbcts.Checked Then
            fla = "CTS"
        End If
        If rdbvaca.Checked Then
            fla = "VACA"
        End If
        gsError = PERBL.InsAsPlan(txttdoc.Text, cmbaño.Text, txtndoc.Text, npdtcmb.Value, dtpfecha.Value, fla, txtcontrato_prdo9.Text)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'txttdoc.Text = ""
            txtndoc.Text = ""
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormAsientoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.Text = sAño
        txttdoc.Text = "9999"

    End Sub

    Private Sub FormAsientoPlanilla_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcontrato_prdo9.Text = gLinea
            dtpfec_ini9.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            'gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcontrato_prdo9_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo9.LostFocus
        If txtcontrato_prdo9.TextLength = 0 Then
            dtpfec_ini9.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo9.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini9.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo9.Text)
                dtpfec_ini9.Checked = True
            End If
        End If
    End Sub

    Private Sub txtcontrato_prdo9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo9.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcontrato_prdo9.Text = gLinea
                dtpfec_ini9.Value = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                'gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub
End Class