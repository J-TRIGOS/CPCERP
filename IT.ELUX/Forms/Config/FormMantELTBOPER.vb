Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBOPER
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBOPERBL As New ELTBOPERBL
    Private ELTBVALOPERBL As New ELTBVALOPERBL
    Private flagAccion As String = ""
    Private Sub CleanVar()

        txtcodigo.Text = ELTBOPERBL.LastCodigo()
        txtdescri.Clear()
        cmbcodest.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean

        If cmbcodest.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbcodest.Focus()
            Return False
        End If
        If txtdescri.Text = "" Then
            MsgBox("Ingrese descripcion", MsgBoxStyle.Exclamation)
            txtdescri.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBOPERBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtdescri.Text = IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))
            cmbcodest.SelectedIndex = IIf(IsDBNull(Registro("EST")), -1, Registro("EST"))
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

        Dim ELTBOPERBE As New ELTBOPERBE
        Dim ELTBVALOPERBE As New ELTBVALOPERBE
        ELTBOPERBE.cod = RTrim(txtcodigo.Text)
        ELTBOPERBE.descri = RTrim(txtdescri.Text)
        ELTBOPERBE.est = IIf(cmbcodest.SelectedIndex = 0, "0", "1")
        ELTBVALOPERBE.val_codoper = RTrim(txtcodigo.Text)
        ELTBOPERBE.npases = npdpases.Value
        gsError2 = ELTBVALOPERBL.SaveRow(ELTBVALOPERBE, flagAccion, lstValor)

        gsError = ELTBOPERBL.SaveRow(ELTBOPERBE, flagAccion)

        'MsgBox(lv.Items(i).ToString)
        If gsError = "OK" And gsError2 = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Sub FormELTBProcesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "Operaciones"
        Me.Text = gpCaption
        txtcodigo.Enabled = False
        'pSetButtons(tsbForm, gsCodeButton, True, {})
        'pSetPermisos(tsbForm, "Tab", gsCodTab, gpCodSis)

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                ELTBVALOPERBL.SelectRow(Me.txtcodigo.Text, lstValor)
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
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtValor.Text.Trim = "" Then
            Exit Sub
        End If

        'buscar si existe
        If lstValor.FindString(txtValor.Text) <> -1 Then
            MsgBox("El valor ya se encuentra registrado, verifique...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        lstValor.Items.Add(txtValor.Text)
        txtValor.Text = ""

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        If lstValor.SelectedItem Is Nothing Then
            Exit Sub
        End If

        If MessageBox.Show("Desea eliminar el valor",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        lstValor.Items.Remove(lstValor.SelectedItem)

    End Sub

    Private Sub FormELTBProcesos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class