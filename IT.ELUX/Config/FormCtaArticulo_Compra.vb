
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormCtaArticulo_Compra

    Private ELCUENTA_ARTBL As New ELCUENTA_ARTBL
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL

    Private Sub FormCtaArticulo_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                Deshabilitar(False)
        End Select
    End Sub
    Sub Deshabilitar(ByVal F As Boolean)
        'cmbanho.Enabled = F
        'txtcodbanco.Enabled = F
        'txtnombanco.Enabled = F
        'txtcta_cod.Enabled = F
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
                Dim ELCUENTA_ARTBE As New ELCUENTA_ARTBE
                ELCUENTA_ARTBE.art_anho = cmbanho.SelectedItem
                ELCUENTA_ARTBE.art_codigo = txtart_cod.Text
                ELCUENTA_ARTBE.art_cuenta = txtcta_cod.Text
                If chkestado.Checked = True Then
                    ELCUENTA_ARTBE.art_estado = "H"
                Else
                    ELCUENTA_ARTBE.art_estado = "A"
                End If

                gsError = ELCUENTA_ARTBL.SaveRow(ELCUENTA_ARTBE, flagAccion)
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

        If txtart_cod.Text = "" Then
            MsgBox("Ingrese el codigo de Articulo", MsgBoxStyle.Exclamation)
            txtart_cod.Focus()
            Return False
        End If

        If flagAccion = "N" Then
            If ELCUENTA_ARTBL.VerificarRepetido(cmbanho.SelectedItem, txtart_cod.Text) = True Then
                MsgBox("Ya existe la cuenta para este articulo y el año", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub Limpiar()
        cmbanho.SelectedItem = DateTime.Now.ToString("yyyy")
        'txtcodbanco.Text = ""
        'txtnombanco.Text = ""
        'txtcta_cod.Text = ""
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELCUENTA_ARTBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            cmbanho.SelectedItem = sTDoc
            txtart_cod.Text = IIf(IsDBNull(Registro("CODIGO")), "", Registro("CODIGO"))
            lblnom.Text = IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))
            lblformato.Text = "" 'IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))
            txtcta_cod.Text = IIf(IsDBNull(Registro("CTA_COD")), "", Registro("CTA_COD"))
            lbl_ctanom.Text = IIf(IsDBNull(Registro("CUENTA")), "", Registro("CUENTA"))
            chkestado.Checked = CBool(Registro("ESTADO"))
        Next
    End Sub
    Private Sub txtcta_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcta_cod.LostFocus
        If (txtcta_cod.Text = "") Then
            lbl_ctanom.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectCuentaCOD(txtcta_cod.Text)
            If dt.Rows.Count > 0 Then
                txtcta_cod.Text = dt.Rows(0).Item(0).ToString
                lbl_ctanom.Text = dt.Rows(0).Item(2).ToString
            Else
                txtcta_cod.Text = ""
                lbl_ctanom.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcta_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            gsCode7 = "9"
            sBusAlm = "111"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcta_cod.Text = gLinea
                lbl_ctanom.Text = gArt
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.F10 Then
            gsCode7 = "10"
            sBusAlm = "111"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcta_cod.Text = gLinea
                lbl_ctanom.Text = gArt
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
        gArt = ""
    End Sub

    Private Sub txtart_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "112"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtart_cod.Text = gLinea
                lblnom.Text = gSubLinea
                lblformato.Text = gArt
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
        gArt = ""
    End Sub

    Private Sub FormCtaArticulo_Compra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class