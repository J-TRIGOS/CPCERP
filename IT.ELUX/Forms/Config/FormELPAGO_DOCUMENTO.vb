Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELPAGO_DOCUMENTO
    Dim gpCaption As String
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private CUENTABANCOBL As New CUENTABANCOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELPAGO_DET_DOCUMENTOBE As New ELPAGO_DET_DOCUMENTOBE
    Private CONTABILIDADBL As New CONTABILIDADBL
    Dim regCont
    Dim reg_anterior As String = ""
    Dim MOV_CTBE As New MOV_CTBE
    Dim CTACOD = ""
    Dim reporte = 0
    Private Sub ELPAGO_DOCUMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmon.Enabled = False
        estadoTC = 0
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                dtpf_gene.Value = Today
                cmbcobranza.SelectedIndex = 0
                reporte = 0
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"

                GetData(sTDoc, sSDoc, sNDoc, sCos)
                If txtcbco_cod.Text = "3" And Mid(txtregcontable.Text, 5, 2) = "11" Then
                    'MsgBox(Mid(txtregcontable.Text, 5, 2))
                    'mid(txtregcontable.Text, 3, 2) = "11"
                    reg_anterior = txtregcontable.Text
                    txtregcontable.Text = obtenerRegConta()
                End If
                reporte = 1
                Deshabilitar(False)
                txtnumero.ReadOnly = True
        End Select
        txtreten.Text = 0
        txtporcentaje.Text = 0
        If dgvt_doc.Rows.Count > 0 Then
            txtRegistros.Text = dgvt_doc.Rows.Count
        End If
    End Sub
    Sub Deshabilitar(ByVal F As Boolean)
        cmbt_ope.Enabled = F
        txtt_doc.Enabled = F
        txtserie.Enabled = F
        'txtnumero.Enabled = F
        txtproveedor.Enabled = F
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
            Case "anular"
                deleteData()
                Exit Sub
            Case "Print"
                ImprimirRegistroContable()
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub

    Private Sub SaveData()


        If OkData() = False Then
            'If True = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim sumSoles = 0.00
                Dim sumDolares = 0.00
                Dim signo = 0

                If cmbt_ope.SelectedItem.ToString.Substring(0, 3) = "010" Then
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                            signo = 1
                        Else
                            signo = -1
                        End If
                        sumSoles = sumSoles + dgvt_doc.Rows(i).Cells("T_Soles").Value * signo
                        sumDolares = sumDolares + dgvt_doc.Rows(i).Cells("T_Dolares").Value * signo
                    Next
                    lblSoles.Text = sumSoles
                    lbldolares.Text = Format(sumDolares, "#.#0")
                Else
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                            signo = -1
                        Else
                            signo = +1
                        End If
                        sumSoles = sumSoles + dgvt_doc.Rows(i).Cells("T_Soles").Value * signo
                        sumDolares = sumDolares + dgvt_doc.Rows(i).Cells("T_Dolares").Value * signo
                    Next
                    lblSoles.Text = sumSoles
                    lbldolares.Text = Format(sumDolares, "#.#0")
                End If

                Dim ELPAGO_DOCUMENTOBE As New ELPAGO_DOCUMENTOBE
                Dim dtCtaBco As New DataTable

                ELPAGO_DOCUMENTOBE.t_ope = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
                ELPAGO_DOCUMENTOBE.t_doc_ref = txtt_doc.Text
                ELPAGO_DOCUMENTOBE.ser_doc_ref = txtserie.Text
                ELPAGO_DOCUMENTOBE.nro_doc_ref = txtnumero.Text
                ELPAGO_DOCUMENTOBE.fec_gene = dtpf_gene.Value
                ELPAGO_DOCUMENTOBE.cbco_cod = txtcbco_cod.Text
                dtCtaBco = ELPAGO_DOCUMENTOBL.BuscarCtaBanco(txtcbco_cod.Text, sAño)
                If dtCtaBco.Rows.Count > 0 Then
                    CTACOD = dtCtaBco.Rows(0).ItemArray(0)
                Else
                    MessageBox.Show("Cuenta Banco no encontrado")
                End If


                ELPAGO_DOCUMENTOBE.cta_cod = CTACOD
                ELPAGO_DOCUMENTOBE.moneda = txtmon.Text
                ELPAGO_DOCUMENTOBE.est1 = cmbest1.SelectedItem.ToString.Substring(0, 1)
                ELPAGO_DOCUMENTOBE.concepto = txtobserva.Text
                ELPAGO_DOCUMENTOBE.proveedor = txtproveedor.Text
                ELPAGO_DOCUMENTOBE.cco_cod = txtcco_cod.Text

                If txtTCambSBS.Text = "" Then
                    ELPAGO_DOCUMENTOBE.tcambiosbs = 1
                Else
                    ELPAGO_DOCUMENTOBE.tcambiosbs = txtTCambSBS.Text
                End If

                If cmbcobranza.SelectedIndex = -1 Then
                    ELPAGO_DOCUMENTOBE.cobranza = ""
                Else
                    ELPAGO_DOCUMENTOBE.cobranza = cmbcobranza.SelectedItem.ToString.Substring(0, 2)
                End If

                ELPAGO_DOCUMENTOBE.tipo1 = cmbtipo1.SelectedItem.ToString.Substring(0, 1)
                ELPAGO_DOCUMENTOBE.reten = txtreten.Text
                ELPAGO_DOCUMENTOBE.porcentaje = txtporcentaje.Text
                ELPAGO_DOCUMENTOBE.totalsoles = lblSoles.Text
                ELPAGO_DOCUMENTOBE.totaldolar = lbldolares.Text
                ELPAGO_DOCUMENTOBE.tipo07 = ""
                ELPAGO_DOCUMENTOBE.est_mercancia = ""

                If dtpfec_vigencia.Checked = True Then
                    ELPAGO_DOCUMENTOBE.fec_vigencia = dtpfec_vigencia.Value
                Else
                    ELPAGO_DOCUMENTOBE.fec_vigencia = Nothing
                End If

                If txtcantidad.Text = "" Then
                    ELPAGO_DOCUMENTOBE.cantidad = "0"
                Else
                    ELPAGO_DOCUMENTOBE.cantidad = txtcantidad.Text
                End If

                If dtpfec_dia.Checked = True Then
                    ELPAGO_DOCUMENTOBE.fec_dia = dtpfec_dia.Value
                Else
                    ELPAGO_DOCUMENTOBE.fec_dia = Nothing
                End If

                If dtpfec_pago.Checked = True Then
                    ELPAGO_DOCUMENTOBE.fec_pago = dtpfec_pago.Value
                Else
                    ELPAGO_DOCUMENTOBE.fec_pago = Nothing
                End If

                If flagAccion = "N" Then
                    regCont = obtenerRegConta()
                    ELPAGO_DOCUMENTOBE.regcontable = regCont
                Else
                    regCont = txtregcontable.Text
                    ELPAGO_DOCUMENTOBE.regcontable = txtregcontable.Text
                    ELPAGO_DOCUMENTOBE.reg_contable1 = txtregcontable.Text
                End If
                If reg_anterior <> "" Then
                    ELPAGO_DOCUMENTOBE.regcontable = reg_anterior
                    ELPAGO_DOCUMENTOBE.reg_contable1 = txtregcontable.Text
                End If

                If txtpagoparcial.Text = "" Then
                    ELPAGO_DOCUMENTOBE.pagoparcial = "0"
                Else
                    ELPAGO_DOCUMENTOBE.pagoparcial = txtpagoparcial.Text
                End If

                If txtreten.Text = "" Then
                    ELPAGO_DOCUMENTOBE.reten = "0"
                Else
                    ELPAGO_DOCUMENTOBE.reten = txtreten.Text
                End If

                If txtporcentaje.Text = "" Then
                    ELPAGO_DOCUMENTOBE.porcentaje = "0"
                Else
                    ELPAGO_DOCUMENTOBE.porcentaje = txtporcentaje.Text
                End If
                ELPAGO_DOCUMENTOBE.usuario = gsUser

                gsError = ELPAGO_DOCUMENTOBL.SaveRow(ELPAGO_DOCUMENTOBE, flagAccion, dgvt_doc, ELPAGO_DET_DOCUMENTOBE)

                'gsError = "OK"
                If txtmon.Text = "01" Then
                    ProcesarRegContDolares()
                    Exit Sub
                End If

                If gsError = "OK" Then
                    'flagAccion = "N"

                    'PRIMER REGISTRO 
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        MOV_CTBE = CargarDatosMOVCT(i, regCont)
                        gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")

                        If Not gsError = "OK" Then
                            FormMain.LblError.Text = "Error al Grabar, Verificar datos en linea " & i + 1
                            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        'REGISTRO EN CASO TENGA CUENTA DESTINO
                        If Not MOV_CTBE.CONTRA_CTA_COD = "" Then
                            MOV_CTBE.CTA_COD = MOV_CTBE.CONTRA_CTA_COD
                            gsError2 = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")

                            If Not gsError = "OK" Then
                                FormMain.LblError.Text = "Error al Grabar, Verificar datos en linea " & i + 1
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                                Exit Sub
                            End If

                            'BUSCAR SEGUNDA CUENTA DESTINO
                            Dim dtcuentaDestimo As New DataTable
                            dtcuentaDestimo = CONTABILIDADBL.BuscarCuentaDestino(MOV_CTBE.CTA_COD, MOV_CTBE.ANHO)
                            If dtcuentaDestimo.Rows.Count > 0 Then
                                MOV_CTBE.CTA_COD = dtcuentaDestimo.Rows(0).Item(0).ToString

                                If Not MOV_CTBE.CTA_COD = "" Then
                                    If MOV_CTBE.SIGNO = "+" Then
                                        MOV_CTBE.SIGNO = "-"
                                    Else
                                        MOV_CTBE.SIGNO = "+"
                                    End If
                                    gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")

                                    If Not gsError = "OK" Then
                                        FormMain.LblError.Text = "Error al Grabar, Verificar datos en linea " & i + 1
                                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    Next
                    'Registro Contable Cabecera cuenta  "1041101" "1041102" "1042101"
                    If gsError = "OK" Then
                        MOV_CTBE = CargarDatosMOVCTCabecera(regCont)
                        If MOV_CTBE.T_OPE_COD = "010" Then
                            MOV_CTBE.SIGNO = "-"
                        Else
                            MOV_CTBE.SIGNO = "+"
                        End If
                        gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")
                    End If
                    If Not gsError = "OK" Then
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                    'actualizarTablaMOVCT(MOV_CTBE, sMes, sAño)

                    txtnumero.Enabled = True
                    'lblEstado.Text = "PENDIENTE"
                    ' lblEstado.ForeColor = Color.Red
                    If flagAccion = "N" Then
                        ELPAGO_DOCUMENTOBL.ActualizarRegContable(MOV_CTBE, prefBanco)
                    End If
                    txtregcontable.Text = regCont
                    sumSoles = 0
                    sumDolares = 0
                    'For i = 0 To dgvt_doc.Rows.Count - 1
                    '    If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                    '        signo = 1
                    '    Else
                    '        signo = -1
                    '    End If
                    '    sumSoles = sumSoles + dgvt_doc.Rows(i).Cells("T_Soles").Value * signo
                    '    sumDolares = sumDolares + dgvt_doc.Rows(i).Cells("T_Dolares").Value * signo
                    'Next
                    lblSoles.Text = MOV_CTBE.IMPOR
                    lbldolares.Text = MOV_CTBE.IMPOR_ME
                    flagAccion = "M"
                    sumSoles = 0
                    sumDolares = 0
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    'Public Sub actualizarTablaMOVCT(ByVal MOV_CTBE As MOV_CTBE, ByVal mmes As String, ByVal manho As String)
    '    Dim dtMovCT As New DataTable
    '    dtMovCT = ELPAGO_DOCUMENTOBL.actualizarTablaMOVCT(MOV_CTBE, mmes, manho)
    'End Sub

    Private Sub ProcesarRegContDolares()
        If gsError = "OK" Then
            ' flagAccion = "N"
            Dim regCont
            If txtregcontable.Text = "" Then
                regCont = obtenerRegConta()
            Else
                regCont = txtregcontable.Text
            End If
            'PRIMER REGISTRO 
            For i = 0 To dgvt_doc.Rows.Count - 1

                MOV_CTBE = CargarDatosMOVCT(i, regCont)
                gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")
                Dim dtCuentas = ELPAGO_DOCUMENTOBL.BuscarCtasDestino(MOV_CTBE.CTA_COD, MOV_CTBE.ANHO)


                'REGISTRO EN CASO TENGA CUENTA DESTINO
                If Not MOV_CTBE.CONTRA_CTA_COD = "" Then
                    MOV_CTBE.CTA_COD = MOV_CTBE.CONTRA_CTA_COD
                    gsError2 = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")

                    If Not gsError = "OK" Then
                        FormMain.LblError.Text = "Error al Grabar, Verificar datos en linea " & i + 1
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                        Exit Sub
                    End If

                    'BUSCAR SEGUNDA CUENTA DESTINO
                    'Dim dtcuentaDestimo As New DataTable
                    ' dtcuentaDestimo = CONTABILIDADBL.BuscarCuentaDestino(MOV_CTBE.CTA_COD, MOV_CTBE.ANHO)
                    'If dtcuentaDestimo.Rows.Count > 0 Then
                    If Not dtCuentas.Rows(0).ItemArray(2) = "" Then
                        MOV_CTBE.CTA_COD = dtCuentas.Rows(0).Item(2).ToString

                        If Not MOV_CTBE.CTA_COD = "" Then
                            If ELPAGO_DET_DOCUMENTOBE.t_ope_cod = "010" Then
                                If MOV_CTBE.SIGNO = "+" Then
                                    MOV_CTBE.SIGNO = "-"
                                Else
                                    MOV_CTBE.SIGNO = "+"
                                End If
                            Else
                                If MOV_CTBE.SIGNO = "+" Then
                                    MOV_CTBE.SIGNO = "-"
                                Else
                                    MOV_CTBE.SIGNO = "+"
                                End If
                            End If

                            gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")

                            If Not gsError = "OK" Then
                                FormMain.LblError.Text = "Error al Grabar, Verificar datos en linea " & i + 1
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        End If
                    End If
                End If
                Dim diferencia = 0.0
                If Not txtTCambSBS.Text = dgvt_doc.Rows(i).Cells("T_cambio").Value Then
                    'If Not dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text = dgvt_doc.Rows(i).Cells("T_soles").Value Then
                    'Registrar Perdida/Ganancia por tipo de cambio
                    If MOV_CTBE.T_OPE_COD = "010" Then
                        If i = 16 Then
                            Dim valor = ""
                        End If
                        If txtTCambSBS.Text * dgvt_doc.Rows(i).Cells("T_dolares").Value > dgvt_doc.Rows(i).Cells("T_soles").Value Then
                            diferencia = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text - dgvt_doc.Rows(i).Cells("T_soles").Value
                            Dim monto1 = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text
                            Dim monto2 = dgvt_doc.Rows(i).Cells("T_soles").Value
                            Dim dif = monto1 - monto2

                            If dgvt_doc.Rows(i).Cells("Signo").Value = "-" Then
                                MOV_CTBE.CTA_COD = "7761101"
                                MOV_CTBE.SIGNO = "-"
                            Else
                                MOV_CTBE.CTA_COD = "6761101"
                                MOV_CTBE.SIGNO = "+"
                            End If
                        Else
                            diferencia = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text - dgvt_doc.Rows(i).Cells("T_soles").Value
                            Dim monto1 = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text
                            Dim monto2 = dgvt_doc.Rows(i).Cells("T_soles").Value
                            Dim dif = monto1 - monto2
                            If dgvt_doc.Rows(i).Cells("Signo").Value = "-" Then
                                MOV_CTBE.CTA_COD = "6761101"
                                MOV_CTBE.SIGNO = "+"
                            Else

                                MOV_CTBE.CTA_COD = "7761101"
                                MOV_CTBE.SIGNO = "-"
                            End If
                        End If
                    Else
                        If txtTCambSBS.Text * dgvt_doc.Rows(i).Cells("T_dolares").Value > dgvt_doc.Rows(i).Cells("T_soles").Value Then
                            If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                                MOV_CTBE.CTA_COD = "6761101"
                                diferencia = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text - dgvt_doc.Rows(i).Cells("T_soles").Value
                                Dim monto1 = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text
                                Dim monto2 = dgvt_doc.Rows(i).Cells("T_soles").Value
                                Dim dif = monto1 - monto2
                                MOV_CTBE.SIGNO = "+"
                            Else
                                MOV_CTBE.CTA_COD = "7761101"
                                diferencia = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text - dgvt_doc.Rows(i).Cells("T_soles").Value
                                Dim monto1 = dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text
                                Dim monto2 = dgvt_doc.Rows(i).Cells("T_soles").Value
                                Dim dif = monto1 - monto2
                                MOV_CTBE.SIGNO = "-"
                            End If

                        Else
                            If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                                MOV_CTBE.CTA_COD = "7761101"
                                diferencia = dgvt_doc.Rows(i).Cells("T_soles").Value - dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text
                                MOV_CTBE.SIGNO = "-"
                                'If diferencia < 0 Then
                                '    MOV_CTBE.CTA_COD = "7761101"
                                '    MOV_CTBE.SIGNO = "-"
                                'Else
                                '    MOV_CTBE.CTA_COD = "6761101"
                                '    MOV_CTBE.SIGNO = "+"
                                'End If
                            Else
                                MOV_CTBE.CTA_COD = "6761101"
                                diferencia = dgvt_doc.Rows(i).Cells("T_soles").Value - dgvt_doc.Rows(i).Cells("T_dolares").Value * txtTCambSBS.Text
                                MOV_CTBE.SIGNO = "+"
                                'If diferencia < 0 Then
                                '    MOV_CTBE.CTA_COD = "6761101"
                                '    MOV_CTBE.SIGNO = "+"
                                'Else
                                '    MOV_CTBE.CTA_COD = "7761101"
                                '    MOV_CTBE.SIGNO = "-"
                                'End If
                            End If
                        End If
                    End If
                    diferencia = diferencia
                    MOV_CTBE.IMPOR = IIf(diferencia < 0, diferencia * -1, diferencia)
                    MOV_CTBE.IMPOR_ME = 0
                    MOV_CTBE.T_CMB = txtTCambSBS.Text
                    gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")
                End If
            Next

            'Registro Contable Cabecera cuenta  "1041101" "1041102" "1042101"
            If gsError = "OK" Then
                MOV_CTBE = CargarDatosMOVCTCabecera(regCont)
                If MOV_CTBE.T_OPE_COD = "010" Then
                    MOV_CTBE.SIGNO = "-"
                Else
                    MOV_CTBE.SIGNO = "+"
                End If
                gsError = ELPAGO_DOCUMENTOBL.SaveRowRegCont(MOV_CTBE, "N")
            Else
                MsgBox("Error al Grabar", MsgBoxStyle.Information)
                FormMain.LblError.Text = gsError
                Exit Sub
            End If

            If Not gsError = "OK" Then
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If flagAccion = "N" Then
                ELPAGO_DOCUMENTOBL.ActualizarRegContable(MOV_CTBE, prefBanco)
            End If

            'Dim sumSoles = 0.00
            'Dim sumDolares = 0.00
            'Dim signo = 0

            'For i = 0 To dgvt_doc.Rows.Count - 1
            '    If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
            '        Signo = 1
            '    Else
            '        Signo = -1
            '    End If
            '    sumSoles = sumSoles + dgvt_doc.Rows(i).Cells("T_Soles").Value * Signo
            '    sumDolares = sumDolares + dgvt_doc.Rows(i).Cells("T_Dolares").Value * Signo
            'Next
            'lblSoles.Text = sumSoles
            'lbldolares.Text = Format(sumDolares, "#.#0")


            lblEstado.Text = "PROCESADO"
            lblEstado.ForeColor = Color.Blue
            txtregcontable.Text = regCont
            flagAccion = "M"
            lblSoles.Text = MOV_CTBE.IMPOR
            VerificarDiferenciaTC()
            lbldolares.Text = MOV_CTBE.IMPOR_ME
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            txtnumero.Enabled = False
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function CargarDatosMOVCTCabecera(ByVal regCont As String) As MOV_CTBE
        Dim MOV_CTBE As New MOV_CTBE
        Dim cuenta = ""
        Select Case txtcbco_cod.Text & txtmon.Text
            Case "100"
                cuenta = "1041101"
            Case "201"
                cuenta = "1041102"
            Case "300"
                cuenta = "1042101"
        End Select

        With MOV_CTBE
            .ANHO = dtpf_gene.Value.ToString("yyyy")
            .MES = dtpf_gene.Value.ToString("MM")
            .T_OPE_COD = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
            .REG_NRO = regCont
            .SEQ = 0
            .CTA_COD = cuenta
            .CONTRA_CTA_COD = ""
            .CTCT_COD = ""
            .FEC = dtpf_gene.Value.ToString("dd/MM/yyyy")
            .SERIE_NRO = txtserie.Text
            .T_DOC_COD = txtt_doc.Text
            .MON_COD = txtmon.Text
            .CCO_COD = txtcco_cod.Text
            .FUENTE_COD = ""
            .PROY_COD = 1
            .CHEQ_NRO = txtnumero.Text
            .COMP_CPTO = txtobserva.Text
            .COMP_FEC = dtpf_gene.Value.ToString("dd/MM/yyyy")
            .COMP_NRO = txtnumero.Text
            Dim sumSoles = 0.00
            Dim sumDolares = 0.00
            Dim signo = 0
            If .T_OPE_COD = "010" Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                        signo = 1
                    Else
                        signo = -1
                    End If
                    sumSoles = sumSoles + dgvt_doc.Rows(i).Cells("T_Soles").Value * signo
                    sumDolares = sumDolares + dgvt_doc.Rows(i).Cells("T_Dolares").Value * signo
                Next
            Else
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("Signo").Value = "+" Then
                        signo = -1
                    Else
                        signo = +1
                    End If
                    sumSoles = sumSoles + dgvt_doc.Rows(i).Cells("T_Soles").Value * signo
                    sumDolares = sumDolares + dgvt_doc.Rows(i).Cells("T_Dolares").Value * signo
                Next
            End If

            lblSoles.Text = sumSoles
            lbldolares.Text = Format(sumDolares, "#.#0")

            If .MON_COD = "00" Then
                .IMPOR = sumSoles
            Else
                .IMPOR = Math.Round(sumDolares * txtTCambSBS.Text, 2)
            End If

            '.IMPOR = sumSoles
            .IMPOR_ME = lbldolares.Text
            .PROG_FEC = dtpfec_pago.Value.ToString("dd/MM/yyyy")
            .RUC = txtproveedor.Text
            .SIGNO = "-"
            .T_CMB = txtTCambSBS.Text
            .X_PROV = ""
            .USUARIO = gsUser

        End With
        Return MOV_CTBE
    End Function

    Private Function obtenerRegConta() As String
        prefBanco = "00"
        If txtmon.Text = "00" Then
            Select Case txtcbco_cod.Text
                Case 1
                    prefBanco = "11"
                Case 3
                    prefBanco = "22"
            End Select
        Else
            prefBanco = "12"
        End If

        Dim dtRegCont As New DataTable
        dtRegCont = ELPAGO_DOCUMENTOBL.BuscarRegistroContable(dtpf_gene.Value.ToString("yyyy"), dtpf_gene.Value.ToString("MM"),
                                                             cmbt_ope.SelectedItem.ToString.Substring(0, 3), prefBanco)

        If dtRegCont.Rows.Count > 0 Then
            Return dtRegCont.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Private Function CargarDatosMOVCT(ByVal i As Integer, ByVal regCont As String) As MOV_CTBE

        With MOV_CTBE
            .ANHO = dtpf_gene.Value.ToString("yyyy")
            .MES = dtpf_gene.Value.ToString("MM")
            .T_OPE_COD = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
            .REG_NRO = regCont
            .SEQ = 0
            .CTA_COD = dgvt_doc.Rows(i).Cells("Cuenta").Value
            .CONTRA_CTA_COD = dgvt_doc.Rows(i).Cells("Cta_des").Value
            .CTCT_COD = ""
            .FEC = dgvt_doc.Rows(i).Cells("Fecha").Value
            .SERIE_NRO = dgvt_doc.Rows(i).Cells("SERIE_DOC_REF").Value
            .T_DOC_COD = dgvt_doc.Rows(i).Cells("T_DOC_REF").Value
            .MON_COD = txtmon.Text
            .CCO_COD = Mid(dgvt_doc.Rows(i).Cells("CCO_COD").Value, 1, 3)
            .FUENTE_COD = ""
            .PROY_COD = 1
            .CHEQ_NRO = txtnumero.Text
            .COMP_CPTO = txtobserva.Text
            .COMP_FEC = dgvt_doc.Rows(i).Cells("Fecha").Value
            .COMP_NRO = dgvt_doc.Rows(i).Cells("NRO_DOC").Value
            .IMPOR = dgvt_doc.Rows(i).Cells("T_Soles").Value
            .IMPOR_ME = dgvt_doc.Rows(i).Cells("T_Dolares").Value
            .PROG_FEC = dtpf_gene.Value
            .RUC = dgvt_doc.Rows(i).Cells("Codigo").Value
            .SIGNO = dgvt_doc.Rows(i).Cells("Signo").Value
            .T_CMB = dgvt_doc.Rows(i).Cells("T_cambio").Value
            .X_PROV = ""
            .USUARIO = gsUser
            .labor_cod = dgvt_doc.Rows(i).Cells("CODFLUJO").Value
            .t_est_tes_cod = dgvt_doc.Rows(i).Cells("CODCAJA").Value
        End With

        Return MOV_CTBE
    End Function

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

        If txtproveedor.Text = "" Then
            MsgBox("Ingrese El proveedor", MsgBoxStyle.Exclamation)
            txtproveedor.Focus()
            Return False
        End If

        'If txtcco_cod.Text = "" Then
        '    MsgBox("Ingresar Centro de Costo", MsgBoxStyle.Exclamation)
        '    txtcco_cod.Focus()
        '    Return False
        'End If

        If txtTCambSBS.Text = "" Or txtTCambSBS.Text = "1" Then
            MsgBox("Verificar Tipo de Cambio", MsgBoxStyle.Exclamation)
            txtTCambSBS.Focus()
            Return False
        End If
        'If flagAccion = "N" Then
        '    If ELLIB_CONTBL.VerificarRepetido(txtcod.Text) = True Then
        '        MsgBox("El Codigo ya existe", MsgBoxStyle.Exclamation)
        '        Return False
        '    End If
        'End If

        For i = 0 To dgvt_doc.Rows.Count - 1
            If dgvt_doc.Rows(i).Cells("CODFLUJO").Value = "" Or dgvt_doc.Rows(0).Cells("CODCAJA").Value = "" Then
                MsgBox("Verificar Cod. Flujo o Cod. Caja en fila " & i + 1)
                Return False
            End If
        Next


        For i = 0 To dgvt_doc.Rows.Count - 1
            If dgvt_doc.Rows(i).Cells("Signo").Value = "" Then
                MsgBox("Ingrese Signo en fila " & i + 1)
                dgvt_doc.Rows(i).Selected = True
                Return False
            End If
        Next

        Return True
    End Function
    Private Sub Limpiar()
        txtserie.Text = DateTime.Now.Year
        cmbtipo1.SelectedIndex = 1
        'txtserie.Text = "2040"
        cmbt_ope.SelectedIndex = 0
        cmbest1.SelectedIndex = 0
        cmbcobranza.SelectedIndex = 0
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sCos As String)
        Dim dtUsuario, Dtdetalle As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPAGO_DOCUMENTOBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            estadoTC = 0
            cmbt_ope.SelectedItem = IIf(IsDBNull(Registro("T_OPE")), "", Registro("T_OPE"))
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            txtserie.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            lblt_doc.Text = IIf(IsDBNull(Registro("TIPO_DOCUMENTO")), "", Registro("TIPO_DOCUMENTO"))
            dtpf_gene.Value = Registro("FEC_GENE")
            txtcbco_cod.Text = IIf(IsDBNull(Registro("CBCO_COD")), "", Registro("CBCO_COD"))
            lblcbco.Text = IIf(IsDBNull(Registro("BANCO")), "", Registro("BANCO"))
            txtcantidad.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            lblmon.Text = IIf(IsDBNull(Registro("MONEDA_NOM")), "", Registro("MONEDA_NOM"))
            cmbest1.SelectedIndex = IIf(IsDBNull(Registro("ESTADO")), 0, Registro("ESTADO"))
            txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtproveedor.Text = IIf(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            lblproveedor.Text = IIf(IsDBNull(Registro("PROVEE_NOM")), "", Registro("PROVEE_NOM"))
            txtcco_cod.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            lvlcco_cod.Text = IIf(IsDBNull(Registro("CENTRO_NOM")), "", Registro("CENTRO_NOM"))
            cmbcobranza.SelectedIndex = IIf(IsDBNull(Registro("COBRANZA")), -1, Registro("COBRANZA"))
            cmbtipo1.SelectedIndex = IIf(IsDBNull(Registro("TIPO1")), -1, Registro("TIPO1"))
            txtreten.Text = IIf(IsDBNull(Registro("RETEN")), "", Registro("RETEN"))
            txtporcentaje.Text = IIf(IsDBNull(Registro("PORCENTAJE")), "", Registro("PORCENTAJE"))
            txtregcontable.Text = IIf(IsDBNull(Registro("REG_NRO")), "", Registro("REG_NRO"))

            txtTCambSBS.Text = IIf(IsDBNull(Registro("T_CAMBIO")), "", Registro("T_CAMBIO"))
            lbldolares.Text = IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), "", Registro("TPRECIO_DCOMPRA"))
            lblSoles.Text = IIf(IsDBNull(Registro("TPRECIO_COMPRA")), "", Registro("TPRECIO_COMPRA"))
            lblEstado.Text = IIf(IsDBNull(Registro("EST_SEGUIMIENTO")), "", Registro("EST_SEGUIMIENTO"))
            txt_usuCrea.Text = IIf(IsDBNull(Registro("USUARIO")), "", Registro("USUARIO"))
            txt_usuAct.Text = IIf(IsDBNull(Registro("COD_FARDOANTIGUO3")), "", Registro("COD_FARDOANTIGUO3"))
            txt_FecCrea.Text = IIf(IsDBNull(Registro("FEC_LETRA")), "", Registro("FEC_LETRA"))

            If lblEstado.Text = "0" Then
                lblEstado.Text = "PENDIENTE"
                lblEstado.ForeColor = Color.Red
            Else
                lblEstado.Text = "PROCESADO"
                lblEstado.ForeColor = Color.Blue
            End If

            If Registro("FEC_VIGENCIA").ToString = "01/01/0001" Or IsDBNull(Registro("FEC_VIGENCIA")) Then
                dtpfec_vigencia.Value = Registro("FEC_GENE")
                dtpfec_vigencia.Checked = False
            Else
                dtpfec_vigencia.Value = Registro("FEC_VIGENCIA")
            End If

            If Registro("FEC_DIA").ToString = "01/01/0001" Or IsDBNull(Registro("FEC_DIA")) Then
                dtpfec_dia.Value = Registro("FEC_GENE")
                dtpfec_dia.Checked = False
            Else
                dtpfec_dia.Value = Registro("FEC_DIA")
            End If

            If Registro("FEC_PAGO").ToString = "01/01/0001" Or IsDBNull(Registro("FEC_PAGO")) Then
                dtpfec_pago.Value = Registro("FEC_GENE")
                dtpfec_pago.Checked = False
            Else
                dtpfec_pago.Value = Registro("FEC_PAGO")
            End If

            txtpagoparcial.Text = IIf(IsDBNull(Registro("PORCENTAJE")), "", Registro("PORCENTAJE"))
        Next

        ''
        Dtdetalle = ELPAGO_DOCUMENTOBL.SelectRowDetalle(sTDoc, sSDoc, sNDoc, sCos)
        For Each Detalle In Dtdetalle.Rows
            Dim chk
            If Detalle("REPARAR") = "0" Then
                chk = False
            Else
                chk = True
            End If
            dgvt_doc.Rows.Add(IIf(IsDBNull(Detalle("T_DOC_REF1")), "", Detalle("T_DOC_REF1")),
                              IIf(IsDBNull(Detalle("SER_DOC_REF1")), "", Detalle("SER_DOC_REF1")),
                              IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")),
                              IIf(IsDBNull(Detalle("STATUS")), "", Detalle("STATUS")),
                              IIf(IsDBNull(Detalle("CUENTA")), "", Detalle("CUENTA")),
                              IIf(IsDBNull(Detalle("CUENTA_DEST")), "", Detalle("CUENTA_DEST")),
                              IIf(IsDBNull(Detalle("CTCT_COD")), "", Detalle("CTCT_COD")),
                              IIf(IsDBNull(Detalle("NOMBRE")), "", Detalle("NOMBRE")),
                              IIf(IsDBNull(Detalle("SIGNO")), "", Detalle("SIGNO")),
                              IIf(IsDBNull(Detalle("FEC_GENE")), "", Detalle("FEC_GENE")),
                              IIf(IsDBNull(Detalle("T_CAMB")), "", Detalle("T_CAMB")),
                              IIf(IsDBNull(Detalle("MONEDA")), "", Detalle("MONEDA")),
                              IIf(IsDBNull(Detalle("NOM")), "", Detalle("NOM")),
                              IIf(IsDBNull(Detalle("TPRECIO_COMPRA")), "", Detalle("TPRECIO_COMPRA")),
                              IIf(IsDBNull(Detalle("TPRECIO_DCOMPRA")), "", Detalle("TPRECIO_DCOMPRA")),
                              IIf(IsDBNull(Detalle("NRO_DOCU1")), "", Detalle("NRO_DOCU1")),
                              IIf(IsDBNull(Detalle("TIPO7")), "", Detalle("TIPO7")),
                              IIf(IsDBNull(Detalle("FLUJO")), "", Detalle("FLUJO")),
                              IIf(IsDBNull(Detalle("EST_MERCADERIA")), "", Detalle("EST_MERCADERIA")),
                              IIf(IsDBNull(Detalle("CAJA")), "", Detalle("CAJA")),
                              IIf(chk, True, False),
                              IIf(IsDBNull(Detalle("TEMPLE")), "", Detalle("TEMPLE")),
                              IIf(IsDBNull(Detalle("CCO_COD")), "", Detalle("CCO_COD")))
        Next

        ' Actualizar()

    End Sub
    Private Sub txtcbco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcbco_cod.LostFocus
        If (txtcbco_cod.Text = "") Then
            lblcbco.Text = ""
        Else
            Dim dt As DataTable
            dt = CUENTABANCOBL.SelectbancoCOD(txtcbco_cod.Text)
            If dt.Rows.Count > 0 Then
                txtcbco_cod.Text = dt.Rows(0).Item(0).ToString
                lblcbco.Text = dt.Rows(0).Item(1).ToString
                Select Case txtcbco_cod.Text
                    Case 1, 3, 4, 8, 10, 11, 13, 15, 19, 21
                        txtmon.Text = "00"
                        lblmon.Text = "SOLES"
                    Case 2, 5, 6, 7, 12, 14, 16, 17, 18, 20, 22
                        txtmon.Text = "01"
                        lblmon.Text = "DÓLARES AMERICANOS"
                End Select
            Else
                txtcbco_cod.Text = ""
                lblcbco.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcbco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcbco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "BANCO"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcbco_cod.Text = gLinea
                lblcbco.Text = gSubLinea
                Select Case txtcbco_cod.Text
                    Case 1, 3, 4, 8, 10, 11, 13, 15, 19, 21
                        txtmon.Text = "00"
                        lblmon.Text = "SOLES"
                    Case 2, 5, 6, 7, 12, 14, 16, 17, 18, 20, 22
                        txtmon.Text = "01"
                        lblmon.Text = "DÓLARES AMERICANOS"
                End Select
                txtobserva.Select()

                Dim dtCtaBco As New DataTable
                dtCtaBco = ELPAGO_DOCUMENTOBL.BuscarCtaBanco(txtcbco_cod.Text, sAño)
                If dtCtaBco.Rows.Count > 0 Then
                    CTACOD = dtCtaBco.Rows(0).ItemArray(0)
                End If
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""

        If e.KeyValue = Keys.Enter Then
            Dim dtBancos As New DataTable
            dtBancos = ELDOCUMENTOBL.BuscarBanco(txtcbco_cod.Text)
            If dtBancos.Rows.Count > 0 Then
                lblcbco.Text = dtBancos.Rows(0).ItemArray(0)
                Dim dtCtaBco As New DataTable
                dtCtaBco = ELPAGO_DOCUMENTOBL.BuscarCtaBanco(txtcbco_cod.Text, sAño)
                If dtCtaBco.Rows.Count > 0 Then
                    CTACOD = dtCtaBco.Rows(0).ItemArray(0)
                End If
                Select Case txtcbco_cod.Text
                    Case 1, 3, 4, 8, 10, 11, 13, 15, 19, 21
                        txtmon.Text = "00"
                        lblmon.Text = "SOLES"
                    Case 2, 5, 6, 7, 12, 14, 16, 17, 18, 20, 22
                        txtmon.Text = "01"
                        lblmon.Text = "DÓLARES AMERICANOS"
                End Select
                txtobserva.Select()
            Else
                MsgBox("Verificar Cod. Banco ")
            End If
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
    'Private Sub txtmon_LostFocus(sender As Object, e As EventArgs) Handles txtmon.LostFocus
    '    If (txtmon.Text = "") Then
    '        lblmon.Text = ""
    '    Else
    '        Dim dt As DataTable
    '        dt = ELDOCUMENTOBL.SelectMonCOD(txtmon.Text)
    '        If dt.Rows.Count > 0 Then
    '            txtmon.Text = dt.Rows(0).Item(0).ToString
    '            lblmon.Text = dt.Rows(0).Item(1).ToString
    '        Else
    '            txtmon.Text = ""
    '            lblmon.Text = ""
    '        End If
    '    End If
    'End Sub

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
        gLinea = ""
        gSubLinea = ""

        If e.KeyValue = Keys.Enter Then
            Dim dtMoneda As New DataTable
            dtMoneda = ELDOCUMENTOBL.BuscarMoneda(txtmon.Text)
            If dtMoneda.Rows.Count > 0 Then
                lblmon.Text = dtMoneda.Rows(0).ItemArray(1)
                txtmon.Text = dtMoneda.Rows(0).ItemArray(0)
                txtobserva.Select()
            Else
                MsgBox("Verificar Cod. Moneda ")
            End If
        End If
    End Sub
    'Private Sub txtproveedor_LostFocus(sender As Object, e As EventArgs) Handles txtproveedor.LostFocus
    '    If (txtproveedor.Text = "") Then
    '        lblproveedor.Text = ""
    '    Else
    '        Dim dt As DataTable
    '        dt = ELDOCUMENTOBL.SelectProveedorCOD(txtproveedor.Text)
    '        If dt.Rows.Count > 0 Then
    '            txtproveedor.Text = dt.Rows(0).Item(0).ToString
    '            lblproveedor.Text = dt.Rows(0).Item(1).ToString
    '        Else
    '            txtproveedor.Text = ""
    '            lblproveedor.Text = ""
    '        End If
    '    End If
    'End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            tipOperacion = cmbt_ope.Text.Substring(0, 3)
            If cmbt_ope.Text.Substring(0, 3) = "010" Then
                sBusAlm = "98"
            Else
                sBusAlm = "98-C"
            End If
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtproveedor.Text = gLinea
                lblproveedor.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""

        If e.KeyValue = Keys.Enter Then
            txtcco_cod.Select()
        End If
    End Sub

    Private Sub txtcco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcco_cod.LostFocus
        If (txtcco_cod.Text = "") Then
            lvlcco_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELPAGO_DOCUMENTOBL.SelectCentroCostoCOD(txtcco_cod.Text)
            If dt.Rows.Count > 0 Then
                txtcco_cod.Text = dt.Rows(0).Item(0).ToString
                lvlcco_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcco_cod.Text = ""
                lvlcco_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "101"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcco_cod.Text = gLinea
                lvlcco_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""

        If e.KeyValue = Keys.Enter Then
            cmbcobranza.Select()
        End If
    End Sub

    Private Sub txtcbco_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcbco_cod.KeyPress, txtmon.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        estadoTC = 0
        If cmbt_ope.SelectedIndex = 0 Then
            gsCode13 = "98"
            gsOperacion = "010"
        Else
            gsCode13 = "98-C"
            gsOperacion = "013"
        End If
        Dim frm As New FormDocuRefConta
        frm.Label9.Text = cmbt_ope.SelectedIndex
        frm.ShowDialog()
        Actualizar()
        estadoTC = 1
        gsCode13 = ""
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        opePagoCob = cmbt_ope.Text.ToString.Substring(0, 3)

        If Not txtTCambSBS.Text = "" Then
            tcOperacion = txtTCambSBS.Text
        End If

        flagAccion1 = "N"
        If flagAccion1 = "N" Then
            fecGenPago = dtpf_gene.Value
        End If

        Dim frm As New FormELPAGO_DETDOCUMENTO
        frm.ShowDialog()
        ' Actualizar()
    End Sub
    Sub Actualizar()
        Dim totalsoles As Double = 0
        Dim totaldolar As Double = 0
        Dim signo = 0

        If cmbt_ope.Text.Substring(0, 3) = "010" Then
            For Each row As DataGridViewRow In dgvt_doc.Rows
                If row.Cells("Signo").Value = "+" Then
                    signo = 1
                Else
                    signo = -1
                End If
                totalsoles = totalsoles + CDbl(row.Cells("T_Soles").Value) * signo
                totaldolar = totaldolar + CDbl(row.Cells("T_Dolares").Value) * signo
            Next
        Else

            For Each row As DataGridViewRow In dgvt_doc.Rows
                If row.Cells("Signo").Value = "+" Then
                    signo = -1
                Else
                    signo = +1
                End If
                totalsoles = totalsoles + CDbl(row.Cells("T_Soles").Value) * signo
                totaldolar = totaldolar + CDbl(row.Cells("T_Dolares").Value) * signo
            Next
        End If


        lblSoles.Text = Math.Round(totalsoles, 2)
        lbldolares.Text = Math.Round(totaldolar, 2)
    End Sub
    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            Actualizar()
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay Filas para Borrar", MsgBoxStyle.Exclamation)
        End If

        If dgvt_doc.Rows.Count > 0 Then
            txtRegistros.Text = dgvt_doc.Rows.Count
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        opePagoCob = cmbt_ope.Text.ToString.Substring(0, 3)
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormELPAGO_DETDOCUMENTO
            gsCode5 = dgvt_doc.CurrentRow.Index
            flagAccion1 = "M"

            gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF").Value
            frm.txtt_doc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF").Value

            frm.txtserie.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SERIE_DOC_REF").Value
            frm.txtnumero.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC").Value

            frm.cmbafecto.SelectedItem = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("AFECTO").Value
            frm.txtcuenta.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUENTA").Value
            frm.lbldestino.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_DES").Value
            frm.lblsigno.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SIGNO").Value

            frm.dtpcom_fech.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FECHA").Value
            frm.lbltcambio.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_cambio").Value
            frm.txtmon.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Mon").Value
            frm.lblmon.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Moneda").Value
            frm.txtsoles.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_Soles").Value
            frm.txtdolar.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_dolares").Value

            frm.txt_codproveedor.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Codigo").Value
            frm.txt_proveedor.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Proveedor").Value
            frm.txt_actFlujo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CODFLUJO").Value
            frm.txt_flujo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(17).Value
            frm.txt_ActCaja.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CODCAJA").Value
            frm.txt_caja.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(19).Value
            If Not dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value = "" Then
                frm.txt_ccocod.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value.ToString.Substring(0, 3)
                Dim longitud = Len(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value)
                frm.txt_nomcco.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value.ToString.Substring(4, longitud - 4)
            End If



            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Mon").Value = "00" Then
                frm.txtsoles.Enabled = True
                frm.Label13.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("estcom").Value
                frm.Label14.Text = frm.txtsoles.Text
                frm.txtdolar.Enabled = False
            Else
                frm.txtsoles.Enabled = False
                frm.txtdolar.Enabled = True
                frm.Label13.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("estcom").Value
                frm.Label14.Text = frm.txtdolar.Text
            End If

            For Each row As DataGridViewRow In dgvt_doc.Rows

                frm.dgvt_docdet.Rows.Add(IIf(IsDBNull(row.Cells("T_DOC_REF").Value), "", row.Cells("T_DOC_REF").Value),'1
                                  IIf(IsDBNull(row.Cells("SERIE_DOC_REF").Value), "", row.Cells("SERIE_DOC_REF").Value),'2
                                  IIf(IsDBNull(row.Cells("NRO_DOC").Value), "", row.Cells("NRO_DOC").Value),'3                                      
                                  IIf(IsDBNull(row.Cells("AFECTO").Value), "", row.Cells("AFECTO").Value),'4
                                  IIf(IsDBNull(row.Cells("CUENTA").Value), "", row.Cells("CUENTA").Value),'5
                                  IIf(IsDBNull(row.Cells("CTA_DES").Value), "", row.Cells("CTA_DES").Value),'6
                                  IIf(IsDBNull(row.Cells("CODIGO").Value), "", row.Cells("CODIGO").Value),'7
                                  IIf(IsDBNull(row.Cells("PROVEEDOR").Value), "", row.Cells("PROVEEDOR").Value), '8
                                  IIf(IsDBNull(row.Cells("SIGNO").Value), "", row.Cells("SIGNO").Value), '9                  
                                  IIf(IsDBNull(row.Cells("FECHA").Value), "", row.Cells("FECHA").Value),'10
                                  IIf(IsDBNull(row.Cells("T_CAMBIO").Value), "", row.Cells("T_CAMBIO").Value),'11
                                  IIf(IsDBNull(row.Cells("MON").Value), "", row.Cells("MON").Value),'12
                                  IIf(IsDBNull(row.Cells("MONEDA").Value), "", row.Cells("MONEDA").Value),'13
                                  IIf(IsDBNull(row.Cells("T_SOLES").Value), "", row.Cells("T_SOLES").Value),'14
                                  IIf(IsDBNull(row.Cells("T_DOLARES").Value), "", row.Cells("T_DOLARES").Value),'15
                                  IIf(IsDBNull(row.Cells("O_COMPRA").Value), "", row.Cells("O_COMPRA").Value), '16
                                  IIf(IsDBNull(row.Cells("estcom").Value), "", row.Cells("estcom").Value)) '17
            Next

            frm.ShowDialog()
        Else
            MsgBox("No hay Filas para modificar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtporcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreten.KeyPress, txtporcentaje.KeyPress, txtregcontable.KeyPress, txtpagoparcial.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub ELPAGO_DOCUMENTO_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub

    Private Sub txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnumero.Select()
        End If
    End Sub

    Private Sub txtnumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumero.KeyDown

        If e.KeyValue = Keys.Enter Then
            Dim dtNumero As New DataTable
            Dim opeDoc = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
            Dim tipoDoc = txtt_doc.Text
            Dim serDoc = txtserie.Text
            Dim numDoc = txtnumero.Text
            dtNumero = ELPAGO_DOCUMENTOBL.VerificarNumeroDoc(opeDoc, tipoDoc, serDoc, numDoc)
            If dtNumero.Rows.Count > 0 Then
                MsgBox("Verificar Numero Documento")
            Else
                dtpf_gene.Select()
            End If

        End If
    End Sub

    Private Sub dtpf_gene_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpf_gene.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim ope = cmbt_ope.Text.Substring(0, 3)
            Dim fecha = dtpf_gene.Value.ToString("dd/MM/yyyy")
            Dim dtTC As New DataTable
            dtTC = ELPAGO_DOCUMENTOBL.VerificarTCSBS(ope, fecha)
            If dtTC.Rows.Count > 0 Then
                txtTCambSBS.Text = dtTC.Rows(0).ItemArray(0)
                txtcbco_cod.Select()
            Else
                MsgBox("No hay TC registrado para esa fecha")
            End If
        End If

        If flagAccion = "N" And Not cmbt_ope.SelectedIndex = -1 Then
            dtpfec_pago.Value = dtpf_gene.Value
            dtpfec_pago.Checked = True
        End If
    End Sub

    Private Sub txtTCambSBS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTCambSBS.KeyDown
        If e.KeyValue = Keys.F9 Then
            operacionTCSBS = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
            fechaTCSBS = dtpf_gene.Value.ToString("dd/MM/yyyy")
            sBusAlm = "TCSBS"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtTCambSBS.Text = gLinea
            End If
            e.Handled = True
        End If
        gLinea = ""

        If e.KeyValue = Keys.Enter Then
            txtcbco_cod.Select()
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtmon.Select()
        End If
    End Sub

    Private Sub cmbest1_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbest1.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtobserva.Select()
        End If
    End Sub

    Private Sub txtobserva_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobserva.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtproveedor.Select()
        End If
    End Sub

    Private Sub cmbcobranza_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcobranza.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmbtipo1.Select()
        End If
    End Sub

    Private Sub cmbtipo1_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbtipo1.KeyDown
        If e.KeyValue = Keys.Enter Then
            dtpfec_vigencia.Select()
        End If
    End Sub

    Private Sub dtpfec_vigencia_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfec_vigencia.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtreten.Select()
        End If
    End Sub

    Private Sub txtreten_KeyDown(sender As Object, e As KeyEventArgs) Handles txtreten.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtporcentaje.Select()
        End If
    End Sub



    Private Sub dgvt_doc_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt_doc.CellValueChanged

        If estadoTC = 1 Then
            If dgvt_doc.Rows.Count > 0 Then
                If e.ColumnIndex = 13 Then
                    Dim fila = dgvt_doc.CurrentRow.Index
                    Dim tc = dgvt_doc.Rows(fila).Cells("T_cambio").Value
                    Dim soles = dgvt_doc.Rows(fila).Cells("T_soles").Value
                    Dim monto = 0.00
                    monto = Math.Round(soles / tc, 2)
                    dgvt_doc.Rows(fila).Cells("T_dolares").Value = monto
                    estadoTC = 0
                End If
            End If
        End If

        If estadoTC = 1 Then
            If dgvt_doc.Rows.Count > 0 Then
                If e.ColumnIndex = 14 Then
                    Dim fila = dgvt_doc.CurrentRow.Index
                    If dgvt_doc.Rows(fila).Cells("estcom").Value <> "1" Then
                        Dim tc = dgvt_doc.Rows(fila).Cells("T_cambio").Value
                        Dim dolares = dgvt_doc.Rows(fila).Cells("T_dolares").Value
                        Dim monto = 0.00
                        monto = Math.Round(dolares * tc, 2)
                        dgvt_doc.Rows(fila).Cells("T_soles").Value = monto
                        estadoTC = 0
                    End If

                End If
            End If
        End If
        Dim moneda = 0
        If dgvt_doc.Rows.Count > 0 Then
            If e.ColumnIndex = 11 And moneda = 0 Then
                Dim fila = dgvt_doc.CurrentRow.Index
                Dim mon = dgvt_doc.Rows(fila).Cells("Mon").Value
                If mon = 0 Then
                    dgvt_doc.Rows(fila).Cells("Moneda").Value = "SOLES"
                    dgvt_doc.Rows(fila).Cells("Mon").Value = "00"
                    moneda = 1
                ElseIf mon = 1 Then
                    dgvt_doc.Rows(fila).Cells("Moneda").Value = "DOLARES AMERICANOS"
                    dgvt_doc.Rows(fila).Cells("Mon").Value = "01"
                    moneda = 1
                End If
            End If
        End If
    End Sub

    Private Sub ImprimirRegistroContable()

        Dim rpt As New FormReportes
        Dim regCont = txtregcontable.Text
        Dim mes = dtpf_gene.Value.ToString("MM")
        Dim Anho = dtpf_gene.Value.ToString("yyyy")
        Dim ope = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
        Dim mon = txtmon.Text
        ReDim gsRptArgs(4)
        gsRptArgs(0) = regCont
        gsRptArgs(1) = mes
        gsRptArgs(2) = Anho
        gsRptArgs(3) = ope
        gsRptArgs(4) = mon

        'If lblEstado.Text = "PROCESADO" Then
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_REPORTE_VOUCHER.rpt"
        'Else
        'gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_REPORTE_VOUCHER_T.rpt"
        'End If


        gsRptPath = gsPathRpt
        rpt.Show()
    End Sub

    Private Sub VerificarDiferenciaTC()
        Dim regCont = txtregcontable.Text
        Dim mes = dtpf_gene.Value.ToString("MM")
        Dim Anho = dtpf_gene.Value.ToString("yyyy")
        Dim ope = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
        Dim dtDiferencia As New DataTable
        Dim diferencia As Double = 0
        dtDiferencia = ELPAGO_DOCUMENTOBL.VerificarDiferenciaTC(regCont, mes, Anho, ope)
        If dtDiferencia.Rows.Count > 0 Then
            If ope = "010" Then
                diferencia = dtDiferencia.Rows(0).ItemArray(3) - dtDiferencia.Rows(0).ItemArray(2)
            Else
                diferencia = dtDiferencia.Rows(0).ItemArray(2) - dtDiferencia.Rows(0).ItemArray(3)
            End If
        End If
        If diferencia = 0.01 Or diferencia = -0.01 Or diferencia = 0.02 Or diferencia = -0.02 Then
            dtDiferencia.Clear()
            dtDiferencia = ELPAGO_DOCUMENTOBL.ActualizarDiferenciaTC(regCont, mes, Anho, ope, diferencia)
            If dtDiferencia.Rows.Count > 0 Then
                diferencia = dtDiferencia.Rows(0).ItemArray(3) - dtDiferencia.Rows(0).ItemArray(2)
                'MsgBox(diferencia)
            Else
            End If
        End If
        'MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
    End Sub



    Private Sub dtpf_gene_ValueChanged(sender As Object, e As EventArgs) Handles dtpf_gene.ValueChanged
        Try
            Dim ope = cmbt_ope.Text.Substring(0, 3)
            Dim fecha = dtpf_gene.Value.ToString("dd/MM/yyyy")
            Dim dtTC As New DataTable
            dtTC = ELPAGO_DOCUMENTOBL.VerificarTCSBS(ope, fecha)
            If dtTC.Rows.Count > 0 Then
                txtTCambSBS.Text = dtTC.Rows(0).ItemArray(0)
                txtcbco_cod.Select()
            Else
                MsgBox("No hay TC registrado para esa fecha")
            End If
        Catch ex As Exception

        End Try
        If flagAccion = "N" And Not cmbt_ope.SelectedIndex = -1 Then
            dtpfec_pago.Value = dtpf_gene.Value
            dtpfec_vigencia.Value = dtpf_gene.Value
            dtpfec_pago.Checked = True
            dtpfec_vigencia.Checked = True
        End If


    End Sub

    Private Sub txtnumero_LostFocus(sender As Object, e As EventArgs) Handles txtnumero.LostFocus
        Dim ope = cmbt_ope.Text.Substring(0, 3)
        Dim serie = txtserie.Text
        Dim tipo = txtt_doc.Text
        Dim numero = txtnumero.Text
        Dim dtValidarDocumento As New DataTable
        dtValidarDocumento = ELPAGO_DOCUMENTOBL.VerificarNumeroDoc(ope, tipo, serie, numero)
        If dtValidarDocumento.Rows.Count > 0 Then
            MsgBox("Número de Documento Registrado", MsgBoxStyle.Exclamation)
            txtnumero.Select()
            Exit Sub
        Else
            dtpf_gene.Select()
        End If
    End Sub

    Private Sub btnProcesarAC_Click(sender As Object, e As EventArgs) Handles btnProcesarAC.Click
        Dim resp = MsgBox("Desea procesar Asientos Contables", MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If
        Dim dtAsientoCOntables As New DataTable
        dtAsientoCOntables = ELPAGO_DOCUMENTOBL.ContarMovctTemporal(cmbt_ope.Text.Substring(0, 3))
        If dtAsientoCOntables.Rows(0).ItemArray(0) > 0 Then
            ELPAGO_DOCUMENTOBL.ProcesarMovctTemporal(cmbt_ope.Text.Substring(0, 3))
            reporte = 1
            lblEstado.Text = "PROCESADO"
            lblEstado.ForeColor = Color.Blue
            MsgBox("Se procesaron los asientos contables", MsgBoxStyle.Exclamation)
        Else
            MsgBox("NO hay Asientos Contables para procesar", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub deleteData()
        Dim resp = MsgBox("Desea Eliminar DOcumento?", MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If
        Dim ELPAGO_DOCUMENTOBE As New ELPAGO_DOCUMENTOBE
        Dim ELPAGO_DET_DOCUMENTOBE As New ELPAGO_DET_DOCUMENTOBE
        ELPAGO_DOCUMENTOBE.t_ope = cmbt_ope.Text.Substring(0, 3)
        ELPAGO_DOCUMENTOBE.t_doc_ref = txtt_doc.Text
        ELPAGO_DOCUMENTOBE.ser_doc_ref = txtserie.Text
        ELPAGO_DOCUMENTOBE.nro_doc_ref = txtnumero.Text
        ELPAGO_DOCUMENTOBE.regcontable = txtregcontable.Text
        ELPAGO_DOCUMENTOBE.fec_gene = dtpf_gene.Value
        flagAccion = "E"

        gsError = ELPAGO_DOCUMENTOBL.SaveRow(ELPAGO_DOCUMENTOBE, flagAccion, dgvt_doc, ELPAGO_DET_DOCUMENTOBE)
        If gsError = "OK" Then
            MsgBox("Registro Eliminado Correctamente")
            Exit Sub
        End If
    End Sub
End Class