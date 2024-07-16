Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormModifGuia
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private primero As Boolean
    Private primero2 As Boolean
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Public dtusuario As DataTable
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
    End Function
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If txtcodart.TextLength <= 7 Then
            MsgBox("Debe Ingresar un Articulo Valido")
            Exit Sub
        End If
        Dim i As Integer
        'MsgBox(dgvcatalogo.Rows.Item(0).ToString)
        'Recorre el catalogo para verificar si los datos son obligatorios o no
        If Label8.Text = "RPD" Then
            MsgBox("Este Documento no se puede modificar")
            Exit Sub
        End If
        Try

            Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            Dim GUIADESPACHOBE As New GUIADESPACHOBE
            DET_DOCUMENTOBE.T_DOC_REF = RTrim(Label5.Text)
            DET_DOCUMENTOBE.SER_DOC_REF = RTrim(Label6.Text)
            DET_DOCUMENTOBE.NRO_DOC_REF = RTrim(Label7.Text)
            DET_DOCUMENTOBE.T_DOC_REF1 = RTrim(Label8.Text)
            DET_DOCUMENTOBE.SER_DOC_REF1 = RTrim(Label9.Text)
            DET_DOCUMENTOBE.NRO_DOC_REF1 = RTrim(Label10.Text)
            DET_DOCUMENTOBE.ART_COD1 = RTrim(Label11.Text)
            DET_DOCUMENTOBE.ART_COD = RTrim(txtcodart.Text)
            DET_DOCUMENTOBE.CANTIDAD = RTrim(npdcantidad.Value)
            DET_DOCUMENTOBE.CANTIDAD1 = RTrim(Label12.Text)
            DET_DOCUMENTOBE.USUARIO = gsUser
            DET_DOCUMENTOBE.T_MOVINV = RTrim(Label13.Text)
            DET_DOCUMENTOBE.ALM_COD = Label14.Text
            ELMVLOGSBE.log_codope = "4"
            ELMVLOGSBE.log_codusu = gsCodUsr
            gsError = DET_DOCUMENTOBL.SaveRow(DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, gsAño)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "TOTART", dgvsum, "", sEstAlmac, dtusuario)
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub FormModifGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If sAño = FormMain.cmbaño.SelectedItem And sMes = gsMes Then
        '    'no desactiva nada 
        '    Exit Sub
        'End If
        'MsgBox(sAño - gsAño)
        'MsgBox(sMes1 - gsMes)
        dgvsum.Columns.Add("T_DOC_REF", "Documento")
        dgvsum.Columns.Add("SER_DOC_REF", "Serie")
        dgvsum.Columns.Add("NRO_DOC_REF", "Numero")
        dgvsum.Columns.Add("ART_COD", "Articulo")
        dgvsum.Columns.Add("CANTIDAD", "Cantidad")
        dgvsum.Columns.Add("T_MOVINV", "T_MOVINV")
        dgvsum.Columns.Add("TRANS", "TRANS")
        dgvsum.Columns.Add("ANHO", "ANHO")
        dgvsum.Columns.Add("FEC_GENE", "FEC_GENE")

        Dim mes As String
        If gsUser <> "DSANDOVAL" Then

            If sAño - gsAño <= 1 Then
                If gsMes <> "12" And sMes2 <> "01" Then
                    If sMes2 > gsMes Then
                        mes = sMes2 - gsMes
                        If mes = 1 Then
                            If DateTime.Now.ToString("dd") > 11 Then
                                'If DateTime.Now.ToString("dd") > 11 Then
                                desactivar(False)
                                'Exit Sub
                            End If
                        ElseIf mes > 1 Then
                            MsgBox("El mes es mayor al permitido")
                            desactivar(False)
                            'Exit Sub
                        End If
                    ElseIf gsMes <> "12" And sMes2 <> "01" Then
                        mes = sMes2 - gsMes
                        If mes = 1 Then
                            If DateTime.Now.ToString("dd") > 11 Then
                                'If DateTime.Now.ToString("dd") > 11 Then
                                desactivar(False)
                                'Exit Sub
                            End If
                        ElseIf mes > 1 Then
                            MsgBox("El mes es mayor al permitido")
                            desactivar(False)
                            'Exit Sub
                        ElseIf mes < 0 Then
                            MsgBox("El mes es mayor al permitido")
                            desactivar(False)
                        End If
                    End If
                ElseIf gsMes = "12" And sMes2 = "01" And sAño - gsAño = 1 Then

                End If
            Else
                If sAño > gsAño And gsMes <> "12" And sMes2 <> "01" Then
                    desactivar(False)
                End If
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
        Label11.Text = gsCode2
        Label12.Text = gsCode3
        Label14.Text = DET_DOCUMENTOBL.SelectAlm(Label5.Text, Label6.Text, Label7.Text)
        primero = False
        primero2 = False
        If gsUser = "HMARAPARA" Then
            desactivar(False)
        End If
        txtcodart_Validated(Nothing, Nothing)
        flagAccion = "MG"
        dgvsum.Rows.Add(Label5.Text,
                      Label6.Text,
                      Label7.Text,
                      txtcodart.Text,
                      npdcantidad.Value,
                      Label16.Text,
                      Label13.Text,
                      gsAño,
                      Label17.Text)
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
        'buscar articulo

        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbArticulo.SelectedValue = txtcodart.Text
        ' cmbLineas_SelectedIndexChanged(Nothing, Nothing)
        gsCode = gsCode
        '
        'cmbSublineas_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub FormModifGuia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub


End Class