Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELUTILIDADES

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELUTILIDADESBL As New ELUTILIDADESBL
    Private ELTBTAREOBL As New ELTBTAREOBL

    Private Sub FormELUTILIDADES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                habilitar(True)
                Limpiar()
            Case 1
                flagAccion = "M"
                habilitar(False)
                GetData(sTDoc, sSDoc)
        End Select
    End Sub
    Private Sub habilitar(ByVal F As Boolean)
        cmb_año.Enabled = F
        txtper_cod.Enabled = F
    End Sub
    Private Sub Limpiar()
        txtper_cod.Text = ""
        txtmonto.Text = ""
        txtdscto.Text = ""
        txtobservación.Text = ""
        cmb_año.SelectedItem = DateTime.Now.ToString("yyyy")
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
                Dim ELUTILIDADESBE As New ELUTILIDADESBE

                ELUTILIDADESBE.anho = cmb_año.SelectedItem
                ELUTILIDADESBE.per_cod = txtper_cod.Text
                If txtmonto.Text = "" Then
                    ELUTILIDADESBE.monto = 0
                Else
                    ELUTILIDADESBE.monto = txtmonto.Text
                End If
                If txtdscto.Text = "" Then
                    ELUTILIDADESBE.dscto = 0
                Else
                    ELUTILIDADESBE.dscto = txtdscto.Text
                End If

                ELUTILIDADESBE.dia_pago = dtpfec_pag.Value
                ELUTILIDADESBE.observacion = txtobservación.Text

                gsError = ELUTILIDADESBL.SaveRow(ELUTILIDADESBE, flagAccion)
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
            If ELUTILIDADESBL.VerificarRepetido(cmb_año.SelectedItem, txtper_cod.Text) = True Then
                MsgBox("Ya existe la utilidad para este personal y año", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function
    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELUTILIDADESBL.SelectRow(sTDoc, sSDoc)
        For Each Registro In dtUsuario.Rows
            Dim anho As Integer = CInt(sTDoc) - 1
            cmb_año.SelectedItem = CStr(anho)
            txtper_cod.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            lblper_cod.Text = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            txtmonto.Text = IIf(IsDBNull(Registro("MONTO")), "", Registro("MONTO"))
            txtdscto.Text = IIf(IsDBNull(Registro("DSCTO")), "", Registro("DSCTO"))
            dtpfec_pag.Value = Registro("DIA_PAGO")
            txtobservación.Text = IIf(IsDBNull(Registro("OBSERVACION")), "", Registro("OBSERVACION"))
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
            sBusAlm = "36"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormELUTILIDADES_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class