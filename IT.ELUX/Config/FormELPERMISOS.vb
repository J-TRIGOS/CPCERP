Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELPERMISOS
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private ELPERMISOSBL As New ELPERMISOSBL
    Private Sub DeleteData()

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        flagAccion = "E"
        Dim ELTBALMACENBE As New ELTBALMACENBE
        ELTBALMACENBE.alm_codigo = Trim(txtndoc.Text)

        Dim dTable As New DataTable
        Dim ELPERMISOSBE As New ELPERMISOSBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELPERMISOSBE.ndoc = txtndoc.Text
        ELPERMISOSBE.sdoc = txtsdoc.Text
        gsError = ELPERMISOSBL.SaveRowS(ELPERMISOSBE, ELMVLOGSBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormELPERMISOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Dim año As String = DateTime.Now.ToString("yyyy")
                txtsdoc.Text = DateTime.Now.ToString("yyyy")
                txtndoc.Text = ELPERMISOSBL.SelectNro(año)
                dtpfec_ini.Value = DateTime.Now.ToString("dd/MM/yyyy")
                dtpfec_fin.Value = DateTime.Now.ToString("dd/MM/yyyy")
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                Deshabilitar(False)
                GetData(sSDoc, sNDoc)
                txtsdoc.Text = sSDoc
                txtndoc.Text = sNDoc
        End Select
    End Sub
    Sub Deshabilitar(ByVal F As Boolean)
        'txtper_cod.Enabled = F
        'txtprdo_cod.Enabled = F
        'chkactivar2.Checked = Not F
        'GroupBox2.Enabled = Not F
        'chkactivar.Checked = Not F
        'GroupBox1.Enabled = Not F
    End Sub
    Private Sub Limpiar()
        cmb_motivo.SelectedItem = DateTime.Now.ToString("yyyy")
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
                If DateTime.Now.ToString("yyyyMM") = dtpfec_ini.Value.ToString("yyyyMM") Then
                    DeleteData()
                Else
                    MsgBox("Esta fuera de mes")
                End If
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
                Dim ELPERMISOSBE As New ELPERMISOSBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELPERMISOSBE.sdoc = txtsdoc.Text
                ELPERMISOSBE.ndoc = txtndoc.Text
                ELPERMISOSBE.per_cod = txtper_cod.Text
                'ELPERMISOSBE.dias = txtdias.text
                ELPERMISOSBE.fec_ini = dtpfec_ini.Value.ToShortDateString
                ELPERMISOSBE.fec_fin = dtpfec_fin.Value.ToShortDateString
                ELPERMISOSBE.observacion = txtdescripcion.Text
                ELPERMISOSBE.subs = txtsubsidio.Text
                If txtminutos.Text = "" Then
                    ELPERMISOSBE.minutos = "0"
                Else
                    ELPERMISOSBE.minutos = txtminutos.Text
                End If
                If txtminutos1.Text = "" Then
                    ELPERMISOSBE.minutos1 = "0"
                Else
                    ELPERMISOSBE.minutos1 = txtminutos1.Text
                End If
                Select Case cmb_motivo.SelectedIndex
                    Case 0
                        ELPERMISOSBE.motivo = "P"
                    Case 1
                        ELPERMISOSBE.motivo = "S"
                    Case 2
                        ELPERMISOSBE.motivo = "D"
                    Case 3
                        ELPERMISOSBE.motivo = "O"
                    Case 4
                        ELPERMISOSBE.motivo = "E"
                End Select
                Select Case cmb_motivo1.SelectedIndex
                    Case 0
                        ELPERMISOSBE.motivo1 = "A"
                    Case 1
                        ELPERMISOSBE.motivo1 = "C"
                    Case 2
                        ELPERMISOSBE.motivo1 = "E"
                    Case 3
                        ELPERMISOSBE.motivo1 = "O"
                End Select
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELPERMISOSBL.SaveRow(ELPERMISOSBE, ELMVLOGSBE, flagAccion)
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
            MsgBox("Ingrese dni del personal", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese una observacion", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmb_motivo.SelectedIndex = -1 Then
            MsgBox("Seleccione un motivo", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmb_motivo1.SelectedIndex = -1 Then
            MsgBox("Seleccione una contingencia", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPERMISOSBL.SelectRow(sTDoc, sSDoc)
        For Each Registro In dtUsuario.Rows
            txtper_cod.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            lblper_cod.Text = IIf(IsDBNull(Registro("NOMBRES")), "", Registro("NOMBRES"))
            dtpfec_ini.Value = Registro("F_INICIO")
            dtpfec_fin.Value = Registro("F_FINAL")
            txtdescripcion.Text = IIf(IsDBNull(Registro("OBSERVACION")), "", Registro("OBSERVACION"))
            txtsubsidio.Text = IIf(IsDBNull(Registro("SUBSIDIO")), "", Registro("SUBSIDIO"))
            txtminutos.Text = IIf(IsDBNull(Registro("DESCTO")), "", Registro("DESCTO"))
            txtminutos1.Text = IIf(IsDBNull(Registro("COSTO_EMP")), "", Registro("COSTO_EMP"))
            cmb_motivo.SelectedItem = IIf(IsDBNull(Registro("MOTIVO")), "", Registro("MOTIVO"))
            cmb_motivo1.SelectedItem = IIf(IsDBNull(Registro("MOTIVO_SALUD")), "", Registro("MOTIVO_SALUD"))

        Next
    End Sub

    Private Sub txtper_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtper_cod.KeyPress, txtminutos.KeyPress, txtminutos1.KeyPress
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
            sBusAlm = "82"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
                gLinea = ""
                gSubLinea = ""
            Else
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub FormELPERMISOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub dtpfec_fin_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_fin.LostFocus
        If flagAccion = "N" Then
            txtndoc.Text = ELPERMISOSBL.SelectNro(dtpfec_ini.Value.Year)
            txtsdoc.Text = DateTime.Now.ToString("yyyy")
        End If

    End Sub
End Class