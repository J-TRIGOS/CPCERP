Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBLINEA
    Private ELTBLINEABL As New ELTBLINEABL

    Private Function OkData() As Boolean
        If txtnom.TextLength <= 4 Then
            MsgBox("Ingrese un nombre valido", MsgBoxStyle.Exclamation)
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
        Try
            Dim ELTBLINEABE As New ELTBLINEABE
            ELTBLINEABE.cod = RTrim(txtcod.Text)
            ELTBLINEABE.nom = txtnom.Text
            If cmbest.SelectedIndex = 0 Then
                ELTBLINEABE.est = "H"
            Else
                ELTBLINEABE.est = "A"
            End If
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELMVLOGSBE.log_codusu = gsCodUsr
            gsError = ELTBLINEABL.SaveRow(ELTBLINEABE, flagAccion, ELMVLOGSBE)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetData(ByVal sCode As String)
        Dim dtArticulo As DataTable
        Dim Registro As DataRow
        dtArticulo = ELTBLINEABL.SelectRow(gsCode)
        For Each Registro In dtArticulo.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbest.SelectedIndex = 0
            Else
                cmbest.SelectedIndex = 1
            End If
        Next
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub FormMantELTBLINEA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Linea"
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtcod.Text = ELTBLINEABL.LastCodigo() + 1
                txtcod.Text = txtcod.Text.PadLeft(4, "0")
                txtnom.Select()
                cmbest.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                txtnom.Select()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub FormMantELTBLINEA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class