Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports System.Net
Imports System.Net.Mail
Imports System.IO
Imports vb = Microsoft.VisualBasic

Public Class FormSeguimientoClientes

    Dim CONTABILIDADBL As New CONTABILIDADBL
    Private correos As New MailMessage
    Private envios As New SmtpClient

    Private Sub FormSeguimientoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Seguimiento Documentario x Clientes"
        getCmbAño(cmbAnho)
        getCmbMes(cmbMes)
        Select Case Today.Year
            Case 2019
                cmbAnho.SelectedIndex = 0
            Case 2020
                cmbAnho.SelectedIndex = 1
            Case 2021
                cmbAnho.SelectedIndex = 2
            Case 2022
                cmbAnho.SelectedIndex = 3
            Case 2023
                cmbAnho.SelectedIndex = 4
            Case 2024
                cmbAnho.SelectedIndex = 5
            Case 2025
                cmbAnho.SelectedIndex = 5
        End Select
        cmbMes.SelectedIndex = Today.Month - 1
    End Sub

    Private Function getCmbAño(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("2019")
        cmb.Items.Add("2020")
        cmb.Items.Add("2021")
        cmb.Items.Add("2022")
        cmb.Items.Add("2023")
        cmb.Items.Add("2024")
        cmb.Items.Add("2025")
    End Function

    Private Function getCmbMes(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("Enero")
        cmb.Items.Add("Febrero")
        cmb.Items.Add("Marzo")
        cmb.Items.Add("Abril")
        cmb.Items.Add("Mayo")
        cmb.Items.Add("Junio")
        cmb.Items.Add("Julio")
        cmb.Items.Add("Agosto")
        cmb.Items.Add("Septiembre")
        cmb.Items.Add("Octubre")
        cmb.Items.Add("Noviembre")
        cmb.Items.Add("Diciembre")
    End Function

    Private Sub FormSeguimientoClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub cmbAnho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnho.SelectedIndexChanged
        dgvDocClientes.DataSource = ""
        If cmbMes.SelectedIndex = -1 Then
            Exit Sub
        End If
        Dim anho = cmbAnho.SelectedItem
        Dim mes
        Select Case cmbMes.SelectedIndex + 1
            Case 1
                mes = "01"
            Case 2
                mes = "02"
            Case 3
                mes = "03"
            Case 4
                mes = "04"
            Case 5
                mes = "05"
            Case 6
                mes = "06"
            Case 7
                mes = "07"
            Case 8
                mes = "08"
            Case 9
                mes = "09"
            Case 10
                mes = "10"
            Case 11
                mes = "11"
            Case 12
                mes = "21"
        End Select
        llenarDataGrid(mes, anho)
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        dgvDocClientes.DataSource = ""
        If cmbAnho.SelectedIndex = -1 Then
            Exit Sub
        End If
        Dim anho = cmbAnho.SelectedItem
        Dim mes
        Select Case cmbMes.SelectedIndex + 1
            Case 1
                mes = "01"
            Case 2
                mes = "02"
            Case 3
                mes = "03"
            Case 4
                mes = "04"
            Case 5
                mes = "05"
            Case 6
                mes = "06"
            Case 7
                mes = "07"
            Case 8
                mes = "08"
            Case 9
                mes = "09"
            Case 10
                mes = "10"
            Case 11
                mes = "11"
            Case 12
                mes = "21"
        End Select
        llenarDataGrid(mes, anho)
    End Sub

    Sub llenarDataGrid(ByVal mes As String, ByVal anho As String)
        Dim dtDocumentosClientes = CONTABILIDADBL.BuscarDocumentosClientes(anho, mes)
        If dtDocumentosClientes.Rows.Count < 1 Then
            Exit Sub
        End If
        dgvDocClientes.DataSource = dtDocumentosClientes
        dgvDocClientes.Columns("T_DOC_REF").Visible = False
        dgvDocClientes.Columns("MONEDA").Visible = False
        dgvDocClientes.Columns("F_PAGO_ENT").Visible = False
        dgvDocClientes.Columns("CTCT_COD").Visible = False

        For i = 0 To dgvDocClientes.Columns.Count - 1
            dgvDocClientes.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        For i = 0 To dgvDocClientes.Rows.Count - 1
            dgvDocClientes.Rows(i).Cells("PROCESAR").Value = "PROCESAR"
        Next
    End Sub

    Private Sub dgvDocClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocClientes.CellClick
        Dim fila = dgvDocClientes.CurrentRow.Index
        If e.ColumnIndex = 0 And e.RowIndex = fila Then
            Dim resp = MsgBox("Desea Enviar el Correo", MsgBoxStyle.YesNo)
            If resp = 6 Then
                enviarCorreo(fila)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Sub enviarCorreo(ByVal fila As Integer)
        Try
            Dim borde As String = "2"
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.SubjectEncoding = System.Text.Encoding.UTF8

            correos.Body = "PRUEBA"
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8

            correos.To.Add("jefatura_sistemas@envaseslux.com")
            correos.From = New MailAddress("jefatura_sistemas@envaseslux.com")
            envios.Credentials = New NetworkCredential("jefatura_sistemas@envaseslux.com", "eljefaturasistemas")

            OpenFileDialog1.Multiselect = True
            OpenFileDialog1.ShowDialog()

            If Not OpenFileDialog1.FileNames.Count > 0 Then
                MsgBox("NO Selecciono Archivos")

                Exit Sub
            End If

            For Each archivo In OpenFileDialog1.FileNames
                Dim archivoAdjunto As New System.Net.Mail.Attachment(archivo)
                correos.Attachments.Add(archivoAdjunto)
            Next

            envios.Host = "mail.envaseslux.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class