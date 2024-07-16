
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELDOCUMENTO

    Dim gpCaption As String
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private CUENTABANCOBL As New CUENTABANCOBL

    Private Sub FormELDOCUMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'txtcod.Enabled = F
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
                DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Sub DeleteData()
        'If MessageBox.Show("Esta seguro de Eliminar el Registro",
        '                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'Else
        '    flagAccion = "E"
        '    Dim ELDOCUMENTOBE As New ELDOCUMENTOBE

        '    If (cmbt_ope.SelectedIndex = 0) Then
        '        ELDOCUMENTOBE.t_ope = "010"
        '    Else
        '        ELDOCUMENTOBE.t_ope = "013"
        '    End If

        '    'ELLIB_CONTBE.cod = txtcod.Text
        '    gsError = ELDOCUMENTOBL.SaveRow(ELDOCUMENTOBE, flagAccion)
        '        If gsError = "OK" Then
        '            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
        '            Dispose()
        '        Else
        '            FormMain.LblError.Text = gsError
        '            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        '        End If
        '    End If
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELDOCUMENTOBE As New ELDOCUMENTOBE
                If (cmbt_ope.SelectedIndex = 0) Then
                    ELDOCUMENTOBE.t_ope = "010"
                Else
                    ELDOCUMENTOBE.t_ope = "013"
                End If
                ELDOCUMENTOBE.cbco_cod = txtcbco_cod.Text
                ELDOCUMENTOBE.t_doc_ref = txtt_doc_ref.Text
                ELDOCUMENTOBE.ser_doc_ref = txtser_doc_ref.Text
                ELDOCUMENTOBE.nro_doc_ref = txtnro_doc_ref.Text
                ELDOCUMENTOBE.fec_gene = dtpfec_gene.Value
                ELDOCUMENTOBE.proveedor = txtproveedor.Text
                ELDOCUMENTOBE.concepto = txtconcepto.Text
                ELDOCUMENTOBE.fec_pago = dtpfec_pago.Value
                ELDOCUMENTOBE.moneda = txtmoneda.Text
                ELDOCUMENTOBE.tprecio_compra = txttprecio_compra.Text
                ELDOCUMENTOBE.tprecio_dcompra = txttprecio_dcompra.Text
                ELDOCUMENTOBE.t_cambio = txtt_cambio.Text
                ELDOCUMENTOBE.nro_doc_ref1 = txtnro_doc_ref1.Text
                ELDOCUMENTOBE.tipo1 = cmbtipo1.SelectedItem.ToString.Substring(0, 1)

                gsError = ELDOCUMENTOBL.SaveRow(ELDOCUMENTOBE, flagAccion)
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

        If cmbt_ope.SelectedIndex = -1 Then
            MsgBox("Seleccione el Tipo de Operación", MsgBoxStyle.Exclamation)
            cmbt_ope.Focus()
            Return False
        End If

        If txtt_doc_ref.Text = "" Then
            MsgBox("Ingrese el Tipo de Documento", MsgBoxStyle.Exclamation)
            txtt_doc_ref.Focus()
            Return False
        End If

        If txtser_doc_ref.Text = "" Then
            MsgBox("Ingrese la Serie de Documento", MsgBoxStyle.Exclamation)
            txtt_doc_ref.Focus()
            Return False
        End If

        If txtnro_doc_ref.Text = "" Then
            MsgBox("Ingrese el Nro. de Documento", MsgBoxStyle.Exclamation)
            txtt_doc_ref.Focus()
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
        'txtcod.Text = ELLIB_CONTBL.SelectMaxLibro().PadLeft(2, "0")
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELDOCUMENTOBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows

            cmbt_ope.SelectedItem = IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))
            txtt_doc_ref.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            lbltipo.Text = IIf(IsDBNull(Registro("DESCRI_DOC")), "", Registro("DESCRI_DOC"))
            txtser_doc_ref.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnro_doc_ref.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            txtcbco_cod.Text = IIf(IsDBNull(Registro("CBCO_COD")), "", Registro("CBCO_COD"))
            txtnombanco.Text = IIf(IsDBNull(Registro("DESCRI_BAN")), "", Registro("DESCRI_BAN"))
            txtproveedor.Text = IIf(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            lblproveedor.Text = IIf(IsDBNull(Registro("PROVEE")), "", Registro("PROVEE"))
            txtconcepto.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtmoneda.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            lblmoneda.Text = IIf(IsDBNull(Registro("DESCRI_MON")), "", Registro("DESCRI_MON"))
            txttprecio_compra.Text = IIf(IsDBNull(Registro("TPRECIO_COMPRA")), "", Registro("TPRECIO_COMPRA"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), "", Registro("TPRECIO_DCOMPRA"))
            txtt_cambio.Text = IIf(IsDBNull(Registro("T_CAMBIO")), "", Registro("T_CAMBIO"))
            txtnro_doc_ref1.Text = IIf(IsDBNull(Registro("NRO_DOCU1")), "", Registro("NRO_DOCU1"))
            'Dim d As String = IIf(IsDBNull(Registro("ESTADO")), "", Registro("ESTADO"))
            cmbtipo1.SelectedItem = IIf(IsDBNull(Registro("ESTADO")), "", Registro("ESTADO"))
            dtpfec_gene.Value = Registro("FEC_GENE")
            dtpfec_pago.Value = Registro("FEC_PAGO")
        Next
    End Sub
    Private Sub txtcbco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcbco_cod.LostFocus
        If (txtcbco_cod.Text = "") Then
            txtnombanco.Text = ""
        Else
            Dim dt As DataTable
            dt = CUENTABANCOBL.SelectbancoCOD(txtcbco_cod.Text)
            If dt.Rows.Count > 0 Then
                txtcbco_cod.Text = dt.Rows(0).Item(0).ToString
                txtnombanco.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcbco_cod.Text = ""
                txtnombanco.Text = ""
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
                txtnombanco.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtt_doc_ref_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc_ref.LostFocus
        If (txtt_doc_ref.Text = "") Then
            lbltipo.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectTipodocCOD(txtt_doc_ref.Text)
            If dt.Rows.Count > 0 Then
                txtt_doc_ref.Text = dt.Rows(0).Item(0).ToString
                lbltipo.Text = dt.Rows(0).Item(1).ToString
            Else
                txtt_doc_ref.Text = ""
                lbltipo.Text = ""
            End If
        End If
    End Sub

    Private Sub txtt_doc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_doc_ref.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "96"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtt_doc_ref.Text = gLinea
                lbltipo.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtmoneda_LostFocus(sender As Object, e As EventArgs) Handles txtmoneda.LostFocus
        If (txtmoneda.Text = "") Then
            lblmoneda.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectMonCOD(txtmoneda.Text)
            If dt.Rows.Count > 0 Then
                txtmoneda.Text = dt.Rows(0).Item(0).ToString
                lblmoneda.Text = dt.Rows(0).Item(1).ToString
            Else
                txtmoneda.Text = ""
                lblmoneda.Text = ""
            End If
        End If
    End Sub

    Private Sub txtmoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmoneda.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "97"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtmoneda.Text = gLinea
                lblmoneda.Text = gSubLinea
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
    Private Sub txttprecio_compra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttprecio_compra.KeyPress, txttprecio_dcompra.KeyPress, txtt_cambio.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcbco_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcbco_cod.KeyPress, txtmoneda.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormELDOCUMENTO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class