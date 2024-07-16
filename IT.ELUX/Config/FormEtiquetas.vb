Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormEtiquetas
    Private ELETIQUETABL As New ELETIQUETABL
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private ARTICULOBL As New ARTICULOBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private CCOSTOBL As New CCOSTOBL
    Dim bprimero As String = False
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub FormEtiquetas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Etiquetas"
        cmbcalidad.SelectedIndex = 0
        cmb1.SelectedIndex = 0
        cmb2.SelectedIndex = 0
        cmb3.SelectedIndex = 0
        cmb4.SelectedIndex = 0
        cmbturnoTwo.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        Dim dt As DataTable = ELTBGRUPOBL.SearhPERCAL()
        GetCmb("cod", "nom", dt, cmbcal)
    End Sub

    Private Sub txtcliente1_LostFocus(sender As Object, e As EventArgs) Handles txtcliente1.LostFocus
        If (txtcliente1.Text = "") Then
            lblcliente1.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente1.Text)
            If dt.Rows.Count > 0 Then
                txtcliente1.Text = dt.Rows(0).Item(0).ToString
                lblcliente1.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcliente1.Text = ""
                lblcliente1.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcliente_LostFocus(sender As Object, e As EventArgs) Handles txtcliente.LostFocus
        If (txtcliente.Text = "") Then
            lblcliente.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente.Text)
            If dt.Rows.Count > 0 Then
                txtcliente.Text = dt.Rows(0).Item(0).ToString
                lblcliente.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcliente.Text = ""
                lblcliente.Text = ""
            End If
        End If
    End Sub

    Private Sub txtarticulo1_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo1.LostFocus
        If (txtarticulo1.Text = "") Then
            lblarticulo1.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtarticulo1.Text)
            If dt.Rows.Count > 0 Then
                txtarticulo1.Text = dt.Rows(0).Item(0).ToString
                lblarticulo1.Text = dt.Rows(0).Item(1).ToString
            Else
                txtarticulo1.Text = ""
                lblarticulo1.Text = ""
            End If
        End If
    End Sub

    Private Sub txtarticulo_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo.LostFocus
        If (txtarticulo.Text = "") Then
            lblarticulo.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtarticulo.Text)
            If dt.Rows.Count > 0 Then
                txtarticulo.Text = dt.Rows(0).Item(0).ToString
                lblarticulo.Text = dt.Rows(0).Item(1).ToString
            Else
                txtarticulo.Text = ""
                lblarticulo.Text = ""
            End If
        End If
    End Sub

    Private Sub txtarticulo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo1.KeyDown
        gCliente = txtcliente1.Text.Trim
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "114"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtarticulo1.Text = gLinea
                lblarticulo1.Text = gSubLinea
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.F10 Then
            sBusAlm = "115"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtarticulo1.Text = gLinea
                lblarticulo1.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcliente1.Text = gLinea
                lblcliente1.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub btnbuskar_Click(sender As Object, e As EventArgs) Handles btnbuskar.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcliente1.Text = gLinea
            lblcliente1.Text = gSubLinea
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub txtcliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcliente.Text = gLinea
                lblcliente.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub btnreportePro_Click(sender As Object, e As EventArgs) Handles btnreportePro.Click
        If gsUser = "LVERGARA" Then
            If txtarticulo1.Text = "" And cmbarticulo.Text = "" Then
                MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
                txtarticulo1.Focus()
            Else
                Cursor.Current = Cursors.WaitCursor
                If CheckBox1.Checked Then
                    If chkvis.Checked Then
                        ReDim gsRptArgs(13)
                        gsRptArgs(0) = txtcliente1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtart_venta.Text
                        gsRptArgs(4) = txtlote.Text
                        gsRptArgs(5) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(6) = txtcantenv.Text
                        gsRptArgs(7) = txtlinea.Text
                        gsRptArgs(8) = cmbturno.SelectedItem
                        gsRptArgs(9) = txtlogo.Text
                        gsRptArgs(10) = txtembalador.Text
                        gsRptArgs(11) = ""
                        gsRptArgs(12) = ""
                        gsRptArgs(13) = ""
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        ReDim gsRptArgs(13)
                        gsRptArgs(0) = txtcliente1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        'gsRptArgs(1) = txtarticulo1.Text
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtart_venta.Text
                        gsRptArgs(4) = txtlote.Text
                        gsRptArgs(5) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(6) = txtcantenv.Text
                        gsRptArgs(7) = txtlinea.Text
                        gsRptArgs(8) = cmbturno.SelectedItem
                        gsRptArgs(9) = txtlogo.Text
                        gsRptArgs(10) = txtembalador.Text
                        gsRptArgs(11) = ""
                        gsRptArgs(12) = ""
                        gsRptArgs(13) = ""
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_N_CANT.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    End If
                Else
                    If chkvis.Checked Then
                        ReDim gsRptArgs(14)
                        gsRptArgs(0) = txtcliente1.Text
                        'gsRptArgs(1) = txtarticulo1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtinicio.Text
                        gsRptArgs(4) = txtart_venta.Text
                        gsRptArgs(5) = txtlote.Text
                        gsRptArgs(6) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(7) = txtcantenv.Text
                        gsRptArgs(8) = txtlinea.Text
                        gsRptArgs(9) = cmbturno.SelectedItem
                        gsRptArgs(10) = txtlogo.Text
                        gsRptArgs(11) = txtembalador.Text
                        gsRptArgs(12) = ""
                        gsRptArgs(13) = ""
                        gsRptArgs(14) = ""
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA1.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        ReDim gsRptArgs(14)
                        gsRptArgs(0) = txtcliente1.Text
                        'gsRptArgs(1) = txtarticulo1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtinicio.Text
                        gsRptArgs(4) = txtart_venta.Text
                        gsRptArgs(5) = txtlote.Text
                        gsRptArgs(6) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(7) = txtcantenv.Text
                        gsRptArgs(8) = txtlinea.Text
                        gsRptArgs(9) = cmbturno.SelectedItem
                        gsRptArgs(10) = txtlogo.Text
                        gsRptArgs(11) = txtembalador.Text
                        gsRptArgs(12) = ""
                        gsRptArgs(13) = ""
                        gsRptArgs(14) = ""
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA1_N_CANT.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    End If
                End If
            End If
        Else
            If txtarticulo1.Text = "" And cmbarticulo.Text = "" Then
                MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
                txtarticulo1.Focus()
            Else
                Cursor.Current = Cursors.WaitCursor
                If CheckBox1.Checked Then
                    If chkvis.Checked Then
                        ReDim gsRptArgs(13)
                        gsRptArgs(0) = txtcliente1.Text
                        'gsRptArgs(1) = txtarticulo1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtart_venta.Text
                        gsRptArgs(4) = txtlote.Text
                        gsRptArgs(5) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(6) = txtcantenv.Text
                        gsRptArgs(7) = txtlinea.Text
                        gsRptArgs(8) = cmbturno.SelectedItem
                        gsRptArgs(9) = txtlogo.Text
                        gsRptArgs(10) = txtembalador.Text
                        gsRptArgs(11) = txtnro_orden.Text
                        gsRptArgs(12) = txtoc.Text
                        gsRptArgs(13) = txtcantot.Text
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETAX.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        ReDim gsRptArgs(13)
                        gsRptArgs(0) = txtcliente1.Text
                        'gsRptArgs(1) = txtarticulo1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtart_venta.Text
                        gsRptArgs(4) = txtlote.Text
                        gsRptArgs(5) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(6) = txtcantenv.Text
                        gsRptArgs(7) = txtlinea.Text
                        gsRptArgs(8) = cmbturno.SelectedItem
                        gsRptArgs(9) = txtlogo.Text
                        gsRptArgs(10) = txtembalador.Text
                        gsRptArgs(11) = txtnro_orden.Text
                        gsRptArgs(12) = txtoc.Text
                        gsRptArgs(13) = txtcantot.Text
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_N_CANTX.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    End If
                Else
                    If chkvis.Checked Then
                        ReDim gsRptArgs(14)
                        gsRptArgs(0) = txtcliente1.Text
                        'gsRptArgs(1) = txtarticulo1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtinicio.Text
                        gsRptArgs(4) = txtart_venta.Text
                        gsRptArgs(5) = txtlote.Text
                        gsRptArgs(6) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(7) = txtcantenv.Text
                        gsRptArgs(8) = txtlinea.Text
                        gsRptArgs(9) = cmbturno.SelectedItem
                        gsRptArgs(10) = txtlogo.Text
                        gsRptArgs(11) = txtembalador.Text
                        gsRptArgs(12) = txtnro_orden.Text
                        gsRptArgs(13) = txtoc.Text
                        gsRptArgs(14) = txtcantot.Text
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA1X.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        ReDim gsRptArgs(14)
                        gsRptArgs(0) = txtcliente1.Text
                        'gsRptArgs(1) = txtarticulo1.Text
                        If txtnro_orden.TextLength > 0 Then
                            gsRptArgs(1) = cmbarticulo.Text
                        Else
                            gsRptArgs(1) = txtarticulo1.Text
                        End If
                        gsRptArgs(2) = txtetiquetas.Text
                        gsRptArgs(3) = txtinicio.Text
                        gsRptArgs(4) = txtart_venta.Text
                        gsRptArgs(5) = txtlote.Text
                        gsRptArgs(6) = Format(dtpfec1.Value, "dd/MM/yyyy")
                        gsRptArgs(7) = txtcantenv.Text
                        gsRptArgs(8) = txtlinea.Text
                        gsRptArgs(9) = cmbturno.SelectedItem
                        gsRptArgs(10) = txtlogo.Text
                        gsRptArgs(11) = txtembalador.Text
                        gsRptArgs(12) = txtnro_orden.Text
                        gsRptArgs(13) = txtoc.Text
                        gsRptArgs(14) = txtcantot.Text
                        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA1_N_CANTX.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtinicio.Enabled = False
            txtinicio.Text = "1"
        Else
            txtinicio.Enabled = True
            txtinicio.Select()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtinicio1.Enabled = False
            txtinicio1.Text = "1"
        Else
            txtinicio1.Enabled = True
            txtinicio1.Select()
        End If
    End Sub

    '' ETIQUETAS DE TWO D
    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged, cmb2.SelectedIndexChanged, cmb3.SelectedIndexChanged, cmb4.SelectedIndexChanged

        Dim textcmb1, textcmb2, textcmb3, textcmb4, textcmb5 As String
        If cmb1.SelectedIndex = 0 Then
            textcmb1 = ""
        Else
            textcmb1 = cmb1.SelectedItem
        End If

        If cmb2.SelectedIndex = 0 Then
            textcmb2 = ""
        Else
            textcmb2 = cmb2.SelectedIndex.ToString.PadLeft(2, "0")
        End If

        If cmb3.SelectedIndex = 0 Then
            textcmb3 = ""
        Else
            textcmb3 = cmb3.SelectedItem
        End If

        If cmb4.SelectedIndex = 0 Then
            textcmb4 = ""
        Else
            textcmb4 = cmb4.SelectedItem
        End If

        If txt5.Text = "" Then
            textcmb5 = ""
        Else
            textcmb5 = txt5.Text
        End If

        txtlotenvase.Text = textcmb1 + textcmb2 + "-" + textcmb3 + textcmb4 + textcmb5

    End Sub

    Private Sub textcmb5_LostFocus(sender As Object, e As EventArgs) Handles txt5.LostFocus
        Dim textcmb1, textcmb2, textcmb3, textcmb4, textcmb5 As String
        If cmb1.SelectedIndex = 0 Then
            textcmb1 = ""
        Else
            textcmb1 = cmb1.SelectedItem
        End If

        If cmb2.SelectedIndex = 0 Then
            textcmb2 = ""
        Else
            textcmb2 = cmb2.SelectedIndex.ToString.PadLeft(2, "0")
        End If

        If cmb3.SelectedIndex = 0 Then
            textcmb3 = ""
        Else
            textcmb3 = cmb3.SelectedItem
        End If

        If cmb4.SelectedIndex = 0 Then
            textcmb4 = ""
        Else
            textcmb4 = cmb4.SelectedItem
        End If

        If txt5.Text = "" Then
            textcmb5 = ""
        Else
            textcmb5 = txt5.Text
        End If

        txtlotenvase.Text = textcmb1 + textcmb2 + "-" + textcmb3 + textcmb4 + textcmb5
    End Sub
    Private Sub GetDataTwo()
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELETIQUETABL.SelectRow_TWO("T")
        For Each Registro In dtUsuario.Rows
            txtarticulo.Text = IIf(IsDBNull(Registro("ARTICULO")), "", Registro("ARTICULO"))
            lblarticulo.Text = IIf(IsDBNull(Registro("ART_DES")), "", Registro("ART_DES"))
            txtcant.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
            txtfardo.Text = IIf(IsDBNull(Registro("MEDIDA")), "", Registro("MEDIDA"))
            txtcliente.Text = IIf(IsDBNull(Registro("CLIENTE")), "", Registro("CLIENTE"))
            lblcliente.Text = IIf(IsDBNull(Registro("NOMB_CLIE")), "", Registro("NOMB_CLIE"))

            cmb1.SelectedItem = Registro("LOTE_ENVASE").ToString.Substring(0, 2)
            cmb2.SelectedIndex = CInt(Registro("LOTE_ENVASE").ToString.Substring(2, 2))
            cmb3.SelectedItem = Registro("LOTE_ENVASE").ToString.Substring(5, 1)
            cmb4.SelectedItem = Registro("LOTE_ENVASE").ToString.Substring(6, 1)
            txt5.Text = Registro("LOTE_ENVASE").ToString.Substring(7, Registro("LOTE_ENVASE").ToString.Length - 7)
            txtlotenvase.Text = IIf(IsDBNull(Registro("LOTE_ENVASE")), "", Registro("LOTE_ENVASE"))

            dtpfec.Value = IIf(IsDBNull(Registro("FECHA_PRODUCCION")), "", Registro("FECHA_PRODUCCION"))
            txtembalador1.Text = IIf(IsDBNull(Registro("EMBALADOR")), "", Registro("EMBALADOR"))
            cmbturno.SelectedItem = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
        Next
    End Sub

    Private Function OkData() As Boolean

        If txtarticulo.Text = "" And cmbarticulo1.SelectedIndex = -1 Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
            txtarticulo.Focus()
            Return False
        End If

        If cmb1.SelectedIndex = 0 Then
            MsgBox("Ingrese la Cant. de Fardos", MsgBoxStyle.Exclamation)
            cmb1.Focus()
            Return False
        End If

        If cmb2.SelectedIndex = 0 Then
            MsgBox("Ingrese el Mes", MsgBoxStyle.Exclamation)
            cmb2.Focus()
            Return False
        End If
        If cmb3.SelectedIndex = 0 Then
            MsgBox("Ingrese la Cant. de Paquetes", MsgBoxStyle.Exclamation)
            cmb3.Focus()
            Return False
        End If
        If cmb4.SelectedIndex = 0 Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
            cmb4.Focus()
            Return False
        End If
        If txt5.Text = "" Then
            MsgBox("Ingrese el Cod. de Litografia", MsgBoxStyle.Exclamation)
            txt5.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub txtarticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "113"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtarticulo.Text = gLinea
                lblarticulo.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""

    End Sub

    Private Sub btnreporteT_Click(sender As Object, e As EventArgs) Handles btnreporteT.Click
        If OkData() = False Then
            Exit Sub
        Else
            ReDim gsRptArgs(14)
            gsRptArgs(0) = lblarticulo.Text
            gsRptArgs(1) = txtlotenvase.Text
            gsRptArgs(2) = txtfardo.Text
            gsRptArgs(3) = Format(dtpfec.Value, "dd/MM/yyyy")
            gsRptArgs(4) = txtcant.Text
            gsRptArgs(5) = txtetiquetastwo.Text
            gsRptArgs(6) = cmbturnoTwo.SelectedItem
            gsRptArgs(7) = txtembalador1.Text
            gsRptArgs(8) = cmbcalidad.SelectedItem
            gsRptArgs(9) = cmb4.SelectedItem
            If txtnro_orden1.Text = "" Then
                gsRptArgs(10) = txtarticulo.Text
            Else
                gsRptArgs(10) = cmbarticulo1.Text
            End If
            'gsRptArgs(10) = txtarticulo.Text
            gsRptArgs(11) = lblcliente.Text
            gsRptArgs(12) = CInt(txtinicio1.Text) - 1
            gsRptArgs(13) = txtoc1.Text
            gsRptArgs(14) = txtnro_orden1.Text
            If chknros.Checked = True Then
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_TWOX.rpt"
            Else
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_TWO2X.rpt"
            End If
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

            Dim ELETIQUETABE As New ELETIQUETABE

            ELETIQUETABE.articulo = txtarticulo.Text
            ELETIQUETABE.cantidad = txtcant.Text
            ELETIQUETABE.medida = txtfardo.Text
            ELETIQUETABE.lote = txtcant.Text
            ELETIQUETABE.fecha_produ = dtpfec.Value
            ELETIQUETABE.lote_envase = txtlotenvase.Text
            ELETIQUETABE.cod = ELETIQUETABL.SelectMaxTranspTwo()
            ELETIQUETABE.estado = "T"
            ELETIQUETABE.tipo = cmbturnoTwo.SelectedItem               'tipo
            ELETIQUETABE.cliente = txtcliente.Text                'cliente
            ELETIQUETABE.embalador = txtembalador1.Text         'embalador

            flagAccion = "N"
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                gsError = ELETIQUETABL.SaveRow(ELETIQUETABE, flagAccion)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
            'gsError = ELETIQUETABL.SaveRow(ELETIQUETABE, flagAccion)
            'If gsError = "OK" Then
            '    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Else
            '    FormMain.LblError.Text = gsError
            '    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            'End If

        End If
    End Sub

    Private Sub Tabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If (TabControl1.SelectedTab.Name = "TabPage1") Then
            'GetDataPro()
        ElseIf (TabControl1.SelectedTab.Name = "TabPage2") Then
            GetDataTwo()
        Else
            GetDataEns()
        End If

    End Sub

    Private Sub btnreporteE_Click(sender As Object, e As EventArgs) Handles btnreporteE.Click
        'If OkData() = False Then
        '    '  Exit Sub
        'Else
        ReDim gsRptArgs(14)
        gsRptArgs(0) = lblarticulo2.Text
        gsRptArgs(1) = txtlotenvase2.Text
        gsRptArgs(2) = txtfardo2.Text
        gsRptArgs(3) = Format(dtpfec2.Value, "dd/MM/yyyy")
        gsRptArgs(4) = txtcant2.Text
        gsRptArgs(5) = txtetiquetastwo2.Text
        gsRptArgs(6) = cmbturnoTwo2.SelectedItem
        gsRptArgs(7) = txtembalador12.Text
        gsRptArgs(8) = cmbcalidad2.Text
        gsRptArgs(9) = cmb4.SelectedItem
        gsRptArgs(10) = txtarticulo2.Text
        gsRptArgs(11) = lblcliente2.Text
        gsRptArgs(12) = CInt(txtinicio12.Text) - 1
        gsRptArgs(13) = ""
        gsRptArgs(14) = ""

        If CheckBox4.Checked = True Then
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_ENSAMX.rpt"
        Else
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_ENSAM2X.rpt"
        End If
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

        Dim ELETIQUETABE As New ELETIQUETABE

        ELETIQUETABE.articulo = txtarticulo2.Text
        ELETIQUETABE.cantidad = txtcant2.Text
        ELETIQUETABE.medida = txtfardo2.Text
        ELETIQUETABE.lote = txtcant2.Text
        ELETIQUETABE.fecha_produ = dtpfec2.Value
        ELETIQUETABE.lote_envase = txtlotenvase2.Text
        ELETIQUETABE.cod = ELETIQUETABL.SelectMaxTranspEns()
        ELETIQUETABE.estado = "E"
        ELETIQUETABE.tipo = cmbturnoTwo2.SelectedItem               'tipo
        ELETIQUETABE.cliente = txtcliente2.Text                'cliente
        ELETIQUETABE.embalador = txtembalador12.Text         'embalador

        flagAccion = "N"
        gsError = ELETIQUETABL.SaveRow(ELETIQUETABE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

        'End If
    End Sub

    Private Sub txtarticulo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo2.KeyDown
        gCliente = txtcliente2.Text.Trim
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "114"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtarticulo2.Text = gLinea
                lblarticulo2.Text = gSubLinea
            End If
            e.Handled = True
        End If
        If e.KeyValue = Keys.F10 Then
            sBusAlm = "115"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtarticulo2.Text = gLinea
                lblarticulo2.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcliente2.Text = gLinea
                lblcliente2.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub
    Private Sub txtcliente3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcliente3.Text = gLinea
                lblcliente3.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub
    Private Sub txtcliente2_LostFocus(sender As Object, e As EventArgs) Handles txtcliente2.LostFocus
        If (txtcliente2.Text = "") Then
            lblcliente2.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente2.Text)
            If dt.Rows.Count > 0 Then
                txtcliente2.Text = dt.Rows(0).Item(0).ToString
                lblcliente2.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcliente2.Text = ""
                lblcliente2.Text = ""
            End If
        End If
    End Sub
    Private Sub txtcliente3_LostFocus(sender As Object, e As EventArgs) Handles txtcliente3.LostFocus
        If (txtcliente3.Text = "") Then
            lblcliente3.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente3.Text)
            If dt.Rows.Count > 0 Then
                txtcliente3.Text = dt.Rows(0).Item(0).ToString
                lblcliente3.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcliente3.Text = ""
                lblcliente3.Text = ""
            End If
        End If
    End Sub
    Private Sub txtarticulo2_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo2.LostFocus
        If (txtarticulo2.Text = "") Then
            lblarticulo2.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtarticulo2.Text)
            If dt.Rows.Count > 0 Then
                txtarticulo2.Text = dt.Rows(0).Item(0).ToString
                lblarticulo2.Text = dt.Rows(0).Item(1).ToString
            Else
                txtarticulo2.Text = ""
                lblarticulo2.Text = ""
            End If
        End If
    End Sub
    Private Sub txtarticulo3_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo3.LostFocus
        If (txtarticulo3.Text = "") Then
            lblarticulo3.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtarticulo3.Text)
            If dt.Rows.Count > 0 Then
                txtarticulo3.Text = dt.Rows(0).Item(0).ToString
                lblarticulo3.Text = dt.Rows(0).Item(1).ToString
            Else
                txtarticulo3.Text = ""
                lblarticulo3.Text = ""
            End If
        End If
    End Sub

    Private Sub GetDataEns()
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELETIQUETABL.SelectRow_TWO("E")
        For Each Registro In dtUsuario.Rows
            txtarticulo2.Text = IIf(IsDBNull(Registro("ARTICULO")), "", Registro("ARTICULO"))
            lblarticulo2.Text = IIf(IsDBNull(Registro("ART_DES")), "", Registro("ART_DES"))
            txtcant2.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
            txtfardo2.Text = IIf(IsDBNull(Registro("MEDIDA")), "", Registro("MEDIDA"))
            txtcliente2.Text = IIf(IsDBNull(Registro("CLIENTE")), "", Registro("CLIENTE"))
            lblcliente2.Text = IIf(IsDBNull(Registro("NOMB_CLIE")), "", Registro("NOMB_CLIE"))

            'cmb12.SelectedItem = Registro("LOTE_ENVASE").ToString.Substring(0, 2)
            'cmb22.SelectedIndex = CInt(Registro("LOTE_ENVASE").ToString.Substring(2, 2))
            'cmb32.SelectedItem = Registro("LOTE_ENVASE").ToString.Substring(5, 1)
            'cmb42.SelectedItem = Registro("LOTE_ENVASE").ToString.Substring(6, 1)
            'txt52.Text = Registro("LOTE_ENVASE").ToString.Substring(7, 5)
            txtlotenvase2.Text = IIf(IsDBNull(Registro("LOTE_ENVASE")), "", Registro("LOTE_ENVASE"))

            dtpfec2.Value = IIf(IsDBNull(Registro("FECHA_PRODUCCION")), "", Registro("FECHA_PRODUCCION"))
            txtembalador12.Text = IIf(IsDBNull(Registro("EMBALADOR")), "", Registro("EMBALADOR"))
            cmbturnoTwo2.SelectedItem = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcliente2.Text = gLinea
            lblcliente2.Text = gSubLinea
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cmblugar.SelectedIndex = -1 Then
            MsgBox("Seleccione un lugar")
            Exit Sub
        End If
        ReDim gsRptArgs(2)
        gsRptArgs(0) = npdcantidad4.Value
        If cmblugar.SelectedIndex = 1 Then
            gsRptArgs(1) = "2"
        Else
            gsRptArgs(1) = "1"
        End If
        gsRptArgs(2) = npdinicio4.Value
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_MIGUEL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReDim gsRptArgs(14)
        gsRptArgs(0) = lblarticulo.Text
        gsRptArgs(1) = txtlotenvase.Text
        gsRptArgs(2) = txtfardo.Text
        gsRptArgs(3) = Format(dtpfec.Value, "dd/MM/yyyy")
        gsRptArgs(4) = txtcant.Text
        gsRptArgs(5) = txtetiquetastwo.Text
        gsRptArgs(6) = cmbturnoTwo.SelectedItem
        gsRptArgs(7) = txtembalador1.Text
        gsRptArgs(8) = cmbcalidad.SelectedItem
        gsRptArgs(9) = cmb4.SelectedItem
        If txtnro_orden1.Text = "" Then
            gsRptArgs(10) = txtarticulo.Text
        Else
            gsRptArgs(10) = cmbarticulo1.Text
        End If

        gsRptArgs(11) = lblcliente.Text
        gsRptArgs(12) = CInt(txtinicio1.Text) - 1
        gsRptArgs(13) = txtoc1.Text
        gsRptArgs(14) = txtnro_orden1.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_TWOXPK.rpt"
        'Else
        '    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_TWO2.rpt"
        'End If
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "238"
        Dim dt As New DataTable
        Dim frm As New FormBUSQUEDA
        bprimero = True
        frm.ShowDialog()
        'cmbarticulo = Nothing
        If (gLinea <> Nothing) Then
            txtnro_orden.Text = gLinea
            txtcliente1.Text = gSubLinea
            dt = ORDENCOMPRABL.ArtNro(txtnro_orden.Text)
            GetCmb("COD", "NOM", dt, cmbarticulo)
            lblarticulo1.Text = ""
            txtoc.Text = ORDENCOMPRABL.FecProv(txtnro_orden.Text)
            ' txtoc.Text = dt.Rows(0).Item(1).ToString
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente1.Text)
            lblcliente1.Text = dt.Rows(0).Item(1).ToString
            txtcliente1.Enabled = False
            cmbarticulo.Visible = True
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            cmbarticulo.Visible = False
            txtcliente1.Enabled = True
            gLinea = Nothing
            gSubLinea = Nothing
        End If
        bprimero = False
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        sBusAlm = "238"
        Dim dt As New DataTable
        Dim frm As New FormBUSQUEDA
        bprimero = True
        frm.ShowDialog()
        'cmbarticulo = Nothing
        If (gLinea <> Nothing) Then
            txtnro_orden1.Text = gLinea
            txtcliente.Text = gSubLinea
            dt = ORDENCOMPRABL.ArtNro(txtnro_orden1.Text)
            GetCmb("COD", "NOM", dt, cmbarticulo1)
            lblarticulo.Text = ""
            txtoc1.Text = ORDENCOMPRABL.FecProv(txtnro_orden1.Text)
            ' txtoc.Text = dt.Rows(0).Item(1).ToString
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente.Text)
            lblcliente.Text = dt.Rows(0).Item(1).ToString
            txtcliente.Enabled = False
            cmbarticulo1.Visible = True
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            cmbarticulo1.Visible = False
            txtcliente.Enabled = True
            gLinea = Nothing
            gSubLinea = Nothing
        End If
        bprimero = False
    End Sub
    Private Sub txtnro_orden_LostFocus(sender As Object, e As EventArgs) Handles txtnro_orden.LostFocus
        Dim dt As New DataTable
        If txtnro_orden.TextLength = 0 Then
            cmbarticulo.SelectedIndex = -1
            cmbarticulo.Visible = False
            txtcliente1.Enabled = True
            txtarticulo1.Text = ""
            cmbarticulo.SelectedIndex = -1
            lblarticulo1.Text = ""
            lblcliente1.Text = ""
            txtcliente1.Text = ""
        Else
            txtnro_orden.Text = txtnro_orden.Text.PadLeft(7, "0")
            txtcliente1.Text = ORDENCOMPRABL.SelProv(txtnro_orden.Text)
            lblcliente1.Text = PROVISIONESBL.SelectT_Prov(txtcliente1.Text)
            dt = ORDENCOMPRABL.ArtNro(txtnro_orden.Text)
            GetCmb("COD", "NOM", dt, cmbarticulo)
            lblarticulo1.Text = ""
            txtoc.Text = ORDENCOMPRABL.FecProv(txtnro_orden.Text)
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente1.Text)
            lblcliente1.Text = dt.Rows(0).Item(1).ToString
            txtcliente1.Enabled = False
            cmbarticulo.Visible = True
            'cmbarticulo.Visible = True
        End If

    End Sub

    Private Sub txtnro_orden3_LostFocus(sender As Object, e As EventArgs) Handles txtnro_orden3.LostFocus
        Dim dt As New DataTable
        If txtnro_orden3.TextLength = 0 Then
            cmbarticulo3.SelectedIndex = -1
            cmbarticulo3.Visible = False
            txtcliente3.Enabled = True
            txtarticulo3.Text = ""
            cmbarticulo.SelectedIndex = -1
            lblarticulo3.Text = ""
            lblcliente3.Text = ""
            txtcliente3.Text = ""
        Else
            txtnro_orden3.Text = txtnro_orden3.Text.PadLeft(7, "0")
            txtcliente3.Text = ORDENCOMPRABL.SelProv(txtnro_orden3.Text)
            lblcliente3.Text = PROVISIONESBL.SelectT_Prov(txtcliente3.Text)
            dt = ORDENCOMPRABL.ArtNro(txtnro_orden3.Text)
            GetCmb("COD", "NOM", dt, cmbarticulo3)
            lblarticulo3.Text = ""
            txtoc3.Text = ORDENCOMPRABL.FecProv(txtnro_orden3.Text)
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente3.Text)
            lblcliente3.Text = dt.Rows(0).Item(1).ToString
            txtcliente3.Enabled = False
            cmbarticulo3.Visible = True
        End If

    End Sub
    Private Sub txtnro_orden1_LostFocus(sender As Object, e As EventArgs) Handles txtnro_orden1.LostFocus
        Dim dt As New DataTable
        If txtnro_orden1.TextLength = 0 Then
            cmbarticulo1.SelectedIndex = -1
            cmbarticulo1.Visible = False
            txtcliente.Enabled = True
            txtarticulo.Text = ""
            cmbarticulo.SelectedIndex = -1
            lblarticulo.Text = ""
            lblcliente.Text = ""
            txtcliente.Text = ""
        Else
            Try
                txtnro_orden1.Text = txtnro_orden1.Text.PadLeft(7, "0")
                txtcliente.Text = ORDENCOMPRABL.SelProv(txtnro_orden1.Text)
                lblcliente.Text = PROVISIONESBL.SelectT_Prov(txtcliente.Text)
                dt = ORDENCOMPRABL.ArtNro(txtnro_orden1.Text)
                GetCmb("COD", "NOM", dt, cmbarticulo1)
                lblarticulo.Text = ""
                txtoc1.Text = ORDENCOMPRABL.FecProv(txtnro_orden1.Text)
                dt = ELETIQUETABL.SelectClienteCOD(txtcliente.Text)
                lblcliente.Text = dt.Rows(0).Item(1).ToString
                txtcliente.Enabled = False
                cmbarticulo1.Visible = True
            Catch ex As Exception
                MsgBox("No existe la Orden de Compra")
            End Try

        End If

    End Sub
    Private Sub cmbarticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        lblarticulo1.Text = ARTICULOBL.SelectArt2(Trim(cmbarticulo.Text))
        txtcantot.Text = ORDENCOMPRABL.SelCantOT(txtnro_orden.Text, cmbarticulo.Text)
    End Sub

    Private Sub cmbarticulo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulo1.SelectedIndexChanged
        lblarticulo.Text = ARTICULOBL.SelectArt2(Trim(cmbarticulo1.Text))
    End Sub

    Private Sub cmbarticulo3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulo3.SelectedIndexChanged
        lblarticulo3.Text = ARTICULOBL.SelectArt2(Trim(cmbarticulo3.Text))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtnro_orden.Text = ""
        txtarticulo1.Text = ""
        lblarticulo1.Text = ""
        txtcliente1.Text = ""
        lblcliente1.Text = ""
        txtcliente1.Enabled = True
        cmbarticulo.Visible = False
        txtoc3.Text = ""
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "15"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcliente1.Text = gLinea
            lblcliente1.Text = gSubLinea
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtnro_orden3.Text = ""
        txtarticulo3.Text = ""
        lblarticulo3.Text = ""
        txtcliente3.Text = ""
        lblcliente3.Text = ""
        txtcliente3.Enabled = True
        cmbarticulo3.Visible = False
        txtoc3.Text = ""
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            txtinicio3.Enabled = False
            txtinicio3.Text = "1"
        Else
            txtinicio3.Enabled = True
            txtinicio3.Select()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If txtarticulo3.Text = "" And cmbarticulo3.Text = "" Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
            txtarticulo1.Focus()
        Else
            Cursor.Current = Cursors.WaitCursor
            If CheckBox1.Checked Then
                ReDim gsRptArgs(16)
                If txtnro_orden3.TextLength > 0 Then
                    gsRptArgs(0) = cmbarticulo3.Text
                Else
                    gsRptArgs(0) = txtarticulo3.Text
                End If
                gsRptArgs(1) = txtoc3.Text
                gsRptArgs(2) = txtlote3.Text
                gsRptArgs(3) = Format(dtpfec3.Value, "dd/MM/yyyy")
                gsRptArgs(4) = npdcajas.Value
                gsRptArgs(5) = txtarea3.Text
                gsRptArgs(6) = txtnomsup.Text
                gsRptArgs(7) = txtcodempacador.Text
                gsRptArgs(8) = txtcantenv3.Value
                gsRptArgs(9) = txtetiquetas3.Value
                gsRptArgs(10) = cmbcal.Text
                gsRptArgs(11) = Format(dtpfecvb.Value, "dd/MM/yyyy")
                gsRptArgs(12) = txtnro_orden3.Text
                gsRptArgs(13) = txtncopias3.Value
                gsRptArgs(14) = lblcliente3.Text
                gsRptArgs(15) = txtproduccion.Text
                gsRptArgs(16) = txtfardo3.Text
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETAALBARAM.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Else
                ReDim gsRptArgs(13)
                gsRptArgs(0) = txtcliente1.Text
                'gsRptArgs(1) = txtarticulo1.Text
                If txtnro_orden.TextLength > 0 Then
                    gsRptArgs(1) = cmbarticulo.Text
                Else
                    gsRptArgs(1) = txtarticulo1.Text
                End If
                gsRptArgs(2) = txtetiquetas.Text
                gsRptArgs(3) = txtinicio.Text
                gsRptArgs(4) = txtart_venta.Text
                gsRptArgs(5) = txtlote.Text
                gsRptArgs(6) = Format(dtpfec1.Value, "dd/MM/yyyy")
                gsRptArgs(7) = txtcantenv.Text
                gsRptArgs(8) = txtlinea.Text
                gsRptArgs(9) = cmbturno.SelectedItem
                gsRptArgs(10) = txtlogo.Text
                gsRptArgs(11) = txtembalador.Text
                gsRptArgs(12) = ""
                gsRptArgs(13) = ""
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA1_N_CANT.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        sBusAlm = "239"
        Dim dt As New DataTable
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'cmbarticulo = Nothing
        If (gLinea <> Nothing) Then
            txtsupervisor.Text = gLinea
            txtnomsup.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sBusAlm = "238"
        Dim dt As New DataTable
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'cmbarticulo = Nothing
        If (gLinea <> Nothing) Then
            txtnro_orden3.Text = gLinea
            txtcliente3.Text = gSubLinea
            dt = ORDENCOMPRABL.ArtNro(txtnro_orden3.Text)
            GetCmb("COD", "NOM", dt, cmbarticulo3)
            lblarticulo3.Text = ""
            txtoc3.Text = ORDENCOMPRABL.FecProv(txtnro_orden3.Text)
            ' txtoc.Text = dt.Rows(0).Item(1).ToString
            dt = ELETIQUETABL.SelectClienteCOD(txtcliente3.Text)
            lblcliente3.Text = dt.Rows(0).Item(1).ToString
            txtcliente3.Enabled = False
            cmbarticulo3.Visible = True
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            cmbarticulo3.Visible = False
            txtcliente3.Enabled = True
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtnro_orden1.Text = ""
        txtarticulo.Text = ""
        lblarticulo.Text = ""
        txtcliente.Text = ""
        lblcliente.Text = ""
        txtcliente.Enabled = True
        cmbarticulo1.Visible = False
        txtoc1.Text = ""
    End Sub

    Private Sub dtpfec3_LostFocus(sender As Object, e As EventArgs) Handles dtpfec3.LostFocus
        dtpfecvb.Value = dtpfec3.Value
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If txtsublinea.Text = "" And txtcodartact.Text = "" And txtc_costo.Text = "" Then
            MsgBox("Ingrese el Articulo de Activo", MsgBoxStyle.Exclamation)
            txtarticulo1.Focus()
        Else
            Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(3)
            gsRptArgs(0) = dtpfecactivo.Text
            gsRptArgs(1) = txtsublinea.Text
            gsRptArgs(2) = txtcodartact.Text
            gsRptArgs(3) = txtc_costo.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETAACTIVO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub txtsublinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "249"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtsublinea.Text = gLinea
                txtnomsublinea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcodartact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodartact.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "120"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gArt <> Nothing And gSubLinea <> Nothing Then
                txtcodartact.Text = gArt
                txtnomartact.Text = gSubLinea
                'txtstock.Text = ARTICULOBL.SetStock(txtactivo.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub txtcodartact_LostFocus(sender As Object, e As EventArgs) Handles txtcodartact.LostFocus
        If txtcodartact.TextLength = 0 Then
            txtnomartact.Text = ""
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
        Else
            If txtcodartact.TextLength > 0 And txtcodartact.TextLength < 8 Then
                txtnomartact.Text = ""
                txtcodartact.Text = ""
                MsgBox("Codigo de Activo invalido")
                Exit Sub
            End If
            txtsublinea.Text = Mid(txtcodartact.Text, 1, 4)
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
        End If
    End Sub

    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
        Else
            txtnomsublinea.Text = ""
        End If
    End Sub
    Private Sub txtc_costo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtc_costo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "29"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtc_costo.Text = gLinea
                txtnom_ccosto.Text = CCOSTOBL.SelectNom(txtc_costo.Text)
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.TextLength > 2 Then
            txtnom_ccosto.Text = CCOSTOBL.SelectNom(txtc_costo.Text)
        Else
            txtnom_ccosto.Text = ""
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcliente5.Text = gLinea
            lblcliente5.Text = gSubLinea
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ReDim gsRptArgs(13)
        gsRptArgs(0) = txttexto.Text
        gsRptArgs(1) = txtlote5.Text
        gsRptArgs(2) = txtfardo5.Text
        gsRptArgs(3) = Format(dtpfec5.Value, "dd/MM/yyyy")
        gsRptArgs(4) = txtcantenv5.Text
        gsRptArgs(5) = txtetiquetas5.Text
        gsRptArgs(6) = cmbturno.SelectedItem
        gsRptArgs(7) = txtembalador5.Text
        gsRptArgs(8) = ""
        gsRptArgs(9) = txtlinea5.Text
        gsRptArgs(10) = lblcliente5.Text
        gsRptArgs(11) = txtinicio5.Text
        gsRptArgs(12) = ""
        gsRptArgs(13) = ""

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_SINART.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ReDim gsRptArgs(0)
        gsRptArgs(0) = npdcnetiqueta.Value
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_INVENTARIO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class