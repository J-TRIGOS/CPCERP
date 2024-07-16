Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRepProdAll
    Private ELTBLINESBL As New ELTBLINESBL
    Private ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormReporteProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFecha As Date
        bPrimero = True
        dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        Dim dt As DataTable = ARTICULOBL.getListcmb13()
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = ARTICULOBL.getListcmb13()
        GetCmb("cod", "nom", dt, cmbc_costo3)
        If sOp = "0" Then
            Me.Text = "Reporte Produccion"
            dtpfecini.Value = dtFecha
            TabPage3.Enabled = False
            TabPage4.Enabled = False
        ElseIf sOp = "1" Then
            'txtuserrep.Enabled = False
            'Button1.Enabled = False
            'txtlinea1.Enabled = False
            Button7.Enabled = False
            Me.Text = "Reporte Control Productividad"
            'dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
            dtpfecini.Value = dtFecha
            dtpfecini3.Value = dtFecha
            dtpfecini4.Value = dtFecha
        End If
        'dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfecha3.Value = dtFecha
        bPrimero = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRepProdAll_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "20"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If sOp = "0" Then

            gsRptArgs = {}
            ReDim gsRptArgs(10)
            gsRptArgs(0) = Format(dtpfecini.Value, "yyyy/MM/dd")
            gsRptArgs(1) = Format(dtpfecfin.Value, "yyyy/MM/dd")
            If cmbest.SelectedIndex <> -1 Then
                gsRptArgs(2) = cmbest.SelectedText
            Else
                gsRptArgs(2) = ""
            End If
            If cmbestdoc.SelectedIndex = 1 Then
                gsRptArgs(3) = "0"
            ElseIf cmbestdoc.SelectedIndex = 2 Then
                gsRptArgs(3) = "1"
            ElseIf cmbestdoc.SelectedIndex = 3 Then
                gsRptArgs(3) = "2"
            ElseIf cmbestdoc.SelectedIndex = 4 Then
                gsRptArgs(3) = "3"
            End If
            gsRptArgs(4) = txtuserrep.Text
            gsRptArgs(5) = txtarticulo1.Text
            'If txtsublinea.TextLength = "4" Then
            gsRptArgs(6) = txtsublinea.Text
            gsRptArgs(7) = txtlote.Text
            gsRptArgs(8) = txtfardo.Text
            gsRptArgs(9) = txtsublinea2.Text
            If txtnro_orden.TextLength > 0 And cmbser_orden.SelectedIndex > -1 Then
                gsRptArgs(10) = cmbser_orden.Text & "-" & txtnro_orden.Text
            Else
                gsRptArgs(10) = ""
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PRODUCCION_RP_ALL1.rpt"
                'Else
                '    'gsRptArgs(6) = txtlinea.Text
                '    gsRptArgs(7) = txtlote.Text
                '    gsRptArgs(8) = txtfardo.Text
                '    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PRODUCCION_RP_ALL.rpt"
                'End If

                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            ElseIf sOp = "1" Then
                gsRptArgs = {}
            If txtsublinea.TextLength = "4" Then
                ReDim gsRptArgs(8)
            Else
                ReDim gsRptArgs(7)
            End If

            gsRptArgs(0) = Format(dtpfecini.Value, "yyyy/MM/dd")
            gsRptArgs(1) = Format(dtpfecfin.Value, "yyyy/MM/dd")
            If cmbest.SelectedIndex <> -1 Then
                gsRptArgs(2) = cmbest.SelectedText
            Else
                gsRptArgs(2) = ""
            End If
            If cmbestdoc.SelectedIndex = 1 Then
                gsRptArgs(3) = "0"
            ElseIf cmbestdoc.SelectedIndex = 2 Then
                gsRptArgs(3) = "1"
            ElseIf cmbestdoc.SelectedIndex = 3 Then
                gsRptArgs(3) = "2"
            ElseIf cmbestdoc.SelectedIndex = 4 Then
                gsRptArgs(3) = "3"
            End If
            gsRptArgs(4) = txtarticulo1.Text
            gsRptArgs(5) = txtuserrep.Text
            If txtsublinea.TextLength = "4" Then
                gsRptArgs(6) = txtsublinea.Text
                gsRptArgs(7) = txtc_costo.Text
                gsRptArgs(8) = txtfardo.Text
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONTROL_PRODUCTIVIDAD1.rpt"
            Else
                'gsRptArgs(6) = ""
                gsRptArgs(6) = txtc_costo.Text
                gsRptArgs(7) = txtfardo.Text
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONTROL_PRODUCTIVIDAD.rpt"
            End If

            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "11"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo1.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "30"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "11"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo2.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        gsRptArgs = {}
        ReDim gsRptArgs(5)
        gsRptArgs(0) = Format(dtpfecha3.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfecha4.Value, "yyyy/MM/dd")
        gsRptArgs(2) = txtusuario2.Text
        gsRptArgs(3) = txtarticulo2.Text
        gsRptArgs(4) = ""
        If txtsublinea1.TextLength = "4" Then
            gsRptArgs(5) = txtsublinea1.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PRODUCCION_ORDEN1.rpt"
        Else
            gsRptArgs(5) = txtlinea1.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PRODUCCION_ORDEN.rpt"
        End If

        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        sBusAlm = "32"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            'txtlinea.Text = Trim(gLinea)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "32"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtlinea1.Text = Trim(gLinea)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    'Private Sub txtlinea_TextChanged(sender As Object, e As EventArgs)
    '    If txtlinea.TextLength = "2" Then
    '        txtsublinea.Enabled = True
    '    Else
    '        'txtsublinea.Enabled = False
    '        'txtcodart.Enabled = False
    '        txtnomlinea.Text = ""
    '        txtsublinea.Text = ""
    '        txtnomsublinea.Text = ""
    '    End If
    'End Sub

    Private Sub txtlinea1_TextChanged(sender As Object, e As EventArgs) Handles txtlinea1.TextChanged
        If txtlinea1.TextLength = "2" Then
            txtsublinea1.Enabled = True
        Else
            'txtsublinea.Enabled = False
            'txtcodart.Enabled = False
            txtnomlinea1.Text = ""
            txtsublinea1.Text = ""
            txtnomsublinea1.Text = ""
        End If
    End Sub

    'Private Sub txtlinea3_TextChanged(sender As Object, e As EventArgs)
    '    If txtlinea3.TextLength = "2" Then
    '        txtsublinea3.Enabled = True
    '    Else
    '        'txtsublinea.Enabled = False
    '        'txtcodart.Enabled = False
    '        txtnomlinea3.Text = ""
    '        txtsublinea3.Text = ""
    '        txtnomsublinea3.Text = ""
    '    End If
    'End Sub

    Private Sub txtlinea4_TextChanged(sender As Object, e As EventArgs) Handles txtlinea4.TextChanged
        If txtlinea4.TextLength = "2" Then
            txtsublinea4.Enabled = True
        Else
            'txtsublinea.Enabled = False
            'txtcodart.Enabled = False
            txtnomlinea4.Text = ""
            txtsublinea4.Text = ""
            txtnomsublinea4.Text = ""
        End If
    End Sub

    Private Sub txtsublinea_TextChanged(sender As Object, e As EventArgs) Handles txtsublinea.TextChanged
        If txtsublinea.TextLength = "4" Then
            'txtcodart.Enabled = True

        Else
            'txtcodart.Enabled = False
            txtnomsublinea.Text = ""

            'txtcodart.Text = ""
            'txtnomart.Text = ""
        End If
    End Sub
    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
            'If txtlinea.TextLength = "0" Then
            '    txtnomlinea.Text = ELTBLINESBL.SelectDescri(Mid(txtsublinea.Text, 1, 2) & "00")
            '    txtlinea.Text = Mid(txtsublinea.Text, 1, 2)
            '    'Else
            'End If
            'If txtnomsublinea.TextLength > 0 Then
            '    txtcodart.Enabled = True
            'Else
            '    txtcodart.Enabled = False
            'End If
        Else
            txtnomsublinea.Text = ""
            'txtcodart.Enabled = False
        End If
    End Sub

    Private Sub txtsublinea3_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea3.LostFocus
        If txtsublinea3.TextLength = 4 Then
            txtnomsublinea3.Text = ELTBLINESBL.SelectDescri(txtsublinea3.Text)
            'If txtlinea3.TextLength = "0" Then
            '    txtnomlinea3.Text = ELTBLINESBL.SelectDescri(Mid(txtsublinea3.Text, 1, 2) & "00")
            '    txtlinea3.Text = Mid(txtsublinea3.Text, 1, 2)
            '    'Else
            'End If
            'If txtnomsublinea.TextLength > 0 Then
            '    txtcodart.Enabled = True
            'Else
            '    txtcodart.Enabled = False
            'End If
        Else
            txtnomsublinea3.Text = ""
            'txtcodart.Enabled = False
        End If
    End Sub

    Private Sub txtsublinea4_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea4.LostFocus
        If txtsublinea4.TextLength = 4 Then
            txtnomsublinea4.Text = ELTBLINESBL.SelectDescri(txtsublinea4.Text)
            If txtlinea4.TextLength = "0" Then
                txtnomlinea4.Text = ELTBLINESBL.SelectDescri(Mid(txtsublinea4.Text, 1, 2) & "00")
                txtlinea4.Text = Mid(txtsublinea4.Text, 1, 2)
                'Else
            End If
            'If txtnomsublinea.TextLength > 0 Then
            '    txtcodart.Enabled = True
            'Else
            '    txtcodart.Enabled = False
            'End If
        Else
            txtnomsublinea4.Text = ""
            'txtcodart.Enabled = False
        End If
    End Sub

    Private Sub txtsublinea1_TextChanged(sender As Object, e As EventArgs) Handles txtsublinea1.TextChanged
        If txtsublinea1.TextLength = "4" Then
            'txtcodart.Enabled = True
        Else
            'txtcodart.Enabled = False
            txtnomsublinea1.Text = ""
            'txtcodart.Text = ""
            'txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtsublinea3_TextChanged(sender As Object, e As EventArgs) Handles txtsublinea3.TextChanged
        If txtsublinea3.TextLength = "4" Then
            'txtcodart.Enabled = True
        Else
            'txtcodart.Enabled = False
            txtnomsublinea3.Text = ""
            'txtcodart.Text = ""
            'txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtsublinea4_TextChanged(sender As Object, e As EventArgs) Handles txtsublinea4.TextChanged
        If txtsublinea4.TextLength = "4" Then
            'txtcodart.Enabled = True
        Else
            'txtcodart.Enabled = False
            txtnomsublinea4.Text = ""
            'txtcodart.Text = ""
            'txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtsublinea1_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea1.LostFocus
        If txtsublinea1.TextLength = 4 Then
            txtnomsublinea1.Text = ELTBLINESBL.SelectDescri(txtsublinea1.Text)
            txtnomlinea1.Text = ELTBLINESBL.SelectDescri(Mid(txtsublinea1.Text, 1, 2) & "00")
            txtlinea1.Text = Mid(txtsublinea1.Text, 1, 2)
            'If txtnomsublinea.TextLength > 0 Then
            '    txtcodart.Enabled = True
            'Else
            '    txtcodart.Enabled = False
            'End If
        Else
            txtnomsublinea1.Text = ""
            'txtcodart.Enabled = False
        End If
    End Sub

    'Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    '    sBusAlm = "221"
    '    Dim frm As New FormBUSQUEDA
    '    gsCode7 = Mid(txtlinea.Text, 1, 2)
    '    frm.ShowDialog()
    '    If gLinea <> Nothing Then
    '        txtsublinea.Text = Trim(gLinea)
    '        txtnomsublinea.Text = gSubLinea
    '        gLinea = Nothing
    '        gSubLinea = Nothing
    '    Else
    '        gLinea = Nothing
    '        gSubLinea = Nothing
    '    End If
    'End Sub
    'Private Sub txtlinea_LostFocus(sender As Object, e As EventArgs)
    '    If txtlinea.TextLength = 2 Then
    '        txtnomlinea.Text = ELTBLINESBL.SelectDescri(txtlinea.Text & "00")
    '        If txtnomlinea.TextLength > 0 Then
    '            txtsublinea.Enabled = True
    '        Else
    '            txtsublinea.Enabled = False
    '        End If
    '    Else
    '        txtnomlinea.Text = ""
    '        txtsublinea.Text = ""
    '        txtnomsublinea.Text = ""
    '        'txtsublinea.Enabled = False
    '    End If
    'End Sub
    Private Sub txtlinea1_LostFocus(sender As Object, e As EventArgs) Handles txtlinea1.LostFocus
        If txtlinea1.TextLength = 2 Then
            txtnomlinea1.Text = ELTBLINESBL.SelectDescri(txtlinea1.Text & "00")
            If txtnomlinea1.TextLength > 0 Then
                txtsublinea1.Enabled = True
            Else
                txtsublinea1.Enabled = False
            End If
        Else
            txtnomlinea1.Text = ""
            txtsublinea1.Text = ""
            txtnomsublinea1.Text = ""
            'txtsublinea.Enabled = False
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sBusAlm = "221"
        Dim frm As New FormBUSQUEDA
        gsCode7 = Mid(txtlinea1.Text, 1, 2)
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtsublinea1.Text = Trim(gLinea)
            txtnomsublinea1.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtlinea_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub txtlinea3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub txtlinea4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlinea4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtsublinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtsublinea3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtsublinea4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtlinea1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlinea1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtsublinea1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("La linea no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
            txtc_costo.Select()
        End If
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dispose()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        gsRptArgs = {}
        'If txtsublinea.TextLength = "4" Then
        '    
        'Else
        '    ReDim gsRptArgs(6)
        'End If
        ReDim gsRptArgs(8)
        gsRptArgs(0) = Format(dtpfecini3.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfecfin3.Value, "yyyy/MM/dd")
        If cmbest3.SelectedIndex <> -1 Then
            gsRptArgs(2) = cmbest3.SelectedText
        Else
            gsRptArgs(2) = ""
        End If
        If cmbestdoc3.SelectedIndex = 1 Then
            gsRptArgs(3) = "0"
        ElseIf cmbestdoc3.SelectedIndex = 2 Then
            gsRptArgs(3) = "1"
        ElseIf cmbestdoc3.SelectedIndex = 3 Then
            gsRptArgs(3) = "2"
        ElseIf cmbestdoc3.SelectedIndex = 4 Then
            gsRptArgs(3) = "3"
        End If
        gsRptArgs(4) = txtarticulo3.Text
        gsRptArgs(5) = txtc_costo3.Text
        gsRptArgs(6) = txtuserrep3.Text
        gsRptArgs(7) = txtsublinea3.Text
        gsRptArgs(8) = txtsublinea6.Text

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONTROL_PRODUCTIVIDAD_DIA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        sBusAlm = "240"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtuserrep3.Text = gLinea
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        sBusAlm = "11"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo3.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    'Private Sub Button12_Click(sender As Object, e As EventArgs)
    '    sBusAlm = "32"
    '    Dim frm As New FormBUSQUEDA
    '    frm.ShowDialog()
    '    If gLinea <> Nothing Then
    '        txtlinea3.Text = Trim(gLinea)
    '        gLinea = Nothing
    '    Else
    '        gLinea = Nothing
    '    End If
    'End Sub

    'Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
    '    sBusAlm = "221"
    '    Dim frm As New FormBUSQUEDA
    '    gsCode7 = Mid(txtlinea3.Text, 1, 2)
    '    frm.ShowDialog()
    '    If gLinea <> Nothing Then
    '        txtsublinea3.Text = Trim(gLinea)
    '        txtnomsublinea3.Text = gSubLinea
    '        gLinea = Nothing
    '        gSubLinea = Nothing
    '    Else
    '        gLinea = Nothing
    '        gSubLinea = Nothing
    '    End If
    'End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dispose()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        sBusAlm = "240"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtuserrep4.Text = gLinea
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        sBusAlm = "11"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo4.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        sBusAlm = "32"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtlinea4.Text = Trim(gLinea)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        sBusAlm = "221"
        Dim frm As New FormBUSQUEDA
        gsCode7 = Mid(txtlinea4.Text, 1, 2)
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtsublinea4.Text = Trim(gLinea)
            txtnomsublinea4.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        gsRptArgs = {}
        'If txtsublinea.TextLength = "4" Then
        '    
        'Else
        '    ReDim gsRptArgs(6)
        'End If
        ReDim gsRptArgs(7)
        gsRptArgs(0) = Format(dtpfecini4.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfecfin4.Value, "yyyy/MM/dd")
        If cmbest4.SelectedIndex <> -1 Then
            gsRptArgs(2) = cmbest4.SelectedText
        Else
            gsRptArgs(2) = ""
        End If
        If cmbestdoc4.SelectedIndex = 1 Then
            gsRptArgs(3) = "0"
        ElseIf cmbestdoc4.SelectedIndex = 2 Then
            gsRptArgs(3) = "1"
        ElseIf cmbestdoc4.SelectedIndex = 3 Then
            gsRptArgs(3) = "2"
        ElseIf cmbestdoc4.SelectedIndex = 4 Then
            gsRptArgs(3) = "3"
        End If
        gsRptArgs(4) = txtarticulo4.Text
        gsRptArgs(5) = txtc_costo4.Text
        gsRptArgs(6) = txtuserrep4.Text
        gsRptArgs(7) = txtsublinea4.Text

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONTROL_PRODUCTIVIDAD_CCOSTO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea.Text = gSubLinea
            txtsublinea.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea2.Text = gSubLinea
            txtsublinea2.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea3.Text = gSubLinea
            txtsublinea3.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea6.Text = gSubLinea
            txtsublinea6.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtnro_orden_LostFocus(sender As Object, e As EventArgs) Handles txtnro_orden.LostFocus
        If txtnro_orden.TextLength > 0 Then
            txtnro_orden.Text = txtnro_orden.Text.PadLeft(9, "0")
        End If
    End Sub
End Class