Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetFacturacion
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Private Sub CleanVar()
        Me.txtcodart.Clear()
    End Sub
    Private Sub habilitar(ByVal bl As Boolean)
        txtobservacion.Enabled = bl
        'txt
    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub FormMantDetGuiaDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As New DataTable
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbuni)
        If gContador = 0 Then
            cmblinea.SelectedValue = Mid(gsCode3, 1, 2) & "00"
            dt = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
            cmbsublinea.SelectedValue = Mid(gsCode3, 1, 4)
            dt = ARTICULOBL.SelectArt1(cmbsublinea.SelectedValue)
            GetCmb("ART_CODIGO", "ART_COD", dt, cmbart)
            cmbart.SelectedValue = Trim(gsCode3)
            cmbuni.SelectedValue = sUni
            txtcodart.Text = Trim(gsCode3)
        Else
            CleanVar()
            cmbart.DataSource = Nothing
            cmbsublinea.DataSource = Nothing
            dt = REQUERIMIENTOBL.T_camb(Mid(sFecCom, 1, 10))
            For Each Registro In dt.Rows
                npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
            Next
            habilitar(True)
        End If
        bPrimero = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "37"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmblinea.SelectedValue = gLinea
            cmbsublinea.SelectedValue = gSubLinea
            cmbart.SelectedValue = gArt
            txtcodart.Text = gArt
            txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormMantDetGuiaDespacho_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "5"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            'cmblinea.SelectedValue = gLinea
            'cmbsublinea.SelectedValue = gSubLinea
            'cmbart.SelectedValue = gArt
            'txtcodart.Text = gArt
            'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            cmblinea.SelectedValue = gLinea
            cmbsublinea.SelectedValue = gSubLinea
            txtcodart.Text = gArt
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            cmbart.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
    Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
        If bPrimero Then Exit Sub
        'buscar articulo

        cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmblinea.SelectedValue = "" Then
            Exit Sub
        End If

        cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbsublinea.SelectedValue = "" Then
            Exit Sub
        End If
        Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
        GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
        cmbart.SelectedValue = txtcodart.Text
        gsCode = gsCode
        txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)

        'cmbart.SelectedValue = gArt
        'If bPrimero Then Exit Sub
        'buscar articulo
        'Dim dt As DataTable
        'cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        'If cmblinea.SelectedValue = "" Then
        '    Exit Sub
        'End If
        'Dim art As String = txtcodart.Text
        'If flagAccion = "N" Then
        '    cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        '    txtcodart.Text = art
        'Else
        '    cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        'End If

        'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        'txtcodart.Text = art
        'If cmbsublinea.SelectedValue = "" Then
        '    Exit Sub
        'End If
        'If flagAccion = "M" Then
        '    cmbart.DataSource = Nothing
        '    dt = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
        '    GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
        'Else
        'End If
        'cmbart.SelectedValue = txtcodart.Text

        'If cmbart.SelectedValue <> txtcodart.Text Then
        '    MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
        '    txtcodart.Text = ""
        '    txtcodart.Select()
        'End If

    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If cmbuni.SelectedIndex = -1 Then
            MsgBox("Ingrese la unidad de medida")
            Exit Sub
        End If
        If npdcantidad.Value = 0 Then
            MsgBox("La cantidad debe ser mayor a 0")
            Exit Sub
        End If
        If npdtcamb.Value = 0 Then
            MsgBox("El tipo de Cambio debe ser mayor a 0")
            Exit Sub
        End If
        If FormMantFacturacion.txtmon.Text = "00" Then
            If npduprecio_venta.Value = 0 Then
                MsgBox("El Precio de Venta en Soles debe ser mayor a 0")
            End If
        ElseIf FormMantFacturacion.txtmon.Text = "01" Then
            If npduprecio_venta.Value = 0 Then
                MsgBox("El Precio de Venta en Dolares debe ser mayor a 0")
            End If
        End If

        If npdtcamb.Value = 0 Then
            MsgBox("El tipo de Cambio debe ser mayor a 0")
            Exit Sub
        End If
        Dim medida As String
        If gContador = 1 Then

            '    gContador = 0
            If npdcantidad.Value > 0 Then
                Dim sValor As String

                Dim i As Integer
                Dim icontador As Integer
                If gContador = 1 Then
                    gContador = 0
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                    If FormMantFacturacion.dgvt_doc.Rows.Count > 0 Then
                        For i = 0 To FormMantFacturacion.dgvt_doc.Rows.Count - 1
                            If FormMantFacturacion.dgvt_doc.Rows(i).Cells("ART_COD").Value = cmbart.SelectedValue Then
                                icontador = icontador + 1
                            End If
                        Next
                    End If
                    Try
                        medida = ARTICULOBL.getMedida(txtcodart.Text)

                    Catch ex As Exception

                    End Try

                    If icontador > 0 Then
                        FormMantFacturacion.dgvt_doc.Rows.Add(FormMantFacturacion.txtt_doc.Text, '0
                                                              FormMantFacturacion.cmb_serdoc.Text,'1
                                                              FormMantFacturacion.txtnumero.Text, '2
                                                              FormMantFacturacion.txtt_doc.Text, '3
                                                              FormMantFacturacion.cmb_serdoc.Text,'4
                                                              txtguia.Text, '5
                                                              FormMantFacturacion.txtctct_cod.Text,'6 
                                                              npdcantidad.Value, '7
                                                              cmbart.SelectedValue,'8
                                                              sValor, '9
                                                              medida, '10
                                                              cmbuni.SelectedValue,'11
                                                              "", "", "", "", "", "+", txtobservacion.Text, '18
                                                              FormMantFacturacion.txtt_movinv.Text, '19
                                                              txttprecio_venta.Text, txttprecio_dventa.Text, '21
                                                              txtigv.Text, txtigvimpor.Text, npdtcamb.Value,'24
                                                              npduprecio_venta.Value,'25
                                                              npduprecio_dventa.Value,'26
                                                              txtigv_dimpor.Text, FormMantFacturacion.txtmon.Text,  '28
                                                              FormMantFacturacion.dtpfecha.Text, '29
                                                              gsUser, '30
                                                              cmbuni.SelectedValue, '31
                                                              FormMantFacturacion.txtt_pago.Text, '30
                                                              FormMantFacturacion.txtfor_ent.Text,'31
                                                              RTrim(DateTime.Now), "20100279348", '35
                                                              "", "", '37
                                                              "", "", '39
                                                              txtnro_docu1.Text, "", txtdscto.Text, txtdscto_impor.Text, '43
                                                              txtdscto_dimpor.Text,'44
                                                              FormMantFacturacion.cmbestado.Text,'45
                                                              txtpercepcion.Text) '46
                        Dispose()
                    Else
                        FormMantFacturacion.dgvt_doc.Rows.Add(FormMantFacturacion.txtt_doc.Text, '0
                                                              FormMantFacturacion.cmb_serdoc.Text,'1
                                                              FormMantFacturacion.txtnumero.Text, '2
                                                              FormMantFacturacion.txtt_doc.Text, '3
                                                              FormMantFacturacion.cmb_serdoc.Text,'4
                                                              txtguia.Text, '5
                                                              FormMantFacturacion.txtctct_cod.Text,'6 
                                                              npdcantidad.Value, '7
                                                              cmbart.SelectedValue,'8
                                                              sValor, '9
                                                              medida, '10
                                                              cmbuni.SelectedValue,'11
                                                              "", "", "", "", "", "+", txtobservacion.Text, '18
                                                              FormMantFacturacion.txtt_movinv.Text, '19
                                                              txttprecio_venta.Text, txttprecio_dventa.Text, '21
                                                              txtigv.Text, txtigvimpor.Text, npdtcamb.Value,'24
                                                              npduprecio_venta.Value,'25
                                                              npduprecio_dventa.Value,'26
                                                              txtigv_dimpor.Text, FormMantFacturacion.txtmon.Text,  '28
                                                              FormMantFacturacion.dtpfecha.Text, '29
                                                              gsUser, '30
                                                              cmbuni.SelectedValue, '31
                                                              FormMantFacturacion.txtt_pago.Text, '30
                                                              FormMantFacturacion.txtfor_ent.Text,'31
                                                              RTrim(DateTime.Now), "20100279348", '35
                                                              "", "", '37
                                                              "", "", '39
                                                              txtnro_docu1.Text, "", txtdscto.Text, txtdscto_impor.Text, '43
                                                              txtdscto_dimpor.Text,'44
                                                              FormMantFacturacion.cmbestado.Text,'45
                                                              txtpercepcion.Text) '46
                        Dispose()
                    End If
                End If
            Else
                MsgBox("Favor Ingrese la cantidad a declarar")
            End If
        ElseIf gContador = 0 Then
            If FormMantFacturacion.txtmon.Text = "01" Then
                If txtigv.Text > 0 Then
                    txttcomprad.Text = Math.Round((npduprecio_dventa.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txttcompras.Text = Math.Round(((npduprecio_dventa.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dventa.Text * npdcantidad.Text) * npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text * npdtcamb.Text, 2)
                    txttprecio_dventa.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)

                Else
                    txttcomprad.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txttcompras.Text = Math.Round((npduprecio_dventa.Text * npdcantidad.Text) * npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text * npdtcamb.Text, 2)
                    txttprecio_dventa.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txtigvimpor.Text = 0
                    txtigv_dimpor.Text = 0
                End If

            Else
                If txtigv.Text > 0 Then
                    npduprecio_dventa.Value = npduprecio_venta.Value / npdtcamb.Value
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttcomprad.Text = Math.Round(((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                Else
                    npduprecio_dventa.Value = npduprecio_venta.Value / npdtcamb.Value
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text), 2)
                    txttcomprad.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = 0
                    txtigv_dimpor.Text = 0
                End If

            End If
            Dim sValor As String
            sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = npdcantidad.Value '7
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value = cmbart.SelectedValue
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = sValor
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value = txtobservacion.Text '16
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("TPRECIO_VENTA").Value = txttprecio_venta.Text
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DVENTA").Value = txttprecio_dventa.Text '19
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("IGV").Value = txtigv.Text
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value = txtigvimpor.Text
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value = npdtcamb.Value
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("UPRECIO_VENTA").Value = npduprecio_venta.Value '23
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DVENTA").Value = npduprecio_dventa.Value '24
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value = cmbuni.SelectedValue '29
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value = txtguia.Text '29
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value = txtnro_docu1.Text '29
            FormMantFacturacion.dgvt_doc.Rows(FormMantFacturacion.dgvt_doc.CurrentRow.Index).Cells("PERCEPCION").Value = txtpercepcion.Text '46
            Dispose()
        End If
    End Sub
    Private Sub cmbart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbart.SelectedIndexChanged
        If bTercero Then
            Exit Sub
        End If
        'OJO VER
        If cmbart.SelectedIndex <> -1 Then
            cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(cmbart.Text, 1, 8))
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

            Else
                MsgBox("La Sublinea no tiene articulos")
                cmbart.DataSource = Nothing
            End If

        End If
        cmbuni.SelectedIndex = -1
    End Sub

    Private Sub cmbart_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbart.SelectedIndexChanged
        If bTercero Then
            Exit Sub
        End If
        'OJO VER
        If cmbart.SelectedIndex <> -1 Then
            cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(cmbart.Text, 1, 8))
        End If
        bTercero = False
    End Sub


    Private Sub npduprecio_compra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_venta.LostFocus
        'If gContador <> 0 Then
        If FormMantFacturacion.txtmon.Text = "00" Then
            If npdcantidad.Value > 0 And npduprecio_venta.Value <> 0 And npdtcamb.Value > 0 Then
                If txtigv.Text > 0 Then
                    npduprecio_dventa.Value = npduprecio_venta.Value / npdtcamb.Value
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + (npduprecio_venta.Text * npdcantidad.Text), 2)
                    txttcomprad.Text = Math.Round(((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                Else
                    npduprecio_dventa.Value = npduprecio_venta.Value / npdtcamb.Value
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text), 2)
                    txttcomprad.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = 0
                    txtigv_dimpor.Text = 0
                End If

            End If
        Else
            If npduprecio_dventa.Value = 0 Then
                npduprecio_dventa.Select()
            End If

        End If
        'End If
    End Sub


    Private Sub npduprecio_dcompra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_dventa.LostFocus
        If FormMantFacturacion.txtmon.Text = "01" Then
            npduprecio_venta.Value = npduprecio_dventa.Value * npdtcamb.Value
            If npdcantidad.Value > 0 And npduprecio_dventa.Value <> 0 Then
                If txtigv.Text > 0 Then
                    txttcomprad.Text = Math.Round((npduprecio_dventa.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txttcompras.Text = Math.Round(((npduprecio_dventa.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dventa.Text * npdcantidad.Text) * npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text * npdtcamb.Text, 2)
                    txttprecio_dventa.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                Else
                    txttcomprad.Text = Math.Round((npduprecio_dventa.Text * npdcantidad.Text), 2)
                    txttcompras.Text = Math.Round((npduprecio_dventa.Text * npdcantidad.Text) * npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text * npdtcamb.Text, 2)
                    txttprecio_dventa.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txtigvimpor.Text = 0
                    txtigv_dimpor.Text = 0
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                End If

            End If
        Else
            If npduprecio_venta.Value = 0 Then
                npduprecio_venta.Select()
            End If
        End If
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
                txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
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
                txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
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


End Class