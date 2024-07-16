Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBTIPOCAMBIO

    Private bPrimero As Boolean
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBTIPOCAMBIOBL As New ELTBTIPOCAMBIOBL
    Private flagAccion As String = ""
    Private MenuBL As New MenuBL

    Private Sub FormMantELTBTIPOCAMBIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        Dim dt As DataTable = ELTBTIPOCAMBIOBL.SelectT_Moneda()
        GetCmb("cod", "nom", dt, cmbmoneda)
        bPrimero = False
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
            Case 1
                flagAccion = "M"
                GetData(gsCode)
        End Select
    End Sub
    Private Function Limpiar()
        dtpfec.Value = ELTBTIPOCAMBIOBL.SelectMaxTransp()
        txtcompra.Text = 0
        txtventa.Text = 0
        txtmon_doc_ref.Text = "01"
    End Function
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = 1
    End Function

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
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub

    Private Sub cmbmoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmoneda.SelectedIndexChanged
        If bPrimero = True Then
            Exit Sub
        Else
            txtmon_doc_ref.Text = cmbmoneda.SelectedValue
        End If
    End Sub
    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        If sTDoc = "" Then
            dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(gsCode)
        Else
            dtUsuario = ELTBTIPOCAMBIOBL.SelectRow1(gsCode)
        End If

        For Each Registro In dtUsuario.Rows
            dtpfec.Value = sCode
            txtmon_doc_ref.Text = IIf(IsDBNull(Registro("MON_COD_REF")), "", Registro("MON_COD_REF"))
            txtcompra.Text = IIf(IsDBNull(Registro("COMPRA")), "0", Registro("COMPRA"))
            txtventa.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
            Dim a As Integer = Registro("MON_COD_REF")
            cmbmoneda.SelectedIndex = a
        Next
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            Dim mm As String
            Dim dd As String
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                If flagAccion = "N" Then
                    Dim dtFilas As DataTable = ELTBTIPOCAMBIOBL.Verificar_Repetido(dtpfec.Value)
                    If dtFilas.Rows.Count = 0 Then
                        Dim ELTBTIPOCAMBIOBE As New ELTBTIPOCAMBIOBE
                        ELTBTIPOCAMBIOBE.fec = dtpfec.Value
                        ELTBTIPOCAMBIOBE.mon_cod_ref = txtmon_doc_ref.Text
                        ELTBTIPOCAMBIOBE.compra = CDbl(txtcompra.Text)
                        ELTBTIPOCAMBIOBE.venta = CDbl(txtventa.Text)
                        ELTBTIPOCAMBIOBE.tipo = sTDoc
                        gsError = ELTBTIPOCAMBIOBL.SaveRow(ELTBTIPOCAMBIOBE, flagAccion)
                        If gsError = "OK" Then

                            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                            Dispose()
                        Else
                            FormMain.LblError.Text = gsError
                            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Ya Existe el tipo de cambio para esta fecha", MsgBoxStyle.Information)
                    End If
                Else
                    Dim ELTBTIPOCAMBIOBE As New ELTBTIPOCAMBIOBE
                    ELTBTIPOCAMBIOBE.fec = dtpfec.Value
                    ELTBTIPOCAMBIOBE.mon_cod_ref = txtmon_doc_ref.Text
                    ELTBTIPOCAMBIOBE.compra = CDbl(txtcompra.Text)
                    ELTBTIPOCAMBIOBE.venta = CDbl(txtventa.Text)
                    ELTBTIPOCAMBIOBE.tipo = sTDoc
                    If Month(dtpfec.Value).ToString.Length = 1 Then
                        mm = "0" & Month(dtpfec.Value)
                    Else
                        mm = Month(dtpfec.Value)
                    End If
                    If Mid(dtpfec.Value, 1, 2).ToString.Length = 1 Then
                        dd = "0" & Mid(dtpfec.Value, 1, 2)
                    Else
                        dd = Mid(dtpfec.Value, 1, 2)
                    End If
                    ELTBTIPOCAMBIOBE.fec1 = Year(dtpfec.Value) & mm & dd
                    gsError = ELTBTIPOCAMBIOBL.SaveRow(ELTBTIPOCAMBIOBE, flagAccion)
                    If gsError = "OK" Then
                        If ELTBTIPOCAMBIOBE.tipo = "" Then
                            If flagAccion = "M" Then
                                gsError2 = ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UC")
                                If gsError2 = "OK" Then
                                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                                    Dispose()
                                Else
                                    FormMain.LblError.Text = gsError
                                    MsgBox("Error al Actualizar Tipo de Cambio en Documento", MsgBoxStyle.Critical)
                                End If
                            Else
                                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                                Dispose()
                            End If
                        End If
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Actualizar Tipo de Cambio", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End If
    End Sub
    Private Function OkData() As Boolean

        If CInt(txtcompra.Text) <= 0 Then
            MsgBox("Ingrese un valor para compra", MsgBoxStyle.Exclamation)
            txtcompra.Focus()
            Return False
        End If

        If CInt(txtventa.Text) <= 0 Then
            MsgBox("Ingrese un valor para venta", MsgBoxStyle.Exclamation)
            txtventa.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub FormMantELTBTIPOCAMBIO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class