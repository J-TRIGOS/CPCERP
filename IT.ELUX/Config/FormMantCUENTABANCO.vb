Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormMantCUENTABANCO

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private CUENTABANCOBL As New CUENTABANCOBL

    Private Sub FormCUENTABANCO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                Deshabilitar(False)
        End Select
    End Sub

    Sub Deshabilitar(ByVal F As Boolean)
        cmbanho.Enabled = F
        txtcodbanco.Enabled = F
        txtnombanco.Enabled = F
        txtcta_cod.Enabled = F
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
                Dim CUENTABANCOBE As New CUENTABANCOBE
                CUENTABANCOBE.anho = cmbanho.SelectedItem
                CUENTABANCOBE.cbco_cod = txtcodbanco.Text
                CUENTABANCOBE.cta_cod = txtcta_cod.Text

                gsError = CUENTABANCOBL.SaveRow(CUENTABANCOBE, flagAccion)
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

        If txtcodbanco.Text = "" Then
            MsgBox("Ingrese el codigo de banco", MsgBoxStyle.Exclamation)
            txtcodbanco.Focus()
            Return False
        End If

        If txtcta_cod.Text = "" Then
            MsgBox("Ingrese el codigo de cuenta", MsgBoxStyle.Exclamation)
            txtcta_cod.Focus()
            Return False
        End If

        If flagAccion = "N" Then
            If CUENTABANCOBL.VerificarRepetido(cmbanho.SelectedItem, txtcodbanco.Text, txtcta_cod.Text) = True Then
                MsgBox("El Codigo ya existe", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub Limpiar()
        cmbanho.SelectedItem = DateTime.Now.ToString("yyyy")
        txtcodbanco.Text = ""
        txtnombanco.Text = ""
        txtcta_cod.Text = ""
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = CUENTABANCOBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            cmbanho.SelectedItem = sTDoc
            txtcodbanco.Text = IIf(IsDBNull(Registro("CBCO_COD")), "", Registro("CBCO_COD"))
            txtnombanco.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtcta_cod.Text = IIf(IsDBNull(Registro("CTA_COD")), "", Registro("CTA_COD"))
        Next
    End Sub
    Private Sub txtcodbanco_LostFocus(sender As Object, e As EventArgs) Handles txtcodbanco.LostFocus
        If (txtcodbanco.Text = "") Then
            txtnombanco.Text = ""
        Else
            Dim dt As DataTable
            dt = CUENTABANCOBL.SelectbancoCOD(txtcodbanco.Text)
            If dt.Rows.Count > 0 Then
                txtcodbanco.Text = dt.Rows(0).Item(0).ToString
                txtnombanco.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcodbanco.Text = ""
                txtnombanco.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcodbanco_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodbanco.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "58"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcodbanco.Text = gLinea
                txtnombanco.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodbanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodbanco.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class