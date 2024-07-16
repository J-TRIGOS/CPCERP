Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormModifGuiaTrans
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private primero As Boolean
    Private primero2 As Boolean
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private ELETIQUETABL As New ELETIQUETABL

    Sub desactivar(ByVal bol As Boolean)
        cmbLineas.Enabled = bol
        cmbSublineas.Enabled = bol
        txtcodart.Enabled = bol
        npdcantidad.Enabled = bol
        btnbuscar.Enabled = bol
        cmbArticulo.Enabled = bol
        btnAceptar.Enabled = bol
    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
#Disable Warning BC42105 ' La función 'GetCmb' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function
    Private Function OkData() As Boolean

        If txtcodart.Text = txtcodartdos.Text Then
            MsgBox("Debe Ingresar articulos diferentes", MsgBoxStyle.Exclamation)
            txtcodartdos.Focus()
            Return False
        End If
        If npdcantidad.Text < 1 Then
            MsgBox("La cantidad no debe ser menor a 1", MsgBoxStyle.Exclamation)
            npdcantidad.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If

            Try

                Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                Dim ELMVLOGSBE As New ELMVLOGSBE

                DET_DOCUMENTOBE.T_DOC_REF = RTrim(Label5.Text)
                DET_DOCUMENTOBE.SER_DOC_REF = RTrim(Label6.Text)
                DET_DOCUMENTOBE.NRO_DOC_REF = RTrim(Label7.Text)
                DET_DOCUMENTOBE.T_DOC_REF1 = RTrim(Label8.Text)
                DET_DOCUMENTOBE.SER_DOC_REF1 = RTrim(Label9.Text)
                DET_DOCUMENTOBE.NRO_DOC_REF1 = RTrim(Label10.Text)
                DET_DOCUMENTOBE.ART_COD1 = RTrim(txtcodartdos.Text)
                DET_DOCUMENTOBE.ART_COD = RTrim(txtcodart.Text)
                DET_DOCUMENTOBE.CANTIDAD = RTrim(npdcantidad.Value)
                DET_DOCUMENTOBE.CANTIDAD1 = RTrim(Label12.Text)
                DET_DOCUMENTOBE.T_MOVINV = RTrim(Label13.Text)

                DET_DOCUMENTOBE.PER_COD1 = gsCode2 'ART_COD1
                DET_DOCUMENTOBE.PER_COD2 = gsCode5 'ART_COD2
                DET_DOCUMENTOBE.OBSERVA1 = gsCode6 'ALM_COD

                ELMVLOGSBE.log_codope = "4"
                ELMVLOGSBE.log_codusu = gsCodUsr

                gsError = DET_DOCUMENTOBL.SaveRow(DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, gsAño)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Private Sub FormModifGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mes As String
        If sAño > gsAño Then
            desactivar(False)
        End If
        If sMes2 < gsMes Then
            mes = gsMes - sMes2
            If mes = 1 Then
                If DateTime.Now.ToString("dd") > 11 Then
                    desactivar(False)
                End If
            ElseIf mes > 1 Then
                MsgBox("El mes es mayor al permitido")
                desactivar(False)
            End If
        End If

        primero = True
        primero2 = True

        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)
        ' GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        txtcodart.Text = gsCode2
        npdcantidad.Value = gsCode3
        Label12.Text = gsCode3
        txtcodartdos.Text = gsCode5
        txtcodartdos_LostFocus(Nothing, Nothing)

        primero = False
        primero2 = False

        txtcodart_Validated(Nothing, Nothing)
        flagAccion = "MT"

    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        'change line
        If primero Then Exit Sub

        '    primero = True
        Dim sCode As String = Mid(cmbLineas.SelectedValue, 1, 2)
        Dim dt As New DataTable

        primero = True
        dt = ARTICULOBL.SelectDescripcion1(sCode)
        GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        primero = False
    End Sub

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        'change subline
        If primero Then Exit Sub

        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable

        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            GetCmb("COD", "art_descri", dt, cmbArticulo)

        Else
            MsgBox("La Sublinea no tiene articulos")
            'For i = 0 To cmbart.Items.Count - 1
            cmbArticulo.DataSource = Nothing
            'Next
            'cmbart.Refresh()
        End If

        primero = False
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If primero Then Exit Sub
        txtcodart.Text = cmbArticulo.SelectedValue
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        SaveData()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        cmbLineas.SelectedValue = gLinea
        cmbSublineas.SelectedValue = gSubLinea
        cmbArticulo.SelectedValue = gArt
        gLinea = Nothing
        gSubLinea = Nothing
        gArt = Nothing
    End Sub

    Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
        If primero2 Then Exit Sub

        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If
        cmbArticulo.SelectedValue = txtcodart.Text
    End Sub

    Private Sub FormModifGuia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtcodartdos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodartdos.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "5"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcodartdos.Text = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
        gArt = ""
    End Sub

    Private Sub txtcodartdos_LostFocus(sender As Object, e As EventArgs) Handles txtcodartdos.LostFocus
        If (txtcodartdos.Text = "") Then
            lblart_des.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcodartdos.Text)
            If dt.Rows.Count > 0 Then
                txtcodartdos.Text = dt.Rows(0).Item(0).ToString
                lblart_des.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcodartdos.Text = ""
                lblart_des.Text = ""
            End If
        End If
    End Sub

End Class