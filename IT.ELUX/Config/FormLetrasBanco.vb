Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormLetrasBanco
    Private LETRASBL As New LETRASBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub FormLetrasBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Letras de Banco"
        dgvt_doc.Columns.Add("T_DOC_REF", "Tipo") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("RUC", "Ruc") '3
        dgvt_doc.Columns.Add("PROVEEDOR", "Proveedor") '4
        dgvt_doc.Columns.Add("FEC_GENE", "F. Generacion") '5
        dgvt_doc.Columns.Add("MONEDA", "MONEDA") '6
        dgvt_doc.Columns.Add("PRECIO", "PRECIO") '7
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   "Estado Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim LETRASBE As New LETRASBE

        If chkbinteres.Checked Then
            LETRASBE.BINTERES = "1"
        Else
            LETRASBE.BINTERES = ""
        End If
        If cmbest1.SelectedIndex = 1 Then
            LETRASBE.EST1 = "T"
        ElseIf cmbest1.SelectedIndex = 2 Then
            LETRASBE.EST1 = "N"
        ElseIf cmbest1.SelectedIndex = 0 Then
            LETRASBE.EST1 = ""
        ElseIf cmbest1.SelectedIndex = -1 Then
            LETRASBE.EST1 = ""
        End If
        If chkrecogido.Checked Then
            LETRASBE.X_D = "1"
        Else
            LETRASBE.X_D = ""
        End If
        gsError = LETRASBL.SaveRowEst1(LETRASBE, ELMVLOGSBE, "ACTEST1", dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FormDocuRefLtBanco
        frm.ShowDialog()
    End Sub

    Private Sub FormLetrasBanco_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class