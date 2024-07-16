Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormCargarDias
    Private PERBL As New PERBL
    Private Sub FormCargarDias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cargar Dias de Labores"
        dgvt_doc.Columns.Add("COD", "DNI") '0
        dgvt_doc.Columns.Add("NOM", "Apellidos y Nombres") '1
        dgvt_doc.Columns.Add("TOT_DIA", "Dias") '2
        dgvt_doc.Columns.Add("TOT_HOR", "Horas") '3
        dgvt_doc.Columns.Add("TOT_MIN", "Min") '3
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim frm As New BusquedaPersonal
        sBusAlm = "85"
        gArt = npdtot_dias.Value
        gsCode = npdhoras.Value
        gsCode2 = npdminutos.Value
        frm.ShowDialog()
        gArt = Nothing
        gsCode = Nothing
        gsCode2 = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La Lista no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar los Registros",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        Dim PERBE As New PERBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        gsError = PERBL.Save(PERBE, ELMVLOGSBE, dgvt_doc, "D")
        If gsError = "OK" Then
            'FormMain.LblError.Text = gsError
            MsgBox("Se guardaron los dias", MsgBoxStyle.Critical)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormCargarDias_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        Dim dt As DataTable
        If cmbemp.SelectedIndex > 0 Then
            If cmbemp.SelectedIndex = 1 Then
                dt = PERBL.SelPerDias("21")
            Else
                dt = PERBL.SelPerDias("20")
            End If

            For Each Registro In dt.Rows
                dgvt_doc.Rows.Add(IIf(IsDBNull(Registro("COD")), "", Registro("COD")),
                                  IIf(IsDBNull(Registro("NOM")), "", Registro("NOM")),
                                  npdtot_dias.Value, npdhoras.Value, npdminutos.Value)
            Next
        End If

    End Sub

    Private Sub cmbemp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbemp.SelectedIndexChanged
        If cmbemp.SelectedIndex > 0 Then
            btncargar.Enabled = True
        Else
            btncargar.Enabled = False
        End If
    End Sub
End Class