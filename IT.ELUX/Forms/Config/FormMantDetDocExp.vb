Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormMantDetDocExp
    Private ARTICULOBL As New ARTICULOBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private CCOSTOBL As New CCOSTOBL
    Private ss As String = ""
    Public modif As String
    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "117"
            'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.medida = Mid(FormMantDocExp.txtmskfecsbs.Text, 7, 4)
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txtcuenta.Text = gLinea
                txtnomcuenta.Text = PROVISIONESBL.SelectNomCta(txtcuenta.Text, Mid(FormMantDocExp.txtmskfecprov.Text, 7, 4))
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
            e.Handled = True
        End If

        'CODIGO NUEVO
        Dim dt As DataTable
        Dim i As Integer = dgvt_docdet.Rows.Count

        If e.KeyValue = Keys.Down Then
            If CInt(gsCode5) + 1 = i Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
                gsCode5 = CInt(gsCode5) + 1
                ss = ""


                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtnomcuenta.Text = PROVISIONESBL.SelectNomCta(txtcuenta.Text, Mid(FormMantDocExp.txtmskfecprov.Text, 7, 4))
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                txtnomcuenta_dest.Text = PROVISIONESBL.SelectNomCta(txtcuenta_dest.Text, Mid(FormMantDocExp.txtmskfecprov.Text, 7, 4))
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If

                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
            End If
            e.Handled = True
        End If

        If e.KeyValue = Keys.Up Then
            If CInt(gsCode5) - 1 = -1 Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia '42
                gsCode5 = CInt(gsCode5) - 1
                ss = ""

                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If

                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
            End If
            e.Handled = True
        End If
        'CODIGO NUEVO
        Label31.Text = gsCode5

        'If ss = "1" Then
        '    If dgvt_docdet.Rows.Count > 0 Then


        '    End If
        'End If


        If e.KeyValue = Keys.Enter Then
            txtcuenta_dest.Focus()
        End If
    End Sub



    Private Sub txtcuenta_dest_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta_dest.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "117"
            'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txtcuenta_dest.Text = gLinea
                txtnomcuenta_dest.Text = PROVISIONESBL.SelectNomCta(txtcuenta_dest.Text, Mid(FormMantDocExp.txtmskfecprov.Text, 7, 4))
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
            e.Handled = True
        End If

        'CODIGO NUEVO
        Dim dt As DataTable
        Dim i As Integer = dgvt_docdet.Rows.Count

        If e.KeyValue = Keys.Down Then
            If CInt(gsCode5) + 1 = i Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
                gsCode5 = CInt(gsCode5) + 1
                ss = ""

                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                'frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
                '    frm.txtigv.Text = 18
                'End If
                'frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year.ToString("yyyy") & "/" & dtpfecha.Value.Month.ToString("MM") & "/" & dtpfecha.Value.Day.ToString("dd"))
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                'End If
                'gCliente = txtctct_cod.Text
            End If
            e.Handled = True
        End If

        If e.KeyValue = Keys.Up Then
            If CInt(gsCode5) - 1 = -1 Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
                gsCode5 = CInt(gsCode5) - 1
                ss = ""
                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                'frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
                '    frm.txtigv.Text = 18
                'End If
                'frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year.ToString("yyyy") & "/" & dtpfecha.Value.Month.ToString("MM") & "/" & dtpfecha.Value.Day.ToString("dd"))
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                'End If
                'gCliente = txtctct_cod.Text
            End If
            e.Handled = True
        End If

        Label31.Text = gsCode5

        If e.KeyValue = Keys.Enter Then
            txtcodart.Focus()
        End If
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtser_doc_ref1.KeyDown, txtnro_doc_ref1.KeyDown, npduprecio_dcompra.KeyDown, txtdscto.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtnomart.Text = gSubLinea
                txtcodart.Text = gLinea
                txtunidad.Text = ARTICULOBL.SelectUniMed(gLinea)
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
        ss = ""
        '----VERIFICAR
        Dim dt As DataTable
        Dim i As Integer = dgvt_docdet.Rows.Count

        If e.KeyValue = Keys.Down Then
            If CInt(gsCode5) + 1 = i Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbstatus.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '39
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '40
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '41
                gsCode5 = CInt(gsCode5) + 1
                ss = ""

                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                'frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
                '    frm.txtigv.Text = 18
                'End If
                'frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year.ToString("yyyy") & "/" & dtpfecha.Value.Month.ToString("MM") & "/" & dtpfecha.Value.Day.ToString("dd"))
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                'End If
                'gCliente = txtctct_cod.Text
            End If
            e.Handled = True
        End If

        If e.KeyValue = Keys.Up Then
            If CInt(gsCode5) - 1 = -1 Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbstatus.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
                gsCode5 = CInt(gsCode5) - 1
                ss = ""

                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                'frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
                '    frm.txtigv.Text = 18
                'End If
                'frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year.ToString("yyyy") & "/" & dtpfecha.Value.Month.ToString("MM") & "/" & dtpfecha.Value.Day.ToString("dd"))
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                'End If
                'gCliente = txtctct_cod.Text
            End If
            e.Handled = True
        End If
        'Grabar valores antes de saltar en el grid

        Label31.Text = gsCode5
        If Label31.Text.Length <> 0 Then
            Label32.Text = Label31.Text + 1
        End If
        If modif <> "0" Then
            Label32.Text = Label31.Text + 1
        End If

        If e.KeyValue = Keys.Enter Then
            npdcantidad.Focus()
        End If
    End Sub

    Private Sub txtt_doc_ref1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_doc_ref1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "102"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtt_doc_ref1.Text = gLinea
                txtnom_t_doc.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
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

        'CODIGO NUEVO
        Dim dt As DataTable
        Dim i As Integer = dgvt_docdet.Rows.Count

        If e.KeyValue = Keys.Down Then
            If CInt(gsCode5) + 1 = i Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbstatus.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Text '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
                gsCode5 = CInt(gsCode5) + 1
                ss = ""
                If dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = "" Then
                    cmbsguia.SelectedIndex = -1
                End If
                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
            End If
            e.Handled = True
        End If

        If e.KeyValue = Keys.Up Then
            If CInt(gsCode5) - 1 = -1 Then
                'gsCode5 = CInt(gsCode5)
            Else
                Dim status As String
                Dim signo As String
                If cmbstatus.SelectedIndex = 1 Then
                    status = "AFECTO"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    status = "INAFECTO"
                Else
                    status = ""
                End If

                If cmbsigno.SelectedIndex = 1 Then
                    signo = "+"
                ElseIf cmbsigno.SelectedIndex = 2 Then
                    signo = "-"
                Else
                    signo = ""
                End If
                Dim cm As String = ""
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
                dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
                dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
                dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
                dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
                dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
                dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
                dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
                dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
                dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
                dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
                dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
                dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
                dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
                dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
                dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
                dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
                dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
                dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
                dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
                dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
                dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '40
                dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '41
                gsCode5 = CInt(gsCode5) - 1
                ss = ""
                If dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = "" Then
                    cmbsguia.SelectedIndex = -1
                End If
                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                'frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
                'frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                    cmb_xd.SelectedIndex = 1
                Else
                    cmb_xd.SelectedIndex = -1
                End If
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                'frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
                '    frm.txtigv.Text = 18
                'End If
                'frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year.ToString("yyyy") & "/" & dtpfecha.Value.Month.ToString("MM") & "/" & dtpfecha.Value.Day.ToString("dd"))
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                'End If
                'gCliente = txtctct_cod.Text
            End If
            e.Handled = True
        End If
        'CODIGO NUEVO

        Label31.Text = gsCode5
        If e.KeyValue = Keys.Enter Then
            txtser_doc_ref1.Focus()
        End If
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dim status As String
        Dim signo As String
        If cmbstatus.SelectedIndex = 1 Then
            status = "AFECTO"
        ElseIf cmbstatus.SelectedIndex = 2 Then
            status = "INAFECTO"
        Else
            status = ""
        End If

        If cmbsigno.SelectedIndex = 1 Then
            signo = "+"
        ElseIf cmbsigno.SelectedIndex = 2 Then
            signo = "-"
        Else
            signo = ""
        End If
        Dim cm As String = ""
        If cmb_xd.SelectedIndex = 1 Then
            cm = "1"
        End If
        dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
        dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
        dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
        dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '5
        dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '6
        dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '7
        dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '8
        dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '9
        dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
        dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
        dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
        dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
        dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
        dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
        dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
        dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
        dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
        dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
        dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
        dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
        dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
        dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
        dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
        dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
        dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
        dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
        dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
        dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
        dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
        dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
        dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
        dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
        dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
        dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
        dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
        gsCode5 = CInt(gsCode5) + 1
        ss = "1"
        Label31.Text = gsCode5 + 1
        If (dgvt_docdet.Rows.Count = gsCode5) Then
            gsCode5 = CInt(gsCode5) - 1
            btnagregar.Focus()
        Else
            txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
            txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
            txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
            txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
            txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
            txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
            txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
            txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
            txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
            sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
            npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
            npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
            npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
            npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
            npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
            npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
            txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
            txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
            txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
            txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
            txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
            txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
            txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
            txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
            txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
            txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
            txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
            txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
            txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
            txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
            txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
            cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
            npdadvalore.Text = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
            If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                cmbsigno.SelectedIndex = 1
            ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                cmbsigno.SelectedIndex = 2
            End If
            If dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = "1" Then
                cmb_xd.SelectedIndex = 1
            Else
                cmb_xd.SelectedIndex = -1
            End If
            If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                cmbstatus.SelectedIndex = 1
            Else
                cmbstatus.SelectedIndex = 2
            End If
            If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
            End If
            txtt_doc_ref1.Focus()
        End If
    End Sub

    Private Sub FormMantDetProvisiones_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If Mid(txtcuenta.Text, 1, 2) = "62" Or Mid(txtcuenta.Text, 1, 2) = "63" Or Mid(txtcuenta.Text, 1, 2) = "64" Or
            Mid(txtcuenta.Text, 1, 2) = "65" Or Mid(txtcuenta.Text, 1, 2) = "68" Or Mid(txtcuenta.Text, 1, 2) = "67" Then
            If txtcco_cod.TextLength = 0 Then
                MsgBox("Debe ingresar el centro de Costo")
                Exit Sub
            End If
        End If
        Dim status As String
        Dim signo As String
        Dim cm As String = ""
        If cmbstatus.SelectedIndex = 1 Then
            status = "AFECTO"
        ElseIf cmbstatus.SelectedIndex = 2 Then
            status = "INAFECTO"
        Else
            status = ""
        End If

        If cmbsigno.SelectedIndex = 1 Then
            signo = "+"
        ElseIf cmbsigno.SelectedIndex = 2 Then
            signo = "-"
        Else
            signo = ""
        End If
        If cmb_xd.SelectedIndex = 1 Then
            cm = "1"
        End If
        If modif = "0" Then

            FormMantDocExp.dgvt_doc.Rows.Add(FormMantDocExp.txtt_doc.Text, '0
                                                             FormMantDocExp.txtser_doc_ref.Text,'1
                                                             FormMantDocExp.txtnumero.Text, '2
                                                             txtt_doc_ref1.Text, '3
                                                             txtser_doc_ref1.Text,'4
                                                             txtnro_doc_ref1.Text, '5
                                                             txtcco_cod.Text,'6
                                                             status,'7
                                                             txtcuenta.Text, '8
                                                             txtcuenta_dest.Text,'9
                                                             signo, '10
                                                             "20100279348", '11
                                                             npdcantidad.Value,'12
                                                             txtcodart.Text,'13
                                                             txtunidad.Text,'14
                                                             txttprecio_compra.Text,'15
                                                             txttprecio_dcompra.Text,'16
                                                             txtigv.Text,'17
                                                             txtigvimpor.Text,'18
                                                             npdtcamb.Value,'19
                                                             npduprecio_compra.Value, '20
                                                             npduprecio_dcompra.Value, '21
                                                             txtigv_dimpor.Text, '22
                                                             FormMantDocExp.txtmoneda.Text,'23
                                                             "", '24
                                                             gsUser,'25
                                                             RTrim(DateTime.Now),'26
                                                             FormMantDocExp.txtproveedor.Text,'27
                                                             txtdscto_impor.Text,'28
                                                             txtdscto_dimpor.Text,  '29
                                                             txtdscto.Text, '30
                                                             txties.Text, '31
                                                             txties_impor.Text, '32
                                                             txties_dimpor.Text, '33
                                                             txtcta.Text,'34
                                                             txtcta_impor.Text, '35
                                                             txtcta_dimpor.Text, '36
                                                             npduprecio_afectos.Value, '37
                                                             npduprecio_afectod.Value,'38
                                                             ARTICULOBL.SelectArt2(txtcodart.Text),'39
                                                             npdadvalore.Value,'40
                                                             cmbsguia.Text,'41
                                                             txtnguia.Text,'42,
                                                             cm) '43
            Dispose()
        Else
            FormMantDocExp.dgvt_doc.Rows.Clear()
            dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value = txtt_doc_ref1.Text '3
            dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value = txtser_doc_ref1.Text '4
            dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value = txtnro_doc_ref1.Text '5
            dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value = txtcco_cod.Text '6
            dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = status '7
            dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text '8
            dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value = txtcuenta_dest.Text '9
            dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = signo '10
            dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value = npdcantidad.Value '11
            dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value = txtcodart.Text '12
            dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value = txtunidad.Text '13
            dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value = txttprecio_compra.Text '14
            dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value = txttprecio_dcompra.Text '15
            dgvt_docdet.Rows(gsCode5).Cells("IGV").Value = txtigv.Text '16
            dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value = txtigvimpor.Text '17
            dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value = npdtcamb.Value '18
            dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value = npduprecio_compra.Value '19
            dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value = npduprecio_dcompra.Value '20
            dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value = txtigv_dimpor.Text '21
            dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value = txtdscto_impor.Text '27
            dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value = txtdscto_dimpor.Text '28
            dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value = txtdscto.Text '29
            dgvt_docdet.Rows(gsCode5).Cells("IES").Value = txties.Text '30
            dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value = txties_impor.Text '31
            dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value = txties_dimpor.Text '32
            dgvt_docdet.Rows(gsCode5).Cells("CTA").Value = txtcta.Text '33
            dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value = txtcta_impor.Text '34
            dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value = txtcta_dimpor.Text '35
            dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value = npduprecio_afectos.Value '36
            dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value = npduprecio_afectod.Value '37
            'verificar
            dgvt_docdet.Rows(gsCode5).Cells("ART_NOM").Value = ARTICULOBL.SelectArt2(txtcodart.Text) '38
            dgvt_docdet.Rows(gsCode5).Cells("X_D").Value = cm '39
            dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value = txtnguia.Text '41
            dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value = cmbsguia.Text '42
            dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value = npdadvalore.Value '40
            gsCode5 = CInt(gsCode5) + 1
            ss = "1"
            Label31.Text = gsCode5 + 1
            If (dgvt_docdet.Rows.Count = gsCode5) Then
                gsCode5 = CInt(gsCode5) - 1
                btnagregar.Focus()
            Else
                txtcodart.Text = dgvt_docdet.Rows(gsCode5).Cells("ART_COD").Value
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                If cmb_xd.SelectedIndex = 1 Then
                    cm = "1"
                End If
                txtunidad.Text = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                txtt_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF1").Value
                txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
                txtser_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("SER_DOC_REF1").Value
                txtnro_doc_ref1.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC_REF1").Value
                txtcco_cod.Text = dgvt_docdet.Rows(gsCode5).Cells("CCO_COD").Value
                txtcco_nom.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
                txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA").Value
                txtcuenta_dest.Text = dgvt_docdet.Rows(gsCode5).Cells("CUENTA_DEST").Value
                sUni = dgvt_docdet.Rows(gsCode5).Cells("UNIDAD").Value
                npdcantidad.Text = dgvt_docdet.Rows(gsCode5).Cells("CANTIDAD").Value
                npdtcamb.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("T_CAMB").Value)
                npduprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_COMPRA").Value)
                npduprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_DCOMPRA").Value)
                npduprecio_afectos.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOS").Value)
                npduprecio_afectod.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("UPRECIO_AFECTOD").Value)
                txttprecio_compra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_COMPRA").Value)
                txttprecio_dcompra.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("TPRECIO_DCOMPRA").Value)
                txtdscto.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO").Value)
                txtigv.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV").Value)
                txtigvimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_IMPOR").Value)
                txtigv_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IGV_DIMPOR").Value)
                txtdscto_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_DIMPOR").Value)
                txtdscto_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("DSCTO_IMPOR").Value)
                txties.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES").Value)
                txties_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_IMPOR").Value)
                txties_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("IES_DIMPOR").Value)
                txtcta.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA").Value)
                txtcta_impor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_IMPOR").Value)
                txtcta_dimpor.Text = Val(dgvt_docdet.Rows(gsCode5).Cells("CTA_DIMPOR").Value)
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                npdadvalore.Value = dgvt_docdet.Rows(gsCode5).Cells("ADVALORE").Value
                If dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "+" Then
                    cmbsigno.SelectedIndex = 1
                ElseIf dgvt_docdet.Rows(gsCode5).Cells("SIGNO").Value = "-" Then
                    cmbsigno.SelectedIndex = 2
                End If
                txtnguia.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOCU2").Value
                cmbsguia.Text = dgvt_docdet.Rows(gsCode5).Cells("CONFIGURACION").Value
                If dgvt_docdet.Rows(gsCode5).Cells("STATUS").Value = "AFECTO" Then
                    cmbstatus.SelectedIndex = 1
                Else
                    cmbstatus.SelectedIndex = 2
                End If
                If npduprecio_compra.Text.Length > 0 And npdcantidad.Text.Length And txtigv.Text > 0 Then
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                End If

            End If

            For Each row As DataGridViewRow In dgvt_docdet.Rows
                FormMantDocExp.dgvt_doc.Rows.Add(row.Cells("T_DOC_REF").Value,'0
                row.Cells("SER_DOC_REF").Value,'1
                row.Cells("NRO_DOC_REF").Value,'2
                row.Cells("T_DOC_REF1").Value,'3
                row.Cells("SER_DOC_REF1").Value,'4
                row.Cells("NRO_DOC_REF1").Value,'5
                row.Cells("CCO_COD").Value,'6
                row.Cells("STATUS").Value,'7
                row.Cells("CUENTA").Value,'8
                row.Cells("CUENTA_DEST").Value,'9
                row.Cells("SIGNO").Value,'10
                row.Cells("CTCT_COD").Value,'11
                row.Cells("CANTIDAD").Value,'12
                row.Cells("ART_COD").Value,'13
                row.Cells("UNIDAD").Value,'14
                row.Cells("TPRECIO_COMPRA").Value,'15
                row.Cells("TPRECIO_DCOMPRA").Value,'16
                row.Cells("IGV").Value,'17
                row.Cells("IGV_IMPOR").Value,'18
                row.Cells("T_CAMB").Value,'19
                row.Cells("UPRECIO_COMPRA").Value,'20
                row.Cells("UPRECIO_DCOMPRA").Value,'21
                row.Cells("IGV_DIMPOR").Value,'22
                row.Cells("MONEDA").Value,'23
                row.Cells("FEC_GENE").Value,'24
                row.Cells("USUARIO").Value,'25
                row.Cells("FEC_DIA").Value,'26
                row.Cells("PROVEEDOR").Value,'27
                row.Cells("DSCTO_IMPOR").Value,'28
                row.Cells("DSCTO_DIMPOR").Value,'29
                row.Cells("DSCTO").Value,'30
                row.Cells("IES").Value,'31
                row.Cells("IES_IMPOR").Value,'32
                row.Cells("IES_DIMPOR").Value,'33
                row.Cells("CTA").Value,'34
                row.Cells("CTA_IMPOR").Value,'35
                row.Cells("CTA_DIMPOR").Value,'36
                row.Cells("UPRECIO_AFECTOS").Value,'37
                row.Cells("UPRECIO_AFECTOD").Value,'38
                row.Cells("ART_NOM").Value,'39
                row.Cells("ADVALORE").Value,'40
                row.Cells("NRO_DOCU2").Value,'41
                row.Cells("CONFIGURACION").Value,'42
                row.Cells("X_D").Value) '43
            Next
        End If

        Dispose()

    End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If txtcodart.TextLength > 0 Then
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            txtunidad.Text = ARTICULOBL.SelectUniMed(txtcodart.Text)
        Else
            txtcodart.Text = ""
            txtnomart.Text = ""
            txtunidad.Text = ""
        End If
    End Sub

    Private Sub txtt_doc_ref1_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc_ref1.LostFocus
        Dim dt As DataTable
        If txtt_doc_ref1.TextLength > 0 Then
            txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc_ref1.Text)
            Dim mesfecha As String
            Dim mesdia As String
            If Mid(FormMantDocExp.txtmskfecsbs.Text, 4, 2) = "1" Then
                mesfecha = "0" & Mid(FormMantDocExp.txtmskfecsbs.Text, 4, 2)
            Else
                mesfecha = Mid(FormMantDocExp.txtmskfecsbs.Text, 4, 2)
            End If
            If Mid(FormMantDocExp.txtmskfecsbs.Text, 1, 2) = "1" Then
                mesdia = "0" & Mid(FormMantDocExp.txtmskfecsbs.Text, 1, 2)
            Else
                mesdia = Mid(FormMantDocExp.txtmskfecsbs.Text, 1, 2)
            End If
            dt = PROVISIONESBL.getT_CAMBvensbs(Mid(FormMantDocExp.txtmskfecsbs.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
            For Each Registro In dt.Rows
                npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            Next
        Else
            txtt_doc_ref1.Text = ""
            txtnom_t_doc.Text = ""
        End If
    End Sub

    Private Sub npduprecio_compra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_compra.LostFocus
        If FormMantDocExp.txtmoneda.Text = "00" Then
            If npdcantidad.Value > 0 And npduprecio_compra.Value > 0 And npdtcamb.Value > 0 Then
                If txtigv.Text > 0 Then
                    npduprecio_dcompra.Value = Math.Round(npduprecio_compra.Value / npdtcamb.Value, 6)
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + (npduprecio_compra.Text * npdcantidad.Text), 6)
                    txttcomprad.Text = Math.Round(((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                    txttprecio_compra.Text = Math.Round(npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttprecio_dcompra.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_compra.Text, 6)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dcompra.Text, 6)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                Else
                    npduprecio_dcompra.Value = Math.Round(npduprecio_compra.Value / npdtcamb.Value, 6)
                    txttcompras.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text), 6)
                    txttcomprad.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                    txttprecio_compra.Text = Math.Round(npduprecio_compra.Text * npdcantidad.Text, 6)
                    txttprecio_dcompra.Text = Math.Round((npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text, 6)
                    txtigvimpor.Text = 0
                    txtigv_dimpor.Text = 0
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                End If
            Else
                txttcomprad.Text = 0
                txttcompras.Text = 0
                txtigvimpor.Text = 0
                txtigv_dimpor.Text = 0
                txttprecio_compra.Text = 0
                txttprecio_dcompra.Text = 0
            End If
        Else
            If npduprecio_dcompra.Value = 0 Then
                npduprecio_dcompra.Focus()
            End If
        End If
    End Sub

    Private Sub npduprecio_dcompra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_dcompra.LostFocus
        If FormMantDocExp.txtmoneda.Text = "01" Then
            npduprecio_compra.Value = npduprecio_dcompra.Value * npdtcamb.Value
            If npdcantidad.Value > 0 And npduprecio_dcompra.Value > 0 Then
                If txtigv.Text > 0 Then
                    txttcomprad.Text = Math.Round((npduprecio_dcompra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dcompra.Text * npdcantidad.Text, 6)
                    txttcompras.Text = Math.Round(((npduprecio_dcompra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dcompra.Text * npdcantidad.Text) * npdtcamb.Text, 6)
                    txttprecio_compra.Text = Math.Round(npduprecio_dcompra.Text * npdcantidad.Text * npdtcamb.Text, 6)
                    txttprecio_dcompra.Text = Math.Round(npduprecio_dcompra.Text * npdcantidad.Text, 6)
                    txtigvimpor.Text = Math.Round(txttcompras.Text - txttprecio_compra.Text, 6)
                    txtigv_dimpor.Text = Math.Round(txttcomprad.Text - txttprecio_dcompra.Text, 6)
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                Else
                    txttcomprad.Text = Math.Round((npduprecio_dcompra.Text * npdcantidad.Text), 6)
                    txttcompras.Text = Math.Round((npduprecio_dcompra.Text * npdcantidad.Text) * npdtcamb.Text, 6)
                    txttprecio_compra.Text = Math.Round(npduprecio_dcompra.Text * npdcantidad.Text * npdtcamb.Text, 6)
                    txttprecio_dcompra.Text = Math.Round(npduprecio_dcompra.Text * npdcantidad.Text, 6)
                    txtigvimpor.Text = 0
                    txtigv_dimpor.Text = 0
                    'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                    'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                    'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                    'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
                End If
            Else
                txttcomprad.Text = 0
                txttcompras.Text = 0
                txtigvimpor.Text = 0
                txtigv_dimpor.Text = 0
                txttprecio_compra.Text = 0
                txttprecio_dcompra.Text = 0
            End If
        Else
            If npduprecio_compra.Value = 0 Then
                npduprecio_compra.Focus()
            End If
        End If
    End Sub

    Private Sub npduprecio_afectos_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_afectos.LostFocus
        Dim status As String
        Dim signo As String
        If cmbstatus.SelectedIndex = 1 Then
            status = "AFECTO"
        ElseIf cmbstatus.SelectedIndex = 2 Then
            status = "INAFECTO"
        Else
            status = ""
        End If

        If cmbsigno.SelectedIndex = 1 Then
            signo = "+"
        ElseIf cmbsigno.SelectedIndex = 2 Then
            signo = "-"
        Else
            signo = ""
        End If
        npduprecio_afectod.Value = npduprecio_afectos.Value / npdtcamb.Value
        If FormMantDocExp.txtmoneda.Text = "01" Then
            If status = "AFECTO" And FormMantDocExp.txtt_doc.Text <> "02" And npduprecio_afectos.Value > 0 Then
                txtigv.Select()
            ElseIf status = "AFECTO" And FormMantDocExp.txtt_doc.Text = "02" Then
                txties.Select()
            ElseIf status = "INAFECTO" Then
                If FormMantDocExp.txtmoneda.Text = "00" And FormMantDocExp.txtt_doc.Text = "02" Then
                    txttprecio_compra.Text = npduprecio_afectos.Value * npdcantidad.Value
                    txttprecio_dcompra.Text = npduprecio_afectos.Value * npdcantidad.Value / npdtcamb.Value
                    txttcompras.Text = txttprecio_compra.Text
                    txttcomprad.Text = txttprecio_dcompra.Text
                    'txtigv
                ElseIf FormMantDocExp.txtt_doc.Text <> "02" And FormMantDocExp.txtmoneda.Text = "00" And status = "INAFECTO" Then
                    txttprecio_compra.Text = npduprecio_afectos.Value * npdcantidad.Value
                    txttprecio_dcompra.Text = npduprecio_afectos.Value * npdcantidad.Value / npdtcamb.Value
                    txttcompras.Text = txttprecio_compra.Text
                    txttcomprad.Text = txttprecio_dcompra.Text
                End If
            End If
        ElseIf FormMantDocExp.txtmoneda.Text = "00" Then
            'If status = "AFECTO" And FormMantDocExp.txtt_doc.Text <> "02" And npduprecio_afectos.Value > 0 Then
            '    txtigv.Select()
            'ElseIf status = "AFECTO" And FormMantDocExp.txtt_doc.Text = "02" Then
            '    txties.Select()
            'ElseIf status = "INAFECTO" Then
            If FormMantDocExp.txtmoneda.Text = "00" And FormMantDocExp.txtt_doc.Text = "02" Then
                txttprecio_compra.Text = npduprecio_afectos.Value * npdcantidad.Value
                txttprecio_dcompra.Text = npduprecio_afectos.Value * npdcantidad.Value / npdtcamb.Value
                txttcompras.Text = txttprecio_compra.Text
                txttcomprad.Text = txttprecio_dcompra.Text
                'txtigv
            ElseIf FormMantDocExp.txtt_doc.Text <> "02" And FormMantDocExp.txtmoneda.Text = "00" And status = "INAFECTO" Then
                txttprecio_compra.Text = npduprecio_afectos.Value * npdcantidad.Value
                txttprecio_dcompra.Text = npduprecio_afectos.Value * npdcantidad.Value / npdtcamb.Value
                txttcompras.Text = txttprecio_compra.Text
                txttcomprad.Text = txttprecio_dcompra.Text
            End If
            'End If
        End If
        txtigvimpor.Text = 0
        txtigv_dimpor.Text = 0

    End Sub
    Private Sub npduprecio_afectod_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_afectod.LostFocus
        Dim status As String
        Dim signo As String
        If cmbstatus.SelectedIndex = 1 Then
            status = "AFECTO"
        ElseIf cmbstatus.SelectedIndex = 2 Then
            status = "INAFECTO"
        Else
            status = ""
        End If

        If cmbsigno.SelectedIndex = 1 Then
            signo = "+"
        ElseIf cmbsigno.SelectedIndex = 2 Then
            signo = "-"
        Else
            signo = ""
        End If
        npduprecio_afectos.Value = npduprecio_afectod.Value * npdtcamb.Value
        'If FormMantDocExp.txtmoneda.Text = "01" Then
        If status = "AFECTO" And FormMantDocExp.txtt_doc.Text <> "02" And npduprecio_afectod.Value > 0 Then
            txtigv.Select()
        ElseIf status = "AFECTO" And FormMantDocExp.txtt_doc.Text = "02" Then
            txties.Select()
        ElseIf status = "INAFECTO" Then
            If FormMantDocExp.txtmoneda.Text = "01" And FormMantDocExp.txtt_doc.Text = "02" Then
                npduprecio_afectos.Value = npduprecio_afectod.Value * npdtcamb.Value
                txttprecio_compra.Text = npduprecio_afectod.Value * npdcantidad.Value * npdtcamb.Value
                txttprecio_dcompra.Text = npduprecio_afectod.Value * npdcantidad.Value
                txttcompras.Text = txttprecio_compra.Text
                txttcomprad.Text = txttprecio_dcompra.Text
            ElseIf FormMantDocExp.txtt_doc.Text <> "02" And FormMantDocExp.txtmoneda.Text = "01" And status = "INAFECTO" Then
                npduprecio_afectos.Value = npduprecio_afectod.Value * npdtcamb.Value
                txttprecio_compra.Text = npduprecio_afectod.Value * npdcantidad.Value * npdtcamb.Value
                txttprecio_dcompra.Text = npduprecio_afectod.Value * npdcantidad.Value
                txttcompras.Text = txttprecio_compra.Text
                txttcomprad.Text = txttprecio_dcompra.Text
            End If
        End If
        txtigvimpor.Text = 0
        txtigv_dimpor.Text = 0
        'End If
    End Sub
    Private Sub txtcuenta_LostFocus(sender As Object, e As EventArgs) Handles txtcuenta.LostFocus
        'If txtcuenta.TextLength > 0 Then
        '    txtcuenta_dest.Text = PROVISIONESBL.SelectCTA_OPE(FormMantDocExp.dtpfechaprov.Value.Year, txtcuenta.Text)
        'Else
        '    txtcuenta_dest.Text = ""
        'End If

        If txtcuenta.Text = "" Then
            txtcuenta_dest.Text = ""
        Else
            txtcuenta_dest.Text = PROVISIONESBL.SelectCTA_OPE(Mid(FormMantDocExp.txtmskfecprov.Text, 7, 4), txtcuenta.Text)
        End If
    End Sub

    Private Sub FormMantDetDocExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbstatus.SelectedIndex = 2 Then
            npduprecio_compra.Enabled = False
            npduprecio_dcompra.Enabled = False
            npduprecio_compra.Value = 0
            npduprecio_dcompra.Value = 0
            If FormMantDocExp.txtmoneda.Text = "01" Then
                npduprecio_afectod.Enabled = True
                npduprecio_afectos.Enabled = False
            Else
                npduprecio_afectod.Enabled = False
                npduprecio_afectos.Enabled = True
            End If
        ElseIf cmbstatus.SelectedIndex = 1 Then
            npduprecio_afectod.Enabled = False
            npduprecio_afectos.Enabled = False
            npduprecio_afectod.Value = 0
            npduprecio_afectos.Value = 0
            If FormMantDocExp.txtmoneda.Text = "01" Then
                npduprecio_compra.Enabled = False
                npduprecio_dcompra.Enabled = True
            Else
                npduprecio_compra.Enabled = True
                npduprecio_dcompra.Enabled = False
            End If
        End If
    End Sub
    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        If cmbstatus.SelectedIndex = 1 Then
            npduprecio_afectod.Enabled = False
            npduprecio_afectos.Enabled = False
            npduprecio_afectod.Value = 0
            npduprecio_afectos.Value = 0
            If FormMantDocExp.txtmoneda.Text = "01" Then
                npduprecio_compra.Enabled = False
                npduprecio_dcompra.Enabled = True
            Else
                npduprecio_compra.Enabled = True
                npduprecio_dcompra.Enabled = False
            End If
        ElseIf cmbstatus.SelectedIndex = 2 Then
            npduprecio_compra.Enabled = False
            npduprecio_dcompra.Enabled = False
            npduprecio_compra.Value = 0
            npduprecio_dcompra.Value = 0
            If FormMantDocExp.txtmoneda.Text = "01" Then
                npduprecio_afectod.Enabled = True
                npduprecio_afectos.Enabled = False
            Else
                npduprecio_afectod.Enabled = False
                npduprecio_afectos.Enabled = True
            End If
            txtigvimpor.Text = 0
            txtigv_dimpor.Text = 0
        End If

    End Sub

    Private Sub txtser_doc_ref1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtser_doc_ref1.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnro_doc_ref1.Focus()
        End If
    End Sub

    Private Sub txtnro_doc_ref1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnro_doc_ref1.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmbstatus.Focus()
        End If
    End Sub

    Private Sub cmbstatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbstatus.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtcuenta.Focus()
        End If
    End Sub

    Private Sub npdcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles npdcantidad.KeyDown
        If cmbstatus.SelectedIndex = 1 Then
            If FormMantDocExp.txtmoneda.Text = "00" Then
                If e.KeyValue = Keys.Enter Then
                    If npduprecio_compra.Value = 0 Then
                        npduprecio_compra.Text = ""
                    End If
                    npduprecio_compra.Focus()
                End If
            Else
                If e.KeyValue = Keys.Enter Then
                    If npduprecio_dcompra.Value = 0 Then
                        npduprecio_dcompra.Text = ""
                    End If
                    npduprecio_dcompra.Focus()
                End If
            End If

        ElseIf cmbstatus.SelectedIndex = 2 Then
            If FormMantDocExp.txtmoneda.Text = "00" Then
                If e.KeyValue = Keys.Enter Then
                    If npduprecio_afectos.Value = 0 Then
                        npduprecio_afectos.Text = ""
                    End If
                    npduprecio_afectos.Focus()
                End If
            End If
            If e.KeyValue = Keys.Enter Then
                If npduprecio_afectod.Value = 0 Then
                    npduprecio_afectod.Text = ""
                End If
                npduprecio_afectod.Focus()
            End If
        End If
    End Sub

    Private Sub npduprecio_compra_KeyDown(sender As Object, e As KeyEventArgs) Handles npduprecio_compra.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtigv.Focus()
        End If
    End Sub

    Private Sub npduprecio_afectos_KeyDown(sender As Object, e As KeyEventArgs) Handles npduprecio_afectos.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtigv.Focus()
        End If
    End Sub

    Private Sub npduprecio_dcompra_KeyDown(sender As Object, e As KeyEventArgs) Handles npduprecio_dcompra.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtigv.Focus()
        End If
    End Sub

    Private Sub npduprecio_afectod_KeyDown(sender As Object, e As KeyEventArgs) Handles npduprecio_afectod.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtigv.Focus()
        End If
    End Sub

    Private Sub txtigv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtigv.KeyDown
        If e.KeyValue = Keys.Enter Then
            If (dgvt_docdet.Rows.Count = gsCode5 + 1) Then
                btnagregar.Focus()
            Else
                btnregresar.Focus()
            End If
        End If
    End Sub

    Private Sub txtt_doc_ref1_Enter(sender As Object, e As EventArgs) Handles txtt_doc_ref1.Enter
        txtt_doc_ref1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtt_doc_ref1_Leave(sender As Object, e As EventArgs) Handles txtt_doc_ref1.Leave
        txtt_doc_ref1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtser_doc_ref1_Enter(sender As Object, e As EventArgs) Handles txtser_doc_ref1.Enter
        txtser_doc_ref1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtser_doc_ref1_Leave(sender As Object, e As EventArgs) Handles txtser_doc_ref1.Leave
        txtser_doc_ref1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtnro_doc_ref1_Enter(sender As Object, e As EventArgs) Handles txtnro_doc_ref1.Enter
        txtnro_doc_ref1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtnro_doc_ref1_Leave(sender As Object, e As EventArgs) Handles txtnro_doc_ref1.Leave
        txtnro_doc_ref1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub cmbstatus_Enter(sender As Object, e As EventArgs) Handles cmbstatus.Enter
        cmbstatus.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbstatus_Leave(sender As Object, e As EventArgs) Handles cmbstatus.Leave
        cmbstatus.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub txtcuenta_Enter(sender As Object, e As EventArgs) Handles txtcuenta.Enter
        txtcuenta.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtcuenta_Leave(sender As Object, e As EventArgs) Handles txtcuenta.Leave
        txtcuenta.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtcuenta_dest_Enter(sender As Object, e As EventArgs) Handles txtcuenta_dest.Enter
        txtcuenta_dest.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtcuenta_dest_Leave(sender As Object, e As EventArgs) Handles txtcuenta_dest.Leave
        txtcuenta_dest.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub cmbsigno_Enter(sender As Object, e As EventArgs) Handles cmbsigno.Enter
        cmbsigno.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbsigno_Leave(sender As Object, e As EventArgs) Handles cmbsigno.Leave
        cmbsigno.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub txtcodart_Enter(sender As Object, e As EventArgs) Handles txtcodart.Enter
        txtcodart.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtcodart_Leave(sender As Object, e As EventArgs) Handles txtcodart.Leave
        txtcodart.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub npdcantidad_Enter(sender As Object, e As EventArgs) Handles npdcantidad.Enter
        npdcantidad.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub npdcantidad_Leave(sender As Object, e As EventArgs) Handles npdcantidad.Leave
        npdcantidad.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub npduprecio_afectod_Enter(sender As Object, e As EventArgs) Handles npduprecio_afectod.Enter
        npduprecio_afectod.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub npduprecio_afectod_Leave(sender As Object, e As EventArgs) Handles npduprecio_afectod.Leave
        npduprecio_afectod.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub npduprecio_afectos_Enter(sender As Object, e As EventArgs) Handles npduprecio_afectos.Enter
        npduprecio_afectos.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub npduprecio_afectos_Leave(sender As Object, e As EventArgs) Handles npduprecio_afectos.Leave
        npduprecio_afectos.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub npduprecio_compra_Enter(sender As Object, e As EventArgs) Handles npduprecio_compra.Enter
        npduprecio_compra.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub npduprecio_compra_Leave(sender As Object, e As EventArgs) Handles npduprecio_compra.Leave
        npduprecio_compra.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtigv_Enter(sender As Object, e As EventArgs) Handles txtigv.Enter
        txtigv.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtigv_Leave(sender As Object, e As EventArgs) Handles txtigv.Leave
        txtigv.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub cmbsigno_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbsigno.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtcodart.Focus()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub txtnro_doc_ref1_LostFocus(sender As Object, e As EventArgs) Handles txtnro_doc_ref1.LostFocus
        'If 
    End Sub
    Private Sub cmbsguia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsguia.SelectedIndexChanged
        If cmbsguia.Text = "002" Then
            'txtnguia.TextLength = 10
            txtnguia.MaxLength = 10
        Else
            txtnguia.MaxLength = 8
        End If
    End Sub

    Private Sub txtcco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "101"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                btnagregar.Enabled = True
                txtcco_cod.Text = gLinea
                txtcco_nom.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "101" ' "245"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            btnagregar.Enabled = True
            txtcco_cod.Text = gLinea
            txtcco_nom.Text = gSubLinea
            gsCode7 = gLinea
            gLinea = ""
            gSubLinea = ""
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
End Class