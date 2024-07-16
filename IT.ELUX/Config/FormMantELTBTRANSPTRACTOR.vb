Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormMantELTBTRANSPTRACTOR
    Private bPrimero As Boolean
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBTRANSPTRACTORBL As New ELTBTRANSPTRACTORBL
    Private ELTBTRANSPBL As New ELTBTRANSPBL
    Private flagAccion As String = ""
    Private MenuBL As New MenuBL


    Private Sub txtctct_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtctct_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "84"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtctct_cod.Text = gLinea
                lblcodigo.Text = gSubLinea
                lblcho_cod.Text = ELTBTRANSPTRACTORBL.SelectMaxTransp(txtctct_cod.Text)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormMantELTBTRANSPTRACTOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case gnOpcion
            Case 0
                If Cerrar = "Guia" Then
                    txtctct_cod.Text = gLinea
                    lblcho_cod.Text = ELTBTRANSPTRACTORBL.SelectMaxTransp(gLinea).PadLeft(3, "0")
                    lblcodigo.Text = gSubLinea
                    txtctct_cod.Enabled = False
                    flagAccion = "N"
                    txtctct_cod_Leave(sender, e)
                Else
                    flagAccion = "N"
                    Limpiar()
                    Deshabilitar(True)
                End If
            Case 1
                flagAccion = "M"
                GetData(gsCode, sNDoc)
                Deshabilitar(False)
        End Select
    End Sub
    Private Function Limpiar()
        lblcho_cod.Text = ""
        txtctct_cod.Text = ""
        txtplaca.Text = ""
        txtmarca.Text = ""
        txtobservacion.Text = ""
        txtcertificado.Text = ""
        txtconfig_vehi.Text = ""
        lblcodigo.Text = ""
    End Function
    Private Function Deshabilitar(ByVal A As Boolean)
        txtctct_cod.Enabled = A
    End Function
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Function OkData() As Boolean
        If txtctct_cod.Text = "" Then
            MsgBox("Seleccione el Trasnportista a Asociar", MsgBoxStyle.Exclamation)
            txtctct_cod.Focus()
            Return False
        End If
        If txtplaca.Text = "" Then
            MsgBox("Ingrese los Placa del Vehiculo", MsgBoxStyle.Exclamation)
            txtplaca.Focus()
            Return False
        End If
        If txtmarca.Text = "" Then
            MsgBox("Ingrese la Marca del Vehiculo", MsgBoxStyle.Exclamation)
            txtmarca.Focus()
            Return False
        End If
        If cmbtipo.SelectedIndex = -1 Then
            MsgBox("Ingrese el tipo de Vehiculo", MsgBoxStyle.Exclamation)
            txtmarca.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub DeleteData()
        'If MessageBox.Show("Esta seguro de Eliminar el Registro",
        '                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'Else
        '    flagAccion = "E"
        '    Dim ELTBTRANSPTRACTORBE As New ELTBTRANSPTRACTORBE
        '    ELTBTRANSPTRACTORBE.ctct_cod = Trim(txtctct_cod.Text)
        '    ELTBTRANSPTRACTORBE.cor = Trim(txtcho_cod.Text)
        '    gsError = ELTBTRANSPTRACTORBL.SaveRow(ELTBTRANSPTRACTORBE, flagAccion)
        '    If gsError = "OK" Then
        '        MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
        '        Dispose()
        '    Else
        '        FormMain.LblError.Text = gsError
        '        MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        '    End If
        'End If
    End Sub

    Private Sub GetData(ByVal sCode As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBTRANSPTRACTORBL.SelectRow(gsCode, sNDoc)
        For Each Registro In dtUsuario.Rows
            txtctct_cod.Text = gsCode
            lblcho_cod.Text = sNDoc
            txtplaca.Text = IIf(IsDBNull(Registro("PLACA")), "", Registro("PLACA"))
            txtmarca.Text = IIf(IsDBNull(Registro("MARCA")), "", Registro("MARCA"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVACION")), "", Registro("OBSERVACION"))
            txtconfig_vehi.Text = IIf(IsDBNull(Registro("CONFIG_VEHI")), "", Registro("CONFIG_VEHI"))
            lblcodigo.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            Dim b As Integer = Registro("TIPO")
            cmbtipo.SelectedIndex = b - 1
        Next
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBTRANSPTRACTORBE As New ELTBTRANSPTRACTORBE
                ELTBTRANSPTRACTORBE.ctct_cod = txtctct_cod.Text
                ELTBTRANSPTRACTORBE.cor = lblcho_cod.Text
                ELTBTRANSPTRACTORBE.placa = txtplaca.Text
                ELTBTRANSPTRACTORBE.marca = txtmarca.Text
                ELTBTRANSPTRACTORBE.observacion = txtobservacion.Text
                ELTBTRANSPTRACTORBE.certificado = txtcertificado.Text
                ELTBTRANSPTRACTORBE.config_vehi = txtconfig_vehi.Text
                ELTBTRANSPTRACTORBE.tipo = (cmbtipo.SelectedIndex + 1).ToString().PadLeft(2, "0")

                gsError = ELTBTRANSPTRACTORBL.SaveRow(ELTBTRANSPTRACTORBE, flagAccion)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If (Cerrar = "Guia") Then
                        Dim frm As New FormTransportista
                        gLinea = txtplaca.Text
                        gSubLinea = txtconfig_vehi.Text
                        gArt = txtmarca.Text
                        gsCode2 = txtcertificado.Text
                        gsCode3 = cmbtipo.SelectedItem
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
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
                DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub txtctct_cod_Leave(sender As Object, e As EventArgs) Handles txtctct_cod.Leave
        If txtctct_cod.Text = "" Then
            lblcodigo.Text = ""
            lblcho_cod.Text = ""
        Else
            Dim dt As DataTable = ELTBTRANSPBL.SelectRow(txtctct_cod.Text)
            If dt.Rows.Count > 0 Then
                lblcodigo.Text = dt.Rows(0).Item(1).ToString
                lblcho_cod.Text = ELTBTRANSPTRACTORBL.SelectMaxTransp(txtctct_cod.Text)
            Else
                MsgBox("No existe el codigo de Transportista", MsgBoxStyle.Exclamation)
                txtctct_cod.Text = ""
                lblcodigo.Text = ""
                lblcho_cod.Text = ""
            End If
        End If
    End Sub
End Class