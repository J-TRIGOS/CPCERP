
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELPAGO_DOCUMENTO

    Dim gpCaption As String
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private CUENTABANCOBL As New CUENTABANCOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELPAGO_DET_DOCUMENTOBE As New ELPAGO_DET_DOCUMENTOBE

    Private Sub ELPAGO_DOCUMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                Deshabilitar(False)
        End Select
    End Sub
    Sub Deshabilitar(ByVal F As Boolean)
        cmbt_ope.Enabled = F
        txtt_doc.Enabled = F
        txtserie.Enabled = F
        txtnumero.Enabled = F
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
            Case "delete"
                'DeleteData()
            Case "exit"
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
                Dim ELPAGO_DOCUMENTOBE As New ELPAGO_DOCUMENTOBE

                ELPAGO_DOCUMENTOBE.t_ope = cmbt_ope.SelectedItem.ToString.Substring(0, 3)
                ELPAGO_DOCUMENTOBE.t_doc_ref = txtt_doc.Text
                ELPAGO_DOCUMENTOBE.ser_doc_ref = txtserie.Text
                ELPAGO_DOCUMENTOBE.nro_doc_ref = txtnumero.Text
                ELPAGO_DOCUMENTOBE.fec_gene = dtpf_gene.Value
                ELPAGO_DOCUMENTOBE.cbco_cod = txtcbco_cod.Text
                ELPAGO_DOCUMENTOBE.moneda = txtmon.Text
                ELPAGO_DOCUMENTOBE.est1 = cmbest1.SelectedItem.ToString.Substring(0, 1)
                ELPAGO_DOCUMENTOBE.concepto = txtobserva.Text
                ELPAGO_DOCUMENTOBE.proveedor = txtproveedor.Text
                ELPAGO_DOCUMENTOBE.cco_cod = txtcco_cod.Text
                ELPAGO_DOCUMENTOBE.cobranza = cmbcobranza.SelectedItem.ToString.Substring(0, 2)
                ELPAGO_DOCUMENTOBE.tipo1 = cmbtipo1.SelectedItem.ToString.Substring(0, 1)
                ELPAGO_DOCUMENTOBE.reten = txtreten.Text
                ELPAGO_DOCUMENTOBE.porcentaje = txtporcentaje.Text
                ELPAGO_DOCUMENTOBE.totalsoles = lblSoles.Text
                ELPAGO_DOCUMENTOBE.totaldolar = lbldolares.Text

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

                If txtregcontable.Text = "" Then
                    ELPAGO_DOCUMENTOBE.regcontable = "0"
                Else
                    ELPAGO_DOCUMENTOBE.regcontable = txtregcontable.Text
                End If

                If txtpagoparcial.Text = "" Then
                    ELPAGO_DOCUMENTOBE.pagoparcial = "0"
                Else
                    ELPAGO_DOCUMENTOBE.pagoparcial = txtpagoparcial.Text
                End If

                gsError = ELPAGO_DOCUMENTOBL.SaveRow(ELPAGO_DOCUMENTOBE, flagAccion, dgvt_doc, ELPAGO_DET_DOCUMENTOBE)
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

        'If flagAccion = "N" Then
        '    If ELLIB_CONTBL.VerificarRepetido(txtcod.Text) = True Then
        '        MsgBox("El Codigo ya existe", MsgBoxStyle.Exclamation)
        '        Return False
        '    End If
        'End If

        Return True
    End Function
    Private Sub Limpiar()
        txtserie.Text = DateTime.Now.Year
        cmbtipo1.SelectedIndex = 1
        'txtserie.Text = "2040"
        cmbt_ope.SelectedIndex = 0
        cmbest1.SelectedIndex = 0
        cmbcobranza.SelectedIndex = 1
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim dtUsuario, Dtdetalle As DataTable
        Dim Registro As DataRow

        dtUsuario = ELPAGO_DOCUMENTOBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows

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
            txtregcontable.Text = IIf(IsDBNull(Registro("PORCENTAJE")), "", Registro("PORCENTAJE"))
            txtpagoparcial.Text = IIf(IsDBNull(Registro("PORCENTAJE")), "", Registro("PORCENTAJE"))
        Next

        ''
        Dtdetalle = ELPAGO_DOCUMENTOBL.SelectRowDetalle(sTDoc, sSDoc, sNDoc)
        For Each Detalle In Dtdetalle.Rows

            dgvt_doc.Rows.Add(IIf(IsDBNull(Detalle("T_DOC_REF1")), "", Detalle("T_DOC_REF1")),
                              IIf(IsDBNull(Detalle("SER_DOC_REF1")), "", Detalle("SER_DOC_REF1")),
                              IIf(IsDBNull(Detalle("NRO_DOC_REF1")), "", Detalle("NRO_DOC_REF1")),
                              IIf(IsDBNull(Detalle("STATUS")), "", Detalle("STATUS")),
                              IIf(IsDBNull(Detalle("CUENTA")), "", Detalle("CUENTA_DEST")),
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
                              IIf(IsDBNull(Detalle("NRO_DOCU1")), "", Detalle("NRO_DOCU1")))
        Next

        Actualizar()

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
            Else
                txtcbco_cod.Text = ""
                lblcbco.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcbco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcbco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "58"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcbco_cod.Text = gLinea
                lblcbco.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
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
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtproveedor_LostFocus(sender As Object, e As EventArgs) Handles txtproveedor.LostFocus
        If (txtproveedor.Text = "") Then
            lblproveedor.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectProveedorCOD(txtproveedor.Text)
            If dt.Rows.Count > 0 Then
                txtproveedor.Text = dt.Rows(0).Item(0).ToString
                lblproveedor.Text = dt.Rows(0).Item(1).ToString
            Else
                txtproveedor.Text = ""
                lblproveedor.Text = ""
            End If
        End If
    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "98"
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
    End Sub

    Private Sub txtcbco_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcbco_cod.KeyPress, txtmon.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRefConta
        frm.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        flagAccion1 = "N"
        Dim frm As New FormELPAGO_DETDOCUMENTO
        frm.ShowDialog()
        Actualizar()
    End Sub
    Sub Actualizar()
        Dim totalsoles As Double = 0
        Dim totaldolar As Double = 0
        For Each row As DataGridViewRow In dgvt_doc.Rows
            totalsoles = totalsoles + CDbl(row.Cells("T_Soles").Value)
            totaldolar = totaldolar + CDbl(row.Cells("T_Dolares").Value)
        Next

        lblSoles.Text = Format(Val(CDec(totalsoles)), "##,##0.00")
        lbldolares.Text = Format(Val(CDec(totaldolar)), "##,##0.00")
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
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

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

            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Mon").Value = "00" Then
                frm.txtsoles.Enabled = True
                frm.txtdolar.Enabled = False
            Else
                frm.txtsoles.Enabled = False
                frm.txtdolar.Enabled = True
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
                                  IIf(IsDBNull(row.Cells("O_COMPRA").Value), "", row.Cells("O_COMPRA").Value)) '16
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

End Class