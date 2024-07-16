Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELPROGRAMACION

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELPROGRAMACIONBL As New ELPROGRAMACIONBL
    Private ELTBTAREOBL As New ELTBTAREOBL

    Private Sub FormELPROGRAMACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dtpprogra_ini.Enabled = F
        'GroupBox2.Enabled = Not F
        'GroupBox1.Enabled = Not F
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
            Case "Periodo"
                Dim frm As New FormELPROGRAMACION_cuadro
                frm.Label1.Visible = True
                frm.txtprdo_cod.Visible = True
                frm.lblprdo_cod.Visible = True
                frm.Generar1.Visible = True
                frm.cancelar1.Visible = True

                frm.Label2.Visible = False
                frm.Label3.Visible = False
                frm.txtper_cod.Visible = False
                frm.lblper_cod.Visible = False
                frm.Generar2.Visible = False
                frm.cancelar2.Visible = False

                frm.Label5.Visible = False
                frm.txtlinea_cod.Visible = False
                frm.lbllinea_cod.Visible = False
                frm.Generar3.Visible = False
                frm.cancelar3.Visible = False
                frm.ShowDialog()
            Case "Personal"
                Dim frm As New FormELPROGRAMACION_cuadro
                frm.Label1.Visible = False
                frm.txtprdo_cod.Visible = False
                frm.lblprdo_cod.Visible = False
                frm.Generar1.Visible = False
                frm.cancelar1.Visible = False

                frm.Label2.Visible = True
                frm.Label3.Visible = True
                frm.txtper_cod.Visible = True
                frm.lblper_cod.Visible = True
                frm.Generar2.Visible = True
                frm.cancelar2.Visible = True

                frm.Label5.Visible = False
                frm.txtlinea_cod.Visible = False
                frm.lbllinea_cod.Visible = False
                frm.Generar3.Visible = False
                frm.cancelar3.Visible = False
                frm.ShowDialog()
            Case "ccosto"
                Dim frm As New FormELPROGRAMACION_cuadro
                frm.Label1.Visible = False
                frm.txtprdo_cod.Visible = False
                frm.lblprdo_cod.Visible = False
                frm.Generar1.Visible = False
                frm.cancelar1.Visible = False

                frm.Label2.Visible = False
                frm.Label3.Visible = False
                frm.txtper_cod.Visible = False
                frm.lblper_cod.Visible = False
                frm.Generar2.Visible = False
                frm.cancelar2.Visible = False

                frm.Label5.Visible = True
                frm.txtlinea_cod.Visible = True
                frm.lbllinea_cod.Visible = True
                frm.Generar3.Visible = True
                frm.cancelar3.Visible = True
                frm.ShowDialog()

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
                Dim ELPROGRAMACIONBE As New ELPROGRAMACIONBE

                If flagAccion = "M" Then
                    ELPROGRAMACIONBE.per_cod = txtper_cod.Text
                    If txtprdo_cod.Text = "" Then ELPROGRAMACIONBE.prdo_cod = "0" Else ELPROGRAMACIONBE.prdo_cod = txtprdo_cod.Text
                    ELPROGRAMACIONBE.d_programado = dtpprogra_ini.Value
                    If txtdscto.Text = "" Then ELPROGRAMACIONBE.dscto = "0" Else ELPROGRAMACIONBE.dscto = txtdscto.Text
                    If txtminutos.Text = "" Then ELPROGRAMACIONBE.minutos = "0" Else ELPROGRAMACIONBE.minutos = txtminutos.Text
                    If txtmin1.Text = "" Then ELPROGRAMACIONBE.min1 = "0" Else ELPROGRAMACIONBE.min1 = txtmin1.Text
                    If txtmin2.Text = "" Then ELPROGRAMACIONBE.min2 = "0" Else ELPROGRAMACIONBE.min2 = txtmin2.Text
                    If txtt_dscto1.Text = "" Then ELPROGRAMACIONBE.t_dscto1 = "0" Else ELPROGRAMACIONBE.t_dscto1 = txtt_dscto1.Text
                    If txtt_dscto2.Text = "" Then ELPROGRAMACIONBE.t_dscto2 = "0" Else ELPROGRAMACIONBE.t_dscto2 = txtt_dscto2.Text
                    If txttiempo_dscto.Text = "" Then ELPROGRAMACIONBE.tiempo_dscto = "0" Else ELPROGRAMACIONBE.tiempo_dscto = txttiempo_dscto.Text
                    ELPROGRAMACIONBE.linea_cod = txtlinea_cod.Text
                    ELPROGRAMACIONBE.observacion = txtobservacion.Text
                End If

                gsError = ELPROGRAMACIONBL.SaveRow(ELPROGRAMACIONBE, flagAccion, dgvDatos)
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
            If dgvDatos.Rows.Count < 1 Then
                MsgBox("Ingrese datos a la Lista", MsgBoxStyle.Exclamation)
                txtper_cod.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sTDoc As String, ByVal ssDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPROGRAMACIONBL.SelectRow(sTDoc, ssDoc)
        For Each Registro In dtUsuario.Rows
            txtper_cod.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            lblper_cod.Text = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            txtlinea_cod.Text = IIf(IsDBNull(Registro("LINEA_COD")), "", Registro("LINEA_COD"))
            lbllinea_cod.Text = IIf(IsDBNull(Registro("NOMBRE")), "", Registro("NOMBRE"))
            txtprdo_cod.Text = IIf(IsDBNull(Registro("PRDO_COD")), "", Registro("PRDO_COD"))
            lblprdo_cod.Text = IIf(IsDBNull(Registro("PERIODO_PAGO")), "", Registro("PERIODO_PAGO"))
            dtpprogra_ini.Value = IIf(IsDBNull(Registro("D_PROGRAMADO")), "", Registro("D_PROGRAMADO"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVACION")), "", Registro("OBSERVACION"))
            txtminutos.Text = IIf(IsDBNull(Registro("MINUTOS")), "", Registro("MINUTOS"))
            txtmin1.Text = IIf(IsDBNull(Registro("MIN1")), "", Registro("MIN1"))
            txtmin2.Text = IIf(IsDBNull(Registro("MIN2")), "", Registro("MIN2"))
            txttiempo_dscto.Text = IIf(IsDBNull(Registro("TIEMPO_DSCTO")), "", Registro("TIEMPO_DSCTO"))
            txtt_dscto1.Text = IIf(IsDBNull(Registro("T_DSCTO1")), "", Registro("T_DSCTO1"))
            txtt_dscto2.Text = IIf(IsDBNull(Registro("T_DSCTO2")), "", Registro("T_DSCTO2"))
        Next
    End Sub

    Private Sub txtprdo_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprdo_cod.KeyPress, txtper_cod.KeyPress, txtminutos.KeyPress, txtmin1.KeyPress, txtmin2.KeyPress, txttiempo_dscto.KeyPress, txtt_dscto1.KeyPress, txtt_dscto2.KeyPress, txtdscto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    'Private Sub txtper_cod_LostFocus(sender As Object, e As EventArgs) Handles txtper_cod.LostFocus
    '    If (txtper_cod.Text = "") Then
    '        lblper_cod.Text = ""
    '    Else
    '        Dim dt As DataTable
    '        dt = ELTBTAREOBL.SelectPerCOD(txtper_cod.Text)
    '        If dt.Rows.Count > 0 Then
    '            txtper_cod.Text = dt.Rows(0).Item(0).ToString
    '            lblper_cod.Text = dt.Rows(0).Item(1).ToString
    '        Else
    '            txtper_cod.Text = ""
    '            lblper_cod.Text = ""
    '        End If
    '    End If
    'End Sub

    Private Sub txtper_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "81"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtprdo_cod_LostFocus(sender As Object, e As EventArgs) Handles txtprdo_cod.LostFocus
        If (txtprdo_cod.Text = "") Then
            lblprdo_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELPROGRAMACIONBL.SelectPeriodoCOD(DateTime.Now.Year, txtprdo_cod.Text)
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
            sBusAlm = "77"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtprdo_cod.Text = gLinea
                lblprdo_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtlinea_cod_LostFocus(sender As Object, e As EventArgs) Handles txtlinea_cod.LostFocus
        If (txtlinea_cod.Text = "") Then
            lbllinea_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELPROGRAMACIONBL.SelectAreaCOD(txtlinea_cod.Text)
            If dt.Rows.Count > 0 Then
                txtlinea_cod.Text = dt.Rows(0).Item(0).ToString
                lbllinea_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtlinea_cod.Text = ""
                lbllinea_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtlinea_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "80"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtlinea_cod.Text = gLinea
                lbllinea_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormELPROGRAMACION_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If dgvDatos.Rows.Count < 1 Then
            MsgBox("No hay Registros que borrar", MsgBoxStyle.Exclamation)
        Else
            dgvDatos.Rows.Remove(dgvDatos.CurrentRow)
            dgvDatos.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvDatos.Rows.Count < 1 Then
            MsgBox("No hay Registros que borrar", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show("Desea Borrar toda la lista", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                dgvDatos.Rows.Clear()
                dgvDatos.DataSource = Nothing
                dgvDatos.Refresh()
            End If

        End If
    End Sub
End Class