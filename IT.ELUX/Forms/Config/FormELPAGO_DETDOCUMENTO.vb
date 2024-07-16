Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Math
Public Class FormELPAGO_DETDOCUMENTO

    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private CUENTABANCOBL As New CUENTABANCOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELPAGO_DET_DOCUMENTOBE As New ELPAGO_DET_DOCUMENTOBE
    Private ELTBTIPOCAMBIOBL As New ELTBTIPOCAMBIOBL

    Private Sub ELPAGO_DETDOCUMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsUser = "SGARCIA" Or gsUser = "CHOYOS" Or gsUser = "DBERNAL" Then
            txt_actFlujo.Text = "1"
            txt_flujo.Text = "ACTIVIDADES DE OPERACION"
            txt_ActCaja.Text = "01"
            txt_caja.Text = "VENTA DE BIENES"
        End If
        If flagAccion1 = "N" Then
            dtpcom_fech.Value = fecGenPago
            btnAgregar.Text = "Agregar"
            Limpiar()
            'Deshabilitar(True)
        Else
            btnAgregar.Text = "Actualizar"
            'GetData(sTDoc, sSDoc, sNDoc)
            'Deshabilitar(False)
        End If
        txtt_doc_LostFocus(sender, e)
        'lbltcambio.Text = tcOperacion

        Dim dtUsuario As DataTable
        Dim dtDolares As New DataTable

        If flagAccion1 = "M" Then

        Else
            dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(dtpcom_fech.Value.ToString("dd/MM/yyyy"))
            If dtUsuario.Rows.Count > 0 Then
                For Each Registro In dtUsuario.Rows
                    If opePagoCob = "010" Then
                        lbltcambio.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
                    Else
                        lbltcambio.Text = IIf(IsDBNull(Registro("COMPRA")), "0", Registro("COMPRA"))
                    End If

                Next
            Else
                lbltcambio.Text = 0
            End If
        End If
    End Sub
    Private Sub Limpiar()
        'txtserie.Text = DateTime.Now.Year  
        cmbafecto.SelectedIndex = 0
        txtdolar.Text = 0.00
        txtsoles.Text = 0.00

        Dim dtUsuario As DataTable
        dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(DateTime.Now.ToString("dd/MM/yyyy"))
        If dtUsuario.Rows.Count > 0 Then
            For Each Registro In dtUsuario.Rows
                lbltcambio.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
            Next
        Else
            MsgBox("No hay Tipo de Cambio para este dia", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If OkData() = False Then
            Exit Sub
        Else
            If flagAccion1 = "N" Then
                Dim cco_Cod
                If txt_ccocod.Text = "" Then
                    cco_Cod = ""
                Else
                    cco_Cod = txt_ccocod.Text & "-" & txt_nomcco.Text
                End If

                FormELPAGO_DOCUMENTO.dgvt_doc.Rows.Add(txtt_doc.Text, txtserie.Text, txtnumero.Text,
                         cmbafecto.SelectedItem, txtcuenta.Text, lbldestino.Text, txt_codproveedor.Text, txt_proveedor.Text,
                         lblsigno.Text, dtpcom_fech.Value.ToString("dd/MM/yyyy"), lbltcambio.Text, txtmon.Text, lblmon.Text, txtsoles.Text,
                         txtdolar.Text, "", txt_actFlujo.Text, txt_flujo.Text, txt_ActCaja.Text, txt_caja.Text, chkReparar.Checked, "", cco_Cod) 'txt_ccocod.Text & "-" & txt_nomcco.Text)
                FormELPAGO_DOCUMENTO.txtRegistros.Text = FormELPAGO_DOCUMENTO.dgvt_doc.Rows.Count
                MsgBox("Registro agregado al detalle", MsgBoxStyle.Information)
            Else
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("T_DOC_REF").Value = txtt_doc.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("SERIE_DOC_REF").Value = txtserie.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("NRO_DOC").Value = txtnumero.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("AFECTO").Value = cmbafecto.SelectedItem
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("CUENTA").Value = txtcuenta.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("CTA_DES").Value = lbldestino.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("FECHA").Value = dtpcom_fech.Value.ToString("dd/MM/yyyy")
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("T_cambio").Value = lbltcambio.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("Mon").Value = txtmon.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("Moneda").Value = lblmon.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("T_Soles").Value = txtsoles.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("T_dolares").Value = txtdolar.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("signo").Value = lblsigno.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("Codigo").Value = txt_codproveedor.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("Proveedor").Value = txt_proveedor.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("CODFLUJO").Value = txt_actFlujo.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells(17).Value = txt_flujo.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("CODCAJA").Value = txt_ActCaja.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells(19).Value = txt_caja.Text

                If txt_ccocod.Text = "" Then
                    FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells(22).Value = ""
                Else
                    FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells(22).Value = txt_ccocod.Text & "-" & txt_nomcco.Text
                End If

                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF").Value = txtt_doc.Text
                dgvt_docdet.Rows(gsCode5).Cells("SERIE_DOC_REF").Value = txtserie.Text
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC").Value = txtnumero.Text
                dgvt_docdet.Rows(gsCode5).Cells("AFECTO").Value = cmbafecto.SelectedItem
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA2").Value = txtcuenta.Text
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DES").Value = lbldestino.Text
                dgvt_docdet.Rows(gsCode5).Cells("FECHA").Value = dtpcom_fech.Value.ToString("dd/MM/yyyy")
                dgvt_docdet.Rows(gsCode5).Cells("T_cambio").Value = lbltcambio.Text
                dgvt_docdet.Rows(gsCode5).Cells("Mon").Value = txtmon.Text
                dgvt_docdet.Rows(gsCode5).Cells("Moneda").Value = lblmon.Text
                dgvt_docdet.Rows(gsCode5).Cells("T_Soles").Value = txtsoles.Text
                dgvt_docdet.Rows(gsCode5).Cells("T_dolares").Value = txtdolar.Text
                dgvt_docdet.Rows(gsCode5).Cells("signo").Value = lblsigno.Text
                dgvt_docdet.Rows(gsCode5).Cells("Codigo").Value = txt_codproveedor.Text
                dgvt_docdet.Rows(gsCode5).Cells("Proveedor").Value = txt_proveedor.Text


                MsgBox("Registro actualizado en el detalle", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Function OkData() As Boolean

        If txtt_doc.Text = "" Then
            MsgBox("Ingrese el Tipo de Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If

        If txtserie.Text = "" Then
            MsgBox("Ingrese la Serie de Documento", MsgBoxStyle.Exclamation)
            txtserie.Focus()
            Return False
        End If

        If txtnumero.Text = "" Then
            MsgBox("Ingrese el Nro. de Documento", MsgBoxStyle.Exclamation)
            txtnumero.Focus()
            Return False
        End If

        If txtmon.Text = "" Then
            MsgBox("Ingrese la moneda", MsgBoxStyle.Exclamation)
            txtmon.Focus()
            Return False
        End If
        If txtcuenta.Text = "" Then
            MsgBox("Ingrese la Cuenta", MsgBoxStyle.Exclamation)
            txtcuenta.Focus()
            Return False
        End If

        Select Case txtcuenta.Text.Substring(0, 2)
            Case "62", "63", "64", "65", "68"
                If txt_ccocod.Text = "" Then
                    MsgBox("Ingrese Centro De Costo", MsgBoxStyle.Exclamation)
                    txt_ccocod.Focus()
                    Return False
                End If
        End Select
        If btnAgregar.Text = "Agregar" Then
            For i = 0 To FormELPAGO_DOCUMENTO.dgvt_doc.Rows.Count - 1
                If (FormELPAGO_DOCUMENTO.dgvt_doc.Rows(i).Cells("T_DOC_REF").Value = txtt_doc.Text And
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(i).Cells("SERIE_DOC_REF").Value = txtserie.Text And
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(i).Cells("NRO_DOC").Value = txtnumero.Text) Then

                    MsgBox("Ya se agregó este tipo , serie y numero", MsgBoxStyle.Exclamation)
                    Exit Function
                End If
            Next
        End If

        Return True
#Disable Warning BC42353 ' La función 'OkData' no devuelve un valor en todas las rutas de acceso de código. ¿Falta alguna instrucción 'Return'?
    End Function
#Enable Warning BC42353 ' La función 'OkData' no devuelve un valor en todas las rutas de acceso de código. ¿Falta alguna instrucción 'Return'?

    Private Sub txtnumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumero.KeyDown

        'Dim i As Integer = dgvt_docdet.Rows.Count

        'If e.KeyValue = Keys.Down Then
        '    If CInt(gsCode5) + 1 = i Then
        '        'gsCode5 = CInt(gsCode5)
        '    Else
        '        gsCode5 = CInt(gsCode5) + 1
        '    End If
        '    e.Handled = True
        'End If

        'If e.KeyValue = Keys.Up Then
        '    If CInt(gsCode5) - 1 = -1 Then
        '        'gsCode5 = CInt(gsCode5)
        '    Else
        '        gsCode5 = CInt(gsCode5) - 1
        '    End If
        '    e.Handled = True
        'End If

        'If dgvt_docdet.Rows.Count > 0 Then
        '    txtt_doc.Text = dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF").Value
        '    txtserie.Text = dgvt_docdet.Rows(gsCode5).Cells("SERIE_DOC_REF").Value
        '    txtnumero.Text = dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC").Value
        '    'If dgvt_docdet.Rows(gsCode5).Cells("FECHA").Value <> "" Then
        '    '    dtpf_gene.Value = dgvt_docdet.Rows(gsCode5).Cells("FECHA").Value
        '    'End If
        '    cmbafecto.SelectedItem = dgvt_docdet.Rows(gsCode5).Cells("afecto").Value
        '    txtcuenta.Text = dgvt_docdet.Rows(gsCode5).Cells("Cuenta2").Value
        '    lbldestino.Text = dgvt_docdet.Rows(gsCode5).Cells("cta_des").Value
        '    lbltcambio.Text = dgvt_docdet.Rows(gsCode5).Cells("T_cambio").Value
        '    txtmon.Text = dgvt_docdet.Rows(gsCode5).Cells("Mon").Value
        '    lblmon.Text = dgvt_docdet.Rows(gsCode5).Cells("Moneda").Value
        '    txtsoles.Text = dgvt_docdet.Rows(gsCode5).Cells("T_Soles").Value
        '    txtdolar.Text = dgvt_docdet.Rows(gsCode5).Cells("T_dolares").Value
        '    lblsigno.Text = dgvt_docdet.Rows(gsCode5).Cells("Signo").Value
        '    txtt_doc_LostFocus(sender, e)
        'End If

        If e.KeyValue = Keys.Enter Then
            txt_codproveedor.Select()
        End If
    End Sub
    Private Sub txtt_doc_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc.LostFocus
        If (txtt_doc.Text = "") Then
            lblt_doc.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectTipodocCOD(txtt_doc.Text)
            If dt.Rows.Count > 0 Then
                txtt_doc.Text = dt.Rows(0).Item(0).ToString
                lblt_doc.Text = dt.Rows(0).Item(1).ToString
            Else
                txtt_doc.Text = ""
                lblt_doc.Text = ""
            End If
        End If
    End Sub

    Private Sub txtt_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_doc.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "96"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtt_doc.Text = gLinea
                lblt_doc.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
        If e.KeyValue = Keys.Enter Then
            txtserie.Select()
        End If
    End Sub

    Private Sub txtcuenta_LostFocus(sender As Object, e As EventArgs) Handles txtcuenta.LostFocus
        If (txtcuenta.Text = "") Then
            lbldestino.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectCuentaCOD(txtcuenta.Text)
            If dt.Rows.Count > 0 Then
                txtcuenta.Text = dt.Rows(0).Item(0).ToString
                lbldestino.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcuenta.Text = ""
                lbldestino.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "111"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcuenta.Text = gLinea
                lbldestino.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""

        If e.KeyValue = Keys.Enter Then
            dtpcom_fech.Select()
        End If
    End Sub

    Private Sub txtmon_LostFocus(sender As Object, e As EventArgs) Handles txtmon.LostFocus
        If (txtmon.Text = "") Then
            lblmon.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectMonCOD(txtmon.Text)
            If dt.Rows.Count > 0 Then
                txtmon.Text = dt.Rows(0).Item(0).ToString
                lblmon.Text = dt.Rows(0).Item(1).ToString
                If txtmon.Text = "00" Then
                    txtsoles.Enabled = True
                    txtdolar.Enabled = False
                    txtsoles.Focus()
                Else
                    txtsoles.Enabled = False
                    txtdolar.Enabled = True
                    txtdolar.Focus()
                End If
            Else
                txtmon.Text = ""
                lblmon.Text = ""
            End If
        End If
    End Sub

    Private Sub txtmoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmon.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "97"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtmon.Text = gLinea
                lblmon.Text = gSubLinea
            End If
            e.Handled = True
        End If
        If txtmon.Text = "00" Then
            txtsoles.Enabled = True
            txtdolar.Enabled = False
        Else
            txtsoles.Enabled = False
            txtdolar.Enabled = True

        End If
        gLinea = ""
        gSubLinea = ""
        If e.KeyValue = Keys.Enter Then
            If txtmon.Text = "00" Then
                txtsoles.Select()
            ElseIf txtmon.Text = "01" Then
                txtdolar.Select()
            End If
        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub dtpcom_fech_ValueChanged(sender As Object, e As EventArgs) Handles dtpcom_fech.ValueChanged
        Dim dtUsuario As DataTable
        Dim dtDolares As New DataTable
        dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(dtpcom_fech.Value.ToString("dd/MM/yyyy"))
        If dtUsuario.Rows.Count > 0 Then
            For Each Registro In dtUsuario.Rows
                If opePagoCob = "010" Then
                    lbltcambio.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
                Else
                    lbltcambio.Text = IIf(IsDBNull(Registro("COMPRA")), "0", Registro("COMPRA"))
                End If

            Next
        Else
            lbltcambio.Text = 0
        End If
    End Sub

    Private Sub txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnumero.Select()
        End If
    End Sub

    Private Sub txtsoles_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsoles.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim dtDolares As New DataTable
            'If txtsoles.Text <> Label13.Text Then
            dtDolares = ELTBTIPOCAMBIOBL.CalcularDolares("SOL", txtsoles.Text, lbltcambio.Text)
            If dtDolares.Rows.Count > 0 Then
                txtdolar.Text = dtDolares.Rows(0).Item(0)
            End If
            ' End If
            lblsigno.Select()
            'Dim cambio As Double = Val(txtdolar.Text) * Val(lbltcambio.Text)
            ''.Text = Math.Round((Val(txtdolar.Text) * Val(lbltcambio.Text)), 2)
            'txtsoles.Text = Math.Ceiling(cambio * 100D) / 100D

        End If
    End Sub


    Private Sub txtdolar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdolar.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim dtDolares As New DataTable
            If Label13.Text = "1" Then
                If Label14.Text <> Label13.Text Then
                    dtDolares = ELTBTIPOCAMBIOBL.CalcularDolares("DOL", txtdolar.Text, lbltcambio.Text)
                    If dtDolares.Rows.Count > 0 Then
                        txtsoles.Text = dtDolares.Rows(0).Item(0)
                    End If
                End If
            Else
                dtDolares = ELTBTIPOCAMBIOBL.CalcularDolares("DOL", txtdolar.Text, lbltcambio.Text)
                If dtDolares.Rows.Count > 0 Then
                    txtsoles.Text = dtDolares.Rows(0).Item(0)
                End If
            End If
            lblsigno.Select()
            'Dim cambio As Double = Val(txtdolar.Text) * Val(lbltcambio.Text)
            ''.Text = Math.Round((Val(txtdolar.Text) * Val(lbltcambio.Text)), 2)
            'txtsoles.Text = Math.Ceiling(cambio * 100D) / 100D
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codproveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            If tipOperacion = "010" Then
                sBusAlm = "98"
            Else
                sBusAlm = "98-C"
            End If

            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_codproveedor.Text = gLinea
                txt_proveedor.Text = gSubLinea
                txtcuenta.Select()
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""

        If e.KeyValue = Keys.Enter Then
            txtcuenta.Select()
        End If
    End Sub

    Private Sub dtpcom_fech_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpcom_fech.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim dtUsuario As DataTable
            Dim dtDolares As New DataTable
            dtUsuario = ELTBTIPOCAMBIOBL.SelectRow(dtpcom_fech.Value.ToString("dd/MM/yyyy"))
            If dtUsuario.Rows.Count > 0 Then
                For Each Registro In dtUsuario.Rows
                    If opePagoCob = "010" Then
                        lbltcambio.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
                    Else
                        lbltcambio.Text = IIf(IsDBNull(Registro("COMPRA")), "0", Registro("COMPRA"))
                    End If

                Next
            Else
                lbltcambio.Text = 0
            End If
        End If
    End Sub

    Private Sub lbltcambio_KeyDown(sender As Object, e As KeyEventArgs) Handles lbltcambio.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtmon.Select()
        End If
    End Sub

    Private Sub lblsigno_KeyDown(sender As Object, e As KeyEventArgs) Handles lblsigno.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub txt_actFlujo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_actFlujo.KeyDown

        If e.KeyValue = Keys.F9 Then
            sBusAlm = "ACTFLUJO"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing And gSubLinea <> Nothing) Then
                txt_actFlujo.Text = gLinea
                txt_flujo.Text = gSubLinea
                txt_ActCaja.Text = ""
                txt_caja.Text = ""
                txt_ActCaja.Select()
            End If
        End If


        If e.KeyValue = Keys.Enter Then
            Dim dtActFlujo As New DataTable
            dtActFlujo = ELDOCUMENTOBL.BuscarActFlujo(txt_actFlujo.Text)
            If dtActFlujo.Rows.Count > 0 Then
                txt_flujo.Text = dtActFlujo.Rows(0).ItemArray(0)
                gLinea = txt_flujo.Text
                txt_ActCaja.Text = ""
                txt_caja.Text = ""
                txt_ActCaja.Select()
            Else
                MsgBox("Verificar Cod. Act. Flujo ")
                txt_ActCaja.Text = ""
                txt_caja.Text = ""
                txt_actFlujo.Text = ""
                txt_flujo.Text = ""
                txt_actFlujo.Select()
            End If
        End If
    End Sub

    Private Sub txt_ActCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ActCaja.KeyDown
        gSubLinea = opePagoCob
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "ACTFLUJOCAJA"
            gLinea = txt_actFlujo.Text
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing And gSubLinea <> Nothing) Then
                txt_ActCaja.Text = gLinea
                txt_caja.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

        If e.KeyValue = Keys.Enter Then
            Dim dtActFlujo As New DataTable
            dtActFlujo = ELDOCUMENTOBL.BuscarActFlujoCaja(txt_actFlujo.Text, txt_ActCaja.Text, gSubLinea)
            If dtActFlujo.Rows.Count > 0 Then
                txt_ActCaja.Text = dtActFlujo.Rows(0).ItemArray(0)
                txt_caja.Text = dtActFlujo.Rows(0).ItemArray(1)
            Else
                MsgBox("Verificar Cod. Act. Flujo ")
                txt_ActCaja.Text = ""
                txt_caja.Text = ""
                txt_ActCaja.Select()
            End If
        End If
    End Sub

    Private Sub lbltcambio_TextChanged(sender As Object, e As EventArgs) Handles lbltcambio.TextChanged
        Dim dtDolares As New DataTable
        If txtmon.Text <> "" And txtsoles.Text <> "" And txtdolar.Text <> "" Then
            If txtmon.Text = "00" Then
                dtDolares = ELTBTIPOCAMBIOBL.CalcularDolares("SOL", txtsoles.Text, lbltcambio.Text)
                If dtDolares.Rows.Count > 0 Then
                    txtdolar.Text = dtDolares.Rows(0).Item(0)
                End If
                ' End If

            Else
                dtDolares = ELTBTIPOCAMBIOBL.CalcularDolares("DOL", txtdolar.Text, lbltcambio.Text)
                If dtDolares.Rows.Count > 0 Then
                    txtsoles.Text = dtDolares.Rows(0).Item(0)
                End If
                ' End If

            End If

        End If
    End Sub

    Private Sub txt_ccocod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ccocod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "CCO_COD"
            gLinea = txt_actFlujo.Text
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing And gSubLinea <> Nothing) Then
                txt_ccocod.Text = gLinea
                txt_nomcco.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtcuenta_TextChanged(sender As Object, e As EventArgs) Handles txtcuenta.TextChanged

    End Sub

    Private Sub txtcuenta_Leave(sender As Object, e As EventArgs) Handles txtcuenta.Leave
        If Len(txtcuenta.Text) > 0 Then
            Dim cta = txtcuenta.Text.Substring(0, 2)
            If cta = "67" Then
                txt_ccocod.Text = "306"
                txt_nomcco.Text = "FINANZAS"
            End If
        Else
            txt_ccocod.Text = ""
            txt_nomcco.Text = ""
        End If
    End Sub

    Private Sub txt_ccocod_Leave(sender As Object, e As EventArgs) Handles txt_ccocod.Leave
        If Len(txt_ccocod.Text) = 0 Then
            txt_nomcco.Text = ""
        End If
    End Sub
End Class