Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormLimpiarDias
    Dim PERBL As New PERBL
    Private Sub FormLimpiarDias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Limpiar Dias"

    End Sub

    Private Sub FormLimpiarDias_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Dim dt As New DataGridView
        If MessageBox.Show("Desea Borrar los datos de los Empleados", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        Else
            If rdbempleados.Checked Then
                Dim PERBE As New PERBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                PERBE.NN = "21"
                gsError = PERBL.Save(PERBE, ELMVLOGSBE, dt, "M")
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            ElseIf rdbobreros.Checked Then
                Dim PERBE As New PERBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                PERBE.NN = "20"
                gsError = PERBL.Save(PERBE, ELMVLOGSBE, dt, "M")
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            ElseIf rdbcpto.Checked Then
                Dim PERBE As New PERBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                PERBE.NN = "11"
                gsError = PERBL.Save(PERBE, ELMVLOGSBE, dt, "CP")
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            Else
                Dim PERBE As New PERBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                PERBE.NN = ""
                gsError = PERBL.Save(PERBE, ELMVLOGSBE, dt, "M")
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If

        End If

    End Sub
End Class