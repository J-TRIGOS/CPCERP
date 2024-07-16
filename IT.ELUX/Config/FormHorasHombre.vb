Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormHorasHombre
    Private CCOSTOBL As New CCOSTOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private PERBL As New PERBL
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

    Private Sub FormHorasHombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Horas Hombre"
        cmbaño.SelectedItem = sAño
        cmbmes.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbaño2.SelectedItem = sAño
        cmbmes5.SelectedItem = "Enero"
        cmbmes6.SelectedIndex = Month(Date.Today)
        cmbaño5.SelectedItem = sAño
        cmbaño7.SelectedItem = sAño
        cmbmes7.SelectedItem = "Enero"
        cmbmes8.SelectedIndex = Month(Date.Today)
        'cmbaño5.SelectedItem = sAño
        'cmbmes3.SelectedItem = "Enero"
        cmbmes3.SelectedIndex = Month(Date.Today)
        TextBox4.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
        bPrimero = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo.Text = gLinea
            TextBox5.Text = CCOSTOBL.SelectNom(gLinea)
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
            TextBox1.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo2.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub FormHorasHombre_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cursor.Current = Cursors.WaitCursor
        gsRptArgs = {}
        ReDim gsRptArgs(4)
        gsRptArgs(0) = cmbaño.SelectedItem
        If cmbmes.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtc_costo.Text
        gsRptArgs(4) = txtc_costo2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_HORASH_RESUANUAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.TextLength > 2 Then
            TextBox5.Text = CCOSTOBL.SelectNom(txtc_costo.Text)
        Else
            TextBox5.Text = ""
        End If

    End Sub


    Private Sub txtc_costo2_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo2.LostFocus
        If txtc_costo2.TextLength > 2 Then
            TextBox1.Text = CCOSTOBL.SelectNom(txtc_costo2.Text)
        Else
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dispose()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni.Text = gLinea
            TextBox9.Text = gSubLinea
            txtdni.Select()
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni.Text = gLinea
            txtdni2.Text = gSubLinea
            txtdni2.Select()
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor.Current = Cursors.WaitCursor
        gsRptArgs = {}
        ReDim gsRptArgs(8)
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
        If cmbmes3.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes3.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = Trim(txtc_costo3.Text)
        gsRptArgs(4) = Trim(txtc_costo4.Text)
        gsRptArgs(5) = txtarea1.Text
        gsRptArgs(6) = txtarea2.Text
        gsRptArgs(7) = txtdni.Text
        gsRptArgs(8) = txtdni2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_HORASH_CCOSTO_DETALLE.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo3.Text = gLinea
            TextBox4.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo3.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo4.Text = gLinea
            TextBox2.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo4.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txtc_costo3_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo3.LostFocus
        bPrimero = True
        Dim dt As DataTable
        If txtc_costo3.TextLength > 2 Then
            TextBox4.Text = CCOSTOBL.SelectNom(txtc_costo3.Text)
            txtarea1.Enabled = True
            cmbarea1.Enabled = True
            dt = SOLMATERIALESBL.gArea(txtc_costo3.Text)
            GetCmb("cod", "nom", dt, cmbarea1)
            bPrimero = False
        Else
            TextBox4.Text = ""
            cmbarea1.SelectedIndex = -1
            txtarea1.Text = ""
            txtarea1.Enabled = False
            cmbarea1.Enabled = False
        End If
    End Sub

    Private Sub txtc_costo4_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo4.LostFocus
        Dim dt As DataTable
        If txtc_costo4.TextLength > 2 Then
            TextBox2.Text = CCOSTOBL.SelectNom(txtc_costo4.Text)
            txtarea2.Enabled = True
            cmbarea2.Enabled = True
            dt = SOLMATERIALESBL.gArea(txtc_costo4.Text)
            GetCmb("cod", "nom", dt, cmbarea2)
            bPrimero = False
        Else
            TextBox2.Text = ""
            cmbarea2.SelectedIndex = -1
            txtarea2.Text = ""
            txtarea2.Enabled = False
            cmbarea2.Enabled = False
        End If
    End Sub


    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.TextLength > 0 Then
            TextBox9.Text = PERBL.SelectApeNom(txtdni.Text)
        Else
            TextBox9.Text = ""
        End If
    End Sub

    Private Sub txtdni2_LostFocus(sender As Object, e As EventArgs) Handles txtdni2.LostFocus
        If txtdni2.TextLength > 0 Then
            TextBox10.Text = PERBL.SelectApeNom(txtdni2.Text)
        Else
            TextBox10.Text = ""
        End If
    End Sub

    Private Sub txtarea1_LostFocus(sender As Object, e As EventArgs) Handles txtarea1.LostFocus

        If txtarea1.Text = "" Then
            cmbarea1.SelectedValue = ""
            Exit Sub
        End If
        cmbarea1.SelectedValue = txtc_costo.Text
        If cmbarea1.SelectedValue Is Nothing Then
            MsgBox("La linea no existe ", MsgBoxStyle.Exclamation)
            txtarea1.Text = ""
            txtarea1.Select()
        End If
    End Sub

    Private Sub txtarea2_LostFocus(sender As Object, e As EventArgs) Handles txtarea2.LostFocus
        If txtarea2.Text = "" Then
            cmbarea2.SelectedValue = ""
            Exit Sub
        End If
        cmbarea2.SelectedValue = txtc_costo.Text
        If cmbarea2.SelectedValue Is Nothing Then
            MsgBox("La linea no existe", MsgBoxStyle.Exclamation)
            txtarea2.Text = ""
            txtarea2.Select()
        End If
    End Sub

    Private Sub cmbarea1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarea1.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        Try
            txtarea1.Text = cmbarea1.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbarea2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarea2.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        Try
            txtarea2.Text = cmbarea2.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dispose()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo5.Text = gLinea
            TextBox13.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo5.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo6.Text = gLinea
            TextBox11.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo6.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni5.Text = gLinea
            TextBox7.Text = gSubLinea
            txtdni5.Select()
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni6.Text = gLinea
            TextBox3.Text = gSubLinea
            txtdni6.Select()
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Cursor.Current = Cursors.WaitCursor
        gsRptArgs = {}
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmbaño5.SelectedItem
        If cmbmes5.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes5.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes5.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes5.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes5.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes5.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes5.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes5.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes5.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes5.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes5.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes5.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes6.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes6.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes6.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes6.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes6.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes6.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes6.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes6.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes6.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes6.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes6.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes6.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtdni5.Text
        gsRptArgs(4) = txtdni6.Text
        gsRptArgs(5) = Trim(txtc_costo5.Text)
        gsRptArgs(6) = Trim(txtc_costo6.Text)
        If chkcco.Checked Then
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_HORAS_EXTRAS_PER_PRDO.rpt"
        Else
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_HORAS_EXTRAS_PER_PRDOX.rpt"
        End If

        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dispose()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo7.Text = gLinea
            TextBox12.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo7.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo8.Text = gLinea
            TextBox6.Text = CCOSTOBL.SelectNom(gLinea)
            txtc_costo8.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Cursor.Current = Cursors.WaitCursor
        gsRptArgs = {}
        ReDim gsRptArgs(4)
        gsRptArgs(0) = cmbaño7.SelectedItem
        If cmbmes7.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes7.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes7.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes7.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes7.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes7.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes7.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes7.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes7.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes7.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes7.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes7.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes8.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes8.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes8.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes8.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes8.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes8.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes8.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes8.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes8.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes8.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes8.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes8.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = Trim(txtc_costo7.Text)
        gsRptArgs(4) = Trim(txtc_costo8.Text)
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_HORAS_PAGADAS_CCOSTO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class