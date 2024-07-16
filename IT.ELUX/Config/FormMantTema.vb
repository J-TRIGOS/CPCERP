Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantTema
    Dim ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Dim Accion As String = "N"
    Private gpCaption As String
    Dim nro As String
    Private Sub FormMantTema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Tema"

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtCod.Text = ""
                nro = ELTBCAPACITACIONBL.SelectNroCod()
                If nro.Length = 1 Then
                    txtCod.Text = "0000" & nro
                ElseIf nro.Length = 2 Then
                    txtCod.Text = "000" & nro
                ElseIf nro.Length = 3 Then
                    txtCod.Text = "00" & nro
                ElseIf nro.Length = 4 Then
                    txtCod.Text = "0" & nro
                ElseIf nro.Length = 5 Then
                    txtCod.Text = nro
                End If
                nro = txtCod.Text
                cmbestado.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                txtCod.Text = sTDoc
                Dim dtUsuario As DataTable

                dtUsuario = ELTBCAPACITACIONBL.SelectTema(sTDoc)

                For Each Registro In dtUsuario.Rows

                    txtTema.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
                    Select Case Registro("EST").ToString
                        Case "H"
                            cmbestado.SelectedIndex = 0
                        Case "A"
                            cmbestado.SelectedIndex = 1
                            cmbestado.Enabled = False
                    End Select
                Next
        End Select

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "121"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gArt <> Nothing And gSubLinea <> Nothing Then
            txtCod.Text = gArt
            txtTema.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub FormMantTema_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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

            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                     gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim ELTBCAPACITACIONBE As New ELTBCAPACITACIONBE
                ELTBCAPACITACIONBE.CODIGO = txtCod.Text
                gsError = ELTBCAPACITACIONBL.SaveRows(ELTBCAPACITACIONBE, "A")
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

                Exit Sub
        End Select
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If txtTema.Text = Nothing Then
            Exit Sub
        End If
        Dim ELTBCAPACITACIONBE As New ELTBCAPACITACIONBE

        ELTBCAPACITACIONBE.CODIGO = txtCod.Text
        ELTBCAPACITACIONBE.TEMA1 = txtTema.Text

        If cmbestado.SelectedIndex = 0 Then
            ELTBCAPACITACIONBE.EST1 = "H"
        Else
            ELTBCAPACITACIONBE.EST1 = "A"
        End If



        gsError = ELTBCAPACITACIONBL.SaveRows(ELTBCAPACITACIONBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else

            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub
End Class