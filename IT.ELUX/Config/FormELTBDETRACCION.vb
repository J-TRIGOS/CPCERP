Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBDETRACCION
    Private ELTBDETRACCIONBL As New ELTBDETRACCIONBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private bPrimero As Boolean = True
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region
    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRefDet
        frm.ShowDialog()
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ELTBDETRACCIONBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
        For Each Registro In dtUsuario.Rows
            dtpfecha.Value = CDate(IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE")))
            txtt_doc.Text = "DET"
            cmbt_doc.SelectedIndex = 0
            cmb_serdoc.Text = sSDoc
            txtnumero.Text = sNDoc
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "A" Then
                cmbestado.SelectedIndex = 1
            End If
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
        Next
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
        Dim dtUsuario As DataTable
        Dim ELTBDETRACCIONBE As New ELTBDETRACCIONBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBDETDETRACCIONBE As New ELTBDETDETRACCIONBE
        ELTBDETRACCIONBE.T_DOC_REF = txtt_doc.Text
        ELTBDETRACCIONBE.SER_DOC_REF = cmb_serdoc.Text
        ELTBDETRACCIONBE.NRO_DOC_REF = txtnumero.Text
        ELTBDETRACCIONBE.FEC_GENE = dtpfecha.Value
        If cmbestado.SelectedIndex = 0 Then
            ELTBDETRACCIONBE.EST = "H"
        Else
            ELTBDETRACCIONBE.EST = "A"
        End If
        If ELTBDETRACCIONBE.EST = "A" Then
            dtpfanul.Checked = True
            ELTBDETRACCIONBE.FEC_ANU = dtpfanul.Value
        End If
        ELMVLOGSBE.log_codusu = gsCodUsr
        'PROVISIONESBE.CTA_CBCO = dgvt_doc.Rows(0).Cells("CTA_CBCO").Value
        gsError = ELTBDETRACCIONBL.SaveRow(ELTBDETRACCIONBE, ELTBDETDETRACCIONBE, flagAccion, ELMVLOGSBE, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            flagAccion = "M"
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormELTBDETRACCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ingreso de Documentos Proveedor/Cliente"
        Me.txtt_doc.Text = sTDoc
        bPrimero = True
        'Me.cmb_serdoc.Text = sSDoc
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("PROVEEDOR", "RUC") '6
        dgvt_doc.Columns.Add("RAZ_SOCIAL", "Raz. Social") '7
        dgvt_doc.Columns.Add("FEC_GENE", "Fec. Gene") '8
        dgvt_doc.Columns.Add("MONTO_PAGADO", "Monto Pagado") '9
        dgvt_doc.Columns.Add("PORC", "Porcentaje") '10
        dgvt_doc.Columns.Add("T_OPE", "T. Operacion") '11
        dgvt_doc.Columns.Add("SERV", "Servicio") '12
        dgvt_doc.Columns.Add("CUENTA", "Cuenta") '13
        dgvt_doc.Columns.Add("TOTAL", "Total") '14

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtt_doc.Text = "DET"
                cmbt_doc.SelectedIndex = 0
                'CleanVar()
                cmb_serdoc.Text = sAño
                txtnumero.Text = (ELTBDETRACCIONBL.SelectNro(txtt_doc.Text, cmb_serdoc.Text)).ToString.PadLeft(7, "0")
                cmbestado.SelectedIndex = 0

            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)

                'bCuarto = "1"
                Dim dtArticulo As DataTable
                'habilitar(True)
                dtArticulo = ELTBDETRACCIONBL.getListdgv(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'6
                                      IIf(IsDBNull(row("RAZ_SOCIAL")), "", row("RAZ_SOCIAL")),'7
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'8
                                      IIf(IsDBNull(row("MONTO_PAGADO")), "", row("MONTO_PAGADO")),'9
                                      IIf(IsDBNull(row("PORC")), "", row("PORC")),'10
                                      IIf(IsDBNull(row("T_OPE")), "", row("T_OPE")),'11
                                      IIf(IsDBNull(row("SERV")), "", row("SERV")),'12
                                      IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),'13
                                      IIf(IsDBNull(row("TOTAL")), "", row("TOTAL"))) '14
                    't_cmb = IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB"))
                Next

                Dim i As Integer
                For i = 0 To 13
                    'If i <> 4 Then
                    dgvt_doc.Columns(i).ReadOnly = True
                    'End If
                Next
                'Label18.Text = dgvt_doc.Rows.Count
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                'Me.btnborrar.Enabled = False
                'Me.btndocu.Enabled = False
                'Me.btnagregar.Enabled = False
        End Select
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        'dgvt_doc.Columns(3).Visible = False
        'dgvt_doc.Columns(4).Visible = False
        'dgvt_doc.Columns(5).Visible = False
        'dgvt_doc.Columns(6).Visible = False
        'dgvt_doc.Columns(7).Visible = False
        dgvt_doc.Columns(8).Visible = False
        dgvt_doc.Columns(11).Visible = False
        dgvt_doc.Columns(12).Visible = False
        dgvt_doc.Columns(13).Visible = False
        dgvt_doc.Columns(14).Visible = False
        bPrimero = False
        btndocu.Select()
    End Sub

    Private Sub FormELTBDETRACCION_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormDetELTBDETRACCION
            frm.txtt_doc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
            frm.txtser_doc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            frm.txtnro.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.txtctct.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PROVEEDOR").Value
            frm.txtnomctct.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("RAZ_SOCIAL").Value
            frm.txtcta.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUENTA").Value
            frm.txtserv.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SERV").Value
            frm.txtnomserv.Text = PROVISIONESBL.SelectDescDetrac(frm.txtserv.Text)
            frm.txtt_ope.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_OPE").Value
            frm.txtnomope.Text = PROVISIONESBL.SelectNomDetra(frm.txtt_ope.Text)
            frm.npdporc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PORC").Value
            frm.txtpago.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTO_PAGADO").Value)
            frm.txttotal.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TOTAL").Value)
            gContador = 0
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = txtt_doc.Text
                    gsRptArgs(1) = cmb_serdoc.Text
                    gsRptArgs(2) = txtnumero.Text
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPT_ELTBDETRACCION.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Case "exportar"
                    Dim frm As New FormDetElect
                    frm.ShowDialog()
            End Select
        Catch ex As Exception
        End Try
    End Sub

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
End Class