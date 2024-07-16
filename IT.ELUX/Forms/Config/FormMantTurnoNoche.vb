Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.ComponentModel
Public Class FormMantTurnoNoche
    Private ELTBTURNOBL As New ELTBTURNOBL
    Private PERBL As New PERBL
    Dim codigo, cof, cot, nomper, est, indi, indice_g As String
    Public mes As String
    Private Sub FormMantTurnoNoche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Turnos"
        If Month(Date.Today) <> 12 Then
            dptfecha.MinDate = DateSerial(Year(Date.Today), Month(Date.Today), 1)
            dptfecha.MaxDate = DateSerial(Year(Date.Today), 12, 31)
        Else
            Dim fec As Date = Date.Today.AddYears(+1)
            dptfecha.MinDate = DateSerial(Year(Date.Today), 12, 1)
            dptfecha.MaxDate = DateSerial(Year(fec), 1, 31)
        End If
        If Month(Date.Today) <> 12 Then
            dtpfecfin.MinDate = DateSerial(Year(Date.Today), Month(Date.Today), 1)
            dtpfecfin.MaxDate = DateSerial(Year(Date.Today), 12, 31)
        Else
            Dim fec As Date = Date.Today.AddYears(+1)
            dtpfecfin.MinDate = DateSerial(Year(Date.Today), 12, 1)
            dtpfecfin.MaxDate = DateSerial(Year(fec), 1, 31)
        End If
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                lblindice.Text = ELTBTURNOBL.SelectIndice(mes) + 1
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                'dgvdatos.Refresh()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "5"
        Dim frm As New FormPerGrupo
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtper.Text = gLinea
            txtnomper.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtper.Text = "" Then
            MsgBox("Ingrese el documento del Usuario", MsgBoxStyle.Exclamation)
            txtper.Focus()
        Else
            If DateTime.Compare(dtpfecfin.Value, dptfecha.Value) < 0 Then
                MsgBox("La fecha de inicio no debe ser mayor a la fecha final", MsgBoxStyle.Exclamation)
                dptfecha.Focus()
            Else
                If dgvdatos.Rows.Count > 0 Then

                    For i = 0 To dgvdatos.Rows.Count - 1
                        If dptfecha.Text = dgvdatos.Rows(i).Cells("fec_inicio").Value Then
                            MsgBox("La fecha debe ser diferente a la ya declarada")
                            Exit Sub
                        End If
                    Next
                    If cmbestado.SelectedIndex = 1 Then
                        dgvdatos.Rows.Add(txtper.Text, dptfecha.Text, dtpfecfin.Text, "Habilitado", lblindice.Text)
                    ElseIf cmbestado.SelectedIndex = 2 Then
                        dgvdatos.Rows.Add(txtper.Text, dptfecha.Text, dtpfecfin.Text, "Anulado", lblindice.Text)
                    End If
                    dtpfecfin.Value = Date.Now
                    dptfecha.Value = Date.Now
                    txtper.Text = ""
                    txtnomper.Text = ""
                    cmbestado.SelectedIndex = 1
                    lblindice.Text = lblindice.Text + 1
                Else
                    If cmbestado.SelectedIndex = 1 Then
                        dgvdatos.Rows.Add(txtper.Text, dptfecha.Text, dtpfecfin.Text, "Habilitado", lblindice.Text)
                    ElseIf cmbestado.SelectedIndex = 2 Then
                        dgvdatos.Rows.Add(txtper.Text, dptfecha.Text, dtpfecfin.Text, "Anulado", lblindice.Text)
                    Else
                        MsgBox("Debe marcar el estado")
                    End If
                    dtpfecfin.Value = Date.Now
                    dptfecha.Value = Date.Now
                    txtper.Text = ""
                    txtnomper.Text = ""
                    cmbestado.SelectedIndex = 1
                    lblindice.Text = lblindice.Text + 1
                End If
            End If
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()
            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    SaveData()
                    Dispose()
                Case "delete"
                    DeleteData()
                Case "exit"
                    Dispose()
                    Exit Sub

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdatos.CellContentClick
        If dgvdatos.Rows.Count > 0 Then
            dptfecha.Text = dgvdatos.Rows(dgvdatos.CurrentRow.Index).Cells("FEC_INICIO").Value
            dtpfecfin.Text = dgvdatos.Rows(dgvdatos.CurrentRow.Index).Cells("FEC_FIN").Value
            If dgvdatos.Rows(dgvdatos.CurrentRow.Index).Cells("ESTADO").Value = "H" Then
                cmbestado.SelectedIndex = 1
            ElseIf dgvdatos.Rows(dgvdatos.CurrentRow.Index).Cells("ESTADO").Value = "A" Then
                cmbestado.SelectedIndex = 2
            Else
                cmbestado.SelectedIndex = -1
            End If
            'lblindice.Text = dgvdatos.Rows(dgvdatos.CurrentRow.Index).Cells("INDICE").Value
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvdatos.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            dgvdatos.Rows.RemoveAt(dgvdatos.CurrentRow.Index)
            dgvdatos.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBTURNOBE As New ELTBTURNOBE
                ELTBTURNOBE.USUARIO = gsUser
                ELTBTURNOBE.PER_COD = txtper.Text
                ELTBTURNOBE.FEC_INICIO = dptfecha.Text
                ELTBTURNOBE.FEC_FIN = dtpfecfin.Text
                If cmbestado.SelectedIndex = 0 Then
                    ELTBTURNOBE.EST = ""
                ElseIf cmbestado.SelectedIndex = 1 Then
                    ELTBTURNOBE.EST = "H"
                ElseIf cmbestado.SelectedIndex = 2 Then
                    ELTBTURNOBE.EST = "A"
                Else
                    ELTBTURNOBE.EST = ""
                End If
                If flagAccion = "N" Then
                    ELTBTURNOBE.INDICE = ELTBTURNOBL.SelectIndice(mes)
                Else
                    ELTBTURNOBE.INDICE = lblindice.Text
                End If
                ELTBTURNOBE.MES = mes

                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                If TabPage1.Visible Then
                    gsError = ELTBTURNOBL.SaveRow(ELTBTURNOBE, ELMVLOGSBE, flagAccion, dgvdatos)
                Else
                    gsError = ELTBTURNOBL.SaveRow(ELTBTURNOBE, ELMVLOGSBE, flagAccion, dgvdatos)
                End If

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
        If flagAccion = "N" Then
            If dgvdatos.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        dtpfecfin.Value = Date.Now
        dptfecha.Value = Date.Now
        txtper.Text = ""
        txtnomper.Text = ""
        cmbestado.SelectedIndex = 1
        lblindice.Text = ELTBTURNOBL.SelectIndice(mes)

    End Sub

    Private Sub GetData(ByVal gsCode As String)
        'Dim dtUsuario As DataTable
        'Dim Registro As DataRow

        'dtUsuario = ELTBTURNOBL.SelectRow(gsCode, sAño & mes)
        'For Each Registro In dtUsuario.Rows

        '    codigo = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
        '    'nomper = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
        '    cof = IIf(IsDBNull(Registro("FEC_INICIO")), "", Registro("FEC_INICIO"))
        '    cot = IIf(IsDBNull(Registro("FEC_FIN")), "", Registro("FEC_FIN"))
        '    est = IIf(IsDBNull(Registro("est")), "", Registro("est"))
        '    indi = IIf(IsDBNull(Registro("indice")), "", Registro("indice"))
        '    dgvdatos.Rows.Add(codigo, cof, cot, est, indi)
        'Next
        'Dim comboCell2 As DataGridViewComboBoxCell
        'comboCell2 = New DataGridViewComboBoxCell
        'comboCell2.Items.Add("")
        'comboCell2.Items.Add("DIURNO")
        'comboCell2.Items.Add("NOCTURNO")
        'Dim indice As Integer
        'indice = dgvdatos.Rows.Count - 1
        'dgvdatos.Rows(indice).Cells(2) = comboCell2
        'dgvdatos.Rows(indice).Cells(2).Value = cot
    End Sub

    Private Sub FormMantTurnoNoche_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub DeleteData()
        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        Else
            flagAccion = "E"
            Dim ELTBTURNOBE As New ELTBTURNOBE
            ELTBTURNOBE.PER_COD = txtper.Text
            ELTBTURNOBE.FEC_INICIO = dptfecha.Text
            ELTBTURNOBE.FEC_FIN = dtpfecfin.Text
            ELTBTURNOBE.INDICE = lblindice.Text
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELMVLOGSBE.log_codusu = gsCodUsr
            If cmbestado.SelectedIndex = 1 Then
                ELTBTURNOBE.EST = "H"
            Else
                ELTBTURNOBE.EST = "A"
            End If
            ELTBTURNOBE.MES = mes
            gsError = ELTBTURNOBL.SaveRow(ELTBTURNOBE, ELMVLOGSBE, flagAccion, dgvdatos)
            If gsError = "OK" Then
                MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub txtper_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "5"
            Dim frm As New FormPerGrupo
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper.Text = gLinea
                txtnomper.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtper_LostFocus(sender As Object, e As EventArgs) Handles txtper.LostFocus
        If txtper.TextLength = 8 Then
            txtnomper.Text = PERBL.SelectApeNom(txtper.Text)
        Else
            txtnomper.Text = ""
        End If

    End Sub
End Class