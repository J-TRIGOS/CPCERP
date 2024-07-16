Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetRequerimiento
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Public bFecha As Date
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
    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormMantDetRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As New DataTable
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbuni)
        If bFecha >= Format(CDate("2020/12/21"), "yyyy/MM/dd") Then
            txtarticulo.Visible = True
            If txtactivo.TextLength > 0 Then
                txtarticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            End If
            cmbactivo.Visible = False
        Else
            cmbactivo.Visible = True
            dt = ARTICULOBL.SelectAct()
            GetCmb("COD", "NOM_ACT", dt, cmbactivo)
        End If
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
            If bFecha.ToString("dd-MM-yyyy") >= "21-12-2020" Then
                txtarticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            End If

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

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If cmbuni.SelectedIndex = -1 Then
            MsgBox("Ingrese la unidad de medida")
            Exit Sub
        End If
        If gContador = 1 Then

            '    gContador = 0
            If npdcantidad.Value > 0 Then
                Dim sValor As String

                Dim i As Integer
                Dim icontador As Integer
                If gContador = 1 Then
                    gContador = 0
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                    If FormMantRequerimiento.dgvt_doc.Rows.Count > 0 Then
                        For i = 0 To FormMantRequerimiento.dgvt_doc.Rows.Count - 1
                            If FormMantRequerimiento.dgvt_doc.Rows(i).Cells(8).Value = cmbart.SelectedValue Then
                                icontador = icontador + 1
                            End If
                        Next
                    End If
                    If icontador > 0 Then
                        FormMantRequerimiento.dgvt_doc.Rows.Add(FormMantRequerimiento.txtt_doc.Text, '0
                                                              FormMantRequerimiento.cmb_serdoc.Text,'1
                                                              FormMantRequerimiento.txtnumero.Text, '2
                                                              FormMantRequerimiento.txtt_doc.Text, '3
                                                              FormMantRequerimiento.cmb_serdoc.Text,'4
                                                              FormMantRequerimiento.txtnumero.Text & "-" & icontador, '5
                                                              FormMantRequerimiento.txtproveedor.Text,'6 
                                                              npdcantidad.Value, '7
                                                              cmbart.SelectedValue,'8
                                                              sValor, '9
                                                              Nothing, '10
                                                              "401M00",'11
                                                              "", "", "", "+", txtobservacion.Text, '16
                                                              FormMantRequerimiento.txtt_movinv.Text, '17
                                                              txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                              txtigv.Text, txtigvimpor.Text, npdtcamb.Value,'22
                                                              npduprecio_compra.Value,'23
                                                              npduprecio_dcompra.Value,'24
                                                              txtigv_dimpor.Text, FormMantRequerimiento.txtmon.Text,  '26
                                                              FormMantRequerimiento.dtpfecha.Text, '27
                                                              gsUser, '28
                                                              cmbuni.SelectedValue, '29
                                                              FormMantRequerimiento.txtt_pago.Text, '30
                                                              FormMantRequerimiento.txtfor_ent.Text,'31
                                                              RTrim(DateTime.Now), "20100279348", '33
                                                              FormMantRequerimiento.txtc_costo.Text, "", '35
                                                              txtlote.Text, FormMantRequerimiento.txtdni.Text, '37
                                                              "0", txtmarca.Text, txtdscto.Text, txtdscto_impor.Text, '41 
                                                              txtdscto_dimpor.Text,'42
                                                              FormMantRequerimiento.cmbestado.Text) '43
                        Dispose()
                    Else
                        FormMantRequerimiento.dgvt_doc.Rows.Add(FormMantRequerimiento.txtt_doc.Text, '0
                                                                  FormMantRequerimiento.cmb_serdoc.Text,'1
                                                                  FormMantRequerimiento.txtnumero.Text, '2
                                                                  FormMantRequerimiento.txtt_doc.Text, '3
                                                                  FormMantRequerimiento.cmb_serdoc.Text,'4
                                                                  FormMantRequerimiento.txtnumero.Text, '5
                                                                  FormMantRequerimiento.txtproveedor.Text,'6 
                                                                  npdcantidad.Value, '7
                                                                  cmbart.SelectedValue,'8
                                                                  sValor, '9
                                                                  Nothing, '10
                                                                  "",'11
                                                                  "", "", "", "+", txtobservacion.Text, '16
                                                                  FormMantRequerimiento.txtt_movinv.Text, '17
                                                                  txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                  txtigv.Text, txtigvimpor.Text, npdtcamb.Value,'22
                                                                  npduprecio_compra.Value,'23
                                                                  npduprecio_dcompra.Value,'24
                                                                  txtigv_dimpor.Text, FormMantRequerimiento.txtmon.Text,  '26
                                                                  FormMantRequerimiento.dtpfecha.Text, '27
                                                                  gsUser, '28
                                                                  cmbuni.SelectedValue, '29
                                                                  FormMantRequerimiento.txtt_pago.Text, '30
                                                                  FormMantRequerimiento.txtfor_ent.Text,'31
                                                                  RTrim(DateTime.Now), "20100279348", '33
                                                                  FormMantRequerimiento.txtc_costo.Text, "", '35
                                                                  txtlote.Text, FormMantRequerimiento.txtdni.Text, '37
                                                                  "0", txtmarca.Text, txtdscto.Text, txtdscto_impor.Text, '41 
                                                                  txtdscto_dimpor.Text,'42
                                                                  FormMantRequerimiento.cmbestado.Text) '43
                        Dispose()
                    End If
                End If
            Else
                MsgBox("Favor Ingrese la cantidad a declarar")
            End If
        ElseIf gContador = 0 Then
            If FormMantRequerimiento.txtmon.Text = "01" Then
                txttcomprad.Text = (npduprecio_dcompra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_dcompra.Text * npdcantidad.Text
                txttcompras.Text = (npduprecio_dcompra.Text * npdcantidad.Text * npdtcamb.Text) * (txtigv.Text / 100) + npduprecio_dcompra.Text * npdcantidad.Text * npdtcamb.Text
                txttprecio_compra.Text = npduprecio_dcompra.Text * npdcantidad.Text * npdtcamb.Text
                txttprecio_dcompra.Text = npduprecio_dcompra.Text * npdcantidad.Text
                txtigvimpor.Text = txttcompras.Text - txttprecio_compra.Text
                txtigv_dimpor.Text = txttcomprad.Text - txttprecio_dcompra.Text
                'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
            Else
                npduprecio_dcompra.Value = npduprecio_compra.Value / npdtcamb.Value
                txttcompras.Text = (npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text
                txttcomprad.Text = ((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text
                txttprecio_compra.Text = npduprecio_compra.Text * npdcantidad.Text
                txttprecio_dcompra.Text = (npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text
                txtigvimpor.Text = txttcompras.Text - txttprecio_compra.Text
                txtigv_dimpor.Text = txttcomprad.Text - txttprecio_dcompra.Text
                'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
            End If
            Dim sValor As String
            sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(7).Value = npdcantidad.Value '7
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = sValor
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(8).Value = cmbart.SelectedValue
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(16).Value = txtobservacion.Text '16
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(18).Value = txttprecio_compra.Text
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(19).Value = txttprecio_dcompra.Text '19
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(20).Value = txtigv.Text
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(21).Value = txtigvimpor.Text
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(25).Value = txtigv_dimpor.Text
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(22).Value = npdtcamb.Value
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(23).Value = npduprecio_compra.Value '23
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(24).Value = npduprecio_dcompra.Value '24
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(29).Value = cmbuni.SelectedValue '29
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(36).Value = txtlote.Text
            FormMantRequerimiento.dgvt_doc.Rows(FormMantRequerimiento.dgvt_doc.CurrentRow.Index).Cells(39).Value = txtmarca.Text

            Dispose()
        End If
    End Sub

    'Private Sub txtart_codigo_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyValue = Keys.F9 Then
    '        FuncKeysModule(e.KeyValue)
    '        e.Handled = True
    '    End If
    'End Sub
    'Public Sub FuncKeysModule(ByVal value As Keys)
    '    Dim frm As New FormBUSQUEDA
    '    Select Case value

    '        Case Keys.F9
    '            'Add the code for the function key F9 here.
    '            sBusqueda = "1"
    '            frm.ShowDialog()
    '        Case Keys.F10
    '            'Add the code for the function key F10 here.
    '            MessageBox.Show("F10 pressed")

    '    End Select
    'End Sub

    Private Sub FormMantDetRequerimiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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

        cmbart.SelectedValue = txtcodart.Text
        gsCode = gsCode
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
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
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


    Private Sub npduprecio_compra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_compra.LostFocus
        'If gContador <> 0 Then
        If FormMantRequerimiento.txtmon.Text = "07" Then
            If npdcantidad.Value > 0 And npduprecio_compra.Value > 0 Then
                npduprecio_dcompra.Value = npduprecio_compra.Value / npdtcamb.Value
                txttcompras.Text = (npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text
                txttcomprad.Text = ((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text
                txttprecio_compra.Text = npduprecio_compra.Text * npdcantidad.Text
                txttprecio_dcompra.Text = npduprecio_dcompra.Text * npdcantidad.Text
                txtigvimpor.Text = txttcompras.Text - txttprecio_compra.Text
                txtigv_dimpor.Text = txttcomprad.Text - txttprecio_dcompra.Text
                'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
            Else
                txttcompras.Text = 0
                txttcomprad.Text = 0
                txttprecio_compra.Text = 0
                txttprecio_dcompra.Text = 0
                txtigvimpor.Text = 0
                txtigv_dimpor.Text = 0
            End If
        End If

        'End If
    End Sub


    Private Sub npduprecio_dcompra_LostFocus(sender As Object, e As EventArgs) Handles npduprecio_dcompra.LostFocus
        'If gContador <> 0 Then
        If FormMantRequerimiento.txtmon.Text = "01" Then
            npduprecio_compra.Value = npduprecio_dcompra.Value * npdtcamb.Value
            If npdcantidad.Value > 0 And npduprecio_dcompra.Value > 0 Then
                txttcompras.Text = (npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text
                txttcomprad.Text = ((npduprecio_compra.Text * npdcantidad.Text) * (txtigv.Text / 100) + npduprecio_compra.Text * npdcantidad.Text) / npdtcamb.Text
                txttprecio_compra.Text = npduprecio_compra.Text * npdcantidad.Text
                txttprecio_dcompra.Text = npduprecio_dcompra.Text * npdcantidad.Text
                txtigvimpor.Text = txttcompras.Text - txttprecio_compra.Text
                txtigv_dimpor.Text = txttcomprad.Text - txttprecio_dcompra.Text
                'txttcomprad.Text = Format(CType(txttcomprad.Text, Decimal), "###,##0.00")
                'txttcompras.Text = Format(CType(txttcompras.Text, Decimal), "###,##0.00")
                'txtigv_dimpor.Text = Format(CType(txtigv_dimpor.Text, Decimal), "###,##0.00")
                'txtigvimpor.Text = Format(CType(txtigvimpor.Text, Decimal), "###,##0.00")
            Else
                txttcompras.Text = 0
                txttcomprad.Text = 0
                txttprecio_compra.Text = 0
                txttprecio_dcompra.Text = 0
                txtigvimpor.Text = 0
                txtigv_dimpor.Text = 0
            End If
        End If
        'End If
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

    Private Sub txtactivo_LostFocus(sender As Object, e As EventArgs) Handles txtactivo.LostFocus
        If txtactivo.Text = "" Then
            cmbactivo.SelectedValue = ""
            Exit Sub
        End If
        If bFecha.ToString("yyyy-MM-dd") >= "2020-12-21" Then
            txtarticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            If txtarticulo.Text = Nothing Then
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
    Private Sub btnbusact_Click(sender As Object, e As EventArgs) Handles btnbusact.Click
        If bFecha >= Format(CDate("21/12/2020"), "dd/MM/yyyy") Then
            If txtarticulo.Visible = True Then
                sBusAlm = "120"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gArt <> Nothing And gSubLinea <> Nothing Then
                    txtactivo.Text = gArt
                    txtarticulo.Text = gSubLinea
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
        If bFecha >= Format(CDate("21/12/2020"), "dd/MM/yyyy") Then
            If txtactivo.Text = "" Then
                txtarticulo.Text = ""
            Else
                txtarticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            End If
        End If
    End Sub

End Class