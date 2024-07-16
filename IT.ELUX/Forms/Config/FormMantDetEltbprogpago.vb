Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail

Public Class FormMantDetEltbprogpago
    Dim ELTBPROGPAGOBL As New ELTBPROGPAGOBL
    Dim PROVISIONESBL As New PROVISIONESBL
    'Dim ELTBPROGPAGO As New ELTBPROGPAGO
    Public dtCompra As Double
    Public dtComprad As Double
    Public dtMoneda As String
    Public dtT_cmb As Double
    Public dtAfecto As String
    Public dtCuenta As String
    Public dtCDest As String
    Public dtReparacion As String
    Public dtObserva2 As String

    Private gpCaption As String
    Public nro As String


    Private Sub FormMantDetEltbprogpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim mesfecha As String
        Dim mesdia As String
        If gsCode11 = "" Then
            txtt_cambio.Text = dtT_cmb
            txtcuenta_dest.ReadOnly = True
            If FormMantELTBPROGPAGO.txtmon.Text = "00" Then
                'npdmonto_pagar.Text = dtCompra
                npdmontod_pagar.Enabled = False
                lblMoneda.Text = "Soles"
            Else
                'npdmontod_pagar.Text = dtComprad
                npdmonto_pagar.Enabled = False
                lblMoneda.Text = "Dolares"
            End If
            txtcuenta.Text = dtCuenta
            txtcuenta_dest.Text = dtCDest
            cmbafec.Text = dtAfecto
            If dtReparacion = "1" Then
                chkx_ret.Checked = True
            End If

            txtobserva2.Text = dtObserva2
        Else
            If Mid(dtpfecha.Text, 4, 2) = "1" Then
                mesfecha = "0" & Mid(dtpfecha.Text, 4, 2)
            Else
                mesfecha = Mid(dtpfecha.Text, 4, 2)
            End If
            If Mid(dtpfecha.Text, 1, 2) = "1" Then
                mesdia = "0" & Mid(dtpfecha.Text, 1, 2)
            Else
                mesdia = Mid(dtpfecha.Text, 1, 2)
            End If
            dt = PROVISIONESBL.getT_CAMB(Mid(dtpfecha.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
            For Each Registro In dt.Rows
                '    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                txtt_cambio.Text = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            Next
            If FormMantELTBPROGPAGO.txtmon.Text = "00" Then
                'npdmonto_pagar.Text = dtCompra
                npdmontod_pagar.Enabled = False
                lblMoneda.Text = "Soles"
            Else
                'npdmontod_pagar.Text = dtComprad
                npdmonto_pagar.Enabled = False
                lblMoneda.Text = "Dolares"
            End If
        End If
    End Sub

    Private Sub FormMantDetEltbprogpago_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If gsCode11 = "" Then
            gpCaption = "Guardar Cambios"
            If precios() = False Then
                Exit Sub
            End If
            If afecto() = False Then
                Exit Sub
            End If
            If dtAfecto <> Nothing Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("STATUS").Value = cmbafec.Text
            End If
            If txtcuenta.Text <> Nothing Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("CTA_CBCO").Value = txtcuenta.Text
            End If
            If txtcuenta_dest.Text <> Nothing Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("CTA_COD_DEST").Value = txtcuenta_dest.Text
            End If
            If npdmonto_pagar.Text <> Nothing Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("MONTO_PAGADO").Value = npdmonto_pagar.Text
            End If
            If npdmontod_pagar.Text <> Nothing Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("MONTO_DPAGADO").Value = npdmontod_pagar.Text
            End If
            FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("TPRECIO_COMPRA").Value = npdtprecio_compra.Text
            FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("TPRECIO_DCOMPRA").Value = npdpreciod_compra.Text
            If chkx_ret.Checked Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("X_RET").Value = "1"
            Else
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("X_RET").Value = ""
            End If
            If txtobserva2.Text <> Nothing Then
                FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("OBSERVA2").Value = txtobserva2.Text
            End If
            FormMantELTBPROGPAGO.dgvt_doc.Rows(nro).Cells("SIGNO").Value = cmbsigno.Text
            Dispose()
        Else
            Dim x_ret As String
            If chkx_ret.Checked = True Then
                x_ret = "1"
            Else
                x_ret = ""
            End If
            FormMantELTBPROGPAGO.dgvt_doc.Rows.Add(FormMantELTBPROGPAGO.txtt_doc.Text,
                                                   cmbafec.Text,
                                                   FormMantELTBPROGPAGO.cmb_serdoc.Text,
                                                   FormMantELTBPROGPAGO.txtnumero.Text,
                                                   txttdoc.Text,
                                                   txtsdoc.Text,
                                                   txtndoc.Text,
                                                   txtcuenta.Text,
                                                   txtcuenta_dest.Text,
                                                   FormMantELTBPROGPAGO.txtctct_cod.Text,
                                                   cmbsigno.Text,
                                                   FormMantELTBPROGPAGO.dtpfecha.Value,
                                                   txtt_cambio.Text,
                                                   FormMantELTBPROGPAGO.txtmon.Text,
                                                   0,
                                                   0,
                                                   0,
                                                   0,
                                                   txtobserva2.Text,
                                                   x_ret,
                                                   FormMantELTBPROGPAGO.dtpfec_prov.Value,
                                                   "",
                                                   "010",
                                                   gsUser,
                                                   "",
                                                   0,
                                                   "",
                                                   dtpfecha.Value,
                                                   "",
                                                   npdmonto_pagar.Value,
                                                   npdmontod_pagar.Value,
                                                   "")
            If FormMantELTBPROGPAGO.txtmon.Text = "00" Then
                If npdmonto_pagar.Value = 0 Then
                    npdmontod_pagar.Text = 0
                Else
                    npdmontod_pagar.Text = npdmonto_pagar.Text * txtt_cambio.Text
                End If
            Else
                If npdmontod_pagar.Value = 0 Then
                    npdmonto_pagar.Text = 0
                Else
                    npdmonto_pagar.Text = npdmonto_pagar.Text / txtt_cambio.Text
                End If
            End If
            Dispose()
        End If

    End Sub

    'Private Sub txttprecio_compra_ValueChanged(sender As Object, e As EventArgs) Handles npdmonto_pagar.ValueChanged
    '    If npdmonto_pagar.Text = 0 Then
    '        npdmonto_pagar.Text = 0
    '    Else
    '        npdmontod_pagar.Text = npdmonto_pagar.Text / dtT_cmb
    '    End If
    'End Sub

    'Private Sub txttprecio_dcompra_ValueChanged(sender As Object, e As EventArgs) Handles npdmontod_pagar.ValueChanged
    '    If npdmontod_pagar.Text = "" Then
    '        npdmontod_pagar.Text = "0"
    '    Else
    '        npdmonto_pagar.Text = npdmontod_pagar.Text * dtT_cmb
    '    End If
    'End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Function precios() As Boolean
        If dtMoneda = "00" Then
            If npdmonto_pagar.Value <> 0 Then
                If npdmonto_pagar.Value > npdtprecio_compra.Value Then
                    MsgBox("S/." + npdmonto_pagar.Value.ToString + " es Mayor a S/." + npdtprecio_compra.Value.ToString)
                    Return False
                End If
                If npdmonto_pagar.Value <> dtCompra Then
                    If MessageBox.Show("Esta seguro de modificar S/." + npdmonto_pagar.Value.ToString + " por S/" + npdtprecio_compra.Value.ToString,
            gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Return False
                    End If
                End If
            End If

        Else
            If npdmontod_pagar.Text <> dtComprad Then
                If npdmontod_pagar.Text > npdpreciod_compra.Text Then
                    MsgBox("$/." + npdmontod_pagar.Value + " es Mayor a $/." + npdpreciod_compra.Value)
                    Return False
                End If
                If MessageBox.Show("Esta seguro de modificar $/." + npdmontod_pagar.Value + " por $/" + npdmontod_pagar.Value,
                gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Return False
                End If
            End If
        End If
        Return True
    End Function
    Private Function afecto() As Boolean
        If cmbafec.SelectedIndex = 0 Then
            dtAfecto = "N"
        ElseIf cmbafec.SelectedIndex = 1 Then
            dtAfecto = "S"
        Else
            dtAfecto = ""
        End If
        Return True
    End Function
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
#Disable Warning BC42105
    End Function

    Private Sub txtcuenta_LostFocus(sender As Object, e As EventArgs) Handles txtcuenta.LostFocus
        'Dim Cdest As String
        'txtc_des.Text = ELTBPROGPAGOBL.SelectCuenta(FormMantELTBPROGPAGO.dtpfecha.Value.Year, txtcuenta.Text)
        If txtcuenta.Text = "" Then
            txtcuenta_dest.Text = ""
        Else
            txtcuenta_dest.Text = PROVISIONESBL.SelectCTA_OPE(Mid(FormMantELTBPROGPAGO.dtpfecha.Text, 7, 4), txtcuenta.Text)
        End If

        '    If Cdest > 0 Then              --- Actualizar 
        '        txtc_des.Text = Cdest
        '    ElseIf txtcuenta.Text = "" Then
        '        txtc_des.Text = ""
        '        Exit Sub
        '    Else
        '        MsgBox("La cuenta no existe")
        '        txtcuenta.Text = ""
        '        txtc_des.Text = ""
        '    End If
    End Sub

    Private Sub txtcuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcuenta.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "1" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "117"
            'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.medida = Mid(FormMantELTBPROGPAGO.dtpfecha.Text, 7, 4)
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txtcuenta.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub dtpfecha_LostFocus(sender As Object, e As EventArgs) Handles dtpfecha.LostFocus
        Dim dt As DataTable
        Dim mesfecha As String
        Dim mesdia As String
        If Mid(dtpfecha.Text, 4, 2) = "1" Then
            mesfecha = "0" & Mid(dtpfecha.Text, 4, 2)
        Else
            mesfecha = Mid(dtpfecha.Text, 4, 2)
        End If
        If Mid(dtpfecha.Text, 1, 2) = "1" Then
            mesdia = "0" & Mid(dtpfecha.Text, 1, 2)
        Else
            mesdia = Mid(dtpfecha.Text, 1, 2)
        End If
        dt = PROVISIONESBL.getT_CAMB(Mid(dtpfecha.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            '    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            txtt_cambio.Text = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
    End Sub

    Private Sub npdmonto_pagar_LostFocus(sender As Object, e As EventArgs) Handles npdmonto_pagar.LostFocus
        If npdmonto_pagar.Text = 0 Then
            npdmonto_pagar.Text = 0
        Else
            npdmontod_pagar.Text = npdmonto_pagar.Text / txtt_cambio.Text
        End If
    End Sub

    Private Sub npdmontod_pagar_LostFocus(sender As Object, e As EventArgs) Handles npdmontod_pagar.LostFocus
        If npdmontod_pagar.Text = 0 Then
            npdmontod_pagar.Text = 0
        Else
            npdmonto_pagar.Text = npdmontod_pagar.Text * txtt_cambio.Text
        End If
    End Sub

    Private Sub txttdoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txttdoc.KeyDown
        ' txtcuenta_dest.Text = ELTBPROGPAGOBL.SelectCTA_OPE(Mid(FormMantELTBPROGPAGO.dtpfecha.Text, 7, 4), txtcuenta.Text)
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "102"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txttdoc.Text = gLinea
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
    End Sub

    Private Sub txttdoc_LostFocus(sender As Object, e As EventArgs) Handles txttdoc.LostFocus
        If txttdoc.TextLength > 0 Then
            txttdoc.Text = PROVISIONESBL.SelectT_DOC_SEL(txttdoc.Text)
            txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txttdoc.Text)
        ElseIf txttdoc.TextLength = 0 Then
            txtnom_t_doc.Text = ""
        End If
    End Sub

End Class