Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTMerma
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL

    Private primero As Boolean
    Private primero2 As Boolean

    Private bprimero As Boolean

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub FormRPTMerma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radTodos.Checked = True
        ''     bprimero = True
        ''     Me.Text = "Reporte De Seguimiento de Movimientos de Ordenes de Porduccion"
        ''     'cmbaño.SelectedItem = sAño
        ''     Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        ''     dtpfec1.Value = dtFecha
        ''     Dim dt As DataTable
        ''     Dim item As ListViewItem
        ''     dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto1()
        ''     For Each row As DataRow In dt.Rows
        ''         item = lvccosto.Items.Add(IIf(IsDBNull(row("COD")), "", row("COD")))
        ''         item.SubItems.Add(IIf(IsDBNull(row("NOM")), "", row("NOM")))
        ''     Next
        ''     'cmbmes1.SelectedIndex = Month(Date.Today)
        ''     bprimero = False
        Dim dtFecha As Date
        dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpFecIni.Value = dtFecha

        primero = True
        primero2 = True
        'dtpFecIni.Value = "01/01/" + Year(Date.Now).ToString
        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)
        primero = False
        primero2 = False


    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Private Sub FormRPTMerma_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ''    Dim c As Integer = 0
        ''    Dim d As String = "0"
        ''    Dim s As String = ""
        ''    Dim t As String = ""
        ''    gsRptArgs = {}
        ''    For i = 0 To lvccosto.Items.Count - 1
        ''        If lvccosto.Items(i).Checked Then
        ''            c = c + 1
        ''        End If
        ''    Next
        ''    If c = 0 Then
        ''        ReDim gsRptArgs(4)
        ''        'gsRptArgs(0) = cmbaño.SelectedItem
        ''        'gsRptArgs(1) = s
        ''        gsRptArgs(0) = txtnumero.Text
        ''
        ''        If dtpfec1.Checked Then
        ''            gsRptArgs(1) = Format(dtpfec1.Value, "yyyy/MM/dd")
        ''        Else
        ''            gsRptArgs(1) = ""
        ''        End If
        ''        If dtpfec1.Checked Then
        ''            gsRptArgs(2) = Format(dtpfec2.Value, "yyyy/MM/dd")
        ''        Else
        ''            gsRptArgs(2) = ""
        ''        End If
        ''        gsRptArgs(3) = txtcodart.Text
        ''        If dtpfec1.Checked Then
        ''            gsRptArgs(4) = ""
        ''        Else
        ''            gsRptArgs(4) = cmbaño.Text
        ''        End If
        ''        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGMERMA_PRO.rpt"
        ''        gsRptPath = gsPathRpt
        ''        FormReportes.ShowDialog()
        ''
        ''        'Else
        ''        '    Dim sf1 As String = ""
        ''        '    Dim sf2 As String = ""
        ''        '    If dtpfec1.Checked Then
        ''        '        sf1 = Format(dtpfec1.Value, "yyyy/MM/dd")
        ''        '        sf2 = Format(dtpfec2.Value, "yyyy/MM/dd")
        ''        '    Else
        ''        '        sf1 = ""
        ''        '        sf2 = ""
        ''        '    End If
        ''        '    ELORDEN_PROGRAMBL.ReportePrograma("ESOP", cmbaño.SelectedItem, s, d.PadLeft(2, "0"), t, "", "")
        ''        '    For i = 0 To lvccosto.Items.Count - 1
        ''        '        If lvccosto.Items(i).Checked Then
        ''        '            ELORDEN_PROGRAMBL.ReportePrograma("SOP", txtnumero.Text, sf1, sf2, txtcodart.Text,
        ''        '                                              lvccosto.Items(i).SubItems(0).Text, cmbaño.Text)
        ''        '        End If
        ''        '    Next
        ''        '    'ReDim gsRptArgs()
        ''        '    dgvt_doc.DataSource = Nothing
        ''        '    dgvt_doc.DataSource = ELORDEN_PROGRAMBL.RPTSEGPRDORD()
        ''        '    If dgvt_doc.Rows.Count > 0 Then
        ''        '        For i = 0 To dgvt_doc.Rows.Count - 1
        ''        '            ELORDEN_PROGRAMBL.ReportePrograma("SOP1", dgvt_doc.Rows(i).Cells("numero").Value, "", "", "", "", "")
        ''        '        Next
        ''        '    End If
        ''        '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_ORD2.rpt"
        ''        '    gsRptPath = gsPathRpt
        ''        '    FormReportes.ShowDialog()
        ''    End If
    End Sub

    Private Sub dtpfec1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfec1.ValueChanged
        If dtpfec1.Checked Then
            dtpfec2.Enabled = True
            cmbaño.SelectedIndex = -1
            cmbaño.Enabled = False
        Else
            dtpfec2.Enabled = False
            cmbaño.Text = sAño
            cmbaño.Enabled = True
        End If
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F10 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart.Text = gLinea
                txtnomart.Text = gSubLinea
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
    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        ''    If txtcodart.TextLength > 0 Then
        ''        txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
        ''        'txtunidad.Text = ARTICULOBL.SelectUniMed(txtcodart.Text)
        ''    Else
        ''        txtcodart.Text = ""
        ''        txtnomart.Text = ""
        ''        'txtunidad.Text = ""
        ''    End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''      sBusAlm = "106"
        ''      Dim frm As New FormBUSQUEDA
        ''      frm.ShowDialog()
        ''      If gLinea <> Nothing And gSubLinea <> Nothing Then
        ''          txtcodart.Text = gLinea
        ''          txtnomart.Text = gSubLinea
        ''          gLinea = Nothing
        ''          gSubLinea = Nothing
        ''          gArt = Nothing
        ''      Else
        ''          gLinea = Nothing
        ''          gSubLinea = Nothing
        ''          gArt = Nothing
        ''      End If
    End Sub
    Private Sub txtnumero_LostFocus(sender As Object, e As EventArgs) Handles txtnumero.LostFocus
        ''     If txtnumero.TextLength = 0 Then
        ''         txtnumero.Text = ""
        ''     Else
        ''         txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
        ''     End If
    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged

        If primero Then Exit Sub
        Dim sCode As String = Mid(cmbLineas.SelectedValue, 1, 2)
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectDescripcion1(sCode)
        GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        txtLinea.Text = cmbLineas.SelectedValue


        'TextBox2.Text = cmbLineas.SelectedValue
        primero = False

    End Sub



    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles txtArtCod.Validated
        If primero2 Then Exit Sub

        If txtArtCod.Text = "" Then
            cmbArticulo.SelectedIndex = -1
            Exit Sub
        End If

        cmbLineas.SelectedValue = Mid(txtArtCod.Text, 1, 2) + "00"
        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If
        cmbSublineas.SelectedValue = Mid(txtArtCod.Text, 1, 4)
        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If
        cmbArticulo.SelectedValue = txtArtCod.Text
        gsCode = gsCode
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If primero Then Exit Sub
        txtArtCod.Text = cmbArticulo.SelectedValue
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmbLineas.SelectedValue = gLinea
            cmbSublineas.SelectedValue = gSubLinea
            cmbArticulo.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim pAREA As String = ""
        Dim plINEA1 As String = ""
        Dim plINEA2 As String = ""
        If OkData() = False Then
            Exit Sub
        End If

        If txtSubLin1.Text = "0230" Or txtSubLin1.Text = "0222" Or txtSubLin1.Text = "0218" Or txtSubLin1.Text = "0220" Or txtSubLin1.Text = "0217" Or txtSubLin1.Text = "0216" Or txtSubLin1.Text = "0219" Or txtSubLin1.Text = "0226" Or txtSubLin1.Text = "0227" Or txtSubLin1.Text = "0223" Or txtSubLin1.Text = "0225" Or txtSubLin1.Text = "0224" Then
            pAREA = "PT" 'PRODUCTO TERMINADO
        ElseIf txtSubLin1.Text = "0204" Or txtSubLin1.Text = "0213" Or txtSubLin1.Text = "0211" Or txtSubLin1.Text = "0229" Or txtSubLin1.Text = "0212" Or txtSubLin1.Text = "0228" Or txtSubLin1.Text = "0214" Then
            pAREA = "CT" 'CORTE
        ElseIf txtSubLin1.Text = "0310" Or txtSubLin1.Text = "0311" Or txtSubLin1.Text = "0312" Or txtSubLin1.Text = "0307" Or txtSubLin1.Text = "0301" Or txtSubLin1.Text = "0304" Then
            pAREA = "PR" 'PRENSA
        ElseIf txtSubLin1.Text = "0207" Or txtSubLin1.Text = "0210" Or txtSubLin1.Text = "0208" Then
            pAREA = "LT" 'LITOGRAFIA
        ElseIf txtSubLin1.Text = "0101" Or txtSubLin1.Text = "0102" Or txtSubLin1.Text = "1003" Or txtSubLin1.Text = "0104" Then
            pAREA = "FC" 'FIBRA CARTON
        ElseIf txtSubLin1.Text = "1003" Or txtSubLin1.Text = "1004" Then
            pAREA = "CN" 'CARTON
        ElseIf txtLinea.TextLength = 4 Then
            plINEA1 = "LINEA"
            plINEA2 = txtLinea.Text
        ElseIf txtSubLin2.TextLength = 4 Then
            'MsgBox("Sub Linea no esta agregado al reporte")
            Exit Sub
        End If

        If plINEA1 = "LINEA" Then
            gsRptArgs = {}
            ReDim gsRptArgs(9)
            gsRptArgs(0) = txtnumero.Text

            gsRptArgs(1) = Format(dtpFecIni.Value, "yyyy/MM/dd")
            gsRptArgs(2) = Format(dtpFecFin.Value, "yyyy/MM/dd")
            gsRptArgs(3) = txtArtCod.Text
            gsRptArgs(4) = Format(dtpFecIni.Value, "yyyy")
            gsRptArgs(5) = plINEA1
            gsRptArgs(6) = plINEA2
            If CheckBox1.Checked = True Then
                gsRptArgs(7) = "0"
            Else
                gsRptArgs(7) = ""
            End If
            gsRptArgs(8) = pAREA
            If radSi.Checked = True Then
                gsRptArgs(9) = 1
            End If
            If radNo.Checked = True Then
                gsRptArgs(9) = 0
            End If
            If radTodos.Checked = True Then
                gsRptArgs(9) = ""
            End If

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGMERMA_PRO_2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            gsRptArgs = {}
            ReDim gsRptArgs(9)
            gsRptArgs(0) = txtnumero.Text

            gsRptArgs(1) = Format(dtpFecIni.Value, "yyyy/MM/dd")
            gsRptArgs(2) = Format(dtpFecFin.Value, "yyyy/MM/dd")
            gsRptArgs(3) = txtArtCod.Text
            gsRptArgs(4) = Format(dtpFecIni.Value, "yyyy")
            gsRptArgs(5) = txtSubLin1.Text
            gsRptArgs(6) = txtSubLin2.Text
            If CheckBox1.Checked = True Then
                gsRptArgs(7) = "0"
            Else
                gsRptArgs(7) = ""
            End If
            gsRptArgs(8) = pAREA
            If radSi.Checked = True Then
                gsRptArgs(9) = 1
            End If
            If radNo.Checked = True Then
                gsRptArgs(9) = 0
            End If
            If radTodos.Checked = True Then
                gsRptArgs(9) = ""
            End If

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGMERMA_PRO_2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub
    Private Function OkData() As Boolean

        'If TextBox1.Text = "" Then
        '    MsgBox("Ingrese un Articulo", MsgBoxStyle.Exclamation)
        '    TextBox1.Focus()
        '    Return False
        'End If
        Return True
    End Function
    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles txtLinea.LostFocus
        If txtLinea.TextLength >= 2 Then

            If txtLinea.TextLength = 1 Then
                txtLinea.Text = txtLinea.Text & "000"
            ElseIf txtLinea.TextLength = 2 Then
                txtLinea.Text = txtLinea.Text & "00"
            ElseIf txtLinea.TextLength = 3 Then
                txtLinea.Text = txtLinea.Text & "0"
            End If
            cmbLineas.SelectedValue = txtLinea.Text 'ELTBLINESBL.SelectDescri(TextBox2.Text & "00")
        Else
            If cmbLineas.Text = "" Then
                txtLinea.Text = ""
            End If
        End If
    End Sub
    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles txtSubLin1.LostFocus

        If txtSubLin1.TextLength = 4 Then

            txtLinea.Text = txtSubLin1.Text.Substring(0, 2).Trim()
            TextBox2_LostFocus(sender, e)


            ''If TextBox4.Text = "" Then
            txtSubLin2.Text = txtSubLin1.Text
            TextBox4_LostFocus(sender, e)
            ''End If

            cmbSublineas.SelectedValue = txtSubLin1.Text

            If txtArtCod.Text <> Nothing Then
                If txtArtCod.Text.Substring(0, 4).Trim() = txtSubLin1.Text Then
                Else
                    txtArtCod.Text = ""
                    cmbArticulo.SelectedIndex = -1
                End If
            End If

                If cmbSublineas.Text = "" Then
                    txtLinea.Text = ""
                    cmbLineas.SelectedIndex = -1
                    txtSubLin1.Text = ""
                    cmbSublineas.SelectedIndex = -1
                End If
            Else
                cmbSublineas.SelectedValue = -1
            txtSubLin1.Text = ""
            txtSubLin2.Text = ""
            cmbSublineas2.SelectedIndex = -1
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub


    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        If primero Then Exit Sub
        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            GetCmb("COD", "art_descri", dt, cmbArticulo)
            txtSubLin1.Text = cmbSublineas.SelectedValue
            txtSubLin2.Text = cmbSublineas.SelectedValue
            dt = ARTICULOBL.SelectDescripcion1(sCode)
            GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas2)
            cmbSublineas2.SelectedValue = txtSubLin2.Text


            'TextBox2.Text = cmbLineas.SelectedValue
        ElseIf txtLinea.Text = Nothing Then
            MsgBox("La Sublinea no tiene articulos")
            cmbArticulo.DataSource = Nothing
        Else
            cmbArticulo.DataSource = Nothing
        End If

        primero = False
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles txtSubLin2.LostFocus

        If txtLinea.Text = "" And txtSubLin1.Text = "" And txtSubLin2.Text <> "" Then
            txtLinea.Text = txtSubLin2.Text.Substring(0, 2).Trim()
            TextBox2_LostFocus(sender, e)

            txtSubLin1.Text = txtSubLin2.Text
            TextBox3_LostFocus(sender, e)
        End If

        Dim sCode As String = txtLinea.Text
        Dim dt As New DataTable

        If txtSubLin2.TextLength = 4 Then
            'cmbSublineas2.SelectedValue = TextBox4.Text

            dt = ARTICULOBL.SelectDescripcion1(sCode)
            GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas2)
            cmbSublineas2.SelectedValue = txtSubLin2.Text

            If cmbSublineas2.Text = "" Then
                txtSubLin2.Text = ""
                cmbSublineas2.SelectedIndex = -1
            End If
        ElseIf txtSubLin1.TextLength = 4 Then
            dt = ARTICULOBL.SelectDescripcion1(sCode)
            GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas2)
            txtSubLin2.Text = txtSubLin1.Text
            cmbSublineas2.SelectedValue = txtSubLin1.Text
        Else
            cmbSublineas2.SelectedValue = -1
            txtSubLin2.Text = ""
        End If
    End Sub

    Private Sub txtLinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLinea.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSubLin1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubLin1.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSubLin2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubLin2.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtArtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArtCod.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub radSi_CheckedChanged(sender As Object, e As EventArgs) Handles radSi.CheckedChanged
        If radSi.Checked = True Then
            radNo.Checked = False
            radTodos.Checked = False
        End If
    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        If radNo.Checked = True Then
            radSi.Checked = False
            radTodos.Checked = False
        End If
    End Sub

    Private Sub radTodos_CheckedChanged(sender As Object, e As EventArgs) Handles radTodos.CheckedChanged
        If radTodos.Checked = True Then
            radSi.Checked = False
            radNo.Checked = False
        End If
    End Sub
End Class