Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.ComponentModel

Public Class FormMantContratos
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELCONTRATOBL As New ELCONTRATOBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"

    Private Sub FormELTBREGISTRO_NRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvdatos.Rows.Clear()
        dgvdatos.DataSource = Nothing

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                habilitar(True)
                btnbuscar.Enabled = True
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                habilitar(False)
                btnbuscar.Enabled = False
                btnCambiar.Enabled = False
        End Select
    End Sub

    Private Sub habilitar(ByVal F As Boolean)
        txtdias.Enabled = Not F
        btnBorrar.Enabled = F
        lbl2.Visible = Not F
    End Sub

    Private Sub chkactivar_CheckedChanged(sender As Object, e As EventArgs) Handles chkactivar.CheckedChanged
        If chkactivar.Checked = True Then
            txtdias.Enabled = True
            txtdias.Focus()
        Else
            txtdias.Enabled = False
        End If
    End Sub

    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable


        dtUsuario = ELCONTRATOBL.SelectRow(gsCode)
        For Each row In dtUsuario.Rows

            dgvdatos.Rows.Add(IIf(IsDBNull(row("DNI")), "", row("DNI")),
                              IIf(IsDBNull(row("NOM")), "", row("NOM")),
                              IIf(IsDBNull(row("F_INI")), "", row("F_INI")),
                              IIf(IsDBNull(row("F_FIN")), "", row("F_FIN")),
                              IIf(IsDBNull(row("INDICE")), "", row("INDICE")))
            dtpfecha_ini.Value = IIf(IsDBNull(row("F_INI")), "", row("F_INI"))
            dtpfecha_fin.Value = IIf(IsDBNull(row("F_FIN")), "", row("F_FIN"))
        Next

        Dim Numero As Integer = dgvdatos.Rows.Count

        For Each Row2 As DataGridViewRow In dgvdatos.Rows
            If Numero = CInt(Row2.Cells("INDICE").Value) Then
                Row2.DefaultCellStyle.BackColor = Color.FromArgb(245, 230, 140)
            End If
        Next

    End Sub

    Private Sub Limpiar()
        Dim a As Integer = DateTime.Now.Month
    End Sub

    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            Dim mensaje As String
            If flagAccion = "N" Then
                mensaje = "Desea grabar el Registro"
            Else
                mensaje = "Se Actualizará el contrato vigente"
            End If

            If MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELCONTRATOBE As New ELCONTRATOBE
                ELCONTRATOBE.f_ini = dtpfecha_ini.Value
                ELCONTRATOBE.f_fin = dtpfecha_fin.Value
                ELCONTRATOBE.codusu = gsCodUsr
                gsError = ELCONTRATOBL.SaveRow(ELCONTRATOBE, flagAccion, dgvdatos)
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

    Private Sub txtdias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdias.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        'If btnbuscar.Text = "Buscar" Then

        If DateTime.Compare(dtpfecha_ini.Value, dtpfecha_fin.Value) >= 0 Then
            MsgBox("Verifique las Fechas, la fecha de fin debe ser mayor a la de Inicio", MsgBoxStyle.Exclamation)
        Else
            sBusAlm = "36"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
        End If


    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If dgvdatos.Rows.Count < 1 Then
            MsgBox("No hay Registros que borrar", MsgBoxStyle.Exclamation)
        Else
            dgvdatos.Rows.Remove(dgvdatos.CurrentRow)
            dgvdatos.Refresh()
        End If
    End Sub

    Private Sub FormMantContratos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
        Cerrar = ""
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        If DateTime.Compare(dtpfecha_ini.Value, dtpfecha_fin.Value) >= 0 Then
            MsgBox("Verifique las Fechas, la fecha de fin debe ser mayor a la de Inicio", MsgBoxStyle.Exclamation)
        Else
            For i As Integer = 0 To dgvdatos.Rows.Count - 1
                dgvdatos.Rows(i).Cells("F_INI").Value = dtpfecha_ini.Value.ToShortDateString
                dgvdatos.Rows(i).Cells("F_FIN").Value = dtpfecha_fin.Value.ToShortDateString
            Next
        End If
    End Sub
End Class