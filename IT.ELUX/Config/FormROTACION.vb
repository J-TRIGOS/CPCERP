
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.ComponentModel

Public Class FormROTACION

    Private PERROTBL As New PERROTBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Dim cod, cof, cot As String

    Private Sub FormROTACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dgvdatos.Rows.Clear()
        'dgvdatos.DataSource = Nothing

        Select Case gnOpcion
            Case 0
                flagAccion = "M"
                habilitar(True)
            Case 1
                flagAccion = "N"
                habilitar(False)
                GetData(gsCode)
        End Select
    End Sub
    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = PERROTBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows

            cod = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            cof = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            cot = IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO"))

            dgvdatos.Rows.Add(cod, cof, "")
        Next
        Dim comboCell2 As DataGridViewComboBoxCell
        comboCell2 = New DataGridViewComboBoxCell
        comboCell2.Items.Add("")
        comboCell2.Items.Add("DIURNO")
        comboCell2.Items.Add("NOCTURNO")
        Dim indice As Integer
        indice = dgvdatos.Rows.Count - 1
        dgvdatos.Rows(indice).Cells(2) = comboCell2
        dgvdatos.Rows(indice).Cells(2).Value = cot
    End Sub

    Private Sub habilitar(ByVal F As Boolean)
        btnBorrar.Enabled = F
        lbl2.Visible = Not F
        btnbuscar.Enabled = F
        cmbturno.Enabled = F
    End Sub

    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim PERBE As New PERBE
                PERBE.ZONA_COD = gsCodUsr
                gsError = PERROTBL.SaveRow(PERBE, flagAccion, dgvdatos)
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
        If dgvdatos.Rows.Count < 1 Then
            MsgBox("No hay Registros que guardar", MsgBoxStyle.Exclamation)
            Return False
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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "84"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
    End Sub

    Private Sub FormROTACION_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub borrar1_Click(sender As Object, e As EventArgs) Handles borrar1.Click
        If dgvdatos.Rows.Count < 1 Then
            MsgBox("No hay Registros que borrar", MsgBoxStyle.Exclamation)
        Else
            dgvdatos.Rows.Remove(dgvdatos.CurrentRow)
            dgvdatos.Refresh()
        End If
    End Sub

    Private Sub borrartodos_Click(sender As Object, e As EventArgs) Handles borrartodos.Click
        If dgvdatos.Rows.Count < 1 Then
            MsgBox("No hay Registros que borrar", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show("Desea Borrar toda la lista", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                dgvdatos.Rows.Clear()
                dgvdatos.DataSource = Nothing
                dgvdatos.Refresh()
            End If

        End If
    End Sub
End Class