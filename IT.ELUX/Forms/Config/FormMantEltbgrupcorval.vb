Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantEltbgrupcorval
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0

    Private ELTBGRUPCORVALBL As New ELTBGRUPCORVALBL
    Private ELTBGRUPCORBL As New ELTBGRUPCORBL
    Private flagAccion As String = ""
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

        dtUsuario = ELTBGRUPCORBL.SelectRow(sCode)

        For Each Registro In dtUsuario.Rows
            'txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtdescri.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            cmbcodest.SelectedIndex = IIf(IsDBNull(Registro("EST")), -1, Registro("EST"))
        Next

    End Sub
    Private Sub FormMantEltbgrupcorval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flagAccion = "M"
        gsError = ""
        gpCaption = "Grupo de Correo"
        If gsCode13 = "OC" Then
            cmbcodcor.Items.Add("0001")
            cmbcodcor.Items.Add("0002")
            cmbcodcor.Items.Add("0005")
            cmbcodcor.Text = "0005"
            'GetData(cmbcodcor.Text)
            lstValor.Items.Clear()
            ELTBGRUPCORVALBL.SelectRow(Me.cmbcodcor.Text, lstValor)
            GetData(cmbcodcor.Text)
        ElseIf gsCode13 = "RC" Then
            Dim dt As DataTable
            lvccosto.Visible = True
            cmbcodcor.Items.Add("0006")
            cmbcodcor.Text = "0006"
            lstValor.Items.Clear()
            txtValor.Enabled = False
            dt = ELTBGRUPCORVALBL.SelectRow1(Me.cmbcodcor.Text)
            For Each row As DataRow In dt.Rows
                If IIf(IsDBNull(row("est")), "", row("est")) = "1" Then
                    For i = 0 To lvccosto.Items.Count - 1
                        'MsgBox(lvccosto.Items(i).SubItems(0).ToString)
                        If IIf(IsDBNull(row("COR_VAL")), "", row("COR_VAL")) = lvccosto.Items(i).SubItems(0).Text Then
                            lvccosto.Items(i).Checked = True
                        End If
                    Next

                End If
            Next
            lvccosto.Enabled = False
            GetData(cmbcodcor.Text)
        End If
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

        Dim ELTBGRUPCORBE As New ELTBGRUPCORBE
        Dim ELTBGRUPCORVALBE As New ELTBGRUPCORVALBE
        ELTBGRUPCORBE.cod = RTrim(cmbcodcor.Text)
        ELTBGRUPCORBE.nom = RTrim(txtdescri.Text)
        ELTBGRUPCORBE.est = IIf(cmbcodest.SelectedIndex = 0, "0", "1")
        ELTBGRUPCORVALBE.cod = RTrim(cmbcodcor.Text)
        If gsCode13 = "RC" Then
            gsError2 = ELTBGRUPCORVALBL.SaveRowRC(ELTBGRUPCORVALBE, "RC", lvccosto)
        Else
            gsError2 = ELTBGRUPCORVALBL.SaveRow(ELTBGRUPCORVALBE, flagAccion, lstValor)
        End If


        gsError = ELTBGRUPCORBL.SaveRow(ELTBGRUPCORBE, flagAccion)

        'MsgBox(lv.Items(i).ToString)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


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
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub cmbcodcor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodcor.SelectedIndexChanged
        lstValor.Items.Clear()
        GetData(cmbcodcor.Text)
        ELTBGRUPCORVALBL.SelectRow(Me.cmbcodcor.Text, lstValor)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtValor.Text.Trim = "" Then
            Exit Sub
        End If

        'buscar si existe
        If lstValor.FindString(txtValor.Text) <> -1 Then
            MsgBox("El valor correo se encuentra registrado, verifique...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        lstValor.Items.Add(txtValor.Text)
        txtValor.Text = ""
    End Sub

    Private Sub FormMantEltbgrupcorval_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
End Class