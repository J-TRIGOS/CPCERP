Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormCIIU
    Public val As String = ""
    Private CIIUBL As New CIIUBL
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim CIIUBE As New CIIUBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                CIIUBE.Codigo = txtcodigo.Text
                CIIUBE.Nombre = txtnombre.Text
                CIIUBE.Cod_cambio = Label3.Text
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = CIIUBL.SaveRow(CIIUBE, val, ELMVLOGSBE)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    FormMantELTBPROVEEDORES.lblser_cod.Text = txtnombre.Text
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

            End If
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
            Case "exit"
                'sOp = "1"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Function OkData() As Boolean
        If txtnombre.Text = "" Then
            MsgBox("Ingrese el nombre del CIIU", MsgBoxStyle.Exclamation)
            txtnombre.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub FormCIIU_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'sOp = "1"
        Dispose()
    End Sub

    Private Sub FormCIIU_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sOp = "1" Then
            txtcodigo.ReadOnly = False
            Select Case gnOpcion
                Case 0
                    val = "N"
                Case 1
                    val = "M"
                    txtcodigo.Text = gsCode
                    Label3.Text = gsCode
            End Select

        End If
    End Sub
End Class