Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormELTBPROVVACA
    Private PERBL As New PERBL
    Private ELCONTRATOBL As New ELCONTRATOBL
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "86"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcontrato_prdo1.Text = gLinea
            dtpfec_ini.Value = gArt ' gSubLinea
            'dtpfec_fin.Value = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcontrato_prdo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcontrato_prdo1.Text = gLinea
                dtpfec_ini.Value = gArt
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

    Private Sub txtcontrato_prdo1_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo1.LostFocus
        If txtcontrato_prdo1.Text <> "" Then
            If PERBL.SelectPrdoFecIni(txtcontrato_prdo1.Text).Length <> 0 Then
                dtpfec_ini.Checked = True
                dtpfec_ini.Value = PERBL.SelectPrdoFecIni(txtcontrato_prdo1.Text)
            End If
        Else
            dtpfec_ini.Checked = False
            'txtnom_linea.Text = ""
        End If
    End Sub

    Private Sub FormELTBPROVVACA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvt_doc.Columns.Add("CPTO_COD", "CPTO_COD") '0
        dgvt_doc.Columns.Add("PRDO_COD", "PRDO_COD") '1
        dgvt_doc.Columns.Add("PER_COD", "PER_COD") '2
        dgvt_doc.Columns.Add("CCOSTO_COD", "CCOSTO_COD") '3
        dgvt_doc.Columns.Add("FEC_ING", "FEC_ING") '4
        dgvt_doc.Columns.Add("FEC_ICESE", "FEC_ICESE") '5
        dgvt_doc.Columns.Add("MONTO_MEN_FIJO", "MONTO_MEN_FIJO") '6
        dgvt_doc.Columns.Add("CALC_DIA", "CALC_DIA") '7
        dgvt_doc.Columns.Add("ULT_DIA", "ULT_DIA") '8
        dgvt_doc.Columns.Add("MONTO_PROV", "MONTO_PROV") '9
        dgvt_doc.Columns.Add("MONTO_AJUSTE", "MONTO_AJUSTE") '10
        dgvt_doc.Columns.Add("NVO_MONTO_PROV", "NVO_MONTO_PROV") '11
        dgvt_doc.Columns.Add("PAGO_LIQUI", "PAGO_LIQUI") '12

        dgvt_doc1.Columns.Add("CPTO_COD", "CPTO_COD") '0
        dgvt_doc1.Columns.Add("PRDO_COD", "PRDO_COD") '1
        dgvt_doc1.Columns.Add("PER_COD", "PER_COD") '2
        dgvt_doc1.Columns.Add("CCOSTO_COD", "CCOSTO_COD") '3
        dgvt_doc1.Columns.Add("FEC_ING", "FEC_ING") '4
        dgvt_doc1.Columns.Add("FEC_ICESE", "FEC_ICESE") '5
        dgvt_doc1.Columns.Add("MONTO_MEN_FIJO", "MONTO_MEN_FIJO") '6
        dgvt_doc1.Columns.Add("CALC_DIA", "CALC_DIA") '7
        dgvt_doc1.Columns.Add("ULT_DIA", "ULT_DIA") '8
        dgvt_doc1.Columns.Add("MONTO_PROV", "MONTO_PROV") '9
        dgvt_doc1.Columns.Add("MONTO_AJUSTE", "MONTO_AJUSTE") '10
        dgvt_doc1.Columns.Add("NVO_MONTO_PROV", "NVO_MONTO_PROV") '11
        dgvt_doc1.Columns.Add("PAGO_LIQUI", "PAGO_LIQUI") '12
        dgvt_doc1.Columns.Add("PRDO_ULTIMA_GRATI", "PRDO_ULTIMA_GRATI") '13
        dgvt_doc1.Columns.Add("MONTO_ULT_GRATI", "MONTO_ULT_GRATI") '14
        dgvt_doc1.Columns.Add("COMISION", "COMISION") '14


        dgvt_doc2.Columns.Add("PER_COD", "PER_COD")
        dgvt_doc2.Columns.Add("MONTO", "MONTO")
        dgvt_doc2.Columns.Add("CPTO_COD", "CPTO_COD")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgvt_doc.Rows.Clear()
        dgvt_doc1.Rows.Clear()
        'MsgBox(dtpfec_ini.Value.ToString("yyyyMM"))
        'VACACIONES 
        Dim dtArticulo As DataTable
        dtArticulo = ELCONTRATOBL.SelectDgvProv(dtpfec_ini.Value.ToString("yyyyMM"), txtcontrato_prdo1.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(row("CPTO_COD")), "", row("CPTO_COD")),
                              IIf(IsDBNull(row("PRDO_COD")), "", row("PRDO_COD")),
                              IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                              IIf(IsDBNull(row("CCOSTO_COD")), "", row("CCOSTO_COD")),
                              IIf(IsDBNull(row("FEC_ING")), "", row("FEC_ING")),
                              IIf(IsDBNull(row("FEC_ICESE")), "", row("FEC_ICESE")),
                              IIf(IsDBNull(row("MONTO_MEN_FIJO")), 0, row("MONTO_MEN_FIJO")),
                              IIf(IsDBNull(row("CALC_DIA")), 0, row("CALC_DIA")),
                              IIf(IsDBNull(row("ULT_DIA")), 0, row("ULT_DIA")),
                              IIf(IsDBNull(row("MONTO_PROV")), 0, row("MONTO_PROV")),
                              IIf(IsDBNull(row("MONTO_AJUSTE")), 0, row("MONTO_AJUSTE")),
                              IIf(IsDBNull(row("NVO_MONTO_PROV")), 0, row("NVO_MONTO_PROV")),
                              IIf(IsDBNull(row("PAGO_LIQUI")), 0, row("PAGO_LIQUI")))
        Next
        'LIMPIA
        ELCONTRATOBL.PROGVACA(txtcontrato_prdo1.Text, "E", dgvt_doc)
        'CARGA REPORTE
        ELCONTRATOBL.PROGVACA("", "RPT", dgvt_doc)
        dgvt_doc.Rows.Clear()

        ''CARGA REPORTE CTS
        dtArticulo = ELCONTRATOBL.SelectDgvProvCTS(dtpfec_ini.Value.ToString("yyyyMM"), txtcontrato_prdo1.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc1.Rows.Add(IIf(IsDBNull(row("CPTO_COD")), "", row("CPTO_COD")),
                              IIf(IsDBNull(row("PRDO_COD")), "", row("PRDO_COD")),
                              IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                              IIf(IsDBNull(row("CCOSTO_COD")), "", row("CCOSTO_COD")),
                              IIf(IsDBNull(row("FEC_ING")), "", row("FEC_ING")),
                              IIf(IsDBNull(row("FEC_ICESE")), "", row("FEC_ICESE")),
                              IIf(IsDBNull(row("MONTO_MEN_FIJO")), 0, row("MONTO_MEN_FIJO")),
                              IIf(IsDBNull(row("CALC_DIA")), 0, row("CALC_DIA")),
                              IIf(IsDBNull(row("ULT_DIA")), 0, row("ULT_DIA")),
                              IIf(IsDBNull(row("MONTO_PROV")), 0, row("MONTO_PROV")),
                              IIf(IsDBNull(row("MONTO_AJUSTE")), 0, row("MONTO_AJUSTE")),
                              IIf(IsDBNull(row("NVO_MONTO_PROV")), 0, row("NVO_MONTO_PROV")),
                              IIf(IsDBNull(row("PAGO_LIQUI")), 0, row("PAGO_LIQUI")),
                              IIf(IsDBNull(row("PRDO_ULTIMA_GRATI")), 0, row("PRDO_ULTIMA_GRATI")),
                              IIf(IsDBNull(row("MONTO_ULT_GRATI")), 0, row("MONTO_ULT_GRATI")),
                              IIf(IsDBNull(row("COMISION")), 0, row("COMISION")))
        Next
        'dgvt_doc1.Rows.Clear()
        gsError = ELCONTRATOBL.PROGVACA("", "RPT1", dgvt_doc1)

        dtArticulo = ELCONTRATOBL.SelectDgvProvGra(dtpfec_ini.Value.ToString("yyyyMM"), txtcontrato_prdo1.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(row("CPTO_COD")), "", row("CPTO_COD")),
                              IIf(IsDBNull(row("PRDO_COD")), "", row("PRDO_COD")),
                              IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                              IIf(IsDBNull(row("CCOSTO_COD")), "", row("CCOSTO_COD")),
                              IIf(IsDBNull(row("FEC_ING")), "", row("FEC_ING")),
                              IIf(IsDBNull(row("FEC_ICESE")), "", row("FEC_ICESE")),
                              IIf(IsDBNull(row("MONTO_MEN_FIJO")), 0, row("MONTO_MEN_FIJO")),
                              IIf(IsDBNull(row("CALC_DIA")), 0, row("CALC_DIA")),
                              IIf(IsDBNull(row("ULT_DIA")), 0, row("ULT_DIA")),
                              IIf(IsDBNull(row("MONTO_PROV")), 0, row("MONTO_PROV")),
                              IIf(IsDBNull(row("MONTO_AJUSTE")), 0, row("MONTO_AJUSTE")),
                              IIf(IsDBNull(row("NVO_MONTO_PROV")), 0, row("NVO_MONTO_PROV")),
                              IIf(IsDBNull(row("PAGO_LIQUI")), 0, row("PAGO_LIQUI")))
        Next
        ''CARGA REPORTE
        gsError = ELCONTRATOBL.PROGVACA("", "RPT2", dgvt_doc)
        'COMISION
        dtArticulo = ELCONTRATOBL.SelectComPer(txtcontrato_prdo1.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc2.Rows.Add(IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                              IIf(IsDBNull(row("MONTO")), "", row("MONTO")))
        Next
        gsError = ELCONTRATOBL.PROGVACA(txtcontrato_prdo1.Text, "COM", dgvt_doc2)
        dgvt_doc2.Rows.Clear()
        'PRUEBA
        dtArticulo = ELCONTRATOBL.SelectHorNocPer1(txtcontrato_prdo1.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc2.Rows.Add(IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                              IIf(IsDBNull(row("MONTO")), "", row("MONTO")))
        Next
        gsError = ELCONTRATOBL.PROGVACA(txtcontrato_prdo1.Text, "HEX", dgvt_doc2)
        dgvt_doc2.Rows.Clear()
        'HORAS EXTRAS Y NOCTURNOS
        dtArticulo = ELCONTRATOBL.SelectHorNocPer(txtcontrato_prdo1.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc2.Rows.Add(IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                              IIf(IsDBNull(row("MONTO")), "", row("MONTO")),
                              IIf(IsDBNull(row("CPTO_COD")), "", row("CPTO_COD")))
        Next
        gsError = ELCONTRATOBL.PROGVACA(txtcontrato_prdo1.Text, "HENOC", dgvt_doc2)
        dgvt_doc2.Rows.Clear()
        If gsError = "OK" Then
            MsgBox("Se Inserto Correctamente")
        Else
            FormMain.LblError.Text = gsError
        End If
    End Sub
End Class