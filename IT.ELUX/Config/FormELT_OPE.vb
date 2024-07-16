Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELT_OPE

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELT_OPEBL As New ELT_OPEBL

    Private Sub FormELT_OPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmb_año.SelectedItem = DateTime.Now.ToString("yyyy")
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc)
                Deshabilitar(False)
        End Select
    End Sub

    Sub Deshabilitar(ByVal F As Boolean)
        txtcod.Enabled = F
        cmb_año.Enabled = F
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
                Dim ELT_OPEBE As New ELT_OPEBE

                ELT_OPEBE.cod = txtcod.Text
                ELT_OPEBE.anho = cmb_año.SelectedItem
                ELT_OPEBE.nom = lblnom.Text
                If chkaux.Checked = True Then
                    ELT_OPEBE.t_reg_aux = "1"
                Else
                    ELT_OPEBE.t_reg_aux = "0"
                End If
                If chkcont.Checked = True Then
                    ELT_OPEBE.t_reg_cc = "1"
                Else
                    ELT_OPEBE.t_reg_cc = "0"
                End If
                ELT_OPEBE.x_order_cont = txtorden.Text

                gsError = ELT_OPEBL.SaveRow(ELT_OPEBE, flagAccion)
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
            MsgBox("Ingrese el codigo de operación", MsgBoxStyle.Exclamation)
            txtcod.Focus()
            Return False
        End If

        If flagAccion = "N" Then
            If ELT_OPEBL.VerificarRepetido(cmb_año.SelectedItem, txtcod.Text) = True Then
                MsgBox("El Codigo y Año ya existe", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function
    Private Sub GetData(ByVal anho As String, ByVal cod As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELT_OPEBL.SelectRow(anho, cod)
        For Each Registro In dtUsuario.Rows
            cmb_año.SelectedItem = anho
            txtcod.Text = cod
            lblnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            If Registro("REG_AUX") = "SI" Then
                chkaux.Checked = True
            Else
                chkaux.Checked = False
            End If

            If Registro("REG_CC") = "SI" Then
                chkcont.Checked = True
            Else
                chkcont.Checked = False
            End If
            txtorden.Text = IIf(IsDBNull(Registro("X_ORDER_CONT")), "", Registro("X_ORDER_CONT"))
        Next
    End Sub

    Private Sub FormELT_OPE_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class