Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBTAREA
    Private ELTBTAREABL As New ELTBTAREABL
    Private Sub GetData(ByVal sCod As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        dtUsuario = ELTBTAREABL.SelectRow(sCod)
        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbest.SelectedIndex = 0
            Else
                cmbest.SelectedIndex = 1
            End If
        Next
    End Sub
    Private Function OkData() As Boolean
        If txtnom.Text = "" Then
            MsgBox("Ingrese el nombre de la Tarea", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim nro As String
        Dim ELTBTAREABE As New ELTBTAREABE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELTBTAREABE.cod = txtcod.Text
        ELTBTAREABE.nom = txtnom.Text
        If cmbest.SelectedIndex = 0 Then
            ELTBTAREABE.est = "H"
        Else
            ELTBTAREABE.est = "A"
        End If
        ELMVLOGSBE.log_codusu = gsCodUsr
        'nro = FACTURACIONBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
        gsError = ELTBTAREABL.SaveRow(ELTBTAREABE, ELMVLOGSBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Tarea Creada", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormELTBTAREA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                Dim nro As String = ""
                flagAccion = "N"
                nro = ELTBTAREABL.SelectNro1()
                txtcod.Text = nro.PadLeft(4, "0")
                cmbest.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                GetData(gsCode)
        End Select
    End Sub

    Private Sub FormELTBTAREA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
End Class