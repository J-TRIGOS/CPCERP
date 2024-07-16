Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptVentas_Fact_Art
    Private ELTBLINESBL As New ELTBLINESBL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub FormRptVentas_Fact_Art_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If rdbfacturas.Checked = True Then
            If rdbnum.Checked = True Then
                If txtnumero.TextLength = 0 Or txtcliente1.TextLength = 0 Then
                    MsgBox("Favor Ingrese un numero o cliente para el filtro")
                Else
                    ReDim gsRptArgs(1)
                    gsRptArgs(0) = txtnumero.Text
                    gsRptArgs(1) = txtcliente1.Text
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDET_DOCU_VENTAS.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Else
                ReDim gsRptArgs(2)
                gsRptArgs(0) = txtcliente1.Text
                gsRptArgs(1) = cmbaño.Text
                gsRptArgs(2) = cmbaño2.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDET_DOCU_VEN_CTCT.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If
        ElseIf rdbfacturasn.Checked = True Then
            If rdbnum.Checked = True Then
                ReDim gsRptArgs(1)
                gsRptArgs(0) = txtnumero.Text
                gsRptArgs(1) = txtcliente1.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDET_DOCU_VENTAS1.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            ElseIf rdbaño.Checked = True Then
                ReDim gsRptArgs(2)
                gsRptArgs(0) = txtcliente1.Text
                gsRptArgs(1) = cmbaño.Text
                gsRptArgs(2) = cmbaño2.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDET_DOCU_VEN_CTCT2.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()

                'End If
            ElseIf rdbañomes.Checked = True Then
                ReDim gsRptArgs(3)
                gsRptArgs(0) = txtcliente1.Text
                If cmbmes1.SelectedIndex = 1 Then
                    gsRptArgs(1) = cmbaño.Text & "01"
                ElseIf cmbmes1.SelectedIndex = 2 Then
                    gsRptArgs(1) = cmbaño.Text & "02"
                ElseIf cmbmes1.SelectedIndex = 3 Then
                    gsRptArgs(1) = cmbaño.Text & "03"
                ElseIf cmbmes1.SelectedIndex = 4 Then
                    gsRptArgs(1) = cmbaño.Text & "04"
                ElseIf cmbmes1.SelectedIndex = 5 Then
                    gsRptArgs(1) = cmbaño.Text & "05"
                ElseIf cmbmes1.SelectedIndex = 6 Then
                    gsRptArgs(1) = cmbaño.Text & "06"
                ElseIf cmbmes1.SelectedIndex = 7 Then
                    gsRptArgs(1) = cmbaño.Text & "07"
                ElseIf cmbmes1.SelectedIndex = 8 Then
                    gsRptArgs(1) = cmbaño.Text & "08"
                ElseIf cmbmes1.SelectedIndex = 9 Then
                    gsRptArgs(1) = cmbaño.Text & "09"
                ElseIf cmbmes1.SelectedIndex = 10 Then
                    gsRptArgs(1) = cmbaño.Text & "10"
                ElseIf cmbmes1.SelectedIndex = 11 Then
                    gsRptArgs(1) = cmbaño.Text & "11"
                ElseIf cmbmes1.SelectedIndex = 12 Then
                    gsRptArgs(1) = cmbaño.Text & "12"
                End If
                If cmbmes2.SelectedIndex = 1 Then
                    gsRptArgs(2) = cmbaño2.Text & "01"
                ElseIf cmbmes2.SelectedIndex = 2 Then
                    gsRptArgs(2) = cmbaño2.Text & "02"
                ElseIf cmbmes2.SelectedIndex = 3 Then
                    gsRptArgs(2) = cmbaño2.Text & "03"
                ElseIf cmbmes2.SelectedIndex = 4 Then
                    gsRptArgs(2) = cmbaño2.Text & "04"
                ElseIf cmbmes2.SelectedIndex = 5 Then
                    gsRptArgs(2) = cmbaño2.Text & "05"
                ElseIf cmbmes2.SelectedIndex = 6 Then
                    gsRptArgs(2) = cmbaño2.Text & "06"
                ElseIf cmbmes2.SelectedIndex = 7 Then
                    gsRptArgs(2) = cmbaño2.Text & "07"
                ElseIf cmbmes2.SelectedIndex = 8 Then
                    gsRptArgs(2) = cmbaño2.Text & "08"
                ElseIf cmbmes2.SelectedIndex = 9 Then
                    gsRptArgs(2) = cmbaño2.Text & "09"
                ElseIf cmbmes2.SelectedIndex = 10 Then
                    gsRptArgs(2) = cmbaño2.Text & "10"
                ElseIf cmbmes2.SelectedIndex = 11 Then
                    gsRptArgs(2) = cmbaño2.Text & "11"
                ElseIf cmbmes2.SelectedIndex = 12 Then
                    gsRptArgs(2) = cmbaño2.Text & "12"
                End If
                gsRptArgs(3) = TextBox7.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDET_DOCU_VEN_CTCT3.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If
        End If

    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        If TextBox7.TextLength = 4 Then
            TextBox6.Text = ELTBLINESBL.SelectDescri(TextBox7.Text)
        Else
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub FormRptVentas_Fact_Art_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ventas de Articulo por Factura"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub chkañomes_CheckedChanged(sender As Object, e As EventArgs)
        'If chkaño.Checked = True Then
        '    cmbaño.SelectedItem = sAño
        '    cmbaño2.SelectedItem = sAño
        '    cmbaño.Enabled = True
        '    cmbaño2.Enabled = True
        '    txtnumero.Text = ""
        '    txtnumero.Enabled = False
        '    chkaño.Checked = False
        '    cmbmes1.SelectedIndex = -1
        '    cmbmes2.SelectedIndex = -1
        '    cmbmes1.Enabled = False
        '    cmbmes2.Enabled = False
        'Else
        '    cmbaño.SelectedIndex = -1
        '    cmbaño2.SelectedIndex = -1
        '    cmbaño.Enabled = False
        '    cmbaño2.Enabled = False
        '    txtnumero.Text = ""
        '    txtnumero.Enabled = True
        '    txtnumero.Enabled = False
        '    chkaño.Checked = False
        '    cmbmes1.SelectedIndex = -1
        '    cmbmes2.SelectedIndex = -1
        'End If
    End Sub

    Private Sub rdbaño_CheckedChanged(sender As Object, e As EventArgs) Handles rdbaño.CheckedChanged
        If rdbaño.Checked = True Then
            cmbaño.SelectedItem = sAño
            cmbaño2.SelectedItem = sAño
            cmbaño.Enabled = True
            cmbaño2.Enabled = True
            txtnumero.Text = ""
            txtnumero.Enabled = False
            'chkañomes.Checked = False
            cmbmes2.Enabled = False
            cmbmes1.Enabled = False
            cmbmes1.SelectedIndex = -1
            cmbmes2.SelectedIndex = -1
            'Else
            '    cmbaño.SelectedIndex = -1
            '    cmbaño2.SelectedIndex = -1
            '    cmbaño.Enabled = False
            '    cmbaño2.Enabled = False
            '    txtnumero.Text = ""
            '    txtnumero.Enabled = True
            '    txtnumero.Enabled = False
            '    'chkañomes.Checked = False
            '    cmbmes1.SelectedIndex = -1
            '    cmbmes2.SelectedIndex = -1
            '    cmbmes1.Enabled = False
            '    cmbmes2.Enabled = False
        End If
    End Sub

    Private Sub rdbfacturas_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfacturas.CheckedChanged
        If rdbfacturas.Checked = True Then
            rdbañomes.Visible = False
            TextBox7.Enabled = False
            TextBox6.Enabled = False
            rdbnum.Checked = True
        End If
    End Sub

    Private Sub rdbañomes_CheckedChanged(sender As Object, e As EventArgs) Handles rdbañomes.CheckedChanged
        If rdbañomes.Checked = True Then
            cmbaño.SelectedItem = sAño
            cmbaño2.SelectedItem = sAño
            cmbaño.Enabled = True
            cmbaño2.Enabled = True
            txtnumero.Text = ""
            txtnumero.Enabled = False
            cmbmes2.Enabled = True
            cmbmes1.Enabled = True
            TextBox7.Enabled = True
            TextBox6.Enabled = True
            'chkañomes.Checked = False
            cmbmes1.SelectedIndex = -1
            cmbmes2.SelectedIndex = -1
        End If
    End Sub

    Private Sub rdbfacturasn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfacturasn.CheckedChanged
        If rdbfacturasn.Checked = True Then
            rdbañomes.Visible = True
        End If
    End Sub

    Private Sub rdbnum_CheckedChanged(sender As Object, e As EventArgs) Handles rdbnum.CheckedChanged
        If rdbnum.Checked Then
            cmbaño.SelectedIndex = -1
            cmbaño2.SelectedIndex = -1
            cmbaño.Enabled = False
            cmbaño2.Enabled = False
            txtnumero.Text = ""
            txtnumero.Enabled = True
            'txtnumero.Enabled = False
            'chkañomes.Checked = False
            cmbmes2.Enabled = False
            cmbmes1.Enabled = False
            cmbmes1.SelectedIndex = -1
            cmbmes2.SelectedIndex = -1

        End If

    End Sub

    Private Sub txtsublinea_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            TextBox7.Text = gSubLinea
            TextBox7.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub
End Class