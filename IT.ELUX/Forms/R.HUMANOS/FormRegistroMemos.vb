Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormRegistroMemos
    Dim MEMOBL As New MEMOBL

    Private Sub txt_codEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codEmp.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_codEmp.Text = gLinea
                txt_nomEmp.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txt_CodSanc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodSanc.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "080302"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_CodSanc.Text = gLinea
                txt_MotSanc.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub FormRegistroMemos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro de Memorándum"
        cmbTipMem.SelectedIndex = -1
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()
            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    flagAccion = "N"
                    SaveData()
                    Exit Sub
                Case "edit"
                    Exit Sub
                Case "Delete"
                    DeleteData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveData()
        Dim resp = MsgBox("Desea Registrar " & cmbTipMem.SelectedItem & " para " & txt_nomEmp.Text, vbYesNo)
        If resp = 7 Then
            Exit Sub
        End If
        Dim MEMOBE As New MEMOBE
        With MEMOBE
            .MES = datFecMem.Value.ToString("MM")
            .ANHO = datFecMem.Value.ToString("yyyy")
            Dim dtNroDoc = MEMOBL.CalcularNroMemo(.MES, .ANHO)
            .NRO_DOC = dtNroDoc.Rows(0).Item(0)
            If Len(.NRO_DOC) = 1 Then
                .NRO_DOC = "00" & .NRO_DOC
            Else
                .NRO_DOC = "0" & .NRO_DOC
            End If
            .PER_COD = txt_codEmp.Text
            .NOM_EMP = txt_nomEmp.Text
            .FEC_GENE = datFecMem.Value.ToString("dd/MM/yyyy")
            .TIPO_MEMO = cmbTipMem.SelectedItem
            .MOT_MEMO = txt_MotSanc.Text
            .FEC_INISUS = datFecIniSus.Value.ToString("dd/MM/yyyy")
            .DIA_SUSP = txt_diasSusp.Text
            .FEC_FALTA = datFecFalta.Value.ToString("dd/MM/yyyy")
            .COD_SANCION = txt_CodSanc.Text
        End With
        gsError = MEMOBL.InsertRowMemo(MEMOBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Memorándum Grabado Correctamente")
            imprimirMemo(MEMOBE)
        End If
    End Sub

    Private Sub imprimirMemo(ByVal MEMOBE As MEMOBE)
        ReDim gsRptArgs(2)
        gsRptArgs(0) = MEMOBE.NRO_DOC
        gsRptArgs(1) = MEMOBE.MES
        gsRptArgs(2) = MEMOBE.ANHO
        Select Case MEMOBE.COD_SANCION
            Case "8807"
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_MEMO_SUSPENSION.rpt"
            Case "8602", "6602"
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_MEMO_LLAMADAATENCION.rpt"
        End Select
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub DeleteData()

    End Sub

    Private Sub FormRegistroMemos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class