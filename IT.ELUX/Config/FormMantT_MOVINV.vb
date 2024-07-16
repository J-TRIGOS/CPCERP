Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantT_MOVINV

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private T_MOVINVBL As New T_MOVINVBL
    Private flagAccion As String = ""

    Private MenuBL As New MenuBL
    '   Private FunctionsBL As New FunctionsBL

    Private Sub CleanVar()

        txtdescri.Clear()
        cmbtipo.SelectedIndex = -1
        cmbx_tran.SelectedIndex = -1
        cmbtraslado.SelectedIndex = -1
        txtcosto.Clear()
        txtcodigo.Clear()
        txtcodope.Clear()
        txtdoc.Clear()
        txtref.Clear()
        txtser.Clear()
    End Sub

    Private Function OkData() As Boolean

        If cmbtipo.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo", MsgBoxStyle.Exclamation)
            cmbtipo.Focus()
            Return False
        End If
        If txtdescri.Text = "" Then
            MsgBox("Ingrese descripcion de moneda", MsgBoxStyle.Exclamation)
            txtdescri.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = T_MOVINVBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtcosto.Text = IIf(IsDBNull(Registro("COSTO")), "", Registro("COSTO"))
            txtdescri.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            If Registro("SIGNO") = "+" Then
                cmbtipo.SelectedIndex = 0
            ElseIf Registro("SIGNO") = "-" Then
                cmbtipo.SelectedIndex = 1
            ElseIf Registro("SIGNO") = "*" Then
                cmbtipo.SelectedIndex = 2
            ElseIf Registro("SIGNO") = "$" Then
                cmbtipo.SelectedIndex = 3
            End If
            If Registro("X_TRAN") = "S" Then
                cmbx_tran.SelectedIndex = 0
            ElseIf Registro("X_TRAN") = "N" Then
                cmbx_tran.SelectedIndex = 1
            Else
                cmbx_tran.SelectedIndex = -1
            End If
            txtdoc.Text = IIf(IsDBNull(Registro("DOCMOV")), "", Registro("DOCMOV"))
            txtser.Text = IIf(IsDBNull(Registro("SERMOV")), "", Registro("SERMOV"))
            txtref.Text = IIf(IsDBNull(Registro("DREFMOV")), "", Registro("DREFMOV"))
            txtcodope.Text = IIf(IsDBNull(Registro("COD_OPE")), "", Registro("COD_OPE"))
            If Registro("FLAG") = "V" Then
                cmbtraslado.SelectedIndex = 0
            ElseIf Registro("FLAG") = "C" Then
                cmbtraslado.SelectedIndex = 1
            ElseIf Registro("FLAG") = "T" Then
                cmbtraslado.SelectedIndex = 2
            ElseIf Registro("FLAG") = "D" Then
                cmbtraslado.SelectedIndex = 3
            ElseIf Registro("FLAG") = "L" Then
                cmbtraslado.SelectedIndex = 4
            ElseIf Registro("FLAG") = "I" Then
                cmbtipo.SelectedIndex = 5
            ElseIf Registro("FLAG") = "O" Then
                cmbtraslado.SelectedIndex = 6
            Else
                cmbtraslado.SelectedIndex = -1
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

        Dim T_MOVINVBE As New T_MOVINVBE
        T_MOVINVBE.cod = RTrim(txtcodigo.Text)
        T_MOVINVBE.nom = RTrim(txtdescri.Text)
        T_MOVINVBE.costo = RTrim(txtcosto.Text)
        If RTrim(cmbtipo.SelectedIndex) = 0 Then
            T_MOVINVBE.signo = "+"
        ElseIf RTrim(cmbtipo.SelectedIndex) = 1 Then
            T_MOVINVBE.signo = "-"
        ElseIf RTrim(cmbtipo.SelectedIndex) = 2 Then
            T_MOVINVBE.signo = "*"
        ElseIf RTrim(cmbtipo.SelectedIndex) = 3 Then
            T_MOVINVBE.signo = "$"
        End If

        T_MOVINVBE.x_tran = IIf(cmbx_tran.SelectedIndex = 0, "S", "N")
        T_MOVINVBE.docmov = RTrim(txtdoc.Text)
        T_MOVINVBE.ser_mov = RTrim(txtser.Text)
        T_MOVINVBE.drefmov = RTrim(txtref.Text)
        If cmbtraslado.SelectedIndex = 0 Then
            T_MOVINVBE.flag = "V"
        ElseIf cmbtraslado.SelectedIndex = 1 Then
            T_MOVINVBE.flag = "C"
        ElseIf cmbtraslado.SelectedIndex = 2 Then
            T_MOVINVBE.flag = "T"
        ElseIf cmbtraslado.SelectedIndex = 3 Then
            T_MOVINVBE.flag = "D"
        ElseIf cmbtraslado.SelectedIndex = 4 Then
            T_MOVINVBE.flag = "L"
        ElseIf cmbtraslado.SelectedIndex = 5 Then
            T_MOVINVBE.flag = "I"
        ElseIf cmbtraslado.SelectedIndex = 6 Then
            T_MOVINVBE.flag = "O"
        Else
            cmbtraslado.SelectedIndex = -1
        End If
        T_MOVINVBE.cod_ope = txtcodope.Text

        gsError = T_MOVINVBL.SaveRow(T_MOVINVBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub


    Private Sub FormMntUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gsError = ""
        gpCaption = "Movimiento"
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
            'Case "delete"
            '    DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub FormMantT_MOVINV_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class