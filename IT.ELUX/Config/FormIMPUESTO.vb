Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Public Class FormIMPUESTO
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBMOVIMIENTOBL As New ELTBMOVIMIENTOBL
    Private IMPUESTOBL As New IMPUESTOBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sSec As String
    Private MenuBL As New MenuBL
    Public boton As String
    Private Sub FormIMPUESTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbtipo.Items.Insert(0, "PORCENTAJE")
        cmbtipo.Items.Insert(1, "BASE")
        cmbtipo.Items.Insert(2, "TOTAL")

        cmbafecto.Items.Insert(0, "AFECTO")
        cmbafecto.Items.Insert(1, "INAFECTO")

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                habilitar(True)
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                habilitar(False)
        End Select
    End Sub
    Private Sub habilitar(ByVal F As Boolean)
        txt_codigo.Enabled = F
    End Sub
    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = IMPUESTOBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows

            txt_codigo.Text = gsCode
            txtdescripcion.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            cmbtipo.SelectedIndex = IIf(IsDBNull(Registro("TIPO")), -1, Registro("TIPO"))
            txtporcentaje.Text = IIf(IsDBNull(Registro("PORC")), "", Registro("PORC"))
            cmbafecto.SelectedIndex = IIf(IsDBNull(Registro("AFECTO")), -1, Registro("AFECTO"))

        Next
    End Sub
    Private Sub Limpiar()
        txt_codigo.Text = ""
        txtdescripcion.Text = ""
        cmbtipo.SelectedIndex = -1
        txtporcentaje.Text = ""
        cmbafecto.SelectedIndex = -1
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim IMPUESTOBE As New IMPUESTOBE

                IMPUESTOBE.cod = txt_codigo.Text
                IMPUESTOBE.nom = txtdescripcion.Text.Trim
                IMPUESTOBE.tipo = cmbtipo.SelectedItem.ToString.Substring(0, 1)
                IMPUESTOBE.porc = txtporcentaje.Text
                If cmbafecto.SelectedItem = "AFECTO" Then
                    IMPUESTOBE.afecto = "S"
                Else
                    IMPUESTOBE.afecto = "N"
                End If

                gsError = IMPUESTOBL.SaveRow(IMPUESTOBE, flagAccion)
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
        If txt_codigo.Text = "" Then
            MsgBox("Ingrese el Codigo", MsgBoxStyle.Exclamation)
            txt_codigo.Focus()
            Return False
        End If
        If flagAccion = "N" Then
            If IMPUESTOBL.VerificarRepetido(txt_codigo.Text) = True Then
                MsgBox("El Codigo ya existe", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If
        Return True
    End Function
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
    Private Sub txtporcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtporcentaje.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormIMPUESTO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class