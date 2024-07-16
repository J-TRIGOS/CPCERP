Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptConsVal
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private bprimero As Boolean
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormRptConsVal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Consumo de Insumos Valorizado"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbaño2.SelectedItem = sAño
        cmbmes2.SelectedItem = "Diciembre"
        cmbaño3.SelectedItem = sAño
        cmbmes3.SelectedItem = "Enero"
        cmbmes5.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
        cmbmes6.SelectedIndex = Month(Date.Today)
        cmbaño4.SelectedItem = sAño
        cmbmes7.SelectedItem = "Enero"
        cmbmes8.SelectedItem = "Diciembre"
        bprimero = True
        txtnomart1.ReadOnly = True
        txtnomart2.ReadOnly = True
        txtnomart3.ReadOnly = True
        txtnomart4.ReadOnly = True
        txtnomart6.ReadOnly = True
        txtnomart5.ReadOnly = True
        txtnomart7.ReadOnly = True
        txtnomart8.ReadOnly = True
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo2)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo3)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo4)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo5)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo6)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo7)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo8)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sBusAlm = "35"
        'Dim frm As New FormBUSQUEDA
        'frm.ShowDialog()
        'If gSubLinea <> Nothing Then
        '    txtart1.Text = gArt
        '    txtart1.Select()
        '    txtnomart1.Text = gSubLinea
        '    gSubLinea = Nothing
        '    gArt = Nothing
        'Else
        '    gSubLinea = Nothing
        '    gArt = Nothing
        'End If
        If txtnomsublinea1.TextLength > 0 Then
            sBusAlm = "223"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtsublinea1.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtart1.Text = Trim(gLinea)
                txtnomart1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        Else
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            'MsgBox(IsDBNull(gLinea.Length))
            If gLinea <> Nothing Then
                txtart1.Text = gLinea
                'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                txtnomart1.Text = ARTICULOBL.SelectArt2(txtart1.Text)
                'cmbart.SelectedValue = gArt
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'sBusAlm = "35"
        'Dim frm As New FormBUSQUEDA
        'frm.ShowDialog()
        'If gSubLinea <> Nothing Then
        '    txtart2.Text = gArt
        '    txtart2.Select()
        '    txtnomart2.Text = gSubLinea
        '    gSubLinea = Nothing
        '    gArt = Nothing
        'Else
        '    gSubLinea = Nothing
        '    gArt = Nothing
        'End If
        If txtnomsublinea1.TextLength > 0 Then
            sBusAlm = "223"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtsublinea2.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtart2.Text = Trim(gLinea)
                txtnomart2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        Else
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            'MsgBox(IsDBNull(gLinea.Length))
            If gLinea <> Nothing Then
                txtart2.Text = gLinea
                'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                txtnomart2.Text = ARTICULOBL.SelectArt2(txtart2.Text)
                'cmbart.SelectedValue = gArt
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

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptConsVal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo.Text = gLinea
            cmbc_costo.SelectedValue = gLinea
            txtc_costo.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo2.Text = gLinea
            cmbc_costo2.SelectedValue = gLinea
            txtc_costo2.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txtart1_LostFocus(sender As Object, e As EventArgs) Handles txtart1.LostFocus
        If txtart1.TextLength = "8" Then
            txtnomart1.Text = ARTICULOBL.SelectArt2(txtart1.Text)
        ElseIf (txtart1.TextLength > "1" Or txtart1.TextLength < "7") And txtart1.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart1.Select()
        ElseIf txtart1.TextLength = 0 Then
            txtnomart1.Text = ""
        End If

    End Sub

    Private Sub txtart2_LostFocus(sender As Object, e As EventArgs) Handles txtart2.LostFocus
        If txtart2.TextLength = "8" Then
            txtnomart2.Text = ARTICULOBL.SelectArt2(txtart2.Text)
        ElseIf (txtart2.TextLength > 1 Or txtart2.TextLength < 7) And txtart2.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart2.Select()
        ElseIf txtart2.TextLength = 0 Then
            txtnomart2.Text = ""
        End If
    End Sub
    Private Sub txtart3_LostFocus(sender As Object, e As EventArgs) Handles txtart3.LostFocus
        If txtart3.TextLength = "8" Then
            txtnomart3.Text = ARTICULOBL.SelectArt2(txtart3.Text)
        ElseIf (txtart5.TextLength > 1 Or txtart3.TextLength < 7) And txtart3.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart3.Select()
        ElseIf txtart3.TextLength = 0 Then
            txtnomart3.Text = ""
        End If
    End Sub
    Private Sub txtart4_LostFocus(sender As Object, e As EventArgs) Handles txtart4.LostFocus
        If txtart4.TextLength = "8" Then
            txtnomart4.Text = ARTICULOBL.SelectArt2(txtart4.Text)
        ElseIf (txtart6.TextLength > 1 Or txtart4.TextLength < 7) And txtart4.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart4.Select()
        ElseIf txtart4.TextLength = 0 Then
            txtnomart4.Text = ""
        End If
    End Sub
    Private Sub txtart5_LostFocus(sender As Object, e As EventArgs) Handles txtart5.LostFocus
        If txtart5.TextLength = "8" Then
            txtnomart5.Text = ARTICULOBL.SelectArt2(txtart5.Text)
        ElseIf (txtart5.TextLength > 1 Or txtart5.TextLength < 7) And txtart5.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart5.Select()
        ElseIf txtart5.TextLength = 0 Then
            txtnomart5.Text = ""
        End If
    End Sub
    Private Sub txtart6_LostFocus(sender As Object, e As EventArgs) Handles txtart6.LostFocus
        If txtart6.TextLength = "8" Then
            txtnomart6.Text = ARTICULOBL.SelectArt2(txtart6.Text)
        ElseIf (txtart6.TextLength > 1 Or txtart6.TextLength < 7) And txtart6.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart6.Select()
        ElseIf txtart6.TextLength = 0 Then
            txtnomart6.Text = ""
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = cmbaño.SelectedItem
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtc_costo.Text
        gsRptArgs(4) = txtc_costo2.Text
        gsRptArgs(5) = txtart1.Text
        gsRptArgs(6) = txtart2.Text
        gsRptArgs(7) = txtsublinea1.Text
        gsRptArgs(8) = txtsublinea2.Text
        gsRptArgs(9) = txtproveedor.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONS_RESUANUAL_VAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sBusAlm = "35"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtart3.Text = gArt
            txtart3.Select()
            txtnomart3.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "35"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtart4.Text = gArt
            txtart4.Select()
            txtnomart4.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo3.Text = gLinea
            cmbc_costo3.SelectedValue = gLinea
            txtc_costo3.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo4.Text = gLinea
            cmbc_costo4.SelectedValue = gLinea
            txtc_costo4.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = cmbaño2.SelectedItem
        If cmbmes3.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes3.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes4.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes4.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes4.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes4.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes4.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes4.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes4.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes4.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes4.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes4.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes4.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes4.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtc_costo3.Text
        gsRptArgs(4) = txtc_costo4.Text
        gsRptArgs(5) = txtart3.Text
        gsRptArgs(6) = txtart4.Text
        gsRptArgs(7) = txtsublinea3.Text
        gsRptArgs(8) = txtsublinea4.Text
        gsRptArgs(9) = txtproveedor2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONSUMO_DETALLE_VAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub



    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dispose()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = cmbaño3.SelectedItem
        If cmbmes6.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes6.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes6.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes6.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes6.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes6.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes6.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes6.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes6.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes6.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes6.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes6.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes5.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes5.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes5.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes5.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes5.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes5.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes5.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes5.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes5.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes5.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes5.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes5.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtc_costo5.Text
        gsRptArgs(4) = txtc_costo6.Text
        gsRptArgs(5) = txtart5.Text
        gsRptArgs(6) = txtart6.Text
        gsRptArgs(7) = txtsublinea5.Text
        gsRptArgs(8) = txtsublinea6.Text
        gsRptArgs(9) = txtproveedor3.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONS_RESUCCOSTO_VAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub


    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
        End If
    End Sub

    Private Sub txtc_costo2_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo2.LostFocus
        If txtc_costo2.Text = "" Then
            cmbc_costo2.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo2.SelectedValue = txtc_costo2.Text
        If cmbc_costo2.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo2.Text = ""
        End If
    End Sub

    Private Sub txtc_costo3_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo3.LostFocus
        If txtc_costo3.Text = "" Then
            cmbc_costo3.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo3.SelectedValue = txtc_costo3.Text
        If cmbc_costo3.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo3.Text = ""
        End If
    End Sub

    Private Sub txtc_costo4_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo4.LostFocus
        If txtc_costo4.Text = "" Then
            cmbc_costo4.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo4.SelectedValue = txtc_costo4.Text
        If cmbc_costo4.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo4.Text = ""
        End If
    End Sub

    Private Sub txtc_costo5_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo5.LostFocus
        If txtc_costo5.Text = "" Then
            cmbc_costo5.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo5.SelectedValue = txtc_costo5.Text
        If cmbc_costo5.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo5.Text = ""
        End If
    End Sub

    Private Sub txtc_costo6_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo6.LostFocus
        If txtc_costo6.Text = "" Then
            cmbc_costo6.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo6.SelectedValue = txtc_costo6.Text
        If cmbc_costo6.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo6.Text = ""
        End If
    End Sub

    Private Sub cmbc_costo6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo6.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo6.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo6.Text = cmbc_costo6.SelectedValue
    End Sub

    Private Sub cmbc_costo5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo5.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo5.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo5.Text = cmbc_costo5.SelectedValue
    End Sub

    Private Sub cmbc_costo4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo4.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo4.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo4.Text = cmbc_costo4.SelectedValue
    End Sub

    Private Sub cmbc_costo3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo3.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo3.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo3.Text = cmbc_costo3.SelectedValue
    End Sub

    Private Sub cmbc_costo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo2.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo2.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo2.Text = cmbc_costo2.SelectedValue
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea1.Text = gSubLinea
            txtsublinea1.Select()
            txtnomsublinea1.Text = ELTBLINESBL.SelectDescri(txtsublinea1.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        sBusAlm = "28"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea2.Text = gSubLinea
            txtsublinea2.Select()
            txtnomsublinea2.Text = ELTBLINESBL.SelectDescri(txtsublinea2.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtart1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart1.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea1.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea1.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtart1.Text = Trim(gLinea)
                    txtnomart1.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "106"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing Then
                    txtart1.Text = gLinea
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart1.Text = ARTICULOBL.SelectArt2(txtart1.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub txtsublinea1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "27"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea1.Text = gSubLinea
                txtsublinea1.Select()
                txtnomsublinea1.Text = ELTBLINESBL.SelectDescri(txtsublinea1.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "28"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea2.Text = gSubLinea
                txtsublinea2.Select()
                txtnomsublinea2.Text = ELTBLINESBL.SelectDescri(txtsublinea2.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea1_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea1.LostFocus
        If txtsublinea1.TextLength > 0 Then
            txtnomsublinea1.Text = ELTBLINESBL.SelectDescri(txtsublinea1.Text)
        Else
            txtnomsublinea1.Text = ""
        End If

    End Sub

    Private Sub txtsublinea2_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea2.LostFocus
        If txtsublinea2.TextLength = 8 Then
            txtnomsublinea2.Text = ELTBLINESBL.SelectDescri(txtsublinea2.Text)
        Else
            txtnomsublinea2.Text = ""
        End If
    End Sub

    Private Sub txtart2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart2.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea2.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea2.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtart2.Text = Trim(gLinea)
                    txtnomart2.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "106"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing Then
                    txtart2.Text = gLinea
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart2.Text = ARTICULOBL.SelectArt2(txtart2.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea3.Text = gSubLinea
            txtsublinea3.Select()
            txtnomsublinea3.Text = ELTBLINESBL.SelectDescri(txtsublinea3.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea4.Text = gSubLinea
            txtsublinea4.Select()
            txtnomsublinea4.Text = ELTBLINESBL.SelectDescri(txtsublinea4.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea5.Text = gSubLinea
            txtsublinea5.Select()
            txtnomsublinea5.Text = ELTBLINESBL.SelectDescri(txtsublinea5.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea6.Text = gSubLinea
            txtsublinea6.Select()
            txtnomsublinea6.Text = ELTBLINESBL.SelectDescri(txtsublinea6.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtart3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart3.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea3.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea3.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtart3.Text = Trim(gLinea)
                    txtnomart3.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "106"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing Then
                    txtart3.Text = gLinea
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart3.Text = ARTICULOBL.SelectArt2(txtart3.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub txtart4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart4.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea4.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea4.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtart4.Text = Trim(gLinea)
                    txtnomart4.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "106"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing Then
                    txtart4.Text = gLinea
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart4.Text = ARTICULOBL.SelectArt2(txtart4.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub txtart5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart5.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea5.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea5.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtart5.Text = Trim(gLinea)
                    txtnomart5.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "106"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing Then
                    txtart5.Text = gLinea
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart5.Text = ARTICULOBL.SelectArt2(txtart5.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub txtart6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart6.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea6.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea6.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtart6.Text = Trim(gLinea)
                    txtnomart6.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "106"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing Then
                    txtart6.Text = gLinea
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart6.Text = ARTICULOBL.SelectArt2(txtart6.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub txtsublinea3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "27"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea3.Text = gSubLinea
                txtsublinea3.Select()
                txtnomsublinea3.Text = ELTBLINESBL.SelectDescri(txtsublinea3.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "27"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea4.Text = gSubLinea
                txtsublinea4.Select()
                txtnomsublinea4.Text = ELTBLINESBL.SelectDescri(txtsublinea4.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea5.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "27"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea5.Text = gSubLinea
                txtsublinea5.Select()
                txtnomsublinea5.Text = ELTBLINESBL.SelectDescri(txtsublinea5.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea6.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "27"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea6.Text = gSubLinea
                txtsublinea6.Select()
                txtnomsublinea6.Text = ELTBLINESBL.SelectDescri(txtsublinea6.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea3_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea3.LostFocus
        If txtsublinea3.TextLength > 0 Then
            txtnomsublinea3.Text = ELTBLINESBL.SelectDescri(txtsublinea3.Text)
        Else
            txtnomsublinea3.Text = ""
        End If
    End Sub

    Private Sub txtsublinea4_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea4.LostFocus
        If txtsublinea4.TextLength > 0 Then
            txtnomsublinea4.Text = ELTBLINESBL.SelectDescri(txtsublinea4.Text)
        Else
            txtnomsublinea4.Text = ""
        End If
    End Sub

    Private Sub txtsublinea5_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea5.LostFocus
        If txtsublinea5.TextLength > 0 Then
            txtnomsublinea5.Text = ELTBLINESBL.SelectDescri(txtsublinea5.Text)
        Else
            txtnomsublinea5.Text = ""
        End If
    End Sub

    Private Sub txtsublinea6_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea6.LostFocus
        If txtsublinea6.TextLength > 0 Then
            txtnomsublinea6.Text = ELTBLINESBL.SelectDescri(txtsublinea6.Text)
        Else
            txtnomsublinea1.Text = ""
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea7.Text = gSubLinea
            txtsublinea7.Select()
            txtnomsublinea7.Text = ELTBLINESBL.SelectDescri(txtsublinea7.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        sBusAlm = "28"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea8.Text = gSubLinea
            txtsublinea8.Select()
            txtnomsublinea8.Text = ELTBLINESBL.SelectDescri(txtsublinea8.Text)
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If txtnomsublinea7.TextLength > 0 Then
            sBusAlm = "223"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtsublinea7.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtart7.Text = Trim(gLinea)
                txtnomart7.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        Else
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            'MsgBox(IsDBNull(gLinea.Length))
            If gLinea <> Nothing Then
                txtart7.Text = gLinea
                'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                txtnomart7.Text = ARTICULOBL.SelectArt2(txtart7.Text)
                'cmbart.SelectedValue = gArt
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

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If txtnomsublinea8.TextLength > 0 Then
            sBusAlm = "223"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtsublinea8.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtart8.Text = Trim(gLinea)
                txtnomart8.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        Else
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            'MsgBox(IsDBNull(gLinea.Length))
            If gLinea <> Nothing Then
                txtart8.Text = gLinea
                'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                txtnomart8.Text = ARTICULOBL.SelectArt2(txtart8.Text)
                'cmbart.SelectedValue = gArt
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

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo7.Text = gLinea
            cmbc_costo7.SelectedValue = gLinea
            txtc_costo7.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo8.Text = gLinea
            cmbc_costo8.SelectedValue = gLinea
            txtc_costo8.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dispose()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = cmbaño4.SelectedItem
        If cmbmes8.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes8.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes8.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes8.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes8.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes8.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes8.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes8.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes8.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes8.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes8.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes8.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes7.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes7.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes7.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes7.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes7.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes7.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes8.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes7.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes7.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes7.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes7.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes7.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtc_costo7.Text
        gsRptArgs(4) = txtc_costo8.Text
        gsRptArgs(5) = txtart7.Text
        gsRptArgs(6) = txtart8.Text
        gsRptArgs(7) = txtsublinea7.Text
        gsRptArgs(8) = txtsublinea8.Text
        gsRptArgs(9) = txtproveedor4.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONS_RESUCCOSTO_LINEA_VAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtproveedor.Text = gLinea
            txtnomprov.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtproveedor2.Text = gLinea
            txtnomprov2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtproveedor3.Text = gLinea
            txtnomprov3.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtproveedor4.Text = gLinea
            txtnomprov4.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub
End Class