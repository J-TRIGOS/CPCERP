Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELLIQUIDACION

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELLIQUIDACIONBL As New ELLIQUIDACIONBL
    Private ELVACACIONESBL As New ELVACACIONESBL
    Private ELTBTAREOBL As New ELTBTAREOBL

    Private Sub FormELLIQUIDACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                habilitar(True)
                Limpiar()
            Case 1
                flagAccion = "M"
                habilitar(False)
                GetData(sTDoc, sSDoc, sNDoc)
        End Select
    End Sub
    Private Sub habilitar(ByVal F As Boolean)
        cmb_año.Enabled = F
        txtper_cod.Enabled = F
        cmb_mes.Enabled = F
    End Sub
    Private Sub Limpiar()
        txtper_cod.Text = ""
        txtmonto.Text = ""
        cmb_año.SelectedItem = DateTime.Now.ToString("yyyy")
        Dim a As Integer = DateTime.Now.Month
        cmb_mes.SelectedIndex = a - 1
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
                Dim ELLIQUIDACIONBE As New ELLIQUIDACIONBE

                ELLIQUIDACIONBE.per_cod = txtper_cod.Text
                ELLIQUIDACIONBE.anho = cmb_año.SelectedItem
                ELLIQUIDACIONBE.mes = cmb_mes.SelectedItem.ToString.Substring(0, 2)
                ELLIQUIDACIONBE.monto = txtmonto.Text
                ELLIQUIDACIONBE.interes = txtinteres.Text
                ELLIQUIDACIONBE.monto_cts = txtcts.Text
                ELLIQUIDACIONBE.vacaciones = txtvacaciones.Text
                ELLIQUIDACIONBE.gratis = txtgrati.Text
                ELLIQUIDACIONBE.Hextras = txthextras.Text
                ELLIQUIDACIONBE.comision = txtcomision.Text
                ELLIQUIDACIONBE.subsidio = txtsubsidio.Text
                ELLIQUIDACIONBE.meses = txtmeses.Text
                ELLIQUIDACIONBE.dias = txtdias.Text
                ELLIQUIDACIONBE.prdo_pago = txtprdo.Text

                gsError = ELLIQUIDACIONBL.SaveRow(ELLIQUIDACIONBE, flagAccion)
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
            MsgBox("Ingrese los Nombres del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        If flagAccion = "N" Then
            If ELLIQUIDACIONBL.VerificarRepetido(cmb_año.SelectedItem, cmb_mes.SelectedItem.ToString.Substring(0, 2), txtper_cod.Text) = True Then
                MsgBox("Ya existe la cts para este personal", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function
    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELLIQUIDACIONBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            cmb_año.SelectedItem = sTDoc
            cmb_mes.SelectedIndex = sSDoc - 1
            txtper_cod.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            lblper_cod.Text = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            txtmonto.Text = IIf(IsDBNull(Registro("MONTO")), "", Registro("MONTO"))
            txtinteres.Text = IIf(IsDBNull(Registro("INTERES")), "", Registro("INTERES"))
            txtcts.Text = IIf(IsDBNull(Registro("MONTO_CTS")), "", Registro("MONTO_CTS"))
            txtvacaciones.Text = IIf(IsDBNull(Registro("VACACIONES")), "", Registro("VACACIONES"))
            txtgrati.Text = IIf(IsDBNull(Registro("GRATIFICACION")), "", Registro("GRATIFICACION"))
            txthextras.Text = IIf(IsDBNull(Registro("HORAS_EXTRAS")), "", Registro("HORAS_EXTRAS"))
            txtcomision.Text = IIf(IsDBNull(Registro("COMISION")), "", Registro("COMISION"))
            txtsubsidio.Text = IIf(IsDBNull(Registro("SUBSIDIO")), "", Registro("SUBSIDIO"))
            txtmeses.Text = IIf(IsDBNull(Registro("MESES")), "", Registro("MESES"))
            txtdias.Text = IIf(IsDBNull(Registro("DIAS")), "", Registro("DIAS"))
            txtprdo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            lblprdo.Text = IIf(IsDBNull(Registro("PERIODO")), "", Registro("PERIODO"))
        Next
    End Sub
    Private Sub txtper_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtper_cod.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtper_cod_LostFocus(sender As Object, e As EventArgs) Handles txtper_cod.LostFocus
        If (txtper_cod.Text = "") Then
            lblper_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBTAREOBL.SelectPerCOD(txtper_cod.Text)
            If dt.Rows.Count > 0 Then
                txtper_cod.Text = dt.Rows(0).Item(0).ToString
                lblper_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtper_cod.Text = ""
                lblper_cod.Text = ""
            End If
        End If
    End Sub
    Private Sub txtper_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "63"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub ttxtprdo_LostFocus(sender As Object, e As EventArgs) Handles txtprdo.LostFocus
        If (txtprdo.Text = "") Then
            lblprdo.Text = ""
        Else
            Dim dt As DataTable
            dt = ELVACACIONESBL.SelectPeriodoCOD(DateTime.Now.Year, txtprdo.Text)
            If dt.Rows.Count > 0 Then
                txtprdo.Text = dt.Rows(0).Item(0).ToString
                lblprdo.Text = dt.Rows(0).Item(1).ToString
            Else
                txtprdo.Text = ""
                lblprdo.Text = ""
            End If
        End If
    End Sub
    Private Sub txtprdo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprdo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "77"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtprdo.Text = gLinea
                lblprdo.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormELUTILIDADES_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress, txtinteres.KeyPress, txtcts.KeyPress, txtvacaciones.KeyPress, txtgrati.KeyPress, txthextras.KeyPress, txtcomision.KeyPress, txtsubsidio.KeyPress, txtmeses.KeyPress, txtdias.KeyPress, txtprdo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class