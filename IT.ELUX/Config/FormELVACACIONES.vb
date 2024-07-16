
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELVACACIONES

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELVACACIONESBL As New ELVACACIONESBL
    Private ELTBTAREOBL As New ELTBTAREOBL

    Private Sub FormELVACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                Deshabilitar(False)
                GetData(sTDoc, sSDoc)

        End Select
    End Sub
    Sub Deshabilitar(ByVal F As Boolean)
        txtper_cod.Enabled = F
        txtprdo_cod.Enabled = F
        chkactivar2.Checked = Not F
        GroupBox2.Enabled = Not F
        chkactivar.Checked = Not F
        GroupBox1.Enabled = Not F
    End Sub
    Private Sub Limpiar()
        'txtcod.Text = ""
        'txtdes.Text = ""
        'chkestado.Checked = False
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
                Dim ELVACACIONESBE As New ELVACACIONESBE
                ELVACACIONESBE.per_cod = txtper_cod.Text.Trim()
                If txtdias.Text.Trim = "" Then txtdias.Text = 0
                ELVACACIONESBE.dias = txtdias.Text.Trim()

                If chkactivar.Checked = True Then
                    ELVACACIONESBE.fec_fin_vac = dtpvaca_fin.Value
                    ELVACACIONESBE.fec_ini_vac = dtpvaca_ini.Value
                Else
                    ELVACACIONESBE.fec_ini_vac = Nothing
                    ELVACACIONESBE.fec_fin_vac = Nothing
                End If
                ELVACACIONESBE.fec_ini = dtpgose_ini.Value
                ELVACACIONESBE.fec_fin = dtpgose_fin.Value
                ELVACACIONESBE.observacion = txtobservacion.Text.Trim
                ELVACACIONESBE.prdo_cod = txtprdo_cod.Text.Trim
                ELVACACIONESBE.susp_cod = txtsusp_cod.Text.Trim

                gsError = ELVACACIONESBL.SaveRow(ELVACACIONESBE, flagAccion)
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

        If txtper_cod.Text = "" Then
            MsgBox("Ingrese el Personal", MsgBoxStyle.Exclamation)
            txtper_cod.Focus()
            Return False
        End If

        If txtprdo_cod.Text = "" Then
            MsgBox("Ingrese el Periodo de pago", MsgBoxStyle.Exclamation)
            txtprdo_cod.Focus()
            Return False
        End If

        If chkactivar.Checked = True Then
            If DateTime.Compare(dtpvaca_ini.Value, dtpvaca_fin.Value) >= 0 Then
                MsgBox("La Fecha final debe ser mayor al Inicio en Periodo Vacacional", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        If chkactivar2.Checked = True Then
            If DateTime.Compare(dtpgose_ini.Value, dtpgose_fin.Value) >= 0 Then
                MsgBox("La Fecha final debe ser mayor al Inicio en Periodo de Gose", MsgBoxStyle.Exclamation)
                Return False
            End If
        Else
            MsgBox("Ingrese las fechas en Periodo de Gose", MsgBoxStyle.Exclamation)
            chkactivar2.Focus()
            Return False
        End If

        If flagAccion = "N" Then
            If ELVACACIONESBL.VerificarRepetido(txtper_cod.Text, txtprdo_cod.Text) = True Then
                MsgBox("Ya existe el personal y el periodo de Pago", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sTDoc As String, ByVal ssDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELVACACIONESBL.SelectRow(sTDoc, ssDoc)
        For Each Registro In dtUsuario.Rows
            txtper_cod.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            lblper_cod.Text = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            lblfecha_ing.Text = IIf(IsDBNull(Registro("F_INGRESO")), "", Registro("F_INGRESO"))
            txtdias.Text = IIf(IsDBNull(Registro("DIAS")), "", Registro("DIAS"))
            txtprdo_cod.Text = IIf(IsDBNull(Registro("PRDO_COD")), "", Registro("PRDO_COD"))
            lblprdo_cod.Text = IIf(IsDBNull(Registro("PERIODO_PAGO")), "", Registro("PERIODO_PAGO"))
            txtsusp_cod.Text = IIf(IsDBNull(Registro("SUSP_COD")), "", Registro("SUSP_COD"))
            lblsusp_cod.Text = IIf(IsDBNull(Registro("T_SUSPENSION")), "", Registro("T_SUSPENSION"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVACION")), "", Registro("OBSERVACION"))

            If IsDBNull(Registro("VACACIONES_INI")) Then
                dtpvaca_ini.Value = DateTime.Now
                dtpvaca_fin.Value = DateTime.Now
                chkactivar.Checked = False
                GroupBox1.Enabled = False
            Else
                dtpvaca_ini.Value = Registro("VACACIONES_INI")
                dtpvaca_fin.Value = Registro("VACACIONES_FIN")
                chkactivar.Checked = True
                GroupBox1.Enabled = True
            End If

            dtpgose_ini.Value = IIf(IsDBNull(Registro("GOSE_INI")), DateTime.Now, Registro("GOSE_INI"))
            dtpgose_fin.Value = IIf(IsDBNull(Registro("GOSE_FIN")), DateTime.Now, Registro("GOSE_FIN"))
        Next
    End Sub

    Private Sub txtprdo_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprdo_cod.KeyPress, txtdias.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtper_cod_LostFocus(sender As Object, e As EventArgs) Handles txtper_cod.LostFocus
        If (txtper_cod.Text = "") Then
            lblper_cod.Text = ""
            lblfecha_ing.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBTAREOBL.SelectPerCOD(txtper_cod.Text)
            If dt.Rows.Count > 0 Then
                txtper_cod.Text = dt.Rows(0).Item(0).ToString
                lblper_cod.Text = dt.Rows(0).Item(1).ToString
                lblfecha_ing.Text = dt.Rows(0).Item(2).ToString
            Else
                txtper_cod.Text = ""
                lblper_cod.Text = ""
                lblfecha_ing.Text = ""
            End If
        End If
    End Sub

    Private Sub txtper_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "95"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
                lblfecha_ing.Text = gArt
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtprdo_cod_LostFocus(sender As Object, e As EventArgs) Handles txtprdo_cod.LostFocus
        If (txtprdo_cod.Text = "") Then
            lblprdo_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELVACACIONESBL.SelectPeriodoCOD(DateTime.Now.Year, txtprdo_cod.Text)
            If dt.Rows.Count > 0 Then
                txtprdo_cod.Text = dt.Rows(0).Item(0).ToString
                lblprdo_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtprdo_cod.Text = ""
                lblprdo_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtprdo_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprdo_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "258"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtprdo_cod.Text = gLinea
                lblprdo_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtsusp_cod_LostFocus(sender As Object, e As EventArgs) Handles txtsusp_cod.LostFocus
        If (txtsusp_cod.Text = "") Then
            lblsusp_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELVACACIONESBL.SelectSuspenCOD(txtsusp_cod.Text)
            If dt.Rows.Count > 0 Then
                txtsusp_cod.Text = dt.Rows(0).Item(0).ToString
                lblsusp_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtsusp_cod.Text = ""
                lblsusp_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtsusp_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsusp_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "78"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtsusp_cod.Text = gLinea
                lblsusp_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub chkactivar_CheckedChanged(sender As Object, e As EventArgs) Handles chkactivar.CheckedChanged
        If chkactivar.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub chkactivar2_CheckedChanged(sender As Object, e As EventArgs) Handles chkactivar2.CheckedChanged
        If chkactivar2.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub FormELVACACIONES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class