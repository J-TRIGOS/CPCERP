Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBCARGO
    Private ELTBCARGOBL As New ELTBCARGOBL
    Private Sub GetData(ByVal sT_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ELTBCARGOBL.SelectRow(sT_Ref)
        For Each Registro In dtUsuario.Rows
            txtcod.Text = sT_Ref
            txtnom.Text = IIf(IsDBNull(Registro("CARGO_DESCRI")), "", Registro("CARGO_DESCRI"))
        Next

    End Sub
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If txtnom.TextLength = 0 Then
            MsgBox("Debe tener algo escrito como Descripcion")
            Exit Sub
        End If
        Dim ELTBCARGOBE As New ELTBCARGOBE
        ELTBCARGOBE.CARGO_COD = txtcod.Text
        ELTBCARGOBE.CARGO_DESCRI = txtnom.Text

        gsError = ELTBCARGOBL.SaveRow(ELTBCARGOBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormELTBCARGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtcod.Text = ELTBCARGOBL.SelectNro()
            Case 1
                flagAccion = "M"
                GetData(sTDoc)
        End Select
    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Dim mesaño As String
            Dim m As String
            Select Case sFunc

                Case "save"
                    SaveData()
                    Dispose()
                Case "exit"
                    Dispose()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try

    End Sub
End Class