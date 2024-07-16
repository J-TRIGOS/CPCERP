Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBCARA
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBCARABL As New ELTBCARABL
    Private ELTBCARA_VALBL As New ELTBCARA_VALBL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()

        txtcodigo.Text = ELTBCARABL.LastCodigo()
        txtdescri.Clear()
        cmbobligatorio.SelectedIndex = -1
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

        dtUsuario = ELTBCARABL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("CAR_CODIGO")), "", Registro("CAR_CODIGO"))
            txtdescri.Text = IIf(IsDBNull(Registro("CAR_DESCRI")), "", Registro("CAR_DESCRI"))
            cmbobligatorio.SelectedIndex = IIf(IsDBNull(Registro("CAR_OBLIG")), -1, Registro("CAR_OBLIG"))
            cmbcodest.SelectedIndex = IIf(IsDBNull(Registro("CAR_CODEST")), -1, Registro("CAR_CODEST"))
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

        Dim ELTBCARABE As New ELTBCARABE
        Dim ELTBCARA_VALBE As New ELTBCARA_VALBE
        ELTBCARABE.car_codigo = RTrim(txtcodigo.Text)
        ELTBCARABE.car_descri = RTrim(txtdescri.Text)
        ELTBCARABE.car_oblig = IIf(cmbobligatorio.SelectedIndex = 0, "0", "1")
        ELTBCARABE.car_codest = IIf(cmbcodest.SelectedIndex = 0, "0", "1")
        ELTBCARA_VALBE.val_codcar = RTrim(txtcodigo.Text)
        gsError2 = ELTBCARA_VALBL.SaveRow(ELTBCARA_VALBE, flagAccion, lstValor)

        gsError = ELTBCARABL.SaveRow(ELTBCARABE, flagAccion)

        'MsgBox(lv.Items(i).ToString)
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
        Dim ELTBCARABE As New ELTBCARABE
        ELTBCARABE.car_codigo = Trim(txtcodigo.Text)

        Dim dTable As New DataTable

        gsError = ELTBCARABL.SaveRow(ELTBCARABE, flagAccion)
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
        gpCaption = "Caracteristicas"
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
                ELTBCARA_VALBL.SelectRow(Me.txtcodigo.Text, lstValor)
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

    Private Sub FormMantELTBCARA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class