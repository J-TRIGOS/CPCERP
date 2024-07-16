Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormSolmOrden
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private ELTBUSERBL As New ELTBUSERBL
    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private ARTICULOBL As New ARTICULOBL
    Private nu As String = ""
    Dim nrosolm() As String
    Dim nrosolm1 As String
    Dim sersolm() As String
    Dim sersolm1 As String
    Dim artcod() As String
    Dim art_cod As String
    Private Sub SaveData()
        Dim num As String = ""
        Dim ar As String = ""
        Dim dtComp As New DataTable
        Dim c As Integer = 0
        Dim dgv As DataGridView
        Dim a As Integer = 0
        Dim SOLMATERIALESBE As New SOLMATERIALESBE
        Dim ELTBDETSOLMATERIALESBE As New ELTBDETSOLMATERIALESBE
        Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
        Dim nro As String = ""
        nrosolm = Nothing
        sersolm = Nothing
        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked Then
                dgvt_doc.Rows.Clear()
                c = c + 1
                dtComp = ARTICULOBL.getListdgv3(lvbusqueda.Items(i).SubItems(0).Text)
                If dtComp.Rows.Count > 0 Then
                    If (lvbusqueda.Items(i).SubItems(9).Text).Length > 0 And
                       (lvbusqueda.Items(i).SubItems(10).Text).Length > 0 Then
                        sersolm1 = lvbusqueda.Items(i).SubItems(9).Text & "|" & sersolm1
                        nrosolm1 = lvbusqueda.Items(i).SubItems(10).Text & "|" & nrosolm1
                        art_cod = art_cod & "|" & lvbusqueda.Items(i).SubItems(0).Text
                    End If
                Else
                    MsgBox("Este Articulo: " + lvbusqueda.Items(i).SubItems(0).Text + "no tiene Explosion Verifique")
                    Exit Sub
                End If
            End If
        Next
        If nrosolm1 <> "" Then
            nrosolm = nrosolm1.Split("|")
            sersolm = sersolm1.Split("|")
        End If

        Dim c1 As Integer = 0
        If nrosolm1 <> "" Then
            For i = 0 To sersolm.Count - 2
                If dgvsolm.Rows.Count = 0 Then
                    dgvsolm.Rows.Add(sersolm(i), nrosolm(i))
                Else
                    c1 = 0
                    For j = 0 To dgvsolm.Rows.Count - 1
                        If nrosolm(i) = dgvsolm.Rows(j).Cells("NSOLM").Value Then
                            c1 = c1 + 1
                        End If
                    Next
                    If c1 = 0 Then
                        dgvsolm.Rows.Add(sersolm(i), nrosolm(i))
                    End If

                End If
            Next
        End If
        For i = 0 To dgvsolm.Rows.Count - 1
            gsRptArgs = {}
            ReDim gsRptArgs(1)
            gsRptArgs(0) = dgvsolm.Rows(i).Cells("SSOLM").Value
            gsRptArgs(1) = dgvsolm.Rows(i).Cells("NSOLM").Value
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLM1.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Next

        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked Then
                If (lvbusqueda.Items(i).SubItems(9).Text).Length = 0 And
                  (lvbusqueda.Items(i).SubItems(10).Text).Length = 0 Then
                    'dgvt_doc.Rows.Clear()
                    dtComp = ARTICULOBL.getListdgv3(lvbusqueda.Items(i).SubItems(0).Text)
                    For j = 0 To dtComp.Rows.Count - 1
                        If dtComp.Rows(j).Item(3) = "1" Then
                            dgvt_doc.Rows.Add(lvbusqueda.Items(i).SubItems(7).Text, lvbusqueda.Items(i).SubItems(8).Text, Mid(dtComp.Rows(j).Item(1), 1, 8), lvbusqueda.Items(i).SubItems(2).Text * dtComp.Rows(j).Item(2), dtComp.Rows(j).Item(4))
                        End If
                    Next
                End If
            End If
        Next

        If dgvt_doc.Rows.Count > 0 Then
            If MessageBox.Show("Desea grabar el Registro",
                                         Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                dgvt_doc.Rows.Clear()
                Exit Sub
            End If
            Try
                nro = SOLMATERIALESBL.SelectNro("SOLM", "001")
                num = nro.PadLeft(7, "0")
                SOLMATERIALESBE.T_DOC_REF = "SOLM"
                SOLMATERIALESBE.SER_DOC_REF = "001"
                SOLMATERIALESBE.NRO_DOC_REF = num
                SOLMATERIALESBE.FEC_GENE = Date.Now.ToString("yyyy/MM/dd")
                SOLMATERIALESBE.NRO_ORDEN = lblndoc.Text 'lvbusqueda.Items(0).SubItems(3).Text
                SOLMATERIALESBE.SER_ORDEN = lblsdoc.Text 'Date.Now.ToString("yyyy")
                SOLMATERIALESBE.EST = "H"
                SOLMATERIALESBE.FEC_ANU = Nothing
                SOLMATERIALESBE.OBSERVA = ""
                SOLMATERIALESBE.CCO_COD = lvbusqueda.Items(0).SubItems(4).Text
                SOLMATERIALESBE.USUARIO = Trim(gsCodUsr)
                SOLMATERIALESBE.FEC_DIA = RTrim(DateTime.Now)
                SOLMATERIALESBE.LINEA = lvbusqueda.Items(0).SubItems(5).Text
                SOLMATERIALESBE.USUARIO_SOL = SOLMATERIALESBL.SelectUsuario(gsUser)
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                Dim nvl As String = ELTBUSERBL.SelectUsuNvl(gsCodUsr)
                Dim dg As DataGridView
                'If flagAccion = "N" Then
                gsError = SOLMATERIALESBL.SaveRow1(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, "NN", dgvt_doc, lblsdoc.Text, lblndoc.Text)
                If gsError = "OK" Then
                    For i = 0 To lvbusqueda.Items.Count - 1
                        If lvbusqueda.Items(i).Checked Then
                            If (lvbusqueda.Items(i).SubItems(9).Text).Length = 0 And
                              (lvbusqueda.Items(i).SubItems(10).Text).Length = 0 Then
                                ELPRODUCCIONBE.t_doc_ref = lbltdoc.Text
                                ELPRODUCCIONBE.ser_doc_ref = lblsdoc.Text
                                ELPRODUCCIONBE.nro_doc_ref = lblndoc.Text
                                ELPRODUCCIONBE.cod_art = lvbusqueda.Items(i).SubItems(0).Text 'ELTBDETSOLMATERIALESBE.ART_COD
                                ELPRODUCCIONBE.sdoc = SOLMATERIALESBE.NRO_DOC_REF
                                ELPRODUCCIONBE.ndoc = SOLMATERIALESBE.SER_DOC_REF
                                gsError3 = ELPRODUCCIONBL.SaveRow1(ELPRODUCCIONBE, "")
                            End If
                        End If
                    Next
                    If gsError3 = "OK" Then
                        MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                        'If flagAccion = "N" Then
                        If nvl = "1" Then
                            SOLMATERIALESBE.USUARIO_OB = gsUser
                            SOLMATERIALESBE.USUARIO_VB = gsUser
                            ELMVLOGSBE.log_codusu = gsCodUsr
                            gsError2 = SOLMATERIALESBL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, "AS", dgv)
                            If gsError2 = "OK" Then
                                MsgBox("Solicitud Auto Aprobada por Nivel de Usuario", MsgBoxStyle.Information)
                            Else
                                FormMain.LblError.Text = gsError2
                                MsgBox("Error al Generar la Aprobacion", MsgBoxStyle.Critical)
                            End If
                        End If
                        gsRptArgs = {}
                        ReDim gsRptArgs(1)
                        gsRptArgs(0) = SOLMATERIALESBE.SER_DOC_REF
                        gsRptArgs(1) = SOLMATERIALESBE.NRO_DOC_REF
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLM1.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        For i = 0 To lvbusqueda.Items.Count - 1
                            If lvbusqueda.Items(i).Checked Then
                                If (lvbusqueda.Items(i).SubItems(9).Text).Length = 0 And
                                  (lvbusqueda.Items(i).SubItems(10).Text).Length = 0 Then
                                    lvbusqueda.Items(i).SubItems(9).Text = SOLMATERIALESBE.SER_DOC_REF 'ELTBDETSOLMATERIALESBE.ART_COD
                                    lvbusqueda.Items(i).SubItems(9).Text = SOLMATERIALESBE.NRO_DOC_REF
                                End If
                            End If
                        Next
                        'End If
                    Else
                        FormMain.LblError.Text = gsError3
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = False Then
                    lvbusqueda.Items(i).Checked = True
                End If

            Next
        Else
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    lvbusqueda.Items(i).Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Dim c As Integer = 0
        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked Then
                c = c + 1
            End If
        Next

        If c > 0 Then
            SaveData()
        Else
            MsgBox("No se ah marcado ningun item para generar")
        End If

    End Sub

    Private Sub btnproc_Click(sender As Object, e As EventArgs) Handles btnproc.Click
        Dim c As Integer = 0
        Dim dtComp As New DataTable
        Dim a As String = ""
        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked Then
                c = c + 1
            End If
        Next
        If c > 0 Then
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked Then
                    a = ARTICULOBL.ProcNom(ARTICULOBL.VerProc(lvbusqueda.Items(i).SubItems(0).Text))
                    If Mid(a, 1, 3) = "ENS" Then
                        'If Trim(txtcodproc.Text) = "0001" Then
                        Cursor.Current = Cursors.WaitCursor
                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = lblndoc.Text 'Trim(lvbusqueda.Items(i).SubItems(6).Text)
                        gsRptArgs(1) = lblsdoc.Text
                        gsRptArgs(2) = lvbusqueda.Items(i).SubItems(0).Text
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_ENS1.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        'End If
                    ElseIf Mid(a, 1, 3) = "LIT" Then
                        'If Trim(txtcodproc.Text) = "0025" Then
                        Cursor.Current = Cursors.WaitCursor
                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = lblndoc.Text 'Trim(lvbusqueda.Items(i).SubItems(6).Text)
                        gsRptArgs(1) = lblsdoc.Text
                        gsRptArgs(2) = lvbusqueda.Items(i).SubItems(0).Text
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_LIT1.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        'End If
                    ElseIf Mid(a, 1, 3) = "PRE" Then
                        'If Trim(txtcodproc.Text) = "0026" Then
                        Cursor.Current = Cursors.WaitCursor
                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = lblndoc.Text 'Trim(lvbusqueda.Items(i).SubItems(6).Text)
                        gsRptArgs(1) = lblsdoc.Text
                        gsRptArgs(2) = lvbusqueda.Items(i).SubItems(0).Text
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_TMPPRE1.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        'End If
                    ElseIf Mid(a, 1, 3) = "COR" Then
                        'If Trim(txtcodproc.Text) = "0027" Then
                        Cursor.Current = Cursors.WaitCursor
                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = lblndoc.Text 'Trim(lvbusqueda.Items(i).SubItems(6).Text)
                        gsRptArgs(1) = lblsdoc.Text
                        gsRptArgs(2) = lvbusqueda.Items(i).SubItems(0).Text
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_TMPCOR.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        'End If
                    End If
                End If
            Next
        Else
            MsgBox("No se ah marcado ningun item para generar")
        End If


    End Sub

    Private Sub FormSolmOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvt_doc.Columns.Add("SER_DOC_REF", "SER_DOC_REF")
        dgvt_doc.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF")
        dgvt_doc.Columns.Add("ART_COD", "ART_COD")
        dgvt_doc.Columns.Add("FACTOR", "FACTOR")
        dgvt_doc.Columns.Add("UNIDAD", "UNIDAD")
        'dgvt_doc.Columns.Add("NRO_DOC_REF1", "NRO_DOC_REF1")
        dgvsolm.Columns.Add("SSOLM", "SSOLM")
        dgvsolm.Columns.Add("NSOLM", "NSOLM")
        dgvsolm.Columns.Add("ARTCOD", "ARTCOD")
    End Sub

    Private Sub FormSolmOrden_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click

        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked Then
                Dim frm As New FormRPTSolOrden
                frm.ser = lvbusqueda.Items(i).SubItems(7).Text
                frm.nro = lvbusqueda.Items(i).SubItems(8).Text
                frm.nom_art = lvbusqueda.Items(i).SubItems(1).Text
                frm.cod_art = lvbusqueda.Items(i).SubItems(0).Text
                frm.nro_op = lvbusqueda.Items(i).SubItems(8).Text
                frm.ShowDialog()
            End If
        Next

    End Sub
End Class