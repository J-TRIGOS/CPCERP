Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormRegistroAsistencia

    Private MARCACIONBL As New MARCACIONBL

    Private Sub FormRegistroAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtDNI As New DataTable
        dtDNI = MARCACIONBL.BuscarDNI(gsCodUsr)
        If dtDNI.Rows.Count > 0 Then
            If gsUser <> "WJAIME" Then
                txtDni.Enabled = False
                txtDni.Text = dtDNI.Rows(0).Item(0)
            End If
        End If

        Dim hora = DateTime.Now.ToString("HH:mm")
        If hora < "12:00" Then
            radEntrada.Checked = True
            radRefrigerio.Enabled = False
            radSalida.Enabled = False
        End If
        If hora >= "12:00" And hora < "15:00" Then
            radEntrada.Enabled = False
            radRefrigerio.Enabled = True
            radRefrigerio.Checked = True
            radSalida.Enabled = False
        End If
        If hora >= "15:00" Then
            radEntrada.Enabled = False
            radRefrigerio.Enabled = False
            radSalida.Enabled = True
            radSalida.Checked = True
        End If
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If (Asc(e.KeyChar)) = 13 Then
            If txtDni.Text = "" Then
                MsgBox("No es valido el DNI ingresado")
            Else
                btnMarcar_Click(sender, e)
                txtDni.Text = ""
                txtDni.Focus()
            End If
        End If

    End Sub

    Private Sub btnMarcar_Click(sender As Object, e As EventArgs) Handles btnMarcar.Click
        Dim pc = ""
        Dim tipo = ""
        If radEntrada.Checked = True Then
            tipo = "EN"
        End If
        If radRefrigerio.Checked = True Then
            tipo = "RE"
        End If
        If radSalida.Checked = True Then
            tipo = "SA"
        End If

        If txtDni.Text = "" Then
            MsgBox("Ingrese DNI", MsgBoxStyle.Exclamation)
            txtDni.Focus()
        Else
            Dim dtDni As New DataTable
            dtDni = MARCACIONBL.VerificarDNI(txtDni.Text)
            If dtDni.Rows.Count > 0 Then
                Dim dia = DateTime.Now.ToString("dd")
                Dim mes = DateTime.Now.ToString("MM")
                Dim anho = DateTime.Now.ToString("yyyy")
                Dim fecha = dia & "/" & mes & "/" & anho
                ' MsgBox(fecha)
                Dim dni = txtDni.Text
                pc = My.Computer.Name

                Dim resultado = MARCACIONBL.registrarAsistencia(dni, fecha, pc, gsUser, tipo)
                If resultado = "OK" Then
                    MsgBox("Asistencia Registrada " & dtDni.Rows(0).ItemArray(0) & " - " & lblReloj.Text)
                Else
                    MsgBox(resultado)
                End If
            Else
                MsgBox("DNI no registrado")
                Exit Sub
            End If


        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblReloj.Text = TimeOfDay.ToString("HH:mm:ss")
    End Sub

    Private Sub FormRegistroAsistencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

End Class