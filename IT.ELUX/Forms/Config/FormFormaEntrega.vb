
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormFormaEntrega

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private FORMA_ENTBL As New FORMA_ENTBL

    Private Sub FormFormaEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                Deshabilitar(False)
        End Select
    End Sub

    Sub Deshabilitar(ByVal F As Boolean)
        txtcod.Enabled = F
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
            Case "delete"
                'DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim FORMA_ENTBE As New FORMA_ENTBE
                FORMA_ENTBE.cod = txtcod.Text.Trim()
                FORMA_ENTBE.nom = txtdes.Text.Trim()
                If chkestado.Checked = True Then FORMA_ENTBE.estado = "" Else FORMA_ENTBE.estado = "A"

                gsError = FORMA_ENTBL.SaveRow(FORMA_ENTBE, flagAccion)
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


    Private Function OkData() As Boolean

        If txtcod.Text = "" Then
            MsgBox("Ingrese el codigo", MsgBoxStyle.Exclamation)
            txtcod.Focus()
            Return False
        End If

        If flagAccion = "N" Then
            If FORMA_ENTBL.VerificarRepetido(txtcod.Text) = True Then
                MsgBox("El Codigo ya existe", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub Limpiar()
        txtcod.Text = ""
        txtdes.Text = ""
        chkestado.Checked = False
    End Sub

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = FORMA_ENTBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows
            txtcod.Text = gsCode
            txtdes.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            chkestado.Checked = Convert.ToBoolean(Registro("ESTADO"))
        Next
    End Sub
End Class