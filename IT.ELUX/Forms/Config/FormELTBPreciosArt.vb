Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBPreciosArt
    Private GUIAALMACENBL As New GUIAALMACENBL
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Sub FormELTBPreciosArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Precio de Articulos"
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente") '6
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '7
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '8
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '9
        Select Case gnOpcion
            Case 1
                flagAccion = "M"
                GetData("SALM", sSDoc, sNDoc)
                'bCuarto = "1"
                'cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable

                dtArticulo = GUIAALMACENBL.getListdgv("SALM", sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows

                Next
        End Select


    End Sub

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()
        Dim mes As String
        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)
        End If
        Select Case sFunc
            Case "exit"
                Dispose()
                contcant = 0
                Exit Sub
            Case "Print"
                gsRptArgs = {}
                ReDim gsRptArgs(2)
                'gsRptArgs(0) = cmbt_doc.SelectedValue
                'gsRptArgs(1) = cmb_serdoc.SelectedItem
                'gsRptArgs(2) = txtnumero.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VALE.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
        End Select
    End Sub

    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim dt As DataTable
        Dim Registro As DataRow
        Dim anulfech As Boolean

        dtUsuario = GUIAALMACENBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            'txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            'cmbt_doc.SelectedValue = txtt_doc.Text
            'cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            'txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            'dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            'anulfech = IIf(IsDBNull(Registro("FEC_ANU")), False, True)

            'If cmbestado.SelectedIndex = 1 Then
            '    dtpfanul.Checked = True
            '    dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            'End If
            ''cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            'txtt_movinv.Text = IIf(IsDBNull(Registro("T_MOVINV")), "", Registro("T_MOVINV"))
            'cmbt_movinv.SelectedValue = txtt_movinv.Text
            'If txtt_movinv.Text = "E19" Then
            '    Me.chk_m.Visible = True
            'End If
            'If IIf(IsDBNull(Registro("X_M")), "", Registro("X_M")) = "1" Then
            '    Me.chk_m.Checked = True
            'End If
            'txtt_pago.Text = IIf(IsDBNull(Registro("F_PAGO_ENT")), "", Registro("F_PAGO_ENT"))
            'cmbt_pago.SelectedValue = txtt_pago.Text
            'txtfor_ent.Text = IIf(IsDBNull(Registro("FOR_ENT_COD")), "", Registro("FOR_ENT_COD"))
            'cmbfor_ent.SelectedValue = txtfor_ent.Text
            'txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            'cmbmon.SelectedValue = txtmon.Text
            'txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            'cmbc_costo.SelectedValue = txtc_costo.Text
            'txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            'cmbdni.SelectedValue = txtdni.Text
            'txtproveedor.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD")) 'ACA VERIFICAR
            'cmbproveedor.SelectedValue = txtproveedor.Text
            'If cmbproveedor.SelectedIndex <> -1 Then
            '    dt = GUIAALMACENBL.SelectDir(txtproveedor.Text)
            '    If dt.Rows.Count > 0 Then
            '        GetCmb("dir_cod", "nom_dir", dt, cmbdir)

            '    End If
            'End If
            'txtdir.Text = IIf(IsDBNull(Registro("DIR_COD")), "", Registro("DIR_COD"))
            'cmbdir.SelectedValue = txtdir.Text
            'cmbturno.Text = IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO"))
            'txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
        Next
    End Sub

End Class