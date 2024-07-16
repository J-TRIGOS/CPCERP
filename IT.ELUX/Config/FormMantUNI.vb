Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantUNI
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private UNIBL As New UNIBL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()

        txtcodigo.Clear()
        txtnombre.Clear()
        txtsigla.Clear()
        txtnompl.Clear()
        cmbcodest.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean

        If cmbcodest.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbcodest.Focus()
            Return False
        End If
        If txtnombre.Text = "" Then
            MsgBox("Ingrese descripcion de moneda", MsgBoxStyle.Exclamation)
            txtnombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = UNIBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnombre.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtsigla.Text = IIf(IsDBNull(Registro("SIGLA")), "", Registro("SIGLA"))
            txtnompl.Text = IIf(IsDBNull(Registro("NOMPL")), "", Registro("NOMPL"))
            If Registro("ESTADO") = "H" Then
                cmbcodest.SelectedIndex = 0
            ElseIf Registro("ESTADO") = "A" Then
                cmbcodest.SelectedIndex = 1
            Else
                cmbcodest.SelectedIndex = -1
            End If
        Next

    End Sub

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If

        Dim UNIBE As New UNIBE
        UNIBE.cod = RTrim(txtcodigo.Text)
        UNIBE.nom = RTrim(txtnombre.Text)
        UNIBE.sigla = RTrim(txtsigla.Text)
        UNIBE.nompl = RTrim(txtnompl.Text)
        UNIBE.estado = IIf(cmbcodest.SelectedIndex = 0, "H", "A")

        gsError = UNIBL.SaveRow(UNIBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub DeleteData()

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        flagAccion = "E"
        Dim UNIBE As New UNIBE
        UNIBE.cod = Trim(txtcodigo.Text)

        Dim dTable As New DataTable

        gsError = UNIBL.SaveRow(UNIBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FormMntUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "Unidad"
        Me.Text = gpCaption
        'txtcodigo.Enabled = False
        'pSetButtons(tsbForm, gsCodeButton, True, {})
        'pSetPermisos(tsbForm, "Tab", gsCodTab, gpCodSis)

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
            Case 1
                flagAccion = "M"
                GetData(gsCode)

        End Select

    End Sub

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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

    Private Sub FormMantUNI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class