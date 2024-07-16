
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELLIB_CONT

    Dim gpCaption As String
    Private ELLIB_CONTBL As New ELLIB_CONTBL
    Private Sub FormELLIB_CONT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Sub DeleteData()
        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        Else
            flagAccion = "E"
            Dim ELLIB_CONTBE As New ELLIB_CONTBE
            ELLIB_CONTBE.cod = txtcod.Text
            gsError = ELLIB_CONTBL.SaveRow(ELLIB_CONTBE, flagAccion)
            If gsError = "OK" Then
                MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELLIB_CONTBE As New ELLIB_CONTBE
                ELLIB_CONTBE.cod = txtcod.Text
                ELLIB_CONTBE.nom = txtdescripcion.Text

                If chkestado.Checked = True Then
                    ELLIB_CONTBE.estado = ""
                Else
                    ELLIB_CONTBE.estado = "A"
                End If

                gsError = ELLIB_CONTBL.SaveRow(ELLIB_CONTBE, flagAccion)
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
            MsgBox("Ingrese el codigo del libro", MsgBoxStyle.Exclamation)
            txtcod.Focus()
            Return False
        End If

        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese la descripción del libro", MsgBoxStyle.Exclamation)
            txtdescripcion.Focus()
            Return False
        End If

        If flagAccion = "N" Then
            If ELLIB_CONTBL.VerificarRepetido(txtcod.Text) = True Then
                MsgBox("El Codigo ya existe", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub Limpiar()
        txtcod.Text = ELLIB_CONTBL.SelectMaxLibro().PadLeft(2, "0")
    End Sub

    Private Sub GetData(ByVal sTDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        Dim est As String

        dtUsuario = ELLIB_CONTBL.SelectRow(sTDoc)
        For Each Registro In dtUsuario.Rows
            txtcod.Text = sTDoc
            txtdescripcion.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            est = IIf(IsDBNull(Registro("ESTADO")), "", Registro("ESTADO"))

            If est = "A" Then
                chkestado.Checked = False
            Else
                chkestado.Checked = True
            End If
        Next
    End Sub

End Class