Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBDETSOLMATERIALES
    Private ARTICULOBL As New ARTICULOBL
    Private REPORTE_PRODUCCIONBL As New REPORTE_PRODUCCIONBL
    Private DETALLE_DOCUMENTOBL As New DETALLE_DOCUMENTOBL
    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private gpCaption As String
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Private bCuarto As String = "0"
    Public bfecha As Date
    Public a As String = ""
    Public b As String = ""
    Public c As String = ""
    Public d As String = ""
    Public et As String = ""
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    'Private Function VERIFICAR() As Boolean
    '    If cmbart.SelectedValue <> txtcodart.Text Then
    '        MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
    '        txtcodart.Text = ""
    '        txtcodart.Select()
    '        cmbsublinea.SelectedIndex = -1
    '        cmblinea.SelectedIndex = -1
    '        cmbart.SelectedIndex = -1
    '        Return VERIFICAR = False
    '    Else
    '        Return VERIFICAR = True
    '    End If
    'End Function
    Private Function OkData() As Boolean

        If txtcodart.Text = "" Then
            MsgBox("Ingrese el articulo a solicitar", MsgBoxStyle.Exclamation)
            txtcodart.Focus()
            Return False
        ElseIf npdcantidad.Value = 0 Then
            MsgBox("Ingrese la cantidad a solicitar", MsgBoxStyle.Exclamation)
            npdcantidad.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub FormELTBDETSOLMATERIALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        Me.Text = "Detalle Materiales"
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        'dt = REQUERIMIENTOBL.SelectCCosto
        'GetCmb("cod", "nom", dt, cmbc_costo)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbuni)
        If bfecha >= Format(CDate("2020/12/21"), "yyyy/MM/dd") Then '
            txtArticulo.Visible = True
            cmbactivo.Visible = False
        Else
            cmbactivo.Visible = True
            dt = ARTICULOBL.SelectAct()
            GetCmb("COD", "NOM_ACT", dt, cmbactivo)
        End If
        If gContador = 0 Then
            'bPrimero = True
            cmblinea.SelectedValue = Mid(gsCode3, 1, 2) & "00"
            dt = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
            cmbsublinea.SelectedValue = Mid(gsCode3, 1, 4)
            dt = ARTICULOBL.SelectArt1(cmbsublinea.SelectedValue)
            GetCmb("ART_CODIGO", "ART_COD", dt, cmbart)
            cmbart.SelectedValue = Trim(gsCode3)
            cmbuni.SelectedValue = sUni
            txtcodart.Text = Trim(gsCode3)
            If bfecha.ToString("yyyy/MM/dd") >= "2020/12/21" Then
                txtArticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            Else
                cmbactivo.SelectedValue = txtactivo.Text
            End If
        Else
            'CleanVar()
            cmbart.DataSource = Nothing
            cmbsublinea.DataSource = Nothing
            'habilitar(True)
        End If
        If gsCode10 <> "1" Then
            'MsgBox(bfecha.ToString("yyyy/MM/dd"))
            If bfecha.ToString("yyyy/MM/dd") <= "2021/02/12" Then
                rdbant.Enabled = False
                rdbnew.Enabled = False
                rdbordman.Enabled = False
                cmbaño.Enabled = False
                txtnumorden.Enabled = False
                txtc_costo.Enabled = False
                cmbc_costo.Enabled = False
                txt_linea.Enabled = False
                cmb_linea.Enabled = False
            End If
        Else
            If txtnumorden.TextLength > 0 Then
                If et = "TMANT" Then
                    rdbnew.Checked = False
                    rdbordman.Checked = True
                Else
                    rdbnew.Checked = True
                    rdbordman.Checked = False
                End If
                rdbant.Checked = False
                txtnumorden.Text = b
                txtc_costo.Text = c
                cmbc_costo.SelectedValue = c
                txt_linea.Text = d
                cmblinea.SelectedValue = d
                cmbaño.Text = a
            Else
                rdbant.Checked = True
                rdbnew.Checked = False
                txtc_costo.Text = c
                cmbc_costo.SelectedValue = c
                txt_linea.Text = d
                If SOLMATERIALESBL.SelLinea(txt_linea.Text) = 0 Then
                    dt = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                Else
                    dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
                End If
                GetCmb("cod", "nom", dt, cmb_linea)
                cmblinea.SelectedValue = txt_linea.Text
                cmbaño.Text = a
            End If
        End If
        bPrimero = False
        If gsCode10 = "1" Then
            cmblinea.SelectedValue = txt_linea.Text
        End If
    End Sub

    'Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
    '    If bPrimero Then Exit Sub
    '    'buscar articulo
    '    Dim dt As DataTable
    '    cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

    '    If cmblinea.SelectedValue = "" Then
    '        Exit Sub
    '    End If
    '    Dim art As String = txtcodart.Text
    '    If flagAccion = "N" Then
    '        cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
    '        txtcodart.Text = art
    '    Else
    '        cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
    '    End If

    '    'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
    '    'txtcodart.Text = art
    '    If cmbsublinea.SelectedValue = "" Then
    '        Exit Sub
    '    End If
    '    If flagAccion = "M" Then
    '        cmbart.DataSource = Nothing
    '        dt = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
    '        GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
    '    Else
    '    End If
    '    cmbart.SelectedValue = txtcodart.Text
    '    txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
    '    If cmbart.SelectedValue <> txtcodart.Text Then
    '        MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
    '        txtcodart.Text = ""
    '        txtcodart.Select()
    '    End If
    'End Sub
    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        Dim dt As DataTable
        cmbart.DataSource = Nothing
        cmbsublinea.DataSource = Nothing
        cmblinea.SelectedIndex = -1
        bSegundo = True
        If txtcodart.TextLength < 8 And txtcodart.TextLength > 0 Then
            MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
            txtcodart.Text = ""
            cmbart.DataSource = Nothing
            'txtcodart.Select()
            cmbsublinea.DataSource = Nothing
            cmblinea.SelectedIndex = -1
            Exit Sub
        End If
        cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"
        Dim art As String = txtcodart.Text
        If flagAccion = "N" Then
            cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
            txtcodart.Text = art
        Else
            cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        End If

        'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        'txtcodart.Text = art
        If cmbsublinea.SelectedIndex = -1 Then
            Exit Sub
        End If
        If flagAccion = "M" Then
            cmbart.DataSource = Nothing
            dt = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
        Else
        End If
        cmbart.SelectedValue = txtcodart.Text
        txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
        If cmbart.SelectedValue <> txtcodart.Text Then
            MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
            txtcodart.Text = ""
            cmbart.DataSource = Nothing
            'txtcodart.Select()
            cmbsublinea.DataSource = Nothing
            cmblinea.SelectedIndex = -1
        End If

        bSegundo = False
    End Sub

    Private Sub cmbart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbart.SelectedIndexChanged
        If bTercero Then Exit Sub
        'OJO VER
        If cmbart.SelectedIndex <> -1 Then
            If gsCode3 <> Nothing Then
                cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(gsCode3, 1, 8))
            Else
                txtcodart.Text = cmbart.SelectedValue
                cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8))
                txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
            End If
        End If
        bTercero = False
    End Sub
    Private Sub cmblinea_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmblinea.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        'bSegundo = True
        If cmblinea.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
        End If
        bSegundo = False
    End Sub
    Private Sub cmbsublinea_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbsublinea.SelectedIndexChanged
        If bSegundo Then
            Exit Sub
        End If

        If cmbsublinea.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            If dt.Rows.Count > 0 Then
                GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
                bTercero = False
                'If sBusAlm = "2" Then
                '    cmbart.SelectedValue = gArt
                '    gArt = Nothing
                'End If

            Else
                MsgBox("La Sublinea no tiene articulos")
                'For i = 0 To cmbart.Items.Count - 1
                cmbart.DataSource = Nothing
                'Next
                'cmbart.Refresh()
            End If

        End If
        cmbuni.SelectedIndex = -1
    End Sub
    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormELTBDETSOLMATERIALES_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "5"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmblinea.SelectedValue = gLinea
            cmbsublinea.SelectedValue = gSubLinea
            cmbart.SelectedValue = gArt
            txtcodart.Text = gArt
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            cmbart.SelectedValue = gArt
            txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If bfecha.ToString("yyyy/MM/dd") >= Format(CDate("2020/12/21"), "yyyy/MM/dd") And txtArticulo.Visible = True Then
            If npdcantidad.Value > 0 And cmbart.SelectedIndex <> -1 And txtcodart.TextLength = 8 Then 'And txtactivo.Text <> Nothing And txtArticulo.Text <> Nothing
                If txtactivo.Text = Nothing Then
                    If MessageBox.Show("Activo no ingresado Desea continuar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                        Exit Sub
                    End If
                End If

                If gContador <> 0 Then
                    For z = 0 To FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count - 1
                        If FormMantELTBSOLMATERIALES.dgvt_doc.Rows(z).Cells("ART_ACT").Value = txtactivo.Text And
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(z).Cells("ART_COD").Value = txtcodart.Text Then
                            MsgBox("Se repite el mismo articulo y activo en caso de necesitar dos veces pedir lo mismo generar otro vale de solicitud")
                            Exit Sub
                        End If
                    Next
                End If
                If Format(bfecha, "yyyy/MM/dd") > Format(CDate("2021/02/12"), "yyyy/MM/dd") Then
                    If txt_linea.Text = "" Then
                        MsgBox("Ingrese el centro de costo o Linea")
                        Exit Sub
                    End If
                    If rdbnew.Checked And txtnumorden.TextLength = 0 Then
                        MsgBox("Ingrese Numero de Orden o marcar sin OP")
                        Exit Sub
                    End If
                    Dim sValor As String
                    Dim i As Integer
                    Dim icontador As Integer = 0
                    If gContador = 1 Then
                        gContador = 0
                        sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                        If FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count > 0 Then
                            For i = 0 To FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count - 1
                                If FormMantELTBSOLMATERIALES.dgvt_doc.Rows(i).Cells(7).Value = cmbart.SelectedValue Then 'txtArticulo.Text
                                    icontador = icontador + 1
                                End If
                            Next
                        End If
                        If icontador > 0 Then
                            If txtnumorden.Text <> Nothing Then
                                If rdbnew.Checked Then
                                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              "OPRD", '3
                                                              cmbaño.Text,'4
                                                              txtnumorden.Text, '5
                                                              npdcantidad.Value, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'11
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                                    Dispose()
                                ElseIf rdbordman.Checked Then
                                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              "TMANT", '3
                                                              cmbaño.Text,'4
                                                              txtnumorden.Text, '5
                                                              npdcantidad.Value, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'11
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                                    Dispose()
                                End If

                            Else
                                FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              FormMantELTBSOLMATERIALES.txtt_doc.Text, '3
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'4
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text & "-" & icontador, '5
                                                              npdcantidad.Text, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'9,10,11
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                                Dispose()
                            End If
                        Else
                            If txtnumorden.Text <> Nothing Then
                                If rdbnew.Checked Then
                                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              "OPRD", '3
                                                              cmbaño.Text,'4
                                                              txtnumorden.Text, '5
                                                              npdcantidad.Value, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                                    Dispose()
                                ElseIf rdbordman.Checked Then
                                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              "TMANT", '3
                                                              cmbaño.Text,'4
                                                              txtnumorden.Text, '5
                                                              npdcantidad.Value, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'11
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                                    Dispose()
                                End If

                            Else
                                FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              FormMantELTBSOLMATERIALES.txtt_doc.Text, '3
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'4
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '5
                                                              npdcantidad.Value, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                                Dispose()
                            End If
                        End If
                    ElseIf gContador = 0 Then

                        sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = npdcantidad.Value
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8))
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value = cmbart.SelectedValue
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = sValor
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("ART_ACT").Value = txtactivo.Text
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value = txtobservacion.Text
                        If rdbant.Checked = False Then
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value = "OPRD"
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value = txtnumorden.Text
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value = cmbaño.Text
                        ElseIf rdbordman.Checked Then
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value = "TMANT"
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value = txtnumorden.Text
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value = cmbaño.Text
                        Else
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value = "SOLM"
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value = FormMantELTBSOLMATERIALES.txtnumero.Text
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value = FormMantELTBSOLMATERIALES.cmb_serdoc.Text
                        End If
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("CCO_COD").Value = txtc_costo.Text
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells("LINEA").Value = txt_linea.Text
                        Dispose()
                    End If
                Else 'en caso la fecha sea mayor al 12-02-2021
                    Dim sValor As String
                    Dim i As Integer
                    Dim icontador As Integer = 0
                    If gContador = 1 Then
                        gContador = 0
                        sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                        If FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count > 0 Then
                            For i = 0 To FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count - 1
                                If FormMantELTBSOLMATERIALES.dgvt_doc.Rows(i).Cells(7).Value = cmbart.SelectedValue Then 'txtArticulo.Text
                                    icontador = icontador + 1
                                End If
                            Next
                        End If
                        'If icontador > 0 Then
                        If txtnumorden.Text <> Nothing Then
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              "OPRD", '3
                                                              cmbaño.Text,'4
                                                              txtnumorden.Text, '5
                                                              npdcantidad.Value, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'11
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                            Dispose()
                        Else
                            FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                              FormMantELTBSOLMATERIALES.txtt_doc.Text, '3
                                                              FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'4
                                                              FormMantELTBSOLMATERIALES.txtnumero.Text & "-" & icontador, '5
                                                              npdcantidad.Text, '6
                                                              cmbart.SelectedValue,'7
                                                              sValor, '8
                                                              txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'9,10,11
                                                              FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                                                              txtc_costo.Text, txt_linea.Text) '15,16
                            Dispose()
                        End If
                        'Else
                        '    If FormMantELTBSOLMATERIALES.txtnumorden.Text <> Nothing Then
                        '        FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                        '                                      FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                        '                                      FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                        '                                      "OPRD", '3
                        '                                      FormMantELTBSOLMATERIALES.cmbaño.Text,'4
                        '                                      FormMantELTBSOLMATERIALES.txtnumorden.Text, '5
                        '                                      npdcantidad.Value, '6
                        '                                      cmbart.SelectedValue,'7
                        '                                      sValor, '8
                        '                                      txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                        '                                      FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                        '                                      txtc_costo.Text, txt_linea.Text) '15,16
                        '        Dispose()
                        '    Else
                        '        FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                        '                                      FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                        '                                      FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                        '                                      FormMantELTBSOLMATERIALES.txtt_doc.Text, '3
                        '                                      FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'4
                        '                                      FormMantELTBSOLMATERIALES.txtnumero.Text, '5
                        '                                      npdcantidad.Value, '6
                        '                                      cmbart.SelectedValue,'7
                        '                                      sValor, '8
                        '                                      txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                        '                                      FormMantELTBSOLMATERIALES.cmbestado.Text, "", txtactivo.Text, '12,13,14
                        '                                      txtc_costo.Text, txt_linea.Text) '15,16
                        '        Dispose()
                        '    End If
                        'End If
                    ElseIf gContador = 0 Then
                        sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(6).Value = npdcantidad.Value
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(11).Value = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8))
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(7).Value = cmbart.SelectedValue
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(8).Value = sValor
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(14).Value = txtactivo.Text
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(9).Value = txtobservacion.Text
                        Dispose()
                    End If

                End If

            Else
                MsgBox("Favor Ingrese la cantidad a declarar o el articulo")
            End If
        Else
            If npdcantidad.Value > 0 And cmbart.SelectedIndex <> -1 And cmbactivo.SelectedIndex <> -1 Then
                For z = 0 To FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count - 1
                    If FormMantELTBSOLMATERIALES.dgvt_doc.Rows(z).Cells("ART_COD").Value = txtcodart.Text And
                       FormMantELTBSOLMATERIALES.dgvt_doc.Rows(z).Cells("ACT_COD").Value = txtactivo.Text Then
                        MsgBox("Se repite el mismo articulo y activo en caso de necesitar dos veces pedir lo mismo generar otro vale de solicitud")
                        Exit Sub
                    End If
                Next

                Dim sValor As String
                Dim i As Integer
                Dim icontador As Integer = 0
                If gContador = 1 Then
                    gContador = 0
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                    If FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count > 0 Then
                        For i = 0 To FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Count - 1
                            If FormMantELTBSOLMATERIALES.dgvt_doc.Rows(i).Cells(7).Value = cmbart.SelectedValue Then
                                icontador = icontador + 1
                            End If
                        Next
                    End If
                    If icontador > 0 Then
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                          FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                          FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                          FormMantELTBSOLMATERIALES.txtt_doc.Text, '3
                                                          FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'4
                                                          FormMantELTBSOLMATERIALES.txtnumero.Text & "-" & icontador, '5
                                                          npdcantidad.Text, '6
                                                          cmbart.SelectedValue,'7
                                                          sValor, '8
                                                          txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'9,10,11
                                                          FormMantELTBSOLMATERIALES.cmbestado.Text, txtactivo.Text, "") '12
                        Dispose()
                    Else
                        FormMantELTBSOLMATERIALES.dgvt_doc.Rows.Add(FormMantELTBSOLMATERIALES.txtt_doc.Text, '0
                                                          FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'1
                                                          FormMantELTBSOLMATERIALES.txtnumero.Text, '2
                                                          FormMantELTBSOLMATERIALES.txtt_doc.Text, '3
                                                          FormMantELTBSOLMATERIALES.cmb_serdoc.Text,'4
                                                          FormMantELTBSOLMATERIALES.txtnumero.Text, '5
                                                          npdcantidad.Value, '6
                                                          cmbart.SelectedValue,'7
                                                          sValor, '8
                                                          txtobservacion.Text, FormMantELTBSOLMATERIALES.dtpfecha.Text, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                                                          FormMantELTBSOLMATERIALES.cmbestado.Text, txtactivo.Text, "")
                        Dispose()



                    End If
                ElseIf gContador = 0 Then
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(6).Value = npdcantidad.Value
                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(11).Value = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8))
                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(7).Value = cmbart.SelectedValue
                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(8).Value = sValor
                    FormMantELTBSOLMATERIALES.dgvt_doc.Rows(FormMantELTBSOLMATERIALES.dgvt_doc.CurrentRow.Index).Cells(13).Value = txtactivo.Text
                    Dispose()

                End If
            Else
                MsgBox("Favor Ingrese la cantidad a declarar o el articulo")
            End If
        End If
    End Sub

    Private Sub txtnumorden_LostFocus(sender As Object, e As EventArgs) Handles txtnumorden.LostFocus
        Dim dt As DataTable
        Dim dt1 As DataTable
        If rdbnew.Checked Then
            txtnumorden.Text = txtnumorden.Text.PadLeft(9, "0")
            dt = ELPRODUCCIONBL.LineaProd(cmbaño.Text, txtnumorden.Text)
            For Each Registro In dt.Rows
                txt_linea.Text = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
                txtcodart1.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart1.Text)
                txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                cmbc_costo.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                dt1 = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt1, cmb_linea)
                cmb_linea.SelectedValue = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
            Next
            If txtcodart1.Text = "" Then
                MsgBox("La Orden de Produccion No existe o ya esta completa")
            End If
            If txtnumorden.Text = "000000000" Then
                MsgBox("Si no cuenta con numero de Orden Por favor marque Sin OP")
            End If
        ElseIf rdbordman.Checked Then
            txtnumorden.Text = txtnumorden.Text.PadLeft(7, "0")
            dt = ELPRODUCCIONBL.LineaMant(cmbaño.Text, txtnumorden.Text)
            For Each Registro In dt.Rows
                txt_linea.Text = IIf(IsDBNull(Registro("AREADES")), "", Registro("AREADES"))
                txtcodart1.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart1.Text)
                txtc_costo.Text = IIf(IsDBNull(Registro("CCO_CODDES")), "", Registro("CCO_CODDES"))
                cmbc_costo.SelectedValue = IIf(IsDBNull(Registro("CCO_CODDES")), "", Registro("CCO_CODDES"))
                dt1 = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt1, cmb_linea)
                cmb_linea.SelectedValue = IIf(IsDBNull(Registro("AREADES")), "", Registro("AREADES"))
            Next
            If txtcodart1.Text = "" Then
                MsgBox("La Orden de Produccion No existe o ya esta completa")
            End If
            If txtnumorden.Text = "000000000" Then
                MsgBox("Si no cuenta con numero de Orden Por favor marque Sin OP")
            End If
        End If

    End Sub


    Private Sub txtactivo_LostFocus(sender As Object, e As EventArgs) Handles txtactivo.LostFocus
        'Dim ARTICULOBL As ARTICULOBL
        If txtactivo.Text = "" Then
            txtArticulo.Text = ""
            Exit Sub
        End If
        'MsgBox(bfecha.ToString("dd-MM-yyyy"))
        If bfecha.ToString("yyyy/MM/dd") >= "2020/02/12" Then
            txtArticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            If txtArticulo.Text = Nothing Then
                MsgBox("Activo no existe", MsgBoxStyle.Exclamation)
                txtactivo.Text = ""
            End If
        Else
            cmbactivo.SelectedValue = txtactivo.Text
            If cmbactivo.SelectedValue Is Nothing Then
                MsgBox("Activo no existe", MsgBoxStyle.Exclamation)
                txtactivo.Text = ""
            End If
        End If
    End Sub

    Private Sub cmbactivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbactivo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbactivo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtactivo.Text = cmbactivo.SelectedValue
    End Sub
    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                cmblinea.SelectedValue = gLinea
                cmbsublinea.SelectedValue = gSubLinea
                cmbart.SelectedValue = gArt
                txtcodart.Text = gArt
                txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
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

        If e.KeyValue = Keys.F10 Then
            sBusAlm = "5"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                cmblinea.SelectedValue = gLinea
                cmbsublinea.SelectedValue = gSubLinea
                cmbart.SelectedValue = gArt
                txtcodart.Text = gArt
                txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
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
    End Sub



    Private Sub btnbusact_Click(sender As Object, e As EventArgs) Handles btnbusact.Click
        If bfecha >= Format(CDate("21/12/2020"), "dd/MM/yyyy") Then
            If txtArticulo.Visible = True Then
                sBusAlm = "120"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gArt <> Nothing And gSubLinea <> Nothing Then
                    txtactivo.Text = gArt
                    txtArticulo.Text = gSubLinea
                    txtstock.Text = ARTICULOBL.SetStock(txtactivo.Text)
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub txtactivo_TextChanged(sender As Object, e As EventArgs) Handles txtactivo.TextChanged
        If bfecha.ToString("yyyy/MM/dd") >= "2020/12/21" Then
            If txtactivo.Text = "" Then
                txtArticulo.Text = ""
            Else
                txtArticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            End If
        End If
    End Sub

    Private Sub rdbant_CheckedChanged(sender As Object, e As EventArgs) Handles rdbant.CheckedChanged
        If rdbnew.Checked Or rdbordman.Checked Then
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
            cmb_linea.Enabled = False
            txt_linea.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = True
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            txtcodart1.Text = ""
            txtnomart.Text = ""
        Else
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            cmb_linea.Enabled = True
            txt_linea.Enabled = True
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = False
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            txtnumorden.Enabled = False
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            txtcodart1.Text = ""
            txtnomart.Text = ""
        End If
    End Sub
    Private Sub rdbnew_CheckedChanged(sender As Object, e As EventArgs) Handles rdbnew.CheckedChanged
        If rdbnew.Checked Or rdbordman.Checked Then
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
            cmb_linea.Enabled = False
            txt_linea.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = True
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            txtnumorden.Enabled = True
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            'End If
        Else
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            cmb_linea.Enabled = True
            txt_linea.Enabled = True
            txtnumorden.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = False
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
        End If
    End Sub

    Private Sub rdbordman_CheckedChanged(sender As Object, e As EventArgs) Handles rdbordman.CheckedChanged
        If rdbnew.Checked Or rdbordman.Checked Then
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
            cmb_linea.Enabled = False
            txt_linea.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = True
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            txtnumorden.Enabled = True
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            'End If
        Else
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            cmb_linea.Enabled = True
            txt_linea.Enabled = True
            txtnumorden.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = False
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
        End If
    End Sub


    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
        'MsgBox(dtpfecha.Value.ToString("dd/MM/yyyy"))
        Dim sFecha As String = "02/10/2020"
        Dim dt As DataTable
        'MsgBox(dtpfecha.Value.ToString("dd/MM/yyyy"))
        Try
            dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
            GetCmb("cod", "nom", dt, cmb_linea)
        Catch ex As Exception
            MsgBox("El centro de costo no cuenta con Area")
        End Try
        'txtobservacion.Select()
    End Sub
    Private Sub cmb_linea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_linea.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Try
            txt_linea.Text = cmb_linea.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        Else
            cmbc_costo.SelectedValue = txtc_costo.Text
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("El centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
            txtc_costo.Select()
        Else
            If cmbc_costo.SelectedIndex > -1 Then
                Dim dt As DataTable

                Try
                    dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
                    GetCmb("cod", "nom", dt, cmb_linea)
                Catch ex As Exception
                    MsgBox("El centro de costo no cuenta con Area")
                End Try

            End If
        End If
    End Sub

    Private Sub txt_linea_LostFocus(sender As Object, e As EventArgs) Handles txt_linea.LostFocus
        If cmb_linea.Items.Count > 0 Then
            If txt_linea.Text = "" Then
                cmb_linea.SelectedValue = ""
                Exit Sub
            End If
            cmb_linea.SelectedValue = txt_linea.Text
            If cmb_linea.SelectedIndex = -1 Then
                txt_linea.Text = ""
            End If
        Else
            txt_linea.Text = ""
        End If

    End Sub
End Class