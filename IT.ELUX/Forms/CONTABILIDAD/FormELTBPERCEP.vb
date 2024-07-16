Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBPERCEP
    Private ELTBPERCEPBL As New ELTBPERCEPBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub txtctct_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtctct_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "105"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtctct_cod.Text = gLinea
                txtnomctct.Text = gSubLinea
                'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sBusAlm = "105"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtctct_cod.Text = gLinea
            txtnomctct.Text = gSubLinea
            'txtstk.Text = ARTICULOBL.SetStock(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub FormELTBPERCEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttdoc.Text = "41"
        dgvt_doc.Columns.Add("T_DOC_REF", "T_DOC_REF")
        dgvt_doc.Columns.Add("SER_DOC_REF", "SER_DOC_REF")
        dgvt_doc.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF")
        dgvt_doc.Columns.Add("T_DOC_REF1", "T_DOC_REF")
        dgvt_doc.Columns.Add("SER_DOC_REF1", "SER_DOC_REF")
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "NRO_DOC_REF")
        dgvt_doc.Columns.Add("FEC_COMP", "FEC_COMP")
        dgvt_doc.Columns.Add("MONTO", "MONTO")
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                lblndoc.Text = ELTBPERCEPBL.SelectNro(DateTime.Now.ToString("yyyy"))
                cmbaño.SelectedItem = sAño
                cmbmes.SelectedIndex = Month(Date.Today) - 1
            Case 1
                flagAccion = "M"
                lblndoc.Text = sNDoc
                GetData(sNDoc)
                Dim dtArticulo As DataTable
                'habilitar(True)
                dtArticulo = ELTBPERCEPBL.SelectRow(sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),
                                      IIf(IsDBNull(row("FEC_COMP")), "", row("FEC_COMP")),
                                      IIf(IsDBNull(row("MONTO")), 0, row("MONTO")),
                                      IIf(IsDBNull(row("NDOCU")), 0, row("NDOCU")))
                Next
        End Select

        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
    End Sub
    Private Sub GetData(ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ELTBPERCEPBL.SelectRow1(sN_Ref)
        For Each Registro In dtUsuario.Rows
            'txttdoc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            txtsdoc.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtndoc.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            txtmskfecprov.Text = IIf(IsDBNull(Registro("FEC_PERC")), "", Registro("FEC_PERC"))
            npdmonperc.Value = Val(IIf(IsDBNull(Registro("MONPERC")), 0, Registro("MONPERC")))
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            txtnomctct.Text = IIf(IsDBNull(Registro("NOMCTCT")), "", Registro("NOMCTCT"))
            cmbaño.Text = IIf(IsDBNull(Registro("ANHO")), "", Registro("ANHO"))
            cmbmes.SelectedIndex = (IIf(IsDBNull(Registro("MES")), "", Registro("MES")) - 1)
            npdtaza.Value = IIf(IsDBNull(Registro("TAZA")), "", Registro("TAZA"))
        Next
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        If txtctct_cod.TextLength = 0 And txttdoc.TextLength > 0 And txtsdoc.TextLength > 0 And txtndoc.TextLength > 0 Then
            MsgBox("No ah seleccionado ningun proveedor o llenado la cabecera")
            txtnomctct.Text = ""
            Exit Sub
        End If
        Dim frm As New FormDocuRecep
        frm.lblruc.Text = txtctct_cod.Text
        frm.lblaño.Text = Mid(txtmskfecprov.Text, 7, 10)
        frm.ShowDialog()
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
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    Cursor.Current = Cursors.WaitCursor
                    ReDim gsRptArgs(0)
                    gsRptArgs(0) = lblndoc.Text
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTELTBPERCEP_DOC.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveData()
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La factura no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim dtUsuario As DataTable
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBDETPERCEPBE As New ELTBDETPERCEPBE
        Dim ELTBPERCEPBE As New ELTBPERCEPBE
        ELTBPERCEPBE.T_DOC_REF = txttdoc.Text
        ELTBPERCEPBE.SER_DOC_REF = txtsdoc.Text
        ELTBPERCEPBE.NRO_DOC_REF = txtndoc.Text
        ELTBPERCEPBE.FEC_PERC = txtmskfecprov.Text
        ELTBPERCEPBE.MONPERC = npdmonperc.Value
        ELTBPERCEPBE.CTCT_COD = txtctct_cod.Text
        ELTBPERCEPBE.NOMCTCT = txtnomctct.Text
        ELTBPERCEPBE.NDOCU = lblndoc.Text
        ELTBPERCEPBE.ANHO = cmbaño.Text
        ELTBPERCEPBE.MES = cmbmes.SelectedIndex + 1
        ELTBPERCEPBE.TAZA = npdtaza.Value
        If flagAccion = "N" Then
            lblndoc.Text = ELTBPERCEPBL.SelectNro(Mid(txtmskfecprov.Text, 7, 10))
        End If
        gsError = ELTBPERCEPBL.SaveRow(ELTBPERCEPBE, ELTBDETPERCEPBE, flagAccion, ELMVLOGSBE, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            flagAccion = "M"
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormELTBPERCEP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtctct_cod_LostFocus(sender As Object, e As EventArgs) Handles txtctct_cod.LostFocus
        If txtctct_cod.TextLength > 0 Then
            If PROVISIONESBL.SelectT_Prov(txtctct_cod.Text).Length = 0 Then
                txtnomctct.Text = ""
            Else
                txtnomctct.Text = PROVISIONESBL.SelectT_Prov(txtctct_cod.Text)
            End If

        Else
            txtnomctct.Text = ""
        End If
    End Sub

    Private Function OkData() As Boolean

        If txttdoc.Text = "" Then
            MsgBox("Ingrese descripcion el Tipo de Documento", MsgBoxStyle.Exclamation)
            txtctct_cod.Focus()
            Return False
        End If
        If txtndoc.Text = "" Then
            MsgBox("Ingrese el numero del Documento", MsgBoxStyle.Exclamation)
            txtndoc.Focus()
            Return False
        End If
        If txtsdoc.Text = "" Then
            MsgBox("Ingrese el numero del Documento", MsgBoxStyle.Exclamation)
            txtsdoc.Focus()
            Return False
        End If
        If txtctct_cod.Text = "" Then
            MsgBox("Ingrese el proveedor del Documento", MsgBoxStyle.Exclamation)
            txtctct_cod.Focus()
            Return False
        End If
        If npdmonperc.Value = 0 Then
            MsgBox("Ingrese el monto de la percepcion", MsgBoxStyle.Exclamation)
            txtctct_cod.Focus()
            Return False
        End If

        Return True
    End Function
End Class