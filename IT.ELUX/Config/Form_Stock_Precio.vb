Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class Form_Stock_Precio
    Dim ARTICULOBL As New ARTICULOBL
    Private Sub btndiametro_Click(sender As Object, e As EventArgs) Handles btndiametro.Click
        Cursor.Current = Cursors.WaitCursor
        If OkData() = False Then
            Exit Sub
        Else
            Dim ARTICULOBE As New ARTICULOBE
            ARTICULOBE.fam1 = dtpfecha1.Value.Year & "/" & dtpfecha1.Value.Month.ToString.PadLeft(2, "0") & "/" & dtpfecha1.Value.Day.ToString.PadLeft(2, "0")
            ARTICULOBE.fam2 = dtpfecha2.Value.Year & "/" & dtpfecha2.Value.Month.ToString.PadLeft(2, "0") & "/" & dtpfecha2.Value.Day.ToString.PadLeft(2, "0")
            ARTICULOBE.fam3 = npdaltmax.Text
            ARTICULOBE.precio = npdaltmin.Text
            ARTICULOBE.stkmin = npdaltmax.Text



            gsError = ARTICULOBL.ReporteKardex("stockprecio", ARTICULOBE)
            If gsError = "OK" Then
                MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                'Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If

            'ReDim gsRptArgs(3)
            'gsRptArgs(0) = CDbl(txtaltmin.Text)
            'gsRptArgs(1) = CDbl(txtaltmax.Text)
            'gsRptArgs(2) = dtpfecha1.Value
            'gsRptArgs(3) = dtpfecha2.Value
            'gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\01\RPT01_REPORTE_ARTICULO_PRECIO.rpt"
            'gsRptPath = gsPathRpt
            'FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub btnaltura_Click(sender As Object, e As EventArgs) Handles btnaltura.Click
        If OkData1() = False Then
            Exit Sub
        Else

            ReDim gsRptArgs(7)
            gsRptArgs(0) = CDbl(txtalturamin.Text)
            gsRptArgs(1) = CDbl(txtalturamax.Text)
            gsRptArgs(2) = CDbl(txtlargmin.Text)
            gsRptArgs(3) = CDbl(txtlargmax.Text)
            gsRptArgs(4) = CDbl(txtanchomin.Text)
            gsRptArgs(5) = CDbl(txtalchomax.Text)
            gsRptArgs(6) = dtp2fecha1.Value
            gsRptArgs(7) = dtp2fecha2.Value

            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\01\RPT01_REPORTE_ARTICULO_PRECIO_F.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub Form_Stock_Precio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        dtpfecha1.Value = dtFecha
    End Sub

    Private Sub npdaltmin_LostFocus(sender As Object, e As EventArgs) Handles npdaltmin.LostFocus
        If npdaltmin.Text = "" Then
            npdaltmin.Text = "0.00"
        End If
    End Sub

    Private Sub npdaltmax_LostFocus(sender As Object, e As EventArgs) Handles npdaltmax.LostFocus
        If npdaltmax.Text = "" Then
            npdaltmax.Text = "0.00"
        End If
    End Sub

    Private Function OkData() As Boolean

        If CDbl(txtalturamin.Text) > CDbl(txtalturamax.Text) Then
            MsgBox("La altura minima no puede ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtalturamin.Focus()
            Return False
        End If

        If CDbl(txtlargmin.Text) > CDbl(txtlargmax.Text) Then
            MsgBox("El Largo minimo no puede ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtlargmin.Focus()
            Return False
        End If

        If CDbl(txtanchomin.Text) > CDbl(txtalchomax.Text) Then
            MsgBox("El Ancho minimo no puede ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtanchomin.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function OkData1() As Boolean
        If CDbl(npdaltmin.Text) > CDbl(npdaltmax.Text) Then
            MsgBox("El Alto minimo no puedo ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtanchomin.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        gsRptArgs = {}
        'ReDim gsRptArgs(0)
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_PRECIOART_VEN01.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub


End Class