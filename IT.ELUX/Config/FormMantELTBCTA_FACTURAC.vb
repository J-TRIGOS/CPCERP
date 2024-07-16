Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormMantELTBCTA_FACTURAC
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBCTA_FACTURACIONBL As New ELTBCTA_FACTURACIONBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sSec As String
    Private MenuBL As New MenuBL
    Public boton As String
    Public añocta As String
    Private Sub visible(ByVal retorno As Boolean)
        Label17.Visible = retorno
        Label18.Visible = retorno
        Label19.Visible = retorno
        txttip_ref.Visible = retorno
        txtnro_ref.Visible = retorno
        txtnomref.Visible = retorno
    End Sub

    Private Sub FormMantELTBCTA_FACTURAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        'Cargar los combos

        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox11.ReadOnly = True
        Dim dt As DataTable
        dt = ELTBCTA_FACTURACIONBL.SelectTipo_Mov()
        GetCmb("cod", "nom", dt, cmbtipomov)

        dt = ELTBCTA_FACTURACIONBL.SelectT_Moneda()
        GetCmb("cod", "nom", dt, cmb_moneda)
        visible(True)
        bPrimero = False
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                If sOp = "0" Then
                    visible(False)
                End If
                If sOp = "0" Then
                    If txt_t_movinv.Text = "" Then
                        txt_t_movinv.Text = "S02"
                        cmbtipomov.SelectedValue = "S02"
                    Else
                        cmbtipomov.SelectedValue = txt_t_movinv.Text
                    End If
                Else
                    If txt_t_movinv.Text = "S06" Then
                        txt_t_movinv.Text = "S06"
                        cmbtipomov.SelectedValue = "S06"
                    ElseIf txt_t_movinv.Text = "S02" Then
                        txt_t_movinv.Text = "S02"
                        cmbtipomov.SelectedValue = "S02"
                    Else
                        txt_t_movinv.Text = "S02"
                        cmbtipomov.SelectedValue = "S02"
                    End If
                End If
            Case 1
                flagAccion = "M"
                visible(False)
                GetData(gsCode, gsCode2, gsCode3, gsCode4, gsCode5, gsCode6, gsCode7, gCodAct, gArt)
        End Select
    End Sub

    Private Sub Limpiar()
        txtope.Text = "001"
        txtdco.Text = "01"
        cmb_año.SelectedItem =
        txt_bruta.Text = ""
        txt_boleta.Text = ""
        txt_otros.Text = ""

        If txt_t_movinv.Text = "" Then
            txt_t_movinv.Text = "S02"
            cmbtipomov.SelectedValue = "S02"
        Else
            cmbtipomov.SelectedValue = txt_t_movinv.Text
        End If

        If txtmon.Text = "" Then
            txtmon.Text = "00"
            cmb_moneda.SelectedValue = "00"
            txt_igv.Text = "4011101"
            TextBox7.Text = "IGV CUENTA PROPIA"
            txt_neta.Text = "1213101"
            TextBox9.Text = "FACTURAS-SOLES"
        Else
            cmb_moneda.SelectedValue = txtmon.Text
            If txtmon.Text = "00" Then
                txt_igv.Text = "4011101"
                TextBox7.Text = "IGV CUENTA PROPIA"
                txt_neta.Text = "1213101"
                TextBox9.Text = "FACTURAS-SOLES"
            Else
                txt_igv.Text = "4011101"
                TextBox7.Text = "IGV-CTA PROPIA"
                txt_neta.Text = "1213102"
                TextBox9.Text = "FACTURAS-DOLARES"
            End If
        End If
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function

    Private Sub GetData(ByVal sCode As String, ByVal gsCode2 As String, ByVal gsCode3 As String, ByVal gsCode4 As String, ByVal gsCode5 As String, ByVal gLinea As String, ByVal gSubLinea As String, ByVal gCodAct As String, ByVal gArt As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBCTA_FACTURACIONBL.SelectRow(gsCode, gsCode2, gsCode3, gsCode4, gsCode5, gsCode6, gsCode7, gCodAct, gArt)
        For Each Registro In dtUsuario.Rows
            cmb_año.Text = IIf(IsDBNull(Registro("T_OPE_ANHO")), "", Registro("T_OPE_ANHO"))
            cmbtipomov.SelectedValue = IIf(IsDBNull(Registro("T_MOVINV_COD")), "", Registro("T_MOVINV_COD"))
            txt_t_movinv.Text = IIf(IsDBNull(Registro("T_MOVINV_COD")), "", Registro("T_MOVINV_COD"))
            txtdco.Text = IIf(IsDBNull(Registro("T_DOC_COD")), "", Registro("T_DOC_COD"))
            txtope.Text = IIf(IsDBNull(Registro("T_OPE_COD")), "", Registro("T_OPE_COD"))
            cmb_moneda.SelectedValue = IIf(IsDBNull(Registro("MON_COD")), "", Registro("MON_COD"))
            txtmon.Text = IIf(IsDBNull(Registro("MON_COD")), "", Registro("MON_COD"))
            txtcod_inicial.Text = IIf(IsDBNull(Registro("COD_INI")), "", Registro("COD_INI"))
            TextBox3.Text = ARTICULOBL.SelectArt2(txtcod_inicial.Text)
            TextBox1.Text = ARTICULOBL.getMedida(txtcod_inicial.Text)
            TextBox11.Text = ARTICULOBL.getMedida_old(txtcod_inicial.Text)
            txtcod_final.Text = IIf(IsDBNull(Registro("COD_FIN")), "", Registro("COD_FIN"))
            TextBox4.Text = ARTICULOBL.SelectArt2(txtcod_final.Text)
            TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
            TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)
            txt_bruta.Text = IIf(IsDBNull(Registro("CTA_BRUT_H")), "", Registro("CTA_BRUT_H"))
            TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_bruta.Text)
            txt_boleta.Text = IIf(IsDBNull(Registro("CTA_BRUT_B")), "", Registro("CTA_BRUT_B"))
            TextBox5.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_boleta.Text)
            txt_otros.Text = IIf(IsDBNull(Registro("CTA_BRUT_O")), "", Registro("CTA_BRUT_O"))
            TextBox8.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_otros.Text)
            txt_igv.Text = IIf(IsDBNull(Registro("CTA_IGV_H")), "", Registro("CTA_IGV_H"))
            TextBox7.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_igv.Text)
            txt_neta.Text = IIf(IsDBNull(Registro("CTA_NET_H")), "", Registro("CTA_NET_H"))
            TextBox9.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_neta.Text)
            sSec = IIf(IsDBNull(Registro("SEC")), "", Registro("SEC"))

            lbl1.Text = IIf(IsDBNull(Registro("T_MOVINV_COD")), "", Registro("T_MOVINV_COD"))
            lbl2.Text = IIf(IsDBNull(Registro("T_DOC_COD")), "", Registro("T_DOC_COD"))
            lbl3.Text = IIf(IsDBNull(Registro("T_OPE_COD")), "", Registro("T_OPE_COD"))
            lbl4.Text = IIf(IsDBNull(Registro("T_OPE_ANHO")), "", Registro("T_OPE_ANHO"))
            lbl5.Text = IIf(IsDBNull(Registro("MON_COD")), "", Registro("MON_COD"))
            lbl6.Text = "A"
            lbl7.Text = IIf(IsDBNull(Registro("COD_INI")), "", Registro("COD_INI"))
            lbl8.Text = IIf(IsDBNull(Registro("COD_FIN")), "", Registro("COD_FIN"))
            lbl9.Text = IIf(IsDBNull(Registro("SEC")), "", Registro("SEC"))
        Next
    End Sub

    Private Sub btnArticulo_Click(sender As Object, e As EventArgs) Handles btnArticulo.Click
        sBusAlm = "46"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcod_inicial.Text = gLinea
            TextBox3.Text = ARTICULOBL.SelectArt2(txtcod_inicial.Text)
            txtcod_final.Text = gLinea
            TextBox4.Text = ARTICULOBL.SelectArt2(txtcod_final.Text)
            TextBox1.Text = ARTICULOBL.getMedida(txtcod_inicial.Text)
            TextBox11.Text = ARTICULOBL.getMedida_old(txtcod_inicial.Text)
            TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
            TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtcod_inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod_inicial.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "46"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcod_inicial.Text = gLinea
                TextBox3.Text = ARTICULOBL.SelectArt2(txtcod_inicial.Text)
                txtcod_final.Text = gLinea
                TextBox4.Text = ARTICULOBL.SelectArt2(txtcod_final.Text)
                TextBox1.Text = ARTICULOBL.getMedida(txtcod_inicial.Text)
                TextBox11.Text = ARTICULOBL.getMedida_old(txtcod_inicial.Text)
                TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
                TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub txtcod_final_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod_final.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "46"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                'txtcod_inicial.Text = gLinea
                'TextBox3.Text = ARTICULOBL.SelectArt2(txtcod_inicial.Text)
                txtcod_final.Text = gLinea
                TextBox4.Text = ARTICULOBL.SelectArt2(txtcod_final.Text)
                TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
                TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)

                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub btntodos_Click(sender As Object, e As EventArgs) Handles btn_ot.Click, btn_ne.Click, btn_ig.Click, btntodos.Click, btn_bo.Click
        sBusAlm = "47"
        Dim opcion As String = DirectCast(sender, Button).Tag.ToString()
        Dim frm As New FormBUSQUEDA
        frm.medida = FormMain.cmbaño.Text
        frm.ShowDialog()

        Select Case opcion
            Case 1
                If gLinea <> Nothing Then
                    txt_bruta.Text = gLinea
                    TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                    gLinea = Nothing
                Else
                    gLinea = Nothing
                End If

            Case 2
                If gLinea <> Nothing Then
                    txt_boleta.Text = gLinea
                    TextBox5.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                    gLinea = Nothing
                Else
                    gLinea = Nothing
                End If

            Case 3
                If gLinea <> Nothing Then
                    txt_otros.Text = gLinea
                    TextBox8.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                    gLinea = Nothing
                Else
                    gLinea = Nothing
                End If

            Case 4
                If gLinea <> Nothing Then
                    txt_igv.Text = gLinea
                    TextBox7.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                    gLinea = Nothing
                Else
                    gLinea = Nothing
                End If

            Case 5
                If gLinea <> Nothing Then
                    txt_neta.Text = gLinea
                    TextBox9.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                    gLinea = Nothing
                Else
                    gLinea = Nothing
                End If

        End Select
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
                Dim ELTBCTA_FACTURACIONBE As New ELTBCTA_FACTURACIONBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELTBCTA_FACTURACIONBE.t_movinv_cod = cmbtipomov.SelectedValue
                ELTBCTA_FACTURACIONBE.t_doc_cod = txtdco.Text
                ELTBCTA_FACTURACIONBE.t_ope_cod = txtope.Text
                ELTBCTA_FACTURACIONBE.t_ope_anho = cmb_año.SelectedItem
                ELTBCTA_FACTURACIONBE.mon_cod = cmb_moneda.SelectedValue
                ELTBCTA_FACTURACIONBE.t_item = "A"
                ELTBCTA_FACTURACIONBE.cod_ini = txtcod_inicial.Text
                ELTBCTA_FACTURACIONBE.cod_fin = txtcod_final.Text
                ELTBCTA_FACTURACIONBE.cta_brut_h = txt_bruta.Text
                ELTBCTA_FACTURACIONBE.cta_igv_h = txt_igv.Text
                ELTBCTA_FACTURACIONBE.cta_net_h = txt_neta.Text
                ELTBCTA_FACTURACIONBE.cta_brut_b = txt_boleta.Text
                ELTBCTA_FACTURACIONBE.cta_brut_o = txt_otros.Text
                ELMVLOGSBE.log_codusu = gsCodUsr
                If flagAccion = "N" Then
                    ELTBCTA_FACTURACIONBE.sec = ELTBCTA_FACTURACIONBL.SelectMaxCtafacturacion(cmbtipomov.SelectedValue, txtdco.Text, txtope.Text, cmb_año.SelectedItem, cmb_moneda.SelectedValue, "A", txtcod_inicial.Text, txtcod_final.Text)
                Else
                    ELTBCTA_FACTURACIONBE.sec = sSec
                End If
                gsError = ELTBCTA_FACTURACIONBL.SaveRow(ELTBCTA_FACTURACIONBE, ELMVLOGSBE, flagAccion, lbl1.Text + "|" + lbl2.Text + "|" + lbl3.Text + "|" + lbl4.Text + "|" + lbl5.Text + "|" + lbl6.Text + "|" + lbl7.Text + "|" + lbl8.Text + "|" + lbl9.Text)
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
        If cmbtipomov.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo de Movimiento", MsgBoxStyle.Exclamation)
            cmbtipomov.Focus()
            Return False
        End If
        If txtope.Text = "" Then
            MsgBox("Ingrese el tipo de Operación", MsgBoxStyle.Exclamation)
            txtope.Focus()
            Return False
        End If
        If txtdco.Text = "" Then
            MsgBox("Ingrese el descuento", MsgBoxStyle.Exclamation)
            txtdco.Focus()
            Return False
        End If
        If txtcod_inicial.Text = "" Then
            MsgBox("Ingrese el codigo inicial del articulo", MsgBoxStyle.Exclamation)
            txtcod_inicial.Focus()
            Return False
        End If
        If txtcod_final.Text = "" Then
            MsgBox("Ingrese el codigo final del articulo", MsgBoxStyle.Exclamation)
            txtcod_final.Focus()
            Return False
        End If
        If txt_bruta.Text = "" Then
            MsgBox("Ingrese nro de Cuenta bruta", MsgBoxStyle.Exclamation)
            txt_bruta.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "46"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcod_inicial.Text = gLinea
            TextBox3.Text = ARTICULOBL.SelectArt2(txtcod_inicial.Text)
            TextBox1.Text = ARTICULOBL.getMedida(txtcod_inicial.Text)
            TextBox11.Text = ARTICULOBL.getMedida_old(txtcod_inicial.Text)
            txtcod_final.Text = gLinea
            TextBox4.Text = ARTICULOBL.SelectArt2(txtcod_final.Text)
            TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
            TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If

    End Sub

    Private Sub txt_bruta_LostFocus(sender As Object, e As EventArgs) Handles txt_bruta.LostFocus
        If txt_bruta.TextLength > 0 Then
            If ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_bruta.Text.Trim) = "" Then
                MsgBox("No existe la cuenta bruta", MsgBoxStyle.Information)
                txt_bruta.Text = ""
                TextBox6.Text = ""
            Else
                TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_bruta.Text.Trim)
            End If
        Else
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub txt_boleta_LostFocus(sender As Object, e As EventArgs) Handles txt_boleta.LostFocus
        If txt_boleta.TextLength > 0 Then
            If ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_boleta.Text.Trim) = "" Then
                MsgBox("No existe la cuenta boleta", MsgBoxStyle.Information)
                txt_boleta.Text = ""
                TextBox5.Text = ""
            Else
                TextBox5.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_boleta.Text.Trim)
            End If
        Else
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub txt_otros_LostFocus(sender As Object, e As EventArgs) Handles txt_otros.LostFocus
        If txt_otros.TextLength > 0 Then
            If ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_otros.Text.Trim) = "" Then
                MsgBox("No existe la cuenta otros", MsgBoxStyle.Information)
                txt_otros.Text = ""
                TextBox8.Text = ""
            Else
                TextBox8.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_otros.Text.Trim)
            End If
        Else
            TextBox8.Text = ""
        End If
    End Sub

    Private Sub txt_igv_LostFocus(sender As Object, e As EventArgs) Handles txt_igv.LostFocus
        If txt_igv.TextLength > 0 Then
            If ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_igv.Text.Trim) = "" Then
                MsgBox("No existe la cuenta IGV", MsgBoxStyle.Information)
                txt_igv.Text = ""
                TextBox7.Text = ""
            Else
                TextBox7.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_igv.Text.Trim)
            End If
        Else
            TextBox7.Text = ""
        End If
    End Sub

    Private Sub txt_neta_LostFocus(sender As Object, e As EventArgs) Handles txt_neta.LostFocus
        If txt_neta.TextLength > 0 Then
            If ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_neta.Text.Trim) = "" Then
                MsgBox("No existe la cuenta neta", MsgBoxStyle.Information)
                txt_neta.Text = ""
                TextBox9.Text = ""
            Else
                TextBox9.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(txt_neta.Text.Trim)
            End If
        Else
            TextBox9.Text = ""
        End If
    End Sub

    Private Sub txtcod_inicial_LostFocus(sender As Object, e As EventArgs) Handles txtcod_inicial.LostFocus
        If txtcod_inicial.TextLength > 0 Then
            If ARTICULOBL.SelectArt2(txtcod_inicial.Text.Trim) = "" Then
                MsgBox("No existe el codigo Articulo", MsgBoxStyle.Information)
                txtcod_inicial.Text = ""
                TextBox3.Text = ""
            Else
                TextBox3.Text = ARTICULOBL.SelectArt2(txtcod_inicial.Text.Trim)
                TextBox1.Text = ARTICULOBL.getMedida(txtcod_inicial.Text)
                TextBox11.Text = ARTICULOBL.getMedida_old(txtcod_inicial.Text)
                TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
                TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)
            End If
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub txtcod_final_LostFocus(sender As Object, e As EventArgs) Handles txtcod_final.LostFocus
        If txtcod_final.TextLength > 0 Then
            If ARTICULOBL.SelectArt2(txtcod_final.Text.Trim) = "" Then
                MsgBox("No existe el codigo Articulo", MsgBoxStyle.Information)
                txtcod_final.Text = ""
                TextBox4.Text = ""
            Else
                TextBox4.Text = ARTICULOBL.SelectArt2(txtcod_final.Text.Trim)
                TextBox2.Text = ARTICULOBL.getMedida(txtcod_final.Text)
                TextBox10.Text = ARTICULOBL.getMedida_old(txtcod_final.Text)
            End If
        Else
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub cmbtipomov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipomov.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbtipomov.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txt_t_movinv.Text = cmbtipomov.SelectedValue
    End Sub

    Private Sub cmb_moneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_moneda.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmb_moneda.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtmon.Text = cmb_moneda.SelectedValue

        If txtmon.Text = "00" Then
            txt_igv.Text = "4011101"
            TextBox7.Text = "IGV CUENTA PROPIA"
            txt_neta.Text = "1213101"
            TextBox9.Text = "FACTURAS-SOLES"
        ElseIf txtmon.Text = "01" Then
            txt_igv.Text = "4011101"
            TextBox7.Text = "IGV-CTA PROPIA"
            txt_neta.Text = "1213102"
            TextBox9.Text = "FACTURAS-DOLARES"
        ElseIf txtmon.Text <> "00" Or txtmon.Text <> "01" Then
            txt_igv.Text = ""
            TextBox7.Text = ""
            txt_neta.Text = ""
            TextBox9.Text = ""
        End If

    End Sub

    Private Sub txt_boleta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_boleta.KeyDown, txt_otros.KeyDown, txt_igv.KeyDown, txt_neta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "47"
            Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.medida = FormMain.cmbaño.Text
            frm.ShowDialog()

            Select Case opcion
                Case 1
                    If gLinea <> Nothing Then
                        txt_bruta.Text = gLinea
                        TextBox6.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                        gLinea = Nothing
                    Else
                        gLinea = Nothing
                    End If
                Case 2
                    If gLinea <> Nothing Then
                        txt_boleta.Text = gLinea
                        TextBox5.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                        gLinea = Nothing
                    Else
                        gLinea = Nothing
                    End If
                Case 3
                    If gLinea <> Nothing Then
                        txt_otros.Text = gLinea
                        TextBox8.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                        gLinea = Nothing
                    Else
                        gLinea = Nothing
                    End If

                Case 4
                    If gLinea <> Nothing Then
                        txt_igv.Text = gLinea
                        TextBox7.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                        gLinea = Nothing
                    Else
                        gLinea = Nothing
                    End If
                Case 5
                    If gLinea <> Nothing Then
                        txt_neta.Text = gLinea
                        TextBox9.Text = ELTBCTA_FACTURACIONBL.SelectCTAFC(gLinea)
                        gLinea = Nothing
                    Else
                        gLinea = Nothing
                    End If
            End Select

            e.Handled = True
        End If
    End Sub
    Private Sub txt_t_movinv_LostFocus(sender As Object, e As EventArgs) Handles txt_t_movinv.LostFocus
        If (txt_t_movinv.Text = "") Then
            cmbtipomov.SelectedValue = -1
        Else
            Dim dt As DataTable
            dt = ELTBCTA_FACTURACIONBL.SelectTipMovCOD(txt_t_movinv.Text)
            If dt.Rows.Count > 0 Then
                txt_t_movinv.Text = dt.Rows(0).Item(0).ToString
                cmbtipomov.SelectedValue = dt.Rows(0).Item(0).ToString
            Else
                txt_t_movinv.Text = ""
                cmbtipomov.SelectedValue = -1
            End If
        End If
    End Sub
    Private Sub txtmon_LostFocus(sender As Object, e As EventArgs) Handles txtmon.LostFocus
        If (txtmon.Text = "") Then
            cmb_moneda.SelectedValue = -1
        Else
            Dim dt As DataTable
            dt = ELTBCTA_FACTURACIONBL.SelectMonCOD(txtmon.Text)
            If dt.Rows.Count > 0 Then
                txtmon.Text = dt.Rows(0).Item(0).ToString
                cmb_moneda.SelectedValue = dt.Rows(0).Item(0).ToString

                If txtmon.Text = "00" Then
                    txt_igv.Text = "4011101"
                    TextBox7.Text = "IGV CUENTA PROPIA"
                    txt_neta.Text = "1213101"
                    TextBox9.Text = "FACTURAS-SOLES"
                ElseIf txtmon.Text = "01" Then
                    txt_igv.Text = "4011101"
                    TextBox7.Text = "IGV-CTA PROPIA"
                    txt_neta.Text = "1213102"
                    TextBox9.Text = "FACTURAS-DOLARES"
                ElseIf txtmon.Text <> "00" Or txtmon.Text <> "01" Then
                    txt_igv.Text = ""
                    TextBox7.Text = ""
                    txt_neta.Text = ""
                    TextBox9.Text = ""
                End If

            Else
                txtmon.Text = ""
                cmb_moneda.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub btnbr_Click(sender As Object, e As EventArgs) Handles btn_br.Click
        sBusAlm = "55"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txt_bruta.Text = gLinea
            TextBox6.Text = gSubLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txt_bruta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bruta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "55"
            Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txt_bruta.Text = gLinea
                TextBox6.Text = gSubLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If

            e.Handled = True
        End If

        If e.KeyValue = Keys.F10 Then
            sBusAlm = "47"
            Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.medida = FormMain.cmbaño.Text
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txt_bruta.Text = gLinea
                TextBox6.Text = gSubLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If

            e.Handled = True
        End If
    End Sub

    Private Sub FormMantELTBCTA_FACTURAC_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class