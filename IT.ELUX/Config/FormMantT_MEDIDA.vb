Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantT_Medida

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private T_MEDIDABL As New T_MEDIDABL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()

        txtcod.Clear()
        txtnom.Clear()
        txtt_env.Clear()
        txtmed_formato.Clear()
        'cmblineacod.SelectedIndex = -1
        cmbcodest.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean

        If cmbcodest.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbcodest.Focus()
            Return False
        End If
        If txtnom.Text = "" Then
            MsgBox("Ingrese descripcion de Nombre", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = T_MEDIDABL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD_NUEVO")), "", Registro("COD_NUEVO"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtt_env.Text = IIf(IsDBNull(Registro("t_env")), "", Registro("t_env"))
            txtmed_formato.Text = IIf(IsDBNull(Registro("med_formato")), "", Registro("med_formato"))
            txtdesccorta.Text = IIf(IsDBNull(Registro("desc_corta")), "", Registro("desc_corta"))
            'cmblineacod.SelectedItem = IIf(IsDBNull(Registro("LINEA_COD")), -1, Registro("LINEA_COD"))
            If Registro("SITUACION") = "H" Then
                cmbcodest.SelectedIndex = 0
            ElseIf Registro("SITUACION") = "A" Then
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

        Dim T_MEDIDABE As New T_MEDIDABE
        T_MEDIDABE.cod = RTrim(txtcod.Text)
        T_MEDIDABE.nom = RTrim(txtnom.Text)
        T_MEDIDABE.t_env = RTrim(txtt_env.Text)
        T_MEDIDABE.desc_corta = RTrim(txtdesccorta.Text)
        'T_MEDIDABE.med_formato = RTrim(txtmed_formato.Text)
        T_MEDIDABE.linea_cod = IIf(cmblineacod.SelectedIndex = 0, "0", "1")
        T_MEDIDABE.situacion = IIf(cmbcodest.SelectedIndex = 0, "H", "A")

        gsError = T_MEDIDABL.SaveRow(T_MEDIDABE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
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
        Dim T_MEDIDABE As New T_MEDIDABE
        T_MEDIDABE.cod = Trim(txtcod.Text)

        Dim dTable As New DataTable

        gsError = T_MEDIDABL.SaveRow(T_MEDIDABE, flagAccion)
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
        gpCaption = "Formato"
        Me.Text = gpCaption

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                If T_MEDIDABL.LASTCODIGO().Length = 2 Then
                    txtcod.Text = "00" & T_MEDIDABL.LASTCODIGO()
                ElseIf T_MEDIDABL.LASTCODIGO().Length = 3 Then
                    txtcod.Text = "0" & T_MEDIDABL.LASTCODIGO()
                ElseIf T_MEDIDABL.LASTCODIGO().Length = 4 Then
                    txtcod.Text = T_MEDIDABL.LASTCODIGO()
                End If
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
            'Case "delete"
            '    DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub FormMantT_Medida_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class