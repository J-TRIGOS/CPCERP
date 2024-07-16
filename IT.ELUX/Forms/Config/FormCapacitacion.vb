Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormCapacitacion
    Dim ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Dim ARTICULOBL As New ARTICULOBL
    Dim ELTBEVALUACIONBL As New ELTBEVALUACIONBL
    Dim ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Dim GUIAALMACENBL As New GUIAALMACENBL
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
    Private Sub FormCapacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bprimero = True
        Me.Text = "Reporte Capacitación"

        'Dim dt As DataTable = GUIAALMACENBL.SelectCCosto
        'GetCmb("cod", "nom", dt, cmbc_costo)

        Dim dt As DataTable = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)

        'Dim dt As DataTable = ARTICULOBL.getListcmb13()
        'GetCmb("cod", "nom", dt, cmbc_costo)

        dt = ELTBCAPACITACIONBL.SelectReporte()
        GetCmb("cod", "nom", dt, cmbReporte)
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        dtpfecini.Value = dtFecha
        bprimero = False
        cmbReporte.SelectedIndex = 0
    End Sub

    Private Sub FormCapacitacion_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        sBusAlm = "20"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "121"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gArt <> Nothing And gSubLinea <> Nothing Then
            txtTema.Text = gArt
            txtNomTema.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtTema_TextChanged(sender As Object, e As EventArgs) Handles txtTema.TextChanged
        txtNomTema.Text = ""
        Dim dtUsuario As DataTable
        dtUsuario = ELTBCAPACITACIONBL.SelectTema(txtTema.Text)
        For Each Registro In dtUsuario.Rows
            txtNomTema.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
        Next

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "122"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gArt <> Nothing And gSubLinea <> Nothing Then
            txtactivo.Text = gArt
            txtArticulo.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtactivo_TextChanged(sender As Object, e As EventArgs) Handles txtactivo.TextChanged
        txtArticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gsCode10 = ""
        Dim frm As New FormPerGrupoCapa
        frm.ShowDialog()
        If gArt <> Nothing And gLinea <> Nothing Then
            txtPer.Text = gLinea
            txtPerNom.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
    Private Sub txtPer_LostFocus(sender As Object, e As EventArgs) Handles txtPer.LostFocus
        If txtPer.Text = "" Then
            txtPerNom.Text = ""
            Exit Sub
        End If
        txtPerNom.Text = ELTBEVALUACIONBL.SelectNroDni(txtPer.Text)
        If txtPerNom.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtPer.Text = ""
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
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Try
            txtc_costo.Text = cmbc_costo.SelectedValue
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbReporte.SelectedIndex = -1 Then
            MsgBox("Seleccionar reporte", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        gsRptArgs = {}
        If cmbReporte.SelectedIndex = 1 Then
            ReDim gsRptArgs(9)
        Else
            ReDim gsRptArgs(8)
        End If


        gsRptArgs(0) = Format(dtpfecini.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfecfin.Value, "yyyy/MM/dd")
        If cmbEst.SelectedIndex = -1 Then
            gsRptArgs(2) = ""
        Else
            gsRptArgs(2) = cmbEst.SelectedIndex
        End If
        gsRptArgs(3) = txtactivo.Text
        gsRptArgs(4) = txtTema.Text
        gsRptArgs(5) = txtPer.Text
        gsRptArgs(6) = txtc_costo.Text
        If cmbTipo.SelectedIndex = -1 Then
            gsRptArgs(7) = ""
        Else
            gsRptArgs(7) = cmbTipo.SelectedIndex
        End If

        If cmbnn.SelectedIndex = 1 Then
            gsRptArgs(8) = "21"
        ElseIf cmbnn.SelectedIndex = 2 Then
            gsRptArgs(8) = "20"
        Else
            gsRptArgs(8) = ""
        End If
        If cmbReporte.SelectedIndex = 1 Then
            If CheckBox1.Checked = True Then
                gsRptArgs(9) = 1
            Else
                gsRptArgs(9) = ""
            End If
        End If

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\" & cmbReporte.SelectedValue
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub cmbReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReporte.SelectedIndexChanged
        If cmbReporte.SelectedIndex = 1 Then
            CheckBox1.Visible = True
            CheckBox1.Checked = False
        Else
            CheckBox1.Visible = False
        End If
    End Sub
End Class