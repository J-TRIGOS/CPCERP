Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantStockFisico
    Private ELTBARTSTOCKBL As New ELTBARTSTOCKBL
    Private contar As Integer = 0
    Private Sub SaveData()
        'If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        'MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'Else
        Dim ELTBARTSTOCKBE As New ELTBARTSTOCKBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELMVLOGSBE.log_codusu = gsUser
        ELTBARTSTOCKBE.ART_CODIGO = txtcodart.Text
        ELTBARTSTOCKBE.ART_STKFISICO1 = npdstock.Value
        ELTBARTSTOCKBE.ART_CODALM = gsCodAlm
        gsError = ELTBARTSTOCKBL.SaveRow(ELTBARTSTOCKBE, ELMVLOGSBE, "M")
        If gsError = "OK" Then
            ' MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            contar = 2
                Cerrar = ""
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        'End If

    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If Cerrar = "" Then
            Cerrar = "Cerrar"
            contar = 1
            Dispose()
            'Exit Sub
        End If
    End Sub

    Private Sub FormMantStockFisico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Stock Fisico"
        Select Case gnOpcion
            Case 0
                flagAccion = "M"
            Case 1
                flagAccion = "N"
                'GetData(gsCode, gsCode2, gsCode3, gsCode4, gsCode5, gsCode6, gsCode7, gCodAct, gArt)
        End Select
    End Sub

    Private Sub FormMantStockFisico_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If contar = 1 Then
            If MessageBox.Show("Esta seguro que desea salir del Ingreso de Stocks", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                If Cerrar = "" Then
                    Cerrar = "Cerrar"
                    Dispose()
                    Exit Sub
                End If
            End If
        ElseIf contar = 2 Then
            Dispose()
        Else
            If Cerrar = "" Then
                Cerrar = "Cerrar"
                Dispose()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        SaveData()
    End Sub
End Class