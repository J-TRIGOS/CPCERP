Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetGuiaDespacho
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private FACTURACIONBL As New FACTURACIONBL
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
            Dim nro As String
            nro = FACTURACIONBL.SelectNro4("09", "001")
            Dim cmb As Double = 0
            'Dim dt As DataTable
            'dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
            ''Dim frm As New FormMantDetFacturacion
            'For Each Registro In dt.Rows
            '    cmb = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
            'Next
            If nro.Length = 4 Then
                nro = "000" & nro
            ElseIf nro.Length = 5 Then
                nro = "00" & nro
            ElseIf nro.Length = 6 Then
                nro = "0" & nro
            ElseIf nro.Length = 7 Then
                nro = nro
            End If
            txtserie_soli.Text = "F001"
            txtnro_docu1.Text = nro
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
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            cmbart.SelectedValue = txtcodart.Text
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
            cmblinea.SelectedValue = gLinea
            cmbsublinea.SelectedValue = gSubLinea
            txtcodart.Text = gArt
            cmbart.SelectedValue = gArt
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            cmbart.SelectedValue = txtcodart.Text
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
        'gsCode = gsCode
        txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If cmbuni.SelectedIndex = -1 Then
            MsgBox("Ingrese la unidad de medida")
            Exit Sub
        End If
        Dim medida As String
        If lbltmov.Text = "E21" Or lbltmov.Text = "S28" Then
            If txtndocfac.Text = "" Or txtsdocfac.Text = "" Or txttdocfac.Text = "" Then
                MsgBox("Debe Ingresar el tipo, serie y numero de documento")
                Exit Sub
            End If
        End If
        If gContador = 1 Then

            '    gContador = 0
            If npdcantidad.Value > 0 Then
                Dim sValor As String

                If gContador = 1 Then
                    'gContador = 0
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)

                    Try
                        medida = ARTICULOBL.getMedida(txtcodart.Text)
                        'If medida = Nothing Then
                        '    MsgBox("Falta medida al articulo")
                        '    Exit Sub
                        'End If
                    Catch ex As Exception

                    End Try

                    FormMantGuiaDespacho.dgvt_doc.Rows.Add(FormMantGuiaDespacho.txtt_doc.Text, '0
                                                              FormMantGuiaDespacho.cmb_serdoc.Text,'1
                                                              FormMantGuiaDespacho.txtnumero.Text, '2
                                                              FormMantGuiaDespacho.txtt_doc.Text, '3
                                                              FormMantGuiaDespacho.cmb_serdoc.Text,'4
                                                              FormMantGuiaDespacho.txtnumero.Text, '5
                                                              FormMantGuiaDespacho.txtctct_cod.Text,'6
                                                              npdcantidad.Value, '7
                                                              cmbart.SelectedValue,'8
                                                              sValor, '9
                                                              medida, '10
                                                              ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),'11
                                                              txtserie_soli.Text,'12
                                                              "", "", "", "", "+",  '17
                                                              FormMantGuiaDespacho.txtt_movinv.Text, '18
                                                              txttprecio_venta.Text, txttprecio_dventa.Text, '20
                                                              txtigv.Text, txtigvimpor.Text, npdtcamb.Value,'23
                                                              npduprecio_venta.Value,'24
                                                              npduprecio_dventa.Value,'25
                                                              txtigv_dimpor.Text, FormMantGuiaDespacho.txtmon.Text,  '27
                                                              FormMantGuiaDespacho.dtpfecha.Text, '28
                                                              gsUser, '29
                                                              FormMantGuiaDespacho.txtt_pago.Text, '30
                                                              FormMantGuiaDespacho.txtfor_ent.Text,'31
                                                              RTrim(DateTime.Now), "20100279348", '33
                                                              "", "", '35
                                                              "", "", '37
                                                              "", txtdscto.Text, txtdscto_impor.Text, '40
                                                              txtdscto_dimpor.Text,'41
                                                              FormMantGuiaDespacho.cmbestado.Text,'42
                                                              txttdocfac.Text, txtsdocfac.Text, txtndocfac.Text,'45
                                                              "", "", "", "", "", "", "", "", "", Mid(dtpfec_ent.Value, 1, 10), txtobservacion.Text, '56
                                                              npdpeso.Value) '57
                    Dispose()
                End If
            Else
                MsgBox("Favor Ingrese la cantidad a declarar")
            End If
        ElseIf gContador = 0 Then
            If FormMantGuiaDespacho.txtmon.Text = "01" Then
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
                    txttcomprad.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txttcompras.Text = Math.Round((npduprecio_dventa.Text * npdcantidad.Text) * npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text * npdtcamb.Text, 2)
                    txttprecio_dventa.Text = Math.Round(npduprecio_dventa.Text * npdcantidad.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                End If

            Else
                If txtigv.Text > 0 Then
                    npduprecio_dventa.Value = Math.Round(npduprecio_venta.Value / npdtcamb.Value, 2)
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttcomprad.Text = Math.Round(((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                Else
                    npduprecio_dventa.Value = Math.Round(npduprecio_venta.Value / npdtcamb.Value, 2)
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text), 2)
                    txttcomprad.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                End If

            End If
            Dim sValor As String
            sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = npdcantidad.Value '7
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value = cmbart.SelectedValue
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = SVALOR
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value = txtobservacion.Text '16
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("TPRECIO_VENTA").Value = txttprecio_venta.Text
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DVENTA").Value = txttprecio_dventa.Text '19
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("IGV").Value = txtigv.Text
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value = txtigvimpor.Text
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value = npdtcamb.Value
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("UPRECIO_VENTA").Value = npduprecio_venta.Value '23
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DVENTA").Value = npduprecio_dventa.Value '24
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)) '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("FEC_ENT").Value = dtpfec_ent.Value '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value = txtnro_docu1.Text '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("SERIE_SOLI").Value = txtserie_soli.Text '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("PESO").Value = npdpeso.Value '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("REPROVEEDOR").Value = txttdocfac.Text '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("RETRANSPORTISTA").Value = txtsdocfac.Text '29
            FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("MARCA1").Value = txtndocfac.Text '29
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
        'txtcodart.Text = cmbart.SelectedValue
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
        If FormMantGuiaDespacho.txtmon.Text = "00" Then
            If npdcantidad.Value > 0 And npduprecio_venta.Value > 0 Then
                If txtigv.Text > 0 Then
                    npduprecio_dventa.Value = Math.Round(npduprecio_venta.Value / npdtcamb.Value, 2)
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttcomprad.Text = Math.Round(((npduprecio_venta.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")

                Else
                    npduprecio_dventa.Value = Math.Round(npduprecio_venta.Value / npdtcamb.Value, 2)
                    txttcompras.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text), 2)
                    txttcomprad.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txttprecio_venta.Text = Math.Round(npduprecio_venta.Text * npdcantidad.Text, 2)
                    txttprecio_dventa.Text = Math.Round((npduprecio_venta.Text * npdcantidad.Text) / npdtcamb.Text, 2)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                End If

            End If
            Else
            If npduprecio_dventa.Value = 0 Then
                npduprecio_dventa.Select()
            End If

        End If
    End Sub


    Private Sub npduprecio_dcompra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_dventa.LostFocus
        'If gContador <> 0 Then
        If FormMantGuiaDespacho.txtmon.Text = "01" Then
            npduprecio_venta.Value = npduprecio_dventa.Value * npdtcamb.Value
            If npdcantidad.Value > 0 And npduprecio_dventa.Value > 0 Then
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
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_venta.Text, 2)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dventa.Text, 2)
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