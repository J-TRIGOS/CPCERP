Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormMantELTBTRANSPCHOFER

    Private bPrimero As Boolean
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBTRANSPCHOFERBL As New ELTBTRANSPCHOFERBL
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
                lblcho_cod.Text = ELTBTRANSPCHOFERBL.SelectMaxTransp(gLinea).PadLeft(3, "0")
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormMantELTBTRANSPCHOFER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case gnOpcion
            Case 0
                If Cerrar = "Guia" Then
                    txtctct_cod.Text = gLinea
                    lblcho_cod.Text = ELTBTRANSPCHOFERBL.SelectMaxTransp(gLinea).PadLeft(3, "0")
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
        gLinea = ""
    End Sub

    Private Function Limpiar()
        txtctct_cod.Text = ""
        txtchofer.Text = ""
        txtbrevete.Text = ""
        txtobserva.Text = ""
        lblcodigo.Text = ""
        lblcho_cod.Text = ""
    End Function

    Private Function Deshabilitar(ByVal A As Boolean)
        txtctct_cod.Enabled = A
    End Function

    Private Function OkData() As Boolean

        If txtctct_cod.Text = "" Then
            MsgBox("Seleccione el Trasnportista a Asociar", MsgBoxStyle.Exclamation)
            txtctct_cod.Focus()
            Return False
        End If

        If txtchofer.Text = "" Then
            MsgBox("Ingrese los Nombres del Chofer", MsgBoxStyle.Exclamation)
            txtchofer.Focus()
            Return False
        End If

        If txtbrevete.Text = "" Then
            MsgBox("Ingrese el Brevete del Chofer", MsgBoxStyle.Exclamation)
            txtbrevete.Focus()
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
        '    Dim ELTBTRANSPCHOFERBE As New ELTBTRANSPCHOFERBE
        '    ELTBTRANSPCHOFERBE.ctct_cod = Trim(txtctct_cod.Text)
        '    ELTBTRANSPCHOFERBE.cho_cod = Trim(txtcho_cod.Text)
        '    gsError = ELTBTRANSPCHOFERBL.SaveRow(ELTBTRANSPCHOFERBE, flagAccion)
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

        dtUsuario = ELTBTRANSPCHOFERBL.SelectRow(gsCode, sNDoc)
        For Each Registro In dtUsuario.Rows
            lblcho_cod.Text = sNDoc
            txtctct_cod.Text = gsCode
            txtchofer.Text = IIf(IsDBNull(Registro("CHOFER")), "", Registro("CHOFER"))
            txtbrevete.Text = IIf(IsDBNull(Registro("BREVETE")), "", Registro("BREVETE"))
            txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            lblcodigo.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
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
                Dim ELTBTRANSPCHOFERBE As New ELTBTRANSPCHOFERBE
                ELTBTRANSPCHOFERBE.ctct_cod = txtctct_cod.Text
                ELTBTRANSPCHOFERBE.chofer = txtchofer.Text
                ELTBTRANSPCHOFERBE.brevete = txtbrevete.Text
                ELTBTRANSPCHOFERBE.observa = txtobserva.Text
                ELTBTRANSPCHOFERBE.cho_cod = lblcho_cod.Text
                gsError = ELTBTRANSPCHOFERBL.SaveRow(ELTBTRANSPCHOFERBE, flagAccion)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

                    If (Cerrar = "Guia") Then
                        Dim frm As New FormTransportista
                        gLinea = lblcho_cod.Text
                        gSubLinea = txtchofer.Text
                        gArt = txtbrevete.Text
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
                lblcho_cod.Text = ELTBTRANSPCHOFERBL.SelectMaxTransp(txtctct_cod.Text).PadLeft(3, "0")
            Else
                MsgBox("No existe el codigo de Transportista", MsgBoxStyle.Exclamation)
                txtctct_cod.Text = ""
                lblcodigo.Text = ""
                lblcho_cod.Text = ""
            End If
        End If
    End Sub
End Class