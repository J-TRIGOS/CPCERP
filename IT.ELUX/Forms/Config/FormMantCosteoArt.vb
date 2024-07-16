Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantCosteoArt
    Private ELTBCOSTARTBL As New ELTBCOSTARTBL
    Private sM As String = ""
    Private Sub FormMantCosteoArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbmes.Items.Add("Enero")
        cmbmes.Items.Add("Febrero")
        cmbmes.Items.Add("Marzo")
        cmbmes.Items.Add("Abril")
        cmbmes.Items.Add("Mayo")
        cmbmes.Items.Add("Junio")
        cmbmes.Items.Add("Julio")
        cmbmes.Items.Add("Agosto")
        cmbmes.Items.Add("Septiembre")
        cmbmes.Items.Add("Octubre")
        cmbmes.Items.Add("Noviembre")
        cmbmes.Items.Add("Diciembre")
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento1") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie1") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero1") '5
        dgvt_doc.Columns.Add("ART_COD", "Codigo") '6
        dgvt_doc.Columns.Add("NOM_ART", "Descripcion") '7
        dgvt_doc.Columns.Add("PRECIO", "Precio") '8
        dgvt_doc.Columns.Add("MES", "MES") '9
        dgvt_doc.Columns.Add("ANHO", "ANHO") '10
        dgvt_doc.Columns.Add("TIPO", "TIPO") '11
        dgvt_doc.Columns.Add("FEC_DIA", "FEC_DIA") '12

        dgvt_art.Columns.Add("ART_COD", "ART_COD") '0
        If sMes2 = "01" Then
            cmbmes.SelectedIndex = 0
        ElseIf sMes2 = "02" Then
            cmbmes.SelectedIndex = 1
        ElseIf sMes2 = "03" Then
            cmbmes.SelectedIndex = 2
        ElseIf sMes2 = "04" Then
            cmbmes.SelectedIndex = 3
        ElseIf sMes2 = "05" Then
            cmbmes.SelectedIndex = 4
        ElseIf sMes2 = "06" Then
            cmbmes.SelectedIndex = 5
        ElseIf sMes2 = "07" Then
            cmbmes.SelectedIndex = 6
        ElseIf sMes2 = "08" Then
            cmbmes.SelectedIndex = 7
        ElseIf sMes2 = "09" Then
            cmbmes.SelectedIndex = 8
        ElseIf sMes2 = "10" Then
            cmbmes.SelectedIndex = 9
        ElseIf sMes2 = "11" Then
            cmbmes.SelectedIndex = 10
        ElseIf sMes2 = "12" Then
            cmbmes.SelectedIndex = 11
        End If
        sM = sMes2
        cmbaño.Text = sAño

    End Sub

    Private Sub btnprocesar1_Click(sender As Object, e As EventArgs) Handles btnprocesar1.Click
        dgvt_art.Rows.Clear()
        dgvt_doc.Rows.Clear()
        Dim dt As DataTable = ELTBCOSTARTBL.SelectMPSP(cmbaño.Text, sM)
        For Each row As DataRow In dt.Rows
            dgvt_art.Rows.Add(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
        Next
        If dgvt_art.Rows.Count > 0 Then
            ReDim gsRptArgs(1)
            gsRptArgs(0) = RTrim(cmbaño.Text)
            gsRptArgs(1) = RTrim(sM)
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBARTCOST_ARTMP1.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            'MsgBox("No hay articulos sin Precio")
            dt = ELTBCOSTARTBL.SelectMPCP(cmbaño.Text, sM)
            For Each row As DataRow In dt.Rows
                dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                  IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                  IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                  IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                  IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                  IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                  IIf(IsDBNull(row("PRECIO")), "", row("PRECIO")),
                                  IIf(IsDBNull(row("MES")), "", row("MES")),
                                  IIf(IsDBNull(row("ANHO")), "", row("ANHO")),
                                  IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")))
            Next
        End If
        Dim ELTBCOSTARTBE As New ELTBCOSTARTBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELTBCOSTARTBE.ANHO = cmbaño.Text
        ELTBCOSTARTBE.TIPO = "MP"
        ELTBCOSTARTBE.MES = sM
        ELTBCOSTARTBL.SaveRow(ELTBCOSTARTBE, ELMVLOGSBE, "ECOS", dgvt_doc)
        If dgvt_art.Rows.Count = 0 Then
            gsError = ELTBCOSTARTBL.SaveRow(ELTBCOSTARTBE, ELMVLOGSBE, "N", dgvt_doc)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                chkmpins.Enabled = False
                'btnprocesar1.Enabled = False
            End If
        End If

    End Sub

    Private Sub cmbmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmes.SelectedIndexChanged
        If cmbmes.SelectedIndex = 0 Then
            sM = "01"
        ElseIf cmbmes.SelectedIndex = 1 Then
            sM = "02"
        ElseIf cmbmes.SelectedIndex = 2 Then
            sM = "03"
        ElseIf cmbmes.SelectedIndex = 3 Then
            sM = "04"
        ElseIf cmbmes.SelectedIndex = 4 Then
            sM = "05"
        ElseIf cmbmes.SelectedIndex = 5 Then
            sM = "06"
        ElseIf cmbmes.SelectedIndex = 6 Then
            sM = "07"
        ElseIf cmbmes.SelectedIndex = 7 Then
            sM = "08"
        ElseIf cmbmes.SelectedIndex = 8 Then
            sM = "09"
        ElseIf cmbmes.SelectedIndex = 9 Then
            sM = "10"
        ElseIf cmbmes.SelectedIndex = 10 Then
            sM = "11"
        ElseIf cmbmes.SelectedIndex = 11 Then
            sM = "12"
        End If
        If ELTBCOSTARTBL.SelectCMP(cmbaño.Text, sM, "MP") > 0 Then
            chkmpins.Checked = True
            chkmpins.Enabled = False
        End If
    End Sub

    Private Sub FormMantCosteoArt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = RTrim(cmbaño.Text)
        gsRptArgs(1) = RTrim(sM)
        gsRptArgs(2) = RTrim("MP")
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBARTCOST_ARTMP2.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnprocesar2_Click(sender As Object, e As EventArgs) Handles btnprocesar2.Click
        dgvt_art.Rows.Clear()
        dgvt_doc.Rows.Clear()
        Dim dt As DataTable = ELTBCOSTARTBL.SelectMPSP(cmbaño.Text, sM)
        For Each row As DataRow In dt.Rows
            dgvt_art.Rows.Add(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
        Next
        If dgvt_art.Rows.Count > 0 Then
            ReDim gsRptArgs(1)
            gsRptArgs(0) = RTrim(cmbaño.Text)
            gsRptArgs(1) = RTrim(sM)
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBARTCOST_ARTMP1.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            'MsgBox("No hay articulos sin Precio")
            dt = ELTBCOSTARTBL.SelectMPCP(cmbaño.Text, sM)
            For Each row As DataRow In dt.Rows
                dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                  IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                  IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                  IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                  IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                  IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),
                                  IIf(IsDBNull(row("PRECIO")), "", row("PRECIO")),
                                  IIf(IsDBNull(row("MES")), "", row("MES")),
                                  IIf(IsDBNull(row("ANHO")), "", row("ANHO")),
                                  IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")))
            Next
        End If
        Dim ELTBCOSTARTBE As New ELTBCOSTARTBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELTBCOSTARTBE.ANHO = cmbaño.Text
        ELTBCOSTARTBE.TIPO = "MP"
        ELTBCOSTARTBE.MES = sM
        ELTBCOSTARTBL.SaveRow(ELTBCOSTARTBE, ELMVLOGSBE, "ECOS", dgvt_doc)
        If dgvt_art.Rows.Count = 0 Then
            gsError = ELTBCOSTARTBL.SaveRow(ELTBCOSTARTBE, ELMVLOGSBE, "N", dgvt_doc)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                chkmpins.Enabled = False
                'btnprocesar1.Enabled = False
            End If
        End If
    End Sub
End Class