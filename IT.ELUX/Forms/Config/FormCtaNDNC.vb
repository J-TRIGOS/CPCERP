Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Public Class FormCtaNDNC
    Private ELTBCTA_FACTURACIONBL As New ELTBCTA_FACTURACIONBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private PROVISIONESBL As New PROVISIONESBL
    'Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private moneda As String
    Private Sub btn_br_Click(sender As Object, e As EventArgs) Handles btn_br.Click
        sBusAlm = "55"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txt_bruta.Text = gLinea
            'TextBox6.Text = gSubLinea
            TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub btntodos_Click(sender As Object, e As EventArgs) Handles btntodos.Click
        sBusAlm = "47"
        Dim opcion As String = DirectCast(sender, Button).Tag.ToString()
        Dim frm As New FormBUSQUEDA
        frm.medida = FormMain.cmbaño.Text
        frm.ShowDialog()

        If gLinea <> Nothing Then
            txt_bruta.Text = gLinea
            TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If

    End Sub

    Private Sub FormCtaNDNC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'bPrimero = False
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
            Case 1
                flagAccion = "M"
                txttipo.Text = gsCode
                Dim dt As DataTable = FACTURACIONBL.SelectT_DOC("01")
                If gsCode = "07" Then
                    txtnomtip.Text = "Nota de Credito"
                ElseIf gsCode = "08" Then
                    txtnomtip.Text = "Nota de Debito"
                End If
                'txtnomtip.Text = dt.Rows(0).Item(1).ToString
                txtser.Text = gsCode2
                txtnum.Text = gsCode3
                txtmon.Text = gsCode4
                Dim prov1 As String = PROVISIONESBL.Select_MON_row(txtmon.Text)
                txtmonnom.Text = prov1
                txtcodcli.Text = gsCode7
                txtnomcli.Text = gsCode6
                dtpfec_ven.Value = sFecCom
                'If gsCode4 = "PEN" Then
                '    moneda = "00"
                'ElseIf gsCode4 = "USD" Then
                '    moneda = "01"
                'End If
                'txtcodcli.Text = gsCode4
                'txtnomcli.Text = gsCode5
        End Select
    End Sub

    Private Sub txt_bruta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bruta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "55"
            'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txt_bruta.Text = gLinea
                TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If

            e.Handled = True
        End If

        If e.KeyValue = Keys.F10 Then
            sBusAlm = "47"
            'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.medida = FormMain.cmbaño.Text
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txt_bruta.Text = gLinea
                TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If

            e.Handled = True
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
            Case "exit"
                Cerrar = "Cerrar"
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
                Dim FACTURACIONBE As New FACTURACIONBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                FACTURACIONBE.T_DOC_REF = txttipo.Text
                FACTURACIONBE.SER_DOC_REF = txtser.Text
                FACTURACIONBE.NRO_DOC_REF = txtnum.Text
                FACTURACIONBE.BAR_COD = txt_bruta.Text
                gsError = FACTURACIONBL.SaveRowEst(FACTURACIONBE, ELMVLOGSBE, "ACTNCND")
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
        If txt_bruta.Text = "" Then
            MsgBox("Seleccione Cuenta Bruta", MsgBoxStyle.Exclamation)
            txt_bruta.Focus()
            Return False
        End If
        Return True
    End Function
End Class